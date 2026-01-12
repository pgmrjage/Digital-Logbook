using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        
        Panel panelMain = new Panel();

        public Form4()
        {
            InitializeComponent();
            InitializeLayout();
        }

        private void InitializeLayout()
        {

            // ------------ MAIN PANEL ------------------
            panelMain = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
            }; this.Controls.Add(panelMain);


            // ------------ SIDEBAR PANEL ------------------
            Panel panelSidebar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 200,
                BackColor = Color.FromArgb(30,30,30),
            }; this.Controls.Add(panelSidebar);
            //panelSidebar.BringToFront();      // somewhat bug due to hiding the content behind it

            Label lblTitle = new Label
            {
                Text = "ADMIN",
                Dock = DockStyle.Top,
                Height = 60,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            }; panelSidebar.Controls.Add(lblTitle);

            Label lblFooter = new Label
            {
                Text = "© 2026 Decode. All Right Reserved",
                Dock= DockStyle.Bottom,
                Height = 25,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding (0,0,0,30),
               
            };  panelSidebar.Controls.Add(lblFooter);


            Panel Separator = new Panel
            {
                Dock = DockStyle.Top,
                Height = 1,
                BackColor = Color.FromArgb(50,50,50),
            }; panelSidebar.Controls.Add(Separator);



            // ------------ DASHBOARD ------------------
            Panel dashboardPanel = CreateDashboardContent();
            Panel createnewPanel = CreateNewPanel();

            // Sidebar button (REVERSE ORDER)
            Button btnLogoout = CreateSidebarButton("Logout");
            //btnLogoout.Click += (s, e) => LoadContent(dashboardPanel);
            panelSidebar.Controls.Add(btnLogoout);

            Button btnAbout = CreateSidebarButton("About Us");
            //btnAbout.Click += (s, e) => LoadContent();
            panelSidebar.Controls.Add(btnAbout);

            Button btnCreate = CreateSidebarButton("Create New");
            btnCreate.Click += (s, e) => LoadContent(createnewPanel);
            panelSidebar.Controls.Add(btnCreate);

            Button btnDashboard = CreateSidebarButton("Dashboard");
            btnDashboard.Click += (s, e) => LoadContent(dashboardPanel);
            panelSidebar.Controls.Add(btnDashboard);

            

            




        }


        // =========================
        // Content Loader
        // =========================
        private void LoadContent(Control content)
        {
            panelMain.Controls.Clear();
            content.Dock = DockStyle.Fill;
            panelMain.Controls.Add(content);
        }

        // =========================
        // Sidebar Button Factory
        // =========================
        private Button CreateSidebarButton(string text)
        {
            Button btn = new Button
            {
                Text = text,
                Dock = DockStyle.Top,
                Height = 45,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(30, 30, 30),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(15, 0, 0, 0)
            };

            btn.FlatAppearance.BorderSize = 0;

            btn.MouseEnter += (s, e) =>
                btn.BackColor = Color.FromArgb(45, 45, 45);

            btn.MouseLeave += (s, e) =>
                btn.BackColor = Color.FromArgb(30, 30, 30);

            return btn;
        }




        // =========================
        // Dashboard Panel
        // =========================
        private Panel CreateDashboardContent()
        {
            Panel dashboardPanel = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                //Padding = new Padding(10),
            };

            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,   
                Height = 60,
                BackColor= Color.DarkBlue,
            };

            Label headerLabel = new Label
            {
                Text = "Dashboard",
                Dock= DockStyle.Fill,
                ForeColor = Color.White,
                Font = new Font("Century Gothic", 24),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };


            Panel testpanel = new Panel
            {
                Padding = new Padding(10, 10, 10, 10),
                Dock = DockStyle.Top,
                BackColor = Color.Yellow,
                
            };


            // Add some test content to see if it's working
            Label testLabel = new Label
            {
                Text = "This is the dashboard content",
                Font = new Font("Segoe UI", 12),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                //Location = new Point(50, 80),
                //AutoSize = true
            };




            //reverse order?? form bot to top
            //headerPanel.Controls.Add(headerLabel);
            //dashboardPanel.Controls.Add(headerPanel);

            // Add controls in correct order
            headerPanel.Controls.Add(headerLabel);
            dashboardPanel.Controls.Add(headerPanel);
            dashboardPanel.Controls.Add(testLabel);
            dashboardPanel.Controls.Add(testpanel);

            return dashboardPanel;
        }


        // =========================
        // Create New Panel
        // =========================
        private Panel CreateNewPanel()
        {
            Panel createnew = new Panel()
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
            };

            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.DarkBlue,
            };

            Label headerLabel = new Label
            {
                Text = "Create New",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Font = new Font("Century Gothic", 24),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };


            headerPanel.Controls.Add(headerLabel);
            createnew.Controls.Add(headerPanel);

            return createnew;

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
                load_form1();
                this.Close();

            }

        }

        


    }
}
