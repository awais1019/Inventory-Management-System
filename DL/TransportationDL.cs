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
    public static class TransportationDL
    {
        public static List<Transportation> transportations = new List<Transportation>();
        public static void addIntoList(Transportation t)
        {
            transportations.Add(t);
        }
        public static int addIntoDB(Transportation t)
        {
            try
            {
                SqlCommand command = new SqlCommand("spAddTransportation", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                command.Parameters.AddWithValue("@VehicleName", t.VehicleName);
                command.Parameters.AddWithValue("@DriverName", t.DriverName);
                command.Parameters.AddWithValue("@DepartureLocation", t.DepartureLocation);
                command.Parameters.AddWithValue("@ArrivalLocation", t.ArrivalLocation);
                command.Parameters.Add("@TransportationId", SqlDbType.Int).Direction = ParameterDirection.Output;

                // Execute the command
                command.ExecuteNonQuery();

                // Retrieve the TransportationId of the newly inserted record
                int insertedTransportationId = Convert.ToInt32(command.Parameters["@TransportationId"].Value);

                // Update the TransportationId of the Transportation object
                t.TransportationID = insertedTransportationId;
                transportations.Add(t);
                return insertedTransportationId;
            }
            catch (Exception ex)
            {
                // Handle any errors that may have occurred
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        public static void loadIntoList()
        {
            try
            {
                SqlCommand command = new SqlCommand("spLoadTransportations", DatabaseManager.connection);
                command.CommandType = CommandType.StoredProcedure;

                // Execute the command
                SqlDataReader reader = command.ExecuteReader();

                // Clear the list
                transportations.Clear();

                // Load the list from the data reader
                while (reader.Read())
                {
                    int transportationId = Convert.ToInt32(reader["TransportationID"]);
                    string vehicleName = reader["VehicleName"].ToString();
                    string driverName = reader["DriverName"].ToString();
                    string departureLocation = reader["DepartureLocation"].ToString();
                    string arrivalLocation = reader["ArrivalLocation"].ToString();

                    Transportation t = new Transportation(transportationId, vehicleName, driverName, departureLocation, arrivalLocation);
                    transportations.Add(t);
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
