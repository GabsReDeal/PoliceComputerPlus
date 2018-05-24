using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceComputer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void civilianToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnCivilian_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Civilian();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Vehicle();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnLicence_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Licence();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Map();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Help();
            form.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Menu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
