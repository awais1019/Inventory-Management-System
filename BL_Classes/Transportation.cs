using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class Transportation
    {
        public int TransportationID { get; set; }
        public string VehicleName { get; set; }
        public string DriverName { get; set; }
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        public Transportation(int TransportationId, string vehicleName, string driverName, string departureLocation, string arrivalLocation)
        {
            this.TransportationID = TransportationId;
            this.VehicleName = vehicleName;
            this.DriverName = driverName;
            this.DepartureLocation = departureLocation;
            this.ArrivalLocation = arrivalLocation;
        }
        public Transportation(string vehicleName, string driverName, string departureLocation, string arrivalLocation)
        {
            this.VehicleName = vehicleName;
            this.DriverName = driverName;
            this.DepartureLocation = departureLocation;
            this.ArrivalLocation = arrivalLocation;
        }

    }
}
