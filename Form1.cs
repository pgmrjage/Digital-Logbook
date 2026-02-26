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

        private string connectionString = "Host=localhost;Port=5432;Database=account;Username=postgre;Password=@ninjacsx1";


        private object pictureBox1;

        public Form1()
        {
            InitializeComponent();
        }
                
        private void btn_login_Click(object sender, EventArgs e)
        {                      
            string username = txtbox_username.Text;
            string password = txtbox_pass.Text;

            if (validateUser(username, password))  //Admin Sample Account
            {
                MessageBox.Show("Login Successfully");
                Form4 f4 = new Form4();
                f4.Show();

                this.Hide();
            }
            
            else { MessageBox.Show("Invalid Credentials, Please Try Again"); }


        }

        private bool validateUser(string username, string pass)
        {
            try
            {
                // Make sure connectionString points to your PostgreSQL server
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Correct table and column names
                    string query = "SELECT COUNT(*) FROM account WHERE username=@username AND pass=@pass";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Add parameters matching the placeholders in the query
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("pass", pass);

                        // Execute the query and check if at least one row matches
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }
    }
}
