using System.Data;
using Microsoft.Data.SqlClient;

namespace LoginnMobileShop1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Connection string (Integrated Security=True uses Windows Authentication)
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S6BET8L\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;Encrypt=False");

        private void label4_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve username and password from the textboxes
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            try
            {
                // Open the connection
                conn.Open();

                // Use a parameterized query to prevent SQL injection
                string query = "SELECT COUNT(1) FROM Login WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Execute the query and get the result
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // If a match is found, allow login
                    if (count == 1)
                    {
                        this.Hide();
                        new Display().Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Show the error message
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is closed
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
