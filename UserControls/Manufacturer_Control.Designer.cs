namespace Inventory_Management_System.UserControls
{
    partial class Manufacturer_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manufacturer_Control));
            this.GridManufacturer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_bar_panel = new System.Windows.Forms.Panel();
            this.count_students_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Delete_Manufacturers_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Add_Manufacturers_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridManufacturer)).BeginInit();
            this.status_bar_panel.SuspendLayout();
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
            this.Checkbox,
            this.CompanyName,
            this.Email,
            this.Phone,
            this.ManufacturerId,
            this.Location});
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
            this.GridManufacturer.GridColor = System.Drawing.Color.White;
            this.GridManufacturer.Location = new System.Drawing.Point(0, 0);
            this.GridManufacturer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridManufacturer.MultiSelect = false;
            this.GridManufacturer.Name = "GridManufacturer";
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
            this.GridManufacturer.RowTemplate.Height = 70;
            this.GridManufacturer.Size = new System.Drawing.Size(834, 540);
            this.GridManufacturer.TabIndex = 55;
            this.GridManufacturer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(128)))), ((int)(((byte)(26)))));
            this.GridManufacturer.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridManufacturer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridManufacturer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            this.GridManufacturer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.GridManufacturer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridManufacturer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridManufacturer.ThemeStyle.HeaderStyle.Height = 50;
            this.GridManufacturer.ThemeStyle.ReadOnly = false;
            this.GridManufacturer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridManufacturer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridManufacturer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridManufacturer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GridManufacturer.ThemeStyle.RowsStyle.Height = 70;
            this.GridManufacturer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridManufacturer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridManufacturer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridManufacturer_CellContentClick);
            // 
            // Checkbox
            // 
            this.Checkbox.FillWeight = 30F;
            this.Checkbox.HeaderText = "";
            this.Checkbox.MinimumWidth = 8;
            this.Checkbox.Name = "Checkbox";
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Name";
            this.CompanyName.MinimumWidth = 8;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CompanyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone Number";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            // 
            // ManufacturerId
            // 
            this.ManufacturerId.HeaderText = "Id";
            this.ManufacturerId.MinimumWidth = 8;
            this.ManufacturerId.Name = "ManufacturerId";
            this.ManufacturerId.Visible = false;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 8;
            this.Location.Name = "Location";
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
            this.status_bar_panel.TabIndex = 59;
            // 
            // count_students_label
            // 
            this.count_students_label.AutoSize = true;
            this.count_students_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.count_students_label.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_students_label.ForeColor = System.Drawing.Color.Black;
            this.count_students_label.Location = new System.Drawing.Point(163, 0);
            this.count_students_label.Name = "count_students_label";
            this.count_students_label.Size = new System.Drawing.Size(18, 19);
            this.count_students_label.TabIndex = 9;
            this.count_students_label.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Manufacturers:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.GridManufacturer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 540);
            this.panel2.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.Searchbox);
            this.panel1.Controls.Add(this.Delete_Manufacturers_btn);
            this.panel1.Controls.Add(this.Add_Manufacturers_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 62);
            this.panel1.TabIndex = 57;
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
            this.back_btn.Location = new System.Drawing.Point(10, 11);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(192, 41);
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
            // Delete_Manufacturers_btn
            // 
            this.Delete_Manufacturers_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Delete_Manufacturers_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_Manufacturers_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete_Manufacturers_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_Manufacturers_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete_Manufacturers_btn.FillColor = System.Drawing.Color.White;
            this.Delete_Manufacturers_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete_Manufacturers_btn.ForeColor = System.Drawing.Color.Black;
            this.Delete_Manufacturers_btn.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Manufacturers_btn.Image")));
            this.Delete_Manufacturers_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete_Manufacturers_btn.ImageSize = new System.Drawing.Size(18, 18);
            this.Delete_Manufacturers_btn.Location = new System.Drawing.Point(219, 15);
            this.Delete_Manufacturers_btn.Name = "Delete_Manufacturers_btn";
            this.Delete_Manufacturers_btn.Size = new System.Drawing.Size(217, 37);
            this.Delete_Manufacturers_btn.TabIndex = 60;
            this.Delete_Manufacturers_btn.Text = "Delete Manufacturer";
            this.Delete_Manufacturers_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete_Manufacturers_btn.Click += new System.EventHandler(this.Delete_Manufacturers_btn_Click);
            // 
            // Add_Manufacturers_btn
            // 
            this.Add_Manufacturers_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Add_Manufacturers_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_Manufacturers_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_Manufacturers_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_Manufacturers_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_Manufacturers_btn.FillColor = System.Drawing.Color.White;
            this.Add_Manufacturers_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Add_Manufacturers_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_Manufacturers_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_Manufacturers_btn.Image")));
            this.Add_Manufacturers_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_Manufacturers_btn.Location = new System.Drawing.Point(3, 15);
            this.Add_Manufacturers_btn.Name = "Add_Manufacturers_btn";
            this.Add_Manufacturers_btn.Size = new System.Drawing.Size(210, 37);
            this.Add_Manufacturers_btn.TabIndex = 59;
            this.Add_Manufacturers_btn.Text = "Add Manufacturer";
            this.Add_Manufacturers_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_Manufacturers_btn.Click += new System.EventHandler(this.Add_Manufacturers_btn_Click);
            // 
            // Manufacturer_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.status_bar_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Manufacturer_Control";
            this.Size = new System.Drawing.Size(834, 602);
            ((System.ComponentModel.ISupportInitialize)(this.GridManufacturer)).EndInit();
            this.status_bar_panel.ResumeLayout(false);
            this.status_bar_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView GridManufacturer;
        private System.Windows.Forms.Panel status_bar_panel;
        private System.Windows.Forms.Label count_students_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox Searchbox;
        private Guna.UI2.WinForms.Guna2Button Delete_Manufacturers_btn;
        private Guna.UI2.WinForms.Guna2Button Add_Manufacturers_btn;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
    }
}
