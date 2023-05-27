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
        public User_Main_Display(string id)
        {
            InitializeComponent();
            userid = id;
        }
        string userid;

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

        private void User_Main_Display_Load(object sender, EventArgs e)
        {
            // 로그인시 
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();


            string selectquery = "SELECT 대출일, 예정반납일, 연체여부 FROM 대출 WHERE 아이디 = @userid";
            MySqlCommand command = new MySqlCommand(selectquery, connection);
            command.Parameters.AddWithValue("@userid", userid);
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            dataAdapter.Fill(dataTable);


            string delinquencyquery = "SELECT 연체여부 FROM 대출 WHERE 아이디 = @userid";
            MySqlCommand delinquencycommand = new MySqlCommand(delinquencyquery, connection);
            delinquencycommand.Parameters.AddWithValue("@userid", userid);
            string delinquency = "";
            using (MySqlDataReader reader = delinquencycommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    delinquency = reader["연체여부"].ToString();
                }
            }


            string usernamequery = "SELECT 이름 FROM 회원 WHERE 아이디 = @userid";
            MySqlCommand namecommand = new MySqlCommand(usernamequery, connection);
            namecommand.Parameters.AddWithValue("@userid", userid);
            string username = "";
            using (MySqlDataReader reader = namecommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    username = reader["이름"].ToString();
                }
            }


            if (delinquency == "O")
            {
                MessageBox.Show("현재 연체되어있는 도서가 존재합니다.\n반납하지 않을 시 도서의 대출이 불가합니다.");
            }
            else if (delinquency == "X")
            {
                MessageBox.Show(username + "님 환영합니다.");
            }
            else
            {
                MessageBox.Show(username + "님 환영합니다.");
            }

            string username_label = USERNAME_UMD.Text;
            string bookname_label = BOOKNAME_UMD.Text;
            string loandate_label = LOANDATE_UMD.Text;
            string returndate_label = RETURNDATE_UMD.Text;

            // 위에 적어둠
            // string usernamequery = "SELECT 이름 FROM 회원 WHERE 아이디 = @userid";
            // MySqlCommand namecommand = new MySqlCommand(usernamequery, connection);
            // namecommand.Parameters.AddWithValue("@userid", userid);
            using (MySqlDataReader reader = namecommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    username_label = reader["이름"].ToString();
                }
            }

            string mainquery = "SELECT 도서.고유번호, 도서.도서이름, 대출.아이디, 대출.대출일, 대출.예정반납일 , 대출.연체여부 " +
                               "FROM 도서, 대출 " +
                               "WHERE 도서.고유번호 = 대출.고유번호 AND 아이디 = @userid";
            MySqlCommand maincommand = new MySqlCommand(mainquery, connection);
            maincommand.Parameters.AddWithValue("@userid", userid);
            using (MySqlDataReader reader = maincommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    bookname_label = reader["도서이름"].ToString();
                }
            }
            using (MySqlDataReader reader = maincommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    loandate_label = reader["대출일"].ToString();
                }
            }
            using (MySqlDataReader reader = maincommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    returndate_label = reader["예정반납일"].ToString();
                }
            }

            USERNAME_UMD.Text = username_label;
            BOOKNAME_UMD.Text = bookname_label;
            LOANDATE_UMD.Text = loandate_label;
            RETURNDATE_UMD.Text = returndate_label;

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
    }
}
