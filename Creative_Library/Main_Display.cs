using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Creative_Library;
using MySql.Data.MySqlClient;

namespace Creative_Library
{
    public partial class Main_Display : Form
    {
        public Main_Display()
        {
            InitializeComponent();
        }

        // MySQL 연결 문자열
        string connectionString = "Server=localhost; Database=회원; Uid=Lzen; Pwd=!fmwps530^^;";

        private void BACK_Click(object sender, EventArgs e) // 뒤로가기
        {
            Not_User_Search_Book NUSB = new Not_User_Search_Book();
            NUSB.Show();
            this.Hide();
        }

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 아이디 입력란에서 Enter 키가 눌렸을 때 로그인 동작 수행
                LOGIN_Click(sender, e);
            }
        }

        private void PW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 비밀번호 입력란에서 Enter 키가 눌렸을 때 로그인 동작 수행
                LOGIN_Click(sender, e);
            }
        }

        private void LOGIN_Click(object sender, EventArgs e) // 로그인
        {
            string id = ID.Text.Trim();
            string pw = PW.Text.Trim();

            // 로그인의 조건
            // 회원가입시 사용했던 아이디를 사용한다.
            // 회원가입시 사용했던 아이디의 비밀번호를 사용한다.

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pw))
            {   //   아이디가 비어있다면.       비밀번호가 비어있다면.
                MessageBox.Show("모든 항목을 입력해주세요.");
                return;
            }

            try
            {
                // MySqlConnection 개체 생성
                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                int login_status = 0;
                string Role = "";

                string query = "SELECT * FROM 회원 WHERE 아이디 = @Username";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", id);

                MySqlDataReader userAccount = command.ExecuteReader();

                while (userAccount.Read())
                {
                    if (id == (string)userAccount["아이디"] && pw == (string)userAccount["비밀번호"])
                    {
                        login_status = 1;
                        Role = userAccount["역할"].ToString();
                    }
                }

                connection.Close();

                

                if (login_status == 1)
                {
                    if (Role == "user")
                    {
                        MessageBox.Show("일반 회원으로 로그인되었습니다.");
                        // 일반 사용자인 경우, 사용자 화면으로 이동
                        User_Main_Display UMD = new User_Main_Display(ID.Text);
                        UMD.Location = new Point(0, 0);
                        UMD.Show();
                        this.Hide();
                    }
                    else if (Role == "admin")
                    {
                        MessageBox.Show("관리자로 로그인되었습니다.");
                        // 관리자인 경우, 관리자 화면으로 이동
                        Admin_Main_Display AMD = new Admin_Main_Display();
                        AMD.Location = new Point(0, 0);
                        AMD.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("알바로 로그인되었습니다.");
                        // 알바인 경우, 알바생 화면으로 이동
                        Book_Loan_Return AlMD = new Book_Loan_Return();
                        AlMD.Location = new Point(0, 0);
                        AlMD.Show();
                        this.Hide();
                    }
                }
                else
                {
                    // 로그인 실패
                    MessageBox.Show("잘못된 사용자 이름 또는 비밀번호입니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SIGNUP_Click(object sender, EventArgs e) // 회원가입
        {
            SignUp SU = new SignUp();
            SU.Location = new Point(0, 0);
            SU.Show();
        }
    }
}
