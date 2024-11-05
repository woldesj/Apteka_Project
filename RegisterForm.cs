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
    public partial class RegisterForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\AptekaProject\AptekaProject\Database\aptekasql.mdf;Integrated Security=True;Connect Timeout=30"; //Було створено та підключено локальну базу данних
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();         //Кнопка закриття форми входу
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_confirmPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';            //Функціонал чек боксу показати пароль
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();              //Функціонал переходу назад на форму входу
            loginForm.Show();
            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            // Перевірка на порожні поля
            // Якщо користувач не заповнив логін, пароль або підтвердження пароля, показуємо повідомлення про помилку
            if (register_username.Text == "" || register_password.Text == "" || register_confirmPassword.Text == "")
            {
                MessageBox.Show("Порожні поля", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Підключення до бази даних
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Відкриваємо з'єднання з базою даних

                    // Запит для перевірки наявності логіна в базі даних
                    string checkUsernQuery = "SELECT * FROM users WHERE username = @usern";

                    using (SqlCommand checkUsern = new SqlCommand(checkUsernQuery, connection))
                    {
                        // Додаємо параметр для запиту, замінюючи @usern на введений логін
                        checkUsern.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern); // Створюємо адаптер для запиту
                        DataTable table = new DataTable(); // Створюємо таблицю для зберігання результатів

                        adapter.Fill(table); // Заповнюємо таблицю результатами запиту

                        // Перевірка, чи існує вже введений логін у базі даних
                        if (table.Rows.Count != 0)
                        {
                            // Формуємо рядок з логіном, перше слово з великої букви
                            string tempUsern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                            MessageBox.Show(tempUsern + " - Цей логін вже використовується", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        // Перевірка довжини пароля
                        else if (register_password.Text.Length < 8)
                        {
                            // Якщо пароль менше 8 символів, показуємо повідомлення про помилку
                            MessageBox.Show("Пароль має бути не менше 8 символів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Запит для додавання нового користувача в базу даних
                            string insertData = "INSERT INTO users (username, password, role, status, date_register) " +
                                "VALUES(@usern, @pass, @role, @status, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connection))
                            {
                                // Додаємо параметри для запиту на вставку
                                cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Cashier"); // Роль користувача
                                cmd.Parameters.AddWithValue("@status", "Approval"); // Статус користувача

                                DateTime today = DateTime.Today; // Дата реєстрації
                                cmd.Parameters.AddWithValue("@date", today);

                                // Виконуємо запит на вставку нового користувача в базу даних
                                cmd.ExecuteNonQuery();

                                // Повідомляємо про успішну реєстрацію
                                MessageBox.Show("Успішна реєстрація!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Перехід на форму входу
                                Form1 loginForm = new Form1(); // Створюємо новий екземпляр форми входу
                                loginForm.Show(); // Відкриваємо форму входу
                                this.Hide(); // Приховуємо поточну форму реєстрації
                            }
                        }
                    }
                }
            }
        }
    }
}
