using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PoliceComputer
{
    public static class Methods
    {

        public static string Connection()
        {
            return "datasource=localhost;" +
                                    "port=3307;" +
                                    "username=root;" +
                                    "password=;" +
                                    "database=police_database;";
        }

        public static string GetInformation(string table, string idColumn, string idValue, string column)
        {
            string query = null;
            if (idValue is string)
            {
                query = "SELECT * FROM " + table +
                            " WHERE " + idColumn + " = '" + idValue + "'";
            }
            else
            {
                query = "SELECT * FROM " + table +
                            " WHERE " + idColumn + " = " + idValue;
            }


            MySqlConnection conn = new MySqlConnection(Connection());
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();

                string output = null;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if(!reader.IsDBNull(reader.GetOrdinal(column)))
                        {
                            output = reader.GetString(column);
                        }
                    }
                }
                else if (output == null)
                {
                    output = null;
                }

                conn.Close();
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query: \n" + query + "\nError: \n" + ex);
                return ("Error: \n" + ex);
            }
        }

       
        public static bool IsDriver(string id)
        {
            string query = "SELECT * FROM tbl_driver" +
                        " WHERE ID = '" + id + "'";

            MySqlConnection conn = new MySqlConnection(Connection());
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();

                bool output = false;

                if (reader.HasRows)
                {
                    output = true;
                }
                else
                {
                    output = false;
                }

                conn.Close();
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query: \n" + query + "\nError: \n" + ex);
                return false;
            }
        }
    }
}
