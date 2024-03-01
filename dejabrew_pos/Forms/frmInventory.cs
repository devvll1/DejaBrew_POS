using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dejabrew_pos.Forms
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void gridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gridInventory.Rows[e.RowIndex]; // Get the selected row

                // Retrieve the data from the selected row
                string p_id = selectedRow.Cells["p_id"].Value.ToString(); // Replace Column1 with the actual column name in the DataGridView for the first column
                string name = selectedRow.Cells["p_name"].Value.ToString();
                int price = Convert.ToInt32(selectedRow.Cells["p_price"].Value); // Replace Column2 with the actual column name in the DataGridView for the second column
                int quantity = Convert.ToInt32(selectedRow.Cells["p_quantity"].Value);
                // Populate the data in the respective textboxes or controls for editing
                txtName.Text = name; // Replace yourTextBox1 with the actual name of your TextBox control for the first column
                txtPrice.Text = price.ToString(); // Replace yourTextBox2 with the actual name of your TextBox control for the second column
                txtQuantity.Text = quantity.ToString();
            }
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string query = "SELECT * FROM products";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gridInventory.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Forms.frmDashboard frmDashboard = new Forms.frmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void RefreshDataGridView()
        {
            // Retrieve the updated data from the database and bind it to the DataGridView
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM products";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gridInventory.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";


            string sql = "INSERT INTO products (p_name, p_price, p_quantity) VALUES (@p_name, @p_price, @p_quantity)";

            string name;
            int price;
            int quantity;

            if (!string.IsNullOrEmpty(txtName.Text) &&
                int.TryParse(txtPrice.Text, out price) &&
                int.TryParse(txtQuantity.Text, out quantity))
            {
                name = txtName.Text;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO products (p_name, p_price, p_quantity) VALUES (@p_name, @p_price, @p_quantity)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@p_name", name);
                    command.Parameters.AddWithValue("@p_price", price);
                    command.Parameters.AddWithValue("@p_quantity", quantity);

                    command.ExecuteNonQuery();
                }
                RefreshDataGridView(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Please enter valid data for all fields.");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridInventory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridInventory.SelectedRows[0]; // Get the selected row

                // Get the primary key or unique identifier value from the selected row
                int primaryKeyValue = Convert.ToInt32(selectedRow.Cells["p_id"].Value); // Replace PrimaryKeyColumnName with the actual column name of the primary key or unique identifier

                // Retrieve the updated data from the textboxes or controls
                string name = txtName.Text; // Replace yourTextBox1 with the actual name of your TextBox control for the first column
                int price = Convert.ToInt32(txtPrice.Text); // Replace yourTextBox2 with the actual name of your TextBox control for the second column
                int quantity = Convert.ToInt32(txtQuantity.Text);
    
                // Update the data in the DataGridView
                selectedRow.Cells["p_name"].Value = name; // Replace Column1 with the actual column name in the DataGridView for the first column
                selectedRow.Cells["p_price"].Value = price; // Replace Column2 with the actual column name in the DataGridView for the second column
                selectedRow.Cells["p_quantity"].Value = quantity;


                // Update the data in the database
                string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE products SET p_name = @p_name, p_price = @p_price, p_quantity = @p_quantity WHERE p_id = @p_id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@p_name", name);
                    command.Parameters.AddWithValue("@p_price", price);
                    command.Parameters.AddWithValue("@p_quantity", quantity);
                    command.Parameters.AddWithValue("@p_id", primaryKeyValue);

                    command.ExecuteNonQuery();
                }
                RefreshDataGridView(); // Refresh the DataGridView
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridInventory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridInventory.SelectedRows[0]; // Get the selected row

                int primaryKeyValue = Convert.ToInt32(selectedRow.Cells["p_id"].Value); // Replace p_id with the actual column name of the primary key or unique identifier

                // Delete the row from the DataGridView
                gridInventory.Rows.Remove(selectedRow);

                // Delete the row from the database
                string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM products WHERE p_id = @p_id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@p_id", primaryKeyValue);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
