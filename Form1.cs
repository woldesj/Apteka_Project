using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AptekaProject
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\AptekaProject\AptekaProject\Database\aptekasql.mdf;Integrated Security=True;Connect Timeout=30"; //Було створено та підключено локальну базу данних

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();         //Кнопка закриття форми входу
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';          //Функціонал чек боксу показати пароль 
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Перевірка на порожні поля
            // Якщо користувач не заповнив логін або пароль, показуємо повідомлення про помилку
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Порожні поля", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Підключення до бази даних
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Відкриваємо з'єднання з базою даних

                    // Запит для вибору користувача з активним статусом
                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass AND status = 'Active'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        // Додаємо параметри для запиту, замінюючи @usern та @pass на введені значення
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Створюємо адаптер для запиту
                        DataTable table = new DataTable(); // Створюємо таблицю для зберігання результатів

                        adapter.Fill(table); // Заповнюємо таблицю результатами запиту

                        // Перевірка, чи знайдено хоча б одного користувача
                        if (table.Rows.Count > 0)
                        {
                            // Якщо користувач знайдений, відкриваємо головну форму
                            MainForm mainForm = new MainForm();
                            mainForm.Show(); // Відкриваємо головну форму
                            this.Hide(); // Приховуємо поточну форму входу
                        }
                        else
                        {
                            // Якщо логін або пароль неправильні, показуємо повідомлення про помилку
                            MessageBox.Show("Неправильний логін або пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();              //Функціонал переходу на форму реєстрацції
            regForm.Show();
            this.Hide();
        }
    }
}
