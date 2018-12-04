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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewYears = new System.Windows.Forms.DataGridView();
            this.buttonAddYear = new System.Windows.Forms.Button();
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
            this.buttonBackToLocations.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(770, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Click here to display additional data for the selected year.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a year in the below table in order to view or edit additional data.";
            // 
            // dataGridViewYears
            // 
            this.dataGridViewYears.AllowUserToAddRows = false;
            this.dataGridViewYears.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYears.Location = new System.Drawing.Point(13, 41);
            this.dataGridViewYears.Name = "dataGridViewYears";
            this.dataGridViewYears.Size = new System.Drawing.Size(769, 317);
            this.dataGridViewYears.TabIndex = 5;
            this.dataGridViewYears.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewYears_CellContentClick);
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
            // FormYearDisplay
            // 
            this.ClientSize = new System.Drawing.Size(794, 442);
            this.Controls.Add(this.buttonAddYear);
            this.Controls.Add(this.dataGridViewYears);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonBackToLocations);
            this.Name = "FormYearDisplay";
            this.Text = "Weather Data Management Program";
            this.Load += new System.EventHandler(this.FormYearDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDescription;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonBackToLocations;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewYears;
        private System.Windows.Forms.Button buttonAddYear;
    }
}
