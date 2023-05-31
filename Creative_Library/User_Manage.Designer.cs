
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
            this.USER_DELETE = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.USERPHONE_UM = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.USERID_UM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.USERNAME_UM = new System.Windows.Forms.TextBox();
            this.PW_RESET = new System.Windows.Forms.Button();
            this.SEARCH_UM = new System.Windows.Forms.Button();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UM_UM = new System.Windows.Forms.Button();
            this.AMD_UM = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ALBA_CONTROL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // USER_DELETE
            // 
            this.USER_DELETE.Location = new System.Drawing.Point(12, 59);
            this.USER_DELETE.Name = "USER_DELETE";
            this.USER_DELETE.Size = new System.Drawing.Size(114, 26);
            this.USER_DELETE.TabIndex = 4;
            this.USER_DELETE.Text = "회원 삭제";
            this.USER_DELETE.UseVisualStyleBackColor = true;
            this.USER_DELETE.Click += new System.EventHandler(this.USER_DELETE_Click);
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
            // USERPHONE_UM
            // 
            this.USERPHONE_UM.Location = new System.Drawing.Point(375, 93);
            this.USERPHONE_UM.Name = "USERPHONE_UM";
            this.USERPHONE_UM.Size = new System.Drawing.Size(100, 21);
            this.USERPHONE_UM.TabIndex = 55;
            this.USERPHONE_UM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.USERPHONE_UM_KeyDown);
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
            // USERID_UM
            // 
            this.USERID_UM.Location = new System.Drawing.Point(203, 93);
            this.USERID_UM.Name = "USERID_UM";
            this.USERID_UM.Size = new System.Drawing.Size(100, 21);
            this.USERID_UM.TabIndex = 53;
            this.USERID_UM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.USERID_UM_KeyDown);
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
            // USERNAME_UM
            // 
            this.USERNAME_UM.Location = new System.Drawing.Point(73, 93);
            this.USERNAME_UM.Name = "USERNAME_UM";
            this.USERNAME_UM.Size = new System.Drawing.Size(73, 21);
            this.USERNAME_UM.TabIndex = 51;
            this.USERNAME_UM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.USERNAME_UM_KeyDown);
            // 
            // PW_RESET
            // 
            this.PW_RESET.Location = new System.Drawing.Point(593, 58);
            this.PW_RESET.Name = "PW_RESET";
            this.PW_RESET.Size = new System.Drawing.Size(114, 26);
            this.PW_RESET.TabIndex = 59;
            this.PW_RESET.Text = "비밀번호 재설정";
            this.PW_RESET.UseVisualStyleBackColor = true;
            this.PW_RESET.Click += new System.EventHandler(this.PW_RESET_Click);
            // 
            // SEARCH_UM
            // 
            this.SEARCH_UM.Location = new System.Drawing.Point(656, 90);
            this.SEARCH_UM.Name = "SEARCH_UM";
            this.SEARCH_UM.Size = new System.Drawing.Size(51, 26);
            this.SEARCH_UM.TabIndex = 60;
            this.SEARCH_UM.Text = "검색";
            this.SEARCH_UM.UseVisualStyleBackColor = true;
            this.SEARCH_UM.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // PASSWORD
            // 
            this.PASSWORD.Location = new System.Drawing.Point(487, 62);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(100, 21);
            this.PASSWORD.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 62;
            this.label1.Text = "비밀번호";
            // 
            // UM_UM
            // 
            this.UM_UM.Enabled = false;
            this.UM_UM.Location = new System.Drawing.Point(92, 12);
            this.UM_UM.Name = "UM_UM";
            this.UM_UM.Size = new System.Drawing.Size(74, 24);
            this.UM_UM.TabIndex = 65;
            this.UM_UM.Text = "회원 관리";
            this.UM_UM.UseVisualStyleBackColor = true;
            this.UM_UM.Click += new System.EventHandler(this.UM_Click);
            // 
            // AMD_UM
            // 
            this.AMD_UM.Location = new System.Drawing.Point(12, 12);
            this.AMD_UM.Name = "AMD_UM";
            this.AMD_UM.Size = new System.Drawing.Size(74, 24);
            this.AMD_UM.TabIndex = 68;
            this.AMD_UM.Text = "도서 관리";
            this.AMD_UM.UseVisualStyleBackColor = true;
            this.AMD_UM.Click += new System.EventHandler(this.AMD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(692, 343);
            this.dataGridView1.TabIndex = 70;
            // 
            // ALBA_CONTROL
            // 
            this.ALBA_CONTROL.Location = new System.Drawing.Point(141, 58);
            this.ALBA_CONTROL.Name = "ALBA_CONTROL";
            this.ALBA_CONTROL.Size = new System.Drawing.Size(114, 26);
            this.ALBA_CONTROL.TabIndex = 71;
            this.ALBA_CONTROL.Text = "알바 권한부여";
            this.ALBA_CONTROL.UseVisualStyleBackColor = true;
            this.ALBA_CONTROL.Click += new System.EventHandler(this.ALBA_CONTROL_Click);
            // 
            // User_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 475);
            this.Controls.Add(this.ALBA_CONTROL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AMD_UM);
            this.Controls.Add(this.UM_UM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.SEARCH_UM);
            this.Controls.Add(this.PW_RESET);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.USERPHONE_UM);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.USERID_UM);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.USERNAME_UM);
            this.Controls.Add(this.USER_DELETE);
            this.Name = "User_Manage";
            this.Text = "User_Manage";
            this.Load += new System.EventHandler(this.User_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button USER_DELETE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox USERPHONE_UM;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox USERID_UM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox USERNAME_UM;
        private System.Windows.Forms.Button PW_RESET;
        private System.Windows.Forms.Button SEARCH_UM;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UM_UM;
        private System.Windows.Forms.Button AMD_UM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ALBA_CONTROL;
    }
}