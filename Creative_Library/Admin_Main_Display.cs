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
    public partial class Admin_Main_Display : Form
    {
        public Admin_Main_Display()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) // 회원 관리 버튼
        {
            User_Manage UM = new User_Manage();
            UM.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // 도서 추가/수정/반납 on off
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

        private void Admin_Main_Display_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e) //도서 검색 버튼
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // 도서 대출/반납 on off
        {
            button7.Enabled = !button7.Enabled;
            button8.Enabled = !button8.Enabled;

            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            textBox5.Enabled = button1.Enabled || button2.Enabled;
            textBox6.Enabled = button1.Enabled || button2.Enabled;
            textBox7.Enabled = button1.Enabled || button2.Enabled;
            textBox8.Enabled = button1.Enabled || button2.Enabled;

            if (!button3.Enabled && !button5.Enabled && !button6.Enabled && !button7.Enabled && !button8.Enabled)
            {
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e) //추가
        {

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

        private void button9_Click(object sender, EventArgs e)
        {
            Book_Manage BM = new Book_Manage();
            BM.Show();
            this.Hide();
        }
    }
}
