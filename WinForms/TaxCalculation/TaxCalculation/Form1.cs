using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaxCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSalary.Text = "";
            txtTaxes.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal salary = Decimal.Parse(txtSalary.Text);
            decimal tax = 0;

            if (salary >= 80000)
            {
                decimal remainder = salary - 80000;
                tax += remainder * 0.33m;
                salary -= remainder;
            }
            if (salary >= 50000)
            {
                decimal remainder = salary - 50000;
                tax += remainder * 0.27m;
                salary -= remainder;
            }
            if (salary >= 30000)
            {
                decimal remainder = salary - 30000;
                tax += remainder * 0.22m;
                salary -= remainder;
            }
            if (salary > 15000)
            {
                decimal remainder = salary - 15000;
                tax += remainder * 0.18m;
                salary -= remainder;
            }
            if (salary <= 15000)
            {
                tax += salary * 0.15m;
            }
            txtTaxes.Text = tax.ToString("c");


        }
    }
}
