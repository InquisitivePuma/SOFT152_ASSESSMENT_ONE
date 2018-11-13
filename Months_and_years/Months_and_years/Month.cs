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
        int minimumTemperature
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
        int maximumTemperature
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
        int millimitersOfRainfall
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
        int hoursOfSunshine
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
        public Month(int identityIn, int minimumTemperatureIn, int maximumTemperatureIn, int daysOfFrostIn, int millimitersOfRainIn, int hoursOfSunIn)
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
