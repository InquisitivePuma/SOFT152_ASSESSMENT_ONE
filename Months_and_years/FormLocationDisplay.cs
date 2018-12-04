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
            InitializeComponent();
            PopulateDataGridView(data);
            locations = data;
        }

        private void FormLocationDisplay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formFileSelect = new FormFileSelect();
            formFileSelect.Location = this.Location;
            formFileSelect.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formFileSelect.Show();
        }

        private void buttonOpenLocation_Click(object sender, EventArgs e)
        {
            int location = dataGridViewLocations.CurrentCellAddress.Y;
            var formYearDisplay = new FormYearDisplay(locations, location);
            formYearDisplay.Location = this.Location;
            formYearDisplay.StartPosition = FormStartPosition.Manual;
            this.Hide();
            formYearDisplay.Show();
        }
        
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
        }

        private void dataGridViewLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelLocations_Click(object sender, EventArgs e)
        {

        }
    }
}
