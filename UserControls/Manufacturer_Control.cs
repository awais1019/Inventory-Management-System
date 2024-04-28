using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.UserControls
{
    public partial class Manufacturer_Control : UserControl
    {
        public Manufacturer_Control()
        {
            InitializeComponent();
        }

        private void Add_Manufacturers_btn_Click(object sender, EventArgs e)
        {
            Add_Manufacturer_Control control = new Add_Manufacturer_Control();
            back_btn.Visible = true;
            Add_Manufacturers_btn.Visible = false;
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            Searchbox.Visible = false;
            Delete_Manufacturers_btn.Visible = false;
            panel2.Controls.Add(control);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(GridManufacturer);
            back_btn.Visible = false;
            Add_Manufacturers_btn.Visible = true;
            Searchbox.Visible = true;
            Delete_Manufacturers_btn.Visible = true;

        }
    }
}
