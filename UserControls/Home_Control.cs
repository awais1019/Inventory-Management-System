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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Inventory_Management_System.UserControls
{
    public partial class Home_Control : UserControl
    {
        public Home_Control()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            Addcards();
            Addcards1();
            lbl_total_products.Text = getTotalProducts().ToString();
            label10.Text = ManufacturerDL.manufacturers.Count.ToString();
            lbl_total_cost.Text = ProductDL.getTotalCost().ToString();
            lbl_total_sale.Text = DispatchDL.getTotalSales().ToString();
        }
        private int getTotalProducts()
        {
            int count = 0;

            for (int i = 0; i < ProductMovementDL.productMovements.Count; i++)
            {
                ProductMovement pm = ProductMovementDL.productMovements[i];
                if (pm.movementType == "IN")
                {
                    if (ProductDL.getProduct(pm.productID).Quantity > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        void Addcards()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            List<Product> prod = ProductDL.getLowQuantityProduct();

            for (int i = 0; i < prod.Count; i++)
            {
                Threshold_Card card =new Threshold_Card();
                card.setvalues(prod[i].ProductName, CategoryDL.getCategory(prod[i].CategoryID).CategoryName, ManufacturerDL.getManufacturer(prod[i].ManufacturerID).CompanyName);
                flowLayoutPanel1.Controls.Add(card);
                
                
              
        
            }
            flowLayoutPanel1.ResumeLayout();
        }
        void Addcards1()
        {
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel2.ResumeLayout();
            // Extract unique dates from dispatches and format them to display only date
            // Get the most recent date
            // Find the most recent date
            DateTime mostRecentDate = ProductMovementDL.productMovements.Max(d => d.movementTime.Date);

            // Find all movementType objects with the most recent date
            List<ProductMovement> recentMovements = ProductMovementDL.productMovements
                .Where(d => d.movementTime.Date == mostRecentDate)
                .ToList();

            // Sort the unique dates
            for (int i = 0; i < recentMovements.Count; i++)
            {
                Product_Movement_Card card1=new Product_Movement_Card();
                Product p = ProductDL.getProduct(recentMovements[i].productID);
                card1.setvalues(p.ProductName, CategoryDL.getCategory(p.CategoryID).CategoryName, ManufacturerDL.getManufacturer(p.ManufacturerID).CompanyName, recentMovements[i].movementType, recentMovements[i].quantity, recentMovements[i].movementTime);
                
                flowLayoutPanel2.Controls.Add(card1);
            }
            flowLayoutPanel2.ResumeLayout();
            

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_total_products_Click(object sender, EventArgs e)
        {

        }
    }
}
