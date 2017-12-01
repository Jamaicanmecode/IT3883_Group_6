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
        OleDbCommand getIdCommand;
        int id;

        // Change the connection location when adding it to the final build
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Downloads\VandevanAirShuttle_1.accdb");
            command = connection.CreateCommand();
            getIdCommand = connection.CreateCommand();
        }

        public databaseConnection()
        {
            ConnectTo();
        }

        public void InsertCustomer(Customer c)
        {
            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO Customer (FirstName, LastName, CustomerAddress, CustomerNumber, CreditCardNumber, CustomerEmail) VALUES ('" + c.FirstName + "','" +
                    c.LastName + "','" + c.Address + "','" + c.PhoneNumber + "','" + c.CreditCardNumber + "','" + c.Email + "')";
                command.CommandType = System.Data.CommandType.Text;

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

        // Existing customer code
        public void InsertReservation(Reservation r)
        {
            try
            {
                command.CommandText = "INSERT INTO Reservation (CustomerID, ReserveDate, TravelDate, DestinationCity, NumPassengers, ShuttleID, ReservMethod) VALUES ('"+id + "','" + 
                    r.ReservationDate + "','" + r.TravelDate + "','" + r.DestinationCity + "','" + r.PassengerCount + "','" + 1 + "','" + r.ReservationMethod +"')";
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

        public void SearchCustomer (existingCustomer ec)
        {
            try
            {
                command.CommandText = "SELECT * FROM Customer WHERE CustomerEmail = 'ec.Email'";
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();

                //Write code that will use Output of query and set Customer.cs with values from query and send it to the UI.

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

