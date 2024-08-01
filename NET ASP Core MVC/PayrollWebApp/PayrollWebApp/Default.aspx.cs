using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None; // use older JS validation
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            const decimal FULL_WEEK = 37.5m;
            const decimal OT_RATE = 1.5m;
            decimal hours, rate, payAmount;

            try
            {
                if (!Decimal.TryParse(txtHours.Text, out decimal val)) throw new Exception("Hours worked must be a decimal");
                if (Decimal.Parse(txtHours.Text) < 0) throw new Exception("Hours worked cannot be less than 0");
                if (Decimal.Parse(txtHours.Text) > 84) throw new Exception("Hours cannot be greater than 84");
                if (!Decimal.TryParse(txtRate.Text, out decimal val1)) throw new Exception("Hourly rate must be a decimal");
                if (Decimal.Parse(txtRate.Text) < 0) throw new Exception("Hourly rate cannot be less than 0");

                // get hours and rate
                hours = Convert.ToDecimal(txtHours.Text);
                rate = Convert.ToDecimal(txtRate.Text);

                // calculate pay amount
                if (hours <= FULL_WEEK)
                    payAmount = hours * rate;
                else payAmount = FULL_WEEK * rate + (hours - FULL_WEEK) * rate * OT_RATE;

                // display pay amount
                lblPay.Text = payAmount.ToString("c");
            }
            catch (Exception ex)
            {
                updateLbl(ex.Message);
            }
        }
        private void updateLbl(string msg)
        {
            lblMessage.Text = msg;
        }

        // reset lbl and controls
        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtHours.Text = "";
            txtRate.Text = "";
            lblPay.Text = "";
            txtHours.Focus();
        }
    }
}