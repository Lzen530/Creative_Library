
namespace Creative_Library
{
    partial class Not_User_Search_Book
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SEARCH_BOOKNUMBER_GUEST = new System.Windows.Forms.TextBox();
            this.SEARCH_PUBLISHER_GUEST = new System.Windows.Forms.TextBox();
            this.SEARCH_AUTHOR_GUEST = new System.Windows.Forms.TextBox();
            this.SEARCH_BOOKNAME_GUEST = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Button();
            this.SEARCH_GUEST = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 361);
            this.dataGridView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "고유 번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "출판사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "저자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "도서 이름";
            // 
            // SEARCH_BOOKNUMBER_GUEST
            // 
            this.SEARCH_BOOKNUMBER_GUEST.Location = new System.Drawing.Point(589, 18);
            this.SEARCH_BOOKNUMBER_GUEST.Name = "SEARCH_BOOKNUMBER_GUEST";
            this.SEARCH_BOOKNUMBER_GUEST.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_BOOKNUMBER_GUEST.TabIndex = 23;
            this.SEARCH_BOOKNUMBER_GUEST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SEARCH_BOOKNUMBER_GUEST_KeyDown);
            // 
            // SEARCH_PUBLISHER_GUEST
            // 
            this.SEARCH_PUBLISHER_GUEST.Location = new System.Drawing.Point(405, 18);
            this.SEARCH_PUBLISHER_GUEST.Name = "SEARCH_PUBLISHER_GUEST";
            this.SEARCH_PUBLISHER_GUEST.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_PUBLISHER_GUEST.TabIndex = 22;
            this.SEARCH_PUBLISHER_GUEST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SEARCH_PUBLISHER_GUEST_KeyDown);
            // 
            // SEARCH_AUTHOR_GUEST
            // 
            this.SEARCH_AUTHOR_GUEST.Location = new System.Drawing.Point(237, 18);
            this.SEARCH_AUTHOR_GUEST.Name = "SEARCH_AUTHOR_GUEST";
            this.SEARCH_AUTHOR_GUEST.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_AUTHOR_GUEST.TabIndex = 21;
            this.SEARCH_AUTHOR_GUEST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SEARCH_AUTHOR_GUEST_KeyDown);
            // 
            // SEARCH_BOOKNAME_GUEST
            // 
            this.SEARCH_BOOKNAME_GUEST.Location = new System.Drawing.Point(77, 18);
            this.SEARCH_BOOKNAME_GUEST.Name = "SEARCH_BOOKNAME_GUEST";
            this.SEARCH_BOOKNAME_GUEST.Size = new System.Drawing.Size(100, 21);
            this.SEARCH_BOOKNAME_GUEST.TabIndex = 20;
            this.SEARCH_BOOKNAME_GUEST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SEARCH_BOOKNAME_GUEST_KeyDown);
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(16, 436);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(93, 37);
            this.LOGIN.TabIndex = 29;
            this.LOGIN.Text = "로그인 화면";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // SEARCH_GUEST
            // 
            this.SEARCH_GUEST.Location = new System.Drawing.Point(695, 19);
            this.SEARCH_GUEST.Name = "SEARCH_GUEST";
            this.SEARCH_GUEST.Size = new System.Drawing.Size(93, 21);
            this.SEARCH_GUEST.TabIndex = 30;
            this.SEARCH_GUEST.Text = "검색";
            this.SEARCH_GUEST.UseVisualStyleBackColor = true;
            this.SEARCH_GUEST.Click += new System.EventHandler(this.SEARCH_GUEST_Click);
            // 
            // Not_User_Search_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 485);
            this.Controls.Add(this.SEARCH_GUEST);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SEARCH_BOOKNUMBER_GUEST);
            this.Controls.Add(this.SEARCH_PUBLISHER_GUEST);
            this.Controls.Add(this.SEARCH_AUTHOR_GUEST);
            this.Controls.Add(this.SEARCH_BOOKNAME_GUEST);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Not_User_Search_Book";
            this.Text = "Not_User_Search_Book";
            this.Load += new System.EventHandler(this.Not_User_Search_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SEARCH_BOOKNUMBER_GUEST;
        private System.Windows.Forms.TextBox SEARCH_PUBLISHER_GUEST;
        private System.Windows.Forms.TextBox SEARCH_AUTHOR_GUEST;
        private System.Windows.Forms.TextBox SEARCH_BOOKNAME_GUEST;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.Button SEARCH_GUEST;
    }
}