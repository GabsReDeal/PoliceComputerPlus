namespace PoliceComputer
{
    partial class Help
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
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblCivilian = new System.Windows.Forms.Label();
            this.lblLicence = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(270, 25);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(56, 25);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "Help";
            // 
            // lblCivilian
            // 
            this.lblCivilian.AutoSize = true;
            this.lblCivilian.Location = new System.Drawing.Point(66, 135);
            this.lblCivilian.Name = "lblCivilian";
            this.lblCivilian.Size = new System.Drawing.Size(91, 13);
            this.lblCivilian.TabIndex = 1;
            this.lblCivilian.Text = "Search by Civilian";
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Location = new System.Drawing.Point(66, 183);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(96, 13);
            this.lblLicence.TabIndex = 2;
            this.lblLicence.Text = "Search by Licence";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(66, 230);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(93, 13);
            this.lblVehicle.TabIndex = 3;
            this.lblVehicle.Text = "Search by Vehicle";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(617, 364);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblLicence);
            this.Controls.Add(this.lblCivilian);
            this.Controls.Add(this.lblHelp);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblCivilian;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.Label lblVehicle;
    }
}