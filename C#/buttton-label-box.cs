/*program to create button,label and textbox*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //when we click on button first this message window will
            MessageBox.Show("you are in button1 click event");
            
            //second whatever written in textbox will appeare in new window when user click button1 
            MessageBox.Show(textBox1.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you are in label1 event");
        }
    }
}
