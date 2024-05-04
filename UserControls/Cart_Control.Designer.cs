namespace Inventory_Management_System.UserControls
{
    partial class Cart_Control
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
            this.CartGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartGrid
            // 
            this.CartGrid.AllowUserToAddRows = false;
            this.CartGrid.AllowUserToDeleteRows = false;
            this.CartGrid.AllowUserToResizeColumns = false;
            this.CartGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.CartGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CartGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CartGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CartGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CartGrid.ColumnHeadersHeight = 50;
            this.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.ProductId,
            this.purchaseRate,
            this.sellRate,
            this.quantity,
            this.category,
            this.manufacturer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CartGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartGrid.EnableHeadersVisualStyles = true;
            this.CartGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CartGrid.Location = new System.Drawing.Point(0, 0);
            this.CartGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CartGrid.MultiSelect = false;
            this.CartGrid.Name = "CartGrid";
            this.CartGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CartGrid.RowHeadersVisible = false;
            this.CartGrid.RowHeadersWidth = 100;
            this.CartGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CartGrid.RowTemplate.Height = 25;
            this.CartGrid.Size = new System.Drawing.Size(834, 540);
            this.CartGrid.TabIndex = 56;
            this.CartGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(128)))), ((int)(((byte)(26)))));
            this.CartGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.CartGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.CartGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CartGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CartGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CartGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            this.CartGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.CartGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CartGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CartGrid.ThemeStyle.HeaderStyle.Height = 50;
            this.CartGrid.ThemeStyle.ReadOnly = true;
            this.CartGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CartGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CartGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.CartGrid.ThemeStyle.RowsStyle.Height = 25;
            this.CartGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.CartGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.CartGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 540);
            this.panel2.TabIndex = 20;
            // 
            // productName
            // 
            this.productName.FillWeight = 160.0426F;
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Column1";
            this.ProductId.MinimumWidth = 8;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // purchaseRate
            // 
            this.purchaseRate.FillWeight = 160.2921F;
            this.purchaseRate.HeaderText = "Purchase Rate";
            this.purchaseRate.MinimumWidth = 8;
            this.purchaseRate.Name = "purchaseRate";
            this.purchaseRate.ReadOnly = true;
            this.purchaseRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // sellRate
            // 
            this.sellRate.FillWeight = 160.192F;
            this.sellRate.HeaderText = "Sell Rate";
            this.sellRate.MinimumWidth = 8;
            this.sellRate.Name = "sellRate";
            this.sellRate.ReadOnly = true;
            this.sellRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 160.1819F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // category
            // 
            this.category.FillWeight = 160.6189F;
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 8;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // manufacturer
            // 
            this.manufacturer.FillWeight = 160.6391F;
            this.manufacturer.HeaderText = "Manufacturer";
            this.manufacturer.MinimumWidth = 8;
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.ReadOnly = true;
            this.manufacturer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Cart_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "Cart_Control";
            this.Size = new System.Drawing.Size(834, 540);
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView CartGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
    }
}
