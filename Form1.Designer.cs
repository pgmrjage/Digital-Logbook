namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBox pictureBox1;
            txtbox_username = new TextBox();
            btn_login = new Button();
            txtbox_pass = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Barangay_Mabuhay_Logo;
            pictureBox1.Location = new Point(67, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtbox_username
            // 
            txtbox_username.Location = new Point(366, 140);
            txtbox_username.Margin = new Padding(3, 2, 3, 2);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.PlaceholderText = "Username";
            txtbox_username.Size = new Size(191, 23);
            txtbox_username.TabIndex = 0;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(64, 64, 64);
            btn_login.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(382, 214);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(157, 38);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txtbox_pass
            // 
            txtbox_pass.ImeMode = ImeMode.NoControl;
            txtbox_pass.Location = new Point(366, 172);
            txtbox_pass.Margin = new Padding(3, 2, 3, 2);
            txtbox_pass.Name = "txtbox_pass";
            txtbox_pass.PlaceholderText = "Password";
            txtbox_pass.Size = new Size(191, 23);
            txtbox_pass.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 319);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 205);
            label2.Name = "label2";
            label2.Size = new Size(238, 32);
            label2.TabIndex = 1;
            label2.Text = "Barangay Mabuhay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 108);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 6;
            label1.Text = "User Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(361, 57);
            label3.Name = "label3";
            label3.Size = new Size(196, 32);
            label3.TabIndex = 7;
            label3.Text = "Welcome, User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 241);
            label4.Name = "label4";
            label4.Size = new Size(145, 21);
            label4.TabIndex = 2;
            label4.Text = "Digital Logbook";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            ClientSize = new Size(625, 319);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtbox_pass);
            Controls.Add(btn_login);
            Controls.Add(txtbox_username);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_username;
        private Button btn_login;
        private TextBox txtbox_pass;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
