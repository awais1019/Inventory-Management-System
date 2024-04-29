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
    public partial class Products_Control : UserControl
    {
        public Products_Control()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Product_btn_Click(object sender, EventArgs e)
        {
            Add_Products add_Products = new Add_Products();
            back_btn.Visible = true;
            Add_Product_btn.Visible = false;
            panel2.Controls.Clear();
            add_Products.Dock = DockStyle.Fill;
            searchbox.Visible = false;
            Delete_Product.Visible = false;
            panel2.Controls.Add(add_Products);
   

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void status_bar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void count_students_label_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Product_Click(object sender, EventArgs e)
        {

        }

      

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(GridProduct);
            back_btn.Visible = false;
            Add_Product_btn.Visible = true;
            searchbox.Visible = true;
            Delete_Product.Visible = true;
           
           
        }
    }
}
