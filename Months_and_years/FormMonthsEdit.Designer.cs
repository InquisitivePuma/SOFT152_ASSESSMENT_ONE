namespace Months_and_years
{
    partial class FormMonthsEdit
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
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelMaxTehmp = new System.Windows.Forms.Label();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.labelRainfall = new System.Windows.Forms.Label();
            this.labelAirFrost = new System.Windows.Forms.Label();
            this.labelSunshine = new System.Windows.Forms.Label();
            this.textBoxMaxTemp = new System.Windows.Forms.TextBox();
            this.textBoxSunshine = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.textBoxRainfall = new System.Windows.Forms.TextBox();
            this.textBoxAirFrost = new System.Windows.Forms.TextBox();
            this.textBoxMinTemp = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBackMonthEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(12, 71);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(66, 13);
            this.labelIndex.TabIndex = 0;
            this.labelIndex.Text = "Month Index";
            // 
            // labelMaxTehmp
            // 
            this.labelMaxTehmp.AutoSize = true;
            this.labelMaxTehmp.Location = new System.Drawing.Point(12, 127);
            this.labelMaxTehmp.Name = "labelMaxTehmp";
            this.labelMaxTehmp.Size = new System.Drawing.Size(114, 13);
            this.labelMaxTehmp.TabIndex = 1;
            this.labelMaxTehmp.Text = "Maximum Temperature";
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.Location = new System.Drawing.Point(12, 185);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(111, 13);
            this.labelMinTemp.TabIndex = 2;
            this.labelMinTemp.Text = "Minimum Temperature";
            // 
            // labelRainfall
            // 
            this.labelRainfall.AutoSize = true;
            this.labelRainfall.Location = new System.Drawing.Point(12, 297);
            this.labelRainfall.Name = "labelRainfall";
            this.labelRainfall.Size = new System.Drawing.Size(105, 13);
            this.labelRainfall.TabIndex = 3;
            this.labelRainfall.Text = "Millimeters of Rainfall";
            // 
            // labelAirFrost
            // 
            this.labelAirFrost.AutoSize = true;
            this.labelAirFrost.Location = new System.Drawing.Point(12, 241);
            this.labelAirFrost.Name = "labelAirFrost";
            this.labelAirFrost.Size = new System.Drawing.Size(84, 13);
            this.labelAirFrost.TabIndex = 4;
            this.labelAirFrost.Text = "Days of Air Frost";
            // 
            // labelSunshine
            // 
            this.labelSunshine.AutoSize = true;
            this.labelSunshine.Location = new System.Drawing.Point(12, 354);
            this.labelSunshine.Name = "labelSunshine";
            this.labelSunshine.Size = new System.Drawing.Size(94, 13);
            this.labelSunshine.TabIndex = 5;
            this.labelSunshine.Text = "Hours of Sunshine";
            // 
            // textBoxMaxTemp
            // 
            this.textBoxMaxTemp.Location = new System.Drawing.Point(129, 124);
            this.textBoxMaxTemp.Name = "textBoxMaxTemp";
            this.textBoxMaxTemp.Size = new System.Drawing.Size(659, 20);
            this.textBoxMaxTemp.TabIndex = 7;
            // 
            // textBoxSunshine
            // 
            this.textBoxSunshine.Location = new System.Drawing.Point(129, 351);
            this.textBoxSunshine.Name = "textBoxSunshine";
            this.textBoxSunshine.Size = new System.Drawing.Size(659, 20);
            this.textBoxSunshine.TabIndex = 8;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Enabled = false;
            this.textBoxIndex.Location = new System.Drawing.Point(129, 69);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(659, 20);
            this.textBoxIndex.TabIndex = 9;
            // 
            // textBoxRainfall
            // 
            this.textBoxRainfall.Location = new System.Drawing.Point(129, 294);
            this.textBoxRainfall.Name = "textBoxRainfall";
            this.textBoxRainfall.Size = new System.Drawing.Size(659, 20);
            this.textBoxRainfall.TabIndex = 10;
            // 
            // textBoxAirFrost
            // 
            this.textBoxAirFrost.Location = new System.Drawing.Point(129, 238);
            this.textBoxAirFrost.Name = "textBoxAirFrost";
            this.textBoxAirFrost.Size = new System.Drawing.Size(659, 20);
            this.textBoxAirFrost.TabIndex = 11;
            // 
            // textBoxMinTemp
            // 
            this.textBoxMinTemp.Location = new System.Drawing.Point(129, 182);
            this.textBoxMinTemp.Name = "textBoxMinTemp";
            this.textBoxMinTemp.Size = new System.Drawing.Size(659, 20);
            this.textBoxMinTemp.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 413);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(776, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Click here to save any edits to this month\'s data.";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBackMonthEdit
            // 
            this.buttonBackMonthEdit.Location = new System.Drawing.Point(12, 15);
            this.buttonBackMonthEdit.Name = "buttonBackMonthEdit";
            this.buttonBackMonthEdit.Size = new System.Drawing.Size(776, 23);
            this.buttonBackMonthEdit.TabIndex = 14;
            this.buttonBackMonthEdit.Text = "Back";
            this.buttonBackMonthEdit.UseVisualStyleBackColor = true;
            this.buttonBackMonthEdit.Click += new System.EventHandler(this.buttonBackMonthEdit_Click);
            // 
            // FormMonthsEdit
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackMonthEdit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxMinTemp);
            this.Controls.Add(this.textBoxAirFrost);
            this.Controls.Add(this.textBoxRainfall);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.textBoxSunshine);
            this.Controls.Add(this.textBoxMaxTemp);
            this.Controls.Add(this.labelSunshine);
            this.Controls.Add(this.labelAirFrost);
            this.Controls.Add(this.labelRainfall);
            this.Controls.Add(this.labelMinTemp);
            this.Controls.Add(this.labelMaxTehmp);
            this.Controls.Add(this.labelIndex);
            this.Name = "FormMonthsEdit";
            this.Load += new System.EventHandler(this.FormMonthsEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelMaxTehmp;
        private System.Windows.Forms.Label labelMinTemp;
        private System.Windows.Forms.Label labelRainfall;
        private System.Windows.Forms.Label labelAirFrost;
        private System.Windows.Forms.Label labelSunshine;
        private System.Windows.Forms.TextBox textBoxMaxTemp;
        private System.Windows.Forms.TextBox textBoxSunshine;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.TextBox textBoxRainfall;
        private System.Windows.Forms.TextBox textBoxAirFrost;
        private System.Windows.Forms.TextBox textBoxMinTemp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBackMonthEdit;
    }
}
