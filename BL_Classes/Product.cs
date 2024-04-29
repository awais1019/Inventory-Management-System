using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class Product
    {
        public int ProductID { get; set; }
        public int ManufacturerID { get; set; }
        public int shelfId { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SellRate { get; set; }
        public int Quantity { get; set; }
        public int ThresholdQuantity { get; set; }
        public DateTime AddedAt { get; set; }
        public Product(int productID, int manufacturerID, int shelfId ,string productName, int categoryID, decimal purchaseRate, decimal sellRate, int quantity, int thresholdQuantity, DateTime addedAt)
        {
            ProductID = productID;
            ManufacturerID = manufacturerID;
            this.shelfId = shelfId;
            ProductName = productName;
            CategoryID = categoryID;
            PurchaseRate = purchaseRate;
            SellRate = sellRate;
            Quantity = quantity;
            ThresholdQuantity = thresholdQuantity;
            AddedAt = addedAt;
        }
        public Product(int manufacturerID, string productName, int shelfId, int categoryID, decimal purchaseRate, decimal sellRate, int quantity, int thresholdQuantity, DateTime addedAt)
        {
            this.shelfId = shelfId;
            ManufacturerID = manufacturerID;
            ProductName = productName;
            CategoryID = categoryID;
            PurchaseRate = purchaseRate;
            SellRate = sellRate;
            Quantity = quantity;
            ThresholdQuantity = thresholdQuantity;
            AddedAt = addedAt;
        }
    }
}
