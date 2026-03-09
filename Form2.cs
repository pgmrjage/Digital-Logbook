using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        //INITIALIZE SERVER
        public class Database()
        {
            private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=yourpassword;Database=yourdb";
            public NpgsqlConnection GetConnection()
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        Panel panelMain = new Panel();

        public Form2()
        {
            InitializeComponent();
            InitializeLayout();

            // Default when Logging In
            Panel dashboard = CreateNewPanel();
            LoadContent(dashboard);
        }

        // =========================
        // INITIAL LAYOUT
        // =========================
        private void InitializeLayout()
        {
            // ------------ MAIN PANEL ------------------
            panelMain = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
            };
            this.Controls.Add(panelMain);

            // ------------ SIDEBAR PANEL ------------------
            Panel panelSidebar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 200,
                BackColor = Color.FromArgb(30, 30, 30),
            };
            this.Controls.Add(panelSidebar);

            Panel Separatorbot = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 1,
                BackColor = Color.FromArgb(50, 50, 50),
            };
            panelSidebar.Controls.Add(Separatorbot);

            Label lblTitle = new Label
            {
                Text = "USER",
                Dock = DockStyle.Bottom,
                Height = 60,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelSidebar.Controls.Add(lblTitle);

            Panel Separatorbot1 = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 1,
                BackColor = Color.FromArgb(50, 50, 50),
            };
            panelSidebar.Controls.Add(Separatorbot1);

            Label lblFooter = new Label
            {
                Text = "© 2026 Decode. All Right Reserved",
                Dock = DockStyle.Bottom,
                Height = 25,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0, 0, 0, 30),
            };
            panelSidebar.Controls.Add(lblFooter);

            Panel Separator = new Panel
            {
                Dock = DockStyle.Top,
                Height = 1,
                BackColor = Color.FromArgb(50, 50, 50),
            };
            panelSidebar.Controls.Add(Separator);

            // ------------ SECTIONS ------------------            
            Panel createnewPanel = CreateNewPanel();
            

            // Sidebar buttons (reverse order)
            Button btnLogout = CreateSidebarButton("Logout");
            btnLogout.Click += Logout_Section;
            panelSidebar.Controls.Add(btnLogout);           

            Button btnCreate = CreateSidebarButton("Create New");
            btnCreate.Click += (s, e) => LoadContent(createnewPanel);
            panelSidebar.Controls.Add(btnCreate);
            
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
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(45, 45, 45);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(30, 30, 30);

            return btn;
        }

        private Button CreateButton(string text)
        {
            var btn = new Button
            {
                Text = text,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(30, 30, 30),
                Width = 120,
                Height = 50,
                FlatStyle = FlatStyle.Flat
            };

            btn.FlatAppearance.BorderSize = 0;
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(50, 50, 50);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(30, 30, 30);

            return btn;
        }

        

        // =========================
        // Create New Section
        // =========================

        private void ClearAll_Function(object sender, EventArgs e)
        {
        }

        private void Submit_Function(object sender, EventArgs e)
        {
        }

        private Panel CreateNewPanel()
        {
            // MAIN
            Panel createnew_main = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
            };

            // HEADER
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
            };

            Label headerLabel = new Label
            {
                Text = "Create New",
                Dock = DockStyle.Fill,
                ForeColor = Color.FromArgb(30, 30, 30),
                Font = new Font("Cascadia Code", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            headerPanel.Controls.Add(headerLabel);

            // BODY
            Panel body_container = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
            };

            FlowLayoutPanel create_flowlayout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
            };

            body_container.Controls.Add(create_flowlayout);

            Label title = new Label
            {
                Text = "Please Input some details.",
                Width = 500,
                Height = 30,
                Font = new Font("Century Gothic", 18),
                Margin = new Padding(8, 0, 0, 10),
            };

            TextBox CreateTextBox(string placeholder, bool multiline = false)
            {
                return new TextBox
                {
                    PlaceholderText = placeholder,
                    Font = new Font("Segoe UI", 10),
                    BorderStyle = BorderStyle.FixedSingle,
                    Height = multiline ? 250 : 50,
                    Multiline = multiline,
                    Margin = new Padding(12, 0, 0, 12),
                    Width = 400,
                };
            }

            create_flowlayout.Controls.Add(title);
            create_flowlayout.Controls.Add(CreateTextBox("Surname"));
            create_flowlayout.Controls.Add(CreateTextBox("First Name"));
            create_flowlayout.Controls.Add(CreateTextBox("Middle Initial"));
            create_flowlayout.Controls.Add(CreateTextBox("Contact No."));
            create_flowlayout.Controls.Add(CreateTextBox("Address"));
            create_flowlayout.Controls.Add(CreateTextBox("Business"));
            create_flowlayout.Controls.Add(CreateTextBox("Purpose", true));

            // FOOTER
            Panel footerPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = Color.Transparent,
            };

            FlowLayoutPanel footerFlow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(10, 10, 10, 10)
            };

            Button clearBtn = new Button
            {
                Text = "Clear All",
                Height = 30,
                Width = 120,
            };

            Button submitBtn = new Button
            {
                Text = "Submit",
                Height = 30,
                Width = 120,
            };

            footerFlow.Controls.Add(clearBtn);
            footerFlow.Controls.Add(submitBtn);
            footerPanel.Controls.Add(footerFlow);

            body_container.Controls.Add(footerPanel);

            // ASSEMBLE
            createnew_main.Controls.Add(body_container);
            createnew_main.Controls.Add(headerPanel);

            return createnew_main;
        }

        // =========================
        // LOGOUT SECTION
        // =========================
        private void load_form1()
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Logout_Section(object sender, EventArgs e)
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
