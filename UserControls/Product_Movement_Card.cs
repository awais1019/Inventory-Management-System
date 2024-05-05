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
    public partial class Product_Movement_Card : UserControl
    {
        public Product_Movement_Card()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void setvalues(string name,string category,string manufacturer,string type,int qunatity,DateTime time)
        {
            label16.Text = name;
            label17.Text = category;
            label18.Text = manufacturer;    
            label19.Text = type;
            label20.Text = qunatity.ToString();
            label22.Text = time.ToString();
               

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
