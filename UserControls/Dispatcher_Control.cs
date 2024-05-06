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
using System.Web.UI;
using System.Windows.Forms;
using UserControl = System.Windows.Forms.UserControl;

namespace Inventory_Management_System
{


    public partial class Dispatcher_Control : UserControl
    {
        public static int prodId;
        private int currentPage = 1;
        private int pageSize = 20;
        public Dispatcher_Control()
        {
            InitializeComponent();
           // setDataGridViewDataSource();
            txtTotalBill.Visible = false;
            label7.Visible = false;
            
        }

       

        private async Task LoadProducts(int page)
        {
            // Clear existing rows before loading new data
            GridProduct.Rows.Clear();

            // Filter products based on quantity and calculate the index range for the current page
            var filteredProducts = ProductDL.products.Where(product => product.Quantity > 0);
            int startIndex = (page - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, filteredProducts.Count());

            // Iterate over products for the current page
            for (int i = startIndex; i < endIndex; i++)
            {
                var product = filteredProducts.ElementAt(i);
                int rowIndex = GridProduct.Rows.Add(); // Add a new row

                // Set the values of cells in the new row
                GridProduct.Rows[rowIndex].Cells["productName"].Value = product.ProductName;
                GridProduct.Rows[rowIndex].Cells["purchaseRate"].Value = product.PurchaseRate;
                GridProduct.Rows[rowIndex].Cells["sellRate"].Value = product.SellRate;
                GridProduct.Rows[rowIndex].Cells["quantity"].Value = product.Quantity;

                // Fetch category and manufacturer
                ProductCategory cat = CategoryDL.getCategory(product.CategoryID);
                Manufacturer man = ManufacturerDL.getManufacturer(product.ManufacturerID);

                // Set category, manufacturer, and product ID
                GridProduct.Rows[rowIndex].Cells["category"].Value = cat.CategoryName;
                GridProduct.Rows[rowIndex].Cells["manufacturer"].Value = man.CompanyName;
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

        private async Task NextPage()
        {
            currentPage++;
            await LoadProducts(currentPage);
        }

        private async Task PreviousPage()
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadProducts(currentPage);
            }
        }

       






        private void back_btn_Click(object sender, EventArgs e)
        {
          ;
        }
        public void setTotalValue()
        {
            decimal totalValue = 0;
            foreach (Product i in ProductDL.cartList)
            {
                totalValue += i.Quantity * i.SellRate;
            }
            txtTotalBill.Text = totalValue.ToString();
            txtTotalBill.Visible = true;
            label7.Visible = true;
        }
        private void selectedProduct()
        {
           
            foreach (DataGridViewRow row in GridProduct.Rows)
            {
                // Check if the checkbox cell is selected for the current row
                DataGridViewCheckBoxCell checkboxCell = row.Cells["CheckBox"] as DataGridViewCheckBoxCell;
                bool isSelected = Convert.ToBoolean(checkboxCell.Value);

                if (isSelected)
                {
                    int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                }
            }
            
        }
        //private void setDataGridViewDataSource()
        //{
        //    
        //    foreach (var product in ProductDL.products)
        //    {
        //        if (product.Quantity > 0)
        //        {
        //
        //        int rowIndex = GridProduct.Rows.Add(); // Add a new row
        //
        //        // Set the values of cells in the new row
        //        GridProduct.Rows[rowIndex].Cells["productName"].Value = product.ProductName;
        //        GridProduct.Rows[rowIndex].Cells["purchaseRate"].Value = product.PurchaseRate;
        //        GridProduct.Rows[rowIndex].Cells["sellRate"].Value = product.SellRate;
        //        GridProduct.Rows[rowIndex].Cells["quantity"].Value = product.Quantity;
        //        ProductCategory cat = CategoryDL.getCategory(product.CategoryID);
        //        GridProduct.Rows[rowIndex].Cells["category"].Value = cat.CategoryName;
        //        Manufacturer man = ManufacturerDL.getManufacturer(product.ManufacturerID);
        //
        //        GridProduct.Rows[rowIndex].Cells["manufacturer"].Value = man.CompanyName;
        //        GridProduct.Rows[rowIndex].Cells["ProductId"].Value = product.ProductID;
        //
        //        // Apply cell styling
        //        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
        //        cellStyle.BackColor = Color.White;
        //        cellStyle.ForeColor = Color.FromArgb(0, 118, 212);
        //        cellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic);
        //        foreach (DataGridViewCell cell in GridProduct.Rows[rowIndex].Cells)
        //        {
        //            cell.Style.ApplyStyle(cellStyle);
        //        }
        //        }
        //
        //    }
        //}


