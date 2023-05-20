namespace Creative_Library
{
    partial class Book_Manage
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
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEARCH_USER = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SEARCH_BOOK = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loan_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMD = new System.Windows.Forms.Button();
            this.UM = new System.Windows.Forms.Button();
            this.BM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.User_Name,
            this.Phone_Number,
            this.e_Mail});
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(532, 194);
            this.dataGridView1.TabIndex = 8;
            // 
            // User_ID
            // 
            this.User_ID.Frozen = true;
            this.User_ID.HeaderText = "아이디";
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            // 
            // User_Name
            // 
            this.User_Name.Frozen = true;
            this.User_Name.HeaderText = "회원 이름";
            this.User_Name.Name = "User_Name";
            this.User_Name.ReadOnly = true;
            // 
            // Phone_Number
            // 
            this.Phone_Number.Frozen = true;
            this.Phone_Number.HeaderText = "전화번호";
            this.Phone_Number.Name = "Phone_Number";
            this.Phone_Number.ReadOnly = true;
            // 
            // e_Mail
            // 
            this.e_Mail.Frozen = true;
            this.e_Mail.HeaderText = "메일 주소";
            this.e_Mail.Name = "e_Mail";
            this.e_Mail.ReadOnly = true;
            // 
            // SEARCH_USER
            // 
            this.SEARCH_USER.Location = new System.Drawing.Point(656, 89);
            this.SEARCH_USER.Name = "SEARCH_USER";
            this.SEARCH_USER.Size = new System.Drawing.Size(51, 26);
            this.SEARCH_USER.TabIndex = 79;
            this.SEARCH_USER.Text = "검색";
            this.SEARCH_USER.UseVisualStyleBackColor = true;
            this.SEARCH_USER.Click += new System.EventHandler(this.SEARCH_USER_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 78;
            this.label9.Text = "메일 주소";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(550, 92);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 77;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 76;
            this.label15.Text = "전화번호";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(375, 92);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 21);
            this.textBox15.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(156, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 74;
            this.label14.Text = "아이디";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(203, 92);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 21);
            this.textBox14.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 72;
            this.label13.Text = "회원 이름";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(73, 92);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(73, 21);
            this.textBox13.TabIndex = 71;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(650, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(57, 20);
            this.comboBox2.TabIndex = 81;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(587, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 20);
            this.comboBox1.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 90;
            this.label4.Text = "고유 번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 89;
            this.label3.Text = "출판사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 88;
            this.label2.Text = "저자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 87;
            this.label1.Text = "도서 이름";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(375, 359);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 86;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 359);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 85;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(544, 359);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 84;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 83;
            // 
            // SEARCH_BOOK
            // 
            this.SEARCH_BOOK.Location = new System.Drawing.Point(656, 355);
            this.SEARCH_BOOK.Name = "SEARCH_BOOK";
            this.SEARCH_BOOK.Size = new System.Drawing.Size(51, 26);
            this.SEARCH_BOOK.TabIndex = 82;
            this.SEARCH_BOOK.Text = "검색";
            this.SEARCH_BOOK.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(650, 329);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(57, 20);
            this.comboBox3.TabIndex = 92;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(587, 329);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(57, 20);
            this.comboBox4.TabIndex = 91;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_Name,
            this.Author,
            this.Publisher,
            this.Book_Number,
            this.Loan_Date,
            this.Return_Date});
            this.dataGridView2.Location = new System.Drawing.Point(14, 386);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(750, 234);
            this.dataGridView2.TabIndex = 93;
            // 
            // Book_Name
            // 
            this.Book_Name.Frozen = true;
            this.Book_Name.HeaderText = "도서 이름";
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.ReadOnly = true;
            this.Book_Name.Width = 150;
            // 
            // Author
            // 
            this.Author.Frozen = true;
            this.Author.HeaderText = "저자";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.Frozen = true;
            this.Publisher.HeaderText = "출판사";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // Book_Number
            // 
            this.Book_Number.Frozen = true;
            this.Book_Number.HeaderText = "도서 고유 번호";
            this.Book_Number.Name = "Book_Number";
            this.Book_Number.ReadOnly = true;
            // 
            // Loan_Date
            // 
            this.Loan_Date.Frozen = true;
            this.Loan_Date.HeaderText = "대출 일자";
            this.Loan_Date.Name = "Loan_Date";
            this.Loan_Date.ReadOnly = true;
            this.Loan_Date.Width = 120;
            // 
            // Return_Date
            // 
            this.Return_Date.Frozen = true;
            this.Return_Date.HeaderText = "반납 일자";
            this.Return_Date.Name = "Return_Date";
            this.Return_Date.ReadOnly = true;
            this.Return_Date.Width = 120;
            // 
            // AMD
            // 
            this.AMD.Location = new System.Drawing.Point(14, 12);
            this.AMD.Name = "AMD";
            this.AMD.Size = new System.Drawing.Size(74, 24);
            this.AMD.TabIndex = 94;
            this.AMD.Text = "도서 관리";
            this.AMD.UseVisualStyleBackColor = true;
            this.AMD.Click += new System.EventHandler(this.AMD_Click);
            // 
            // UM
            // 
            this.UM.Location = new System.Drawing.Point(94, 12);
            this.UM.Name = "UM";
            this.UM.Size = new System.Drawing.Size(74, 24);
            this.UM.TabIndex = 95;
            this.UM.Text = "회원 관리";
            this.UM.UseVisualStyleBackColor = true;
            this.UM.Click += new System.EventHandler(this.UM_Click);
            // 
            // BM
            // 
            this.BM.Enabled = false;
            this.BM.Location = new System.Drawing.Point(174, 12);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(74, 24);
            this.BM.TabIndex = 96;
            this.BM.Text = "연체 관리";
            this.BM.UseVisualStyleBackColor = true;
            // 
            // Book_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 637);
            this.Controls.Add(this.BM);
            this.Controls.Add(this.UM);
            this.Controls.Add(this.AMD);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SEARCH_BOOK);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SEARCH_USER);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Book_Manage";
            this.Text = "Book_Manage";
            this.Load += new System.EventHandler(this.Book_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SEARCH_USER;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SEARCH_BOOK;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loan_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return_Date;
        private System.Windows.Forms.Button AMD;
        private System.Windows.Forms.Button UM;
        private System.Windows.Forms.Button BM;
    }
}