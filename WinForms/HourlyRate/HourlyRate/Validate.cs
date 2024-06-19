using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HourlyRate
{
    public static class Validator
    {   
        public static bool showMessage(TextBox textBox, string message)
        {
            MessageBox.Show($"{textBox.Tag} {message}");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }

        public static bool isDecimal(TextBox textBox)
        {
            bool isValid = Decimal.TryParse(textBox.Text, out decimal value) ? true : showMessage(textBox, "must be a number"); ;
            return isValid;
        }

        public static bool isNotEmpty(TextBox textBox)
        {
            bool isValid = textBox.Text != "" ? true : showMessage(textBox, "cannot not be empty");
            return isValid;
        }

        public static bool isValidated(TextBox textBox)
        {
            bool isValid = false;

            if (isNotEmpty(textBox) && isDecimal(textBox))
            {
                isValid = true;
            }
            return isValid;

        }
    }
}
