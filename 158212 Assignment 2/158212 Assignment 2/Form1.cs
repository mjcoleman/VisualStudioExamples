/* 158.212 Assignment 2 by Michael Coleman 07315554
 * Credit to the MSDN Documentation for the format modifiers.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _158212_Assignment_2 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Load the supported currencies into the ComboBoxes.
            List<string> currencyToList = new List<string>{"Select a currency...", "NZD", "AUD", "EUR", "USD", "CAD", "GBP"};
            List<string> currencyFromList = new List<string>{"Select a currency...","NZD", "AUD", "EUR", "USD", "CAD", "GBP" };
            CurrencyFromSelector.DataSource = currencyFromList;
            CurrencyToSelector.DataSource = currencyToList;
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            //Clear all fields and set everything back to default.
            CurrencyToSelector.SelectedIndex = 0;
            CurrencyToSelector.ForeColor = Color.Black;
            CurrencyFromSelector.SelectedIndex = 0;
            CurrencyFromSelector.ForeColor = Color.Black;
            ConversionInput.Text = "";
            ErrorLabel.Text = "";
            ErrorLabel.Hide();
            ResultLabel.Text = "";
        }

        private void ConvertButton_Click(object sender, EventArgs e) {
            //Make sure we can actually convert, and set the error label if not.
            if (CurrencyFromSelector.SelectedIndex == 0) {

                //No Currency Selected in the 'From' field.
                CurrencyFromSelector.ForeColor = Color.Red;
                ErrorLabel.Text = "Error: No currency selected to convert from.";
                ErrorLabel.Show();

            } else if (CurrencyToSelector.SelectedIndex == 0) {

                //No Currency Seleceted int the 'To' field.
                CurrencyToSelector.ForeColor = Color.Red;
                ErrorLabel.Text = "Error: No currency selected to convert to.";
                ErrorLabel.Show();

            } else {

                //Nothing wrong with the currency combo boxes, hide any error currently showing.
                ErrorLabel.Hide();

                //Put the input into a string so we can remove any currency symbols the user might of entered.
                string userInput = ConversionInput.Text;
                if (userInput.Contains('$')) {
                    userInput = userInput.Replace("$", "");
                } else if (userInput.Contains('£')) {
                    userInput = userInput.Replace("£", "");
                } else if (userInput.Contains("€")) {
                    userInput = userInput.Replace("€", "");
                }

                try {
                    /* Attempt to convert the string to a double. If it fails, the user has entered something other than a number.
                    * I am not producing an error for negative amounts, in case someone wants to work out their debt in another currency. ¯\_(ツ)_/¯ 
                    */
                    double userAmount = Double.Parse(userInput);
                    Convert(userAmount, CurrencyFromSelector.GetItemText(CurrencyFromSelector.SelectedItem), CurrencyToSelector.GetItemText(CurrencyToSelector.SelectedItem));

                } catch {

                    //Input wasn't a number, or had extra characters in it, show an error and let the user try again.
                    ErrorLabel.Text = "Error: Amount Entered was not a valid number";
                    ErrorLabel.Show();
                }
            }
        }

        private void CurrencyFromSelector_SelectedIndexChanged(object sender, EventArgs e) {
            //If we're coming off an error, and the fore color is currently red, change it back to black.
            if (CurrencyFromSelector.ForeColor == Color.Red && CurrencyFromSelector.SelectedIndex != 0) {
                CurrencyFromSelector.ForeColor = Color.Black;
            }
        }

        private void CurrencyToSelector_SelectedIndexChanged(object sender, EventArgs e) {
            //If we're coming off an error, and the fore color is currently red, change it back to black.
            if (CurrencyToSelector.ForeColor == Color.Red && CurrencyToSelector.SelectedIndex != 0) {
                CurrencyToSelector.ForeColor = Color.Black;
            }
        }
        private void Convert(double amount, string from, string to){

            //Convert from and to using GetExchangeRate to perform the correct calculation.
            double convertedAmount = (amount / GetExchangeRate(from)) * GetExchangeRate(to);

            //Get the correct currency symbols for the currencies selected. Using the region specifiers doesn't work properly.
            char currencySymbolFrom = GetCurrencySymbol(from);
            char currencySymbolTo = GetCurrencySymbol(to);
            
            //Set up and show the result of the calculation. Not using the 'C' modifier because of the regional currency symbols.
            ResultLabel.Text = string.Format("{0}{1:N2} {2} is {3}{4:N2} {5}",currencySymbolFrom, amount, from, currencySymbolTo,convertedAmount, to);
            ResultLabel.Show();
        }

        private double GetExchangeRate(string currency) {
            //Returns the exchange rate vs the default of $1USD.
            switch (currency) {
                case "EUR":
                    return 0.95;
                case "AUD":
                    return 1.31;
                case "CAD":
                    return 1.28;
                case "GBP":
                    return 0.68;
                case "NZD":
                    return 1.36;
            }

            return 1.0;
        }
        private char GetCurrencySymbol(string currency) {
            //Returns the correct currency symbol for the region. Default is '$'
            switch (currency) {
                case "GBP":
                    return '£';
                case "EUR":
                    return '€';
            }
            return '$';
        }
    }
}
