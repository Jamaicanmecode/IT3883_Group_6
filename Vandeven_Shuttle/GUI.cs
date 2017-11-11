using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vandeven_Shuttle
{
    public interface GUI
    {
        /// <summary>
        /// This method is used to collect the input in the textboxes
        /// </summary>
        void voidMain();
        /// <summary>
        /// This method check the calender and make sure the input is not more then 60 days in advance
        /// </summary>
        void calenderCheck();
        /// <summary>
        /// This method check the current load on the shuttle and make sure its under the limit
        /// </summary>
        void loadCheck();
        /// <summary>
        /// Creates a new customer with the constructor
        /// </summary>
        void newCustomer();
        /// <summary>
        /// This method calls the load from database
        /// </summary>
        void existingCustomer();
        void reservationType();
        /// <summary>
        /// Loads the destinations from the database
        /// </summary>
        void destinationsLoad();
    }
}