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
        static int selection;
        public FormYearDisplay(Location[] data, int index)
        {
            InitializeComponent();
            locations = data;
            selection = index;
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
            this.Controls.Add(dataGridView2);
            String[] row = new string[2];

            dataGridView2.ColumnCount = 2;
            dataGridView2.RowHeadersVisible = true;
            dataGridView2.Columns[0].Name = "Year";
            dataGridView2.Columns[1].Name = "Description";
            dataGridView2.Columns[0].Width = (dataGridView2.Width / 4) - 15;
            dataGridView2.Columns[1].Width = ((dataGridView2.Width / 4 ) * 3) - 15;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;

            Console.WriteLine("Debug: dataGrid has been setup.");

            foreach (Year y in data[selection].handleYears)
            {
                row[0] = Convert.ToString(y.handleDate);
                row[1] = y.handleDescription;

                dataGridView2.Rows.Add(row);
                Console.WriteLine("Debug: A year has been added to the dataGrid");

            }

            dataGridView2.Columns[0].DisplayIndex = 0;
            dataGridView2.Columns[1].DisplayIndex = 1;
        }

        private void dataGridViewLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelLocations_Click(object sender, EventArgs e)
        {

        }

    }
}
