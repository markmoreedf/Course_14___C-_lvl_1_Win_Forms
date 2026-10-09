using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_14___C__lvl_1_Win_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Enabled)
                textBox2.Text = textBox1.Text;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if(textBox2.Enabled)
                textBox2.Text = textBox1.Text;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if(textBox2.Enabled)
                textBox2.Text = textBox1.Text;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if(textBox2.Enabled)
                textBox2.Text = textBox1.Text;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            if(textBox2.Enabled)
                textBox2.Text = textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = !textBox1.Enabled;
            textBox1.Text = textBox1.Enabled ? "Enabled" : "Disabled";
            button6.Text = textBox1.Enabled ? "Disable TB1" : "Enable TB1";
            label1.Visible = textBox1.Enabled;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = !textBox2.Enabled;
            textBox2.Text = textBox2.Enabled ? "Enabled" : "Disabled";
            button7.Text = textBox2.Enabled ? "Disable TB2" : "Enable TB2";
            label2.Visible = textBox2.Enabled;
        }

    }
}
