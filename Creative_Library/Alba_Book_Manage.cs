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

        private void button10_Click(object sender, EventArgs e)
        {
            Alba_Main_Display AlMD = new Alba_Main_Display();
            AlMD.Show();
            this.Hide();
        }
    }
}
