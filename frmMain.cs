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
    public partial class frm_Start : Form
    {
        public frm_Start()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "admin" || tbPassword.Text != "admin")
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmCoreApp importantForm = new frmCoreApp();

            // Tell the second form: "When you close, unhide this main form"
            // (If the "X" was clicked, Application.Exit() fires first and stops everything anyway)
            importantForm.FormClosed += (s, args) => this.Show();

            this.Hide();
            importantForm.Show();
        


        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                btn_Start.Enabled = true;
            }
            else
            {
                btn_Start.Enabled = false;
            }
        }
    }
}
