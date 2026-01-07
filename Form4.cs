using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    

    public partial class Form4 : Form
    {
        //Initialization Section
        Panel panelMain = new Panel();
        private void LoadContent(Control content)
        {
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(content);

        }

        public Form4()
        {
            InitializeComponent();

            panelMain.Name = "admin_panelMain";
            panelMain.BackColor = Color.FromArgb(240, 250, 245);
            panelMain.Dock = DockStyle.Fill;
            this.Controls.Add(panelMain);
            
            Panel panelSidebar = new Panel();
            panelSidebar.Name = "admin_panelSidebar";
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Width = 180;
            panelSidebar.BackColor = Color.FromArgb(30, 30, 30);
            this.Controls.Add(panelSidebar);

           





            Label lblTitle = new Label();
            lblTitle.Text = "ADMIN";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTitle.AutoSize = false;
            lblTitle.Height = 60;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
                panelSidebar.Controls.Add(lblTitle);


            Panel separator = new Panel();
            separator.Height = 1;
            separator.Dock = DockStyle.Top;
            separator.BackColor = Color.FromArgb(50, 50, 50);
                panelSidebar.Controls.Add(separator);





            Button CreateSidebarButton(string text)
            {
                Button btn = new Button();
                btn.Text = text;
                btn.Dock = DockStyle.Top;
                btn.Height = 45;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = Color.White;
                btn.BackColor = Color.FromArgb(30, 30, 30);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(15, 0, 0, 0);

                btn.MouseEnter += (s, e) =>
                    btn.BackColor = Color.FromArgb(45, 45, 45);

                btn.MouseLeave += (s, e) =>
                    btn.BackColor = Color.FromArgb(30, 30, 30);

                return btn;
            }

                               
            panelSidebar.Controls.Add(CreateSidebarButton("Logout"));
            panelSidebar.Controls.Add(CreateSidebarButton("Settings"));
            panelSidebar.Controls.Add(CreateSidebarButton("Reports"));
            panelSidebar.Controls.Add(CreateSidebarButton("Dashboard"));


            string[] sidebtn = { "btnLogout", "btnSettings", "btnReports", "btnDashboard" };
            
            foreach(string btn in sidebtn)
            {
                CreateSidebarButton(btn);
            }






            //===========================================================================
            // DEPARTMENT CHECKBOX
            //===========================================================================
            admin_department_cb.DropDownStyle =  ComboBoxStyle.DropDownList; //set dafault comboBox into dropdown list
            //Tabpage 1: Department
            string[] department = { "", "Tanod", "SK", "Lupon", "Health Center", "Social Worker", "BCPC" };
            foreach (string department_index in department)
            {
                admin_department_cb.Items.Add(department_index);
            }
            //===========================================================================



            //===========================================================================
            // DATE ENCODE CHECKBOX
            //===========================================================================
            //Tabpage 1: Set dateEncode to false
            admin_dateEncode_gb.Enabled = false;
            //===========================================================================

            //===========================================================================
            // ADMIN FILTER RECORD COMBOBOX
            //===========================================================================
            admin_filter_cb.DropDownStyle = ComboBoxStyle.DropDownList;  //set default comboBox into dropdown List
            
            int[] filter = { 5, 10, 15, 20, };
            foreach (int filter_index in filter)
            {
                admin_filter_cb.Items.Add(filter_index);
            }
            admin_filter_cb.Items.Add("All");
            admin_filter_cb.SelectedIndex = 0;
            //===========================================================================




        }







       
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void admin_dateEncode_cb_CheckedChanged(object sender, EventArgs e)
        {
            admin_dateEncode_gb.Enabled = admin_dateEncode_cb.Checked;
        }
    }
}
