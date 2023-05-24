using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Creative_Library
{
    public partial class Alba_Book_Manage : Form
    {
        public Alba_Book_Manage()
        {
            InitializeComponent();
        }

        string connectionstring = "Server=localhost; Database=회원; Uid=Lzen; Pwd=!fmwps530^^;";


        string UserQuery = "SELECT 이름, 아이디, 전화번호 FROM 회원 WHERE 1=1";
        string BookQuery = "SELECT 도서.고유번호, 도서.도서이름, 도서.저자, 도서.출판사, 대출.대출일, 대출.예정반납일, 대출.연체여부 " +
                           "FROM 도서, 대출 " +
                           "WHERE 도서.고유번호 = 대출.고유번호 AND 1=1";

        private void LoadDataIntoDataGridView_USER()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(UserQuery, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                dataGridView1.DataSource = datatable;
            }
        }

        private void LoadDataIntoDataGridView_BOOK()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(BookQuery, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                dataGridView2.DataSource = datatable;
            }
        }

        private Book_Loan_Return AlMD;

        private void LOAN_RETURN_AlBM_Click(object sender, EventArgs e)
        {
            if (AlMD == null || AlMD.IsDisposed) // 인스턴스가 존재하지 않거나 폼이 닫혀있는 경우
            {
                AlMD = new Book_Loan_Return(); // 새로운 Alba_Main_Display 폼 인스턴스 생성
            }

            AlMD.Show();
            this.Hide();
        }

        private void USER_SEARCH_AlBM_Click(object sender, EventArgs e)
        {
            try
            {
                string username = SEARCH_USERNAME_AlBM.Text.Trim();
                string userid = SEARCH_USERID_AlBM.Text.Trim();
                string phonenumber = SEARCH_PHONENUMBER_AlBM.Text.Trim();

                string SearchQuery = "SELECT 이름, 아이디, 전화번호 FROM 회원 WHERE 1=1";

                if (!string.IsNullOrEmpty(username))
                {
                    SearchQuery += $" AND 회원.이름 LIKE '%{username}%'";
                }

                if (!string.IsNullOrEmpty(userid))
                {
                    SearchQuery += $" AND 회원.아이디 LIKE '%{userid}%'";
                }

                if (!string.IsNullOrEmpty(phonenumber))
                {
                    SearchQuery += $" AND 회원.전화번호 LIKE '%{phonenumber}%'";
                }

                UserQuery = SearchQuery;

                // 데이터그리드뷰 업데이트
                LoadDataIntoDataGridView_USER();
            }
            catch (Exception ex)
            {
                MessageBox.Show("검색중 오류가 발생했습니다." + ex.Message);
            }

            LoadDataIntoDataGridView_USER();
        }

        private void BOOK_SEARCH_AlBM_Click(object sender, EventArgs e)
        {
            try
            {
                string bookname = SEARCH_BOOKNAME_AlBM.Text.Trim();
                string author = SEARCH_AUTHOR_AlBM.Text.Trim();
                string publisher = SEARCH_PUBLISHER_AlBM.Text.Trim();
                string booknumber = SEARCH_BOOKNUMBER_AlBM.Text.Trim();

                string SearchQuery = "SELECT 도서.고유번호, 도서.도서이름, 도서.저자, 도서.출판사, 대출.대출일, 대출.예정반납일 " +
                                     "FROM 도서, 대출 " +
                                     "WHERE 도서.고유번호 = 대출.고유번호";

                if (!string.IsNullOrEmpty(bookname))
                {
                    SearchQuery += $" AND 도서.도서이름 LIKE '%{bookname}%'";
                }

                if (!string.IsNullOrEmpty(author))
                {
                    SearchQuery += $" AND 도서.저자 LIKE '%{author}%'";
                }

                if (!string.IsNullOrEmpty(publisher))
                {
                    SearchQuery += $" AND 도서.출판사 LIKE '%{publisher}%'";
                }

                if (!string.IsNullOrEmpty(booknumber))
                {
                    SearchQuery += $" AND 도서.고유번호 = '{booknumber}'";
                }

                BookQuery = SearchQuery;

                // 데이터그리드뷰 업데이트
                LoadDataIntoDataGridView_BOOK();
            }
            catch (Exception ex)
            {
                MessageBox.Show("검색중 오류가 발생했습니다." + ex.Message);
            }

            LoadDataIntoDataGridView_BOOK();
        }

        private void Alba_Book_Manage_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView_BOOK();
            LoadDataIntoDataGridView_USER();
        }
    }
}
