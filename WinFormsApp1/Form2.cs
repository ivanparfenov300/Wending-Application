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
    public partial class Form2 : Form
    {
        private DataGridView dataGridView1;
        private string connectionString = "Server=DESKTOP-0HPTUPS;Database=wending;Trusted_Connection=True";

        public Form2()
        {
            InitializeComponent();
            Configure();
            LoadApparatsData();
        }
        private void Configure()
        {
            dataGridView1.AutoGenerateColumns = false;
            if (dataGridView1.Columns.Contains("Column1"))
                dataGridView1.Columns["Column1"].DataPropertyName = "id";

            if (dataGridView1.Columns.Contains("Column2"))
                dataGridView1.Columns["Column2"].DataPropertyName = "manufactur";

            if (dataGridView1.Columns.Contains("Column3"))
                dataGridView1.Columns["Column3"].DataPropertyName = "model";

            if (dataGridView1.Columns.Contains("Column4"))
                dataGridView1.Columns["Column4"].DataPropertyName = "country";

            if (dataGridView1.Columns.Contains("Column5"))
                dataGridView1.Columns["Column5"].DataPropertyName = "inv_id";

            if (dataGridView1.Columns.Contains("Column6"))
                dataGridView1.Columns["Column6"].DataPropertyName = "place";

            if (dataGridView1.Columns.Contains("Column7"))
                dataGridView1.Columns["Column7"].DataPropertyName = "exp_date";
        }
        private void LoadApparatsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT id, manufactur, model, country, inv_id, place, exp_date FROM apparats";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query1 = "SELECT TOP 10 id, manufactur, model,country,inv_id, place, exp_date FROM apparats";
                    SqlCommand command = new SqlCommand(query1, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query2 = "SELECT TOP 20 id, manufactur, model,country,inv_id, place, exp_date FROM apparats";
                    SqlCommand command = new SqlCommand(query2, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query3 = "SELECT TOP 30 id, manufactur, model,country,inv_id, place, exp_date FROM apparats";
                    SqlCommand command = new SqlCommand(query3, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query4 = "SELECT TOP 40 id, manufactur, model,country,inv_id, place, exp_date FROM apparats";
                    SqlCommand command = new SqlCommand(query4, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query5 = "SELECT TOP 50 id, manufactur, model,country,inv_id, place, exp_date FROM apparats";
                    SqlCommand command = new SqlCommand(query5, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ReadOnly)
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
                button3.Text = "Save Changes";
                button1.Enabled = false;
                MessageBox.Show("Edit mode enabled. Change data in cells and click 'Save Changes'",
                    "Editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    SaveChangesToDatabase();
                    dataGridView1.ReadOnly = true;
                    dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                    button3.Text = "Edit";
                    button1.Enabled = true;
                    MessageBox.Show("Changes saved successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveChangesToDatabase()
        {
            bool hasChanges = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.DataBoundItem is DataRowView rowView && rowView.Row.RowState == DataRowState.Modified)
                    {
                        hasChanges = true;

                        int id = Convert.ToInt32(row.Cells["Column1"].Value);
                        string manufactur = row.Cells["Column2"].Value?.ToString() ?? "";
                        string model = row.Cells["Column3"].Value?.ToString() ?? "";
                        string country = row.Cells["Column4"].Value?.ToString() ?? "";
                        string inv_id = row.Cells["Column5"].Value?.ToString() ?? "";
                        string place = row.Cells["Column6"].Value?.ToString() ?? "";
                        string exp_date = row.Cells["Column7"].Value?.ToString() ?? "";

                        string query = @"UPDATE apparats 
                                SET manufactur = @manufactur, 
                                    model = @model, 
                                    country = @country, 
                                    inv_id = @inv_id, 
                                    place = @place, 
                                    exp_date = @exp_date 
                                WHERE id = @id";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@manufactur", manufactur);
                        command.Parameters.AddWithValue("@model", model);
                        command.Parameters.AddWithValue("@country", country);
                        command.Parameters.AddWithValue("@inv_id", inv_id);
                        command.Parameters.AddWithValue("@place", place);
                        command.Parameters.AddWithValue("@exp_date", exp_date);

                        command.ExecuteNonQuery();
                    }
                }

                connection.Close();

                if (!hasChanges)
                {
                    MessageBox.Show("No changes to save", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LoadApparatsData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Select a record to delete!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowIndex;

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    rowIndex = dataGridView1.SelectedRows[0].Index;
                }
                else
                {
                    rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                }

                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                int id = Convert.ToInt32(selectedRow.Cells["Column1"].Value);
                string manufactur = selectedRow.Cells["Column2"].Value?.ToString() ?? "not specified";
                string model = selectedRow.Cells["Column3"].Value?.ToString() ?? "not specified";

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete this record?\n\n" +
                    $"ID: {id}\n" +
                    $"Manufacturer: {manufactur}\n" +
                    $"Model: {model}",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM apparats WHERE id = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            dataGridView1.Rows.Remove(selectedRow);
                            MessageBox.Show("Record deleted successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Show();
        }
    }
}
