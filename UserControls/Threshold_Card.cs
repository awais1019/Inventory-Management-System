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
    public partial class Threshold_Card : UserControl
    {
        public Threshold_Card()
        {
            InitializeComponent();
        }

        public void setvalues(string name,string category,string manufacturer)
        {
            lbl_name.Text=name; lbl_category.Text=category; lbl_manufacturer.Text=manufacturer;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }
    }
}
