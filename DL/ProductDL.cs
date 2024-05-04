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
    public static class ProductDL
    {
        public static List<Product> products = new List<Product>();
        public static List<Product> cartList = new List<Product>();
        public static bool isAlreadyIntoCartList(Product p)
        {
            for (int i = 0;i < cartList.Count; i++)
            {
                if (cartList[i].ProductID == p.ProductID)
                {
                    cartList[i]= p;
                    return true;
                }
            }
            return false;
        }
        public static void addIntoList(Product p)
        {
            products.Add(p);
        }
        public static int addIntoDB(Product p)
        {
            try
            {
                
                SqlCommand command = new SqlCommand("spAddProduct", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameters to the command
                command.Parameters.AddWithValue("@TotalValue", p.totalValue);
                command.Parameters.AddWithValue("@ManufacturerID", p.ManufacturerID);
                command.Parameters.AddWithValue("@ProductName", p.ProductName);
                command.Parameters.AddWithValue("@CategoryID", p.CategoryID);
                command.Parameters.AddWithValue("@PurchaseRate", p.PurchaseRate);
                command.Parameters.AddWithValue("@SellRate", p.SellRate);
                command.Parameters.AddWithValue("@Quantity", p.Quantity);
                command.Parameters.AddWithValue("@ThresholdQuantity", p.ThresholdQuantity);
                command.Parameters.AddWithValue("@AddedAt", p.AddedAt);
                command.Parameters.Add("@ProductID", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                int insertedProductId = Convert.ToInt32(command.Parameters["@ProductId"].Value);
                p.ProductID = insertedProductId;
                products.Add(p);
                if (insertedProductId > 0)
                {
                    MessageBox.Show("Product added successfully.");
                    return insertedProductId;
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
            return 0;
        }
        public static void loadDataIntoList()
        {
            try
            {
               // string query = "SELECT * FROM Product";
                SqlCommand command = new SqlCommand("spGetAllProduct", DatabaseManager.connection);
                SqlDataReader reader = command.ExecuteReader();
                command.CommandType = CommandType.StoredProcedure;
                // Clear the existing list before loading new data
                products.Clear();

                while (reader.Read())
                {
                    int productID = Convert.ToInt32(reader["ProductID"]);
                    int manufacturerID = Convert.ToInt32(reader["ManufacturerID"]);
                    decimal totalValue = Convert.ToDecimal(reader["TotalValue"]); // Assuming ShelfID is present in the Products table
                    string productName = reader["ProductName"].ToString();
                    int categoryID = Convert.ToInt32(reader["CategoryID"]);
                    decimal purchaseRate = Convert.ToDecimal(reader["PurchaseRate"]);
                    decimal sellRate = Convert.ToDecimal(reader["SellRate"]);
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    int thresholdQuantity = Convert.ToInt32(reader["ThresholdQuantity"]);
                    DateTime addedAt = Convert.ToDateTime(reader["AddedAt"]);

                    // Create Product object and add it to the products list
                    Product product = new Product(productID ,manufacturerID,productName, categoryID, purchaseRate, sellRate, quantity, thresholdQuantity, totalValue ,addedAt);
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
                
                SqlCommand command = new SqlCommand("spdeleteProduct", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;
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

        public static int isProductAlreadyExist(string productName, int manufacturerId)
        {
            int len = products.Count;
            for (int i = 0; i < len ; i++)
            {
                if (products[i].ProductName == productName && products[i].ManufacturerID == manufacturerId)
                {
                    return products[i].ProductID;
                }
            }
            return -1;
        }
        public static void updateProductIntoList(Product p)
        {
            int len = products.Count;
            for (int i = 0; i < len; i++)
            {
                if (products[i].ProductID == p.ProductID)
                {
                    products[i] = p;
                }
            }
        }
        public static void UpdateProductIntoDB(Product p)
        {
            try
            {
                

                SqlCommand command = new SqlCommand("spUpdateProduct", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameters to the command
                command.Parameters.AddWithValue("@ManufacturerID", p.ManufacturerID);
                command.Parameters.AddWithValue("@ProductName", p.ProductName);
                command.Parameters.AddWithValue("@CategoryID", p.CategoryID);
                command.Parameters.AddWithValue("@PurchaseRate", p.PurchaseRate);
                command.Parameters.AddWithValue("@SellRate", p.SellRate);
                command.Parameters.AddWithValue("@Quantity", p.Quantity);
                command.Parameters.AddWithValue("@ThresholdQuantity", p.ThresholdQuantity);
                command.Parameters.AddWithValue("@TotalValue", p.totalValue);
                command.Parameters.AddWithValue("@AddedAt", p.AddedAt);
                command.Parameters.AddWithValue("@ProductID", p.ProductID); // Add the product ID parameter

                // Execute the UPDATE command
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
