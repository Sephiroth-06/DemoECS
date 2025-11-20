using System;
using System.Drawing;
using System.Windows.Forms;
using Shoes.Models;

namespace Shoes.Forms
{
    public partial class MainForm : Form
    {
        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            ApplyStyles();
            DisplayUserInfo();
        }

        private void ApplyStyles()
        {
            this.BackColor = Color.White;
            this.Font = new Font("Times New Roman", 10);
            this.Text = "Главная - ООО «Обувь»";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
        }

        private void DisplayUserInfo()
        {
            lblUserName.Text = currentUser.FullName;
            lblUserRole.Text = currentUser.Role.Name;
            lblWelcome.Text = $"Добро пожаловать, {currentUser.FullName}!";
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm(currentUser);
            productsForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}