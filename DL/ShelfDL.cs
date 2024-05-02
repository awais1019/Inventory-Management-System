using Inventory_Management_System.BL_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.DL
{
    public static class ShelfDL
    {
        public static List<Shelf> shelves = new List<Shelf>();
        public static void addIntoList(Shelf shelf)
        {
            shelves.Add(shelf);
        }
        public static void addIntoDB(Shelf shelf)
        {
            try
            {
                string query = @"
            SET IDENTITY_INSERT Shelf ON;
            INSERT INTO Shelf (ShelfId, Capacity, CurrentCapacity, ShelfName, BlockId) 
            VALUES (@ShelfId, @Capacity, @CurrentCapacity, @ShelfName, @BlockId);
            ";
                // string query = "INSERT INTO Shelf (SET IDENTITY_INSERT Shelf ON; ShelfId, Capacity, CurrentCapacity, CategoryId, BlockId) VALUES (@ShelfId, @Capacity, @CurrentCapacity, @CategoryId, @BlockId)";
                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);
                command.Parameters.AddWithValue("@ShelfId", shelf.shelfId);
                command.Parameters.AddWithValue("@Capacity", shelf.capacity);
                command.Parameters.AddWithValue("@CurrentCapacity", shelf.currentCapacity);
                command.Parameters.AddWithValue("@ShelfName", shelf.shelfName); 
                command.Parameters.AddWithValue("@BlockId", shelf.blockId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Shelf added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add Shelf.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void loadIntoList()
        {
            try
            {

                string query = "SELECT * FROM Shelf";
                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);
                SqlDataReader reader = command.ExecuteReader();

                // Clear the existing list before loading new data
                shelves.Clear();

                while (reader.Read())
                {
                    int shelfid = Convert.ToInt32(reader["ShelfId"]);
                    int capacity = Convert.ToInt32(reader["Capacity"]);
                    int currentCapacity = Convert.ToInt32(reader["CurrentCapacity"]);
                    string shelfName = reader["ShelfName"].ToString();
                    int blockId = Convert.ToInt32(reader["BlockId"]);
                    // Create Manufacturer object and add it to the manufacturers list
                    Shelf s = new Shelf(shelfid, capacity, currentCapacity, shelfName, blockId);
                    shelves.Add(s);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static List<Shelf> getShelvesByBlock(int blockId)
        {
            List<Shelf> sh = new List<Shelf>();
            for (int i = 0; i < shelves.Count; i++)
            {
                if (shelves[i].blockId == blockId && shelves[i].currentCapacity < shelves[i].capacity)
                {
                    sh.Add(shelves[i]);
                }
            }
            return sh;
        }
        public static Shelf getShelf(int shelfid)
        {
            foreach (Shelf shelf in shelves)
            {
                if (shelf.shelfId == shelfid)
                {
                    return shelf;
                }
            }
            return null;
        }
        public static void updateShelfIntoList(Shelf shelf)
        {
            int len = shelves.Count;
            for (int i = 0; i < len; i++)
            {
                if (shelves[i].shelfId == shelf.shelfId)
                {
                    shelves[i] = shelf;
                    return;
                }
            }
        }
        public static void updateShelfIntoDB(Shelf shelf)
        {
            try
            {
                SqlCommand command = new SqlCommand("spUpdateShelf", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.AddWithValue("@Capacity", shelf.capacity);
                command.Parameters.AddWithValue("@CurrentCapacity", shelf.currentCapacity);
                command.Parameters.AddWithValue("@ShelfName", shelf.shelfName);
                command.Parameters.AddWithValue("@BlockId", shelf.blockId);
                command.Parameters.AddWithValue("@ShelfId", shelf.shelfId);
                int rowsAffected = command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
