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

        public static string getInformation(string table, string idColumn, string idValue, string column)
        {
            string connSettings = Connection();

            string query = null;
            if(idValue is string)
            {
                query = "SELECT * FROM " + table +
                            " WHERE " + idColumn + " = '" + idValue + "'";
            }
            else
            {
                query = "SELECT * FROM " + table +
                            " WHERE " + idColumn + " = " + idValue;
            }
            

            MySqlConnection conn = new MySqlConnection(connSettings);
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
                        output = reader.GetString(column);
                    }
                }
                else
                {
                    output = "N/a";
                }

                conn.Close();
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex);
                MessageBox.Show("Query: \n" + query);
                return ("Error: \n" + ex);
            }
        }
    }
}
