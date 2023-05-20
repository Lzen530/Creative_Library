
namespace Creative_Library
{
    partial class Alba_Book_Manage
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loan_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView2.Location = new System.Drawing.Point(14, 387);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(750, 234);
            this.dataGridView2.TabIndex = 120;
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(650, 330);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(57, 20);
            this.comboBox3.TabIndex = 119;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(587, 330);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(57, 20);
            this.comboBox4.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 117;
            this.label4.Text = "고유 번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 116;
            this.label3.Text = "출판사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 115;
            this.label2.Text = "저자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 114;
            this.label1.Text = "도서 이름";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(375, 360);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 113;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 360);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 112;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(544, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 111;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 110;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 26);
            this.button2.TabIndex = 109;
            this.button2.Text = "검색";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(650, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(57, 20);
            this.comboBox2.TabIndex = 108;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(587, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 20);
            this.comboBox1.TabIndex = 107;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(656, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 26);
            this.button3.TabIndex = 106;
            this.button3.Text = "검색";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 105;
            this.label9.Text = "메일 주소";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(550, 93);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 104;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 103;
            this.label15.Text = "전화번호";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(375, 93);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 21);
            this.textBox15.TabIndex = 102;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(156, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 101;
            this.label14.Text = "아이디";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(203, 93);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 21);
            this.textBox14.TabIndex = 100;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 99;
            this.label13.Text = "회원 이름";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(73, 93);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(73, 21);
            this.textBox13.TabIndex = 98;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 13);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 24);
            this.button10.TabIndex = 97;
            this.button10.Text = "도서 관리";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(92, 13);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 24);
            this.button9.TabIndex = 96;
            this.button9.Text = "연체 관리";
            this.button9.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(532, 194);
            this.dataGridView1.TabIndex = 94;
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
            // Alba_Book_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 653);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Alba_Book_Manage";
            this.Text = "Alba_Book_Manage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loan_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return_Date;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_Mail;
    }
}