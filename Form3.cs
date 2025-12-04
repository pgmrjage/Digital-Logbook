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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // FOR SUFFIX COMBOBOX 
            //===========================================================================
            //initialize dropdown format
            admin_clear_btn.Visible = true;
            admin_clear_btn.Enabled = true;
            

            //list of name extension
            string[] suffix = { "N/A", "Sr", "Jr", "II", "III", "IV", "V" };
            //admin_clear_btn.DataSource = suffix;

            //default
            //admin_clear_btn.SelectedIndex = 0;

            admin_clear_btn.Refresh();
            //===========================================================================
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {            
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }
    }
}
