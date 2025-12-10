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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            user_clear_btn = new Button();
            user_btn_cancel = new Button();
            user_address_txtbox = new TextBox();
            label17 = new Label();
            user_btn_submit = new Button();
            user_surname_txtbox = new TextBox();
            label4 = new Label();
            label16 = new Label();
            user_business_txtbox = new TextBox();
            user_firstname_txtbox = new TextBox();
            label11 = new Label();
            label15 = new Label();
            user_contact_txtbox = new TextBox();
            user_middleinitial_txtbox = new TextBox();
            label12 = new Label();
            label14 = new Label();
            user_purpose_txtbox = new TextBox();
            user_suffix_cb = new ComboBox();
            label13 = new Label();
            tabPage2 = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            textBox9 = new TextBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            listBox2 = new ListBox();
            textBox2 = new TextBox();
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
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(911, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, logoutToolStripMenuItem, helpToolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(139, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(135, 26);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(139, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(139, 26);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(139, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutUsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(153, 26);
            aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(40, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(820, 616);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(user_clear_btn);
            tabPage1.Controls.Add(user_btn_cancel);
            tabPage1.Controls.Add(user_address_txtbox);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(user_btn_submit);
            tabPage1.Controls.Add(user_surname_txtbox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(user_business_txtbox);
            tabPage1.Controls.Add(user_firstname_txtbox);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(user_contact_txtbox);
            tabPage1.Controls.Add(user_middleinitial_txtbox);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(user_purpose_txtbox);
            tabPage1.Controls.Add(user_suffix_cb);
            tabPage1.Controls.Add(label13);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(812, 583);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // user_clear_btn
            // 
            user_clear_btn.Location = new Point(525, 495);
            user_clear_btn.Name = "user_clear_btn";
            user_clear_btn.Size = new Size(94, 29);
            user_clear_btn.TabIndex = 17;
            user_clear_btn.Text = "Clear All";
            user_clear_btn.UseVisualStyleBackColor = true;
            user_clear_btn.Click += user_clear_btn_Click;
            // 
            // user_btn_cancel
            // 
            user_btn_cancel.Location = new Point(73, 495);
            user_btn_cancel.Name = "user_btn_cancel";
            user_btn_cancel.Size = new Size(94, 29);
            user_btn_cancel.TabIndex = 4;
            user_btn_cancel.Text = "Cancel";
            user_btn_cancel.TextAlign = ContentAlignment.BottomCenter;
            user_btn_cancel.UseVisualStyleBackColor = true;
            user_btn_cancel.Click += user_btn_cancel_Click;
            // 
            // user_address_txtbox
            // 
            user_address_txtbox.Location = new Point(180, 196);
            user_address_txtbox.Name = "user_address_txtbox";
            user_address_txtbox.PlaceholderText = "Complete Address";
            user_address_txtbox.Size = new Size(330, 27);
            user_address_txtbox.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(68, 66);
            label17.Name = "label17";
            label17.Size = new Size(70, 20);
            label17.TabIndex = 0;
            label17.Text = "Surname:";
            // 
            // user_btn_submit
            // 
            user_btn_submit.Location = new Point(625, 495);
            user_btn_submit.Name = "user_btn_submit";
            user_btn_submit.Size = new Size(94, 29);
            user_btn_submit.TabIndex = 3;
            user_btn_submit.Text = "Submit";
            user_btn_submit.TextAlign = ContentAlignment.BottomCenter;
            user_btn_submit.UseVisualStyleBackColor = true;
            // 
            // user_surname_txtbox
            // 
            user_surname_txtbox.Location = new Point(180, 59);
            user_surname_txtbox.Name = "user_surname_txtbox";
            user_surname_txtbox.PlaceholderText = "Surname";
            user_surname_txtbox.Size = new Size(190, 27);
            user_surname_txtbox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 203);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 15;
            label4.Text = "Address:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(68, 99);
            label16.Name = "label16";
            label16.Size = new Size(83, 20);
            label16.TabIndex = 2;
            label16.Text = "First Name:";
            // 
            // user_business_txtbox
            // 
            user_business_txtbox.Location = new Point(180, 417);
            user_business_txtbox.Name = "user_business_txtbox";
            user_business_txtbox.PlaceholderText = "Business";
            user_business_txtbox.Size = new Size(330, 27);
            user_business_txtbox.TabIndex = 14;
            // 
            // user_firstname_txtbox
            // 
            user_firstname_txtbox.Location = new Point(180, 92);
            user_firstname_txtbox.Name = "user_firstname_txtbox";
            user_firstname_txtbox.PlaceholderText = "First Name";
            user_firstname_txtbox.Size = new Size(190, 27);
            user_firstname_txtbox.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(68, 424);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 13;
            label11.Text = "Business:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(68, 132);
            label15.Name = "label15";
            label15.Size = new Size(100, 20);
            label15.TabIndex = 4;
            label15.Text = "Middle Initial:";
            // 
            // user_contact_txtbox
            // 
            user_contact_txtbox.Location = new Point(180, 384);
            user_contact_txtbox.Name = "user_contact_txtbox";
            user_contact_txtbox.PlaceholderText = "Cellphone No.";
            user_contact_txtbox.Size = new Size(125, 27);
            user_contact_txtbox.TabIndex = 12;
            // 
            // user_middleinitial_txtbox
            // 
            user_middleinitial_txtbox.Location = new Point(180, 125);
            user_middleinitial_txtbox.Name = "user_middleinitial_txtbox";
            user_middleinitial_txtbox.PlaceholderText = "Middle Initial";
            user_middleinitial_txtbox.Size = new Size(190, 27);
            user_middleinitial_txtbox.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(68, 391);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 11;
            label12.Text = "Contact No.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(68, 170);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 6;
            label14.Text = "Suffix:";
            // 
            // user_purpose_txtbox
            // 
            user_purpose_txtbox.Location = new Point(180, 236);
            user_purpose_txtbox.Multiline = true;
            user_purpose_txtbox.Name = "user_purpose_txtbox";
            user_purpose_txtbox.PlaceholderText = "State your Purpose";
            user_purpose_txtbox.Size = new Size(539, 142);
            user_purpose_txtbox.TabIndex = 10;
            // 
            // user_suffix_cb
            // 
            user_suffix_cb.FormattingEnabled = true;
            user_suffix_cb.Location = new Point(180, 162);
            user_suffix_cb.Name = "user_suffix_cb";
            user_suffix_cb.Size = new Size(67, 28);
            user_suffix_cb.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(68, 236);
            label13.Name = "label13";
            label13.Size = new Size(65, 20);
            label13.TabIndex = 9;
            label13.Text = "Purpose:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(812, 583);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(30, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(30, 515);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(102, 27);
            textBox9.TabIndex = 12;
            textBox9.Text = "EDIT";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(665, 38);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 11;
            label2.Text = "Filter:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(716, 30);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(57, 28);
            comboBox2.TabIndex = 10;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(30, 103);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(743, 384);
            listBox2.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(558, 65);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 7;
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
            btn_cancel.Click += btn_clearall_Click;
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
            textBox8.Size = new Size(164, 27);
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
            textBox7.Size = new Size(255, 27);
            textBox7.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 69);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First Name";
            textBox1.Size = new Size(164, 27);
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
            textBox6.Size = new Size(255, 27);
            textBox6.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 102);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Middle Initial";
            textBox3.Size = new Size(164, 27);
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
            textBox5.Size = new Size(164, 27);
            textBox5.TabIndex = 28;
            // 
            // suffix_comboBox
            // 
            suffix_comboBox.FormattingEnabled = true;
            suffix_comboBox.Location = new Point(138, 139);
            suffix_comboBox.Name = "suffix_comboBox";
            suffix_comboBox.Size = new Size(67, 28);
            suffix_comboBox.TabIndex = 24;
            suffix_comboBox.SelectedIndexChanged += suffix_comboBox_SelectedIndexChanged;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 714);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private ComboBox comboBox2;
        private ListBox listBox2;
        private TextBox textBox2;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox user_address_txtbox;
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
        private TextBox textBox9;
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private Button user_clear_btn;
        private Button user_btn_cancel;
        private Button user_btn_submit;
        private Label label4;
        private TextBox user_business_txtbox;
        private Label label11;
        private TextBox user_contact_txtbox;
        private Label label12;
        private TextBox user_purpose_txtbox;
        private Label label13;
        private ComboBox user_suffix_cb;
        private Label label14;
        private TextBox user_middleinitial_txtbox;
        private Label label15;
        private TextBox user_firstname_txtbox;
        private Label label16;
        private TextBox user_surname_txtbox;
        private Label label17;
    }
}