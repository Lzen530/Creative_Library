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
    public partial class Alba_Book_Manage : Form
    {
        public Alba_Book_Manage()
        {
            InitializeComponent();
        }

        private Book_Loan_Return AlMD;

        private void LOAN_RETURN_AlBM_Click(object sender, EventArgs e)
        {
            if (AlMD == null || AlMD.IsDisposed) // 인스턴스가 존재하지 않거나 폼이 닫혀있는 경우
            {
                AlMD = new Book_Loan_Return(); // 새로운 Alba_Main_Display 폼 인스턴스 생성
            }

            AlMD.Show();
            this.Hide();
        }
    }
}
