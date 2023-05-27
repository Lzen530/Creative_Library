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
    public partial class Not_User_Search_Book : Form
    {
        public Not_User_Search_Book()
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

        private void Not_User_Search_Book_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private Main_Display MD;
        private void LOGIN_Click(object sender, EventArgs e) // 로그인 화면 이동 버튼
        {
            if (MD == null || MD.IsDisposed) // 인스턴스가 존재하지 않거나 폼이 닫혀있는 경우
            {
                MD = new Main_Display(); // 새로운 Main_Display 폼 인스턴스 생성
            }

            MD.Show();
        }

        private void SEARCH_BOOKNAME_GUEST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 도서명 검색란에서 Enter 키가 눌렸을 때 검색 동작 수행
                SEARCH_GUEST_Click(sender, e);
            }
        }

        private void SEARCH_AUTHOR_GUEST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 저자 검색란에서 Enter 키가 눌렸을 때 검색 동작 수행
                SEARCH_GUEST_Click(sender, e);
            }
        }

        private void SEARCH_PUBLISHER_GUEST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 출판사 검색란에서 Enter 키가 눌렸을 때 검색 동작 수행
                SEARCH_GUEST_Click(sender, e);
            }
        }

        private void SEARCH_BOOKNUMBER_GUEST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 고유번호 검색란에서 Enter 키가 눌렸을 때 검색 동작 수행
                SEARCH_GUEST_Click(sender, e);
            }
        }

        private void SEARCH_GUEST_Click(object sender, EventArgs e) // 도서 검색 버튼
        {
            try
            {
                string bookname = SEARCH_BOOKNAME_GUEST.Text.Trim();
                string author = SEARCH_AUTHOR_GUEST.Text.Trim();
                string publisher = SEARCH_PUBLISHER_GUEST.Text.Trim();
                string booknumber = SEARCH_BOOKNUMBER_GUEST.Text.Trim();

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
                    SearchQuery += $" AND 도서.고유번호 LIKE '%{booknumber}%'";
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
    }
}
