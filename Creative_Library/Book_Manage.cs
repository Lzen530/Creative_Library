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
    public partial class Book_Manage : Form
    {
        public Book_Manage()
        {
            InitializeComponent();
        }

        private void Book_Manage_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("책 이름", typeof(string));          // 책 이름
            table.Columns.Add("고유 번호", typeof(string));        // 고유 번호
            table.Columns.Add("대출한 회원 이름", typeof(string));      // 대출한 회원 이름
            table.Columns.Add("연체 여부", typeof(string));         // 연체 여부

            dataGridView1.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User_Manage UM = new User_Manage();
            UM.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin_Main_Display AMD = new Admin_Main_Display();
            AMD.Show();
            this.Hide();
        }
    }
}
