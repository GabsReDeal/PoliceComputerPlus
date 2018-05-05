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

        public void fillInformation()
        {
            string id = "0162599M";

            txtID.Text = id;
            txtSurame.Text = Methods.getInformation("tbl_civilian", "ID", id, "Surname");
            txtName.Text = Methods.getInformation("tbl_civilian", "ID", id, "Name");
            txtMiddle.Text = Methods.getInformation("tbl_civilian", "ID", id, "Middle_Name");
            txtDob.Text = Methods.getInformation("tbl_civilian", "ID", id, "DoB");
            txtGender.Text = Methods.getInformation("tbl_civilian", "ID", id, "Gender");
            txtSSN.Text = Methods.getInformation("tbl_civilian", "ID", id, "SSN");
            txtHome.Text = Methods.getInformation("tbl_civilian", "ID", id, "Home_Phone");
            txtHouse.Text = Methods.getInformation("tbl_civilian", "ID", id, "House_Number_Name");
            txtStreet.Text = Methods.getInformation("tbl_street", "Street_ID", Methods.getInformation("tbl_civilian", "ID", id, "Street_ID"), "Street");
            txtLocality.Text = Methods.getInformation("tbl_locality", "Locality_ID", Methods.getInformation("tbl_street", "Street_ID", Methods.getInformation("tbl_civilian", "ID", id, "Street_ID"), "Locality_ID"), "Locality");
        }

        private void Civilian_Load(object sender, EventArgs e)
        {
            fillInformation();
        }
    }
}
