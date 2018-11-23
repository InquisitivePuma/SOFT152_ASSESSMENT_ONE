using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    class Location
    {
        string name;
        string street;
        string county;
        string postcode;
        float lattitude;
        float longtitude;
        Year[] years;

        string handleName
        {
            get{ return name; }
            set{ name = value; }
        }
        string handleStreet
        {
            get{ return street; }
            set{ street = value; }
        }
        string handleCounty
        {
            get{ return county; }
            set{ county = value; }
        }
        string handlePostcode
        {
            get{ return postcode; }
            set{ postcode = value; }
        }
        float handleLattitude
        {
            get{ return lattitude; }
            set{ lattitude = value; }
        }
        float handleLongtitude
        {
            get{ return longtitude;}
            set{ longtitude = value; }
        } 
        Year[] handleYears
        {
            get{ return years; }
            set{ years = value; }
        }
        public Year GetYear(int index)
        {
            return years[index];
        }//STARTS AT ZERO (0)!
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
