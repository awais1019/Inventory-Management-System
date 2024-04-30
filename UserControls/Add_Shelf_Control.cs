﻿using Inventory_Management_System.BL_Classes;
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
            setCategoryComboDataSource();
            setBlockComboDataSource();
        }
        
        private void Add_btn_Click(object sender, EventArgs e)
        {
            string shelfNumber = shelfnumber_txtbox.Text;
            string capacity = capacity_txtbox.Text;
            int categoryId = (int)category_combo_box.SelectedValue;
            int blockId = (int)block_combo_box.SelectedValue;
            if (shelfNumber.Length > 0 && capacity.Length > 0)
            {
                if (!isShelfAlreadyExist(categoryId, blockId))
                {

                    Shelf s = new Shelf(categoryId, int.Parse(capacity), 0, categoryId, blockId);
                    ShelfDL.addIntoList(s);
                    ShelfDL.addIntoDB(s);
                }
                else
                {
                    MessageBox.Show("Shelf Already Exist");
                }
            }
            

        }
        private bool isShelfAlreadyExist(int categoryId, int blockId)
        {
            List<Shelf> sh = new List<Shelf>();
            for (int i = 0; i < ShelfDL.shelves.Count; i++)
            {
                if (blockId == ShelfDL.shelves[i].blockId)
                {
                    sh.Add(ShelfDL.shelves[i]);
                }
            }


            for (int i= 0; i < sh.Count; i++)
            {
                if (sh[i].shelfId == categoryId)
                {
                    return false;
                }
            }
            return true;
        }
        private void setCategoryComboDataSource()
        {
            category_combo_box.DataSource = CategoryDL.categories;
            category_combo_box.DisplayMember = "CategoryName";
            category_combo_box.ValueMember = "CategoryId";
        }
        private void setBlockComboDataSource()
        {
            block_combo_box.DataSource = BlockDL.blocks;
            block_combo_box.DisplayMember = "BlockName";
            block_combo_box.ValueMember = "BlockId";
        }
    }
}