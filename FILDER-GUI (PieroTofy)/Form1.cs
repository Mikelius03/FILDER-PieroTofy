using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_FILDER_FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String argument;

        private void click_SEARCH(object sender, EventArgs e)
        {
            FILDERFolderDialog1.ShowDialog();
            textBoxFILDER1.Text = FILDERFolderDialog1.SelectedPath;

        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxPattern1.Checked == true)
            {
                labelPattern1.Enabled = true;
                textBox1.Enabled = true;
            }
            else
            {
                labelPattern1.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void Click_AVVIA(object sender, EventArgs e)
        {

            if ( textBoxFILDER1.Text.ToString() != "")
            {
                if (textBox1.Text=="")
                {
                    textBox1.Text = "*.*";

                }
                argument = "\""+textBoxFILDER1.Text.ToString()+ "\" " + textBox1.Text.ToString();
                  MessageBox.Show("["+argument+"]");
                try
                {
                    System.Diagnostics.Process.Start("FILDER.exe", argument);
                }
                catch
                {
                    MessageBox.Show("FILDER.exe NON TROVATO!");
                }
            }
            else
            {
                MessageBox.Show("Cartella da setacciare non coretta");
            }
        }

        private void textBoxFILDER1_TextChanged(object sender, EventArgs e)
        {

        }


        /*
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRic1.Checked==true)
            {
                checkRicorsione2.Enabled = true;
            }
            else
            {
                checkRicorsione2.Enabled = false;
                numericUpDown1.Enabled = false;
  
            }
        }
        */
    }
}
