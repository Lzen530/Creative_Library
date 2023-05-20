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
    public partial class Not_User_Search_Book : Form
    {
        private Main_Display MD;
        public Not_User_Search_Book()
        {
            InitializeComponent();
        }

        private void SEARCH_Click(object sender, EventArgs e) // 도서 검색 버튼
        {

        }

        private void LOGIN_Click(object sender, EventArgs e) // 로그인 화면 이동 버튼
        {
            if (MD == null || MD.IsDisposed) // 인스턴스가 존재하지 않거나 폼이 닫혀있는 경우
            {
                MD = new Main_Display(); // 새로운 Main_Display 폼 인스턴스 생성
            }

            MD.Show();
        }
    }
}
