
namespace Creative_Library
{
    partial class Main_Display
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BACK = new System.Windows.Forms.Button();
            this.LOGIN = new System.Windows.Forms.Button();
            this.SIGNUP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(92, 105);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(119, 21);
            this.ID.TabIndex = 4;
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            // 
            // PW
            // 
            this.PW.Location = new System.Drawing.Point(92, 145);
            this.PW.Name = "PW";
            this.PW.PasswordChar = '*';
            this.PW.Size = new System.Drawing.Size(119, 21);
            this.PW.TabIndex = 5;
            this.PW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PW_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(41, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "도서 관리 프로그램";
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(12, 272);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(67, 20);
            this.BACK.TabIndex = 8;
            this.BACK.Text = "뒤로가기";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(92, 188);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(119, 24);
            this.LOGIN.TabIndex = 9;
            this.LOGIN.Text = "로그인";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // SIGNUP
            // 
            this.SIGNUP.AutoSize = true;
            this.SIGNUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SIGNUP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SIGNUP.Location = new System.Drawing.Point(120, 227);
            this.SIGNUP.Name = "SIGNUP";
            this.SIGNUP.Size = new System.Drawing.Size(53, 12);
            this.SIGNUP.TabIndex = 10;
            this.SIGNUP.Text = "회원가입";
            this.SIGNUP.Click += new System.EventHandler(this.SIGNUP_Click);
            // 
            // Main_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 304);
            this.Controls.Add(this.SIGNUP);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Main_Display";
            this.Text = "Main_Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.Label SIGNUP;
    }
}

