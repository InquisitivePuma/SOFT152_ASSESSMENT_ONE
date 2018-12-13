namespace Months_and_years
{
    partial class FormYearDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBackToLocations = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewYears = new System.Windows.Forms.DataGridView();
            this.buttonAddYear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonOpenYearGraphs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYears)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToLocations
            // 
            this.buttonBackToLocations.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToLocations.Name = "buttonBackToLocations";
            this.buttonBackToLocations.Size = new System.Drawing.Size(44, 23);
            this.buttonBackToLocations.TabIndex = 0;
            this.buttonBackToLocations.Text = "Back";
            this.buttonBackToLocations.UseVisualStyleBackColor = true;
            this.buttonBackToLocations.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(770, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Click here to display additional data for the selected year.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // dataGridViewYears
            // 
            this.dataGridViewYears.AllowUserToAddRows = false;
            this.dataGridViewYears.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYears.Location = new System.Drawing.Point(13, 41);
            this.dataGridViewYears.Name = "dataGridViewYears";
            this.dataGridViewYears.Size = new System.Drawing.Size(769, 317);
            this.dataGridViewYears.TabIndex = 5;
            // 
            // buttonAddYear
            // 
            this.buttonAddYear.Location = new System.Drawing.Point(12, 364);
            this.buttonAddYear.Name = "buttonAddYear";
            this.buttonAddYear.Size = new System.Drawing.Size(770, 30);
            this.buttonAddYear.TabIndex = 6;
            this.buttonAddYear.Text = "Click here to add a new year.";
            this.buttonAddYear.UseVisualStyleBackColor = true;
            this.buttonAddYear.Click += new System.EventHandler(this.buttonAddYear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(707, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(529, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(172, 20);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.Text = "Enter Year";
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            // 
            // buttonOpenYearGraphs
            // 
            this.buttonOpenYearGraphs.Location = new System.Drawing.Point(62, 12);
            this.buttonOpenYearGraphs.Name = "buttonOpenYearGraphs";
            this.buttonOpenYearGraphs.Size = new System.Drawing.Size(461, 23);
            this.buttonOpenYearGraphs.TabIndex = 9;
            this.buttonOpenYearGraphs.Text = "Cleck here for awesome bonus graphs which don\'t exist yet.";
            this.buttonOpenYearGraphs.UseVisualStyleBackColor = true;
            // 
            // FormYearDisplay
            // 
            this.ClientSize = new System.Drawing.Size(794, 442);
            this.Controls.Add(this.buttonOpenYearGraphs);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonAddYear);
            this.Controls.Add(this.dataGridViewYears);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonBackToLocations);
            this.Name = "FormYearDisplay";
            this.Text = "Weather Data Management Program";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToLocations;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewYears;
        private System.Windows.Forms.Button buttonAddYear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonOpenYearGraphs;
    }
}
