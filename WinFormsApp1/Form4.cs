using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private string connectionString = "Server=DESKTOP-0HPTUPS;Database=wending;Trusted_Connection=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname = textBox1.Text.Trim();
            string role = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(role)) {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM users WHERE surname = @surname AND role = @role";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@role", role);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string userRole = reader["role"].ToString();

                        this.Hide();

                        switch (userRole.ToLower())
                        {
                            case "механик":
                                Form7 form7 = new Form7();
                                form7.Show();
                                break;

                            case "аналитик":
                                Form6 form6 = new Form6();
                                form6.Show();
                                break;

                            case "оператор":
                                Form8 form8 = new Form8();
                                form8.Show();
                                break;

                            case "мерчендайзер":
                                Form1 form1 = new Form1();
                                form1.Show();
                                break;

                            default:
                                Form1 form11 = new Form1();
                                form11.Show();
                                break;
                        }

                        MessageBox.Show($"Добро пожаловать {surname}", "Авторизация успешна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных : {ex.Message}","Ошибка" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
