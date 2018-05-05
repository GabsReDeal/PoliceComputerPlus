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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(316, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchByToolStripMenuItem
            // 
            this.searchByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.civilianToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.searchByToolStripMenuItem.Name = "searchByToolStripMenuItem";
            this.searchByToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.searchByToolStripMenuItem.Text = "File";
            // 
            // civilianToolStripMenuItem
            // 
            this.civilianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.civilianIDToolStripMenuItem,
            this.vehicleToolStripMenuItem1});
            this.civilianToolStripMenuItem.Name = "civilianToolStripMenuItem";
            this.civilianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.civilianToolStripMenuItem.Text = "Search by...";
            this.civilianToolStripMenuItem.Click += new System.EventHandler(this.civilianToolStripMenuItem_Click);
            // 
            // civilianIDToolStripMenuItem
            // 
            this.civilianIDToolStripMenuItem.Name = "civilianIDToolStripMenuItem";
            this.civilianIDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.civilianIDToolStripMenuItem.Text = "Civilian";
            this.civilianIDToolStripMenuItem.Click += new System.EventHandler(this.civilianIDToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem1
            // 
            this.vehicleToolStripMenuItem1.Name = "vehicleToolStripMenuItem1";
            this.vehicleToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vehicleToolStripMenuItem1.Text = "Vehicle";
            this.vehicleToolStripMenuItem1.Click += new System.EventHandler(this.vehicleToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 284);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}