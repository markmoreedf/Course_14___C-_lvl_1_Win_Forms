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
    public partial class frmPizzaShop : Form
    {
        public frmPizzaShop()
        {
            InitializeComponent();
        }
        private float _CalculateToppingsPrice()
        {
            float toppingsPrice = 0.0f;
            if (chkExtraCheese.Checked)
                toppingsPrice += float.Parse(chkExtraCheese.Tag.ToString());
            if (chkTomatoes.Checked)
                toppingsPrice += float.Parse(chkTomatoes.Tag.ToString());
            if (chkMushroom.Checked)
                toppingsPrice += float.Parse(chkMushroom.Tag.ToString());
            if (chkPeppers.Checked)
                toppingsPrice += float.Parse(chkPeppers.Tag.ToString());
            if (chkOlives.Checked)
                toppingsPrice += float.Parse(chkOlives.Tag.ToString());
            
            return toppingsPrice;
        }

        private float _CalculateTotalPrice()
        {
            float basePrice = 5.0f;
            float toppingsPrice = _CalculateToppingsPrice();
            float crustPrice = rbThick.Checked ? float.Parse(rbThick.Tag.ToString()) : float.Parse(rbThin.Tag.ToString());

            if (rbSmall.Checked)
                basePrice = float.Parse(rbSmall.Tag.ToString()) * (basePrice + toppingsPrice + crustPrice) 
                                     + (rbTakeOut.Checked ? float.Parse(rbTakeOut.Tag.ToString()) : 0.0f);
            if (rbMedium.Checked)
                basePrice = float.Parse(rbMedium.Tag.ToString()) * (basePrice + toppingsPrice + crustPrice)
                                     + (rbTakeOut.Checked ? float.Parse(rbTakeOut.Tag.ToString()) : 0.0f);
            if (rbLarge.Checked)
                basePrice = float.Parse(rbLarge.Tag.ToString()) * (basePrice + toppingsPrice + crustPrice)
                                     + (rbTakeOut.Checked ? float.Parse(rbTakeOut.Tag.ToString()) : 0.0f);

            return basePrice;
        }

        private void _UpdatePrice()
        {
            lblPriceNumber.Text = _CalculateTotalPrice().ToString("0.0 $");
        }

        private void _UpdateSummary()
        {
            lblSummaryCrust.Text = "Crust: ";
            lblSummarySize.Text = "Size: ";
            lblSummaryToppings.Text = "Toppings: ";
            if (rbThin.Checked)
                lblSummaryCrust.Text += "Thin";
            if (rbThick.Checked)
                lblSummaryCrust.Text += "Thick";
            if (rbSmall.Checked)
                lblSummarySize.Text += "Small";
            if (rbMedium.Checked)
                lblSummarySize.Text += "Medium";
            if (rbLarge.Checked)
                lblSummarySize.Text += "Large";
            if (chkExtraCheese.Checked)
                lblSummaryToppings.Text += "Extra Cheese, ";
            if (chkTomatoes.Checked)
                lblSummaryToppings.Text += "Tomatoes, ";
            if (chkMushroom.Checked)
                lblSummaryToppings.Text += "Mushroom, ";
            if (chkPeppers.Checked)
                lblSummaryToppings.Text += "Peppers, ";
            if (chkOlives.Checked)
                lblSummaryToppings.Text += "Olives, ";
            if (lblSummaryToppings.Text.EndsWith(", "))
                lblSummaryToppings.Text = lblSummaryToppings.Text.Substring(0, lblSummaryToppings.Text.Length - 2);

        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            gbxCrust.Enabled = true;
            gbxSize.Enabled = true;
            gbxToppings.Enabled = true;
            gbxWhereToEat.Enabled = true;
            btnPlaceOrder.Enabled = true;
            chkExtraCheese.Checked = false;
            chkTomatoes.Checked = false;
            chkMushroom.Checked = false;
            chkPeppers.Checked = false;
            chkOlives.Checked = false;
            rbSmall.Checked = false;
            rbMedium.Checked = false;
            rbLarge.Checked = false;
            rbThin.Checked = false;
            rbThick.Checked = false;
            rbEatIn.Checked = false;
            rbTakeOut.Checked = false;
            lblPriceNumber.Text = "0.0 $";
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePrice();
            _UpdateSummary();
        }

        //private void rbThick_CheckedChanged(object sender, EventArgs e)
        //{
        //    _UpdatePrice();
        //    _UpdateSummary();
        //}

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePrice();
            _UpdateSummary();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePrice();
            _UpdateSummary();
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePrice();
            _UpdateSummary();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePrice();
            _UpdateSummary();
        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePrice();
            _UpdateSummary();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePrice();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e) 
        {
            _UpdatePrice();
            _UpdateSummary();
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePrice();
            _UpdateSummary();
 
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePrice();
            _UpdateSummary();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!rbThick.Checked && !rbThin.Checked)
            {
                MessageBox.Show("Please Choose Your Preferred Crust", "Crust Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!rbSmall.Checked && !rbMedium.Checked && !rbLarge.Checked)
            {
                MessageBox.Show("Please Choose Your Pizza Size", "Size Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Your order has been placed successfully!", "Order Placed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                gbxSize.Enabled = false;
                gbxCrust.Enabled = false;
                gbxToppings.Enabled = false;
                gbxWhereToEat.Enabled = false;
                btnPlaceOrder.Enabled = false;
            }
        }
    }
}