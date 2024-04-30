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
            this.GridManufacturer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_block_btn = new Guna.UI2.WinForms.Guna2Button();
            this.back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Add_Shelf_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridManufacturer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridManufacturer
            // 
            this.GridManufacturer.AllowUserToAddRows = false;
            this.GridManufacturer.AllowUserToDeleteRows = false;
            this.GridManufacturer.AllowUserToResizeColumns = false;
            this.GridManufacturer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GridManufacturer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridManufacturer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridManufacturer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridManufacturer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridManufacturer.ColumnHeadersHeight = 50;
            this.GridManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridManufacturer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridManufacturer.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridManufacturer.EnableHeadersVisualStyles = true;
            this.GridManufacturer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridManufacturer.Location = new System.Drawing.Point(0, 0);
            this.GridManufacturer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridManufacturer.MultiSelect = false;
            this.GridManufacturer.Name = "GridManufacturer";
            this.GridManufacturer.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridManufacturer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridManufacturer.RowHeadersVisible = false;
            this.GridManufacturer.RowHeadersWidth = 100;
            this.GridManufacturer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridManufacturer.RowTemplate.Height = 25;
            this.GridManufacturer.Size = new System.Drawing.Size(834, 540);
            this.GridManufacturer.TabIndex = 55;
            this.GridManufacturer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(128)))), ((int)(((byte)(26)))));
            this.GridManufacturer.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridManufacturer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridManufacturer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridManufacturer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            this.GridManufacturer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.GridManufacturer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridManufacturer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridManufacturer.ThemeStyle.HeaderStyle.Height = 50;
            this.GridManufacturer.ThemeStyle.ReadOnly = true;
            this.GridManufacturer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridManufacturer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridManufacturer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.GridManufacturer.ThemeStyle.RowsStyle.Height = 25;
            this.GridManufacturer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridManufacturer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Shelf Id";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Current Capacity";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Available Capacity";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Capacity";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Block Name";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Category";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.GridManufacturer);
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
            // Storage_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Storage_Control";
            this.Size = new System.Drawing.Size(834, 602);
            ((System.ComponentModel.ISupportInitialize)(this.GridManufacturer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView GridManufacturer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Add_block_btn;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private Guna.UI2.WinForms.Guna2TextBox Searchbox;
        private Guna.UI2.WinForms.Guna2Button Add_Shelf_btn;
    }
}
