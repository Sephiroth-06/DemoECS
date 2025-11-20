using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shoes.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Label lblUserName;
        private Label lblUserRole;
        private Button btnProducts;
        private Button btnLogout;

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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(33, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(177, 22);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Добро пожаловать!";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblUserName.Location = new System.Drawing.Point(33, 133);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(139, 19);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "ФИО пользователя";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblUserRole.Location = new System.Drawing.Point(33, 155);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(35, 16);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Роль";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(154)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnProducts.ForeColor = System.Drawing.Color.Black;
            this.btnProducts.Location = new System.Drawing.Point(33, 58);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(171, 35);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Просмотр товаров";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnLogout.Location = new System.Drawing.Point(76, 177);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 26);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 264);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}