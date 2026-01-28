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
            label1 = new Label();
            btn_login = new Button();
            label2 = new Label();
            txtbox_pass = new TextBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Barangay_Mabuhay_Logo;
            pictureBox1.Location = new Point(323, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtbox_username
            // 
            txtbox_username.Location = new Point(360, 99);
            txtbox_username.Margin = new Padding(3, 2, 3, 2);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(157, 23);
            txtbox_username.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 82);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(360, 184);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(157, 38);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 132);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // txtbox_pass
            // 
            txtbox_pass.Location = new Point(360, 149);
            txtbox_pass.Margin = new Padding(3, 2, 3, 2);
            txtbox_pass.Name = "txtbox_pass";
            txtbox_pass.Size = new Size(157, 23);
            txtbox_pass.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 319);
            panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(29, 37);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(625, 319);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtbox_pass);
            Controls.Add(btn_login);
            Controls.Add(label1);
            Controls.Add(txtbox_username);
            HelpButton = true;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_username;
        private Label label1;
        private Button btn_login;
        private Label label2;
        private TextBox txtbox_pass;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
