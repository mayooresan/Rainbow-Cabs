namespace Rainbow_Cabs
{
    partial class CabLocation
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonRefreshLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(246, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(306, 295);
            this.webBrowser1.TabIndex = 1;
            // 
            // buttonRefreshLocation
            // 
            this.buttonRefreshLocation.Location = new System.Drawing.Point(34, 284);
            this.buttonRefreshLocation.Name = "buttonRefreshLocation";
            this.buttonRefreshLocation.Size = new System.Drawing.Size(162, 23);
            this.buttonRefreshLocation.TabIndex = 2;
            this.buttonRefreshLocation.Text = "Refresh Location";
            this.buttonRefreshLocation.UseVisualStyleBackColor = true;
            this.buttonRefreshLocation.Click += new System.EventHandler(this.buttonRefreshLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Updated";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(108, 27);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 13);
            this.labelDate.TabIndex = 4;
            // 
            // CabLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 319);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefreshLocation);
            this.Controls.Add(this.webBrowser1);
            this.Name = "CabLocation";
            this.Text = "Cab Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonRefreshLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
    }
}