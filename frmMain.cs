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

            frmCoreApp importantForm = new frmCoreApp();

            // Tell the second form: "When you close, unhide this main form"
            // (If the "X" was clicked, Application.Exit() fires first and stops everything anyway)
            importantForm.FormClosed += (s, args) => this.Show();

            this.Hide();
            importantForm.Show();
        


        }
    }
}
