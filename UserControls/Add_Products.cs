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
        public Add_Products()
        {
            InitializeComponent();
            setCategoryComboBox();
            setManufacturerComboBox();
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

        private void setCategoryComboBox()
        {
            //CategoryDL.getCategoryFromDB(); // Fetch categories from the database
            category_combo_box.DataSource = CategoryDL.categories; // Set the data source to the categories list
            category_combo_box.DisplayMember = "CategoryName"; // Specify the property to display for each item
            category_combo_box.ValueMember = "CategoryID"; 
        }
        private void setManufacturerComboBox()
        {
            manufacturer_combo_box.DataSource = ManufacturerDL.manufacturers;
            manufacturer_combo_box.DisplayMember = "CompanyName"; 
            manufacturer_combo_box.ValueMember = "ManufacturerId";
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            string productName = product_txtbox.Text;
            string purchaseRate = prate_txtbox.Text;
            string sellRate = sale_rate_txtbox.Text;
            string quantity = quantity_txtbox.Text;
            int CategoryId = (int)category_combo_box.SelectedValue;
            int manufacturerId = (int)manufacturer_combo_box.SelectedValue;
            if (productName != null  && purchaseRate != null && sellRate != null && quantity != null)
            {
                Product p = new Product(manufacturerId, productName, CategoryId, CategoryId, decimal.Parse(purchaseRate), decimal.Parse(sellRate), int.Parse(quantity), 30, DateTime.Now);
                ProductDL.addIntoList(p);
                ProductDL.addIntoDB(p);
            }

        }
    }
}
