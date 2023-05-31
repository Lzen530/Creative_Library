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
        string SqlQuery = "SELECT * FROM 도서";
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

        private void UMD_AMD_Click(object sender, EventArgs e) // 회원 관리 버튼
        {
            User_Manage UM = new User_Manage();
            UM.Show();
            this.Hide();
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
            LoadDataIntoDataGridView();
        }

        private void BOOK_INSERT_UPDATE_DELETE_AMD_Click(object sender, EventArgs e) // 도서 추가/수정/삭제 on off 기능
        {
            BOOKNAME_AMD.Enabled = !BOOKNAME_AMD.Enabled;
            AUTHOR_AMD.Enabled = !AUTHOR_AMD.Enabled;
            PUBLISHER_AMD.Enabled = !PUBLISHER_AMD.Enabled;
            BOOKNUMBER_AMD.Enabled = !BOOKNUMBER_AMD.Enabled;

            DELETE_AMD.Enabled = !DELETE_AMD.Enabled;
            INSERT_AMD.Enabled = !INSERT_AMD.Enabled;
            UPDATE_AMD.Enabled = !UPDATE_AMD.Enabled;
        }

        private void LOGOUT_AMD_Click(object sender, EventArgs e) // 로그아웃
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

                // 1. 데이터 가져오기
                string BookName = BOOKNAME_AMD.Text.Trim();
                string Author = AUTHOR_AMD.Text.Trim();
                string Publisher = PUBLISHER_AMD.Text.Trim();
                string BookNumber = BOOKNUMBER_AMD.Text.Trim();

                // 2. 예외 처리
                // 2-1. 고유번호가 중복될 경우
                string QueryBookNumber = "SELECT COUNT(*) FROM 도서 WHERE 고유번호 = @BookNumber";

                MySqlCommand command1 = new MySqlCommand(QueryBookNumber, connection);
                command1.Parameters.AddWithValue("@BookNumber", BookNumber);

                int duplicateCount = Convert.ToInt32(command1.ExecuteScalar());

                if (duplicateCount > 0)
                {
                    MessageBox.Show("고유번호가 중복되었습니다.");
                    return;
                }

                // 2-2. 입력한 도서의 정보가 부족할 경우
                if (string.IsNullOrEmpty(BookName) || string.IsNullOrEmpty(Author) || string.IsNullOrEmpty(Publisher) || string.IsNullOrEmpty(BookNumber))
                {
                    MessageBox.Show("추가시킬 도서의 정보가 부족합니다.");
                    return;
                }

                // 3. 데이터 추가
                string QueryBook = "INSERT INTO 도서(도서이름, 저자, 출판사, 고유번호) VALUES(@Bookname, @Author, @Publisher, @Booknumber)";
            
                MySqlCommand command = new MySqlCommand(QueryBook, connection);
                command.Parameters.AddWithValue("@Bookname", BookName);
                command.Parameters.AddWithValue("@Author", Author);
                command.Parameters.AddWithValue("@Publisher", Publisher);
                command.Parameters.AddWithValue("@Booknumber", BookNumber);

                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show("도서가 추가되었습니다.");

                // 4. 데이터그리드뷰 업데이트
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
                    // 1. 선택한 행의 인덱스 가져오기
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
                    // 고유번호는 고유한 하나의 정보만을 가질 수 있기에 이미 존재하는 고유번호로 수정하려
                    // 시도하면 "이미 존재하는 고유번호입니다." 라는 메시지가 나와야한다.

                    if (bookNumber == booknumber)
                    {
                        string QueryBookNumber = "SELECT count(*) FROM 도서 WHERE 고유번호 = @booknumber";

                        using (MySqlConnection connection = new MySqlConnection(connectionstring))
                        {
                            connection.Open();

                            MySqlCommand command1 = new MySqlCommand(QueryBookNumber, connection);
                            command1.Parameters.AddWithValue("@BookNumber", booknumber);

                            int duplicateCount = Convert.ToInt32(command1.ExecuteScalar());
                        }
                    }
                    else
                    {
                        MessageBox.Show("이미 존재하는 고유번호입니다.");
                        return;
                    }
                    
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
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // 1. 선택한 행의 인덱스 가져오기
                    DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];

                    // 2. 데이터 가져오기
                    string bookNumber = rowIndex.Cells["고유번호"].Value.ToString();

                    // 3. 삭제 버튼 이벤트 처리
                    // 선택한 행의 데이터를 데이터베이스에서 삭제
                    string query = "DELETE FROM 도서 WHERE 고유번호 = @고유번호";

                    using (MySqlConnection connection = new MySqlConnection(connectionstring))
                    {
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@고유번호", bookNumber);

                        command.ExecuteNonQuery();
                    }

                    // 4. 데이터그리드뷰 업데이트
                    // 데이터를 다시 가져와서 데이터그리드뷰에 반영
                    LoadDataIntoDataGridView();
                }
                else
                {
                    MessageBox.Show("삭제할 행을 선택해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SEARCH_AMD_Click(object sender, EventArgs e) // 도서 검색 버튼
        {
            try
            {
                string bookname = BOOKNAME_SEARCH_AMD.Text.Trim();
                string author = AUTHOR_SEARCH_AMD.Text.Trim();
                string publisher = PUBLISHER_SEARCH_AMD.Text.Trim();
                string booknumber = BOOKNUMBER_SEARCH_AMD.Text.Trim();

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

        private Book_Loan_Return BLR;
        private void LOAN_RETURN_AMD_Click(object sender, EventArgs e) // 임시용 대출/반납 폼 이동 버튼
        {
            if (BLR == null || BLR.IsDisposed) // 인스턴스가 존재하지 않거나 폼이 닫혀있는 경우
            {
                BLR = new Book_Loan_Return(); // 새로운 Main_Display 폼 인스턴스 생성
            }

            BLR.Show();
        }

        private void BOOKNAME_SEARCH_AMD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEARCH_AMD_Click(sender, e);
            }
        }

        private void AUTHOR_SEARCH_AMD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEARCH_AMD_Click(sender, e);
            }
        }

        private void PUBLISHER_SEARCH_AMD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEARCH_AMD_Click(sender, e);
            }
        }

        private void BOOKNUMBER_SEARCH_AMD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEARCH_AMD_Click(sender, e);
            }
        }
    }
}
