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

            // Default when Logging In
            Panel dashboard = Dashboard_Section();
            LoadContent(dashboard);

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

            Panel Separatorbot = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 1,
                BackColor = Color.FromArgb(50, 50, 50),
            }; panelSidebar.Controls.Add(Separatorbot);

            Label lblTitle = new Label
            {
                Text = "ADMIN",
                Dock = DockStyle.Bottom,
                Height = 60,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            }; panelSidebar.Controls.Add(lblTitle);

            Panel Separatorbot1 = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 1,
                BackColor = Color.FromArgb(50, 50, 50),
            }; panelSidebar.Controls.Add(Separatorbot1);

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
            Panel dashboardPanel = Dashboard_Section();
            Panel createnewPanel = CreateNewPanel();
            Panel summaryPanel = Summary_Section();

            // Sidebar button (REVERSE ORDER)
            Button btnLogoout = CreateSidebarButton("Logout");
            //btnLogoout.Click += (s, e) => LoadContent(dashboardPanel);
            panelSidebar.Controls.Add(btnLogoout);

            Button btnSummary = CreateSidebarButton("Summary");
            btnSummary.Click += (s, e) => LoadContent(summaryPanel);
            panelSidebar.Controls.Add(btnSummary);

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
        // Dashboard Panel
        // =========================
                
        private Panel Dashboard_Section()
        {
            // ===== ROOT =====
            var dashboardPanel = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill
            };

            // ===== HEADER =====
            var headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.White
                
            };

            var headerLabel = new Label
            {
                Text = "Dashboard",
                Dock = DockStyle.Fill,
                ForeColor = Color.FromArgb(30,30,30),
                Font = new Font("Cascadia Code", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };
            headerPanel.Controls.Add(headerLabel);

            // ===== MAIN =====
            var dashmain = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                //BackColor = Color.Yellow
            };

            var mainLayout = new TableLayoutPanel
            {
                RowCount = 2,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(240,240,240),
                //CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60));

            // ===== INFO BOXES =====
            var dashBoxLayout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                AutoScroll = true
            };

            // Example Box 1
            var box1 = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                BackColor = Color.FromArgb(30, 30, 30),
                Width = 250,
                Height = 150,
                Margin = new Padding(10)
            };
            box1.Controls.Add(new Label { Text = "Counts", ForeColor = Color.White, Font = new Font("Century Gothic", 16), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter });
            box1.Controls.Add(new Label { Text = "240", ForeColor = Color.White, Font = new Font("Century Gothic", 48), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter });

            // Example Box 2
            var box2 = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                BackColor = Color.FromArgb(30, 30, 30),
                Width = 250,
                Height = 150,
                Margin = new Padding(10)
            };
            box2.Controls.Add(new Label { Text = "Users", ForeColor = Color.White, Font = new Font("Century Gothic", 16), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter });
            box2.Controls.Add(new Label { Text = "120", ForeColor = Color.White, Font = new Font("Century Gothic", 48), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter });

            dashBoxLayout.Controls.Add(box1);
            dashBoxLayout.Controls.Add(box2);

            mainLayout.Controls.Add(dashBoxLayout, 0, 0);

            // ===== RECORDS =====
            var recordsPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20) };
            var searchPanel = new Panel { Dock = DockStyle.Top, Height = 50 };
            var recordPanel = new Panel { Dock = DockStyle.Fill };

            var searchBox = new TextBox { PlaceholderText = "Search", Dock = DockStyle.Left, Width = 200 };
            var filterCombo = new ComboBox { Dock = DockStyle.Left, Width = 120,};
            var recordsList = new ListBox { Dock = DockStyle.Fill };

            searchPanel.Controls.Add(filterCombo);
            searchPanel.Controls.Add(searchBox);
            recordPanel.Controls.Add(recordsList);

            // Add search first, then records
            recordsPanel.Controls.Add(searchPanel);
            recordsPanel.Controls.Add(recordPanel);

            mainLayout.Controls.Add(recordsPanel, 0, 1);
            dashmain.Controls.Add(mainLayout);

            // ===== FOOTER =====
            var footer = new Panel { Dock = DockStyle.Bottom,  Height = 70 };
            var buttonLayout = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(10), WrapContents = false, AutoSize = true };
            string[] btnNames = { "Edit", "Delete", "Save As" };
            foreach (var n in btnNames) buttonLayout.Controls.Add(CreateButton(n));
            footer.Controls.Add(buttonLayout);

            // ===== ASSEMBLE DASHBOARD =====
            dashboardPanel.Controls.Add(dashmain);      // ✅ Add main panel
            dashboardPanel.Controls.Add(headerPanel);   // ✅ Add header
            dashboardPanel.Controls.Add(footer);        // ✅ Add footer

            return dashboardPanel;
        }


        // =========================
        // Create New Panel
        // =========================
        private void ClearAll_Function (object sender, EventArgs e)
        {
            
        }

        private void Submit_Function (object sender, EventArgs e)
        {

        }

        private Panel CreateNewPanel()
        {
            

            Panel createnew_main = new Panel()
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
            };

            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                //BackColor = Color.DarkBlue,
            };

            Label headerLabel = new Label
            {
                Text = "Create New",
                Dock = DockStyle.Fill,
                ForeColor = Color.FromArgb(30,30,30),
                Font = new Font("Cascadia Code", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            //-------------------- BODY --------------------

            Panel body_container = new Panel
            {
                Dock = DockStyle.Fill,
                //BackColor = Color.Bisque,
                Padding = new Padding(20),
            };

            createnew_main.Controls.Add(body_container);

            var create_flowlayout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,                
            };

            body_container.Controls.Add(create_flowlayout); // -----> Textbox Located


            var title = new Label()
            {
                Text = "Please Input some details.",
                Width = 500,
                Height = 30,
                Font = new Font ("Century Gothic", 18),
                Margin = new Padding (8,0,0,10),
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

            // Inputs                                       
            create_flowlayout.Controls.Add(title);
            create_flowlayout.Controls.Add(CreateTextBox("Surname"));
            create_flowlayout.Controls.Add(CreateTextBox("First Name"));
            create_flowlayout.Controls.Add(CreateTextBox("Middle Initial"));
            create_flowlayout.Controls.Add(CreateTextBox("Contact No."));
            create_flowlayout.Controls.Add(CreateTextBox("Address"));
            create_flowlayout.Controls.Add(CreateTextBox("Business"));
            create_flowlayout.Controls.Add(CreateTextBox("Purpose", true));




                

            headerPanel.Controls.Add(headerLabel);
            createnew_main.Controls.Add(headerPanel);


            // ====================== FOOTER ====================

            var footerPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                //BackColor = Color.FromArgb(30, 30, 30),
                BackColor = Color.Transparent,
            };

            var footerFlow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(10,10,10,10)
            };

            //Button function
            var clearBtn = new Button
            {
                Text = "Clear All",
                Height = 30,
                Width = 120,
            };
            var submitBtn = new Button
            {
                Text = "Submit",
                Height = 30,
                Width = 120,
            };


            body_container.Controls.Add(footerPanel);   // -------> Buttons Located

            footerFlow.Controls.Add(clearBtn);
            footerFlow.Controls.Add(submitBtn);
            footerPanel.Controls.Add(footerFlow);            

            return createnew_main;

            

        }



        // =========================
        // Summary Section (Admin)
        // =========================
        private Panel Summary_Section()
        {
            // ================= MAIN CONTAINER =================
            Panel summaryMain = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            // ================= HEADER =================
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.DarkBlue
            };

            Label headerLabel = new Label
            {
                Text = "Summary",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Font = new Font("Century Gothic", 22, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(15, 0, 0, 0)
            };

            headerPanel.Controls.Add(headerLabel);

            // ================= BODY =================
            Panel bodyPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                BackColor = Color.WhiteSmoke
            };

            // ================= BODY LAYOUT =================
            TableLayoutPanel bodyLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2
            };
            bodyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            bodyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));

            // ================= LEFT : INFO =================
            Panel leftPanel = new Panel { Dock = DockStyle.Fill };

            Label infoHeader = new Label
            {
                Text = "System Overview",
                Dock = DockStyle.Top,
                Height = 50,
                Font = new Font("Century Gothic", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label infoText = new Label
            {
                Text = "This system automates walk-in logbook records across \n Barangay Offices in General Santos City.\n\nDeveloped by Decode Creatives.",
                Dock = DockStyle.Top,
                Font = new Font("Century Gothic", 12),
                Padding = new Padding(10),
                AutoSize = true
            };

            leftPanel.Controls.Add(infoText);
            leftPanel.Controls.Add(infoHeader);

            // ================= RIGHT : SUMMARY PANEL =================
            Panel rightPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            FlowLayoutPanel summaryFlow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(10)
            };

            // ---------- FILTERS ----------
            ComboBox cmbDepartment = new ComboBox
            {
                Width = 250,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbDepartment.Items.AddRange(new string[]
            {
        "All Departments",
        "Barangay Clearance",
        "Health Office",
        "Treasury",
        "Admin"
            });
            cmbDepartment.SelectedIndex = 0;

            DateTimePicker dtpDate = new DateTimePicker
            {
                Width = 250,
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "MMMM yyyy",
                ShowUpDown = true
            };

            // ---------- SUMMARY LABELS ----------
            Label lblMonthlyTotal = CreateSummaryLabel("Total Entries (Monthly): 0");
            Label lblYearlyTotal = CreateSummaryLabel("Total Entries (Yearly): 0");

            // ---------- ADD TO FLOW ----------
            summaryFlow.Controls.Add(CreateSectionLabel("Filters"));
            summaryFlow.Controls.Add(cmbDepartment);
            summaryFlow.Controls.Add(dtpDate);

            summaryFlow.Controls.Add(CreateSectionLabel("Statistics"));
            summaryFlow.Controls.Add(lblMonthlyTotal);
            summaryFlow.Controls.Add(lblYearlyTotal);

            rightPanel.Controls.Add(summaryFlow);

            // ================= ADD TO LAYOUT =================
            bodyLayout.Controls.Add(leftPanel, 0, 0);
            bodyLayout.Controls.Add(rightPanel, 1, 0);

            bodyPanel.Controls.Add(bodyLayout);

            // ================= ADD TO MAIN =================
            summaryMain.Controls.Add(bodyPanel);
            summaryMain.Controls.Add(headerPanel);

            return summaryMain;
        }

        // ================= HELPER METHODS =================
        private Label CreateSectionLabel(string text)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Century Gothic", 14, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(0, 15, 0, 5)
            };
        }

        private Label CreateSummaryLabel(string text)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Century Gothic", 12),
                AutoSize = true,
                Padding = new Padding(5)
            };
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
