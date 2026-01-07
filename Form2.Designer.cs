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
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            clearAllToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            user_clear_btn = new Button();
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
            user_clear_btn1 = new Button();
            user_dateEncode_cb = new CheckBox();
            user_dateEncode_gb = new GroupBox();
            user_to_datetimepicker = new DateTimePicker();
            label19 = new Label();
            user_from_datetimepicker = new DateTimePicker();
            label18 = new Label();
            label2 = new Label();
            user_filter_cb = new ComboBox();
            user_record_listbox = new ListBox();
            user_search_txtbox = new TextBox();
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
            user_dateEncode_gb.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(797, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, clearAllToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(122, 22);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(122, 22);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // clearAllToolStripMenuItem
            // 
            clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            clearAllToolStripMenuItem.Size = new Size(122, 22);
            clearAllToolStripMenuItem.Text = "Clear All";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(122, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(122, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(122, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(122, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutUsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(194, 22);
            aboutUsToolStripMenuItem.Text = "About Digital Logbook";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(248, 36);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(505, 462);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(user_clear_btn);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(497, 434);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // user_clear_btn
            // 
            user_clear_btn.Location = new Point(459, 371);
            user_clear_btn.Margin = new Padding(3, 2, 3, 2);
            user_clear_btn.Name = "user_clear_btn";
            user_clear_btn.Size = new Size(82, 22);
            user_clear_btn.TabIndex = 17;
            user_clear_btn.Text = "Clear All";
            user_clear_btn.UseVisualStyleBackColor = true;
            user_clear_btn.Click += user_clear_btn_Click;
            // 
            // user_address_txtbox
            // 
            user_address_txtbox.Location = new Point(158, 147);
            user_address_txtbox.Margin = new Padding(3, 2, 3, 2);
            user_address_txtbox.Name = "user_address_txtbox";
            user_address_txtbox.PlaceholderText = "Complete Address";
            user_address_txtbox.Size = new Size(289, 23);
            user_address_txtbox.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(60, 50);
            label17.Name = "label17";
            label17.Size = new Size(57, 15);
            label17.TabIndex = 0;
            label17.Text = "Surname:";
            // 
            // user_btn_submit
            // 
            user_btn_submit.Location = new Point(547, 371);
            user_btn_submit.Margin = new Padding(3, 2, 3, 2);
            user_btn_submit.Name = "user_btn_submit";
            user_btn_submit.Size = new Size(82, 22);
            user_btn_submit.TabIndex = 3;
            user_btn_submit.Text = "Submit";
            user_btn_submit.TextAlign = ContentAlignment.BottomCenter;
            user_btn_submit.UseVisualStyleBackColor = true;
            user_btn_submit.Click += user_btn_submit_Click;
            // 
            // user_surname_txtbox
            // 
            user_surname_txtbox.Location = new Point(158, 44);
            user_surname_txtbox.Margin = new Padding(3, 2, 3, 2);
            user_surname_txtbox.Name = "user_surname_txtbox";
            user_surname_txtbox.PlaceholderText = "Surname";
            user_surname_txtbox.Size = new Size(167, 23);
            user_surname_txtbox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 152);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 15;
            label4.Text = "Address:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(60, 74);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 2;
            label16.Text = "First Name:";
            // 
            // user_business_txtbox
            // 
            user_business_txtbox.Location = new Point(158, 313);
            user_business_txtbox.Margin = new Padding(3, 2, 3, 2);
            user_business_txtbox.Name = "user_business_txtbox";
            user_business_txtbox.PlaceholderText = "Business";
            user_business_txtbox.Size = new Size(289, 23);
            user_business_txtbox.TabIndex = 14;
            // 
            // user_firstname_txtbox
            // 
            user_firstname_txtbox.Location = new Point(158, 69);
            user_firstname_txtbox.Margin = new Padding(3, 2, 3, 2);
            user_firstname_txtbox.Name = "user_firstname_txtbox";
            user_firstname_txtbox.PlaceholderText = "First Name";
            user_firstname_txtbox.Size = new Size(167, 23);
            user_firstname_txtbox.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(60, 318);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 13;
            label11.Text = "Business:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(60, 99);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 4;
            label15.Text = "Middle Initial:";
            // 
            // user_contact_txtbox
            // 
            user_contact_txtbox.Location = new Point(158, 288);
            user_contact_txtbox.Margin = new Padding(3, 2, 3, 2);
            user_contact_txtbox.Name = "user_contact_txtbox";
            user_contact_txtbox.PlaceholderText = "Cellphone No.";
            user_contact_txtbox.Size = new Size(110, 23);
            user_contact_txtbox.TabIndex = 12;
            // 
            // user_middleinitial_txtbox
            // 
            user_middleinitial_txtbox.Location = new Point(158, 94);
            user_middleinitial_txtbox.Margin = new Padding(3, 2, 3, 2);
            user_middleinitial_txtbox.Name = "user_middleinitial_txtbox";
            user_middleinitial_txtbox.PlaceholderText = "Middle Initial";
            user_middleinitial_txtbox.Size = new Size(167, 23);
            user_middleinitial_txtbox.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(60, 293);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 11;
            label12.Text = "Contact No.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(60, 128);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 6;
            label14.Text = "Suffix:";
            // 
            // user_purpose_txtbox
            // 
            user_purpose_txtbox.Location = new Point(158, 177);
            user_purpose_txtbox.Margin = new Padding(3, 2, 3, 2);
            user_purpose_txtbox.Multiline = true;
            user_purpose_txtbox.Name = "user_purpose_txtbox";
            user_purpose_txtbox.PlaceholderText = "State your Purpose";
            user_purpose_txtbox.Size = new Size(472, 108);
            user_purpose_txtbox.TabIndex = 10;
            // 
            // user_suffix_cb
            // 
            user_suffix_cb.FormattingEnabled = true;
            user_suffix_cb.Location = new Point(158, 122);
            user_suffix_cb.Margin = new Padding(3, 2, 3, 2);
            user_suffix_cb.Name = "user_suffix_cb";
            user_suffix_cb.Size = new Size(59, 23);
            user_suffix_cb.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(60, 177);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 9;
            label13.Text = "Purpose:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(user_clear_btn1);
            tabPage2.Controls.Add(user_dateEncode_cb);
            tabPage2.Controls.Add(user_dateEncode_gb);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(user_filter_cb);
            tabPage2.Controls.Add(user_record_listbox);
            tabPage2.Controls.Add(user_search_txtbox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(710, 434);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // user_clear_btn1
            // 
            user_clear_btn1.Location = new Point(594, 392);
            user_clear_btn1.Margin = new Padding(3, 2, 3, 2);
            user_clear_btn1.Name = "user_clear_btn1";
            user_clear_btn1.Size = new Size(82, 22);
            user_clear_btn1.TabIndex = 18;
            user_clear_btn1.Text = "Clear All";
            user_clear_btn1.UseVisualStyleBackColor = true;
            user_clear_btn1.Click += user_clear_btn1_Click;
            // 
            // user_dateEncode_cb
            // 
            user_dateEncode_cb.AutoSize = true;
            user_dateEncode_cb.Location = new Point(26, 22);
            user_dateEncode_cb.Margin = new Padding(3, 2, 3, 2);
            user_dateEncode_cb.Name = "user_dateEncode_cb";
            user_dateEncode_cb.Size = new Size(102, 19);
            user_dateEncode_cb.TabIndex = 17;
            user_dateEncode_cb.Text = "Date Encoded:";
            user_dateEncode_cb.UseVisualStyleBackColor = true;
            user_dateEncode_cb.CheckedChanged += user_dateEncode_cb_CheckedChanged;
            // 
            // user_dateEncode_gb
            // 
            user_dateEncode_gb.Controls.Add(user_to_datetimepicker);
            user_dateEncode_gb.Controls.Add(label19);
            user_dateEncode_gb.Controls.Add(user_from_datetimepicker);
            user_dateEncode_gb.Controls.Add(label18);
            user_dateEncode_gb.Location = new Point(26, 37);
            user_dateEncode_gb.Margin = new Padding(3, 2, 3, 2);
            user_dateEncode_gb.Name = "user_dateEncode_gb";
            user_dateEncode_gb.Padding = new Padding(3, 2, 3, 2);
            user_dateEncode_gb.Size = new Size(182, 78);
            user_dateEncode_gb.TabIndex = 16;
            user_dateEncode_gb.TabStop = false;
            // 
            // user_to_datetimepicker
            // 
            user_to_datetimepicker.Format = DateTimePickerFormat.Short;
            user_to_datetimepicker.Location = new Point(67, 44);
            user_to_datetimepicker.Margin = new Padding(3, 2, 3, 2);
            user_to_datetimepicker.Name = "user_to_datetimepicker";
            user_to_datetimepicker.Size = new Size(95, 23);
            user_to_datetimepicker.TabIndex = 17;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(22, 50);
            label19.Name = "label19";
            label19.Size = new Size(22, 15);
            label19.TabIndex = 16;
            label19.Text = "To:";
            // 
            // user_from_datetimepicker
            // 
            user_from_datetimepicker.Format = DateTimePickerFormat.Short;
            user_from_datetimepicker.Location = new Point(67, 20);
            user_from_datetimepicker.Margin = new Padding(3, 2, 3, 2);
            user_from_datetimepicker.Name = "user_from_datetimepicker";
            user_from_datetimepicker.Size = new Size(95, 23);
            user_from_datetimepicker.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(22, 25);
            label18.Name = "label18";
            label18.Size = new Size(38, 15);
            label18.TabIndex = 15;
            label18.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(582, 75);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "Filter:";
            // 
            // user_filter_cb
            // 
            user_filter_cb.FormattingEnabled = true;
            user_filter_cb.Location = new Point(626, 69);
            user_filter_cb.Margin = new Padding(3, 2, 3, 2);
            user_filter_cb.Name = "user_filter_cb";
            user_filter_cb.Size = new Size(50, 23);
            user_filter_cb.TabIndex = 10;
            // 
            // user_record_listbox
            // 
            user_record_listbox.FormattingEnabled = true;
            user_record_listbox.ItemHeight = 15;
            user_record_listbox.Location = new Point(26, 137);
            user_record_listbox.Margin = new Padding(3, 2, 3, 2);
            user_record_listbox.Name = "user_record_listbox";
            user_record_listbox.Size = new Size(651, 244);
            user_record_listbox.TabIndex = 9;
            // 
            // user_search_txtbox
            // 
            user_search_txtbox.Location = new Point(488, 94);
            user_search_txtbox.Margin = new Padding(3, 2, 3, 2);
            user_search_txtbox.Name = "user_search_txtbox";
            user_search_txtbox.PlaceholderText = "Search";
            user_search_txtbox.Size = new Size(189, 23);
            user_search_txtbox.TabIndex = 7;
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
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            user_dateEncode_gb.ResumeLayout(false);
            user_dateEncode_gb.PerformLayout();
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private ComboBox user_filter_cb;
        private ListBox user_record_listbox;
        private TextBox user_search_txtbox;
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
        private DateTimePicker user_from_datetimepicker;
        private Button user_clear_btn;
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
        private GroupBox user_dateEncode_gb;
        private Label label18;
        private CheckBox user_dateEncode_cb;
        private DateTimePicker user_to_datetimepicker;
        private Label label19;
        private Button user_clear_btn1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
    }
}