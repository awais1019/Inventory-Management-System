using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class ProductMovement
    {
        public int movementID { get; set; }
        public int productID { get; set; }
        public int quantity { get; set; }
        public string movementType { get; set; }
        public DateTime movementTime { get; set; }
        public ProductMovement(int movementID, int productID, int quantity, string movementType, DateTime movementTime)
        {
            this.movementID = movementID;
            this.productID = productID;
            this.quantity = quantity;
            this.movementType = movementType;
            this.movementTime = movementTime;
        }
        public ProductMovement(int productID, int quantity, string movementType, DateTime movementTime)
        {
            this.productID = productID;
            this.quantity = quantity;
            this.movementType = movementType;
            this.movementTime = movementTime;
        }
    }
}
