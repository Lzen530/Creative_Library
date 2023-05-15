using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creative_Library
{
    public partial class Main_Display : Form
    {
        public Main_Display()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = ID.Text;
            string password = PW.Text;

            // 일반 회원용 로그인 처리
            if (username == "user" && password == "1234")
            {
                MessageBox.Show("일반 회원으로 로그인되었습니다.");
                // 일반 회원용 메인 화면으로 이동
                User_Main_Display UMD = new User_Main_Display();
                UMD.Show();
                this.Hide();
            }
            // 관리자용 로그인 처리
            else if (username == "admin" && password == "0000")
            {
                MessageBox.Show("관리자로 로그인되었습니다.");
                // 관리자용 메인 화면으로 이동
                Admin_Main_Display MMD = new Admin_Main_Display();
                MMD.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("잘못된 사용자 이름 또는 비밀번호입니다.");
            }
        }
        private void label3_Click_1(object sender, EventArgs e)
        {
            SignUp SU = new SignUp();
            SU.Show();
        }
    }
}
