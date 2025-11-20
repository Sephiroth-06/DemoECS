using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shoes.Forms
{
    partial class ProductsForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxProducts;
        private Button btnBack;
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
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(43, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 22);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Каталог товаров";
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 15;
            this.listBoxProducts.Location = new System.Drawing.Point(43, 52);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(515, 334);
            this.listBoxProducts.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBack.Location = new System.Drawing.Point(277, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 26);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 486);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}