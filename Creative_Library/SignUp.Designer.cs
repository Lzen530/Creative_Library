﻿
namespace Creative_Library
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.PHONE = new System.Windows.Forms.TextBox();
            this.SIGNUP_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "ex) 010-0000-0000\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(117, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "회원가입";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "8~32자 특수문자, 영문자, 숫자 3종류 포함";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "이름";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(89, 120);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(114, 21);
            this.ID.TabIndex = 15;
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            // 
            // PW
            // 
            this.PW.Location = new System.Drawing.Point(89, 161);
            this.PW.Name = "PW";
            this.PW.PasswordChar = '*';
            this.PW.Size = new System.Drawing.Size(114, 21);
            this.PW.TabIndex = 16;
            this.PW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PW_KeyDown);
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(89, 210);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(114, 21);
            this.NAME.TabIndex = 17;
            this.NAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NAME_KeyDown);
            // 
            // PHONE
            // 
            this.PHONE.Location = new System.Drawing.Point(89, 245);
            this.PHONE.Name = "PHONE";
            this.PHONE.Size = new System.Drawing.Size(114, 21);
            this.PHONE.TabIndex = 18;
            this.PHONE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PHONE_KeyDown);
            // 
            // SIGNUP_BUTTON
            // 
            this.SIGNUP_BUTTON.Location = new System.Drawing.Point(98, 295);
            this.SIGNUP_BUTTON.Name = "SIGNUP_BUTTON";
            this.SIGNUP_BUTTON.Size = new System.Drawing.Size(161, 35);
            this.SIGNUP_BUTTON.TabIndex = 19;
            this.SIGNUP_BUTTON.Text = "가입";
            this.SIGNUP_BUTTON.UseVisualStyleBackColor = true;
            this.SIGNUP_BUTTON.Click += new System.EventHandler(this.SIGNUP_BUTTON_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 393);
            this.Controls.Add(this.SIGNUP_BUTTON);
            this.Controls.Add(this.PHONE);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.TextBox PHONE;
        private System.Windows.Forms.Button SIGNUP_BUTTON;
    }
}