/*
 * Author - Raikhana Urazbaeva 
 * Class - Validator class handles the data validation for the user entries.
 * June 2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Project
{
    class Validator
    {
        public static string Title { get; set; } = "Entry Error";
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool IsPresentComboBox(ComboBox comboBox)
        {
            if (comboBox.Text == "")
            {
                MessageBox.Show(comboBox.Tag + " is a required field.", Title);
                comboBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            Int64 number = 0;
            if (Int64.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(TextBox textBox, int min, int max)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsWithinRangeString(TextBox textBox,int min, int max)
        {
            string number = textBox.Text;
            if (number.Length > max || number.Length < min)
            {
                MessageBox.Show(textBox.Tag + " number should be " +  max + " digit number " + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(TextBox textBox)
        {
            if (textBox.Text.IndexOf("@") == -1 ||
                 textBox.Text.IndexOf(".") == -1)
            {
                MessageBox.Show("It is not a valid  " + textBox.Tag + ".", Title);

                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
       
        public static bool IsValidPassword(TextBox textBox)
        {
            var input = textBox.Text;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@"^.{8,15}$");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            var isValidated = hasNumber.IsMatch(input)
                              && hasUpperChar.IsMatch(input)
                              && hasMinimum8Chars.IsMatch(input)
                              && hasLowerChar.IsMatch(input)
                              && hasSymbols.IsMatch(input);
            if (isValidated == true)
            {
                
                return true;
            }
            else
            {
                MessageBox.Show("Password is incorrect please try again" + "\r\n"
                                + "Password  must contain at least a number, " + "\r\n" +
                                "one upper case letter and  8 characters." + "\r\n" +
                                "one special case characters ", Title);
                textBox.Clear();
                return false;
            }
        }

        public static bool IsValidString(TextBox textBox)
        {
            var input  = textBox.Text;
            var hasMiniMaxChars = new Regex(@"^.{2,30}$");
           
            if (!hasMiniMaxChars.IsMatch(input))
            {
                MessageBox.Show(textBox.Tag + " should not be less than 2 or greater" +
                                " than 15 characters", Title);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidPostalCode(TextBox textBox)
        {
            var hasMiniMaxChars = new Regex(@"^.{6,6}$");
            if (!hasMiniMaxChars.IsMatch(textBox.Text))
            {
                MessageBox.Show("Postal Code should  be 6 characters", Title);
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsValidName(TextBox textBox)
        {
            string text = textBox.Text;
            if (!Regex.Match(text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid " + textBox.Tag  + "\r\n" +
                                "Name must start with upper case letter", Title);
                return false;
            }
            return true;
        }

    }
}

