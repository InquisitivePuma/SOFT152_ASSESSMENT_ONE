using System;
using System.IO;

namespace Months_and_years
{
    class Filereader
    {

        static string locationName;
        static string locationStreet;
        static string locationCounty;
        static string locationPostCode;
        static float locationLatitude;
        static float locationLongtitude;
        static string yearDescription;
        static int yearId;
        static int monthId;
        static float monthMaxTemp;
        static float monthMinTemp;
        static int monthDaysOfAirFrost;
        static float monthMilsOfRainfall;
        static float monthHoursOfSunshine;
        static int numberOfLocations;
        static int numberOfYears;
        static Location thisLocation;
        static Year thisYear;
        static Month thisMonth;
        static Location[] parsedLocations;
        static Year[] parsedYears;
        static Month[] parsedMonths;

        public static Location[] readFile(string fileLocation)
        {
            try
            {
                using (StreamReader dataFile = new StreamReader(fileLocation))
                {

                    numberOfLocations = Convert.ToInt32(dataFile.ReadLine());
                    parsedLocations = new Location[numberOfLocations];

                    ReadLocations(dataFile);

                    return parsedLocations;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error ocurred while executing the data import: {0}", e.Message);
                Console.WriteLine("Additional details: \n {0}", e);
                return new Location[0]; //Null array return indicates failure state.
            }
        }

        private static void ReadLocations(StreamReader data)
        {
            for (int i = 0; i < numberOfLocations; i++) // for each location in the file
            {
                locationName = data.ReadLine();
                locationStreet = data.ReadLine();
                locationCounty = data.ReadLine();
                locationPostCode = data.ReadLine();
                locationLatitude = Convert.ToSingle(data.ReadLine());
                locationLongtitude = Convert.ToSingle(data.ReadLine());
                numberOfYears = Convert.ToInt32(data.ReadLine());
                parsedYears = new Year[numberOfYears];  // each iteration gets a fresh array with a length equal to the number of years in this location.

                ReadYears(data);

                thisLocation = new Location(locationName, locationStreet, locationCounty, locationPostCode, locationLatitude, locationLongtitude, parsedYears);
                parsedLocations[i] = thisLocation;
            }
        }

        private static void ReadYears(StreamReader data)
        {
            for (int j = 0; j < numberOfYears; j++) // for each year in this location
            {
                parsedMonths = new Month[12]; // each iteration gets a fresh array
                yearDescription = data.ReadLine();
                yearId = Convert.ToInt32(data.ReadLine());
                ReadMonths(data);

                thisYear = new Year(yearId, yearDescription, parsedMonths);
                parsedYears[j] = thisYear;

            }
        }

        private static void ReadMonths(StreamReader data)
        {
            for (int k = 0; k < 12; k++) // for each month in this year
            {
                monthId = Convert.ToInt32(data.ReadLine());
                Console.WriteLine(monthId);
                monthMaxTemp = Convert.ToSingle(data.ReadLine());
                monthMinTemp = Convert.ToSingle(data.ReadLine());
                monthDaysOfAirFrost = Convert.ToInt32(data.ReadLine());
                monthMilsOfRainfall = Convert.ToSingle(data.ReadLine());
                monthHoursOfSunshine = Convert.ToSingle(data.ReadLine());
                thisMonth = new Month(monthId, monthMaxTemp, monthMinTemp, monthDaysOfAirFrost, monthMilsOfRainfall, monthHoursOfSunshine);
                parsedMonths[k] = thisMonth;
            }
        }
    }
}

/*Note that this file has not been refactored to be more modular as, 
 * after some consideration, I feel that it is more readable and
 * easier to follow in a linear form. 
 * As well as this, the code her is unlikely to be reused in any smaller
 * section than the whole, given how specialised it is to this particular 
 * dataset. 
 */