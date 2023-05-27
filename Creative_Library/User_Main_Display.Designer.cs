
namespace Creative_Library
{
    partial class User_Main_Display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SEARCH_BOOKNUMBER_UMD = new System.Windows.Forms.TextBox();
            this.SEARCH_PUBLISHER_UMD = new System.Windows.Forms.TextBox();
            this.SEARCH_AUTHOR_UMD = new System.Windows.Forms.TextBox();
            this.SEARCH_BOOKNAME_UMD = new System.Windows.Forms.TextBox();
            this.SEARCH_UMD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BOOKNAME_UMD = new System.Windows.Forms.Label();
            this.LOANDATE_UMD = new System.Windows.Forms.Label();
            this.RETURNDATE_UMD = new System.Windows.Forms.Label();
            this.USERNAME_UMD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(567, 361);
            this.dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(814, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "로그아웃";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "고유 번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "출판사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "저자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "도서 이름";
            // 
            // SEARCH_BOOKNUMBER_UMD
            // 
            this.SEARCH_BOOKNUMBER_UMD.Location = new System.Drawing.Point(582, 12);
            this.SEARCH_BOOKNUMBER_UMD.Name = "SEARCH_BOOKNUMBER_UMD";
            this.SEARCH_BOOKNUMBER_UMD.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_BOOKNUMBER_UMD.TabIndex = 31;
            // 
            // SEARCH_PUBLISHER_UMD
            // 
            this.SEARCH_PUBLISHER_UMD.Location = new System.Drawing.Point(398, 12);
            this.SEARCH_PUBLISHER_UMD.Name = "SEARCH_PUBLISHER_UMD";
            this.SEARCH_PUBLISHER_UMD.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_PUBLISHER_UMD.TabIndex = 30;
            // 
            // SEARCH_AUTHOR_UMD
            // 
            this.SEARCH_AUTHOR_UMD.Location = new System.Drawing.Point(230, 12);
            this.SEARCH_AUTHOR_UMD.Name = "SEARCH_AUTHOR_UMD";
            this.SEARCH_AUTHOR_UMD.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_AUTHOR_UMD.TabIndex = 29;
            // 
            // SEARCH_BOOKNAME_UMD
            // 
            this.SEARCH_BOOKNAME_UMD.Location = new System.Drawing.Point(70, 12);
            this.SEARCH_BOOKNAME_UMD.Name = "SEARCH_BOOKNAME_UMD";
            this.SEARCH_BOOKNAME_UMD.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_BOOKNAME_UMD.TabIndex = 28;
            // 
            // SEARCH_UMD
            // 
            this.SEARCH_UMD.Location = new System.Drawing.Point(688, 8);
            this.SEARCH_UMD.Name = "SEARCH_UMD";
            this.SEARCH_UMD.Size = new System.Drawing.Size(75, 30);
            this.SEARCH_UMD.TabIndex = 37;
            this.SEARCH_UMD.Text = "검색";
            this.SEARCH_UMD.UseVisualStyleBackColor = true;
            this.SEARCH_UMD.Click += new System.EventHandler(this.SEARCH_UMD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "이름 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 12);
            this.label7.TabIndex = 39;
            this.label7.Text = "대여중인 도서 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(662, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 40;
            this.label8.Text = "대출일자 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 41;
            this.label9.Text = "반납일자 : ";
            // 
            // BOOKNAME_UMD
            // 
            this.BOOKNAME_UMD.AutoSize = true;
            this.BOOKNAME_UMD.Location = new System.Drawing.Point(748, 171);
            this.BOOKNAME_UMD.Name = "BOOKNAME_UMD";
            this.BOOKNAME_UMD.Size = new System.Drawing.Size(0, 12);
            this.BOOKNAME_UMD.TabIndex = 43;
            // 
            // LOANDATE_UMD
            // 
            this.LOANDATE_UMD.AutoSize = true;
            this.LOANDATE_UMD.Location = new System.Drawing.Point(748, 196);
            this.LOANDATE_UMD.Name = "LOANDATE_UMD";
            this.LOANDATE_UMD.Size = new System.Drawing.Size(0, 12);
            this.LOANDATE_UMD.TabIndex = 44;
            // 
            // RETURNDATE_UMD
            // 
            this.RETURNDATE_UMD.AutoSize = true;
            this.RETURNDATE_UMD.Location = new System.Drawing.Point(748, 222);
            this.RETURNDATE_UMD.Name = "RETURNDATE_UMD";
            this.RETURNDATE_UMD.Size = new System.Drawing.Size(0, 12);
            this.RETURNDATE_UMD.TabIndex = 45;
            // 
            // USERNAME_UMD
            // 
            this.USERNAME_UMD.AutoSize = true;
            this.USERNAME_UMD.Location = new System.Drawing.Point(748, 146);
            this.USERNAME_UMD.Name = "USERNAME_UMD";
            this.USERNAME_UMD.Size = new System.Drawing.Size(0, 12);
            this.USERNAME_UMD.TabIndex = 46;
            // 
            // User_Main_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 430);
            this.Controls.Add(this.USERNAME_UMD);
            this.Controls.Add(this.RETURNDATE_UMD);
            this.Controls.Add(this.LOANDATE_UMD);
            this.Controls.Add(this.BOOKNAME_UMD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SEARCH_UMD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SEARCH_BOOKNUMBER_UMD);
            this.Controls.Add(this.SEARCH_PUBLISHER_UMD);
            this.Controls.Add(this.SEARCH_AUTHOR_UMD);
            this.Controls.Add(this.SEARCH_BOOKNAME_UMD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "User_Main_Display";
            this.Text = "User_Main_Display";
            this.Load += new System.EventHandler(this.User_Main_Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SEARCH_BOOKNUMBER_UMD;
        private System.Windows.Forms.TextBox SEARCH_PUBLISHER_UMD;
        private System.Windows.Forms.TextBox SEARCH_AUTHOR_UMD;
        private System.Windows.Forms.TextBox SEARCH_BOOKNAME_UMD;
        private System.Windows.Forms.Button SEARCH_UMD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label BOOKNAME_UMD;
        private System.Windows.Forms.Label LOANDATE_UMD;
        private System.Windows.Forms.Label RETURNDATE_UMD;
        private System.Windows.Forms.Label USERNAME_UMD;
    }
}