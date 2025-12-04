namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            admin_clear_btn = new Button();
            btn_cancel = new Button();
            textBox7 = new TextBox();
            btn_submit = new Button();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 48);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Surname:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 41);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Surname";
            textBox1.Size = new Size(142, 27);
            textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(admin_clear_btn);
            groupBox1.Controls.Add(btn_cancel);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(btn_submit);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(46, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 471);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Information";
            // 
            // admin_clear_btn
            // 
            admin_clear_btn.Location = new Point(297, 414);
            admin_clear_btn.Name = "admin_clear_btn";
            admin_clear_btn.Size = new Size(94, 29);
            admin_clear_btn.TabIndex = 17;
            admin_clear_btn.Text = "Clear All";
            admin_clear_btn.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(49, 414);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 4;
            btn_cancel.Text = "Cancel";
            btn_cancel.TextAlign = ContentAlignment.BottomCenter;
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(161, 178);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Complete Address";
            textBox7.Size = new Size(330, 27);
            textBox7.TabIndex = 16;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(397, 414);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(94, 29);
            btn_submit.TabIndex = 3;
            btn_submit.Text = "Submit";
            btn_submit.TextAlign = ContentAlignment.BottomCenter;
            btn_submit.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 185);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 15;
            label8.Text = "Address:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(161, 362);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Business";
            textBox6.Size = new Size(330, 27);
            textBox6.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 369);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 13;
            label7.Text = "Business:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(161, 329);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Cellphone No.";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 336);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 11;
            label6.Text = "Contact No.";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(161, 218);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "State your Purpose";
            textBox4.Size = new Size(330, 105);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 218);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 9;
            label5.Text = "Purpose:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(161, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(67, 28);
            comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 152);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Suffix:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(161, 107);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Middle Initial";
            textBox3.Size = new Size(142, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 114);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "Middle Initial:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 74);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "First Name";
            textBox2.Size = new Size(142, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 81);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "First Name:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 558);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private Button btn_submit;
        private Button btn_cancel;
        private Button admin_clear_btn;
    }
}