        private void Check_Cart_btn_Click_1(object sender, EventArgs e)
        {
            back_btn.Visible = true;
            searchbox.Visible = false;
            panel2.Controls.Clear();
            Cart_Control control = new Cart_Control(this);
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
            txtTotalBill.Visible = false;
            label7.Visible = false;
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

        private void GridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void GridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the clicked row
            DataGridViewRow row = GridProduct.Rows[e.RowIndex];

            // Get the productId of the clicked row
            int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
            prodId = productId;
            // Show the productId in a message box
            setValue(productId);
        }
        public void setValue(int pid)
        {
            Product p = ProductDL.getProduct(pid);
            name_txt.Text = p.ProductName;
            name_txt.ReadOnly = true;
            
            
        }
        public void setCartValue(int pid)
        {
            Product p = ProductDL.getCart(pid);
            name_txt.Text = p.ProductName;
            quantity_product_txtbox.Text = p.Quantity.ToString();

        }
        
        private void Add_btn_Click(object sender, EventArgs e)
        {
            
            string quantity = quantity_product_txtbox.Text;
            Product p = ProductDL.getProduct(prodId);

            if (quantity != null && p != null)
            {
                int quant = int.Parse(quantity);
                
                if (quant <= p.Quantity)
                {
                    
                    Product newP = new Product(p.ProductID, p.ManufacturerID, p.ProductName, p.CategoryID, p.PurchaseRate, p.SellRate, quant, p.ThresholdQuantity, quant * p.SellRate, p.AddedAt);
                    if (ProductDL.isAlreadyIntoCartList(newP))
                    {
                        MessageBox.Show("Product Updated Successfully");
                        return;
                    }
                    ProductDL.cartList.Add(newP);
                    MessageBox.Show("Product Added Successfully");
                   
                }

            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            
            if (ProductDL.deleteFromCartList(prodId))
            {
                MessageBox.Show("Deleted Successfully");
                return;
            }
            MessageBox.Show("Product Not Found");
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string quant = quantity_product_txtbox.Text;
            int quantity = int.Parse(quant);
            Product p = ProductDL.getProduct(prodId);
            if (quantity < p.Quantity)
            {
                Product cart = ProductDL.getCart(prodId);
                cart.Quantity = quantity;
                MessageBox.Show("Edited Successfully");
                return;
            }
            else if (quantity > p.Quantity || quantity == 0)
            {
                MessageBox.Show("Invalid Quantity");
                return;
            }
        }

        private void quantity_product_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

       //private void Loadbtn_Click(object sender, EventArgs e)
       //{
       //
       //}
       //
       //private void nextBtn_Click(object sender, EventArgs e)
       //{
       //
       //}
       //
       //private void prevBtn_Click(object sender, EventArgs e)
       //{
       //
       //}
        private async void Loadbtn_Click(object sender, EventArgs e)
        {
            currentPage = 1; // Reset to first page
            await LoadProducts(currentPage);
        }

        private async void nextBtn_Click(object sender, EventArgs e)
        {
            await NextPage();
        }

        private async void prevBtn_Click(object sender, EventArgs e)
        {
            await PreviousPage();
        }


    }
}
