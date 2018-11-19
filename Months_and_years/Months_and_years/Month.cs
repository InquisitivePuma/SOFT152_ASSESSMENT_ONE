using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    class Month
    {
        int identity
        {
            get
            {
                return identity;
            }
            set
            {
                identity = value;
            }
        }
        float maximumTemperature
        {
            get
            {
                return maximumTemperature;
            }
            set
            {
                maximumTemperature = value;
            }
        }
        float minimumTemperature
        {
            get
            {
                return minimumTemperature;
            }
            set
            {
                minimumTemperature = value;
            }
        }
        int daysOfAirFrost
        {
            get
            {
                return daysOfAirFrost;
            }
            set
            {
                daysOfAirFrost = value;
            }
        }
        float millimitersOfRainfall
        {
            get
            {
                return millimitersOfRainfall;
            }
            set
            {
                millimitersOfRainfall = value;
            }
        }
        float hoursOfSunshine
        {
            get
            {
                return hoursOfSunshine;
            }
            set
            {
                hoursOfSunshine = value;
            }
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
