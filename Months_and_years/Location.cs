using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    class Location
    {
        string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        string street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        string county
        {
            get
            {
                return county;
            }
            set
            {
                county = value;
            }
        }
        string postcode
        {
            get
            {
                return postcode;
            }
            set
            {
                postcode = value;
            }
        }
        float lattitude
        {
            get
            {
                return lattitude;
            }
            set
            {
                lattitude = value;
            }
        }
        float longtitude
        {
            get
            {
                return longtitude;
            }
            set
            {
                longtitude = value;
            }
        } 
        Year[] years
        {
            get
            {
                return years;
            }
            set
            {
                years = value;
            }
        }
        public Year GetYear(int index)
        {
            return years[index];
        }
        public Location(string nameIn, string streetIn, string countyIn, string postcodeIn, float lattitudeIn, float longtitudeIn, Year[] yearsIn)
        {
            name = nameIn;
            street = streetIn;
            county = countyIn;
            postcode = postcodeIn;
            lattitude = lattitudeIn;
            longtitude = longtitudeIn;
            years = yearsIn;
        }
    }
}
