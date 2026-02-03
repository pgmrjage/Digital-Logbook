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




        // =========================
        // Dashboard Panel
        // =========================
        private Panel Dashboard_Section()
        {
            Panel dashboardPanel = new Panel    //1
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                //Padding = new Padding(10),
            };

            Panel headerPanel = new Panel       //1.1
            {
                Dock = DockStyle.Top,   
                Height = 60,
                BackColor= Color.DarkBlue,
            };

            Label headerLabel = new Label       //1.2
            {
                Text = "Dashboard",
                Dock= DockStyle.Fill,
                ForeColor = Color.White,
                Font = new Font("Century Gothic", 24),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            Panel dashmain = new Panel         //2
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20, 20, 20, 20),                
                BackColor = Color.Yellow,
            };

            TableLayoutPanel dashmain_layout = new TableLayoutPanel     //2.1
            {
                RowCount = 2,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                BackColor = Color.Aqua,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                //Padding = new Padding (20,20,20,20),
            };

            // This is the layoutbox for box content including counts and numeric
            FlowLayoutPanel dashmain_box_layout = new FlowLayoutPanel{
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,

            };

            // This is the layoutbox for record including searchbox and listbox
            Panel records_box_layout = new Panel
            {
                Dock = DockStyle.Fill,
            };
            
            dashmain_layout.RowStyles.Clear();
            dashmain_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            dashmain_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 60));


            // First Container Section

            FlowLayoutPanel box = new FlowLayoutPanel
            {
                //Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                BackColor = Color.FromArgb(30,30,30),
                Height = 150,
                Width = 250,
                Margin = new Padding (20, 20, 20, 20),
            };

            

            Panel counts_container = new Panel {
                Dock = DockStyle.Top,
                AutoSize = true,
            };

            Panel numeric_container = new Panel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
            };
            Panel actionBtn_container = new Panel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
            };

            

            //Details inside the Box
            Label counts = new Label
            {
                ForeColor = Color.White,
                AutoSize = true,
                Font = new Font("Century Gothic", 16),
                Text = "Counts",
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label numeric = new Label
            {
                ForeColor = Color.White,
                AutoSize = true,
                Font = new Font("Century Gothic", 48),
                Text = "240",
                TextAlign = ContentAlignment.MiddleCenter,
            };


            // Second Container Section

            Panel container = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding (20, 20, 20, 20),
            };
            Panel searchbox_container = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
            };
            Panel record_container = new Panel
            {
                Dock = DockStyle.Top,
                Height = 200,
            };


            TextBox searchbox = new TextBox
            {
                Dock = DockStyle.None,
                Height = 50,
                PlaceholderText = "Search",
            };

            ListBox records = new ListBox
            {
                Dock = DockStyle.None,
                Height = 200,
                Width = 1000
            };


            // ------ DASH FOOTER --------

            TableLayoutPanel footer = new TableLayoutPanel
            {
                Dock = DockStyle.Bottom,
                BackColor = Color.Green,
               
            };

            Panel footer_container = new Panel
            {
                Dock = DockStyle.Fill,
                
            };

            FlowLayoutPanel buttons_container = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(20, 20, 20, 20),
                WrapContents = false,
            };

            Button delete_button = new Button
            {
                Text = "Delete",
                ForeColor = Color.White,
                BackColor = Color.FromArgb(30,30,30),
                Height = 50,
                Width = 120,
            };
            Button edit_button = new Button
            {
                Text = "Edit",
                ForeColor = Color.White,
                BackColor = Color.FromArgb(30,30,30),
                Height = 50,
                Width = 120,
            };
            Button saveAs_button = new Button
            {
                Text = "Save As",
                ForeColor = Color.White,
                BackColor = Color.FromArgb(30, 30, 30),
                Height = 50,
                Width = 120,
            };



            // Add some test content to see if it's working
            Label testLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = "This is the dashboard content",
                Font = new Font("Segoe UI", 12),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                //Location = new Point(50, 80),
                //AutoSize = true
            };






            // Add controls in correct order


            //2
            dashboardPanel.Controls.Add(dashmain);
            dashmain.Controls.Add(dashmain_layout);
            dashmain_layout.Controls.Add(dashmain_box_layout, 0,0);
            dashmain_box_layout.Controls.Add(box);
            box.Controls.Add(counts_container);
            box.Controls.Add(numeric_container);
            counts_container.Controls.Add(counts);
            numeric_container.Controls.Add(numeric);

            //Function call for Records

            //dashboardPanel.Controls.Add(dashmain);
            //dashmain.Controls.Add(dashmain_layout);
            dashmain_layout.Controls.Add(records_box_layout, 0, 1); 
            records_box_layout.Controls.Add(container);
            container.Controls.Add(record_container);
            container.Controls.Add(searchbox_container);            
            searchbox_container.Controls.Add(searchbox);
            record_container.Controls.Add(records);

            //box.Controls.Add(box_content);
            //dashmain.Controls.Add(dashmain_layout);
            //dashboardPanel.Controls.Add(dashmain);  //show in dashboard


            //1
            headerPanel.Controls.Add(headerLabel);
            dashboardPanel.Controls.Add(headerPanel); //show in dashboard

            //3 - footer
            dashboardPanel.Controls.Add(footer);
            footer.Controls.Add(footer_container);
            footer_container .Controls.Add(buttons_container);
            buttons_container.Controls.Add(delete_button);
            buttons_container.Controls.Add(edit_button);
            buttons_container.Controls.Add(saveAs_button);


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

            //-------------------- BODY --------------------

            Panel body_container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Bisque,
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
                Text = "User Input",
                Width = 160,
                Height = 30,
                Font = new Font ("Century Gothic", 18),
                Margin = new Padding (10,0,0,10),
            };
            
            TextBox CreateTextBox(string placeholder, bool multiline = false)
            {
                return new TextBox
                {
                    PlaceholderText = placeholder,
                    Font = new Font("Segoe UI", 10),
                    BorderStyle = BorderStyle.FixedSingle,
                    Height = multiline ? 70 : 32,
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
                BackColor = Color.FromArgb(30, 30, 30),
            };

            var footerFlow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(10,10,0,0)
            };

            //Button function
            var clearBtn = new Button
            {
                Text = "Clear All",
                Height = 30,
            };
            var submitBtn = new Button
            {
                Text = "Submit",
                Height = 30,
            };


            body_container.Controls.Add(footerPanel);   // -------> Buttons Located

            footerFlow.Controls.Add(clearBtn);
            footerFlow.Controls.Add(submitBtn);
            footerPanel.Controls.Add(footerFlow);            

            return createnew_main;

            

        }


        // =========================
        // Summary
        // =========================
        private Panel Summary_Section()
        {
            Panel summary_main = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
            };

            //-------------------- HEADER --------------------
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.DarkBlue,
            };

            Label headerLabel = new Label
            {
                Text = "Summary",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Font = new Font("Century Gothic", 24),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            headerPanel.Controls.Add(headerLabel);

            //-------------------- BODY --------------------

            Panel body_container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Bisque,
                Padding = new Padding(20),
            };

            //---------------------- LEFT ----------------------
            Panel left_content_container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Chartreuse,
            };

            FlowLayoutPanel content = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                WrapContents = false
            };

            Label left_header = new Label
            {
                Dock = DockStyle.Top,
                Height = 120,
                Text = "Summary",
                Font = new Font("Century Gothic", 20),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label left_paragraph = new Label
            {
                Dock = DockStyle.Top,
                Font = new Font("Century Gothic", 12),
                Text = "The program is created to automate logbook in different division in Barangay Offices across General Santos City. This program is created by Decode Creatives by Jan Geraldez.",
                AutoSize = true,
                Padding = new Padding (10,0,10,0)
            };

            left_content_container.Controls.Add(content);
            content.Controls.Add(left_header);
            content.Controls.Add(left_paragraph);
            

            //---------------------- RIGHT ----------------------
            Panel right_content_container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.LightGray
            };

            //---------------------- BODY LAYOUT ----------------------
            TableLayoutPanel body_layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                BackColor = Color.Red
            };
            body_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            body_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            body_layout.Controls.Add(left_content_container, 0, 0);
            body_layout.Controls.Add(right_content_container, 1, 0);

            body_container.Controls.Add(body_layout);

            //---------------------- ADD TO MAIN ----------------------            
            summary_main.Controls.Add(body_container);
            summary_main.Controls.Add(headerPanel);

            return summary_main;
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
