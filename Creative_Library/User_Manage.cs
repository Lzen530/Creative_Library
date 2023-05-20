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
    public partial class User_Manage : Form
    {
        public User_Manage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 잘못 추가함.
            // 근데 이거 삭제하면 오류.
        }

        private void User_Manage_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("이름", typeof(string));
            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("비밀번호", typeof(string));
            table.Columns.Add("전화번호", typeof(string));
            table.Columns.Add("메일주소", typeof(string));
            table.Columns.Add("연체 여부", typeof(string));

            dataGridView1.DataSource = table;
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
