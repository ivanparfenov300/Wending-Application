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
    public partial class Form8 : Form
    {
        DataGridView dataGridView;
        private string connectionString = "Server=DESKTOP-0HPTUPS;Database=wending;Trusted_Connection=True";
        public Form8()
        {
            InitializeComponent();
            Configure();
            LoadItemsData();
        }
        private void Configure()
        {
            dataGridView = this.dataGridView1;
            dataGridView.AutoGenerateColumns = false;
            if (dataGridView.Columns.Contains("Column1"))
                dataGridView.Columns["Column1"].DataPropertyName = "id";
            if (dataGridView.Columns.Contains("Column2"))
                dataGridView.Columns["Column2"].DataPropertyName = "name";
            if (dataGridView.Columns.Contains("Column3"))
                dataGridView.Columns["Column3"].DataPropertyName = "description";
            if (dataGridView.Columns.Contains("Column4"))
                dataGridView.Columns["Column4"].DataPropertyName = "price";
            if (dataGridView.Columns.Contains("Column5"))
                dataGridView.Columns["Column5"].DataPropertyName = "in_stock";
            if (dataGridView.Columns.Contains("Column6"))
                dataGridView.Columns["Column6"].DataPropertyName = "reserve";
            if (dataGridView.Columns.Contains("Column7"))
                dataGridView.Columns["Column7"].DataPropertyName = "avg";
        }
        private void LoadItemsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT id,name,description,price,in_stock,reserve,avg FROM items";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form = new Form9();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView.ReadOnly)
            {
                dataGridView.ReadOnly = false;
                dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
                button3.Enabled = false;
                MessageBox.Show("Режим редактирования включен", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    SaveChangesToDatabase();
                    dataGridView.ReadOnly = true;
                    dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                    button4.Enabled = true;
                    MessageBox.Show("Изменения успешно сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveChangesToDatabase()
        {
            bool hasChanges = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.DataBoundItem is DataRowView rowView && rowView.Row.RowState == DataRowState.Modified)
                    {
                        hasChanges = true;
                        int id = Convert.ToInt32(row.Cells["Column1"].Value);
                        string name = row.Cells["Column2"].Value?.ToString() ?? "";
                        string description = row.Cells["Column3"].Value?.ToString() ?? "";
                        int price = Convert.ToInt32(row.Cells["Column4"].Value);
                        string in_stock = row.Cells["Column5"].Value?.ToString() ?? "";
                        int reserve = Convert.ToInt32(row.Cells["Column6"].Value);
                        int avg = Convert.ToInt32(row.Cells["Column7"].Value);

                        // Исправлено: убрано обновление поля id, так как это первичный ключ
                        string query = "UPDATE items SET name = @name, description = @description, price = @price, in_stock = @in_stock, reserve = @reserve, avg = @avg WHERE id = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@in_stock", in_stock);
                        command.Parameters.AddWithValue("@reserve", reserve);
                        command.Parameters.AddWithValue("@avg", avg);

                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();

                if (!hasChanges)
                {
                    MessageBox.Show("Нет изменений для сохранения", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadItemsData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0 && dataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Введите строку для удаления");
                return;
            }
            try
            {

                int rowIndex;
                if (dataGridView.SelectedRows.Count > 0)
                {
                    rowIndex = dataGridView.SelectedRows[0].Index;
                }
                else
                {
                    rowIndex = dataGridView.SelectedCells[0].RowIndex;
                }
                DataGridViewRow selectedrow = dataGridView.Rows[rowIndex];
                int id = Convert.ToInt32(selectedrow.Cells["Column1"].Value);
                string name = selectedrow.Cells["Column2"].Value?.ToString() ?? "";
                DialogResult result = MessageBox.Show(
                    $"Вы действительно хотите удалить запись\n\n" +
                    $"id:{id}\n" +
                    $"name:{name}\n",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM items WHERE id=@id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        int RowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                        if (RowsAffected > 0)
                        {
                            dataGridView.Rows.Remove(selectedrow);
                            MessageBox.Show("Запись успешно удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении записи {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 10 id,name,description,price,in_stock,reserve,avg FROM items";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 20 id,name,description,price,in_stock,reserve,avg FROM items";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 30 id,name,description,price,in_stock,reserve,avg FROM items";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 40 id,name,description,price,in_stock,reserve,avg FROM items";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 50 id,name,description,price,in_stock,reserve,avg FROM items";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
