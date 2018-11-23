using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    class Month
    {
        int identity;
        float maximumTemperature;
        float minimumTemperature;
        int daysOfAirFrost;
        float millimitersOfRainfall;
        float hoursOfSunshine;

        int handleIdentity
        {
            get{ return identity; }
            set{ identity = value; }
        }
        float handleMaximumTemperature
        {
            get{ return maximumTemperature; }
            set{ maximumTemperature = value; }
        }
        float handleMinimumTemperature
        {
            get{ return minimumTemperature; }
            set{ minimumTemperature = value; }
        }
        int handleDaysOfAirFrost
        {
            get{ return daysOfAirFrost; }
            set{ daysOfAirFrost = value; }
        }
        float handleMillimitersOfRainfall
        {
            get{ return millimitersOfRainfall; }
            set{ millimitersOfRainfall = value; }
        }
        float handleHoursOfSunshine
        {
            get{ return hoursOfSunshine; }
            set{ hoursOfSunshine = value; }
        }
        public Month(int identityIn, float minimumTemperatureIn, float maximumTemperatureIn, int daysOfFrostIn, float millimitersOfRainIn, float hoursOfSunIn)
        {
            identity = identityIn;
            minimumTemperature = minimumTemperatureIn;
            maximumTemperature = maximumTemperatureIn;
            daysOfAirFrost = daysOfFrostIn;
            millimitersOfRainfall = millimitersOfRainIn;
            hoursOfSunshine = hoursOfSunIn;
        }

    }
}
