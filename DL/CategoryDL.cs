using Inventory_Management_System.BL_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.DL
{
    public static class CategoryDL
    {
        public static List<ProductCategory> categories = new List<ProductCategory>();
        public static void getCategoryFromDB()
        {
            try
            {
                string query = "SELECT CategoryID, CategoryName FROM Category";
                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int categoryId = Convert.ToInt32(reader["CategoryID"]);
                    string categoryName = reader["CategoryName"].ToString();

                    // Create ProductCategory object and add it to the categories list
                    ProductCategory category = new ProductCategory(categoryId, categoryName);
                    categories.Add(category);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static ProductCategory getCategory(int id)
        {
            int len = categories.Count;
            for (int i = 0; i < len; i++)
            {
                if (categories[i].CategoryID == id)
                {
                    return categories[i];
                }
            }
            return null;
        }
    }
}
