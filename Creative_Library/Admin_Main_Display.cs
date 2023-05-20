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
    public partial class Admin_Main_Display : Form
    {
        string SqlQuery = "SELECT 도서.고유번호, 도서.도서이름, 도서.저자, 도서.출판사, 회원.이름, 회원.아이디, 대출.대출일, 대출.예정반납일 " +
                          "FROM 대출 " +
                          "INNER JOIN 회원 ON 대출.아이디 = 회원.아이디 " +
                          "RIGHT OUTER JOIN 도서 ON 대출.고유번호 = 도서.고유번호";
        public Admin_Main_Display()
        {
            InitializeComponent();
        }

        string connectionstring = "Server=localhost; Database=회원; Uid=Lzen; Pwd=!fmwps530^^;";

        private void button4_Click(object sender, EventArgs e) // 회원 관리 버튼
        {
            User_Manage UM = new User_Manage();
            UM.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // 도서 추가/수정/삭제 on off 기능
        {
            button3.Enabled = !button3.Enabled;
            button5.Enabled = !button5.Enabled;
            button6.Enabled = !button6.Enabled;

            UpdateButtonStates();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
               // 잘못 추가함.
               // 근데 이거 삭제하면 오류.
        }
        /*
         *  대출(대출번호, 아이디(외래키), 고유번호(외래키), 대출일, 예정반납일)
            반납기록(대출번호(외래키), 실제반납일)
            회원(아이디, 회원이름, 전화번호, 비밀번호,역할)
            도서(고유번호, 도서이름, 저자, 출판사) 

         */
        private void Admin_Main_Display_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();

            MySqlCommand command = new MySqlCommand(SqlQuery, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);


            dataGridView1.DataSource = datatable;
        }

        private void button2_Click(object sender, EventArgs e) //도서 검색 버튼
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // 도서 대출/반납 on off 기능
        {
            button7.Enabled = !button7.Enabled;
            button8.Enabled = !button8.Enabled;

            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            BOOKNAME_AMD.Enabled = button1.Enabled || button2.Enabled;
            AUTHOR_AMD.Enabled = button1.Enabled || button2.Enabled;
            PUBLISHER_AMD.Enabled = button1.Enabled || button2.Enabled;
            BOOKNUMBER_AMD.Enabled = button1.Enabled || button2.Enabled;

            if (!button3.Enabled && !button5.Enabled && !button6.Enabled && !button7.Enabled && !button8.Enabled)
            {
                BOOKNAME_AMD.Enabled = false;
                AUTHOR_AMD.Enabled = false;
                PUBLISHER_AMD.Enabled = false;
                BOOKNUMBER_AMD.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e) //추가
        {
            string BookName = BOOKNAME_AMD.Text.Trim();
            string Author = AUTHOR_AMD.Text.Trim();
            string Publisher = PUBLISHER_AMD.Text.Trim();
            string BookNumber = BOOKNUMBER_AMD.Text.Trim();

            if (string.IsNullOrEmpty(BookName) || string.IsNullOrEmpty(Author) || string.IsNullOrEmpty(Publisher) || string.IsNullOrEmpty(BookNumber))
            {
                MessageBox.Show("추가시킬 도서의 정보가 부족합니다.");
                return;
            }

            string QueryBook = "INSERT INTO 도서(도서이름, 저자, 출판사, 고유번호) VALUES(@Bookname, @Author, @Publisher, @Booknumber)";

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionstring);
                connection.Open();

                MySqlCommand command = new MySqlCommand(QueryBook, connection);
                command.Parameters.AddWithValue("@Bookname", BookName);
                command.Parameters.AddWithValue("@Author", Author);
                command.Parameters.AddWithValue("@Publisher", Publisher);
                command.Parameters.AddWithValue("@Booknumber", BookNumber);

                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show("도서가 추가되었습니다.");


                command = new MySqlCommand(SqlQuery, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);


                dataGridView1.DataSource = datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e) // 수정
        {

        }

        private void button3_Click(object sender, EventArgs e) // 삭제
        {

        }

        private void button7_Click(object sender, EventArgs e) // 대출
        {

        }

        private void button8_Click(object sender, EventArgs e) // 반납
        {

        }

        private void button9_Click(object sender, EventArgs e) // 연체 관리
        {
            Book_Manage BM = new Book_Manage();
            BM.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 도서 관리 버튼 ( 하지만 비활성화 )
        }

        private void button11_Click(object sender, EventArgs e) // 로그아웃
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
