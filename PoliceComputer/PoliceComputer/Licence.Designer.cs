namespace PoliceComputer
{
    partial class Licence
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.lblLicence = new System.Windows.Forms.Label();
            this.lblCitations = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.txtCitations = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlResult.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 35;
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
            this.licenceToolStripMenuItem.Enabled = false;
            this.licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            this.licenceToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.licenceToolStripMenuItem.Text = "Licence";
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
            this.mapToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(414, 76);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 39;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(284, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(82, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 20);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.txtLicence);
            this.pnlResult.Controls.Add(this.lblLicence);
            this.pnlResult.Controls.Add(this.lblCitations);
            this.pnlResult.Controls.Add(this.lblPoints);
            this.pnlResult.Controls.Add(this.txtOwner);
            this.pnlResult.Controls.Add(this.lblOwner);
            this.pnlResult.Controls.Add(this.txtPoints);
            this.pnlResult.Controls.Add(this.txtCitations);
            this.pnlResult.Controls.Add(this.lblStatus);
            this.pnlResult.Location = new System.Drawing.Point(12, 117);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(767, 336);
            this.pnlResult.TabIndex = 36;
            this.pnlResult.Visible = false;
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(109, 26);
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.ReadOnly = true;
            this.txtLicence.Size = new System.Drawing.Size(119, 20);
            this.txtLicence.TabIndex = 13;
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.BackColor = System.Drawing.Color.Black;
            this.lblLicence.ForeColor = System.Drawing.Color.White;
            this.lblLicence.Location = new System.Drawing.Point(45, 29);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(62, 13);
            this.lblLicence.TabIndex = 0;
            this.lblLicence.Text = "Licence No";
            // 
            // lblCitations
            // 
            this.lblCitations.AutoSize = true;
            this.lblCitations.BackColor = System.Drawing.Color.Black;
            this.lblCitations.ForeColor = System.Drawing.Color.White;
            this.lblCitations.Location = new System.Drawing.Point(256, 112);
            this.lblCitations.Name = "lblCitations";
            this.lblCitations.Size = new System.Drawing.Size(47, 13);
            this.lblCitations.TabIndex = 1;
            this.lblCitations.Text = "Citations";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Black;
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(45, 112);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Points";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(526, 176);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(143, 20);
            this.txtOwner.TabIndex = 20;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.BackColor = System.Drawing.Color.Black;
            this.lblOwner.ForeColor = System.Drawing.Color.White;
            this.lblOwner.Location = new System.Drawing.Point(441, 179);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(79, 13);
            this.lblOwner.TabIndex = 8;
            this.lblOwner.Text = "Licence Holder";
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(85, 105);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(143, 20);
            this.txtPoints.TabIndex = 15;
            // 
            // txtCitations
            // 
            this.txtCitations.Location = new System.Drawing.Point(309, 105);
            this.txtCitations.Name = "txtCitations";
            this.txtCitations.ReadOnly = true;
            this.txtCitations.Size = new System.Drawing.Size(143, 20);
            this.txtCitations.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Black;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(569, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.lblStatus.Size = new System.Drawing.Size(53, 23);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // Licence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(791, 525);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Licence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search by Licence No";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem civilianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem civilianIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem licenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.Label lblCitations;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtCitations;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}