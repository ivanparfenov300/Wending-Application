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
    public partial class Form5 : Form
    {
        private string connectionString = "Server=DESKTOP-0HPTUPS;Database=wending;Trusted_Connection=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)){ 
                MessageBox.Show("Первое поле должно быть заполнено", "Предупрежение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                string query = "INSERT INTO sells (sell_id,app_id,item_id,quantity,sell_time,pay_method) VALUES (@sell_id,@app_id,@item_id,@quantity,@sell_time,@pay_method)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@sell_id", Convert.ToInt32(textBox1.Text));
                        command.Parameters.AddWithValue("@app_id", textBox2.Text);
                        command.Parameters.AddWithValue("@item_id", textBox3.Text);
                        command.Parameters.AddWithValue("@quantity", textBox4.Text);
                        command.Parameters.AddWithValue("@sell_time", textBox5.Text);
                        command.Parameters.AddWithValue("@pay_method", textBox6.Text);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Удалось добавить продажу", "Успех",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось добавить продажу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Айди уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Ошибка MySql {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
