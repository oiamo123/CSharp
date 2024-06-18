using System.Diagnostics;

namespace CoinMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private (decimal, decimal) calcChange(decimal change, decimal coin)
        {   
            //11.45 - (1.45) = 10
            decimal changeCoin = change - (change % coin);
            //
            change -= changeCoin;
            //10 / 2
            return (changeCoin / coin, change);
            
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtToonies.Text = "";
            txtLoonies.Text = "";
            txtQuarters.Text = "";
            txtDimes.Text = "";
            txtNickels.Text = "";
            txtChange.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // round to nearest 0.05
            // converts string into decimal
            if (txtChange.Text != "")
            {   // 0.05
                decimal change = Math.Round(Decimal.Parse(txtChange.Text) * 20) / 20;
                decimal toonies = 0;
                decimal loonies = 0;
                decimal quarters = 0;
                decimal dimes = 0;
                decimal nickels = 0;
                if (change >= 2)
                {
                    (toonies, change) = calcChange(change, 2m);
                }
                if (change >= 1)
                {
                    (loonies, change) = calcChange(change, 1m);
                }
                if (change >= 0.25m)
                {
                    (quarters, change) = calcChange(change, 0.25m);
                }
                if (change >= 0.10m)
                {
                    (dimes, change) = calcChange(change, 0.10m);
                }
                if (change > 0.05m)
                {
                    (nickels, change) = calcChange(change, 0.05m);
                }
                txtToonies.Text = Math.Round(toonies).ToString();
                txtLoonies.Text = Math.Round(loonies).ToString();
                txtQuarters.Text = Math.Round(quarters).ToString();
                txtDimes.Text = Math.Round(dimes).ToString();
                txtNickels.Text = Math.Round(nickels).ToString();
            }
        }
    }
}
