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

        private void button4_Click(object sender, EventArgs e) // 회원 관리 버튼
        {
            User_Manage UM = new User_Manage();
            UM.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // 도서 추가/수정/삭제 on off 기능
        {
            DELETE_AMD.Enabled = !DELETE_AMD.Enabled;
            INSERT_AMD.Enabled = !INSERT_AMD.Enabled;
            UPDATE_AMD.Enabled = !UPDATE_AMD.Enabled;

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
            LOAN_AMD.Enabled = !LOAN_AMD.Enabled;
            RETURN_AMD.Enabled = !RETURN_AMD.Enabled;

            USERNAME_AMD.Enabled = true;
            USERID_AMD.Enabled = true;
            PHONE_AMD.Enabled = true;

            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            BOOKNAME_AMD.Enabled = button1.Enabled || button2.Enabled;
            AUTHOR_AMD.Enabled = button1.Enabled || button2.Enabled;
            PUBLISHER_AMD.Enabled = button1.Enabled || button2.Enabled;
            BOOKNUMBER_AMD.Enabled = button1.Enabled || button2.Enabled;

            if (!DELETE_AMD.Enabled && !INSERT_AMD.Enabled && !UPDATE_AMD.Enabled && !LOAN_AMD.Enabled && !RETURN_AMD.Enabled)
            {
                BOOKNAME_AMD.Enabled = false;
                AUTHOR_AMD.Enabled = false;
                PUBLISHER_AMD.Enabled = false;
                BOOKNUMBER_AMD.Enabled = false;
            }
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

        private void INSERT_AMD_Click(object sender, EventArgs e) // 추가
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionstring);
                connection.Open();

                string BookName = BOOKNAME_AMD.Text.Trim();
                string Author = AUTHOR_AMD.Text.Trim();
                string Publisher = PUBLISHER_AMD.Text.Trim();
                string BookNumber = BOOKNUMBER_AMD.Text.Trim();

                // 고유번호 중복 예외 처리
                string QueryBookNumber = "SELECT COUNT(*) FROM 도서 WHERE 고유번호 = @BookNumber";

                MySqlCommand command1 = new MySqlCommand(QueryBookNumber, connection);
                command1.Parameters.AddWithValue("@BookNumber", BookNumber);

                int duplicateCount = Convert.ToInt32(command1.ExecuteScalar());

                if (duplicateCount > 0)
                {
                    MessageBox.Show("고유번호가 중복되었습니다.");
                    return;
                }


                if (string.IsNullOrEmpty(BookName) || string.IsNullOrEmpty(Author) || string.IsNullOrEmpty(Publisher) || string.IsNullOrEmpty(BookNumber))
                {
                    MessageBox.Show("추가시킬 도서의 정보가 부족합니다.");
                    return;
                }

                string QueryBook = "INSERT INTO 도서(도서이름, 저자, 출판사, 고유번호) VALUES(@Bookname, @Author, @Publisher, @Booknumber)";
            
                MySqlCommand command = new MySqlCommand(QueryBook, connection);
                command.Parameters.AddWithValue("@Bookname", BookName);
                command.Parameters.AddWithValue("@Author", Author);
                command.Parameters.AddWithValue("@Publisher", Publisher);
                command.Parameters.AddWithValue("@Booknumber", BookNumber);

                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show("도서가 추가되었습니다.");


                LoadDataIntoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UPDATE_AMD_Click(object sender, EventArgs e) // 수정
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // 선택한 행의 인덱스 가져오기
                    DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];

                    // 2. 데이터 가져오기
                    // 바뀌어야할 정보1
                    string bookNumber = rowIndex.Cells["고유번호"].Value.ToString();

                    // 바꿀 정보 4
                    string booknumber = BOOKNUMBER_AMD.Text;
                    string bookname = BOOKNAME_AMD.Text;
                    string author = AUTHOR_AMD.Text;
                    string publisher = PUBLISHER_AMD.Text;

                    // 3. 수정 버튼 이벤트 처리
                    // 가져온 값을 사용하여 데이터 수정 작업 수행 

                    // 4. 예외 처리
                    // 고유번호는 고유한 하나의 정보만을 가질 수 있기에 이미 존재하는 고유번호로 수정하려 시도하면 "이미 존재하는 고유번호입니다." 라는 메시지가 나와야한다.

                    if (string.IsNullOrEmpty(booknumber) || string.IsNullOrEmpty(bookname) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(publisher))
                    {
                        MessageBox.Show("수정할 도서의 정보가 부족합니다.");
                        return;
                    }

                    // 5. 데이터 수정
                    // 예시: 데이터베이스에서 해당 열 값을 수정
                    string query = "UPDATE 도서 SET 고유번호 = @고유번호, 도서이름 = @도서이름, 저자 = @저자, 출판사 = @출판사 WHERE 고유번호 = @bookNumber";

                    using (MySqlConnection connection = new MySqlConnection(connectionstring))
                    {
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@고유번호", booknumber);
                        command.Parameters.AddWithValue("@도서이름", bookname);
                        command.Parameters.AddWithValue("@저자", author);
                        command.Parameters.AddWithValue("@출판사", publisher);
                        command.Parameters.AddWithValue("@bookNumber", bookNumber);

                        command.ExecuteNonQuery();
                    }

                    // 6. 데이터그리드뷰 업데이트
                    // 데이터를 다시 가져와서 데이터그리드뷰에 반영
                    LoadDataIntoDataGridView();
                }
                else
                {
                    MessageBox.Show("수정할 행을 선택해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DELETE_AMD_Click(object sender, EventArgs e) // 삭제
        {

        }

        private void LOAN_AMD_Click(object sender, EventArgs e) // 대출
        {

        }

        private void RETURN_AMD_Click(object sender, EventArgs e) // 반납
        {

        }
    }
}
