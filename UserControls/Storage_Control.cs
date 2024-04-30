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
    public partial class Storage_Control : UserControl
    {
        public Storage_Control()
        {
            InitializeComponent();
            setGridShelfDataSource();
        }
        private void setGridShelfDataSource()
        {
            

            foreach (var shelf in ShelfDL.shelves)
            {
                int rowIndex = GridShelfs.Rows.Add(); // Add a new row

                // Set the values of cells in the new row
                GridShelfs.Rows[rowIndex].Cells["ShelfId"].Value = shelf.shelfId;
                GridShelfs.Rows[rowIndex].Cells["CurrentCapacity"].Value = shelf.currentCapacity;
                GridShelfs.Rows[rowIndex].Cells["AvailableCapacity"].Value = shelf.capacity - shelf.currentCapacity;
                GridShelfs.Rows[rowIndex].Cells["TotalCapacity"].Value = shelf.capacity;
                GridShelfs.Rows[rowIndex].Cells["BlockName"].Value = BlockDL.getBlock(shelf.blockId).blockName;
                GridShelfs.Rows[rowIndex].Cells["ShelfCategory"].Value = ShelfDL.getCategoryName(shelf.blockId, shelf.shelfId);
                

                // Apply cell styling
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = Color.White;
                cellStyle.ForeColor = Color.FromArgb(0, 118, 212);
                cellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic);
                foreach (DataGridViewCell cell in GridShelfs.Rows[rowIndex].Cells)
                {
                    cell.Style.ApplyStyle(cellStyle);
                }

            }
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(GridShelfs);
            Searchbox.Visible = true;
            Add_Shelf_btn.Visible = true;
            Add_block_btn.Visible = true;
            back_btn.Visible = false;
        }

        private void Add_block_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Searchbox.Visible = false;
            Add_Shelf_btn.Visible = false;
            Add_block_btn.Visible = false;
            back_btn.Visible = true;
            Add_Block_Control control = new Add_Block_Control();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
        }

        private void Add_Shelf_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Searchbox.Visible = false;
            Add_Shelf_btn.Visible = false;
            Add_block_btn.Visible = false;
            back_btn.Visible = true;
            Add_Shelf_Control control = new Add_Shelf_Control();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
        }
    }
}
