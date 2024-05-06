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
        public int shelfId;
        private int currentPage = 1;
        private int pageSize = 20;
        public Products_Control()
        {
            InitializeComponent();
            setProductCount();
        }
        private void setProductCount()
        {
            count_students_label.Text = ProductDL.products.Count.ToString();
        }

        

        private async Task LoadProductsAsync(int page)
        {
            // Clear existing rows before loading new data
            GridProduct.Rows.Clear();

            // Calculate the index range for the current page
            int startIndex = (page - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, ProductDL.products.Count);

            // Iterate over products for the current page
            for (int i = startIndex; i < endIndex; i++)
            {
                var product = ProductDL.products[i];
                int rowIndex = GridProduct.Rows.Add(); // Add a new row

                // Set the values of cells in the new row
                GridProduct.Rows[rowIndex].Cells["ProductName"].Value = product.ProductName;
                GridProduct.Rows[rowIndex].Cells["PurchaseRate"].Value = product.PurchaseRate;
                GridProduct.Rows[rowIndex].Cells["SellRate"].Value = product.SellRate;
                GridProduct.Rows[rowIndex].Cells["ProductQuantity"].Value = product.Quantity;

                // Fetch category asynchronously
                var cat = await Task.Run(() => CategoryDL.getCategory(product.CategoryID));
                GridProduct.Rows[rowIndex].Cells["ProductCategory"].Value = cat.CategoryName;

                // Fetch manufacturer asynchronously
                var man = await Task.Run(() => ManufacturerDL.getManufacturer(product.ManufacturerID));
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

        private async Task NextPageAsync()
        {
            currentPage++;
            await LoadProductsAsync(currentPage);
        }

        private async Task PreviousPageAsync()
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadProductsAsync(currentPage);
            }
        }

       
        


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Product_btn_Click(object sender, EventArgs e)
        {
            Loadbtn.Visible = false;
            nextBtn.Visible= false;
            prevBtn.Visible= false;
            Add_Products add_Products = new Add_Products();
            back_btn.Visible = true;
            Add_Product_btn.Visible = false;
            panel2.Controls.Clear();
            add_Products.Dock = DockStyle.Fill;
            searchbox.Visible = false;
            Delete_Product.Visible = false;
            //btnUpdate.Visible = false;
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
                ProductMovementDL.deleteProductMovementIntoListbyPid(i);
                ProductMovementDL.deleteProductMovementIntoDBbyPid(i);
                ProductShelfDL.deleteProductShelfFromList(i);
                ProductShelfDL.deleteProductShelfFromDBbyPid(i);
                ProductDL.deleteFromList(i);
                ProductDL.deleteFromDB(i);
            }
        }

      

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Loadbtn.Visible = true;
            nextBtn.Visible = true;
            prevBtn.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(GridProduct);
            back_btn.Visible = false;
            Add_Product_btn.Visible = true;
            searchbox.Visible = true;
            Delete_Product.Visible = true;
            //btnUpdate.Visible = true;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<int> sp = selectedProduct();
            if (sp.Count == 1)
            {
                Add_Products add_Products = new Add_Products("update", sp[0]);
                back_btn.Visible = true;
                Add_Product_btn.Visible = false;
                panel2.Controls.Clear();
                add_Products.Dock = DockStyle.Fill;
                searchbox.Visible = false;
                Delete_Product.Visible = false;
                //btnUpdate.Visible = false;
                panel2.Controls.Add(add_Products);
            }
            else
            {
                MessageBox.Show("Select Only one product to update!");
            }
        }

        private void GridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Loadbtn_Click(object sender, EventArgs e)
        {
            currentPage = 1; // Reset to first page
            await LoadProductsAsync(currentPage);
        }

        private async void nextBtn_Click(object sender, EventArgs e)
        {
            await NextPageAsync();
        }

        private async void prevBtn_Click(object sender, EventArgs e)
        {
            await PreviousPageAsync();
        }
    }
}
