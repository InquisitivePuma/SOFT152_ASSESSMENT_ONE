using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    public class Location
    {
        string name;
        string street;
        string county;
        string postcode;
        float lattitude;
        float longtitude;
        Year[] years;

        public string handleName
        {
            get{ return name; }
            set{ name = value; }
        }
        public string handleStreet
        {
            get{ return street; }
            set{ street = value; }
        }
        public string handleCounty
        {
            get{ return county; }
            set{ county = value; }
        }
        public string handlePostcode
        {
            get{ return postcode; }
            set{ postcode = value; }
        }
        public float handleLattitude
        {
            get{ return lattitude; }
            set{ lattitude = value; }
        }
        public float handleLongtitude
        {
            get{ return longtitude;}
            set{ longtitude = value; }
        }
        public Year[] handleYears
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
        public Location() { }

        public void AddYear(Year yearToAdd)
        {
            Year[] newYears = new Year[this.years.Length+1];
            int i = 0;
            bool unadded = false;
            foreach (Year y in years)
            {
                if ( ( unadded && ( y.handleDate < yearToAdd.handleDate ) ) || !unadded ) 
                // if we haven't added the new year but the current year is lower than the new year, or if we've already added the new year.
                {
                    newYears[i] = y;
                }
                else
                {
                    newYears[i] = yearToAdd;
                    newYears[++i] = y;
                }

                i++;                
            }
        }
    }
}
