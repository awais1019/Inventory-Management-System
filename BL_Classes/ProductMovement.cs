using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    internal class ProductMovement
    {
        public int MovementID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string MovementType { get; set; }
        public DateTime MovementTime { get; set; }
    }
}
