using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Months_and_years
{
    public partial class FormMonthsDisplay : Form
    {
        static Location[] locations;
        static int location;
        static int year;
        public FormMonthsDisplay(Location[] data, int previousIndex, int index)
        {
            InitializeComponent();
            locations = data;
            location = previousIndex;
            year = index;
            PopulateDataGridView();
        } // Puts the passed data into statics for this class, then calls other initialisation functions (InitialiseComponents and PopulateDatGridView in this case.)

        private void PopulateDataGridView()
        {
            this.Controls.Add(dataGridViewMonths);
            this.Controls.Add(dataGridViewMonths);
            String[] row = new string[2];

            dataGridViewMonths.ColumnCount = 2;
            dataGridViewMonths.RowHeadersVisible = true;
            dataGridViewMonths.Columns[0].Name = "Identity";
            dataGridViewMonths.Columns[1].Name = "Name";
            dataGridViewMonths.Columns[0].Width = (dataGridViewMonths.Width / 4) - 15;
            dataGridViewMonths.Columns[1].Width = ((dataGridViewMonths.Width / 4) * 3) - 15;

            dataGridViewMonths.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMonths.MultiSelect = false;

            Year thisYear = locations[location].GetYear(year);
            Month[] months = thisYear.handleMonths;

            foreach (Month m in months)                                                  
            {                                                                                                           
                row[0] = Convert.ToString(m.handleIdentity);                             
                row[1] = m.handleName;

                dataGridViewMonths.Rows.Add(row);

            }

            dataGridViewMonths.Columns[0].DisplayIndex = 0;
            dataGridViewMonths.Columns[1].DisplayIndex = 1;
        } // Iterates through the relevant data (The months' identities and names) and copies it into row arrays which are then added to the data grid.

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formYearDisplay = new FormYearDisplay(locations, location);
            formYearDisplay.Location = this.Location;
            formYearDisplay.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formYearDisplay.Show();
        } // Creates a copy of the previous form (year display) and sets it to the same location as this form, with the same information as this form has.
               
        private void buttonEditMonth_Click(object sender, EventArgs e)
        {
            int month = dataGridViewMonths.CurrentCellAddress.Y;
            var formMonthEdit = new FormMonthsEdit(locations, location, year, month);
            formMonthEdit.Location = this.Location;
            formMonthEdit.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formMonthEdit.Show();
        }// Creates a new MonthEdit form, passes it the index of the currently selected location, year and month with the main data structure, then sets it to the current position of the form. 
        
        private void buttonEditDescription_Click(object sender, EventArgs e)
        {
            locations[location].handleYears[year].handleDescription = textBoxDescription.Text;
        } // Sets the description of the currently selected year to the contents of the textbox.

        private void FormMonthsDisplay_Load(object sender, EventArgs e)
        {
            textBoxDescription.Text = locations[location].handleYears[year].handleDescription;
        } //   ***  THIS LOAD FUNCTION HAS PURPOSE.  ***   It sets the data in the textboxe to the description for the currently selected year.
    }
}
