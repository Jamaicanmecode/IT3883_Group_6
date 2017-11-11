using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vandeven_Shuttle
{
    public interface GUIcd
    {
        /// <summary>
        /// This is the void method used to gather the values from the text boxs
        /// </summary>
        void main();
        /// <summary>
        /// This method is use to check the date selected from the calendar is within the set limits
        /// </summary>
        void DateValidator();
    }
}