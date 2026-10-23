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
    public partial class frm_messageBox : Form
    {
        public frm_messageBox()
        {
            InitializeComponent();
        }

        private void btn_messageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi", "Hi,With Title");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi", "Hi With Title and Cancel", MessageBoxButtons.OKCancel);
        }

        private void btn_messageBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi", "Hi With Title, Cancel and Icon", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hi", "Hi With Title, Cancel and Icon", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
        }
    }
}
