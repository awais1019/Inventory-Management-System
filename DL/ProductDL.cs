using Inventory_Management_System.BL_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.DL
{
    public static class ProductDL
    {
        public static List<Product> products = new List<Product>();
        public static void addIntoList(Product p)
        {
            products.Add(p);
        }
        public static void addIntoDB(Product p)
        {
            try
            {
                // Define the SQL query to insert a new product into the Product table
                string query = @"INSERT INTO Product (ManufacturerID, ProductName, CategoryID, PurchaseRate, SellRate, Quantity, ThresholdQuantity, ShelfId, AddedAt) 
                             VALUES (@ManufacturerID, @ProductName, @CategoryID, @PurchaseRate, @SellRate, @Quantity, @ThresholdQuantity, @ShelfId, @AddedAt)";

                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);

                // Add parameters to the command
                command.Parameters.AddWithValue("@ShelfId", p.shelfId);
                command.Parameters.AddWithValue("@ManufacturerID", p.ManufacturerID);
                command.Parameters.AddWithValue("@ProductName", p.ProductName);
                command.Parameters.AddWithValue("@CategoryID", p.CategoryID);
                command.Parameters.AddWithValue("@PurchaseRate", p.PurchaseRate);
                command.Parameters.AddWithValue("@SellRate", p.SellRate);
                command.Parameters.AddWithValue("@Quantity", p.Quantity);
                command.Parameters.AddWithValue("@ThresholdQuantity", p.ThresholdQuantity);
                command.Parameters.AddWithValue("@AddedAt", p.AddedAt);

                // Execute the INSERT command
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static void loadDataIntoList()
        {
            try
            {
                string query = "SELECT * FROM Product";
                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);
                SqlDataReader reader = command.ExecuteReader();

                // Clear the existing list before loading new data
                products.Clear();

                while (reader.Read())
                {
                    int productID = Convert.ToInt32(reader["ProductID"]);
                    int manufacturerID = Convert.ToInt32(reader["ManufacturerID"]);
                    int shelfId = Convert.ToInt32(reader["ShelfID"]); // Assuming ShelfID is present in the Products table
                    string productName = reader["ProductName"].ToString();
                    int categoryID = Convert.ToInt32(reader["CategoryID"]);
                    decimal purchaseRate = Convert.ToDecimal(reader["PurchaseRate"]);
                    decimal sellRate = Convert.ToDecimal(reader["SellRate"]);
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    int thresholdQuantity = Convert.ToInt32(reader["ThresholdQuantity"]);
                    DateTime addedAt = Convert.ToDateTime(reader["AddedAt"]);

                    // Create Product object and add it to the products list
                    Product product = new Product(productID ,manufacturerID, shelfId,productName, categoryID, purchaseRate, sellRate, quantity, thresholdQuantity, addedAt);
                    products.Add(product);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void deleteFromList(int i)
        {
            Product p = getProduct(i);
            if (p != null)
            {
                foreach (Product pr in products)
                {
                    if (pr == p)
                    {
                        products.Remove(p);
                        return;
                    }
                }
            }
        }
        public static Product getProduct(int id)
        {
            int len = products.Count;
            for (int i = 0;i < len;i++)
            {
                if (id == products[i].ProductID)
                {
                    return products[i];
                }
            }
            return null;
        }
        public static void deleteFromDB(int id)
        {
            try
            {
                string deleteCommandText = "DELETE FROM Product WHERE ProductID = @ProductID";
                SqlCommand command = new SqlCommand(deleteCommandText, DatabaseManager.connection);

                // Add parameters to the command
                command.Parameters.AddWithValue("@ProductID", id);

                // Execute the DELETE command
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("deleted");
                }
                else
                {
                    MessageBox.Show($"product with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }

    }
}
