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
    public partial class frmCoreApp : Form
    {
        public frmCoreApp()
        {
            InitializeComponent();
            this.Text = "DATATATATATA";
            this.Icon = new Icon("icon.ico");
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
            textBox1.Text = textBox1.Enabled ? "" : "Disabled";
            btn_DisableTB1.Text = textBox1.Enabled ? "Disable TB1" : "Enable TB1";
            label1.Visible = textBox1.Enabled;
            btn_ChngTB1Clr.Enabled = textBox1.Enabled;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = !textBox2.Enabled;
            textBox2.Text = textBox2.Enabled ? "" : "Disabled";
            btn_DisableTB2.Text = textBox2.Enabled ? "Disable TB2" : "Enable TB2";
            label2.Visible = textBox2.Enabled;
            btn_ChngTB2Clr.Enabled = textBox2.Enabled;
        }

        private void btn_ResetTB1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Enabled = true;
            textBox1.BackColor = Color.GhostWhite;
            textBox1.Text = "";
            btn_DisableTB1.Text = "Disable TB1";

        }

        private void btn_ResetTB2_Click(object sender, EventArgs e)
        {
            
            label2.Visible = true;
            textBox2.Enabled = true;
            textBox2.BackColor = Color.GhostWhite;
            textBox2.Text = "";
            btn_DisableTB2.Text = "Disable TB2";
        }

        private void btn_ChngTB1Clr_Click(object sender, EventArgs e)
        {
            if (!textBox1.Enabled) { return; }
            Random rand = new Random();
            textBox1.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void btn_ChngTB2Clr_Click(object sender, EventArgs e)
        {
            if (!textBox2.Enabled) { return; }
            Random rand = new Random();
            textBox2.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        bool isLinked = false;
        private void button6_Click_1(object sender, EventArgs e)
        {
            isLinked = !isLinked;
            btn_Link.Text = isLinked ? "Unlink" : "Link";
            btn_CopyOnClick.Enabled = !isLinked;
            btn_CopyOnEnter.Enabled = !isLinked;
            btn_CopyOnHover.Enabled = !isLinked;
            btn_CopyOnLeave.Enabled = !isLinked;
            btn_CopyOnMove.Enabled = !isLinked;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Enabled || !textBox2.Enabled || !isLinked) { return; }
            textBox2.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!textBox2.Enabled) { return; }
            progressBar1.Value = textBox2.Text.Length > 100 ? 100 : (textBox2.Text.Length * 100 / textBox2.MaxLength);
        }

        private bool isGoingBack = false;
        private void btn_OpenStartWindow_Click(object sender, EventArgs e)
        {
            isGoingBack = true; // Set the flag to true
            this.Close();       // Close this form
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (isGoingBack)
            {
                // Do nothing here! The Main Form will catch the closure and show itself.
            }
            else
            {
                // The user clicked the "X" button or closed it another way.
                // Kill the entire program cleanly so it doesn't get stuck in Visual Studio.
                Application.Exit();
            }
        }
        


        private void btn_OpenTempForm_Click(object sender, EventArgs e)
        {
            frmCalculator tempForm = new frmCalculator();
            tempForm.Show();
        }

        private void btn_messageBox1_Click(object sender, EventArgs e)
        {
            Form msgBoxForm = new frm_messageBox();
            msgBoxForm.ShowDialog();
        }

        private void btn_OpenOtherControlsFom_Click(object sender, EventArgs e)
        {
            Form otherControlsForm = new frmOtherControls();
            otherControlsForm.ShowDialog();
        }
    }
}
