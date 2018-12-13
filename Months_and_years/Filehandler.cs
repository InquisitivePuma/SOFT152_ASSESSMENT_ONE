using System;
using System.IO;

namespace Months_and_years
{
    class Filehandler
    {        
        #region Static variables declaration
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

        #endregion 
        // If there's a variable and it wasn't explicitly passed into the function you're looking at, it's declared here.

        #region read

        public static Location[] ReadFile(string fileLocation)
        {
            try
            {
                using (StreamReader fileReader = new StreamReader(fileLocation, false))
                {

                    numberOfLocations = Convert.ToInt32(fileReader.ReadLine());
                    parsedLocations = new Location[numberOfLocations];
                    ReadLocations(fileReader);
                    staticFileLocation = fileLocation;
                    fileReader.Close();
                    return parsedLocations;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error ocurred while executing the data import: {0}", e.Message);
                Console.WriteLine("Additional details: \n {0}", e);
                return new Location[0]; //Null array return indicates failure state.
            }
        } // Opens the file. Calls the other functions. Closes the file again.

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
        } // Handles the loop that reads from the file into an array of the Location data structure. Calls ReadYears to get the array of years (not individual years!)

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
        } // Handles the loop that reads from the file into an array of the Year data structure.  Calls ReadMonths to get the array of months.

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


        } // Handles the loop that reads from the file into an array of the Month data structure.  

        //These are in seperate functions because it makes it easier to side-by-side the data structure against the function that's reading into it.

        #endregion

        #region write

        public static void SaveFile(Location[] data)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(staticFileLocation, false)) // false means it's not appending to the file, it's overwriting it entirely. Even if the new data is shorter than the old data. 
                {
                    file.WriteLine(numberOfLocations);
                    WriteLocations(file, data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error ocurred while executing the data export: {0}", e.Message);
                Console.WriteLine("Additional details: \n {0}", e);
            }
        } // Opens the file. Calls the other functions. Closes the file again. 

        private static void WriteLocations(StreamWriter fileWriter, Location[] data)
        {                                                                                                       
            foreach (Location l in data)                                    
            {
                fileWriter.WriteLine(l.handleName);
                fileWriter.WriteLine(l.handleStreet);
                fileWriter.WriteLine(l.handleCounty);
                fileWriter.WriteLine(l.handlePostcode);
                fileWriter.WriteLine(l.handleLattitude);
                fileWriter.WriteLine(l.handleLongtitude);
                fileWriter.WriteLine(l.handleYears.Length);
                WriteYears(fileWriter, l.handleYears);
            }
        } // Handles the loop that writes from the Location data structure into the File. Calls WriteYears to handle the array of years.

        private static void WriteYears(StreamWriter f, Year[] data)
        {
            foreach (Year y in data)
            {
                f.WriteLine(y.handleDescription);
                f.WriteLine(y.handleDate);
                WriteMonths(f, y.handleMonths, y.handleDate);
            }
        } // Handles the loop that writes from the Years data structure into the File. Calls WriteMonths to handle the array of years.

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
        } // Handles the loop that writes from the Month data structure into the File.

        // These are in seperate functions because that makes it easier to see side-by-side the function and the data structure that it's reading from.

        #endregion
    }
    
}
