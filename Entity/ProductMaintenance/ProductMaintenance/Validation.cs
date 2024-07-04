/*
 * AUTHOR: GAVIN OIAMO
 * DATE: 2024/07/03
 * PURPOSE: CLASS FOR VALIDATION
 */

using System.Text.RegularExpressions;

namespace ProductMaintenance
{
    internal class Validation
    {
        /// <summary>
        /// Checks if value is decimal. returns boolean
        /// </summary>
        /// <param name="value">Value to be evaluated</param>
        /// <param name="name">Name of field for exceptions</param>
        /// <returns></returns>
        public bool checkIsDecimal(string value, string name)
        {
            bool success = true;
            try
            {
                // checks if value is both a decimal and not empty
                if (value == "") throw new Exception($"{name} cannot be left empty");

                if (!Decimal.TryParse(value, out decimal v))
                    throw new Exception($"{name} is invalid. Can only contain 0-9 and '.'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                success = false;
            }
            return success;
        }

        /// <summary>
        /// Checks if value is a single word. returns boolean
        /// </summary>
        /// <param name="word">Value to be evaluated</param>
        /// <param name="name">Name of field for exceptions</param>
        /// <returns></returns>
        public bool checkIsWord(string word, string name)
        {
            bool success = true;
            try
            {
                // Checks if value is blank and that it contains only letters
                Regex reg = new Regex("(^[a-zA-Z]+)$");
                if (word == "") throw new Exception($"{name} code cannot be left empty");
                if (!reg.IsMatch(word)) 
                    throw new Exception($"{name} code is Invalid. Can only contain letters");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                success = false;
            }
            return success;
        }

        /// <summary>
        /// Checks if value is a sentence without numbers. returns boolean
        /// </summary>
        /// <param name="str">Value to be evaluated</param>
        /// <param name="name">Name of field for exceptions</param>
        /// <returns></returns>
        public bool checkIsSentence(string str, string name)
        {
            bool success = true;
            try
            {
                // validates that sentence does not contain multiple spaces between words and has no numbers
                Regex reg = new Regex("^([a-zA-Z]+\\s)*[a-zA-Z]+$");
                if (str == "") throw new Exception($"{name} cannot be empty");
                if (!reg.IsMatch(str.TrimEnd())) throw new Exception($"{name} is invalid. Can only contain letters and spaces!");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ensure that sentence does not have multiple spaces or numbers.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                success = false;
            }
            return success;
        }

    }
}
