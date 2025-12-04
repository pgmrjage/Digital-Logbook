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
            txtbox_username = new TextBox();
            label1 = new Label();
            btn_login = new Button();
            label2 = new Label();
            txtbox_pass = new TextBox();
            SuspendLayout();
            // 
            // txtbox_username
            // 
            txtbox_username.Location = new Point(98, 129);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(179, 27);
            txtbox_username.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 106);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(98, 243);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(179, 50);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 173);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // txtbox_pass
            // 
            txtbox_pass.Location = new Point(98, 196);
            txtbox_pass.Name = "txtbox_pass";
            txtbox_pass.Size = new Size(179, 27);
            txtbox_pass.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 409);
            Controls.Add(label2);
            Controls.Add(txtbox_pass);
            Controls.Add(btn_login);
            Controls.Add(label1);
            Controls.Add(txtbox_username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_username;
        private Label label1;
        private Button btn_login;
        private Label label2;
        private TextBox txtbox_pass;
    }
}
