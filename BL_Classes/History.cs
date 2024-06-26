﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class History
    {
        public string name {  get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public decimal totalPrice { get; set; }
        public string category { get; set; }
        public string manufacturer { get; set; }

        public History() { }
        public History(string name, decimal price, int quantity, decimal totalPrice, string category, string manufacturer)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
            this.category = category;
            this.manufacturer = manufacturer;
        }
    }
}
