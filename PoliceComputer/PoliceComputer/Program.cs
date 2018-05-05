using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PoliceComputer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());

            //ConnectAndRetrieve();
            //ConnectAndInsert();
        }

        public static void ConnectAndRetrieve()
        {
            string connSettings = "datasource=localhost;" +
                                    "port=3307;" +
                                    "username=root;" +
                                    "password=;" +
                                    "database=police_database;";

            string query = "SELECT * FROM tbl_civilian";

            MySqlConnection conn = new MySqlConnection(connSettings);
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        MessageBox.Show(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2));

                    }
                }

                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Could not connect to database!");
            }
        }

        public static void ConnectAndInsert()
        {
            string connSettings = "datasource=localhost;" +
                                    "port=3307;" +
                                    "username=root;" +
                                    "password=;" +
                                    "database=police_database;";

            string query = "INSERT INTO table_name (a, b, c, d) " +
                            "VALUES ('aa', 'bb', 'cc', 'dd'";

            //string query = "UPFATE table_name" +
                            //"SET a = 'aa' where b = 'bb'";

            //string query = "DELETE FROM table_name " +
                            //"WHERE a == 'aa'";

            MySqlConnection conn = new MySqlConnection(connSettings);
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not connect to database!");
            }
        }
    }
}
