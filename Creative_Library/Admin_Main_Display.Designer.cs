
namespace Creative_Library
{
    partial class Admin_Main_Display
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
            this.Book_Add = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BOOKNAME_AMD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AUTHOR_AMD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PUBLISHER_AMD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BOOKNUMBER_AMD = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.USERNAME_AMD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.USERID_AMD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PHONE_AMD = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.INSERT_AMD = new System.Windows.Forms.Button();
            this.UPDATE_AMD = new System.Windows.Forms.Button();
            this.DELETE_AMD = new System.Windows.Forms.Button();
            this.LOAN_AMD = new System.Windows.Forms.Button();
            this.RETURN_AMD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_Add
            // 
            this.Book_Add.Location = new System.Drawing.Point(22, 41);
            this.Book_Add.Name = "Book_Add";
            this.Book_Add.Size = new System.Drawing.Size(168, 32);
            this.Book_Add.TabIndex = 3;
            this.Book_Add.Text = "도서 추가/수정/삭제";
            this.Book_Add.UseVisualStyleBackColor = true;
            this.Book_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 24);
            this.button4.TabIndex = 6;
            this.button4.Text = "회원 관리";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(947, 404);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "도서 대출/반납";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 21);
            this.button2.TabIndex = 10;
            this.button2.Text = "검색";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(595, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(411, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "도서 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "저자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "출판사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "고유 번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(989, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "도서 이름";
            // 
            // BOOKNAME_AMD
            // 
            this.BOOKNAME_AMD.Enabled = false;
            this.BOOKNAME_AMD.Location = new System.Drawing.Point(1052, 165);
            this.BOOKNAME_AMD.Name = "BOOKNAME_AMD";
            this.BOOKNAME_AMD.Size = new System.Drawing.Size(100, 21);
            this.BOOKNAME_AMD.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(989, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "저자";
            // 
            // AUTHOR_AMD
            // 
            this.AUTHOR_AMD.Enabled = false;
            this.AUTHOR_AMD.Location = new System.Drawing.Point(1052, 201);
            this.AUTHOR_AMD.Name = "AUTHOR_AMD";
            this.AUTHOR_AMD.Size = new System.Drawing.Size(100, 21);
            this.AUTHOR_AMD.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(989, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "출판사";
            // 
            // PUBLISHER_AMD
            // 
            this.PUBLISHER_AMD.Enabled = false;
            this.PUBLISHER_AMD.Location = new System.Drawing.Point(1052, 237);
            this.PUBLISHER_AMD.Name = "PUBLISHER_AMD";
            this.PUBLISHER_AMD.Size = new System.Drawing.Size(100, 21);
            this.PUBLISHER_AMD.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(989, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "고유 번호";
            // 
            // BOOKNUMBER_AMD
            // 
            this.BOOKNUMBER_AMD.Enabled = false;
            this.BOOKNUMBER_AMD.Location = new System.Drawing.Point(1052, 129);
            this.BOOKNUMBER_AMD.Name = "BOOKNUMBER_AMD";
            this.BOOKNUMBER_AMD.Size = new System.Drawing.Size(100, 21);
            this.BOOKNUMBER_AMD.TabIndex = 29;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(182, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 24);
            this.button9.TabIndex = 31;
            this.button9.Text = "연체 관리";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(988, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "회원 이름";
            // 
            // USERNAME_AMD
            // 
            this.USERNAME_AMD.Enabled = false;
            this.USERNAME_AMD.Location = new System.Drawing.Point(1050, 269);
            this.USERNAME_AMD.Name = "USERNAME_AMD";
            this.USERNAME_AMD.Size = new System.Drawing.Size(100, 21);
            this.USERNAME_AMD.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(988, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 43;
            this.label14.Text = "아이디";
            // 
            // USERID_AMD
            // 
            this.USERID_AMD.Enabled = false;
            this.USERID_AMD.Location = new System.Drawing.Point(1050, 305);
            this.USERID_AMD.Name = "USERID_AMD";
            this.USERID_AMD.Size = new System.Drawing.Size(100, 21);
            this.USERID_AMD.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(988, 344);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 45;
            this.label15.Text = "전화번호";
            // 
            // PHONE_AMD
            // 
            this.PHONE_AMD.Enabled = false;
            this.PHONE_AMD.Location = new System.Drawing.Point(1050, 341);
            this.PHONE_AMD.Name = "PHONE_AMD";
            this.PHONE_AMD.Size = new System.Drawing.Size(100, 21);
            this.PHONE_AMD.TabIndex = 44;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(22, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 24);
            this.button10.TabIndex = 46;
            this.button10.Text = "도서 관리";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(634, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 20);
            this.comboBox1.TabIndex = 47;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(717, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(77, 20);
            this.comboBox2.TabIndex = 48;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1113, 13);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 37);
            this.button11.TabIndex = 49;
            this.button11.Text = "로그아웃";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // INSERT_AMD
            // 
            this.INSERT_AMD.Enabled = false;
            this.INSERT_AMD.Location = new System.Drawing.Point(975, 391);
            this.INSERT_AMD.Name = "INSERT_AMD";
            this.INSERT_AMD.Size = new System.Drawing.Size(71, 31);
            this.INSERT_AMD.TabIndex = 50;
            this.INSERT_AMD.Text = "추가";
            this.INSERT_AMD.UseVisualStyleBackColor = true;
            this.INSERT_AMD.Click += new System.EventHandler(this.INSERT_AMD_Click);
            // 
            // UPDATE_AMD
            // 
            this.UPDATE_AMD.Enabled = false;
            this.UPDATE_AMD.Location = new System.Drawing.Point(1050, 391);
            this.UPDATE_AMD.Name = "UPDATE_AMD";
            this.UPDATE_AMD.Size = new System.Drawing.Size(70, 31);
            this.UPDATE_AMD.TabIndex = 51;
            this.UPDATE_AMD.Text = "수정";
            this.UPDATE_AMD.UseVisualStyleBackColor = true;
            this.UPDATE_AMD.Click += new System.EventHandler(this.UPDATE_AMD_Click);
            // 
            // DELETE_AMD
            // 
            this.DELETE_AMD.Enabled = false;
            this.DELETE_AMD.Location = new System.Drawing.Point(1126, 391);
            this.DELETE_AMD.Name = "DELETE_AMD";
            this.DELETE_AMD.Size = new System.Drawing.Size(70, 31);
            this.DELETE_AMD.TabIndex = 52;
            this.DELETE_AMD.Text = "삭제";
            this.DELETE_AMD.UseVisualStyleBackColor = true;
            this.DELETE_AMD.Click += new System.EventHandler(this.DELETE_AMD_Click);
            // 
            // LOAN_AMD
            // 
            this.LOAN_AMD.Enabled = false;
            this.LOAN_AMD.Location = new System.Drawing.Point(975, 435);
            this.LOAN_AMD.Name = "LOAN_AMD";
            this.LOAN_AMD.Size = new System.Drawing.Size(106, 31);
            this.LOAN_AMD.TabIndex = 53;
            this.LOAN_AMD.Text = "대출";
            this.LOAN_AMD.UseVisualStyleBackColor = true;
            this.LOAN_AMD.Click += new System.EventHandler(this.LOAN_AMD_Click);
            // 
            // RETURN_AMD
            // 
            this.RETURN_AMD.Enabled = false;
            this.RETURN_AMD.Location = new System.Drawing.Point(1087, 435);
            this.RETURN_AMD.Name = "RETURN_AMD";
            this.RETURN_AMD.Size = new System.Drawing.Size(106, 31);
            this.RETURN_AMD.TabIndex = 54;
            this.RETURN_AMD.Text = "반납";
            this.RETURN_AMD.UseVisualStyleBackColor = true;
            this.RETURN_AMD.Click += new System.EventHandler(this.RETURN_AMD_Click);
            // 
            // Admin_Main_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 534);
            this.Controls.Add(this.RETURN_AMD);
            this.Controls.Add(this.LOAN_AMD);
            this.Controls.Add(this.DELETE_AMD);
            this.Controls.Add(this.UPDATE_AMD);
            this.Controls.Add(this.INSERT_AMD);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PHONE_AMD);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.USERID_AMD);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.USERNAME_AMD);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BOOKNUMBER_AMD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PUBLISHER_AMD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AUTHOR_AMD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BOOKNAME_AMD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Book_Add);
            this.Name = "Admin_Main_Display";
            this.Text = "Admin_Main_Display";
            this.Load += new System.EventHandler(this.Admin_Main_Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Book_Add;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BOOKNAME_AMD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AUTHOR_AMD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PUBLISHER_AMD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BOOKNUMBER_AMD;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox USERNAME_AMD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox USERID_AMD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PHONE_AMD;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button INSERT_AMD;
        private System.Windows.Forms.Button UPDATE_AMD;
        private System.Windows.Forms.Button DELETE_AMD;
        private System.Windows.Forms.Button LOAN_AMD;
        private System.Windows.Forms.Button RETURN_AMD;
    }
}