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
    public partial class Licence : Form
    {
        public Licence()
        {
            InitializeComponent();
        }

        public void Search()
        {
            string id = Methods.GetInformation("tbl_driver", "Licence_No", txtSearch.Text, "Licence_No");

            if (id == null)
            {
                lblError.Text = "No results were found with that Licence Plate";
                pnlResult.Hide();
            }
            else
            {
                lblError.Text = null;
                pnlResult.Show();
                FillInformation(id);
            }
        }

        public void FillInformation(string id)
        {
            txtLicence.Text = id;
            txtCitations.Text = Methods.GetInformation("tbl_driver", "Licence_No", id, "Citations");
            txtPoints.Text = Methods.GetInformation("tbl_driver", "Licence_No", id, "Points");
            txtOwner.Text = Methods.GetInformation("tbl_driver", "Licence_No", id, "ID");

            if(Methods.GetInformation("tbl_driver", "Licence_No", id, "Status_ID") == "V")
            {
                lblStatus.Text = "Valid";
                lblStatus.BackColor = Color.Green;
            }
            else if(Methods.GetInformation("tbl_driver", "Licence_No", id, "Status_ID") == "E")
            {
                lblStatus.Text = "Expired";
                lblStatus.BackColor = Color.Red;
            }
            else
            {
                lblStatus.Text = "Revoked";
                lblStatus.BackColor = Color.Red;
            }
        }
        private void btnOwner_Click(object sender, EventArgs e)
        {
            string id = Methods.GetInformation("tbl_driver", "Licence_No", txtSearch.Text, "Licence_No");

            this.Hide();
            var form = new Vehicle();
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

        private void civilianIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Civilian();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
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
