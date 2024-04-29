using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    internal class Transportation
    {
        public int TransportationID { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
    }
}
