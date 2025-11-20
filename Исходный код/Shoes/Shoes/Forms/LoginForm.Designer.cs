using System;
using System.Drawing;
using System.Windows.Forms;
namespace Shoes.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnGuest;
        private Label lblLogin;
        private Label lblPassword;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(75, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 22);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "ООО «Обувь» - Вход";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblLogin.Location = new System.Drawing.Point(43, 69);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 16);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Логин:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtLogin.Location = new System.Drawing.Point(103, 67);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(172, 23);
            this.txtLogin.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblPassword.Location = new System.Drawing.Point(43, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 16);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Пароль:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtPassword.Location = new System.Drawing.Point(103, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(68, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 26);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnGuest.Location = new System.Drawing.Point(166, 147);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(109, 26);
            this.btnGuest.TabIndex = 3;
            this.btnGuest.Text = "Войти как гость";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 215);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblTitle);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}