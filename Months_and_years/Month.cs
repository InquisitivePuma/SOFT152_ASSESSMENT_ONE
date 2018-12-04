using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    public class Month
    {
        int identity;
        float maximumTemperature;
        float minimumTemperature;
        float daysOfAirFrost;
        float millimitersOfRainfall;
        float hoursOfSunshine;
        static string[] names = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


        public int handleIdentity
        {
            get{ return identity; }
            set{ identity = value; }
        }
        public float handleMaximumTemperature
        {
            get{ return maximumTemperature; }
            set{ maximumTemperature = value; }
        }
        public float handleMinimumTemperature
        {
            get{ return minimumTemperature; }
            set{ minimumTemperature = value; }
        }
        public float handleDaysOfAirFrost
        {
            get{ return daysOfAirFrost; }
            set{ daysOfAirFrost = value; }
        }
        public float handleMillimitersOfRainfall
        {
            get{ return millimitersOfRainfall; }
            set{ millimitersOfRainfall = value; }
        }
        public float handleHoursOfSunshine
        {
            get{ return hoursOfSunshine; }
            set{ hoursOfSunshine = value; }
        }
        public string handleName
        {
            get { return names[identity-1];  } // Arrays start at 0, the month identities start at 1.
        }

        public Month(int identityIn, float minimumTemperatureIn, float maximumTemperatureIn, float daysOfFrostIn, float millimitersOfRainIn, float hoursOfSunIn)
        {
            identity = identityIn;
            minimumTemperature = minimumTemperatureIn;
            maximumTemperature = maximumTemperatureIn;
            daysOfAirFrost = daysOfFrostIn;
            millimitersOfRainfall = millimitersOfRainIn;
            hoursOfSunshine = hoursOfSunIn;
        }
        public Month(){}
    }
}
