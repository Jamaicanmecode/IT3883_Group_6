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
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\shark\Documents\VandevanAirShuttle_1.accdb");
            command = connection.CreateCommand();
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

                command.CommandText = "SELECT CustomerID FROM Customer WHERE CustomerEmail ='" + c.Email + "'";
                c.Id = Convert.ToDouble(command.ExecuteScalar().ToString());
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

