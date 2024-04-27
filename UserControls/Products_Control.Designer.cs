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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products_Control));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridAttendance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.status_bar_panel = new System.Windows.Forms.Panel();
            this.count_students_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Delete_Product = new Guna.UI2.WinForms.Guna2Button();
            this.Add_Product_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAttendance)).BeginInit();
            this.status_bar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.Delete_Product);
            this.panel1.Controls.Add(this.Add_Product_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.GridAttendance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 540);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // GridAttendance
            // 
            this.GridAttendance.AllowUserToAddRows = false;
            this.GridAttendance.AllowUserToDeleteRows = false;
            this.GridAttendance.AllowUserToResizeColumns = false;
            this.GridAttendance.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GridAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridAttendance.ColumnHeadersHeight = 50;
            this.GridAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridAttendance.EnableHeadersVisualStyles = true;
            this.GridAttendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridAttendance.Location = new System.Drawing.Point(0, 0);
            this.GridAttendance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridAttendance.MultiSelect = false;
            this.GridAttendance.Name = "GridAttendance";
            this.GridAttendance.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridAttendance.RowHeadersVisible = false;
            this.GridAttendance.RowHeadersWidth = 100;
            this.GridAttendance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridAttendance.RowTemplate.Height = 25;
            this.GridAttendance.Size = new System.Drawing.Size(834, 540);
            this.GridAttendance.TabIndex = 55;
            this.GridAttendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(128)))), ((int)(((byte)(26)))));
            this.GridAttendance.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridAttendance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridAttendance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridAttendance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridAttendance.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridAttendance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridAttendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            this.GridAttendance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.GridAttendance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridAttendance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridAttendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridAttendance.ThemeStyle.HeaderStyle.Height = 50;
            this.GridAttendance.ThemeStyle.ReadOnly = true;
            this.GridAttendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridAttendance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridAttendance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridAttendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.GridAttendance.ThemeStyle.RowsStyle.Height = 25;
            this.GridAttendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridAttendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAttendance_CellContentClick);
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(18, 18);
            this.guna2TextBox1.Location = new System.Drawing.Point(645, 11);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(189, 41);
            this.guna2TextBox1.TabIndex = 61;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.GridAttendance)).EndInit();
            this.status_bar_panel.ResumeLayout(false);
            this.status_bar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView GridAttendance;
        private Guna.UI2.WinForms.Guna2Button Delete_Product;
        private Guna.UI2.WinForms.Guna2Button Add_Product_btn;
        private System.Windows.Forms.Panel status_bar_panel;
        private System.Windows.Forms.Label count_students_label;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}
