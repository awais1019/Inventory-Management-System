using Guna.UI2.WinForms;
using Inventory_Management_System.BL_Classes;
using Inventory_Management_System.DL;
using Inventory_Management_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseManager.openConnection();
            WarehouseDL.loadIntoList();
            BlockDL.loadIntoList();
            CategoryDL.getCategoryFromDB();
            ShelfDL.loadIntoList();
            ManufacturerDL.loadDataIntoList();
           // MessageBox.Show(ManufacturerDL.getManufacturer(1).CompanyName.ToString());
            ProductDL.loadDataIntoList();
            ProductShelfDL.loadIntoList();
            ProductMovementDL.loadIntoList();
            TransportationDL.loadIntoList();
            DispatchDL.loadIntoList();
            DispatchDetailDL.loadIntoList();
        }
        
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            sidepicture.Location = new Point(b.Location.X + 118, b.Location.Y - 30);
            sidepicture.SendToBack();
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            setMenu(new Home_Control(), "Home");
        }

   

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Close Application", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Close Application", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void setMenu(Control control, string header_name)
        {

            main_panel.Controls.Clear();
            label_header_main.Text = header_name;
            main_panel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
        private void products_btn_Click(object sender, EventArgs e)
        {
            setMenu(new Products_Control(), "Products");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setMenu(new Home_Control(), "Home");
        }

        private void manufacturer_btn_Click(object sender, EventArgs e)
        {
            setMenu(new Manufacturer_Control(), "Manufacturers");
          
        }

        private void dispatch_btn_Click(object sender, EventArgs e)
        {
            setMenu(new Dispatcher_Control(), "Dispatcher");
        }

        private void storage_btn_Click(object sender, EventArgs e)
        {
            setMenu(new Storage_Control(), "Storage");
        }

        private void storage_btn_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void History_btn_Click(object sender, EventArgs e)
        {
            setMenu(new History_Control(), "History");
        }
    }
}
