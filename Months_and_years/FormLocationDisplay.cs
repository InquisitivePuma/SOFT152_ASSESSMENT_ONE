using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Months_and_years
{
    public partial class FormLocationDisplay : Form
    {
        static Location[] locations;

        public FormLocationDisplay(Location[] data)
        {
            locations = data;
            InitializeComponent();
            PopulateDataGridView(data);

        } // Puts the passed data into statics for this class, then calls other initialisation functions (InitialiseComponents and PopulateDatGridView in this case.)

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formFileSelect = new FormFileSelect();
            formFileSelect.Location = this.Location;
            formFileSelect.StartPosition = FormStartPosition.Manual;
            formFileSelect.Show();
            this.Hide();
        } // Creates a copy of the previous form (file select) and sets it to the same location as this form.

        private void buttonOpenLocation_Click(object sender, EventArgs e)
        {
            int location = dataGridViewLocations.CurrentCellAddress.Y;
            var formYearDisplay = new FormYearDisplay(locations, location);
            formYearDisplay.Location = this.Location;
            formYearDisplay.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formYearDisplay.Show();
        } // Creates a new YearDusplay form, passes it the index of the currently selected location with the main data structure, then sets it to the current position of the form.


        private void PopulateDataGridView(Location[] data)
        {
            this.Controls.Add(dataGridViewLocations);
            String[] row = new string[2];

            dataGridViewLocations.ColumnCount = 2;
            dataGridViewLocations.RowHeadersVisible = true;
            dataGridViewLocations.Columns[0].Name = "Location Name";
            dataGridViewLocations.Columns[1].Name = "Location Postcode";
            dataGridViewLocations.Columns[0].Width = (dataGridViewLocations.Width/2) - 15;
            dataGridViewLocations.Columns[1].Width = (dataGridViewLocations.Width / 2) - 15;

            dataGridViewLocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLocations.MultiSelect = false;
            
            foreach (Location l in data)
            {
                row[0] = l.handleName;
                row[1] = l.handlePostcode;
                dataGridViewLocations.Rows.Add(row);

            }

            dataGridViewLocations.Columns[0].DisplayIndex = 0;
            dataGridViewLocations.Columns[1].DisplayIndex = 1;
        } // Iterates through the relevant data (The locations' names and postcodes) and copies it into row arrays which are then added to the data grid.

    }
}
