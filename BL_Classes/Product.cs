using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    internal class Product
    {
        public int ProductID { get; set; }
        public int ManufacturerID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SellRate { get; set; }
        public int Quantity { get; set; }
        public int ThresholdQuantity { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
