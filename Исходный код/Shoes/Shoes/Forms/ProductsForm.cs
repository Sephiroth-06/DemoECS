using System;
using System.Drawing;
using System.Windows.Forms;
using Shoes.Data;
using Shoes.Models;

namespace Shoes.Forms
{
    public partial class ProductsForm : Form
    {
        private User currentUser;
        private DatabaseContext dbContext;

        public ProductsForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            dbContext = new DatabaseContext();
            ApplyStyles();
            LoadProducts();
        }

        private void ApplyStyles()
        {
            this.BackColor = Color.White;
            this.Font = new Font("Times New Roman", 10);
            this.Text = "Каталог товаров - ООО «Обувь»";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 600);
        }

        private void LoadProducts()
        {
            try
            {
                var products = dbContext.GetAllProducts();
                listBoxProducts.Items.Clear();

                foreach (var product in products)
                {
                    listBoxProducts.Items.Add($"{product.Category.Name} | {product.Name} - {product.Price} руб.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки товаров: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentUser != null && currentUser.Role.Name != "Гость")
            {
                MainForm mainForm = new MainForm(currentUser);
                mainForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            this.Hide();
        }
    }
}