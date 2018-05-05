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
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        public void Search()
        {
            string id = Methods.GetInformation("tbl_vehicle", "Licence_Plate", txtSearch.Text, "Licence_Plate");

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
            txtPlate.Text = id;
            txtMake.Text = Methods.GetInformation("tbl_vehicle_manufacturer", "Manufacturer_ID", Methods.GetInformation("tbl_vehicle_model", "Model_ID", Methods.GetInformation("tbl_vehicle", "Licence_Plate", id, "Model_ID"), "Manufacturer_ID"), "Manufacturer");
            txtModel.Text = Methods.GetInformation("tbl_vehicle_model", "Model_ID", Methods.GetInformation("tbl_vehicle", "Licence_Plate", id, "Model_ID"), "Model");
            txtYear.Text =  Methods.GetInformation("tbl_vehicle", "Licence_Plate", id, "Year");
            txtColour.Text = Methods.GetInformation("tbl_vehicle", "Licence_Plate", id, "Colour");
            txtOwner.Text = Methods.GetInformation("tbl_vehicle", "Licence_Plate", id, "Licence_No");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
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

        private void btnLicence_Click(object sender, EventArgs e)
        {

        }
    }
}
