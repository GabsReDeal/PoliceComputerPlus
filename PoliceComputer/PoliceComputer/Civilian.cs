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
    public partial class Civilian : Form
    {
        public Civilian()
        {
            InitializeComponent();
        }

        public void Search()
        {
            string id = Methods.GetInformation("tbl_civilian", "ID", txtSearch.Text, "ID");

            if(id == null)
            {
                lblError.Text = "No results were found with that ID";
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
            txtID.Text = id;
            txtSurame.Text = Methods.GetInformation("tbl_civilian", "ID", id, "Surname");
            txtName.Text = Methods.GetInformation("tbl_civilian", "ID", id, "Name");
            txtMiddle.Text = Methods.GetInformation("tbl_civilian", "ID", id, "Middle_Name");
            txtDob.Text = DateTime.ParseExact(Methods.GetInformation("tbl_civilian", "ID", id, "DoB"), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"); // Converting string to DateTime and back to string in order to remove the time included.
            txtGender.Text = Methods.GetInformation("tbl_civilian", "ID", id, "Gender");
            txtSSN.Text = Methods.GetInformation("tbl_civilian", "ID", id, "SSN");
            txtHome.Text = Methods.GetInformation("tbl_civilian", "ID", id, "Home_Phone");
            txtHouse.Text = Methods.GetInformation("tbl_civilian", "ID", id, "House_Number_Name");
            txtStreet.Text = Methods.GetInformation("tbl_street", "Street_ID", Methods.GetInformation("tbl_civilian", "ID", id, "Street_ID"), "Street");
            txtLocality.Text = Methods.GetInformation("tbl_locality", "Locality_ID", Methods.GetInformation("tbl_street", "Street_ID", Methods.GetInformation("tbl_civilian", "ID", id, "Street_ID"), "Locality_ID"), "Locality");

            object tst = Properties.Resources.ResourceManager.GetObject("_" + id);
            profilePicture.Image = (Image)tst;

            if (Methods.IsDriver(id))
            {
                //btnLicence.Enabled = true;
                btnLicence.Show();
            }
            else
            {
                //btnLicence.Enabled = false;
                btnLicence.Hide();
            }
        }

        private void Civilian_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
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
