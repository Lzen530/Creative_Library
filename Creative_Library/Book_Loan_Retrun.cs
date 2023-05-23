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

        private void button2_Click(object sender, EventArgs e) // 도서 검색 버튼
        {

        }

        private void button8_Click(object sender, EventArgs e) // 도서 반납 버튼
        {

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
        }
    }
}
