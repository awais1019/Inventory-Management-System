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
    public static class DispatchDL
    {
        public static List<Dispatch> dispatches = new List<Dispatch>();
        public static void addIntoList(Dispatch d)
        {
            dispatches.Add(d);
        }
        public static int addIntoDB(Dispatch d)
        {
            try
            {
                SqlCommand command = new SqlCommand("spAddDispatch", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                command.Parameters.AddWithValue("@DispatchDate", d.DispatchDate);
                command.Parameters.AddWithValue("@TotalAmount", d.TotalAmount);
                command.Parameters.AddWithValue("@TransportationID", d.TransportationID);
                command.Parameters.Add("@DispatchID", SqlDbType.Int).Direction = ParameterDirection.Output;

                // Execute the command
                command.ExecuteNonQuery();

                // Retrieve the DispatchID of the newly inserted record
                int insertedDispatchId = Convert.ToInt32(command.Parameters["@DispatchID"].Value);

                // Update the DispatchID of the Dispatch object
                d.DispatchID = insertedDispatchId;
                dispatches.Add(d);
                return insertedDispatchId;
            }
            catch (Exception ex)
            {
                // Handle any errors that may have occurred
                MessageBox.Show(ex.Message);
            }
            return 0;
        }
        public static void updateIntoList(int did, decimal totalAmount)
        {
            for (int i = 0; i < dispatches.Count; i++)
            {
                if (dispatches[i].DispatchID == did)
                {
                    dispatches[i].TotalAmount = totalAmount;
                    return;
                }
            }
        }
        public static void updateIntoDB(int did, decimal totalAmount)
        {
            try
            {
                SqlCommand command = new SqlCommand("spUpdateDispatch", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                command.Parameters.AddWithValue("@DispatchID", did);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);

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
                SqlCommand command = new SqlCommand("spLoadDisptach", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;

                // Execute the command
                SqlDataReader reader = command.ExecuteReader();

                // Clear the list
                dispatches.Clear();

                // Load the list from the data reader
                while (reader.Read())
                {
                    int dispatchId = Convert.ToInt32(reader["DispatchID"]);
                    DateTime dispatchDate = Convert.ToDateTime(reader["DispatchDate"]);
                    decimal totalAmount = Convert.ToDecimal(reader["TotalAmount"]);
                    int transportationId = Convert.ToInt32(reader["TransportationID"]);

                    Dispatch d = new Dispatch(dispatchId, dispatchDate, totalAmount, transportationId);
                    dispatches.Add(d);
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
