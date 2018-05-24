using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetBrowser;
using DotNetBrowser.WinForms;

namespace PoliceComputer
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private BrowserView browserView;
        private void Map_Load(object sender, EventArgs e)
        {
            browserView = new WinFormsBrowserView();
            this.Controls.Add((Control)browserView.GetComponent());
            browserView.Browser.LoadURL("http://maps.google.com");

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void civilianIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Civilian();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void vehicleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Vehicle();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void licenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Licence();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Help();
            form.Show();
        }
    }
}
