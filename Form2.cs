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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            // FOR SUFFIX COMBOBOX 
            //===========================================================================
            //initialize dropdown format
            suffix_comboBox.Visible = true;
            suffix_comboBox.Enabled = true;
            suffix_comboBox.DropDownStyle = ComboBoxStyle.DropDown;

            //list of name extension
            string[] suffix = { "N/A", "Sr", "Jr", "II", "III", "IV", "V" };
            suffix_comboBox.DataSource = suffix;

            //default
            suffix_comboBox.SelectedIndex = 0;

            suffix_comboBox.Refresh();
            //===========================================================================

        }


        //Menustrip --> "CREATE"
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            foreach (Control c in tabPage1.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.Clear();
                }
            }


        }

        private void suffix_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
