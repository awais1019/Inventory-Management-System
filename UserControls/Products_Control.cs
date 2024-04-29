using Inventory_Management_System.BL_Classes;
using Inventory_Management_System.DL;
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
            setDataGridViewDataSource();
        }
        private void setDataGridViewDataSource()
        {
            foreach (var product in ProductDL.products)
            {
                int rowIndex = GridProduct.Rows.Add(); // Add a new row

                // Set the values of cells in the new row
                GridProduct.Rows[rowIndex].Cells["ProductName"].Value = product.ProductName;
                GridProduct.Rows[rowIndex].Cells["PurchaseRate"].Value = product.PurchaseRate;
                GridProduct.Rows[rowIndex].Cells["SellRate"].Value = product.SellRate;
                GridProduct.Rows[rowIndex].Cells["ProductQuantity"].Value = product.Quantity;
                ProductCategory cat = CategoryDL.getCategory(product.CategoryID);
                GridProduct.Rows[rowIndex].Cells["ProductCategory"].Value = cat.CategoryName;
                Manufacturer man = ManufacturerDL.getManufacturer(product.ManufacturerID);
                
                GridProduct.Rows[rowIndex].Cells["ProductManufacturer"].Value = man.CompanyName;
                GridProduct.Rows[rowIndex].Cells["ProductId"].Value = product.ProductID;

                // Apply cell styling
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = Color.White;
                cellStyle.ForeColor = Color.FromArgb(0, 118, 212);
                cellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic);
                foreach (DataGridViewCell cell in GridProduct.Rows[rowIndex].Cells)
                {
                    cell.Style.ApplyStyle(cellStyle);
                }

            }
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
        private List<int> selectedProduct()
        {
            List<int> selectedProduct = new List<int>();

            // Iterate through the rows of the DataGridView
            foreach (DataGridViewRow row in GridProduct.Rows)
            {
                // Check if the checkbox cell is selected for the current row
                DataGridViewCheckBoxCell checkboxCell = row.Cells["ProductCheckbox"] as DataGridViewCheckBoxCell;
                bool isSelected = Convert.ToBoolean(checkboxCell.Value);

                if (isSelected)
                {
                    int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                    selectedProduct.Add(productId);
                }
            }
            return selectedProduct;
        }
        private void Delete_Product_Click(object sender, EventArgs e)
        {
            List<int> products = selectedProduct();
            foreach (int i in products)
            {
                
                ProductDL.deleteFromList(i);
                ProductDL.deleteFromDB(i);
            }
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
