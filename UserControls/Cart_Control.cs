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
    public partial class Cart_Control : UserControl
    {
        private Dispatcher_Control _dispatcherControl;
        public Cart_Control(Dispatcher_Control dispatcherControl)
        {
            InitializeComponent();
            setCartGridDataSource();
            _dispatcherControl = dispatcherControl;
            _dispatcherControl.setTotalValue();
        }
        private void setCartGridDataSource()
        {
            foreach (var product in ProductDL.cartList)
            {
                if (product.Quantity > 0)
                {

                    int rowIndex = CartGrid.Rows.Add(); // Add a new row

                    // Set the values of cells in the new row
                    CartGrid.Rows[rowIndex].Cells["productName"].Value = product.ProductName;
                    CartGrid.Rows[rowIndex].Cells["purchaseRate"].Value = product.PurchaseRate;
                    CartGrid.Rows[rowIndex].Cells["sellRate"].Value = product.SellRate;
                    CartGrid.Rows[rowIndex].Cells["quantity"].Value = product.Quantity;
                    ProductCategory cat = CategoryDL.getCategory(product.CategoryID);
                    CartGrid.Rows[rowIndex].Cells["category"].Value = cat.CategoryName;
                    Manufacturer man = ManufacturerDL.getManufacturer(product.ManufacturerID);

                    CartGrid.Rows[rowIndex].Cells["manufacturer"].Value = man.CompanyName;
                    CartGrid.Rows[rowIndex].Cells["ProductId"].Value = product.ProductID;
                    CartGrid.Rows[rowIndex].Cells["TotalPrice"].Value = product.Quantity * product.SellRate;

                    // Apply cell styling
                    DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                    cellStyle.BackColor = Color.White;
                    cellStyle.ForeColor = Color.FromArgb(0, 118, 212);
                    cellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic);
                    foreach (DataGridViewCell cell in CartGrid.Rows[rowIndex].Cells)
                    {
                        cell.Style.ApplyStyle(cellStyle);
                    }
                }

            }
        }

        private void CartGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the clicked row
            DataGridViewRow row = CartGrid.Rows[e.RowIndex];
            
            // Get the productId of the clicked row
            int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
            // Show the productId in a message box
            _dispatcherControl.setCartValue(productId);


        }
       
    }
}
