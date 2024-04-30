using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class Warehouse
    {
        public int warehouseId {  get; set; }
        public string warehouseName { get; set; }
        public Warehouse(int warehouseId, string warehouseName)
        {
            this.warehouseId = warehouseId;
            this.warehouseName = warehouseName;
        }
    }
}
