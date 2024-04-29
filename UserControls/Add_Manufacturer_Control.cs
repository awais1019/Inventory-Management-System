using Inventory_Management_System.BL_Classes;
using Inventory_Management_System.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.UserControls
{
    public partial class Add_Manufacturer_Control : UserControl
    {
        public Add_Manufacturer_Control()
        {
            InitializeComponent();
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            string name = Manufacturer_txtbox.Text;
            string email = email_box.Text;
            string phone = phone_txtbox.Text;
            string location = location_txtbox.Text;
            if (name != null && email != null && phone != null && location != null)
            {
                Manufacturer manufacturer = new Manufacturer(name, email, phone, location);
                ManufacturerDL.addManufacturerIntoDB(manufacturer);
                ManufacturerDL.addManufacturerIntoList(manufacturer);
            }
        }

    }
}
