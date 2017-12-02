using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vandeven_Shuttle
{
    class databaseConnection
    {
        System.Data.OleDb.OleDbConnection connection;
        OleDbCommand command;

        // Change the connection location when adding it to the final build
        /// <summary>
        /// Set the connection string for the datebase and creates a new command object
        /// </summary>
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shadybrook\Documents\Visual Studio 2015\Projects\VandevanAirShuttle_1.accdb");
            command = connection.CreateCommand();
        }

        public databaseConnection()
        {
            ConnectTo();
        }

        /// <summary>
        /// Gathers existing customer information from the database to display in the GUI
        /// </summary>
        public List<String> getCustomerInfo(String email)
        {
            List<String> customerInformation = new List<String>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT CustomerID FROM Customer WHERE CustomerEmail ='" + email + "'";
                customerInformation.Add(command.ExecuteScalar().ToString());
                command.CommandText = "SELECT FirstName FROM Customer WHERE CustomerEmail ='" + email + "'";
                customerInformation.Add(command.ExecuteScalar().ToString());
                command.CommandText = "SELECT LastName FROM Customer WHERE CustomerEmail ='" + email + "'";
                customerInformation.Add(command.ExecuteScalar().ToString());
                command.CommandText = "SELECT CustomerAddress FROM Customer WHERE CustomerEmail ='" + email + "'";
                customerInformation.Add(command.ExecuteScalar().ToString());
                command.CommandText = "SELECT CustomerNumber FROM Customer WHERE CustomerEmail ='" + email + "'";
                customerInformation.Add(command.ExecuteScalar().ToString());
                command.CommandText = "SELECT CreditCardNumber FROM Customer WHERE CustomerEmail ='" + email + "'";
                customerInformation.Add(command.ExecuteScalar().ToString());
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return customerInformation;
        }

        /// <summary>
        /// Compares the customer's email to the email records the database
        /// </summary>
        public Boolean exisitingCustomerVerification(String email)
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT CustomerID FROM Customer WHERE CustomerEmail ='" + email + "'";
                long customerId = Convert.ToInt64(command.ExecuteScalar().ToString());
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return true;
        }

        /// <summary>
        /// Insert Information into the customer table from the new customer section in the GUI
        /// </summary>
        public void InsertCustomer(Customer c)
        {
            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO Customer (FirstName, LastName, CustomerAddress, CustomerNumber, CreditCardNumber, CustomerEmail) VALUES (?,?,?,?,?,?)";
                command.Parameters.AddWithValue("FirstName", c.FirstName);
                command.Parameters.AddWithValue("LastName", c.LastName);
                command.Parameters.AddWithValue("CustomerAddress", c.Address);
                command.Parameters.AddWithValue("CustomerPhoneNumber", c.PhoneNumber);
                command.Parameters.AddWithValue("CustomerCreditCardNumber", c.CreditCardNumber);
                command.Parameters.AddWithValue("CustomerEmail", c.Email);

                command.ExecuteNonQuery();

                command.CommandText = "SELECT CustomerID FROM Customer WHERE CustomerEmail ='" + c.Email + "'";
                c.Id = Convert.ToInt64(command.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Insert information into the reservation table from the existing customer section in the GUI
        /// </summary>
        public void InsertReservationExisiting(Reservation r, long customerId)
        {
            try
            {
                command.CommandText = "INSERT INTO Reservation (CustomerID, ReserveDate, TravelDate, DestinationCity, NumPassengers, ShuttleID, ReservMethod) VALUES ('" + customerId + "','" +
                    r.ReservationDate + "','" + r.TravelDate + "','" + r.DestinationCity + "','" + r.PassengerCount + "','" + 1 + "','" + r.ReservationMethod + "')";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Insert information into the reservation table from the new customer section in the GUI
        /// </summary>
        public void InsertReservation(Reservation r, Customer c)
        {
            try
            {
                int id = Convert.ToInt32(c.Id);
                command.CommandText = "INSERT INTO Reservation (CustomerID, ReserveDate, TravelDate, DestinationCity, NumPassengers, ShuttleID, ReservMethod) VALUES ('" + id + "','" +
                    r.ReservationDate + "','" + r.TravelDate + "','" + r.DestinationCity + "','" + r.PassengerCount + "','" + 1 + "','" + r.ReservationMethod + "')";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


    }
}

