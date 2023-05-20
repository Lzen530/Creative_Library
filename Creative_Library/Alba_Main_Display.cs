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
    public partial class Alba_Main_Display : Form
    {
        public Alba_Main_Display()
        {
            InitializeComponent();
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

        private void button7_Click(object sender, EventArgs e) // 도서 대출 버튼
        {

        }

        private void button8_Click(object sender, EventArgs e) // 도서 반납 버튼
        {

        }

        private void button1_Click(object sender, EventArgs e) // 도서 대출/반납 on off 기능 
        {
            button7.Enabled = !button7.Enabled;
            button8.Enabled = !button8.Enabled;
        }

        private void button3_Click(object sender, EventArgs e)
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
