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
    public partial class Form7 : Form
    {
        private DataGridView dataGridView;
        private string connectionString = "Server=DESKTOP-0HPTUPS;Database=wending;Trusted_Connection=True";
        public Form7()
        {
            InitializeComponent();
            Configure();
            LoadData();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form = new Form4();
            form.Show();
        }
        private void Configure()
        {
            dataGridView = this.dataGridView1;
            dataGridView.AutoGenerateColumns = false;
            if (dataGridView.Columns.Contains("Column1"))
                dataGridView.Columns["Column1"].DataPropertyName = "id";
            if (dataGridView.Columns.Contains("Column2"))
                dataGridView.Columns["Column2"].DataPropertyName = "pay_type";
            if (dataGridView.Columns.Contains("Column3"))
                dataGridView.Columns["Column3"].DataPropertyName = "last_check_date";
            if (dataGridView.Columns.Contains("Column4"))
                dataGridView.Columns["Column4"].DataPropertyName = "next_rep";
            if (dataGridView.Columns.Contains("Column5"))
                dataGridView.Columns["Column5"].DataPropertyName = "resource";
            if (dataGridView.Columns.Contains("Column6"))
                dataGridView.Columns["Column6"].DataPropertyName = "status";
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT id,pay_type,last_check_date,next_rep,resource,status FROM apparats";
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
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView.ReadOnly)
            {
                dataGridView.ReadOnly = false;
                dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
                MessageBox.Show("Edit mode enabled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    SaveChanges();
                    dataGridView.ReadOnly = true;
                    dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                    MessageBox.Show("Changes saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SaveChanges()
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
                        string pay_type = row.Cells["Column2"].Value?.ToString() ?? "";
                        string last_check_date = row.Cells["Column3"].Value?.ToString() ?? "";
                        string next_rep = row.Cells["Column4"].Value?.ToString() ?? "";
                        int resource = Convert.ToInt32(row.Cells["Column5"].Value);
                        string status = row.Cells["Column6"].Value?.ToString() ?? "";
                        string query = "UPDATE apparats SET id=@id,pay_type=@pay_type,last_check_date=@last_check_date,next_rep=@next_rep,resource=@resource,status=@status WHERE id=@id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@pay_type", pay_type);
                        command.Parameters.AddWithValue("@last_check_date", last_check_date);
                        command.Parameters.AddWithValue("@next_rep", next_rep);
                        command.Parameters.AddWithValue("@resource", resource);
                        command.Parameters.AddWithValue("@status", status);

                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
                if (!hasChanges)
                {
                    MessageBox.Show("No changes to save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 10 id,pay_type,last_check_date,next_rep,resource,status FROM apparats";
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
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 20 id,pay_type,last_check_date,next_rep,resource,status FROM apparats";
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
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 30 id,pay_type,last_check_date,next_rep,resource,status FROM apparats";
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
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 40 id,pay_type,last_check_date,next_rep,resource,status FROM apparats";
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
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 50 id,pay_type,last_check_date,next_rep,resource,status FROM apparats";
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
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
    }
}
