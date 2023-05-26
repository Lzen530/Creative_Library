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
    public partial class Book_Loan_Return : Form
    {
        public Book_Loan_Return()
        {
            InitializeComponent();
        }

        string SqlQuery = "SELECT 도서.고유번호, 도서.도서이름, 도서.저자, 도서.출판사, 대출.대출번호, 회원.이름, 회원.아이디, 대출.대출일, 대출.예정반납일 " +
                          "FROM 대출 " +
                          "INNER JOIN 회원 ON 대출.아이디 = 회원.아이디 " +
                          "RIGHT OUTER JOIN 도서 ON 대출.고유번호 = 도서.고유번호";

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

        private void Book_Loan_Return_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void button9_Click(object sender, EventArgs e) // 연체 관리
        {
            Alba_Book_Manage AlBM = new Alba_Book_Manage();
            AlBM.Show();
            this.Hide();
        }

        private void LOGOUT_LOAN_RETURN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("정말로 로그아웃하시겠습니까?", "로그아웃", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Main_Display MD = new Main_Display();
                MD.Show();
                this.Hide();
            }
        }

        private void LOAN_LOAN_RETURN_Click(object sender, EventArgs e) // 도서 대출 버튼
        {
            // 1. 고유번호를 지정할 시, 고유번호, 도서이름, 저자, 출판사가 모두 지정.
            // 2. INSERT(추가) 로 회원이름, 아이디, 대출일자를 추가.
            //    - 회원이름, 아이디가 회원 테이블과 일치하는지 확인 후 대출 테이블에
            //      대출번호, 아이디, 대출한 도서의 고유번호, 대출일자, 반납일자를 추가.
            //    - 대출번호는 버튼 클릭시 자동으로 현재 대출 번호가 있는 위치에서 +1 한다.

            // 3. INSERT(추가) 후 도서, 대출, 회원의 테이블을 조인하고 출력해서
            //    고유번호, 도서이름, 저자, 출판사, 대출번호, 회원이름, 아이디, 대출일자, 반납일자가 다시 나오게 한다.
            
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // 1. 선택한 행의 인덱스 가져오기
                    DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];

                    string bookNumber = rowIndex.Cells["고유번호"].Value.ToString();

                    MySqlConnection connection = new MySqlConnection(connectionstring);
                    connection.Open();


                    string userid = USERID_BLR.Text.Trim();
                    string loandate = LOANDATE_BLR.Text.Trim();

                    // 2. 예외 처리
                    // 2-1. 이미 대출한 도서를 또 대출하는 경우


                    // 2-2. 입력한 도서의 정보가 부족할 경우
                    if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(loandate))
                    {
                        MessageBox.Show("전부 입력되지 않았습니다.");
                        return;
                    }

                    // 2-3 입력한 대출일이 올바른 형식으로 입력되지 않은 경우
                    DateTime loanDate;
                    if (!DateTime.TryParse(loandate, out loanDate))
                    {// DateTime 형식으로 변환 시도. 성공시 true 결과는 out으로, 실패시 false.
                        MessageBox.Show("대출일은 2023-01-01 형식으로 입력해주세요.");
                        return;
                    }
                    string LoanDate = loanDate.ToString("yyyy-MM-dd");

                    // 3. 데이터 추가
                    string QueryBook = "INSERT INTO 대출(아이디, 고유번호, 대출일, 예정반납일, 연체여부) VALUES(@Userid, @Booknumber, @Loandate, @Returndate, @delinquency)";
                    MySqlCommand command = new MySqlCommand(QueryBook, connection);


                    DateTime returndate = loanDate.AddDays(14);
                    string returnDate = returndate.ToString("yyyy-MM-dd");

                    command.Parameters.AddWithValue("@Userid", userid);
                    command.Parameters.AddWithValue("@Booknumber", dataGridView1.SelectedRows[0].Cells["고유번호"].Value.ToString());
                    command.Parameters.AddWithValue("@Loandate", LoanDate);
                    command.Parameters.AddWithValue("@Returndate", returnDate);
                    command.Parameters.AddWithValue("@delinquency", "x");

                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show("대출 처리되었습니다.");

                    // 4. 데이터그리드뷰 업데이트
                    LoadDataIntoDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void RETURN_LOAN_RETURN_Click(object sender, EventArgs e) // 도서 반납 버튼
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
                    string QueryLoan = "DELETE FROM 대출 WHERE 고유번호 = @고유번호";

                    using (MySqlConnection connection = new MySqlConnection(connectionstring))
                    {
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(QueryLoan, connection);
                        command.Parameters.AddWithValue("@고유번호", bookNumber);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("반납 처리되었습니다.");

                    // 4. 데이터그리드뷰 업데이트
                    LoadDataIntoDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SEARCH_LOAN_RETURN_Click(object sender, EventArgs e) // 도서 검색 버튼
        {
            try
            {
                string bookname = SEARCH_BOOKNAME_BLR.Text.Trim();
                string author = SEARCH_AUTHOR_BLR.Text.Trim();
                string publisher = SEARCH_PUBLISHER_BLR.Text.Trim();
                string booknumber = SEARCH_BOOKNUMBER_BLR.Text.Trim();

                string SearchQuery = "SELECT 도서.고유번호, 도서.도서이름, 도서.저자, 도서.출판사, 대출.대출번호, 회원.이름, 회원.아이디, 대출.대출일, 대출.예정반납일 " +
                                     "FROM 대출 " +
                                     "INNER JOIN 회원 ON 대출.아이디 = 회원.아이디 " +
                                     "RIGHT OUTER JOIN 도서 ON 대출.고유번호 = 도서.고유번호 WHERE 1=1";

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
    }
}
