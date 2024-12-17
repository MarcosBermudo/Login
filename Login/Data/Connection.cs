using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Login.Data
{
    internal class Connection
    {
        public static string server = "127.0.0.1";
        public static string dataBase = "login";
        public static string user = "root";
        public static string password = "123456";

        public static MySqlConnection connMaster = new MySqlConnection();
        public static void OpenConnection()
        {
            string connectionString = $"server={server};database={dataBase};user={user};password={password};";
            
            connMaster = new MySqlConnection(connectionString) ;
            connMaster.Open();

            if(connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexión establecida");
            }
            else
            {
                MessageBox.Show("No se ha podido establecer la conexión");
            }
        }
        public static void CloseConnection() { 
        
        }
    }
}
