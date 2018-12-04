using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Months_and_years
{
    public partial class FormYearEdit : Form
    {
        static Location[] locations;
        static int location;
        public FormYearEdit(Location[] data, int index)
        {
            InitializeComponent();
            locations = data;
            location = index;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonBackToYears_Click(object sender, EventArgs e)
        {
            var formYearDisplay = new FormYearDisplay(locations, location);
            formYearDisplay.Location = this.Location;
            formYearDisplay.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formYearDisplay.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Year savedYear = new Year();
                savedYear.handleDescription = textBoxDescription.Text;
                savedYear.handleDate = int.Parse(textBoxDate.Text);

                Month[] savedMonths = new Month[12];

                #region declaring months

                Month january = new Month();
                january.handleMaximumTemperature = Convert.ToSingle(textBoxJMX.Text);
                january.handleMinimumTemperature = Convert.ToSingle(textBoxJMI.Text);
                january.handleDaysOfAirFrost = Convert.ToSingle(textBoxJAF.Text);
                january.handleMillimitersOfRainfall = Convert.ToSingle(textBoxJRF.Text);
                january.handleHoursOfSunshine = Convert.ToSingle(textBoxJS.Text);
                savedMonths[0] = january;

                Month february = new Month();
                february.handleMaximumTemperature = Convert.ToSingle(textBoxFMX.Text);
                february.handleMinimumTemperature = Convert.ToSingle(textBoxFMI.Text);
                february.handleDaysOfAirFrost = Convert.ToSingle(textBoxFAF.Text);
                february.handleMillimitersOfRainfall = Convert.ToSingle(textBoxFRF.Text);
                february.handleHoursOfSunshine = Convert.ToSingle(textBoxFS.Text);
                savedMonths[1] = february;

                Month march = new Month();
                march.handleMaximumTemperature = Convert.ToSingle(textBoxMMX.Text);
                march.handleMinimumTemperature = Convert.ToSingle(textBoxMMI.Text);
                march.handleDaysOfAirFrost = Convert.ToSingle(textBoxMAF.Text);
                march.handleMillimitersOfRainfall = Convert.ToSingle(textBoxMRF.Text);
                march.handleHoursOfSunshine = Convert.ToSingle(textBoxMS.Text);
                savedMonths[2] = march;

                Month april = new Month();
                april.handleMaximumTemperature = Convert.ToSingle(textBoxAMX.Text);
                april.handleMinimumTemperature = Convert.ToSingle(textBoxAMI.Text);
                april.handleDaysOfAirFrost = Convert.ToSingle(textBoxAAF.Text);
                april.handleMillimitersOfRainfall = Convert.ToSingle(textBoxARF.Text);
                april.handleHoursOfSunshine = Convert.ToSingle(textBoxAS.Text);
                savedMonths[3] = april;

                Month may = new Month();
                may.handleMaximumTemperature = Convert.ToSingle(textBoxMAMX.Text);
                may.handleMinimumTemperature = Convert.ToSingle(textBoxMAMI.Text);
                may.handleDaysOfAirFrost = Convert.ToSingle(textBoxMAAF.Text);
                may.handleMillimitersOfRainfall = Convert.ToSingle(textBoxMARF.Text);
                may.handleHoursOfSunshine = Convert.ToSingle(textBoxMAS.Text);
                savedMonths[4] = may;

                Month june = new Month();
                june.handleMaximumTemperature = Convert.ToSingle(textBoxJUNMX.Text);
                june.handleMinimumTemperature = Convert.ToSingle(textBoxJUNMI.Text);
                june.handleDaysOfAirFrost = Convert.ToSingle(textBoxJUNAF.Text);
                june.handleMillimitersOfRainfall = Convert.ToSingle(textBoxJUNRF.Text);
                june.handleHoursOfSunshine = Convert.ToSingle(textBoxJUNS.Text);
                savedMonths[5] = june;

                Month july = new Month();
                july.handleMaximumTemperature = Convert.ToSingle(textBoxJULMX.Text);
                july.handleMinimumTemperature = Convert.ToSingle(textBoxJULMI.Text);
                july.handleDaysOfAirFrost = Convert.ToSingle(textBoxJULAF.Text);
                july.handleMillimitersOfRainfall = Convert.ToSingle(textBoxJULRF.Text);
                july.handleHoursOfSunshine = Convert.ToSingle(textBoxJULS.Text);
                savedMonths[6] = july;

                Month august = new Month();
                august.handleMaximumTemperature = Convert.ToSingle(textBoxAUMX.Text);
                august.handleMinimumTemperature = Convert.ToSingle(textBoxAUMI.Text);
                august.handleDaysOfAirFrost = Convert.ToSingle(textBoxAUAF.Text);
                august.handleMillimitersOfRainfall = Convert.ToSingle(textBoxAURF.Text);
                august.handleHoursOfSunshine = Convert.ToSingle(textBoxAUS.Text);
                savedMonths[7] = august;

                Month september = new Month();
                september.handleMaximumTemperature = Convert.ToSingle(textBoxSMX.Text);
                september.handleMinimumTemperature = Convert.ToSingle(textBoxSMI.Text);
                september.handleDaysOfAirFrost = Convert.ToSingle(textBoxSAF.Text);
                september.handleMillimitersOfRainfall = Convert.ToSingle(textBoxSRF.Text);
                september.handleHoursOfSunshine = Convert.ToSingle(textBoxSS.Text);
                savedMonths[8] = september;

                Month october = new Month();
                october.handleMaximumTemperature = Convert.ToSingle(textBoxOMI.Text);
                october.handleMinimumTemperature = Convert.ToSingle(textBoxOMI.Text);
                october.handleDaysOfAirFrost = Convert.ToSingle(textBoxOAF.Text);
                october.handleMillimitersOfRainfall = Convert.ToSingle(textBoxORF.Text);
                october.handleHoursOfSunshine = Convert.ToSingle(textBoxOS.Text);
                savedMonths[9] = october;

                Month november = new Month();
                november.handleMaximumTemperature = Convert.ToSingle(textBoxNMX.Text);
                november.handleMinimumTemperature = Convert.ToSingle(textBoxNMI.Text);
                november.handleDaysOfAirFrost = Convert.ToSingle(textBoxNAF.Text);
                november.handleMillimitersOfRainfall = Convert.ToSingle(textBoxNRF.Text);
                november.handleHoursOfSunshine = Convert.ToSingle(textBoxNS.Text);
                savedMonths[10] = november;

                Month december = new Month();
                december.handleMaximumTemperature = Convert.ToSingle(textBoxDMX.Text);
                december.handleMinimumTemperature = Convert.ToSingle(textBoxDMI.Text);
                december.handleDaysOfAirFrost = Convert.ToSingle(textBoxDAF.Text);
                december.handleMillimitersOfRainfall = Convert.ToSingle(textBoxDRF.Text);
                december.handleHoursOfSunshine = Convert.ToSingle(textBoxDS.Text);
                savedMonths[11] = december;

                #endregion

                savedYear.handleMonths = savedMonths;

                locations[location].AddYear(savedYear);
                Filehandler.SaveFile(locations);
            }
            catch (Exception badInputError)
            {
                Console.WriteLine("An error ocurred while rading the form: {0}", badInputError.Message);
                Console.WriteLine("Additional details: \n {0}", badInputError);
                Console.WriteLine("It's probably because you entered something wrong, user.");
            }

        }
    }
}
