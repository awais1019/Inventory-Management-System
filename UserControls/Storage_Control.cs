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
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(GridManufacturer);
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
