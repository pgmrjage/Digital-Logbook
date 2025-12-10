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

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            tabPage1.Text = "Add Tab";
            ClearGroupBoxControl(tabPage1);
        }

        private void suffix_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Close();
        }

        private void ClearGroupBoxControl(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.Clear();
                }
            }
        }

        private void user_btn_cancel_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Close();
        }

        private void user_clear_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
