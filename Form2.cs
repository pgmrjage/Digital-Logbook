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
            string[] user_choice = { "Sr", "Jr", "V", "IV", "III", "II", "I" };

            foreach (string choice in user_choice)
            {
                user_suffix_cb.Items.Add(choice);
            }
            //===========================================================================

        }

        void ClearAll(Control Parent)
        {
            foreach (Control nth in Parent.Controls)
            {
                if (nth is TextBox tb)  //clear for ComboBox
                {
                    tb.Clear();
                }
                else if (nth is ComboBox cb) // Clear for ComboBox
                {
                    cb.Items.Clear();
                    cb.Text = "";
                }
                // VERY IMPORTANT: go inside containers such as TabPage, Panel, GroupBox, etc.
                if (nth.HasChildren)
                {
                    ClearAll(nth);
                }
            }
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

        

        private void user_clear_btn_Click(object sender, EventArgs e)
        {
            ClearAll(this); //Clear All Valus inputted by the Users
        }

    }
}
