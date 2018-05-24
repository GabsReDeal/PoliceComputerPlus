namespace PoliceComputer
{
    partial class Vehicle
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.civilianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.civilianIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.licenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlResult.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(414, 60);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(284, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(82, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 20);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.txtPlate);
            this.pnlResult.Controls.Add(this.lblID);
            this.pnlResult.Controls.Add(this.lblMake);
            this.pnlResult.Controls.Add(this.lblModel);
            this.pnlResult.Controls.Add(this.lblYear);
            this.pnlResult.Controls.Add(this.lblColour);
            this.pnlResult.Controls.Add(this.txtOwner);
            this.pnlResult.Controls.Add(this.txtColour);
            this.pnlResult.Controls.Add(this.lblOwner);
            this.pnlResult.Controls.Add(this.txtYear);
            this.pnlResult.Controls.Add(this.txtModel);
            this.pnlResult.Controls.Add(this.txtMake);
            this.pnlResult.Location = new System.Drawing.Point(12, 101);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(767, 336);
            this.pnlResult.TabIndex = 30;
            this.pnlResult.Visible = false;
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(123, 26);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.ReadOnly = true;
            this.txtPlate.Size = new System.Drawing.Size(119, 20);
            this.txtPlate.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Black;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(45, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(72, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Licence Plate";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.Color.Black;
            this.lblMake.ForeColor = System.Drawing.Color.White;
            this.lblMake.Location = new System.Drawing.Point(45, 108);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "Make";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Black;
            this.lblModel.ForeColor = System.Drawing.Color.White;
            this.lblModel.Location = new System.Drawing.Point(268, 108);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Black;
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(491, 108);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.BackColor = System.Drawing.Color.Black;
            this.lblColour.ForeColor = System.Drawing.Color.White;
            this.lblColour.Location = new System.Drawing.Point(42, 183);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(37, 13);
            this.lblColour.TabIndex = 4;
            this.lblColour.Text = "Colour";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(526, 180);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(143, 20);
            this.txtOwner.TabIndex = 20;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(82, 180);
            this.txtColour.Name = "txtColour";
            this.txtColour.ReadOnly = true;
            this.txtColour.Size = new System.Drawing.Size(143, 20);
            this.txtColour.TabIndex = 17;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.BackColor = System.Drawing.Color.Black;
            this.lblOwner.ForeColor = System.Drawing.Color.White;
            this.lblOwner.Location = new System.Drawing.Point(428, 183);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(92, 13);
            this.lblOwner.TabIndex = 8;
            this.lblOwner.Text = "Registered Owner";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(526, 105);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(143, 20);
            this.txtYear.TabIndex = 16;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(310, 105);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(143, 20);
            this.txtModel.TabIndex = 15;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(85, 105);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(143, 20);
            this.txtMake.TabIndex = 14;
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
            this.menuStrip1.TabIndex = 34;
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
            this.civilianIDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.civilianIDToolStripMenuItem.Text = "Civilian";
            this.civilianIDToolStripMenuItem.Click += new System.EventHandler(this.civilianIDToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem1
            // 
            this.vehicleToolStripMenuItem1.Enabled = false;
            this.vehicleToolStripMenuItem1.Name = "vehicleToolStripMenuItem1";
            this.vehicleToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.vehicleToolStripMenuItem1.Text = "Vehicle";
            // 
            // licenceToolStripMenuItem
            // 
            this.licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            this.licenceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.mapToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(791, 525);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search by Licence Plate";
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem civilianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem civilianIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem licenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}