using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Months_and_years
{
    public partial class FormYearDisplay : Form
    {
        static Location[] locations;
        static int location;

        public FormYearDisplay(Location[] data, int index)
        {
            locations = data;
            location = index;
            InitializeComponent();
            PopulateDataGridView(locations);
        } // Puts the passed data into statics for this class, then calls other initialisation functions (PopulateDataGridView and InitialiseComponents, in this case.)

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formLocationDisplay = new FormLocationDisplay(locations);
            formLocationDisplay.Location = this.Location;
            formLocationDisplay.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formLocationDisplay.Show();
        } // Creates a copy of the previous form (location display) and sets it to the same location as this form, with the same information as this form has.

        private void PopulateDataGridView(Location[] data)
        {
            this.Controls.Add(dataGridViewYears);
            String[] row = new string[2];

            dataGridViewYears.ColumnCount = 2;
            dataGridViewYears.RowHeadersVisible = true;
            dataGridViewYears.Columns[0].Name = "Year";
            dataGridViewYears.Columns[1].Name = "Description";
            dataGridViewYears.Columns[0].Width = (dataGridViewYears.Width / 4) - 15;
            dataGridViewYears.Columns[1].Width = ((dataGridViewYears.Width / 4 ) * 3) - 15;

            dataGridViewYears.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewYears.MultiSelect = false;

            foreach (Year y in data[location].handleYears)
            {
                row[0] = Convert.ToString(y.handleDate);
                row[1] = y.handleDescription;

                dataGridViewYears.Rows.Add(row);
            }

            dataGridViewYears.Columns[0].DisplayIndex = 0;
            dataGridViewYears.Columns[1].DisplayIndex = 1;
        } // Iterates through the relevant data (The years' dates and descriptions) and copies it into row arrays which are then added to the data grid.

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            int year = dataGridViewYears.CurrentCellAddress.Y;
            var formMonthDisplay = new FormMonthsDisplay(locations, location, year);
            formMonthDisplay.Location = this.Location;
            formMonthDisplay.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formMonthDisplay.Show();
        } // Creates a new MonthDisplay form, passes it the index of the current selected location, month and year, the main data structure, and sets it to the current position of the form.

        private void buttonAddYear_Click(object sender, EventArgs e)
        {

            var formYearEdit = new FormYearEdit(locations, location);
            formYearEdit.Location = this.Location;
            formYearEdit.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formYearEdit.Show();
        } // Creates a new YearEdit form, passes it the index of the currently selected location and year with the main data structure, and sets it to the current position of the form. 

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string term = textBoxSearch.Text;
            int searchResult = Utils.SearchDataGridView(term, dataGridViewYears);

            if (searchResult == -1)
            {
                textBoxSearch.Text = "Location not found";
            }
            else
            {
                dataGridViewYears.Rows[searchResult].Selected = true;
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate
            {
                textBoxSearch.SelectAll();
            });
        }
    }
}
