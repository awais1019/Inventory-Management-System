using Inventory_Management_System.BL_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.DL
{
    public static class ProductShelfDL
    {
        public static List<ProductShelf> productShelves = new List<ProductShelf>();
        public static void addIntoList(ProductShelf p)
        {
            productShelves.Add(p);
        }
        public static ProductShelf getProductShelf(int pid, int shelfid)
        {
            for (int i = 0; i < productShelves.Count; i++)
            {
                if (productShelves[i].productId == pid && productShelves[i].shelfId == shelfid)
                {
                    return productShelves[i];
                }
            }
            return null;
        }
        public static void loadIntoList()
        {
            try
            {
                string query = "SELECT * FROM ProductShelf";
                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);
                SqlDataReader reader = command.ExecuteReader();

                // Clear the existing list before loading new data
                productShelves.Clear();

                while (reader.Read())
                {
                    int productID = Convert.ToInt32(reader["ProductID"]);
                    int shelfid = Convert.ToInt32(reader["ShelfId"]);
                 
                    int quantity = Convert.ToInt32(reader["Quantity"]);


                    // Create Product object and add it to the products list
                    ProductShelf product = new ProductShelf(productID, shelfid, quantity);
                    productShelves.Add(product);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void addIntoDB(ProductShelf p)
        {
            try
            {
                // Define the SQL query to insert a new product into the Product table
                string query = @"INSERT INTO ProductShelf (ProductId, ShelfId, Quantity) 
                             VALUES (@ProductId, @ShelfId, @Quantity)";

                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);

                // Add parameters to the command
                command.Parameters.AddWithValue("@ProductId", p.productId);
                command.Parameters.AddWithValue("@ShelfId", p.shelfId);
                command.Parameters.AddWithValue("@Quantity", p.quantity);

                // Execute the INSERT command
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    //MessageBox.Show("Product added successfully.");
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
        public static void deleteProductShelfFromList(int pid)
        {
            for (int i = productShelves.Count - 1; i >= 0; i--)
            {
                ProductShelf ps = productShelves[i];
                if (ps.productId == pid)
                {
                    Shelf shelf = ShelfDL.getShelf(ps.shelfId);
                    if (shelf != null)
                    {
                        shelf.currentCapacity -= ps.quantity;
                        ShelfDL.updateShelfIntoList(shelf);
                        ShelfDL.updateShelfIntoDB(shelf);
                    }
                    productShelves.RemoveAt(i);
                }
            }
        }
        public static void deleteProductShelfFromList(int pid, int shelfid)
        {
            for (int i = productShelves.Count - 1; i >= 0; i--)
            {
                ProductShelf ps = productShelves[i];
                if (ps.productId == pid && ps.shelfId == shelfid)
                {
                    productShelves.RemoveAt(i);
                }
            }
        }
        public static void deleteProductShelfFromDBbyPid(int pid)
        {
            try
            {
                SqlCommand command = new SqlCommand("spDeleteProductShelfByProductId", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductId", pid);
                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public static void deleteProductShelfFromDB(int pid, int shelfId)
        {
            try
            {
                SqlCommand command = new SqlCommand("spDeleteProductShelf", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductId", pid);
                command.Parameters.AddWithValue("@ShelfId", shelfId);
                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public static void updateProductShelfIntoList(ProductShelf p)
        {
            foreach(ProductShelf ps in productShelves)
            {
                if (ps.shelfId == p.shelfId && ps.productId == p.productId)
                {
                    ps.quantity = p.quantity;
                }
            }
        }
        public static void updateProductShelfIntoDB(ProductShelf p)
        {
            try
            {
                SqlCommand command = new SqlCommand("spUpdateProductShelf", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductId", p.productId);
                command.Parameters.AddWithValue("@ShelfId", p.shelfId);
                command.Parameters.AddWithValue("@Quantity", p.quantity);
                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public static List<int> getShelfIdbyPid(int pid)
        {
            List<int> shelfid = new List<int>();
            int len = productShelves.Count;
            for (int i = 0; i < len; i++)
            {
                if (productShelves[i].productId == pid)
                {
                    shelfid.Add(productShelves[i].shelfId);
                }
            }
            return shelfid;
        }

    }
}
