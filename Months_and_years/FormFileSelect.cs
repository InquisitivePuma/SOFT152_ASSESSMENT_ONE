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
    public partial class FormFileSelect : Form
    {
        public FormFileSelect()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileOpenBox.Text = openFileDialog.FileName;
                Location[] data = Filereader.readFile(openFileDialog.FileName);
                var formLocationDisplay = new FormLocationDisplay(data);
                formLocationDisplay.Location = this.Location;
                formLocationDisplay.StartPosition = FormStartPosition.Manual;
                this.Hide();
                formLocationDisplay.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileOpenBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
