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
    public static class DispatchDetailDL
    {
        public static List<DispatchDetail> dispatchDetails = new List<DispatchDetail>();
        public static void addIntoList(DispatchDetail d)
        {
            dispatchDetails.Add(d);
        }
        public static void addIntoDB(DispatchDetail dd)
        {
            try
            {
                SqlCommand command = new SqlCommand("spAddDispatchDetail", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                command.Parameters.AddWithValue("@DispatchID", dd.DispatchID);
                command.Parameters.AddWithValue("@ProductID", dd.ProductID);
                command.Parameters.AddWithValue("@Quantity", dd.Quantity);
                command.Parameters.AddWithValue("@UnitPrice", dd.UnitPrice);
                command.Parameters.AddWithValue("@TotalPrice", dd.TotalPrice);
                
                // Execute the command
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle any errors that may have occurred
                MessageBox.Show(ex.Message);
            }
        }
        public static void loadIntoList()
        {
            try
            {
                SqlCommand command = new SqlCommand("spLoadDisptachDetails", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;

                // Execute the command
                SqlDataReader reader = command.ExecuteReader();

                // Clear the list
                dispatchDetails.Clear();

                // Load the list from the data reader
                while (reader.Read())
                {
                    int dispatchId = Convert.ToInt32(reader["DispatchID"]);
                    int productId = Convert.ToInt32(reader["ProductID"]);
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    decimal unitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                    decimal totalPrice = Convert.ToDecimal(reader["TotalPrice"]);

                    DispatchDetail dd = new DispatchDetail(dispatchId, productId, quantity, unitPrice, totalPrice);
                    dispatchDetails.Add(dd);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors that may have occurred
                MessageBox.Show(ex.Message);
            }
        }

    }
}
