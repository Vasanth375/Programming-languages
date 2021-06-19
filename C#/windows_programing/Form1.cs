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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "12")
            {
                MessageBox.Show("exact value enterd");
            }
            else if(textBox1.Text == "")//if user didnt enter anything this window appears
            {
                MessageBox.Show("please enter data");
            }
            else
            {
                MessageBox.Show("not an exact value");
            }
        }
    }
}
