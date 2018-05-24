namespace PoliceComputer
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.civilianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.civilianIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.licenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCivilian = new System.Windows.Forms.Button();
            this.btnLicence = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBadge = new System.Windows.Forms.PictureBox();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBadge)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.mapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchByToolStripMenuItem
            // 
            this.searchByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.civilianToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.searchByToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchByToolStripMenuItem.Name = "searchByToolStripMenuItem";
            this.searchByToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.searchByToolStripMenuItem.Text = "File";
            // 
            // civilianToolStripMenuItem
            // 
            this.civilianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.civilianIDToolStripMenuItem,
            this.vehicleToolStripMenuItem1,
            this.licenceToolStripMenuItem});
            this.civilianToolStripMenuItem.Name = "civilianToolStripMenuItem";
            this.civilianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.civilianToolStripMenuItem.Text = "Search by...";
            this.civilianToolStripMenuItem.Click += new System.EventHandler(this.civilianToolStripMenuItem_Click);
            // 
            // civilianIDToolStripMenuItem
            // 
            this.civilianIDToolStripMenuItem.Name = "civilianIDToolStripMenuItem";
            this.civilianIDToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.civilianIDToolStripMenuItem.Text = "Civilian";
            this.civilianIDToolStripMenuItem.Click += new System.EventHandler(this.civilianIDToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem1
            // 
            this.vehicleToolStripMenuItem1.Name = "vehicleToolStripMenuItem1";
            this.vehicleToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.vehicleToolStripMenuItem1.Text = "Vehicle";
            this.vehicleToolStripMenuItem1.Click += new System.EventHandler(this.vehicleToolStripMenuItem1_Click);
            // 
            // licenceToolStripMenuItem
            // 
            this.licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            this.licenceToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.licenceToolStripMenuItem.Text = "Licence";
            this.licenceToolStripMenuItem.Click += new System.EventHandler(this.licenceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.mapToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(262, 53);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(91, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnCivilian
            // 
            this.btnCivilian.ForeColor = System.Drawing.Color.Black;
            this.btnCivilian.Location = new System.Drawing.Point(112, 282);
            this.btnCivilian.Name = "btnCivilian";
            this.btnCivilian.Size = new System.Drawing.Size(87, 23);
            this.btnCivilian.TabIndex = 3;
            this.btnCivilian.Text = "Civilian";
            this.btnCivilian.UseVisualStyleBackColor = true;
            this.btnCivilian.Click += new System.EventHandler(this.btnCivilian_Click);
            // 
            // btnLicence
            // 
            this.btnLicence.ForeColor = System.Drawing.Color.Black;
            this.btnLicence.Location = new System.Drawing.Point(428, 282);
            this.btnLicence.Name = "btnLicence";
            this.btnLicence.Size = new System.Drawing.Size(87, 23);
            this.btnLicence.TabIndex = 3;
            this.btnLicence.Text = "Licence";
            this.btnLicence.UseVisualStyleBackColor = true;
            this.btnLicence.Click += new System.EventHandler(this.btnLicence_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.ForeColor = System.Drawing.Color.Black;
            this.btnVehicle.Location = new System.Drawing.Point(266, 282);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(87, 23);
            this.btnVehicle.TabIndex = 3;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "You may search by...";
            // 
            // pbBadge
            // 
            this.pbBadge.Image = global::PoliceComputer.Properties.Resources.badgeInvert;
            this.pbBadge.Location = new System.Drawing.Point(251, 91);
            this.pbBadge.Name = "pbBadge";
            this.pbBadge.Size = new System.Drawing.Size(111, 111);
            this.pbBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBadge.TabIndex = 5;
            this.pbBadge.TabStop = false;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Enabled = false;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(617, 364);
            this.Controls.Add(this.pbBadge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVehicle);
            this.Controls.Add(this.btnLicence);
            this.Controls.Add(this.btnCivilian);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBadge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem civilianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem civilianIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenceToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCivilian;
        private System.Windows.Forms.Button btnLicence;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBadge;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}