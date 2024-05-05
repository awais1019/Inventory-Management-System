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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Inventory_Management_System.UserControls
{
    public partial class Add_Products : UserControl
    {
        Product product = null;
        public int ManufacturerID, CategoryID, Quantity, ThresholdQuantity = 10;
        public string ProductName;
        public decimal PurchaseRate, SellRate, TotalValue;
        public DateTime AddedAt;
        int ProductID;
        public Add_Products()
        {
            InitializeComponent();
            setCategoryComboBox();
            setManufacturerComboBox();
            setBlockComboBox();
            int blockid = (int)comboBlock.SelectedValue;
            List<Shelf> sh = ShelfDL.getShelvesByBlock(blockid);
            setShelfComboBox(sh);
            btnUpdateProduct.Visible = false;
            Add_btn.Visible = true;
        }
        public Add_Products(string update, int pid)
        {
            InitializeComponent();
            setCategoryComboBox();
            setManufacturerComboBox();
            setBlockComboBox();
            int blockid = (int)comboBlock.SelectedValue;
            List<Shelf> sh = ShelfDL.getShelvesByBlock(blockid);
            setShelfComboBox(sh);
            setUpdateValue(pid);
            btnUpdateProduct.Visible = true;
            Add_btn.Visible = false;
            ProductID = pid;

        }
        public void setUpdateValue(int pid)
        {
            Product p = ProductDL.getProduct(pid);
            product_txtbox.Text = p.ProductName;
            prate_txtbox.Text = p.PurchaseRate.ToString();
            sale_rate_txtbox.Text = p.SellRate.ToString();
            quantity_txtbox.Text = p.Quantity.ToString();
            


        }
        public void clearfieldes()
        {
            product_txtbox.Text = "";
            prate_txtbox.Text = "";
            sale_rate_txtbox.Text = "";
            quantity_txtbox.Text = "";
            category_combo_box.SelectedIndex = -1;
            manufacturer_combo_box.SelectedIndex = -1;
        }
        private Product CheckFields()
        {
            if (product_txtbox.Text == "" || prate_txtbox.Text == "" || sale_rate_txtbox.Text == ""
            || quantity_txtbox.Text == "")
            {
                MessageBox.Show("Kindly Fill All Above Fields!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (category_combo_box.SelectedIndex != -1 || manufacturer_combo_box.SelectedIndex != -1)
            {
                string selectedCategory = category_combo_box.SelectedItem.ToString();
                string selectedManufacturer = manufacturer_combo_box.SelectedItem.ToString();

                ProductName = product_txtbox.Text;
                PurchaseRate = decimal.Parse(prate_txtbox.Text);
                SellRate = decimal.Parse(sale_rate_txtbox.Text);
                Quantity = int.Parse(quantity_txtbox.Text);
                CategoryID = category_combo_box.SelectedIndex;

                ManufacturerID = manufacturer_combo_box.SelectedIndex;
                /*int id = DataBase.GetStatusIdOne(selectedStatus);
                if (id != -1)
                {
                    Student student = new Student(first_name, last_name, registration_number, email, contact, id);
                    return student;

                }*/

            }
            else
            {
                MessageBox.Show("Kindly Select a IDs from the combo boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void comboBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int blockid = (int)comboBlock.SelectedValue;
            List<Shelf> sh = ShelfDL.getShelvesByBlock(blockid);
            setShelfComboBox(sh);

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string productName = product_txtbox.Text;
            string purchaseRate = prate_txtbox.Text;
            string sellRate = sale_rate_txtbox.Text;
            string quantity = quantity_txtbox.Text;
            int CategoryId = (int)category_combo_box.SelectedValue;
            int manufacturerId = (int)manufacturer_combo_box.SelectedValue;
            int blockid = (int)comboBlock.SelectedValue;
            int shelfid = (int)comboShelf.SelectedValue;
            Product product = ProductDL.getProduct(ProductID);

            if (productName != null && purchaseRate != null && sellRate != null && quantity != null)
            {
                decimal pr = decimal.Parse(purchaseRate);
                int q = int.Parse(quantity);
                decimal totalValue = pr * q;
                int previousQuantity = product.Quantity;
                //Product p = new Product(manufacturerId, productName, CategoryId, pr, decimal.Parse(sellRate), q, 30, totalValue, DateTime.Now);
                product.ManufacturerID = manufacturerId;
                product.ProductName = productName;
                product.SellRate = decimal.Parse(sellRate);
                product.PurchaseRate = pr;
                product.Quantity = q;
                product.CategoryID = CategoryID;
                product.totalValue = totalValue;
                ProductDL.updateProductIntoList(product);
                ProductDL.UpdateProductIntoDB(product);
                List<int> shelfList = ProductShelfDL.getShelfIdbyPid(product.ProductID);
                Shelf newshelf = ShelfDL.getShelf(shelfid);
                bool isMatched = false;
                for (int i = 0; i < shelfList.Count; i++)
                {
                    
                    if (shelfList[i] == shelfid)
                    {
                        newshelf.currentCapacity = (newshelf.currentCapacity - previousQuantity) + q;
                        ProductShelf ps = new ProductShelf(product.ProductID, shelfid, q);
                        ProductShelfDL.updateProductShelfIntoList(ps);
                        ProductShelfDL.updateProductShelfIntoDB(ps);
                        isMatched = true;
                    }
                    else
                    {
                        Shelf prevShelf = ShelfDL.getShelf(shelfList[i]);
                        prevShelf.currentCapacity -= previousQuantity;
                        newshelf.currentCapacity += q;
                        ShelfDL.updateShelfIntoList(prevShelf);
                        ShelfDL.updateShelfIntoDB(prevShelf);
                        ProductShelf ps = new ProductShelf(product.ProductID, shelfList[i], q);
                        ProductShelfDL.deleteProductShelfFromList(product.ProductID, shelfList[i]);
                        ProductShelfDL.deleteProductShelfFromDB(product.ProductID, shelfList[i]);
                    }
                    ShelfDL.updateShelfIntoList(newshelf);
                    ShelfDL.updateShelfIntoDB(newshelf);
                }
                if (!isMatched)
                {
                    ProductShelf ps = new ProductShelf(product.ProductID, shelfid, q);
                    ProductShelfDL.addIntoList(ps);
                    ProductShelfDL.addIntoDB(ps);
                }

                
                
               
               

            }
        }

        private void prate_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void setCategoryComboBox()
        {
            CategoryDL.categories.Sort((x, y) => string.Compare(x.CategoryName, y.CategoryName));
            category_combo_box.DataSource = CategoryDL.categories; // Set the data source to the categories list
            category_combo_box.DisplayMember = "CategoryName"; // Specify the property to display for each item
            category_combo_box.ValueMember = "CategoryID"; 
        }
        private void setManufacturerComboBox()
        {
            ManufacturerDL.manufacturers.Sort((x, y) => string.Compare(x.CompanyName, y.CompanyName));
            manufacturer_combo_box.DataSource = ManufacturerDL.manufacturers;
            manufacturer_combo_box.DisplayMember = "CompanyName"; 
            manufacturer_combo_box.ValueMember = "ManufacturerID";
        }
        private void setBlockComboBox()
        {
            BlockDL.blocks.Sort((x, y) => string.Compare(x.blockName, y.blockName));
            comboBlock.DataSource = BlockDL.blocks;
            comboBlock.DisplayMember = "BlockName";
            comboBlock.ValueMember = "BlockId";
        }
        private void setShelfComboBox(List<Shelf> sh)
        {
            ShelfDL.shelves.Sort((x, y) => string.Compare(x.shelfName, y.shelfName));
            comboShelf.DataSource = sh;
            comboShelf.DisplayMember = "ShelfName";
            comboShelf.ValueMember = "ShelfId";
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            string productName = product_txtbox.Text;
            string purchaseRate = prate_txtbox.Text;
            string sellRate = sale_rate_txtbox.Text;
            string quantity = quantity_txtbox.Text;
            int CategoryId = (int)category_combo_box.SelectedValue;
            int manufacturerId = (int)manufacturer_combo_box.SelectedValue;
            int blockid = (int)comboBlock.SelectedValue;
            int shelfid = (int)comboShelf.SelectedValue;
            //int pid = ProductDL.isProductAlreadyExist(productName, manufacturerId);

            if (productName != null  && purchaseRate != null && sellRate != null && quantity != null)
            {
                decimal pr = decimal.Parse(purchaseRate);
                int q = int.Parse(quantity);
                decimal totalValue = pr * q;
           
                Shelf shelf = ShelfDL.getShelf(shelfid);
                shelf.currentCapacity = shelf.currentCapacity + q;
                if (shelf.capacity - shelf.currentCapacity < q)
                {
                    MessageBox.Show("Selected Shelf has less capacity");
                    return;
                }
                Product p = new Product(manufacturerId, productName, CategoryId, pr, decimal.Parse(sellRate), q, 30, totalValue, DateTime.Now);
                int pid = ProductDL.addIntoDB(p);
                if (pid == 0)
                {
                    return;
                }
                ShelfDL.updateShelfIntoList(shelf);
                ShelfDL.updateShelfIntoDB(shelf);
                ProductShelf ps = new ProductShelf(pid, shelfid, q);
                ProductShelfDL.addIntoList(ps);
                ProductShelfDL.addIntoDB(ps);
                ProductMovement pm = new ProductMovement(pid, q, "IN", DateTime.Now);
                ProductMovementDL.addIntoDB(pm);
                MessageBox.Show("Product Added Successfully");
               
            }

        }
    }
}
