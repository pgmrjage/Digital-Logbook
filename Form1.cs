namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtbox_username.Text;
            string password = txtbox_pass.Text;

            if (username == "admin" &&  password == "123")  //Admin
            {
                MessageBox.Show("Hello Admin");
                Form4 f4 = new Form4();
                f4.Show();

                this.Hide();
            }else if (username == "user" && password == "123")  //User
            {
                MessageBox.Show("Login Successfully");
                Form2 f2 = new Form2();
                f2.Show();
            }
            else { MessageBox.Show("Invalid Credentials, Please Try Again"); }


        }
    }
}
