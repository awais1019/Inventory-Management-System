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
    public partial class Add_Shelf_Control : UserControl
    {
        public Add_Shelf_Control()
        {
            InitializeComponent();
            
            setBlockComboDataSource();
        }
        
        private void Add_btn_Click(object sender, EventArgs e)
        {
            string shelfName = shelfname_txtbox.Text;
            string capacity = capacity_txtbox.Text;
            int blockId = (int)block_combo_box.SelectedValue;
            if (shelfName.Length > 0 && capacity.Length > 0)
            {
                 Shelf s = new Shelf(int.Parse(capacity), 0, shelfName, blockId);
                 ShelfDL.addIntoDB(s); 
            }
            

        }
        //private bool isShelfAlreadyExist(int categoryId, int blockId)
        //{
        //    List<Shelf> sh = new List<Shelf>();
        //    for (int i = 0; i < ShelfDL.shelves.Count; i++)
        //    {
        //        if (blockId == ShelfDL.shelves[i].blockId)
        //        {
        //            sh.Add(ShelfDL.shelves[i]);
        //        }
        //    }
        //
        //
        //    for (int i= 0; i < sh.Count; i++)
        //    {
        //        if (sh[i].shelfId == categoryId)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
       
        private void setBlockComboDataSource()
        {
            BlockDL.blocks.Sort((x, y) => string.Compare(x.blockName, y.blockName));
            block_combo_box.DataSource = BlockDL.blocks;
            block_combo_box.DisplayMember = "BlockName";
            block_combo_box.ValueMember = "BlockId";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
