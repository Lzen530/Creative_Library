
namespace Creative_Library
{
    partial class Book_Loan_Return
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
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SEARCH_PUBLISHER_BLR = new System.Windows.Forms.TextBox();
            this.SEARCH_AUTHOR_BLR = new System.Windows.Forms.TextBox();
            this.SEARCH_BOOKNUMBER_BLR = new System.Windows.Forms.TextBox();
            this.SEARCH_BOOKNAME_BLR = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.LOANDATE_BLR = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.USERID_BLR = new System.Windows.Forms.TextBox();
            this.LOGOUT_LOAN_RETURN = new System.Windows.Forms.Button();
            this.LOAN_LOAN_RETURN = new System.Windows.Forms.Button();
            this.RETURN_LOAN_RETURN = new System.Windows.Forms.Button();
            this.SEARCH_LOAN_RETURN = new System.Windows.Forms.Button();
            this.LOANMORE_LOAN_RETURN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 17);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 24);
            this.button9.TabIndex = 75;
            this.button9.Text = "연체 관리";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "고유 번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 61;
            this.label3.Text = "출판사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 60;
            this.label2.Text = "저자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 59;
            this.label1.Text = "도서 이름";
            // 
            // SEARCH_PUBLISHER_BLR
            // 
            this.SEARCH_PUBLISHER_BLR.Location = new System.Drawing.Point(411, 85);
            this.SEARCH_PUBLISHER_BLR.Name = "SEARCH_PUBLISHER_BLR";
            this.SEARCH_PUBLISHER_BLR.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_PUBLISHER_BLR.TabIndex = 58;
            this.SEARCH_PUBLISHER_BLR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SEARCH_PUBLISHER_BLR_KeyDown);
            // 
            // SEARCH_AUTHOR_BLR
            // 
            this.SEARCH_AUTHOR_BLR.Location = new System.Drawing.Point(243, 85);
            this.SEARCH_AUTHOR_BLR.Name = "SEARCH_AUTHOR_BLR";
            this.SEARCH_AUTHOR_BLR.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_AUTHOR_BLR.TabIndex = 57;
            this.SEARCH_AUTHOR_BLR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SEARCH_AUTHOR_BLR_KeyDown);
            // 
            // SEARCH_BOOKNUMBER_BLR
            // 
            this.SEARCH_BOOKNUMBER_BLR.Location = new System.Drawing.Point(595, 85);
            this.SEARCH_BOOKNUMBER_BLR.Name = "SEARCH_BOOKNUMBER_BLR";
            this.SEARCH_BOOKNUMBER_BLR.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_BOOKNUMBER_BLR.TabIndex = 56;
            this.SEARCH_BOOKNUMBER_BLR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SEARCH_BOOKNUMBER_BLR_KeyDown);
            // 
            // SEARCH_BOOKNAME_BLR
            // 
            this.SEARCH_BOOKNAME_BLR.Location = new System.Drawing.Point(83, 85);
            this.SEARCH_BOOKNAME_BLR.Name = "SEARCH_BOOKNAME_BLR";
            this.SEARCH_BOOKNAME_BLR.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_BOOKNAME_BLR.TabIndex = 55;
            this.SEARCH_BOOKNAME_BLR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SEARCH_BOOKNAME_BLR_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 404);
            this.dataGridView1.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1114, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 99;
            this.label15.Text = "대출일자";
            // 
            // LOANDATE_BLR
            // 
            this.LOANDATE_BLR.Location = new System.Drawing.Point(1176, 278);
            this.LOANDATE_BLR.Name = "LOANDATE_BLR";
            this.LOANDATE_BLR.Size = new System.Drawing.Size(100, 21);
            this.LOANDATE_BLR.TabIndex = 98;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1114, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 97;
            this.label14.Text = "아이디";
            // 
            // USERID_BLR
            // 
            this.USERID_BLR.Location = new System.Drawing.Point(1176, 242);
            this.USERID_BLR.Name = "USERID_BLR";
            this.USERID_BLR.Size = new System.Drawing.Size(100, 21);
            this.USERID_BLR.TabIndex = 96;
            // 
            // LOGOUT_LOAN_RETURN
            // 
            this.LOGOUT_LOAN_RETURN.Location = new System.Drawing.Point(1246, 12);
            this.LOGOUT_LOAN_RETURN.Name = "LOGOUT_LOAN_RETURN";
            this.LOGOUT_LOAN_RETURN.Size = new System.Drawing.Size(75, 23);
            this.LOGOUT_LOAN_RETURN.TabIndex = 102;
            this.LOGOUT_LOAN_RETURN.Text = "로그아웃";
            this.LOGOUT_LOAN_RETURN.UseVisualStyleBackColor = true;
            this.LOGOUT_LOAN_RETURN.Click += new System.EventHandler(this.LOGOUT_LOAN_RETURN_Click);
            // 
            // LOAN_LOAN_RETURN
            // 
            this.LOAN_LOAN_RETURN.Location = new System.Drawing.Point(1126, 320);
            this.LOAN_LOAN_RETURN.Name = "LOAN_LOAN_RETURN";
            this.LOAN_LOAN_RETURN.Size = new System.Drawing.Size(134, 38);
            this.LOAN_LOAN_RETURN.TabIndex = 103;
            this.LOAN_LOAN_RETURN.Text = "대출";
            this.LOAN_LOAN_RETURN.UseVisualStyleBackColor = true;
            this.LOAN_LOAN_RETURN.Click += new System.EventHandler(this.LOAN_LOAN_RETURN_Click);
            // 
            // RETURN_LOAN_RETURN
            // 
            this.RETURN_LOAN_RETURN.Location = new System.Drawing.Point(1126, 364);
            this.RETURN_LOAN_RETURN.Name = "RETURN_LOAN_RETURN";
            this.RETURN_LOAN_RETURN.Size = new System.Drawing.Size(134, 38);
            this.RETURN_LOAN_RETURN.TabIndex = 104;
            this.RETURN_LOAN_RETURN.Text = "반납";
            this.RETURN_LOAN_RETURN.UseVisualStyleBackColor = true;
            this.RETURN_LOAN_RETURN.Click += new System.EventHandler(this.RETURN_LOAN_RETURN_Click);
            // 
            // SEARCH_LOAN_RETURN
            // 
            this.SEARCH_LOAN_RETURN.Location = new System.Drawing.Point(701, 85);
            this.SEARCH_LOAN_RETURN.Name = "SEARCH_LOAN_RETURN";
            this.SEARCH_LOAN_RETURN.Size = new System.Drawing.Size(93, 21);
            this.SEARCH_LOAN_RETURN.TabIndex = 105;
            this.SEARCH_LOAN_RETURN.Text = "검색";
            this.SEARCH_LOAN_RETURN.UseVisualStyleBackColor = true;
            this.SEARCH_LOAN_RETURN.Click += new System.EventHandler(this.SEARCH_LOAN_RETURN_Click);
            // 
            // LOANMORE_LOAN_RETURN
            // 
            this.LOANMORE_LOAN_RETURN.Location = new System.Drawing.Point(1126, 429);
            this.LOANMORE_LOAN_RETURN.Name = "LOANMORE_LOAN_RETURN";
            this.LOANMORE_LOAN_RETURN.Size = new System.Drawing.Size(134, 38);
            this.LOANMORE_LOAN_RETURN.TabIndex = 106;
            this.LOANMORE_LOAN_RETURN.Text = "대출 연장";
            this.LOANMORE_LOAN_RETURN.UseVisualStyleBackColor = true;
            this.LOANMORE_LOAN_RETURN.Click += new System.EventHandler(this.LOANMORE_LOAN_RETURN_Click);
            // 
            // Book_Loan_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 551);
            this.Controls.Add(this.LOANMORE_LOAN_RETURN);
            this.Controls.Add(this.SEARCH_LOAN_RETURN);
            this.Controls.Add(this.RETURN_LOAN_RETURN);
            this.Controls.Add(this.LOAN_LOAN_RETURN);
            this.Controls.Add(this.LOGOUT_LOAN_RETURN);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LOANDATE_BLR);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.USERID_BLR);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SEARCH_PUBLISHER_BLR);
            this.Controls.Add(this.SEARCH_AUTHOR_BLR);
            this.Controls.Add(this.SEARCH_BOOKNUMBER_BLR);
            this.Controls.Add(this.SEARCH_BOOKNAME_BLR);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Book_Loan_Return";
            this.Text = "Book_Loan_Return";
            this.Load += new System.EventHandler(this.Book_Loan_Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SEARCH_PUBLISHER_BLR;
        private System.Windows.Forms.TextBox SEARCH_AUTHOR_BLR;
        private System.Windows.Forms.TextBox SEARCH_BOOKNUMBER_BLR;
        private System.Windows.Forms.TextBox SEARCH_BOOKNAME_BLR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox LOANDATE_BLR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox USERID_BLR;
        private System.Windows.Forms.Button LOGOUT_LOAN_RETURN;
        private System.Windows.Forms.Button LOAN_LOAN_RETURN;
        private System.Windows.Forms.Button RETURN_LOAN_RETURN;
        private System.Windows.Forms.Button SEARCH_LOAN_RETURN;
        private System.Windows.Forms.Button LOANMORE_LOAN_RETURN;
    }
}