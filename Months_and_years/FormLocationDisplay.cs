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
        public FormLocationDisplay()
        {
            InitializeComponent();
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

        }
    }
}
