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
    }
}
