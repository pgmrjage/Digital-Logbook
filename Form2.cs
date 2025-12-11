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

            //===========================================================================
            //TABPAGE 1
            //===========================================================================

            // FOR SUFFIX COMBOBOX 
            //===========================================================================            
            user_suffix_cb.DropDownStyle =  ComboBoxStyle.DropDownList; //set dafault comboBox into dropdown list
            string[] user_choice = { "", "Sr", "Jr", "V", "IV", "III", "II", "I" };
            foreach (string user_choice_index in user_choice)
            {
                user_suffix_cb.Items.Add(user_choice_index);
            }
            //suffix is set to default blank
            user_suffix_cb.SelectedIndex = 0;
            //===========================================================================




            //===========================================================================
            //TABPAGE 2
            //===========================================================================

            // FOR FILTER COMBOBOX
            user_filter_cb.DropDownStyle = ComboBoxStyle.DropDownList;  //set default comboBox into dropdown List
            //date encode set to locked by default
            user_dateEncode_gb.Enabled = false;


            int[] filter = { 5, 10, 15, 20, };
            foreach (int filter_index in filter)
            {
                user_filter_cb.Items.Add(filter_index);
            }
            user_filter_cb.Items.Add("All");
            user_filter_cb.SelectedIndex = 0;

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
                    if (cb.Name != "user_filter_cb")    //TabPage2: Filter ComboBox
                    {
                        cb.SelectedIndex = -1;           // reset selection
                        cb.Text = "";                    // (optional)
                    }
                    //cb.Items.Clear();
                    //cb.Text = "";
                }
                if (nth.HasChildren)    // VERY IMPORTANT: go inside containers such as TabPage, Panel, GroupBox, etc.
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
            ClearAll(this); //Clear All Values inputted by the Users in TabPage1
        }
        private void user_clear_btn1_Click(object sender, EventArgs e)
        {            
            ClearAll(this); //Clear All Values inputted by the Users in TabPage2            
        }

        private void user_dateEncode_cb_CheckedChanged(object sender, EventArgs e)
        {
            user_dateEncode_gb.Enabled = user_dateEncode_cb.Checked;

        }

        
    }
}
