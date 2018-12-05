using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Months_and_years
{
    public partial class FormMonthsEdit : Form
    {
        static Location[] locations;
        static int location;
        static int year;
        static int month;
        public FormMonthsEdit(Location[] data, int firstIndex, int previousIndex, int index)
        {
            locations = data;
            month = index;
            location = firstIndex;
            year = previousIndex;
            InitializeComponent();
        } // Puts the passed data into statics for this class, then calls other initialisation functions (InitialiseComponents, in this case.)

        private void FormMonthsEdit_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Debug: Location - {0}, Year - {1}, Month - {2}", location, year, month);
            Month thisMonth = locations[location].GetYear(year).GetMonth(month);
            textBoxIndex.Text = Convert.ToString(thisMonth.handleIdentity);
            textBoxMaxTemp.Text = Convert.ToString(thisMonth.handleMaximumTemperature);
            textBoxMinTemp.Text = Convert.ToString(thisMonth.handleMinimumTemperature);
            textBoxAirFrost.Text = Convert.ToString(thisMonth.handleDaysOfAirFrost);
            textBoxRainfall.Text = Convert.ToString(thisMonth.handleMillimitersOfRainfall);
            textBoxSunshine.Text = Convert.ToString(thisMonth.handleHoursOfSunshine);
        } //   ***  THIS LOAD FUNCTION HAS PURPOSE.  ***   It sets the data in the textboxes to the correct data for the currently slected month.

        private void buttonBackMonthEdit_Click(object sender, EventArgs e) 
        {
            var formMonthDisplay = new FormMonthsDisplay(locations, location, year);
            formMonthDisplay.Location = this.Location; 
            formMonthDisplay.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formMonthDisplay.Show();
        } // Creates a copy of the previous form(month display) and sets it to the same location as this form, with the same information as this form has.

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Month saveMonth = locations[location].GetYear(year).GetMonth(month);
            saveMonth.handleIdentity = Convert.ToInt32(textBoxIndex.Text);
            saveMonth.handleMaximumTemperature = Convert.ToSingle(textBoxMaxTemp.Text);
            saveMonth.handleMinimumTemperature = Convert.ToSingle(textBoxMinTemp.Text);
            saveMonth.handleDaysOfAirFrost = Convert.ToSingle(textBoxAirFrost.Text);
            saveMonth.handleMillimitersOfRainfall = Convert.ToSingle(textBoxRainfall.Text);
            saveMonth.handleHoursOfSunshine = Convert.ToSingle(textBoxSunshine.Text);            

            locations[location].handleYears[year].handleMonths[month] = saveMonth;
            Filehandler.SaveFile(locations);
        } // Sets the attributes of the currently selected month in the man data structure to be equal to the values currently in the form, then calls the SaveFile function.
    }
}
