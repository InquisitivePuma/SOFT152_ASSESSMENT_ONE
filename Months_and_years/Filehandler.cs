using System;
using System.IO;

namespace Months_and_years
{
    class Filehandler
    {

        static string locationName;
        static string locationStreet;
        static string locationCounty;
        static string locationPostCode;
        static float locationLatitude;
        static float locationLongtitude;
        static string yearDescription;
        static int yearDate;
        static int monthId;
        static float monthMaxTemp;
        static float monthMinTemp;
        static float monthDaysOfAirFrost;
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
        static string staticFileLocation;

        #region read

        public static Location[] ReadFile(string fileLocation)
        {
            try
            {
                using (StreamReader dataFile = new StreamReader(fileLocation, false))
                {

                    numberOfLocations = Convert.ToInt32(dataFile.ReadLine());
                    parsedLocations = new Location[numberOfLocations];
                    Console.WriteLine("Debug: There are {0} locations in this file.", numberOfLocations);
                    ReadLocations(dataFile);
                    staticFileLocation = fileLocation;

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
                yearDescription = data.ReadLine();
                yearDate = Convert.ToInt32(data.ReadLine());

                parsedMonths = new Month[12]; // each iteration gets a fresh array

                ReadMonths(data);

                thisYear = new Year(yearDate, yearDescription, parsedMonths);
                parsedYears[j] = thisYear;

            }
        }

        private static void ReadMonths(StreamReader data)
        {
            for (int k = 0; k < 12; k++) // for each month in this year
            {
                monthId = Convert.ToInt32(data.ReadLine());
                monthMaxTemp = Convert.ToSingle(data.ReadLine());
                monthMinTemp = Convert.ToSingle(data.ReadLine());
                monthDaysOfAirFrost = Convert.ToSingle(data.ReadLine());
                monthMilsOfRainfall = Convert.ToSingle(data.ReadLine());
                monthHoursOfSunshine = Convert.ToSingle(data.ReadLine());
                if (k < 11) { data.ReadLine(); } // This skips the repeated yearID, which we only need once per year.
                thisMonth = new Month(monthId, monthMaxTemp, monthMinTemp, monthDaysOfAirFrost, monthMilsOfRainfall, monthHoursOfSunshine);
                parsedMonths[k] = thisMonth;
            }


        }

        #endregion
        //-----------------------------------------------------------------------------------------------------//
        #region write

        public static void SaveFile(Location[] data)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(/*staticFileLocation*/@"C: \Users\cellv\Desktop\SOFT152_ASSESSMENT_ONE\Data\testOutput.txt", false))
                {
                    file.WriteLine(numberOfLocations);
                    WriteLocations(file, data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error ocurred while executing the data import: {0}", e.Message);
                Console.WriteLine("Additional details: \n {0}", e);
            }
        }

        private static void WriteLocations(StreamWriter f, Location[] data) // To save you double-checking: f is the StreamWriter, with f standing for file.
        {                                                                   // l is the location that we're working with at the moment.                                     
            foreach (Location l in data)                                    // we're using single-letter variables because intelliSense has straight-up died on me right now.
            {
                f.WriteLine(l.handleName);
                f.WriteLine(l.handleStreet);
                f.WriteLine(l.handleCounty);
                f.WriteLine(l.handlePostcode);
                f.WriteLine(l.handleLattitude);
                f.WriteLine(l.handleLongtitude);
                f.WriteLine(l.handleYears.Length);
                WriteYears(f, l.handleYears);
            }
        }

        private static void WriteYears(StreamWriter f, Year[] data)
        {
            foreach (Year y in data)
            {
                f.WriteLine(y.handleDescription);
                f.WriteLine(y.handleDate);
                WriteMonths(f, y.handleMonths, y.handleDate);
            }
        }

        private static void WriteMonths(StreamWriter f, Month[] data, int date)
        {
            foreach (Month m in data)
            {
                f.WriteLine(m.handleIdentity);
                f.WriteLine(m.handleMaximumTemperature);
                f.WriteLine(m.handleMinimumTemperature);
                f.WriteLine(m.handleDaysOfAirFrost);
                f.WriteLine(m.handleMillimitersOfRainfall);
                f.WriteLine(m.handleHoursOfSunshine);
                f.WriteLine(date);
            }
        }

        #endregion
    }
    
}
