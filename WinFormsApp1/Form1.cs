using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=DESKTOP-0HPTUPS;Database=wending;Trusted_Connection=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void автоматовјјToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void торговыејвтоматыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(income) FROM apparats";
                SqlCommand cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                label2.Text = $"доход автоматов: {count}";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(quantity) FROM sells";
                SqlCommand cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                label3.Text = $"продано товаров {count}";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TOP 1 id FROM items";
                SqlCommand cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                label4.Text = $"попул€рный товар {count}";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(status) FROM apparats WHERE status = 'работает'";
                SqlCommand comm = new SqlCommand(query, conn);

                int count = (int)comm.ExecuteScalar();
                label6.Text = $"работающих автоматов {count}";
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

    }
}
