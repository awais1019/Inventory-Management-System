using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class ProductShelf
    {
        public int productId {  get; set; }
        public int shelfId { get; set;}
        public int quantity { get; set; }
        public ProductShelf(int productId, int shelfId, int quantity)
        {
            this.productId = productId;
            this.shelfId = shelfId;
            this.quantity = quantity;
        }
    }
}
