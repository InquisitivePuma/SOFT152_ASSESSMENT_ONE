namespace Months_and_years
{
    partial class FormMonthsDisplay
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
            this.buttonEditDescription = new System.Windows.Forms.Button();
            this.buttonBackMonths = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dataGridViewMonths = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditDescription
            // 
            this.buttonEditDescription.Location = new System.Drawing.Point(668, 46);
            this.buttonEditDescription.Name = "buttonEditDescription";
            this.buttonEditDescription.Size = new System.Drawing.Size(120, 23);
            this.buttonEditDescription.TabIndex = 0;
            this.buttonEditDescription.Text = "Edit Description";
            this.buttonEditDescription.UseVisualStyleBackColor = true;
            this.buttonEditDescription.Click += new System.EventHandler(this.buttonEditDescription_Click);
            // 
            // buttonBackMonths
            // 
            this.buttonBackMonths.Location = new System.Drawing.Point(12, 12);
            this.buttonBackMonths.Name = "buttonBackMonths";
            this.buttonBackMonths.Size = new System.Drawing.Size(75, 23);
            this.buttonBackMonths.TabIndex = 1;
            this.buttonBackMonths.Text = "Back";
            this.buttonBackMonths.UseVisualStyleBackColor = true;
            this.buttonBackMonths.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(776, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Click here to view or edit the selected month.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonEditMonth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a month in the below table in order to view or edit additional data.";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 49);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(650, 20);
            this.textBoxDescription.TabIndex = 4;
            // 
            // dataGridViewMonths
            // 
            this.dataGridViewMonths.AllowUserToAddRows = false;
            this.dataGridViewMonths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonths.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewMonths.Name = "dataGridViewMonths";
            this.dataGridViewMonths.Size = new System.Drawing.Size(776, 318);
            this.dataGridViewMonths.TabIndex = 5;
            // 
            // FormMonthsDisplay
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMonths);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonBackMonths);
            this.Controls.Add(this.buttonEditDescription);
            this.Name = "FormMonthsDisplay";
            this.Load += new System.EventHandler(this.FormMonthsDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditDescription;
        private System.Windows.Forms.Button buttonBackMonths;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DataGridView dataGridViewMonths;
    }
}
