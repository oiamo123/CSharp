using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{   
    /// <summary>
    /// a collection of static methods to validate user input
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// checks if textbox is not empty
        /// </summary>
        /// <param name="textBox">text box to check (Tag specifies meaning)</param>
        /// <returns>returns true if valid and false if not</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text == "")
            {
                MessageBox.Show($"{textBox.Tag} is required.");
                isValid = false;
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// checks if textbox is a negative double
        /// </summary>
        /// <param name="textBox">text box to check (Tag specifies meaning)</param>
        /// <returns>returns false if number is negative and true if number is not</returns>
        public static bool isNonNegativeDouble(TextBox textBox)
        {
            bool isValid = true;
            double value; // parsed value
            if (!Double.TryParse(textBox.Text, out value))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} has to be a number.");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < 0)
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be positive or zero");
                textBox.SelectAll();
                textBox.Focus();
            }

            return isValid;
        }

        /// <summary>
        /// checks if textbox is a negative decimal
        /// </summary>
        /// <param name="textBox">text box to check (Tag specifies meaning)</param>
        /// <returns>returns false if number is negative and true if number is not</returns>
        public static bool isNonNegativeDecimal(TextBox textBox)
        {
            bool isValid = true;
            decimal value; // parsed value
            if (!Decimal.TryParse(textBox.Text, out value))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} has to be a number.");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < 0)
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be positive or zero");
                textBox.SelectAll();
                textBox.Focus();
            }

            return isValid;
        }
        /// <summary>
        /// checks if textbox is a negative decimal
        /// </summary>
        /// <param name="textBox">text box to check (Tag specifies meaning)</param>
        /// <returns>returns false if number is negative and true if number is not</returns>
        public static bool isDecimalInRange(TextBox textBox, decimal minValue, decimal maxValue)
        {
            bool isValid = true;
            decimal value; // parsed value
            if (!Decimal.TryParse(textBox.Text, out value))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} has to be a number.");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < minValue || value > maxValue)
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be between {minValue} and {maxValue}");
                textBox.SelectAll();
                textBox.Focus();
            }

            return isValid;
        }
    }
}
