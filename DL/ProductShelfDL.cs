﻿using Inventory_Management_System.BL_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
    }
}