using System.Diagnostics;

namespace IceCreamShop
{
    public partial class Form1 : Form
    {
        // class-level (global) declarations
        const decimal SINGLE = 4.5m;
        const decimal DOUBLE = 7.5m;
        const decimal TRIPLE = 9.5m;
        const decimal WAFFLE = 1.5m;
        const decimal OTHER = 0.75m;
        public Form1()
        {
            InitializeComponent();
        }
        private void resetForm()
        {
            txtTotal.Text = "";
            chkChocolate.Checked = false;
            chkCone.Checked = false;
            chkFruit.Checked = false;
            chkNuts.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal toPay;

            if (radSingle.Checked) toPay = SINGLE;
            else if (radDouble.Checked) toPay = DOUBLE;
            else toPay = TRIPLE;

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
            radSingle.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            radSingle.Text += $" ({SINGLE:C})";
            radDouble.Text += $" ({DOUBLE:C})";
            radTriple.Text += $" ({TRIPLE:C})";
            chkCone.Text += $" ({WAFFLE:C})";
            chkChocolate.Text += $" ({OTHER:C})";
            chkNuts.Text += $" ({OTHER:C})";
            chkFruit.Text += $" ({OTHER:C})";

            radSingle.Checked = true;
        }
    }
}
