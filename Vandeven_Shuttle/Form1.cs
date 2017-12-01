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

        private void emailMaskedTextBox_Leave(object sender, EventArgs e)
        {
        
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

        private void confirmPurchaseButton_Click(object sender, EventArgs e)
        {
            newUserPanel.Visible = false;
            reservationCompletePanel.Visible = true;
            reservationCompletePanel.BringToFront();

            Customer c = new Customer();
            c.FirstName = firstNameMaskedTextBox.Text;
            c.LastName = lastNameMaskedTextBox.Text;
            c.Address = homeAddressTextBox.Text;
            c.CreditCardNumber = Convert.ToDouble(creditCardNumberTextBox.Text);
            c.Email = emailMaskedTextBox.Text;
            c.PhoneNumber = Convert.ToDouble(phoneNumberMaskedTextBox.Text);

            Reservation r = new Reservation();
            r.DestinationCity = destinationComboBox.SelectedItem.ToString();
            r.PassengerCount = Convert.ToInt32(passengersComboBox.SelectedItem.ToString());
            r.ReservationDate = DateTime.Today;
            r.ReservationMethod = methodOfReservationComboBox.SelectedItem.ToString();
            r.TravelDate = departingDateTimePicker.Value.Date;
            
            d.InsertCustomer(c);
            d.InsertReservation(r);
        }

    }
}
