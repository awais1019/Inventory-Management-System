using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class Block
    {
        public int blockId { get; set; }
        public string blockName { get; set; }
        public int warehouseId { get; set; }
        public Block(int blockId, string blockName, int warehouseId)
        {
            this.blockId = blockId;
            this.blockName = blockName;
            this.warehouseId = warehouseId;
        }
        public Block(string blockName, int warehouseId)
        {
            this.blockName = blockName;
            this.warehouseId = warehouseId;
        }
    }
}
