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
    public partial class Form6 : Form
    {
        private DataGridView dataGridView;
        private string connectionString = "Server=DESKTOP-0HPTUPS;Database=wending;Trusted_Connection=True";
        public Form6()
        {
            InitializeComponent();
            Configure();
            LoadSellsData();
        }
        private void Configure()
        {
            dataGridView = this.dataGridView2;
            dataGridView.AutoGenerateColumns = false;
            if (dataGridView.Columns.Contains("Column1"))
                dataGridView.Columns["Column1"].DataPropertyName = "sell_id";
            if (dataGridView.Columns.Contains("Column2"))
                dataGridView.Columns["Column2"].DataPropertyName = "app_id";
            if (dataGridView.Columns.Contains("Column3"))
                dataGridView.Columns["Column3"].DataPropertyName = "item_id";
            if (dataGridView.Columns.Contains("Column4"))
                dataGridView.Columns["Column4"].DataPropertyName = "quantity";
            if (dataGridView.Columns.Contains("Column5"))
                dataGridView.Columns["Column5"].DataPropertyName = "sell_time";
            if (dataGridView.Columns.Contains("Column6"))
                dataGridView.Columns["Column6"].DataPropertyName = "pay_method";
        }
        private void LoadSellsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT sell_id, app_id, item_id, quantity, sell_time, pay_method FROM sells";
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
                MessageBox.Show($"Ошибка при загрузке данных {ex.Message}");
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query1 = "SELECT TOP 10 sell_id, app_id, item_id, quantity, sell_time, pay_method FROM sells";
                    SqlCommand command = new SqlCommand(query1, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    // Привязываем данные
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 20 sell_id, app_id, item_id, quantity, sell_time, pay_method FROM sells";
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
                MessageBox.Show($"ошибка при загрузке данных{ex.Message}");
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 30 sell_id, app_id, item_id, quantity, sell_time, pay_method FROM sells";
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
                MessageBox.Show($"ошибка при загрузке данных{ex.Message}");
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 40 sell_id, app_id, item_id, quantity, sell_time, pay_method FROM sells";
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
                MessageBox.Show($"ошибка при загрузке данных{ex.Message}");
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 50 sell_id, app_id, item_id, quantity, sell_time, pay_method FROM sells";
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
                MessageBox.Show($"ошибка при загрузке данных{ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
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
                    MessageBox.Show($"Ошибка при сохранении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        int sell_id = Convert.ToInt32(row.Cells["Column1"].Value);
                        int app_id = Convert.ToInt32(row.Cells["Column2"].Value);
                        int item_id = Convert.ToInt32(row.Cells["Column3"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Column4"].Value);
                        string sell_time = row.Cells["Column5"].Value?.ToString() ?? "";
                        string pay_method = row.Cells["Column6"].Value?.ToString() ?? "";

                        string query = "UPDATE sells SET sell_id = @sell_id, app_id = @app_id, item_id = @item_id, quantity = @quantity, sell_time = @sell_time, pay_method = @pay_method WHERE sell_id = @sell_id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@sell_id", sell_id);
                        command.Parameters.AddWithValue("@app_id", app_id);
                        command.Parameters.AddWithValue("@item_id", item_id);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@sell_time", sell_time);
                        command.Parameters.AddWithValue("@pay_method", pay_method);

                        command.ExecuteNonQuery();

                    }
                }
                connection.Close();

                if (!hasChanges)
                {
                    MessageBox.Show("Нет изменений для сохранений", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadSellsData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0 && dataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления");
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
                int app_id = Convert.ToInt32(selectedrow.Cells["Column2"].Value);
                DialogResult result = MessageBox.Show(
                    $"Уверены,что хотите удалить запись\n\n" +
                    $"ID:{id}\n" +
                    $"номер аппарата:{app_id}",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE  FROM sells WHERE sell_id=@sell_id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@sell_id", id);
                        connection.Open();
                        int rowAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowAffected > 0)
                        {
                            dataGridView.Rows.Remove(selectedrow);
                            MessageBox.Show("Запись успешно удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }                        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении записи{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
