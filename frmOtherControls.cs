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
            if (rbThin.Checked)
            {
                lblSummaryCrust.Text += "Thin";
                _UpdatePrice();
            }
            else
            {
                _UpdatePrice();
                lblSummaryCrust.Text = lblSummaryCrust.Text.Replace("Thin", "");
            }
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThick.Checked)
            {
                _UpdatePrice();
                lblSummaryCrust.Text += "Thick";
            }
            else
            {
                _UpdatePrice();
                lblSummaryCrust.Text = lblSummaryCrust.Text.Replace("Thick", "");
            }
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked)
            {
                _UpdatePrice();
                lblSummaryToppings.Text += "Extra Cheese, ";
            }
            else
            {
                _UpdatePrice();
                lblSummaryToppings.Text = lblSummaryToppings.Text.Replace("Extra Cheese, ", "");
            }
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomatoes.Checked)
            {
                _UpdatePrice();
                lblSummaryToppings.Text += "Tomatoes, ";

            }
            else
            {
                _UpdatePrice();
                lblSummaryToppings.Text = lblSummaryToppings.Text.Replace("Tomatoes, ", "");

            }
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushroom.Checked)
            {
                _UpdatePrice();
                lblSummaryToppings.Text += "Mushroom, ";
            }
            else
            {
                _UpdatePrice();
                _UpdatePrice();
                lblSummaryToppings.Text = lblSummaryToppings.Text.Replace("Mushroom, ", "");
            }
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
           if (chkOlives.Checked)
            {
                _UpdatePrice();
                lblSummaryToppings.Text += "Olives, ";
            }
            else
            {
                _UpdatePrice();
                _UpdatePrice();
                lblSummaryToppings.Text = lblSummaryToppings.Text.Replace("Olives, ", "");
            }
        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPeppers.Checked)
            {
                _UpdatePrice();
                lblSummaryToppings.Text += "Peppers, ";
            }
            else
            {
                _UpdatePrice();
                _UpdatePrice();
                lblSummaryToppings.Text = lblSummaryToppings.Text.Replace("Peppers, ", "");
            }
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePrice();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                _UpdatePrice();
                lblSummarySize.Text  += "Small";
            }
            else 
            {
                _UpdatePrice();
                lblSummarySize.Text = lblSummarySize.Text.Replace("Small", "");
            }
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                _UpdatePrice();
                lblSummarySize.Text  += "Medium";
            }
            else
            {
                _UpdatePrice();
                lblSummarySize.Text = lblSummarySize.Text.Replace("Medium", "");
            }
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                _UpdatePrice();
                lblSummarySize.Text  += "Large";
            }
            else
            {
                _UpdatePrice();
                lblSummarySize.Text = lblSummarySize.Text.Replace("Large", "");
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!rbThick.Checked && !rbThin.Checked)
            {
                MessageBox.Show("Please Choose Your Prefered Crust", "Crust Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!rbSmall.Checked && !rbMedium.Checked && !rbLarge.Checked)
            {
                MessageBox.Show("Please Choose Your Pizza Size", "Size Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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