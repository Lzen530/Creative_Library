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
    public partial class SignUp : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost; Database=회원; Uid=Lzen; Pwd=!fmwps530^^;");

        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = ID.Text.Trim();
            string pw = PW.Text.Trim();
            string name = NAME.Text.Trim();
            string phone = PHONE.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pw) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("모든 항목을 입력해주세요.");
                return;
            }

            // 비밀번호 유효성 검사
            if (pw.Length < 8 || pw.Length > 32 || !pw.Any(char.IsDigit) || !pw.Any(char.IsLetter) || !pw.Any(char.IsPunctuation))
            {
                MessageBox.Show("비밀번호는 8자 ~ 32자 사이의 영문자, 숫자, 특수문자가 모두 포함되어야 합니다.");
                return;
            }

            // 전화번호 유효성 검사
            if (!phone.StartsWith("010-") || phone.Length != 13 || !phone.Substring(3, 1).Equals("-") || !phone.Substring(8, 1).Equals("-") || !phone.Substring(4, 4).All(char.IsDigit) || !phone.Substring(9, 4).All(char.IsDigit))
            {
                MessageBox.Show("전화번호는 010-0000-0000 형식으로 입력해주세요.");
                return;
            }

            string insertQuery = "INSERT INTO 회원(아이디, 비밀번호, 이름, 전화번호, 역할) VALUES(@Username, @Password, @Name, @Phone, @User)";

            try
            {
                connection.Open();

                string user = "user";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Username", id);
                command.Parameters.AddWithValue("@Password", pw);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@User", user);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 1)
                {
                    MessageBox.Show("성공적으로 가입되었습니다.");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("회원 정보를 다시 확인해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // 지우면 오류
        }
    }
}
