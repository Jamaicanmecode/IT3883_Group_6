using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vandeven_Shuttle
{
    public partial class vandevenShuttleSystem : Form
    {
        databaseConnection d = new databaseConnection();
        /// <summary>
        /// This is the GUI
        /// </summary>
        /// 
        string first;
        string last;
        string address;
        string number;
        string credit;
        string email;
        bool isEmail = false;

        decimal cost;
        public vandevenShuttleSystem()
        {
            InitializeComponent();
            
        }

        private void vandevenShuttleSystem_Load(object sender, EventArgs e)
        {
            passengersComboBox.SelectedIndex = 0;
            destinationComboBox.SelectedIndex = 0;
            methodOfReservationComboBox.SelectedIndex = 0;
        }


        private void newCustomerDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            
            newUserPanel.Visible = true;
            newUserPanel.BringToFront();
            mainPanel.Visible = false;

        }

        private void firstNameMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void lastNameMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void creditCardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }


        private void destinationComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string destination = destinationComboBox.Text.ToString();
            string temp = passengersComboBox.Text.ToString();
            decimal passengers = Convert.ToDecimal(temp);

            if (destination.Equals("Los Angeles"))
            {
                cost = passengers * 137;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("Chicago"))
            {
                cost = passengers * 79;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("New York"))
            {
                cost = passengers * 118;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("Miami"))
            {
                cost = passengers * 129;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("Dallas"))
            {
                cost = passengers * 96;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("San Diego"))
            {
                cost = passengers * 135;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("Seattle"))
            {
                cost = passengers * 104;
                costLabel.Text = cost.ToString("c");
            }
        }

        private void passengersComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string destination = destinationComboBox.Text.ToString();
            string temp = passengersComboBox.Text.ToString();
            decimal passengers = Convert.ToDecimal(temp);

            if (destination.Equals("Los Angeles"))
            {
                cost = passengers * 137;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("Chicago"))
            {
                cost = passengers * 79;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("New York"))
            {
                cost = passengers * 118;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("Miami"))
            {
                cost = passengers * 129;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("Dallas"))
            {
                cost = passengers * 96;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("San Diego"))
            {
                cost = passengers * 135;
                costLabel.Text = cost.ToString("c");
            }
            if (destination.Equals("Seattle"))
            {
                cost = passengers * 104;
                costLabel.Text = cost.ToString("c");
            }
        }

        private void firstNameMaskedTextBox_Leave(object sender, EventArgs e)
        {
            first = firstNameMaskedTextBox.Text.ToString();
            last = lastNameMaskedTextBox.Text.ToString();
            address = homeAddressTextBox.Text.ToString();
            number = phoneNumberMaskedTextBox.Text.ToString();
            credit = creditCardNumberTextBox.Text.ToString();
            email = emailMaskedTextBox.Text.ToString();

            if (first.Equals(""))
            {
                errorProvider.SetError(firstNameMaskedTextBox, "error");
            }
            else
                errorProvider.SetError(firstNameMaskedTextBox, "");

            if (first.Equals("") || last.Equals("") || address.Equals("") || number.Length < 10 || credit.Length < 16 || isEmail == false)
            {
                confirmPurchaseButton.Enabled = false;
            }
            else
                confirmPurchaseButton.Enabled = true;
        }

        private void lastNameMaskedTextBox_Leave(object sender, EventArgs e)
        {
            first = firstNameMaskedTextBox.Text.ToString();
            last = lastNameMaskedTextBox.Text.ToString();
            address = homeAddressTextBox.Text.ToString();
            number = phoneNumberMaskedTextBox.Text.ToString();
            credit = creditCardNumberTextBox.Text.ToString();
            email = emailMaskedTextBox.Text.ToString();

            if (last.Equals(""))
            {
                errorProvider.SetError(lastNameMaskedTextBox, "error");
            }
            else
                errorProvider.SetError(lastNameMaskedTextBox, "");

            if (first.Equals("") || last.Equals("") || address.Equals("") || number.Length < 10 || credit.Length < 16 || isEmail == false)
            {
                confirmPurchaseButton.Enabled = false;
            }
            else
                confirmPurchaseButton.Enabled = true;
        }

        private void homeAddressTextBox_Leave(object sender, EventArgs e)
        {
            first = firstNameMaskedTextBox.Text.ToString();
            last = lastNameMaskedTextBox.Text.ToString();
            address = homeAddressTextBox.Text.ToString();
            number = phoneNumberMaskedTextBox.Text.ToString();
            credit = creditCardNumberTextBox.Text.ToString();
            email = emailMaskedTextBox.Text.ToString();

            if (address.Equals(""))
            {
                errorProvider.SetError(homeAddressTextBox, "error");
            }
            else
                errorProvider.SetError(homeAddressTextBox, "");

            if (first.Equals("") || last.Equals("") || address.Equals("") || number.Length < 10 || credit.Length < 16 || isEmail == false)
            {
                confirmPurchaseButton.Enabled = false;
            }
            else
                confirmPurchaseButton.Enabled = true;
        }

        private void phoneNumberMaskedTextBox_Leave(object sender, EventArgs e)
        {
            first = firstNameMaskedTextBox.Text.ToString();
            last = lastNameMaskedTextBox.Text.ToString();
            address = homeAddressTextBox.Text.ToString();
            number = phoneNumberMaskedTextBox.Text.ToString();
            credit = creditCardNumberTextBox.Text.ToString();
            email = emailMaskedTextBox.Text.ToString();

            if (number.Length < 10)
            {
                errorProvider.SetError(phoneNumberMaskedTextBox, "error");
            }
            else
                errorProvider.SetError(phoneNumberMaskedTextBox, "");

            if (first.Equals("") || last.Equals("") || address.Equals("") || number.Length < 10 || credit.Length < 16 || isEmail == false)
            {
                confirmPurchaseButton.Enabled = false;
            }
            else
                confirmPurchaseButton.Enabled = true;
        }

        private void creditCardNumberTextBox_Leave(object sender, EventArgs e)
        {
            first = firstNameMaskedTextBox.Text.ToString();
            last = lastNameMaskedTextBox.Text.ToString();
            address = homeAddressTextBox.Text.ToString();
            number = phoneNumberMaskedTextBox.Text.ToString();
            credit = creditCardNumberTextBox.Text.ToString();
            email = emailMaskedTextBox.Text.ToString();

            if (credit.Length < 16)
            {
                errorProvider.SetError(creditCardNumberTextBox, "error");
            }
            else
                errorProvider.SetError(creditCardNumberTextBox, "");

            if (first.Equals("") || last.Equals("") || address.Equals("") || number.Length < 10 || credit.Length < 16 || isEmail == false)
            {
                confirmPurchaseButton.Enabled = false;
            }
            else
                confirmPurchaseButton.Enabled = true;
        }

        private void emailMaskedTextBox_Leave(object sender, EventArgs e)
        {
            first = firstNameMaskedTextBox.Text.ToString();
            last = lastNameMaskedTextBox.Text.ToString();
            address = homeAddressTextBox.Text.ToString();
            number = phoneNumberMaskedTextBox.Text.ToString();
            credit = creditCardNumberTextBox.Text.ToString();
            email = emailMaskedTextBox.Text.ToString();
            string pattern = "^([0-9a-zA-z]([-\\.\\w]*[0-9a-zA-z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(emailMaskedTextBox.Text, pattern))
            {
                isEmail = true;
                errorProvider.SetError(emailMaskedTextBox, "");
            }
            else
            {
                isEmail = false;
                errorProvider.SetError(emailMaskedTextBox, "error");
            }

            if (first.Equals("") || last.Equals("") || address.Equals("") || number.Length < 10 || credit.Length < 16 || isEmail == false)
            {
                confirmPurchaseButton.Enabled = false;
            }
            else
                confirmPurchaseButton.Enabled = true;
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            mainPanel.BringToFront();
            reservationCompletePanel.Visible = false;
            passengersComboBox.SelectedIndex = 0;
            destinationComboBox.SelectedIndex = 0;
            methodOfReservationComboBox.SelectedIndex = 0;
            confirmPurchaseButton.Enabled = false;
            firstNameMaskedTextBox.Text = "";
            lastNameMaskedTextBox.Text = "";
            homeAddressTextBox.Text = "";
            phoneNumberMaskedTextBox.Text = "";
            creditCardNumberTextBox.Text = "";
            emailMaskedTextBox.Text = "";
            existingCustomerTextBox.Text = "";
            costLabel.Text = "$00.00";
        }

        private void confirmPurchaseButton_Click(object sender, EventArgs e)
        {
            newUserPanel.Visible = false;
            reservationCompletePanel.Visible = true;
            reservationCompletePanel.BringToFront();

            Customer c = new Customer();
            c.FirstName = firstNameMaskedTextBox.Text;
            c.LastName = lastNameMaskedTextBox.Text;
            c.Address = homeAddressTextBox.Text;
            c.CreditCardNumber = creditCardNumberTextBox.Text.ToString();
            c.Email = emailMaskedTextBox.Text;
            c.PhoneNumber = Convert.ToDouble(phoneNumberMaskedTextBox.Text);

            Reservation r = new Reservation();
            r.DestinationCity = destinationComboBox.SelectedItem.ToString();
            r.PassengerCount = Convert.ToInt32(passengersComboBox.SelectedItem.ToString());
            r.ReservationDate = DateTime.Today;
            r.ReservationMethod = methodOfReservationComboBox.SelectedItem.ToString();
            r.TravelDate = departingDateTimePicker.Value.Date;

            d.InsertCustomer(c);
            d.InsertReservation(r, c);
            
        }

    }
}
