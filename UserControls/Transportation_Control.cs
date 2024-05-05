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
using System.Xml;

namespace Inventory_Management_System.UserControls
{
    public partial class Transportation_Control : UserControl
    {
        public Transportation_Control()
        {
            InitializeComponent();
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            string driverName = txtDriver.Text;
            string vehicleName = txtVehicle.Text;
            string departure = txtDeparture.Text;
            string arrival = txtArrival.Text;
            if (driverName != null && vehicleName != null &&  departure != null && arrival != null)
            {
                Transportation T = new Transportation(vehicleName, driverName, departure, arrival);
                int tid = TransportationDL.addIntoDB(T);
                decimal totalAmount = 0;
                Dispatch d = new Dispatch(DateTime.Now, totalAmount, tid);
                int did = DispatchDL.addIntoDB(d);
                if (did == 0)
                {
                    MessageBox.Show("Error");
                    return;
                }
                for (int i = 0; i < ProductDL.cartList.Count; i++)
                {
                    totalAmount += ProductDL.cartList[i].SellRate * ProductDL.cartList[i].Quantity; 
                    DispatchDetail dd = new DispatchDetail(did, ProductDL.cartList[i].ProductID, ProductDL.cartList[i].Quantity, ProductDL.cartList[i].SellRate, ProductDL.cartList[i].Quantity * ProductDL.cartList[i].SellRate);
                    DispatchDetailDL.addIntoList(dd);
                    DispatchDetailDL.addIntoDB(dd);
                    Product p = ProductDL.getProduct(ProductDL.cartList[i].ProductID);
                    p.Quantity -= ProductDL.cartList[i].Quantity;
                    p.totalValue = p.Quantity * p.SellRate;
                    List<int> shelfids = ProductShelfDL.getShelfIdbyPid(p.ProductID);
                    int quantityToRemove = ProductDL.cartList[i].Quantity;
                    for (int j = 0; j < shelfids.Count; i++)
                    {
                         ProductShelf ps = ProductShelfDL.getProductShelf(p.ProductID, shelfids[j]);
                         Shelf s = ShelfDL.getShelf(shelfids[j]);
                         if (ps.quantity >= quantityToRemove)
                         {
                             ps.quantity -= quantityToRemove;
                            ProductShelfDL.updateProductShelfIntoDB(ps);
                            s.currentCapacity -= quantityToRemove;
                            ShelfDL.updateShelfIntoDB(s);
                            break;
                         }
                         else if (ps.quantity > 0 && quantityToRemove > 0)
                         {
                            s.currentCapacity -= ps.quantity;
                            quantityToRemove -= ps.quantity;
                            ps.quantity = 0;
                            ShelfDL.updateShelfIntoDB(s);
                            ProductShelfDL.updateProductShelfIntoDB(ps);
                         }
                    }
                    ProductDL.UpdateProductIntoDB(p);
                    ProductMovement pm = new ProductMovement(p.ProductID, quantityToRemove, "OUT", DateTime.Now);
                    ProductMovementDL.addIntoList(pm);
                    ProductMovementDL.addIntoDB(pm);
                }
                DispatchDL.updateIntoList(did, totalAmount);
                DispatchDL.updateIntoDB(did, totalAmount);

            }
        }
    }
}
