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
    public partial class frmOtherControls : Form
    {
        public frmOtherControls()
        {
            InitializeComponent();
        }

        private void chk_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_checkbox1Status.Text = chk_checkBox1.Checked? "Checked" :"Unchecked";
        }

        private void rdbtn_choice1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_rdbtn1Status.Text = rdbtn_choice1.Checked ? rdbtn_choice1.Text : "";
        }

        private void rdbtn_choice2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_rdbtn1Status.Text = rdbtn_choice2.Checked ? rdbtn_choice2.Text : "";
        }

        private void rdbtn_choice3_CheckedChanged(object sender, EventArgs e)
        {
            lbl_rdbtn1Status.Text = rdbtn_choice3.Checked ? rdbtn_choice3.Text : "";
        }
    }
}
