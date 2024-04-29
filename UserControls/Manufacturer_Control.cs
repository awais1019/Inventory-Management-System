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
    public partial class Manufacturer_Control : UserControl
    {
        public Manufacturer_Control()
        {
            InitializeComponent();
            SetDataGridViewDataSource();
        }

        private void Add_Manufacturers_btn_Click(object sender, EventArgs e)
        {
            Add_Manufacturer_Control control = new Add_Manufacturer_Control();
            back_btn.Visible = true;
            Add_Manufacturers_btn.Visible = false;
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            Searchbox.Visible = false;
            Delete_Manufacturers_btn.Visible = false;
            panel2.Controls.Add(control);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(GridManufacturer);
            back_btn.Visible = false;
            Add_Manufacturers_btn.Visible = true;
            Searchbox.Visible = true;
            Delete_Manufacturers_btn.Visible = true;

        }
        private void SetDataGridViewDataSource()
        {
            //foreach (var manufacturer in ManufacturerDL.manufacturers)
            //{
            //    int rowIndex = GridManufacturer.Rows.Add(); // Add a new row
            //
            //    // Set the values of cells in the new row
            //    GridManufacturer.Rows[rowIndex].Cells["CompanyName"].Value = manufacturer.CompanyName;
            //    GridManufacturer.Rows[rowIndex].Cells["Email"].Value = manufacturer.Email;
            //    GridManufacturer.Rows[rowIndex].Cells["Phone"].Value = manufacturer.Phone;
            //    GridManufacturer.Rows[rowIndex].Cells["Location"].Value = manufacturer.Location;
            //    GridManufacturer.Rows[rowIndex].Cells["ManufacturerId"].Value = manufacturer.ManufacturerID;
            //}
            foreach (var manufacturer in ManufacturerDL.manufacturers)
            {
                int rowIndex = GridManufacturer.Rows.Add(); // Add a new row

                // Set the values of cells in the new row
                GridManufacturer.Rows[rowIndex].Cells["CompanyName"].Value = manufacturer.CompanyName;
                GridManufacturer.Rows[rowIndex].Cells["Email"].Value = manufacturer.Email;
                GridManufacturer.Rows[rowIndex].Cells["Phone"].Value = manufacturer.Phone;
                GridManufacturer.Rows[rowIndex].Cells["Location"].Value = manufacturer.Location;
                GridManufacturer.Rows[rowIndex].Cells["ManufacturerId"].Value = manufacturer.ManufacturerID;

                // Apply cell styling
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = Color.White;
                cellStyle.ForeColor = Color.FromArgb(0, 118, 212);
                cellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic);
                foreach (DataGridViewCell cell in GridManufacturer.Rows[rowIndex].Cells)
                {
                    cell.Style.ApplyStyle(cellStyle);
                }
                
            }


        }
        private List<int> selectedManufacturer()
        {
            List<int> selectedManufacturers = new List<int>();

            // Iterate through the rows of the DataGridView
            foreach (DataGridViewRow row in GridManufacturer.Rows)
            {
                // Check if the checkbox cell is selected for the current row
                DataGridViewCheckBoxCell checkboxCell = row.Cells["Checkbox"] as DataGridViewCheckBoxCell;
                bool isSelected = Convert.ToBoolean(checkboxCell.Value);

                if (isSelected)
                {
                    MessageBox.Show("selected");
                    int manufacturerID = Convert.ToInt32(row.Cells["ManufacturerId"].Value);
                    selectedManufacturers.Add(manufacturerID);
                }
            }
            return selectedManufacturers;
        }

        private void Delete_Manufacturers_btn_Click(object sender, EventArgs e)
        {
            List<int> selectedManufacturers = selectedManufacturer();
            foreach (int i in selectedManufacturers)
            {
                ManufacturerDL.deleteFromList(i);
                ManufacturerDL.deleteFromDB(i);
            }
        }

        private void GridManufacturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
