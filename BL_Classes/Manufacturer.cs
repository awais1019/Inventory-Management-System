using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class Manufacturer
    {
        public int ManufacturerID { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public Manufacturer(int manufacturerID, string companyName, string email, string phone, string location)
        {
            this.ManufacturerID = manufacturerID;
            this.CompanyName = companyName;
            this.Email = email;
            this.Phone = phone;
            this.Location = location;
        }
        public Manufacturer( string companyName, string email, string phone,string location)
        {
            this.CompanyName = companyName;
            this.Email = email;
            this.Phone = phone;
            this.Location = location;
        }
    }
}
