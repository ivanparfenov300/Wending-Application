using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form9 : Form
    {
        private string connectionString = "Server=DESKTOP-0HPTUPS;Database=wending;Trusted_Connection=True";
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form = new Form8();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Поле ID должно быть заполнено","Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string query = "INSERT INTO items(id,name,description,price,in_stock,reserve,avg) VALUES(@id,@name,@description,@price,@in_stock,@reserve,@avg)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
                        command.Parameters.AddWithValue("name", textBox2.Text);
                        command.Parameters.AddWithValue("description", textBox3.Text);
                        command.Parameters.AddWithValue("price", Convert.ToInt32(textBox4.Text));
                        command.Parameters.AddWithValue("in_stock", textBox5.Text);
                        command.Parameters.AddWithValue("reserve", Convert.ToInt32(textBox6.Text));
                        command.Parameters.AddWithValue("avg", Convert.ToInt32(textBox7.Text));

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Удалось добавить товары", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось добавить товар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность ввода","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                if(ex.Number == 1062)
                {
                    MessageBox.Show("Айди уже существует","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Ошибка Sql{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
    }
}
