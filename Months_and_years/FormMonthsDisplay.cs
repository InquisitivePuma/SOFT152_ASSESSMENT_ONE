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
            ShowYearDescription();
        }

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

            foreach (Month m in months)                                                  // This is getting messy, I know, but it doesn't go any deeper 
            {                                                                            // and we have to hold onto all the data in order to reconstruct the forms as we go back up                                    
                row[0] = Convert.ToString(m.handleIdentity);                             // or user edits won't show until the program is reloaded.
                row[1] = m.handleName;

                dataGridViewMonths.Rows.Add(row);

            }

            dataGridViewMonths.Columns[0].DisplayIndex = 0;
            dataGridViewMonths.Columns[1].DisplayIndex = 1;
        }

        private void ShowYearDescription()
        {
            textBoxDescription.Text = locations[location].handleYears[year].handleDescription;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formYearDisplay = new FormYearDisplay(locations, location);
            formYearDisplay.Location = this.Location;
            formYearDisplay.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formYearDisplay.Show();
        }



        private void buttonEditMonth_Click(object sender, EventArgs e)
        {
            int month = dataGridViewMonths.CurrentCellAddress.Y;
            var formMonthEdit = new FormMonthsEdit(locations, location, year, month);
            formMonthEdit.Location = this.Location;
            formMonthEdit.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formMonthEdit.Show();
        }


        private void buttonEditDescription_Click(object sender, EventArgs e)
        {
            locations[location].handleYears[year].handleDescription = textBoxDescription.Text;
        }

        private void FormMonthsDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
