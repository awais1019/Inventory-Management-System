using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class DispatchDetail
    {
        public int DispatchID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DispatchDetail(int DispactID, int ProductID, int Quantity, decimal UnitPrice, decimal totalPrice)
        {
            this.DispatchID = DispactID;
            this.ProductID = ProductID;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
            this.TotalPrice = totalPrice;
        }
    }
}
