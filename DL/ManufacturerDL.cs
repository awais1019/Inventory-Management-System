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
    public static class ManufacturerDL
    {
        public static List<Manufacturer> manufacturers = new List<Manufacturer>();
        public static void addManufacturerIntoDB(Manufacturer manufacturer)
        {
            try
            {

                string query = "INSERT INTO Manufacturer (CompanyName, Email, Phone, Location) VALUES (@Name, @Email, @Phone, @Location)";
                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);
                command.Parameters.AddWithValue("@Name", manufacturer.CompanyName);
                command.Parameters.AddWithValue("@Email", manufacturer.Email);
                command.Parameters.AddWithValue("@Phone", manufacturer.Phone);
                command.Parameters.AddWithValue("@Location", manufacturer.Location);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Manufacturer added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add manufacturer.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public static void addManufacturerIntoList(Manufacturer manufacturer)
        {
            manufacturers.Add(manufacturer);
        }
        public static void loadDataIntoList()
        {
            try
            {

                string query = "SELECT * FROM Manufacturer";
                SqlCommand command = new SqlCommand(query, DatabaseManager.connection);
                SqlDataReader reader = command.ExecuteReader();

                // Clear the existing list before loading new data
                manufacturers.Clear();

                while (reader.Read())
                {
                    int manufacturerID = Convert.ToInt32(reader["ManufacturerID"]);
                    string companyName = reader["CompanyName"].ToString();
                    string email = reader["Email"].ToString();
                    string phone = reader["Phone"].ToString();
                    string location = reader["Location"].ToString();

                    // Create Manufacturer object and add it to the manufacturers list
                    Manufacturer manufacturer = new Manufacturer(manufacturerID ,companyName, email, phone, location); // Assuming ProductCategoryID is not relevant here
                    manufacturers.Add(manufacturer);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void deleteFromList(int id)
        {
            Manufacturer man = getManufacturer(id);
            if (manufacturers != null)
            {
                foreach(Manufacturer i in  manufacturers)
                {
                    if (i == man)
                    {
                        manufacturers.Remove(i);
                        return;
                    }
                }
            }
        }
        public static Manufacturer getManufacturer(int id)
        {
            int len = manufacturers.Count;
            for (int i = 0; i < len; i++)
            {
                if (id == manufacturers[i].ManufacturerID)
                {
                    return manufacturers[i];
                }
            }
            return null;
        }
        public static void deleteFromDB(int id)
        {
            try
            {
                string deleteCommandText = "DELETE FROM Manufacturer WHERE ManufacturerID = @ManufacturerID";
                SqlCommand command = new SqlCommand(deleteCommandText, DatabaseManager.connection);

                // Add parameters to the command
                command.Parameters.AddWithValue("@ManufacturerID", id);

                // Execute the DELETE command
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Manufacturer with ID {id} deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"Manufacturer with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}
