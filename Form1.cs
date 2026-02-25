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

        private string connectionString = "Host=localhost;Port=5432;Database=database;Username=postgre;Password=@testing";


        private object pictureBox1;

        public Form1()
        {
            InitializeComponent();
        }
                
        private void btn_login_Click(object sender, EventArgs e)
        {                      
            string username = txtbox_username.Text.Trim();
            string password = txtbox_pass.Text.Trim();

            if (validateUser(username, password))  //Admin Sample Account
            {
                MessageBox.Show("Login Successfully");
                Form4 f4 = new Form4();
                f4.Show();

                this.Hide();
            }
            else if (username == "user" && password == "123")  //User Sample Account
            {
                MessageBox.Show("Login Successfully");
                Form2 f2 = new Form2();
                f2.Show();

                this.Hide();    //hides the login
            }
            else { MessageBox.Show("Invalid Credentials, Please Try Again"); }


        }

        private bool validateUser(string username, string pass)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string Query = "SELECT COUNT(*) FROM account WHERE username=@username AND password=@pass";

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.Parameters.AddWithValue("u", username);
                        cmd.Parameters.AddWithValue("p", pass);

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
