namespace WinFormsApp1
{
    partial class Form2
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
            btn_cancel = new Button();
            btn_submit = new Button();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label3 = new Label();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            suffix_comboBox = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(26, 453);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 34;
            btn_cancel.Text = "Clear All";
            btn_cancel.TextAlign = ContentAlignment.BottomCenter;
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(126, 453);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(94, 29);
            btn_submit.TabIndex = 33;
            btn_submit.Text = "Submit";
            btn_submit.TextAlign = ContentAlignment.BottomCenter;
            btn_submit.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(138, 36);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Surname";
            textBox8.Size = new Size(164, 23);
            textBox8.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 76);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 19;
            label9.Text = "First Name:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(138, 206);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Complete Address";
            textBox7.Size = new Size(255, 23);
            textBox7.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 69);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First Name";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 213);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 31;
            label8.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 109);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 21;
            label3.Text = "Middle Initial:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(138, 241);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Business";
            textBox6.Size = new Size(255, 23);
            textBox6.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 102);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Middle Initial";
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 248);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 29;
            label7.Text = "Business:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 147);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 23;
            label1.Text = "Suffix:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(138, 173);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Contact No.";
            textBox5.Size = new Size(164, 23);
            textBox5.TabIndex = 28;
            // 
            // suffix_comboBox
            // 
            suffix_comboBox.FormattingEnabled = true;
            suffix_comboBox.Location = new Point(138, 139);
            suffix_comboBox.Name = "suffix_comboBox";
            suffix_comboBox.Size = new Size(67, 23);
            suffix_comboBox.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 180);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 27;
            label6.Text = "Contact No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 279);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 25;
            label5.Text = "Purpose:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 43);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 17;
            label10.Text = "Surname:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 536);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private ComboBox suffix_comboBox;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox8;
        private Label label10;
        private Button btn_cancel;
        private Button btn_submit;
    }
}