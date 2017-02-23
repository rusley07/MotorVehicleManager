namespace MotorMgr
{
    partial class summaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(summaryForm));
            this.totalCarsLabel = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.totalCarsSoldLabel = new System.Windows.Forms.Label();
            this.dailySalesAmountLabel = new System.Windows.Forms.Label();
            this.dailySalesLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalCarsLabel
            // 
            this.totalCarsLabel.AutoSize = true;
            this.totalCarsLabel.Location = new System.Drawing.Point(12, 37);
            this.totalCarsLabel.Name = "totalCarsLabel";
            this.totalCarsLabel.Size = new System.Drawing.Size(82, 13);
            this.totalCarsLabel.TabIndex = 0;
            this.totalCarsLabel.Text = "Total Cars Sold:";
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Location = new System.Drawing.Point(12, 76);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(101, 13);
            this.salesLabel.TabIndex = 1;
            this.salesLabel.Text = "Daily Sales Amount:";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(12, 112);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(118, 13);
            this.averageLabel.TabIndex = 2;
            this.averageLabel.Text = "Average Sales Amount:";
            // 
            // totalCarsSoldLabel
            // 
            this.totalCarsSoldLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCarsSoldLabel.Location = new System.Drawing.Point(143, 27);
            this.totalCarsSoldLabel.Name = "totalCarsSoldLabel";
            this.totalCarsSoldLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCarsSoldLabel.TabIndex = 3;
            // 
            // dailySalesAmountLabel
            // 
            this.dailySalesAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailySalesAmountLabel.Location = new System.Drawing.Point(143, 66);
            this.dailySalesAmountLabel.Name = "dailySalesAmountLabel";
            this.dailySalesAmountLabel.Size = new System.Drawing.Size(100, 23);
            this.dailySalesAmountLabel.TabIndex = 4;
            // 
            // dailySalesLabel
            // 
            this.dailySalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailySalesLabel.Location = new System.Drawing.Point(143, 102);
            this.dailySalesLabel.Name = "dailySalesLabel";
            this.dailySalesLabel.Size = new System.Drawing.Size(100, 23);
            this.dailySalesLabel.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.okButton.Location = new System.Drawing.Point(103, 158);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "&Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // summaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dailySalesLabel);
            this.Controls.Add(this.dailySalesAmountLabel);
            this.Controls.Add(this.totalCarsSoldLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.totalCarsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "summaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.summaryForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCarsLabel;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label totalCarsSoldLabel;
        private System.Windows.Forms.Label dailySalesAmountLabel;
        private System.Windows.Forms.Label dailySalesLabel;
        private System.Windows.Forms.Button okButton;
    }
}