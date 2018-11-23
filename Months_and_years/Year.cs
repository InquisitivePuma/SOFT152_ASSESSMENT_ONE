using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    class Year
    {
        int date;
        string description;
        Month[] months;

        int handleDate
        {
            get{ return date; }
            set{ date = value; }
        } 
        string handleDescription
        {
            get{ return description; }
            set{ description = value; }
        }
        Month[] handleMonths
        {
            get{ return months; }
            set{ months = value; }

        }
        public Month getMonth(int index) 
        {
            return months[index];
        }//STARTS AT ZERO (0)!
        public Year(int dateIn, string descriptionIn, Month[] monthsIn)
        {
            date = dateIn;
            description = descriptionIn;
            months = monthsIn;
        }
    }
}
