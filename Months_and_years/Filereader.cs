using System;
using System.IO;

namespace Months_and_years
{
    class Filereader
    {

        public static Location[] readFile(string fileLocation)
        {
            try
            {
                using (StreamReader data = new StreamReader(fileLocation))
                {
                    string locationName;
                    string locationStreet;
                    string locationCounty;
                    string locationPostCode;
                    float locationLatitude;
                    float locationLongtitude;
                    string yearDescription;
                    int yearId;
                    int monthId;
                    float monthMaxTemp;
                    float monthMinTemp;
                    int monthDaysOfAirFrost;
                    float monthMilsOfRainfall;
                    float monthHoursOfSunshine;
                    int numberOfLocations;
                    int numberOfYears;
                    Location thisLocation;
                    Year thisYear;
                    Month thisMonth;
                    Location[] parsedLocations;
                    Year[] parsedYears;
                    Month[] parsedMonths;

                    numberOfLocations = Convert.ToInt32(data.ReadLine());
                    parsedLocations = new Location[numberOfLocations];
                    

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

                        for (int j = 0; j < numberOfYears; j++) // for each year in this location
                        {
                            parsedMonths = new Month[12]; // each iteration gets a fresh array
                            yearDescription = data.ReadLine();
                            yearId = Convert.ToInt32(data.ReadLine());

                            for(int k = 0; k < 12; k++) // for each month in this year
                            {
                                monthId = Convert.ToInt32(data.ReadLine());
                                monthMaxTemp = Convert.ToSingle(data.ReadLine());
                                monthMinTemp = Convert.ToSingle(data.ReadLine());
                                monthDaysOfAirFrost = Convert.ToInt32(data.ReadLine());
                                monthMilsOfRainfall = Convert.ToSingle(data.ReadLine());
                                monthHoursOfSunshine = Convert.ToSingle(data.ReadLine());
                                thisMonth = new Month(monthId, monthMaxTemp, monthMinTemp, monthDaysOfAirFrost, monthMilsOfRainfall, monthHoursOfSunshine);
                                parsedMonths[k] = thisMonth;
                            }

                            thisYear = new Year(yearId, yearDescription, parsedMonths);
                            parsedYears[j] = thisYear;

                        }

                        thisLocation = new Location(locationName, locationStreet, locationCounty, locationPostCode, locationLatitude, locationLongtitude, parsedYears);
                        parsedLocations[i] = thisLocation;
                    }

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
    }
}

/*Note that this file has not been refactored to be more modular as, 
 * after some consideration, I feel that it is more readable and
 * easier to follow in a linear form. 
 * As well as this, the code her is unlikely to be reused in any smaller
 * section than the whole, given how specialised it is to this particular 
 * dataset. 
 */