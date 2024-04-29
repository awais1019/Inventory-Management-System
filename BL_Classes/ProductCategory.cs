using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class ProductCategory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ProductCategory(int categoryId, string name) 
        {
            this.CategoryName = name;
            this.CategoryID = categoryId;
        }
    }
}
