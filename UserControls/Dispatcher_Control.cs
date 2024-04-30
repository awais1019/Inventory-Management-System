using Inventory_Management_System.BL_Classes;
using Inventory_Management_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using UserControl = System.Windows.Forms.UserControl;

namespace Inventory_Management_System
{


    public partial class Dispatcher_Control : UserControl
    {
        public Dispatcher_Control()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
          ;
        }

     

        private void Check_Cart_btn_Click_1(object sender, EventArgs e)
        {
            back_btn.Visible = true;
            searchbox.Visible = false;
            panel2.Controls.Clear();
            Cart_Control control = new Cart_Control();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
            edit_btn.Visible = true;
            delete_btn.Visible = true;
            Add_btn.Visible = false;
            Check_Cart_btn.Visible = false;
            Done_btn.Visible = true;
        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            searchbox.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(GridProduct);
            Add_btn.Visible = true;
            edit_btn.Visible = false;
            delete_btn.Visible = false;
            Check_Cart_btn.Visible = true;
            back_btn.Visible = false;
            Done_btn.Visible = false;
            guna2Shapes2.Visible = true;
            guna2Shapes1.Visible = true;
            name_txt.Visible = true;
            quantity_product_txtbox.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void Done_btn_Click_2(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Transportation_Control control = new Transportation_Control();
            Done_btn.Visible = false;
            edit_btn.Visible = false;
            delete_btn.Visible = false;
            guna2Shapes2.Visible = false;
            guna2Shapes1.Visible = false;
            name_txt.Visible = false;
            quantity_product_txtbox.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
        }
    }
}
