using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    public class Month
    {
        #region attributes

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
            get { return names[identity-1];  } // Arrays start at 0, the month identities start at 1. No need for a set; the name must be linked ot the id.
        }

        #endregion
        // Above are attributes and their handlers. Variable declarations, getters, setters, boring stuff.
        // There is also a static array matching month ids to month names; the month's aren't recorded my name in the data, but being able to display them as such is useful.

        public Month(int identityIn, float minimumTemperatureIn, float maximumTemperatureIn, float daysOfFrostIn, float millimitersOfRainIn, float hoursOfSunIn)
        {
            identity = identityIn;
            minimumTemperature = minimumTemperatureIn;
            maximumTemperature = maximumTemperatureIn;
            daysOfAirFrost = daysOfFrostIn;
            millimitersOfRainfall = millimitersOfRainIn;
            hoursOfSunshine = hoursOfSunIn;
        }
        public Month(){ }
        // Two constructors: One for setting the attributes there and then, one for doing them later (i.e. creating a null month). Allows for some cleaner code, and shows off polymorphism.
    }
}
