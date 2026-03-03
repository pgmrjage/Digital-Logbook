using System.Windows.Forms;
using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Runtime.InteropServices.Marshalling;
using System.IO;
using Npgsql;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {

        private string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=@ninjacsx1";

        public Form1()
        {
            InitializeComponent();
        }
                
        private void btn_login_Click(object sender, EventArgs e)
        {                      
            string username = txtbox_username.Text;
            string password = txtbox_pass.Text;

            string role = validateUser(username, password);

            if (role == "admin")
            {
                MessageBox.Show("Admin Login Successfully");
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else if (role == "client")
            {
                MessageBox.Show("User Login Successfully");
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid Credentials, Please Try Again");

            
        }

        private string validateUser(string username, string pass)
        {
            try
            {
                // Make sure connectionString points to your PostgreSQL server
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Correct table and column names
                    string query = "SELECT role FROM account WHERE username=@username AND pass=@pass";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Add parameters matching the placeholders in the query
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("pass", pass);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                            return result.ToString();
                        else
                            return null;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return null;
            }
        }
    }
}
