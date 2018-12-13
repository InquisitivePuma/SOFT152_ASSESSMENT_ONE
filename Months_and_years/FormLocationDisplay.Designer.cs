namespace Months_and_years
{
    partial class FormLocationDisplay
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOpenLocation = new System.Windows.Forms.Button();
            this.dataGridViewLocations = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonOpenLocationGraphs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(64, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOpenLocation
            // 
            this.buttonOpenLocation.Location = new System.Drawing.Point(12, 405);
            this.buttonOpenLocation.Name = "buttonOpenLocation";
            this.buttonOpenLocation.Size = new System.Drawing.Size(776, 33);
            this.buttonOpenLocation.TabIndex = 1;
            this.buttonOpenLocation.Text = "Click here to display additional data for the selected location.";
            this.buttonOpenLocation.UseVisualStyleBackColor = true;
            this.buttonOpenLocation.Click += new System.EventHandler(this.buttonOpenLocation_Click);
            // 
            // dataGridViewLocations
            // 
            this.dataGridViewLocations.AllowUserToAddRows = false;
            this.dataGridViewLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocations.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewLocations.Name = "dataGridViewLocations";
            this.dataGridViewLocations.Size = new System.Drawing.Size(776, 342);
            this.dataGridViewLocations.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(535, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(172, 20);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.Text = "Enter Location Name";
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(713, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonOpenLocationGraphs
            // 
            this.buttonOpenLocationGraphs.Location = new System.Drawing.Point(82, 12);
            this.buttonOpenLocationGraphs.Name = "buttonOpenLocationGraphs";
            this.buttonOpenLocationGraphs.Size = new System.Drawing.Size(447, 23);
            this.buttonOpenLocationGraphs.TabIndex = 5;
            this.buttonOpenLocationGraphs.Text = "Cleck here for awesome bonus graphs which don\'t exist yet.";
            this.buttonOpenLocationGraphs.UseVisualStyleBackColor = true;
            // 
            // FormLocationDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenLocationGraphs);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewLocations);
            this.Controls.Add(this.buttonOpenLocation);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormLocationDisplay";
            this.Text = "Weather Data Management Program";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOpenLocation;
        private System.Windows.Forms.DataGridView dataGridViewLocations;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonOpenLocationGraphs;
    }
}