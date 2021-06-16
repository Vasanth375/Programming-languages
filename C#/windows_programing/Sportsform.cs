using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true & checkBox2.Checked==true & checkBox3.Checked==true)
            {//cricket           kabbadi          foot ball
                MessageBox.Show("SELECTED ALL");
            }
            else if(checkBox1.Checked == true & checkBox2.Checked == true & checkBox3.Checked == false)
            {
                MessageBox.Show("SELECTED ITEMS ARE CRICKET , KABBADI");
            }
            else if (checkBox1.Checked == true & checkBox2.Checked == false & checkBox3.Checked == true)
            {
                MessageBox.Show("SELECTED ITEMS ARE CRICKET , FOOTBALL");
            }
            else if (checkBox1.Checked == false & checkBox2.Checked == true & checkBox3.Checked == true)
            {
                MessageBox.Show("SELECTED ITEMS ARE KABBADI , FOOTBALL");
            }
            else if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == false)
            {
                MessageBox.Show("PLEASE SELECT ALEAST ONE SPORTS");
            }
            
        }
    }
}
