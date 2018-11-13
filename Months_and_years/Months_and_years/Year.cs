using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    class Year
    {
        int date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        } // Current plan is to have date in a DDMMYYYY format int. This is likely to change in order to match how it is stored in the given data.
        string description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        Month[] months
        {
            get
            {
                return months;
            }
            set
            {
                months = value;
            }

        }
        public Month getMonth(int index) 
        {
            return months[index];
        }//STARTS AT ZERO (0)
        public Year(int dateIn, string descriptionIn, Month[] monthsIn)
        {
            date = dateIn;
            description = descriptionIn;
            months = monthsIn;
        }
    }
}
