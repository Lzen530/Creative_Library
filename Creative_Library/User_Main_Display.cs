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
    public partial class User_Main_Display : Form
    {
        public User_Main_Display()
        {
            InitializeComponent();
        }

        string SqlQuery = "SELECT * FROM 도서";

        string connectionstring = "Server=localhost; Database=회원; Uid=Lzen; Pwd=!fmwps530^^;";

        private void LoadDataIntoDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(SqlQuery, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                dataGridView1.DataSource = datatable;
            }
        }

        private void SEARCH_UMD_Click(object sender, EventArgs e)
        {
            try
            {
                string bookname = SEARCH_BOOKNAME_UMD.Text.Trim();
                string author = SEARCH_AUTHOR_UMD.Text.Trim();
                string publisher = SEARCH_PUBLISHER_UMD.Text.Trim();
                string booknumber = SEARCH_BOOKNUMBER_UMD.Text.Trim();

                string SearchQuery = "SELECT * FROM 도서 WHERE 1=1";

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

                SqlQuery = SearchQuery;

                // 데이터그리드뷰 업데이트
                LoadDataIntoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("검색중 오류가 발생했습니다." + ex.Message);
            }
        }

        private void User_Main_Display_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionstring);
                connection.Open();

                string query = "SELECT 회원.이름, 도서.도서이름, 대출.대출일, 대출.예정반납일 " +
                               "FROM 대출 " +
                               "INNER JOIN 회원 ON 대출.아이디 = 회원.아이디 " +
                               "RIGHT OUTER JOIN 도서 ON 대출.고유번호 = 도서.고유번호 " +
                               "WHERE 회원.아이디 = @username";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", USERNAME_UMD);
                command.Parameters.AddWithValue("@bookname", LOANBOOK_UMD);
                command.Parameters.AddWithValue("@loandate", LOANDATE_UMD);
                command.Parameters.AddWithValue("@returndate", RETURNDATE_UMD);

                string username = command.ExecuteScalar().ToString();
                string bookname = command.ExecuteScalar().ToString();
                string loandate = command.ExecuteScalar().ToString();
                string returndate = command.ExecuteScalar().ToString();

                USERNAME_UMD.Text = username;
                LOANBOOK_UMD.Text = bookname;
                LOANDATE_UMD.Text = loandate;
                RETURNDATE_UMD.Text = returndate;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadDataIntoDataGridView();
        }

        private void button2_Click(object sender, EventArgs e) // 로그아웃
        {
            DialogResult result = MessageBox.Show("정말로 로그아웃하시겠습니까?", "로그아웃", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Main_Display MD = new Main_Display();
                MD.Show();
                this.Hide();
            }
        }

        private void USERNAME_UMD_Click(object sender, EventArgs e)
        {

        }
    }
}
