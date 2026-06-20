using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginnMobileShop1
{
    public partial class Mobile : Form
    {
        public Mobile()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S6BET8L\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;Encrypt=False");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "INSERT INTO MobileData (MobileId, MobileBrand, MobileModel, MobilePrice, MobileStock, MobileRam, MobileRom, MobileCam) " +
                               "VALUES (@id, @brand, @model, @price, @stock, @ram, @rom, @camera)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Parameters for the query
                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text.Trim()));
                cmd.Parameters.AddWithValue("@brand", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@model", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@price", decimal.Parse(textBox4.Text.Trim()));
                cmd.Parameters.AddWithValue("@stock", int.Parse(textBox5.Text.Trim()));
                cmd.Parameters.AddWithValue("@ram", comboBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@rom", comboBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@camera", textBox6.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Mobile Record Added Successfully!");

                ClearFields();
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "UPDATE MobileData SET MobileBrand = @brand, MobileModel = @model, MobilePrice = @price, " +
                               "MobileStock = @stock, MobileRam = @ram, MobileRom = @rom, MobileCam = @camera WHERE MobileId = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text.Trim()));
                cmd.Parameters.AddWithValue("@brand", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@model", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@price", decimal.Parse(textBox4.Text.Trim()));
                cmd.Parameters.AddWithValue("@stock", int.Parse(textBox5.Text.Trim()));
                cmd.Parameters.AddWithValue("@ram", comboBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@rom", comboBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@camera", textBox6.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Mobile Record Updated Successfully!");

                ClearFields();
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "DELETE FROM MobileData WHERE MobileId = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text.Trim()));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Mobile Record Deleted Successfully!");

                ClearFields();
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void DisplayData()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "SELECT * FROM MobileData"; // Fetch all records from Mobiles table
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind data to the DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void Mobile_Load(object sender, EventArgs e)
        {
            DisplayData(); // Load data when form loads
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show();
            this.Hide();
        }
    }
}
