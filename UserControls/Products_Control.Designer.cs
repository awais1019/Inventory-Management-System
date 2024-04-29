namespace Inventory_Management_System.UserControls
{
    partial class Products_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products_Control));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Delete_Product = new Guna.UI2.WinForms.Guna2Button();
            this.Add_Product_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_bar_panel = new System.Windows.Forms.Panel();
            this.count_students_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
            this.status_bar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Controls.Add(this.Delete_Product);
            this.panel1.Controls.Add(this.Add_Product_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.back_btn.Location = new System.Drawing.Point(13, 13);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(159, 41);
            this.back_btn.TabIndex = 62;
            this.back_btn.Text = "Back";
            this.back_btn.Visible = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // searchbox
            // 
            this.searchbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchbox.BorderThickness = 2;
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.DefaultText = "";
            this.searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchbox.IconLeft")));
            this.searchbox.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.searchbox.IconLeftSize = new System.Drawing.Size(18, 18);
            this.searchbox.Location = new System.Drawing.Point(645, 11);
            this.searchbox.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.searchbox.Name = "searchbox";
            this.searchbox.PasswordChar = '\0';
            this.searchbox.PlaceholderText = "Search";
            this.searchbox.SelectedText = "";
            this.searchbox.Size = new System.Drawing.Size(189, 41);
            this.searchbox.TabIndex = 61;
            this.searchbox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // Delete_Product
            // 
            this.Delete_Product.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Delete_Product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_Product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete_Product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_Product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete_Product.FillColor = System.Drawing.Color.White;
            this.Delete_Product.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete_Product.ForeColor = System.Drawing.Color.Black;
            this.Delete_Product.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Product.Image")));
            this.Delete_Product.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete_Product.ImageSize = new System.Drawing.Size(18, 18);
            this.Delete_Product.Location = new System.Drawing.Point(169, 17);
            this.Delete_Product.Name = "Delete_Product";
            this.Delete_Product.Size = new System.Drawing.Size(171, 37);
            this.Delete_Product.TabIndex = 60;
            this.Delete_Product.Text = "Delete Product";
            this.Delete_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete_Product.Click += new System.EventHandler(this.Delete_Product_Click);
            // 
            // Add_Product_btn
            // 
            this.Add_Product_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Add_Product_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_Product_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_Product_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_Product_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_Product_btn.FillColor = System.Drawing.Color.White;
            this.Add_Product_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Add_Product_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_Product_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_Product_btn.Image")));
            this.Add_Product_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_Product_btn.Location = new System.Drawing.Point(3, 15);
            this.Add_Product_btn.Name = "Add_Product_btn";
            this.Add_Product_btn.Size = new System.Drawing.Size(160, 37);
            this.Add_Product_btn.TabIndex = 59;
            this.Add_Product_btn.Text = "Add Product";
            this.Add_Product_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_Product_btn.Click += new System.EventHandler(this.Add_Product_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.GridProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 540);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // GridProduct
            // 
            this.GridProduct.AllowUserToAddRows = false;
            this.GridProduct.AllowUserToDeleteRows = false;
            this.GridProduct.AllowUserToResizeColumns = false;
            this.GridProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GridProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridProduct.ColumnHeadersHeight = 50;
            this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProduct.EnableHeadersVisualStyles = true;
            this.GridProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridProduct.Location = new System.Drawing.Point(0, 0);
            this.GridProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridProduct.MultiSelect = false;
            this.GridProduct.Name = "GridProduct";
            this.GridProduct.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridProduct.RowHeadersVisible = false;
            this.GridProduct.RowHeadersWidth = 100;
            this.GridProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridProduct.RowTemplate.Height = 25;
            this.GridProduct.Size = new System.Drawing.Size(834, 540);
            this.GridProduct.TabIndex = 55;
            this.GridProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(128)))), ((int)(((byte)(26)))));
            this.GridProduct.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            this.GridProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.GridProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridProduct.ThemeStyle.HeaderStyle.Height = 50;
            this.GridProduct.ThemeStyle.ReadOnly = true;
            this.GridProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.GridProduct.ThemeStyle.RowsStyle.Height = 25;
            this.GridProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 0.03353107F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 160.0426F;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 160.2921F;
            this.Column3.HeaderText = "Purchase Rate";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 160.192F;
            this.Column4.HeaderText = "Sell Rate";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 160.1819F;
            this.Column7.HeaderText = "Quantity";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 160.6189F;
            this.Column5.HeaderText = "Category";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 160.6391F;
            this.Column6.HeaderText = "Manufacturer";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // status_bar_panel
            // 
            this.status_bar_panel.BackColor = System.Drawing.Color.Transparent;
            this.status_bar_panel.Controls.Add(this.count_students_label);
            this.status_bar_panel.Controls.Add(this.label7);
            this.status_bar_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_bar_panel.Location = new System.Drawing.Point(0, 577);
            this.status_bar_panel.Name = "status_bar_panel";
            this.status_bar_panel.Size = new System.Drawing.Size(834, 25);
            this.status_bar_panel.TabIndex = 56;
            this.status_bar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.status_bar_panel_Paint);
            // 
            // count_students_label
            // 
            this.count_students_label.AutoSize = true;
            this.count_students_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.count_students_label.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_students_label.ForeColor = System.Drawing.Color.Black;
            this.count_students_label.Location = new System.Drawing.Point(118, 0);
            this.count_students_label.Name = "count_students_label";
            this.count_students_label.Size = new System.Drawing.Size(18, 19);
            this.count_students_label.TabIndex = 9;
            this.count_students_label.Text = "0";
            this.count_students_label.Click += new System.EventHandler(this.count_students_label_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Products:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Products_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.status_bar_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Products_Control";
            this.Size = new System.Drawing.Size(834, 602);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
            this.status_bar_panel.ResumeLayout(false);
            this.status_bar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView GridProduct;
        private Guna.UI2.WinForms.Guna2Button Delete_Product;
        private Guna.UI2.WinForms.Guna2Button Add_Product_btn;
        private System.Windows.Forms.Panel status_bar_panel;
        private System.Windows.Forms.Label count_students_label;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox searchbox;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
