namespace Inventory_Management_System.UserControls
{
    partial class Storage_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storage_Control));
            this.GridShelfs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_block_btn = new Guna.UI2.WinForms.Guna2Button();
            this.back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Add_Shelf_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ShelfId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelfCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridShelfs)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridShelfs
            // 
            this.GridShelfs.AllowUserToAddRows = false;
            this.GridShelfs.AllowUserToDeleteRows = false;
            this.GridShelfs.AllowUserToResizeColumns = false;
            this.GridShelfs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GridShelfs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridShelfs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridShelfs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridShelfs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridShelfs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridShelfs.ColumnHeadersHeight = 50;
            this.GridShelfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridShelfs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ShelfId,
            this.CurrentCapacity,
            this.AvailableCapacity,
            this.TotalCapacity,
            this.BlockName,
            this.ShelfCategory});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridShelfs.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridShelfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridShelfs.EnableHeadersVisualStyles = true;
            this.GridShelfs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridShelfs.Location = new System.Drawing.Point(0, 0);
            this.GridShelfs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridShelfs.MultiSelect = false;
            this.GridShelfs.Name = "GridShelfs";
            this.GridShelfs.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridShelfs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridShelfs.RowHeadersVisible = false;
            this.GridShelfs.RowHeadersWidth = 100;
            this.GridShelfs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridShelfs.RowTemplate.Height = 25;
            this.GridShelfs.Size = new System.Drawing.Size(834, 540);
            this.GridShelfs.TabIndex = 55;
            this.GridShelfs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(128)))), ((int)(((byte)(26)))));
            this.GridShelfs.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridShelfs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridShelfs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridShelfs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridShelfs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridShelfs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridShelfs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            this.GridShelfs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.GridShelfs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridShelfs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridShelfs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridShelfs.ThemeStyle.HeaderStyle.Height = 50;
            this.GridShelfs.ThemeStyle.ReadOnly = true;
            this.GridShelfs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridShelfs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridShelfs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridShelfs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.GridShelfs.ThemeStyle.RowsStyle.Height = 25;
            this.GridShelfs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridShelfs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.GridShelfs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 540);
            this.panel2.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Add_block_btn);
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.Searchbox);
            this.panel1.Controls.Add(this.Add_Shelf_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 62);
            this.panel1.TabIndex = 62;
            // 
            // Add_block_btn
            // 
            this.Add_block_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Add_block_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_block_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_block_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_block_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_block_btn.FillColor = System.Drawing.Color.White;
            this.Add_block_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Add_block_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_block_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_block_btn.Image")));
            this.Add_block_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_block_btn.Location = new System.Drawing.Point(171, 15);
            this.Add_block_btn.Name = "Add_block_btn";
            this.Add_block_btn.Size = new System.Drawing.Size(189, 37);
            this.Add_block_btn.TabIndex = 64;
            this.Add_block_btn.Text = "Add Block";
            this.Add_block_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_block_btn.Click += new System.EventHandler(this.Add_block_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BorderRadius = 5;
            this.back_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_btn.FillColor = System.Drawing.Color.White;
            this.back_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.back_btn.ImageSize = new System.Drawing.Size(18, 18);
            this.back_btn.Location = new System.Drawing.Point(3, 11);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(162, 41);
            this.back_btn.TabIndex = 63;
            this.back_btn.Text = "Back";
            this.back_btn.Visible = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Searchbox
            // 
            this.Searchbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Searchbox.BorderThickness = 2;
            this.Searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchbox.DefaultText = "";
            this.Searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Searchbox.IconLeft")));
            this.Searchbox.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Searchbox.IconLeftSize = new System.Drawing.Size(18, 18);
            this.Searchbox.Location = new System.Drawing.Point(645, 11);
            this.Searchbox.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.PasswordChar = '\0';
            this.Searchbox.PlaceholderText = "Search";
            this.Searchbox.SelectedText = "";
            this.Searchbox.Size = new System.Drawing.Size(189, 41);
            this.Searchbox.TabIndex = 61;
            // 
            // Add_Shelf_btn
            // 
            this.Add_Shelf_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Add_Shelf_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_Shelf_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_Shelf_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_Shelf_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_Shelf_btn.FillColor = System.Drawing.Color.White;
            this.Add_Shelf_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Add_Shelf_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_Shelf_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_Shelf_btn.Image")));
            this.Add_Shelf_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_Shelf_btn.Location = new System.Drawing.Point(3, 15);
            this.Add_Shelf_btn.Name = "Add_Shelf_btn";
            this.Add_Shelf_btn.Size = new System.Drawing.Size(189, 37);
            this.Add_Shelf_btn.TabIndex = 59;
            this.Add_Shelf_btn.Text = "Add Shelf";
            this.Add_Shelf_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_Shelf_btn.Click += new System.EventHandler(this.Add_Shelf_btn_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ShelfId
            // 
            this.ShelfId.HeaderText = "Shelf Id";
            this.ShelfId.MinimumWidth = 8;
            this.ShelfId.Name = "ShelfId";
            this.ShelfId.ReadOnly = true;
            this.ShelfId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShelfId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CurrentCapacity
            // 
            this.CurrentCapacity.HeaderText = "Current Capacity";
            this.CurrentCapacity.MinimumWidth = 8;
            this.CurrentCapacity.Name = "CurrentCapacity";
            this.CurrentCapacity.ReadOnly = true;
            // 
            // AvailableCapacity
            // 
            this.AvailableCapacity.HeaderText = "Available Capacity";
            this.AvailableCapacity.MinimumWidth = 8;
            this.AvailableCapacity.Name = "AvailableCapacity";
            this.AvailableCapacity.ReadOnly = true;
            // 
            // TotalCapacity
            // 
            this.TotalCapacity.HeaderText = "Total Capacity";
            this.TotalCapacity.MinimumWidth = 8;
            this.TotalCapacity.Name = "TotalCapacity";
            this.TotalCapacity.ReadOnly = true;
            // 
            // BlockName
            // 
            this.BlockName.HeaderText = "Block Name";
            this.BlockName.MinimumWidth = 8;
            this.BlockName.Name = "BlockName";
            this.BlockName.ReadOnly = true;
            // 
            // ShelfCategory
            // 
            this.ShelfCategory.HeaderText = "Category";
            this.ShelfCategory.MinimumWidth = 8;
            this.ShelfCategory.Name = "ShelfCategory";
            this.ShelfCategory.ReadOnly = true;
            // 
            // Storage_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Storage_Control";
            this.Size = new System.Drawing.Size(834, 602);
            ((System.ComponentModel.ISupportInitialize)(this.GridShelfs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView GridShelfs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Add_block_btn;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private Guna.UI2.WinForms.Guna2TextBox Searchbox;
        private Guna.UI2.WinForms.Guna2Button Add_Shelf_btn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfCategory;
    }
}
