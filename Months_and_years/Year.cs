using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    public class Year
    {
        #region attributes

        int date;
        string description;
        Month[] months;

        public int handleDate
        {
            get{ return date; }
            set{ date = value; }
        }
        public string handleDescription
        {
            get{ return description; }
            set{ description = value; }
        }
        public Month[] handleMonths
        {
            get{ return months; }
            set{ months = value; }

        }
        public Month GetMonth(int index)
        {
            return months[index];
        }//STARTS AT ZERO (0)!

        #endregion
        // Above are attributes and their handlers. Variable declarations, getters, setters, boring stuff.

        public Year(int dateIn, string descriptionIn, Month[] monthsIn)
        {
            date = dateIn;
            description = descriptionIn;
            months = monthsIn;
        }
        public Year(){}
        // Two constructors: One for setting the attributes there and then, one for doing them later (i.e. creating a null year). Allows for some cleaner code, and shows off polymorphism.
    }
}
