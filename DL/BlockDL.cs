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
    public static class BlockDL
    {
        public static List<Block> blocks = new List<Block>();
        public static void addIntoList(Block b)
        {
            blocks.Add(b);
        }
        public static void addIntoDB(Block b)
        {
            try
            {

                string query = "INSERT INTO Block (BlockName, WarehouseId) VALUES (@BlockName, @WarehouseId)";
                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);
                command.Parameters.AddWithValue("@BlockName", b.blockName);
                command.Parameters.AddWithValue("@WarehouseId", b.warehouseId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Block added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add Block.");
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
                string query = "SELECT BlockId, BlockName, WarehouseId FROM Block";
                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int blockId = Convert.ToInt32(reader["BlockId"]);
                    string blockName = reader["BlockName"].ToString();
                    int warehouseId = Convert.ToInt32(reader["WarehouseId"]);

                    // Create ProductCategory object and add it to the categories list
                    Block b = new Block(blockId, blockName, warehouseId);
                    blocks.Add(b);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static Block getBlock(int id, int warehouseId = 1)
        {
            for (int i = 0; i < blocks.Count; i++)
            {
                if (warehouseId == blocks[i].warehouseId && id == blocks[i].blockId)
                {
                    return blocks[i];
                }
            }
            return null;
        }
    }
}
