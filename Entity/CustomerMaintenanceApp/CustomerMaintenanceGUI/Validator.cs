using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceGUI
{
    /// <summary>
    ///  a collection of static methods to validate user input
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// checks if text box has non-empty string in it
        /// </summary>
        /// <param name="textBox"> text box to check (Tag property specifies meaning)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true; //"innocent until proven guilty"
            if(textBox.Text == "") // bad
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " is required");                
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// checks if values selecetd from a combo box
        /// </summary>
        /// <param name="cbo">combo box to validate</param>
        /// <returns>true is selected and false if not</returns>
        public static bool IsSelected(ComboBox cbo)
        {
            bool isValid = true; //"innocent until proven guilty"
            if (cbo.SelectedIndex == -1) // not selected
            {
                isValid = false;
                MessageBox.Show(cbo.Tag + " needs to be selected");
                cbo.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains non-negative integer
        /// </summary>
        /// <param name="textBox"> text box to check (Tag property specifies meaning)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeInt(TextBox textBox)
        {
            bool isValid = true;
            int value; // parsed value
            if(!Int32.TryParse(textBox.Text, out value)) // bad int
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " has to be a whole number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if(value < 0) // negative
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " must be positive or zero");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains non-negative double
        /// </summary>
        /// <param name="textBox"> text box to check (Tag property specifies meaning)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDouble(TextBox textBox)
        {
            bool isValid = true;
            double value; // parsed value
            if (!Double.TryParse(textBox.Text, out value)) // bad double
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " has to be a number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < 0) // negative
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " must be positive or zero");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }


        /// <summary>
        /// checks if text box contains non-negative decimal
        /// </summary>
        /// <param name="textBox"> text box to check (Tag property specifies meaning)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox textBox)
        {
            bool isValid = true;
            decimal value; // parsed value
            if (!Decimal.TryParse(textBox.Text, out value)) // bad double
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " has to be a number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < 0) // negative
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " must be positive or zero");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        
    }// class
}// namespace
