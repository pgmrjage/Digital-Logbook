using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
            //panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(content);

        }


        


        private void load_form1()
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                load_form1 ();
                this.Close();

            }

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


            // DASHBOARD SECTION
            //========================================================================
            Panel dashboardPanel = new Panel {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
            };

            Label dashboard_Header = new Label
            {
                Height = 50,
                Dock = DockStyle.Top,
                Text = "Dashboard",
                Font = new Font("Century Gothic", 24),
                ForeColor = Color.Black,
                //BackColor = Color.Red,                    //just testing
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(15,10,0,0)
            };
            dashboardPanel.Controls.Add(dashboard_Header); //Call 




            TableLayoutPanel admin_layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
            };
            admin_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            admin_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 10));


            FlowLayoutPanel f1 = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                Height =150,
                BackColor = Color.DarkCyan,
                FlowDirection = FlowDirection.TopDown,  // Optional for vertical stacking
                Padding = new Padding(20)
            };

            Label f1_header = new Label()
            {
                AutoSize = true,
                Text = "Dashboard Header",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold)
            };

            f1.Controls.Add(f1_header);





            FlowLayoutPanel f2 = new FlowLayoutPanel()
            {
                Name = "admin_dashboard_flowlayoutpanel2",
                Dock = DockStyle.Fill,
                BackColor = Color.DarkRed,
            };
            //dashboardPanel.Controls.Add(f2);

                                               

            admin_layout.Controls.Add(f1, 0, 0);
            admin_layout.Controls.Add(f2, 0, 1);

            dashboardPanel.Controls.Add(admin_layout);



            

            //========================================================================







            Panel createNewPanel = new Panel { };
            createNewPanel.Controls.Add(new Label
            {
                Text = "Create New Page",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,

            });
            Panel reportsPanel = new Panel { };
            reportsPanel.Controls.Add(new Label
            {
                Text = "Reports Page",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,

            });



            
            //ABOUT US
            Panel aboutPanel = new Panel { 
                Dock = DockStyle.Fill,
                BackColor = Color.White,
            };

            Label aboutHeader = new Label {
                Height = 50,
                Font = new Font("Century Gothic", 24, FontStyle.Bold),
                Dock = DockStyle.Top,
                Text = "About Us",
                BackColor = Color.Red,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20,0,0,0) // top, left, bottom, right
            };

            aboutPanel.Controls.Add(aboutHeader);




            Button abouttest = new Button {
                Location = new Point(50, 70),
                Height = 25,
                Width = 75,
                Text = "OK",
                TextAlign = ContentAlignment.MiddleCenter,
            };
            aboutPanel.Controls.Add(abouttest);


            //aboutPanel.Controls.Add(new Label
            //{
            //    Height = 50,
            //    Font = new Font("Century Gothic", 24),
            //    BackColor = Color.Red,
            //    Text = "About Us Page",
            //    Dock = DockStyle.Top,
            //    TextAlign = ContentAlignment.MiddleLeft,
            //});

            Label aboutContent = new Label
            {
                Text = "Page is under Maintenance",
                Dock = DockStyle.Fill,                
                TextAlign = ContentAlignment.MiddleCenter,
            };

            aboutPanel.Controls.Add(aboutContent);

           
            





            Button btnDashboard = CreateSidebarButton("Dashboard");
            btnDashboard.Click += (s, e) => LoadContent(dashboardPanel);
            Button btnCreateNew = CreateSidebarButton("Create New");
            btnCreateNew.Click += (s, e) => LoadContent(createNewPanel);
            Button btnReports = CreateSidebarButton("Reports");
            btnReports.Click += (s, e) => LoadContent(reportsPanel);
            Button btnAbout = CreateSidebarButton("About Us");
            btnAbout.Click += (s, e) => LoadContent(aboutPanel);
            Button btnLogout = CreateSidebarButton("Logout");
            btnLogout.Click += btn_logout_Click;


            //reverse order
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnAbout);
            panelSidebar.Controls.Add(btnReports);
            panelSidebar.Controls.Add(btnCreateNew);
            panelSidebar.Controls.Add(btnDashboard);
            








            //===========================================================================
            // DEPARTMENT CHECKBOX
            //===========================================================================
            //admin_department_cb.DropDownStyle =  ComboBoxStyle.DropDownList; //set dafault comboBox into dropdown list
            ////Tabpage 1: Department
            //string[] department = { "", "Tanod", "SK", "Lupon", "Health Center", "Social Worker", "BCPC" };
            //foreach (string department_index in department)
            //{
            //    admin_department_cb.Items.Add(department_index);
            //}
            //===========================================================================



            //===========================================================================
            // DATE ENCODE CHECKBOX
            //===========================================================================
            //Tabpage 1: Set dateEncode to false
            //admin_dateEncode_gb.Enabled = false;
            //===========================================================================

            //===========================================================================
            // ADMIN FILTER RECORD COMBOBOX
            //===========================================================================
            //admin_filter_cb.DropDownStyle = ComboBoxStyle.DropDownList;  //set default comboBox into dropdown List
            
            //int[] filter = { 5, 10, 15, 20, };
            //foreach (int filter_index in filter)
            //{
            //    admin_filter_cb.Items.Add(filter_index);
            //}
            //admin_filter_cb.Items.Add("All");
            //admin_filter_cb.SelectedIndex = 0;
            //===========================================================================




        }







       
        //private void createToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form3 f3 = new Form3();
        //    this.Hide();
        //    f3.Show();
        //}

        //private void admin_dateEncode_cb_CheckedChanged(object sender, EventArgs e)
        //{
        //    admin_dateEncode_gb.Enabled = admin_dateEncode_cb.Checked;
        //}
    }
}
