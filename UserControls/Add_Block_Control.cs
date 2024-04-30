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
    public partial class Add_Block_Control : UserControl
    {
        public Add_Block_Control()
        {
            InitializeComponent();
            setWarehouseComboDataSource();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string blockName = blockName_txtbox.Text;
            int warehouseId = (int)warehouse_combo_box.SelectedValue;
            if (blockName != null  && warehouseId > 0)
            {
                Block b = new Block(blockName, warehouseId);
                BlockDL.addIntoList(b);
                BlockDL.addIntoDB(b);
            }
        }
        private void setWarehouseComboDataSource()
        {
            warehouse_combo_box.DataSource = WarehouseDL.warehouses;
            warehouse_combo_box.DisplayMember = "WarehouseName";
            warehouse_combo_box.ValueMember = "WarehouseId";
        }
    }
}
