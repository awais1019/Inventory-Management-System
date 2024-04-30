using Inventory_Management_System.BL_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.DL
{
    public static class WarehouseDL
    {
        public static List<Warehouse> warehouses = new List<Warehouse>();
        public static void addIntoList(Warehouse w)
        {
            warehouses.Add(w);
        }
        public static void loadIntoList()
        {
            try
            {
                string query = "SELECT WarehouseId, WarehouseName FROM Warehouse";
                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int warehouseId = Convert.ToInt32(reader["WarehouseID"]);
                    string warehouseName = reader["WarehouseName"].ToString();

                    // Create ProductCategory object and add it to the categories list
                    Warehouse w = new Warehouse(warehouseId, warehouseName);
                    warehouses.Add(w);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
