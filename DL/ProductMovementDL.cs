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
                if (id > 0)
                {
                    //MessageBox.Show("Manufacturer added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add Product Movements.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
