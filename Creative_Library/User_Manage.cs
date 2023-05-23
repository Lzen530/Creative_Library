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
    public partial class User_Manage : Form
    {
        public User_Manage()
        {
            InitializeComponent();
        }

        string connectionstring = "Server=localhost; Database=회원; Uid=Lzen; Pwd=!fmwps530^^;";

        string SqlQuery = "SELECT * FROM 회원";

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

        private void User_Manage_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void AMD_Click(object sender, EventArgs e) // 관리자 메인 화면으로 이동 (도서 관리 화면)
        {
            Admin_Main_Display AMD = new Admin_Main_Display();
            AMD.Show();
            this.Hide();
        }

        private void UM_Click(object sender, EventArgs e) // 회원 관리 버튼
        {
            // 본인 폼을 가리키는 역할이라 비활성화
        }

        private void BM_Click(object sender, EventArgs e)
        {
            Book_Manage BM = new Book_Manage();
            BM.Show();
            this.Hide();
        }

        private void SEARCH_Click(object sender, EventArgs e) // 회원 검색 버튼
        {

        }
    }
}
