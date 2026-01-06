using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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
