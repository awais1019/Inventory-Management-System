namespace Inventory_Management_System.UserControls
{
    partial class History_Control
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.report_generate_btn = new Guna.UI2.WinForms.Guna2Button();
            this.show_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllTime_box = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridHistory
            // 
            this.GridHistory.AllowUserToAddRows = false;
            this.GridHistory.AllowUserToDeleteRows = false;
            this.GridHistory.AllowUserToResizeColumns = false;
            this.GridHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.GridHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridHistory.ColumnHeadersHeight = 50;
            this.GridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productPrice,
            this.productQuantity,
            this.totalPrice,
            this.category,
            this.manufacturer});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridHistory.DefaultCellStyle = dataGridViewCellStyle7;
            this.GridHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridHistory.EnableHeadersVisualStyles = true;
            this.GridHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridHistory.Location = new System.Drawing.Point(0, 61);
            this.GridHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridHistory.MultiSelect = false;
            this.GridHistory.Name = "GridHistory";
            this.GridHistory.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.GridHistory.RowHeadersVisible = false;
            this.GridHistory.RowHeadersWidth = 100;
            this.GridHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridHistory.RowTemplate.Height = 25;
            this.GridHistory.Size = new System.Drawing.Size(834, 541);
            this.GridHistory.TabIndex = 58;
            this.GridHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(128)))), ((int)(((byte)(26)))));
            this.GridHistory.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridHistory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            this.GridHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.GridHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridHistory.ThemeStyle.HeaderStyle.Height = 50;
            this.GridHistory.ThemeStyle.ReadOnly = true;
            this.GridHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.GridHistory.ThemeStyle.RowsStyle.Height = 25;
            this.GridHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            // productPrice
            // 
            this.productPrice.FillWeight = 160.192F;
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 8;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // productQuantity
            // 
            this.productQuantity.FillWeight = 160.1819F;
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.MinimumWidth = 8;
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            this.productQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.MinimumWidth = 8;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.report_generate_btn);
            this.panel1.Controls.Add(this.show_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AllTime_box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 61);
            this.panel1.TabIndex = 57;
            // 
            // report_generate_btn
            // 
            this.report_generate_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.report_generate_btn.BorderRadius = 5;
            this.report_generate_btn.BorderThickness = 1;
            this.report_generate_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.report_generate_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.report_generate_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.report_generate_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.report_generate_btn.Enabled = false;
            this.report_generate_btn.FillColor = System.Drawing.Color.White;
            this.report_generate_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.report_generate_btn.ForeColor = System.Drawing.Color.Black;
            this.report_generate_btn.Location = new System.Drawing.Point(641, 10);
            this.report_generate_btn.Name = "report_generate_btn";
            this.report_generate_btn.Size = new System.Drawing.Size(180, 45);
            this.report_generate_btn.TabIndex = 58;
            this.report_generate_btn.Text = "Generate Report";
            this.report_generate_btn.Click += new System.EventHandler(this.report_generate_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.show_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.show_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.show_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.show_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.show_btn.FillColor = System.Drawing.Color.White;
            this.show_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.ForeColor = System.Drawing.Color.Black;
            this.show_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.show_btn.Location = new System.Drawing.Point(412, 11);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(120, 34);
            this.show_btn.TabIndex = 57;
            this.show_btn.Text = "Display";
            this.show_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AllTime_box
            // 
            this.AllTime_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AllTime_box.BackColor = System.Drawing.Color.Transparent;
            this.AllTime_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AllTime_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllTime_box.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllTime_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllTime_box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AllTime_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AllTime_box.ItemHeight = 30;
            this.AllTime_box.Location = new System.Drawing.Point(143, 5);
            this.AllTime_box.Name = "AllTime_box";
            this.AllTime_box.Size = new System.Drawing.Size(256, 36);
            this.AllTime_box.TabIndex = 0;
            this.AllTime_box.SelectedIndexChanged += new System.EventHandler(this.AllTime_box_SelectedIndexChanged);
            // 
            // History_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridHistory);
            this.Controls.Add(this.panel1);
            this.Name = "History_Control";
            this.Size = new System.Drawing.Size(834, 602);
            ((System.ComponentModel.ISupportInitialize)(this.GridHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView GridHistory;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button report_generate_btn;
        private Guna.UI2.WinForms.Guna2Button show_btn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox AllTime_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
    }
}
