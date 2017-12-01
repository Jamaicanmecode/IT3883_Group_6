using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vandeven_Shuttle
{
    public class Reservation
    {
      private  int customerID;

       private DateTime reservationDate;
        

        public DateTime ReservationDate
        {
            get
            {
                return reservationDate;
            }

            set
            {
                reservationDate = value;
            }
        }

       private DateTime travelDate;
        public DateTime TravelDate
        {
            get
            {
                return travelDate;
            }

            set
            {
                travelDate = value;
            }
        }
        private string destinationCity;
        public string DestinationCity
        {
            get
            {
                return destinationCity;
            }

            set
            {
                destinationCity = value;
            }
        }

        private int passengerCount;
        public int PassengerCount
        {
            get
            {
                return passengerCount;
            }

            set
            {
                passengerCount = value;
            }
        }

        private string reservationMethod;
        public string ReservationMethod
        {
            get
            {
                return reservationMethod;
            }

            set
            {
                reservationMethod = value;
            }
        }


        
        
        
    }
}