
namespace Creative_Library
{
    partial class User_Manage
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
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loan_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_DELETE = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SEARCH = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UM = new System.Windows.Forms.Button();
            this.AMD = new System.Windows.Forms.Button();
            this.BM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_Name,
            this.User_ID,
            this.Phone_Number,
            this.e_Mail,
            this.Loan_Status,
            this.Return_Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(695, 330);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // User_Name
            // 
            this.User_Name.Frozen = true;
            this.User_Name.HeaderText = "이름";
            this.User_Name.Name = "User_Name";
            this.User_Name.ReadOnly = true;
            // 
            // User_ID
            // 
            this.User_ID.Frozen = true;
            this.User_ID.HeaderText = "아이디";
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
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
            // Loan_Status
            // 
            this.Loan_Status.Frozen = true;
            this.Loan_Status.HeaderText = "대출 현황";
            this.Loan_Status.Name = "Loan_Status";
            this.Loan_Status.ReadOnly = true;
            // 
            // Return_Status
            // 
            this.Return_Status.Frozen = true;
            this.Return_Status.HeaderText = "연체 현황";
            this.Return_Status.Name = "Return_Status";
            this.Return_Status.ReadOnly = true;
            // 
            // User_DELETE
            // 
            this.User_DELETE.Location = new System.Drawing.Point(12, 59);
            this.User_DELETE.Name = "User_DELETE";
            this.User_DELETE.Size = new System.Drawing.Size(114, 26);
            this.User_DELETE.TabIndex = 4;
            this.User_DELETE.Text = "회원 삭제";
            this.User_DELETE.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 58;
            this.label9.Text = "메일 주소";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(550, 93);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 56;
            this.label15.Text = "전화번호";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(375, 93);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 21);
            this.textBox15.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(156, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 54;
            this.label14.Text = "아이디";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(203, 93);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 21);
            this.textBox14.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 52;
            this.label13.Text = "회원 이름";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(73, 93);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(73, 21);
            this.textBox13.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 26);
            this.button2.TabIndex = 59;
            this.button2.Text = "비밀번호 재설정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SEARCH
            // 
            this.SEARCH.Location = new System.Drawing.Point(656, 90);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(51, 26);
            this.SEARCH.TabIndex = 60;
            this.SEARCH.Text = "검색";
            this.SEARCH.UseVisualStyleBackColor = true;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 62;
            this.label1.Text = "비밀번호";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(650, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(57, 20);
            this.comboBox2.TabIndex = 64;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(587, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 20);
            this.comboBox1.TabIndex = 63;
            // 
            // UM
            // 
            this.UM.Enabled = false;
            this.UM.Location = new System.Drawing.Point(92, 12);
            this.UM.Name = "UM";
            this.UM.Size = new System.Drawing.Size(74, 24);
            this.UM.TabIndex = 65;
            this.UM.Text = "회원 관리";
            this.UM.UseVisualStyleBackColor = true;
            this.UM.Click += new System.EventHandler(this.UM_Click);
            // 
            // AMD
            // 
            this.AMD.Location = new System.Drawing.Point(12, 12);
            this.AMD.Name = "AMD";
            this.AMD.Size = new System.Drawing.Size(74, 24);
            this.AMD.TabIndex = 68;
            this.AMD.Text = "도서 관리";
            this.AMD.UseVisualStyleBackColor = true;
            this.AMD.Click += new System.EventHandler(this.AMD_Click);
            // 
            // BM
            // 
            this.BM.Location = new System.Drawing.Point(172, 12);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(74, 24);
            this.BM.TabIndex = 69;
            this.BM.Text = "연체 관리";
            this.BM.UseVisualStyleBackColor = true;
            this.BM.Click += new System.EventHandler(this.BM_Click);
            // 
            // User_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 475);
            this.Controls.Add(this.BM);
            this.Controls.Add(this.AMD);
            this.Controls.Add(this.UM);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.User_DELETE);
            this.Controls.Add(this.dataGridView1);
            this.Name = "User_Manage";
            this.Text = "User_Manage";
            this.Load += new System.EventHandler(this.User_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button User_DELETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loan_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return_Status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button UM;
        private System.Windows.Forms.Button AMD;
        private System.Windows.Forms.Button BM;
    }
}