using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class Shelf
    {
        public int shelfId {  get; set; }
        public int capacity { get; set; }
        public int currentCapacity { get; set; }
        public int categoryId { get; set; }
        public int blockId { get; set; }
        public Shelf(int shelfId, int capacity, int currentCapacity, int categoryId, int blockId)
        {
            this.shelfId = shelfId;
            this.capacity = capacity;
            this.currentCapacity = currentCapacity;
            this.categoryId = categoryId;
            this.blockId = blockId;
        }
    }
}
