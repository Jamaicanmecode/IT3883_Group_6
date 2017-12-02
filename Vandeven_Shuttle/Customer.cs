using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vandeven_Shuttle
{
    class Customer
    {
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        private string lastName;

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        private string address;
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        private string creditCardNumber;
        public string CreditCardNumber
        {
            get
            {
                return creditCardNumber;
            }

            set
            {
                creditCardNumber = value;
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        private long id;
        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }


    }
}
