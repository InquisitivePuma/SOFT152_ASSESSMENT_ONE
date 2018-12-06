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
            this.labelLocations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 23);
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
            // labelLocations
            // 
            this.labelLocations.AutoSize = true;
            this.labelLocations.Location = new System.Drawing.Point(188, 17);
            this.labelLocations.Name = "labelLocations";
            this.labelLocations.Size = new System.Drawing.Size(430, 13);
            this.labelLocations.TabIndex = 3;
            this.labelLocations.Text = "Select a location in the below table in order to view or edit additional data for" +
    " that location.";
            // 
            // FormLocationDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLocations);
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
        private System.Windows.Forms.Label labelLocations;
    }
}