using Inventory_Management_System.BL_Classes;
using Inventory_Management_System.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace Inventory_Management_System.UserControls
{
    public partial class History_Control : UserControl
    {
        public static string connectionString = "Data Source=CH-Hashim;Initial Catalog = Inventory; Integrated Security = True; Encrypt=False";
        DateTime selectedDate;
        List<History> history = new List<History>();
        public History_Control()
        {
            InitializeComponent();
            setDateComboBox();
            AllTime_box.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void setDateComboBox()
        {
            // Extract unique dates from dispatches and format them to display only date
            var uniqueDates = DispatchDL.dispatches.Select(d => d.DispatchDate.Date.ToString("yyyy-MM-dd")).Distinct().ToList();

            // Sort the unique dates
            uniqueDates.Sort();

            // Set unique dates as the data source for ComboBox
            AllTime_box.DataSource = uniqueDates;
        }

        private async void show_btn_Click(object sender, EventArgs e)
        {
            string selectedDateStr = AllTime_box.SelectedItem.ToString();
            this.selectedDate = DateTime.Parse(selectedDateStr);
            List<Dispatch> dispatchesOnSelectedDate = DispatchDL.dispatches.Where(d => d.DispatchDate.Date == this.selectedDate.Date).ToList();
            await SetGridDataSource(dispatchesOnSelectedDate);
            report_generate_btn.Enabled = true;
        }

        private void AllTime_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private async Task SetGridDataSource(List<Dispatch> dispatchList)
        {
            GridHistory.Rows.Clear();
            List<DispatchDetail> dd = new List<DispatchDetail>();

            // Collect dispatch details asynchronously
            await Task.Run(() =>
            {
                for (int i = 0; i < dispatchList.Count; i++)
                {
                    for (int j = 0; j < DispatchDetailDL.dispatchDetails.Count; j++)
                    {
                        if (dispatchList[i].DispatchID == DispatchDetailDL.dispatchDetails[j].DispatchID)
                        {
                            dd.Add(DispatchDetailDL.dispatchDetails[j]);
                        }
                    }
                }
            });

            foreach (var dispatch in dd)
            {
                
                int rowIndex = GridHistory.Rows.Add(); // Add a new row

                // Set the values of cells in the new row
                GridHistory.Rows[rowIndex].Cells["productName"].Value = ProductDL.getProduct(dispatch.ProductID).ProductName;
                GridHistory.Rows[rowIndex].Cells["productPrice"].Value = dispatch.UnitPrice;
                GridHistory.Rows[rowIndex].Cells["productQuantity"].Value = dispatch.Quantity;
                GridHistory.Rows[rowIndex].Cells["totalPrice"].Value = dispatch.TotalPrice;

                // Fetch category and manufacturer asynchronously
                var catTask = Task.Run(() => CategoryDL.getCategory(ProductDL.getProduct(dispatch.ProductID).CategoryID));
                var manTask = Task.Run(() => ManufacturerDL.getManufacturer(ProductDL.getProduct(dispatch.ProductID).ManufacturerID));
                
                await Task.WhenAll(catTask, manTask); // Wait for both tasks to complete

                GridHistory.Rows[rowIndex].Cells["category"].Value = catTask.Result.CategoryName;
                GridHistory.Rows[rowIndex].Cells["manufacturer"].Value = manTask.Result.CompanyName;
                
                // Apply cell styling
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = Color.White;
                cellStyle.ForeColor = Color.FromArgb(0, 118, 212);
                cellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic);
                foreach (DataGridViewCell cell in GridHistory.Rows[rowIndex].Cells)
                {
                    cell.Style.ApplyStyle(cellStyle);
                }
            }
        }

        private void report_generate_btn_Click(object sender, EventArgs e)
        {
            string name = GridHistory.SelectedRows[0].Cells[0].Value.ToString();
            decimal price = decimal.Parse(GridHistory.SelectedRows[0].Cells[1].Value.ToString());
            int quantity = int.Parse(GridHistory.SelectedRows[0].Cells[2].Value.ToString());
            decimal totalPrice = decimal.Parse(GridHistory.SelectedRows[0].Cells[3].Value.ToString());
            string category = GridHistory.SelectedRows[0].Cells[4].Value.ToString();
            string manufacturer = GridHistory.SelectedRows[0].Cells[5].Value.ToString();
            History his = new History(name, price, quantity, totalPrice, category, manufacturer);
            if(his != null )
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "declare @tid int; set @tid = (select dispatch.TransportationID from Dispatch join DispatchDetail on Dispatch.DispatchID=DispatchDetail.DispatchID join Product on DispatchDetail.ProductID=Product.ProductID where Product.ProductName=" + $"'{name}'); select * from Transportation where TransportationID = @tid;";

                        List<Transportation> list = connection.Query<Transportation>(query, commandType: CommandType.Text).ToList();
                        using (Print_Report frm = new Print_Report(his, list))
                        {
                            frm.ShowDialog();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }           
        }
    }
}
