using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    internal class Dispatch
    {
        public int DispatchID { get; set; }
        public DateTime DispatchDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int TransportationID { get; set; }
    }
}
