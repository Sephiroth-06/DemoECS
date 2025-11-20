using System;
using System.Drawing;
using System.Windows.Forms;
using Shoes.Data;
using Shoes.Models;

namespace Shoes.Forms
{
    public partial class LoginForm : Form
    {
        public User CurrentUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            ApplyStyle();
        }

        private void ApplyStyle()
        {
            // Стиль формы согласно руководству
            this.BackColor = Color.White; // #FFFFFF
            this.Font = new Font("Times New Roman", 10);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Вход в систему - ООО «Обувь»";
            this.Size = new Size(400, 300);

            // Стиль кнопки Войти
            btnLogin.BackColor = Color.FromArgb(0, 250, 154); // #00FA9A
            btnLogin.ForeColor = Color.Black;
            btnLogin.Font = new Font("Times New Roman", 10, FontStyle.Bold);

            // Стиль кнопки Гость
            btnGuest.BackColor = Color.FromArgb(127, 255, 0); // #7FFF00
            btnGuest.ForeColor = Color.Black;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Проверка авторизации через DatabaseContext
                var db = new DatabaseContext();
                CurrentUser = db.AuthenticateUser(login, password);

                if (CurrentUser != null)
                {
                    MessageBox.Show($"Добро пожаловать, {CurrentUser.FullName}!", "Успешный вход",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Открываем главную форму для любой роли
                    MainForm mainForm = new MainForm(CurrentUser);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtLogin.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к БД: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            // Создаем гостевого пользователя
            CurrentUser = new User
            {
                Id = 0,
                FullName = "Гость",
                Login = "guest",
                Role = new Role { Name = "Гость" }
            };

            // Открываем главную форму для гостя
            MainForm mainForm = new MainForm(CurrentUser);
            mainForm.Show();
            this.Hide();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}