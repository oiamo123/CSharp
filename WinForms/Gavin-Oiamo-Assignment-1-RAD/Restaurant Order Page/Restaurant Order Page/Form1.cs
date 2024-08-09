using System.ComponentModel.Design;
/*
 * AUTHOR: Gavin Oiamo 
 * DATE: June 15, 2024
 * PURPOSE: Calculate order prices based on add-ons, selected meal and taxes 
*/
namespace Restaurant_Order_Page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // changes checkbox labels
        private void changeChkBox(string arg1, string arg2, string arg3)
        {
            chk1.Text = arg1;
            chk2.Text = arg2;
            chk3.Text = arg3;
        }
        // changes "add-on" price
        private void changeAddOnPrice(string arg1)
        {
            boxAddOns.Text = $"Add-on items ($.{arg1}/each)";
        }

        // resets checked boxes in add-ons
        private void resetChkBoxes()
        {
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
        }

        // clears text boxes in order total
        private void clearTxtBoxes()
        {
            txtSubTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
        }

        // calls resetChkBoxes to reset check boxes in add-ons and clearTxtBoxes to clear text boxes in order total.
        private void resetForm()
        {
            resetChkBoxes();
            clearTxtBoxes();
        }
        // Calculates Tax and Total order price, takes in subtotal as an argument
        private (decimal, decimal) calcTaxAndTotal(decimal subtotal)
        {
            // tax total is calculated bu multiplying subtotal by 5% (0.05)
            decimal taxTotal = decimal.Multiply(subtotal, 0.05m);
            // calculates total by adding subtotal and taxtotal
            decimal total = decimal.Add(subtotal, taxTotal);
            // returns tax total and total
            return (taxTotal, total);
        }
        // when form loads, checks burger radiobutton
        private void Form1_Load(object sender, EventArgs e)
        {
            radBurger.Checked = true;
        }
        /* whenever burger radio button is selected, clears previous add-ons and textboxes, 
         * changes add on price to $0.75 and changes checkboxes to "lettuce", "tomato and onions" and "french fries" */
        private void radBurger_CheckedChanged(object sender, EventArgs e)
        {
            changeChkBox("Lettuce, tomato and onions", "Ketchup, mustard and mayo", "French fries");
            changeAddOnPrice("75");
            resetForm();
        }
        /* whenever pizza radio button is selected, clears previous add-ons and textboxes, 
         * changes add on price to $0.50 and changes checkboxes to "Pepperoni", "Sausage", and "Olives" */
        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            changeChkBox("Pepperoni", "Sausage", "Olives");
            changeAddOnPrice("50");
            resetForm();
        }
        /* whenever salad radio button is selected, clears previous add-ons and textboxes, 
         * changes add on price to $0.25 and changes checkboxes to "Croutons", "Bacon bits", and "Bread sticks" */
        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            changeChkBox("Croutons", "Bacon bits", "Bread sticks");
            changeAddOnPrice("25");
            resetForm();
        }
        // when reset button is clicked, resets form and sets burger to checked
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
            radBurger.Checked = true;
        }
        // for submit button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // meal price variable: set based on selected radio button
            decimal mealPrice = 0;
            // addon price variable: set based on selected radio button
            decimal addonPrice = 0;
            // sum is added on based on how many check boxes are selected
            decimal addons = 0;

            // sets addon price and meal price based off selected radio button
            if (radBurger.Checked)
            {
                // sets addon price to 0.75 and meal price to 6.95 if burger radio button is selected
                addonPrice = 0.75m;
                mealPrice = 6.95m;
            }
            if (radPizza.Checked)
            {
                // sets addon price to 0.50 and meal price to 5.95 if pizza radio button is selected
                addonPrice = 0.50m;
                mealPrice = 5.95m;
            }
            if (radSalad.Checked)
            {
                // sets addon price to 0.25 and meal price to 4.95 if salad radio button is selected
                addonPrice = 0.25m;
                mealPrice = 4.95m;
            }

            // adds add-on price is checkbox is checked ie
            if (chk1.Checked)
            {   
                // if chk1 is checked, it will add addonPrice to addons
                addons += addonPrice;
            }
            if (chk2.Checked)
            {
                // if chk2 is checked, it will add addonPrice to addons
                addons += addonPrice;
            }
            if (chk3.Checked)
            {
                // if chk3 is checked, it will add addonPrice to addons
                addons += addonPrice;
            }

            // adds mealPrice + sum of addons to calculate subTotal
            decimal subTotal = mealPrice + addons;
            // calls calcTaxAndTotal with subTotal as argument which returns taxTotal and Total values
            var (taxTotal, total) = calcTaxAndTotal(subTotal);

            // sets textbox subtotal
            txtSubTotal.Text = subTotal.ToString("c");
            // sets textbox tax
            txtTax.Text = taxTotal.ToString("c");
            // sets textbox total
            txtTotal.Text = decimal.Add(subTotal, taxTotal).ToString("c");
        }

        // when exit button is clicked, closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
