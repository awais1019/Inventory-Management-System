using Inventory_Management_System.BL_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.DL
{
    public static class ProductMovementDL
    {
        public static List<ProductMovement> productMovements = new List<ProductMovement>();
        public static void addIntoList(ProductMovement pm)
        {
            productMovements.Add(pm);
        }
        public static void addIntoDB(ProductMovement pm)
        {

            try
            {
                SqlCommand command = new SqlCommand("spAddProductMovement", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductId", pm.productID);
                command.Parameters.AddWithValue("@Quantity", pm.quantity);
                command.Parameters.AddWithValue("@MovementType", pm.movementType);
                command.Parameters.AddWithValue("@MovementTime", pm.movementTime);
                command.Parameters.Add("@MovementID", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                int id = Convert.ToInt32(command.Parameters["@MovementID"].Value);
                pm.movementID = id;
                productMovements.Add(pm);
                
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
                SqlCommand command = new SqlCommand("spGetAllproductMovements", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    int movementID = Convert.ToInt32(reader["movementID"]);
                    int productID = Convert.ToInt32(reader["productID"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    string movementType = reader["movementType"].ToString();
                    DateTime movementTime = Convert.ToDateTime(reader["movementTime"]);
                    ProductMovement pm = new ProductMovement(movementID, productID, quantity, movementType, movementTime);
                    productMovements.Add(pm);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
           
        }
        public static void deleteProductMovementIntoListbyPid(int pid)
        {
            foreach (ProductMovement pm in productMovements)
            {
                if (pm.productID == pid)
                {
                    productMovements.Remove(pm);
                    return;
                }
            }
        }
        public static void deleteProductMovementIntoDBbyPid(int pid)
        {
            try
            {
                SqlCommand command = new SqlCommand("spDeleteProductMovementByProductId", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductId", pid);

            
                int rowsAffected = command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }

    }
}
