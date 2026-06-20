using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LoginnMobileShop1
{
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();
        }

        // Connection string to your SQL Server database
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S6BET8L\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;Encrypt=False");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) // Add Button
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "INSERT INTO Accessories (AccessoriesId, AccessoriesBrand, AccessoriesModel, AccessoriesStock, AccessoriesPrice) " +
                               "VALUES (@id, @brand, @model, @stock, @price)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text.Trim()));
                cmd.Parameters.AddWithValue("@brand", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@model", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@stock", int.Parse(textBox5.Text.Trim()));
                cmd.Parameters.AddWithValue("@price", int.Parse(textBox4.Text.Trim()));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully!");

                ClearData();
                DisplayData(); // Refresh the DataGridView2
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // Update Button
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "UPDATE Accessories SET AccessoriesBrand = @brand, AccessoriesModel = @model, " +
                               "AccessoriesStock = @stock, AccessoriesPrice = @price WHERE AccessoriesId = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text.Trim()));
                cmd.Parameters.AddWithValue("@brand", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@model", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@stock", int.Parse(textBox5.Text.Trim()));
                cmd.Parameters.AddWithValue("@price", int.Parse(textBox4.Text.Trim()));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!");

                ClearData();
                DisplayData(); // Refresh the DataGridView2
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Delete Button
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "DELETE FROM Accessories WHERE AccessoriesId = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text.Trim()));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully!");

                ClearData();
                DisplayData(); // Refresh the DataGridView2
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void DisplayData()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM Accessories"; // Fetch all records
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind data to dataGridView2
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // Clear Button
        {
            ClearData();
        }

        private void ClearData()
        {   
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Accessories_Load(object sender, EventArgs e)
        {
            DisplayData(); // Load data into DataGridView when the form loads
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show();
            this.Hide();
        }
    }
}
