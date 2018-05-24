using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PoliceComputer
{
    public partial class loginForm : Form
    {
        private void AuthenticateLogin()
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorLogin.SetError(txtUsername, "Please enter your username!");
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorLogin.SetError(txtPassword, "Please enter your password!");
            }
            else if (!String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                string username = txtUsername.Text; string password = txtPassword.Text;

                string connSettings = Methods.Connection();

                string query = "SELECT * FROM tbl_officer " +
                                "WHERE Officer_ID = '" + username + "' AND Password = sha1('" + password + "')";

                MySqlConnection conn = new MySqlConnection(connSettings);
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader;

                try
                {
                    conn.Open();
                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //MessageBox.Show("You have successfully logged in!");
                        this.Hide();
                        var menuForm = new Menu();
                        menuForm.Closed += (s, args) => this.Close();
                        menuForm.Show();
                    }
                    else
                    {
                        lblError.Text = "Username or Password incorrect!";
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex);
                }
            }
        }
        public loginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthenticateLogin();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AuthenticateLogin();
            }
        }
    }
}
