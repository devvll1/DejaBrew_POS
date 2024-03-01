using dejabrew_pos.Components;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dejabrew_pos.Forms
{
    public partial class frmOrder : Form
    {

        public frmOrder()
        {
            InitializeComponent();
        }

        public class Cart
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public double Total { get; set; }
        }


        private void lblWinter_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTaro_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string selectQuery = "SELECT * FROM products WHERE p_id = @p_id";
            string updateQuery = "UPDATE products SET p_quantity = p_quantity - @p_quantity WHERE p_id = @p_id";

            string p_id = "1";
            string Quantity = txtTaroQuantity.Text;

            if (string.IsNullOrEmpty(Quantity))
            {
                Quantity = "1";
            }

            if (int.TryParse(Quantity, out int quantityBought))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p_id", p_id);
                        connection.Open();
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string p_name = reader.GetString("p_name");
                                decimal p_price = reader.GetDecimal("p_price");
                                int p_quantity = reader.GetInt32("p_quantity");

                                reader.Close();

                                if (p_quantity >= quantityBought)
                                {
                                    decimal total = p_price * quantityBought;

                                    DataGridViewRow newRow = new DataGridViewRow();

                                    DataGridViewTextBoxCell clmName = new DataGridViewTextBoxCell();
                                    clmName.Value = p_name;

                                    DataGridViewTextBoxCell clmPrice = new DataGridViewTextBoxCell();
                                    clmPrice.Value = p_price;

                                    DataGridViewTextBoxCell clmQuantity = new DataGridViewTextBoxCell();
                                    clmQuantity.Value = quantityBought;

                                    DataGridViewTextBoxCell clmTotal = new DataGridViewTextBoxCell();
                                    clmTotal.Value = total;

                                    newRow.Cells.Add(clmName);
                                    newRow.Cells.Add(clmPrice);
                                    newRow.Cells.Add(clmQuantity);
                                    newRow.Cells.Add(clmTotal);

                                    gridOrder.Rows.Add(newRow);

                                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@p_id", p_id);
                                        updateCommand.Parameters.AddWithValue("@p_quantity", quantityBought);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity value.");
            }
        }

        private void btnAddWintermelon_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string selectQuery = "SELECT * FROM products WHERE p_id = @p_id";
            string updateQuery = "UPDATE products SET p_quantity = p_quantity - @p_quantity WHERE p_id = @p_id";

            string p_id = "2";
            string Quantity = txtWinterQuantity.Text;

            if (string.IsNullOrEmpty(Quantity))
            {
                Quantity = "1";
            }

            if (int.TryParse(Quantity, out int quantityBought))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p_id", p_id);
                        connection.Open();
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string p_name = reader.GetString("p_name");
                                decimal p_price = reader.GetDecimal("p_price");
                                int p_quantity = reader.GetInt32("p_quantity");

                                reader.Close();

                                if (p_quantity >= quantityBought)
                                {
                                    decimal total = p_price * quantityBought;

                                    DataGridViewRow newRow = new DataGridViewRow();

                                    DataGridViewTextBoxCell clmName = new DataGridViewTextBoxCell();
                                    clmName.Value = p_name;

                                    DataGridViewTextBoxCell clmPrice = new DataGridViewTextBoxCell();
                                    clmPrice.Value = p_price;

                                    DataGridViewTextBoxCell clmQuantity = new DataGridViewTextBoxCell();
                                    clmQuantity.Value = quantityBought;


                                    DataGridViewTextBoxCell clmTotal = new DataGridViewTextBoxCell();
                                    clmTotal.Value = total;

                                    newRow.Cells.Add(clmName);
                                    newRow.Cells.Add(clmPrice);
                                    newRow.Cells.Add(clmQuantity);
                                    newRow.Cells.Add(clmTotal);

                                    gridOrder.Rows.Add(newRow);

                                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@p_id", p_id);
                                        updateCommand.Parameters.AddWithValue("@p_quantity", quantityBought);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity value.");
            }
        }

        private void btnAddMatcha_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string selectQuery = "SELECT * FROM products WHERE p_id = @p_id";
            string updateQuery = "UPDATE products SET p_quantity = p_quantity - @p_quantity WHERE p_id = @p_id";

            string p_id = "3";
            string Quantity = txtMatchaQuantity.Text;

            if (string.IsNullOrEmpty(Quantity))
            {
                Quantity = "1";
            }

            if (int.TryParse(Quantity, out int quantityBought))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p_id", p_id);
                        connection.Open();
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string p_name = reader.GetString("p_name");
                                decimal p_price = reader.GetDecimal("p_price");
                                int p_quantity = reader.GetInt32("p_quantity");

                                reader.Close();

                                if (p_quantity >= quantityBought)
                                {
                                    decimal total = p_price * quantityBought;

                                    DataGridViewRow newRow = new DataGridViewRow();

                                    DataGridViewTextBoxCell clmName = new DataGridViewTextBoxCell();
                                    clmName.Value = p_name;

                                    DataGridViewTextBoxCell clmPrice = new DataGridViewTextBoxCell();
                                    clmPrice.Value = p_price;

                                    DataGridViewTextBoxCell clmQuantity = new DataGridViewTextBoxCell();
                                    clmQuantity.Value = quantityBought;

                                    DataGridViewTextBoxCell clmTotal = new DataGridViewTextBoxCell();
                                    clmTotal.Value = total;

                                    newRow.Cells.Add(clmName);
                                    newRow.Cells.Add(clmPrice);
                                    newRow.Cells.Add(clmQuantity);
                                    newRow.Cells.Add(clmTotal);

                                    gridOrder.Rows.Add(newRow);

                                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@p_id", p_id);
                                        updateCommand.Parameters.AddWithValue("@p_quantity", quantityBought);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity value.");
            }
        }

        private void btnAddChoco_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string selectQuery = "SELECT * FROM products WHERE p_id = @p_id";
            string updateQuery = "UPDATE products SET p_quantity = p_quantity - @p_quantity WHERE p_id = @p_id";

            string p_id = "4";
            string Quantity = txtChocoQuantity.Text;
            
            if (string.IsNullOrEmpty(Quantity))
            {
                Quantity = "1";
            }

            if (int.TryParse(Quantity, out int quantityBought))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p_id", p_id);
                        connection.Open();
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string p_name = reader.GetString("p_name");
                                decimal p_price = reader.GetDecimal("p_price");
                                int p_quantity = reader.GetInt32("p_quantity");

                                reader.Close();

                                if (p_quantity >= quantityBought)
                                {
                                    decimal total = p_price * quantityBought;

                                    DataGridViewRow newRow = new DataGridViewRow();

                                    DataGridViewTextBoxCell clmName = new DataGridViewTextBoxCell();
                                    clmName.Value = p_name;

                                    DataGridViewTextBoxCell clmPrice = new DataGridViewTextBoxCell();
                                    clmPrice.Value = p_price;

                                    DataGridViewTextBoxCell clmQuantity = new DataGridViewTextBoxCell();
                                    clmQuantity.Value = quantityBought;

                                    DataGridViewTextBoxCell clmTotal = new DataGridViewTextBoxCell();
                                    clmTotal.Value = total;

                                    newRow.Cells.Add(clmName);
                                    newRow.Cells.Add(clmPrice);
                                    newRow.Cells.Add(clmQuantity);
                                    newRow.Cells.Add(clmTotal);
                                    

                                    gridOrder.Rows.Add(newRow);

                                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@p_id", p_id);
                                        updateCommand.Parameters.AddWithValue("@p_quantity", quantityBought);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity value.");
            }
        }

        private void btnAddPeperMint_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string selectQuery = "SELECT * FROM products WHERE p_id = @p_id";
            string updateQuery = "UPDATE products SET p_quantity = p_quantity - @p_quantity WHERE p_id = @p_id";

            string p_id = "5";
            string Quantity = txtPepermintQuantity.Text;

            if (string.IsNullOrEmpty(Quantity))
            {
                Quantity = "1";
            }

            if (int.TryParse(Quantity, out int quantityBought))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p_id", p_id);
                        connection.Open();
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string p_name = reader.GetString("p_name");
                                decimal p_price = reader.GetDecimal("p_price");
                                int p_quantity = reader.GetInt32("p_quantity");

                                reader.Close();

                                if (p_quantity >= quantityBought)
                                {

                                    decimal total = p_price * quantityBought;

                                    DataGridViewRow newRow = new DataGridViewRow();

                                    DataGridViewTextBoxCell clmName = new DataGridViewTextBoxCell();
                                    clmName.Value = p_name;

                                    DataGridViewTextBoxCell clmPrice = new DataGridViewTextBoxCell();
                                    clmPrice.Value = p_price;

                                    DataGridViewTextBoxCell clmQuantity = new DataGridViewTextBoxCell();
                                    clmQuantity.Value = quantityBought;

                                    DataGridViewTextBoxCell clmTotal = new DataGridViewTextBoxCell();
                                    clmTotal.Value = total;

                                    newRow.Cells.Add(clmName);
                                    newRow.Cells.Add(clmPrice);
                                    newRow.Cells.Add(clmQuantity);
                                    newRow.Cells.Add(clmTotal);

                                    gridOrder.Rows.Add(newRow);

                                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@p_id", p_id);
                                        updateCommand.Parameters.AddWithValue("@p_quantity", quantityBought);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity value.");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Forms.frmDashboard frmDashboard = new Forms.frmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn clmBtnRemove = new DataGridViewButtonColumn();
            clmBtnRemove.HeaderText = "Action";
            clmBtnRemove.Name = "clmBtnRemove";
            clmBtnRemove.Text = "Remove";
            clmBtnRemove.UseColumnTextForButtonValue = true;
            this.gridOrder.Columns.Add(clmBtnRemove);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";


            string sql = "INSERT INTO orders (id, p_name, p_price, o_quantity, o_total) VALUES ( @id, @p_name, @p_price, @o_quantity,@o_total )";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in gridOrder.Rows)
                {
                    string p_name = row.Cells["clmName"].Value.ToString();
                    decimal p_price = decimal.Parse(row.Cells["clmPrice"].Value.ToString());
                    int o_quantity = int.Parse(row.Cells["clmQuantity"].Value.ToString());
                    int o_total = int.Parse(row.Cells["clmTotal"].Value.ToString());
                    int id = 1;

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@p_name", p_name);
                        command.Parameters.AddWithValue("@p_price", p_price);
                        command.Parameters.AddWithValue("@o_quantity", o_quantity);
                        command.Parameters.AddWithValue("@o_total", o_total);

                        command.ExecuteNonQuery();
                    }
                }
            }

            decimal total = 0;

            foreach (DataGridViewRow row in gridOrder.Rows)
            {
                if (row.Cells["clmTotal"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["clmTotal"].Value.ToString(), out decimal value))
                    {
                        total += value;
                    }
                }
            }

            this.lblOrderSubTotal.Text = string.Format("Order Sub Total: {0:n}", total);
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCaramelMac_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string selectQuery = "SELECT * FROM products WHERE p_id = @p_id";
            string updateQuery = "UPDATE products SET p_quantity = p_quantity - @p_quantity WHERE p_id = @p_id";

            string p_id = "6";
            string Quantity = txtCaramelQuantity.Text;

            if (string.IsNullOrEmpty(Quantity))
            {
                Quantity = "1";
            }

            if (int.TryParse(Quantity, out int quantityBought))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p_id", p_id);
                        connection.Open();
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string p_name = reader.GetString("p_name");
                                decimal p_price = reader.GetDecimal("p_price");
                                int p_quantity = reader.GetInt32("p_quantity");

                                reader.Close();

                                if (p_quantity >= quantityBought)
                                {
                                    decimal total = p_price * quantityBought;

                                    DataGridViewRow newRow = new DataGridViewRow();

                                    DataGridViewTextBoxCell clmName = new DataGridViewTextBoxCell();
                                    clmName.Value = p_name;

                                    DataGridViewTextBoxCell clmPrice = new DataGridViewTextBoxCell();
                                    clmPrice.Value = p_price;

                                    DataGridViewTextBoxCell clmQuantity = new DataGridViewTextBoxCell();
                                    clmQuantity.Value = quantityBought;

                                    DataGridViewTextBoxCell clmTotal = new DataGridViewTextBoxCell();
                                    clmTotal.Value = total;

                                    newRow.Cells.Add(clmName);
                                    newRow.Cells.Add(clmPrice);
                                    newRow.Cells.Add(clmQuantity);
                                    newRow.Cells.Add(clmTotal);

                                    gridOrder.Rows.Add(newRow);

                                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@p_id", p_id);
                                        updateCommand.Parameters.AddWithValue("@p_quantity", quantityBought);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity value.");
            }
        }

        private void btnAddCoffeeWC_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string selectQuery = "SELECT * FROM products WHERE p_id = @p_id";
            string updateQuery = "UPDATE products SET p_quantity = p_quantity - @p_quantity WHERE p_id = @p_id";

            string p_id = "7";
            string Quantity = txtCoffeeWCQuantity.Text;

            if (string.IsNullOrEmpty(Quantity))
            {
                Quantity = "1";
            }

            if (int.TryParse(Quantity, out int quantityBought))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p_id", p_id);
                        connection.Open();
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string p_name = reader.GetString("p_name");
                                decimal p_price = reader.GetDecimal("p_price");
                                int p_quantity = reader.GetInt32("p_quantity");

                                reader.Close();

                                if (p_quantity >= quantityBought)
                                {
                                    decimal total = p_price * quantityBought;

                                    DataGridViewRow newRow = new DataGridViewRow();

                                    DataGridViewTextBoxCell clmName = new DataGridViewTextBoxCell();
                                    clmName.Value = p_name;

                                    DataGridViewTextBoxCell clmPrice = new DataGridViewTextBoxCell();
                                    clmPrice.Value = p_price;

                                    DataGridViewTextBoxCell clmQuantity = new DataGridViewTextBoxCell();
                                    clmQuantity.Value = quantityBought;

                                    DataGridViewTextBoxCell clmTotal = new DataGridViewTextBoxCell();
                                    clmTotal.Value = total;

                                    newRow.Cells.Add(clmName);
                                    newRow.Cells.Add(clmPrice);
                                    newRow.Cells.Add(clmQuantity);
                                    newRow.Cells.Add(clmTotal);

                                    gridOrder.Rows.Add(newRow);

                                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@p_id", p_id);
                                        updateCommand.Parameters.AddWithValue("@p_quantity", quantityBought);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity value.");
            }
        }

        private void btnAddCoffeeCocoa_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string selectQuery = "SELECT * FROM products WHERE p_id = @p_id";
            string updateQuery = "UPDATE products SET p_quantity = p_quantity - @p_quantity WHERE p_id = @p_id";

            string p_id = "8";
            string Quantity = txtCocoaQuantity.Text;

            if (string.IsNullOrEmpty(Quantity))
            {
                Quantity = "1";
            }

            if (int.TryParse(Quantity, out int quantityBought))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p_id", p_id);
                        connection.Open();
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string p_name = reader.GetString("p_name");
                                decimal p_price = reader.GetDecimal("p_price");
                                int p_quantity = reader.GetInt32("p_quantity");

                                reader.Close();

                                if (p_quantity >= quantityBought)
                                {
                                    decimal total = p_price * quantityBought;

                                    DataGridViewRow newRow = new DataGridViewRow();

                                    DataGridViewTextBoxCell clmName = new DataGridViewTextBoxCell();
                                    clmName.Value = p_name;

                                    DataGridViewTextBoxCell clmPrice = new DataGridViewTextBoxCell();
                                    clmPrice.Value = p_price;

                                    DataGridViewTextBoxCell clmQuantity = new DataGridViewTextBoxCell();
                                    clmQuantity.Value = quantityBought;

                                    DataGridViewTextBoxCell clmTotal = new DataGridViewTextBoxCell();
                                    clmTotal.Value = total;

                                    newRow.Cells.Add(clmName);
                                    newRow.Cells.Add(clmPrice);
                                    newRow.Cells.Add(clmQuantity);
                                    newRow.Cells.Add(clmTotal);

                                    gridOrder.Rows.Add(newRow);

                                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@p_id", p_id);
                                        updateCommand.Parameters.AddWithValue("@p_quantity", quantityBought);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity value.");
            }
        }

        private void btnAddCappuccino_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string selectQuery = "SELECT * FROM products WHERE p_id = @p_id";
            string updateQuery = "UPDATE products SET p_quantity = p_quantity - @p_quantity WHERE p_id = @p_id";

            string p_id = "9";
            string Quantity = txtCappuccinoQuantity.Text;

            if (string.IsNullOrEmpty(Quantity))
            {
                Quantity = "1";
            }

            if (int.TryParse(Quantity, out int quantityBought))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p_id", p_id);
                        connection.Open();
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string p_name = reader.GetString("p_name");
                                decimal p_price = reader.GetDecimal("p_price");
                                int p_quantity = reader.GetInt32("p_quantity");

                                reader.Close();

                                if (p_quantity >= quantityBought)
                                {
                                    decimal total = p_price * quantityBought;

                                    DataGridViewRow newRow = new DataGridViewRow();

                                    DataGridViewTextBoxCell clmName = new DataGridViewTextBoxCell();
                                    clmName.Value = p_name;

                                    DataGridViewTextBoxCell clmPrice = new DataGridViewTextBoxCell();
                                    clmPrice.Value = p_price;

                                    DataGridViewTextBoxCell clmQuantity = new DataGridViewTextBoxCell();
                                    clmQuantity.Value = quantityBought;

                                    DataGridViewTextBoxCell clmTotal = new DataGridViewTextBoxCell();
                                    clmTotal.Value = total;

                                    newRow.Cells.Add(clmName);
                                    newRow.Cells.Add(clmPrice);
                                    newRow.Cells.Add(clmQuantity);
                                    newRow.Cells.Add(clmTotal);

                                    gridOrder.Rows.Add(newRow);

                                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@p_id", p_id);
                                        updateCommand.Parameters.AddWithValue("@p_quantity", quantityBought);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity value.");
            }
        }

        private void btnAddBlackWC_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=dejabrewpos;user=root;password=;";

            string selectQuery = "SELECT * FROM products WHERE p_id = @p_id";
            string updateQuery = "UPDATE products SET p_quantity = p_quantity - @p_quantity WHERE p_id = @p_id";

            string p_id = "10";
            string Quantity = txtBlackWCQuantity.Text;

             if (string.IsNullOrEmpty(Quantity))
            {
                Quantity = "1";
            }

            if (int.TryParse(Quantity, out int quantityBought))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p_id", p_id);
                        connection.Open();
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string p_name = reader.GetString("p_name");
                                decimal p_price = reader.GetDecimal("p_price");
                                int p_quantity = reader.GetInt32("p_quantity");

                                reader.Close();

                                if (p_quantity >= quantityBought)
                                {
                                    decimal total = p_price * quantityBought;

                                    DataGridViewRow newRow = new DataGridViewRow();

                                    DataGridViewTextBoxCell clmName = new DataGridViewTextBoxCell();
                                    clmName.Value = p_name;

                                    DataGridViewTextBoxCell clmPrice = new DataGridViewTextBoxCell();
                                    clmPrice.Value = p_price;

                                    DataGridViewTextBoxCell clmQuantity = new DataGridViewTextBoxCell();
                                    clmQuantity.Value = quantityBought;

                                    DataGridViewTextBoxCell clmTotal = new DataGridViewTextBoxCell();
                                    clmTotal.Value = total;

                                    newRow.Cells.Add(clmName);
                                    newRow.Cells.Add(clmPrice);
                                    newRow.Cells.Add(clmQuantity);
                                    newRow.Cells.Add(clmTotal);

                                    gridOrder.Rows.Add(newRow);

                                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@p_id", p_id);
                                        updateCommand.Parameters.AddWithValue("@p_quantity", quantityBought);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity value.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gridOrder.Rows.Clear();
            txtAmmountTendered.Clear();
            txtBlackWCQuantity.Clear();
            txtCappuccinoQuantity.Clear();
            txtCaramelQuantity.Clear();
            txtChocoQuantity.Clear();
            txtCocoaQuantity.Clear();
            txtCoffeeWCQuantity.Clear();
            txtMatchaQuantity.Clear();
            txtPepermintQuantity.Clear();
            txtTaroQuantity.Clear();
            txtWinterQuantity.Clear();
        }

        private void lblOrderSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<Cart> cart = new List<Cart>();
            cart.Clear();

            for (int i = 0; i < this.gridOrder.Rows.Count; i++)
            {
                cart.Add(new Cart()
                {
                    Name = this.gridOrder.Rows[i].Cells[0].Value.ToString(),
                    Price = double.Parse(this.gridOrder.Rows[i].Cells[1].Value.ToString()),
                    Quantity = int.Parse(this.gridOrder.Rows[i].Cells[2].Value.ToString()),
                    Total = double.Parse(this.gridOrder.Rows[i].Cells[3].Value.ToString())
                });
            }

            frmPrintOrder frmPrintOrder = new frmPrintOrder();
            ReportViewer rprtReceipt = (ReportViewer)frmPrintOrder.Controls["rprtReceipt"];

            ReportDataSource source = new ReportDataSource("dsCart", cart);
            rprtReceipt.LocalReport.DataSources.Clear();
            rprtReceipt.LocalReport.DataSources.Add(source);

            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pTotalPrice", this.lblOrderSubTotal.Text));
            rprtReceipt.LocalReport.SetParameters(parameters);
            parameters.Add(new ReportParameter("pTotalChange", this.lblTotalChange.Text));
            rprtReceipt.LocalReport.SetParameters(parameters);
            parameters.Add(new ReportParameter("pAmmountTendered", this.txtAmmountTendered.Text));
            rprtReceipt.LocalReport.SetParameters(parameters);

            frmPrintOrder.ShowDialog();
        }

        private void gridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.gridOrder.Rows[e.RowIndex];

            if (row.Cells[4].Selected)
            {
                this.gridOrder.Rows.Remove(row);
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in gridOrder.Rows)
            {
                if (row.Cells["clmTotal"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["clmTotal"].Value.ToString(), out decimal value))
                    {
                        total += value;
                    }
                }
            }

            decimal ammountTendered = decimal.Parse(txtAmmountTendered.Text);

            decimal change =  ammountTendered - total;

            lblTotalChange.Text = string.Format("Total Change: {0:n}", change);
        }
    }
}
