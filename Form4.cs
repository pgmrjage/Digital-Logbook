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
            Panel panelMain = new Panel
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
            panelSidebar.BringToFront();

            Label lblTitle = new Label
            {
                Text = "ADMIN",
                Dock = DockStyle.Top,
                Height = 60,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            }; panelSidebar.Controls.Add(lblTitle);


            Panel Separator = new Panel
            {
                Dock = DockStyle.Top,
                Height = 1,
                BackColor = Color.FromArgb(50,50,50),
            }; panelSidebar.Controls.Add(Separator);



            // ------------ DASHBOARD ------------------
            Panel dashboardPanel = CreateDashboardContent();

            // Sidebar button
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
        // Dashboard Panel
        // =========================
        private Panel CreateDashboardContent()
        {
            Panel dashboardPanel = new Panel
            {
                BackColor = Color.Red, 
                Padding = new Padding(10),
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
                Padding = new Padding(15, 0, 0, 0)
            };

            headerPanel.Controls.Add(headerLabel);
            dashboardPanel.Controls.Add(headerPanel);

            return dashboardPanel;
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
