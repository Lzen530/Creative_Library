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
    public partial class User_Main_Display : Form
    {
        public User_Main_Display()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
            }
        }

        private void User_Main_Display_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("책 이름", typeof(string));  // 책 이름
            table.Columns.Add("저자", typeof(string));    // 저자
            table.Columns.Add("출판사", typeof(string)); // 출판사
            table.Columns.Add("번호", typeof(string));    // 고유 번호

            table.Rows.Add("혼자 공부하는 자바스크립트", "윤인성", "한빛미디어", "0001");

            dataGridView1.DataSource = table;
        }
    }
}
