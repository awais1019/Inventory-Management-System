using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public static class DatabaseManager                
    {
        public static string connectionString = "Data Source=DESKTOP-45QI6CK;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False";
        public static SqlConnection connection;
        public static void openConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
        }
        public static void closeConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }
    }
}
