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
            InitializeComponent();
            locations = data;
            location = index;
            PopulateDataGridView(locations);
        }

        private void FormLocationDisplay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formLocationDisplay = new FormLocationDisplay(locations);
            formLocationDisplay.Location = this.Location;
            formLocationDisplay.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formLocationDisplay.Show();
        }

        private void buttonOpenLocation_Click(object sender, EventArgs e)
        {

        }

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
        }

        private void dataGridViewLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelLocations_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int year = dataGridViewYears.CurrentCellAddress.Y;
            var formMonthDisplay = new FormMonthsDisplay(locations, location, year);
            formMonthDisplay.Location = this.Location;
            formMonthDisplay.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formMonthDisplay.Show();
        }

        private void dataGridViewYears_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormYearDisplay_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddYear_Click(object sender, EventArgs e)
        {

            var formYearEdit = new FormYearEdit(locations, location);
            formYearEdit.Location = this.Location;
            formYearEdit.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formYearEdit.Show();
        }
    }
}
