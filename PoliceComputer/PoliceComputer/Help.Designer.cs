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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblCivilian = new System.Windows.Forms.Label();
            this.lblLicence = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(355, 20);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(56, 25);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "Help";
            // 
            // lblCivilian
            // 
            this.lblCivilian.AutoSize = true;
            this.lblCivilian.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCivilian.Location = new System.Drawing.Point(60, 77);
            this.lblCivilian.Name = "lblCivilian";
            this.lblCivilian.Size = new System.Drawing.Size(124, 18);
            this.lblCivilian.TabIndex = 1;
            this.lblCivilian.Text = "Search by Civilian";
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicence.Location = new System.Drawing.Point(60, 182);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(129, 18);
            this.lblLicence.TabIndex = 2;
            this.lblLicence.Text = "Search by Licence";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.Location = new System.Drawing.Point(60, 301);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(125, 18);
            this.lblVehicle.TabIndex = 3;
            this.lblVehicle.Text = "Search by Vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "When searching by civilian, you must enter a valid ID number.\r\nA valid ID number " +
    "consists of 7 digits and 1 letter.\r\n\r\nGood: 0123456M                Bad: 123456M" +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 52);
            this.label2.TabIndex = 5;
            this.label2.Text = "When searching by licence, you must enter a valid licence number.\r\nA valid licenc" +
    "e number consists of 4 letters and 9 digits.\r\n\r\nGood: MLTA012345678             " +
    "   Bad: 12345678MLTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 78);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Additional information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 65);
            this.label5.TabIndex = 8;
            this.label5.Text = "This application was created by\r\n\r\nGabriel Gauci\r\n\r\n© 2018";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Map";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 104);
            this.label7.TabIndex = 10;
            this.label7.Text = resources.GetString("label7.Text");
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(748, 439);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}