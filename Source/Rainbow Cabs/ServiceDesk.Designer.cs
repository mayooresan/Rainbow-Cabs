namespace Rainbow_Cabs
{
    partial class ServiceDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceDesk));
            this.buttonTrackTaxiDriver = new System.Windows.Forms.Button();
            this.buttonMakeReservation = new System.Windows.Forms.Button();
            this.buttonAmendReservation = new System.Windows.Forms.Button();
            this.buttonCheckCabFares = new System.Windows.Forms.Button();
            this.buttonCheckAvailability = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTrackTaxiDriver
            // 
            this.buttonTrackTaxiDriver.Location = new System.Drawing.Point(287, 149);
            this.buttonTrackTaxiDriver.Name = "buttonTrackTaxiDriver";
            this.buttonTrackTaxiDriver.Size = new System.Drawing.Size(88, 51);
            this.buttonTrackTaxiDriver.TabIndex = 4;
            this.buttonTrackTaxiDriver.Text = "Track Driver";
            this.buttonTrackTaxiDriver.UseVisualStyleBackColor = true;
            this.buttonTrackTaxiDriver.Click += new System.EventHandler(this.buttonTrackTaxiDriver_Click);
            // 
            // buttonMakeReservation
            // 
            this.buttonMakeReservation.Location = new System.Drawing.Point(13, 80);
            this.buttonMakeReservation.Name = "buttonMakeReservation";
            this.buttonMakeReservation.Size = new System.Drawing.Size(88, 51);
            this.buttonMakeReservation.TabIndex = 0;
            this.buttonMakeReservation.Text = "Make Reservation";
            this.buttonMakeReservation.UseVisualStyleBackColor = true;
            // 
            // buttonAmendReservation
            // 
            this.buttonAmendReservation.Location = new System.Drawing.Point(154, 80);
            this.buttonAmendReservation.Name = "buttonAmendReservation";
            this.buttonAmendReservation.Size = new System.Drawing.Size(88, 51);
            this.buttonAmendReservation.TabIndex = 1;
            this.buttonAmendReservation.Text = "Amend Reservation";
            this.buttonAmendReservation.UseVisualStyleBackColor = true;
            // 
            // buttonCheckCabFares
            // 
            this.buttonCheckCabFares.Location = new System.Drawing.Point(154, 149);
            this.buttonCheckCabFares.Name = "buttonCheckCabFares";
            this.buttonCheckCabFares.Size = new System.Drawing.Size(88, 51);
            this.buttonCheckCabFares.TabIndex = 3;
            this.buttonCheckCabFares.Text = "Check Cab Fares";
            this.buttonCheckCabFares.UseVisualStyleBackColor = true;
            // 
            // buttonCheckAvailability
            // 
            this.buttonCheckAvailability.Location = new System.Drawing.Point(13, 149);
            this.buttonCheckAvailability.Name = "buttonCheckAvailability";
            this.buttonCheckAvailability.Size = new System.Drawing.Size(88, 51);
            this.buttonCheckAvailability.TabIndex = 2;
            this.buttonCheckAvailability.Text = "Check Availability";
            this.buttonCheckAvailability.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Service Desk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ServiceDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAmendReservation);
            this.Controls.Add(this.buttonCheckAvailability);
            this.Controls.Add(this.buttonCheckCabFares);
            this.Controls.Add(this.buttonMakeReservation);
            this.Controls.Add(this.buttonTrackTaxiDriver);
            this.MaximizeBox = false;
            this.Name = "ServiceDesk";
            this.Text = "Service Desk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTrackTaxiDriver;
        private System.Windows.Forms.Button buttonMakeReservation;
        private System.Windows.Forms.Button buttonAmendReservation;
        private System.Windows.Forms.Button buttonCheckCabFares;
        private System.Windows.Forms.Button buttonCheckAvailability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}