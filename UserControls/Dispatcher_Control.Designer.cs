﻿namespace Inventory_Management_System
{
    partial class Dispatcher_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dispatcher_Control));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Check_Cart_btn = new Guna.UI2.WinForms.Guna2Button();
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
            this.Done_btn = new Guna.UI2.WinForms.Guna2Button();
            this.delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.edit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.quantity_product_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.name_txt = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.panel1.Controls.Add(this.Check_Cart_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 50);
            this.panel1.TabIndex = 58;
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
            this.back_btn.Location = new System.Drawing.Point(4, 7);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(159, 41);
            this.back_btn.TabIndex = 62;
            this.back_btn.Text = "Back";
            this.back_btn.Visible = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click_1);
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
            this.searchbox.Location = new System.Drawing.Point(645, 5);
            this.searchbox.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.searchbox.Name = "searchbox";
            this.searchbox.PasswordChar = '\0';
            this.searchbox.PlaceholderText = "Search";
            this.searchbox.SelectedText = "";
            this.searchbox.Size = new System.Drawing.Size(189, 41);
            this.searchbox.TabIndex = 61;
            // 
            // Check_Cart_btn
            // 
            this.Check_Cart_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Check_Cart_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Check_Cart_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Check_Cart_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Check_Cart_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Check_Cart_btn.FillColor = System.Drawing.Color.White;
            this.Check_Cart_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Check_Cart_btn.ForeColor = System.Drawing.Color.Black;
            this.Check_Cart_btn.Image = ((System.Drawing.Image)(resources.GetObject("Check_Cart_btn.Image")));
            this.Check_Cart_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Check_Cart_btn.Location = new System.Drawing.Point(4, 11);
            this.Check_Cart_btn.Name = "Check_Cart_btn";
            this.Check_Cart_btn.Size = new System.Drawing.Size(172, 37);
            this.Check_Cart_btn.TabIndex = 60;
            this.Check_Cart_btn.Text = "Check Cart";
            this.Check_Cart_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Check_Cart_btn.Click += new System.EventHandler(this.Check_Cart_btn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.GridProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 552);
            this.panel2.TabIndex = 59;
            // 
            // GridProduct
            // 
            this.GridProduct.AllowUserToAddRows = false;
            this.GridProduct.AllowUserToDeleteRows = false;
            this.GridProduct.AllowUserToResizeColumns = false;
            this.GridProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.GridProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GridProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProduct.DefaultCellStyle = dataGridViewCellStyle9;
            this.GridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProduct.EnableHeadersVisualStyles = true;
            this.GridProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridProduct.Location = new System.Drawing.Point(0, 0);
            this.GridProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridProduct.MultiSelect = false;
            this.GridProduct.Name = "GridProduct";
            this.GridProduct.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridProduct.RowHeadersVisible = false;
            this.GridProduct.RowHeadersWidth = 100;
            this.GridProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridProduct.RowTemplate.Height = 25;
            this.GridProduct.Size = new System.Drawing.Size(834, 552);
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = false;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.status_bar_panel.BackColor = System.Drawing.Color.White;
            this.status_bar_panel.Controls.Add(this.Done_btn);
            this.status_bar_panel.Controls.Add(this.delete_btn);
            this.status_bar_panel.Controls.Add(this.edit_btn);
            this.status_bar_panel.Controls.Add(this.Add_btn);
            this.status_bar_panel.Controls.Add(this.label4);
            this.status_bar_panel.Controls.Add(this.guna2Shapes2);
            this.status_bar_panel.Controls.Add(this.quantity_product_txtbox);
            this.status_bar_panel.Controls.Add(this.label3);
            this.status_bar_panel.Controls.Add(this.guna2Shapes1);
            this.status_bar_panel.Controls.Add(this.name_txt);
            this.status_bar_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_bar_panel.Location = new System.Drawing.Point(0, 455);
            this.status_bar_panel.Name = "status_bar_panel";
            this.status_bar_panel.Size = new System.Drawing.Size(834, 147);
            this.status_bar_panel.TabIndex = 60;
            // 
            // Done_btn
            // 
            this.Done_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Done_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Done_btn.BorderRadius = 5;
            this.Done_btn.BorderThickness = 1;
            this.Done_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Done_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Done_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Done_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Done_btn.FillColor = System.Drawing.Color.White;
            this.Done_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Done_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Done_btn.Location = new System.Drawing.Point(700, 102);
            this.Done_btn.Name = "Done_btn";
            this.Done_btn.Size = new System.Drawing.Size(112, 37);
            this.Done_btn.TabIndex = 81;
            this.Done_btn.Text = "Done";
            this.Done_btn.Visible = false;
            this.Done_btn.Click += new System.EventHandler(this.Done_btn_Click_2);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.delete_btn.BorderRadius = 5;
            this.delete_btn.BorderThickness = 1;
            this.delete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_btn.FillColor = System.Drawing.Color.White;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.delete_btn.Location = new System.Drawing.Point(536, 102);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(112, 37);
            this.delete_btn.TabIndex = 80;
            this.delete_btn.Text = "Delete";
            this.delete_btn.Visible = false;
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.edit_btn.BorderRadius = 5;
            this.edit_btn.BorderThickness = 1;
            this.edit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit_btn.FillColor = System.Drawing.Color.White;
            this.edit_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.edit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.edit_btn.Location = new System.Drawing.Point(219, 102);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(112, 37);
            this.edit_btn.TabIndex = 79;
            this.edit_btn.Text = "Edit";
            this.edit_btn.Visible = false;
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Add_btn.BorderRadius = 5;
            this.Add_btn.BorderThickness = 1;
            this.Add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_btn.FillColor = System.Drawing.Color.White;
            this.Add_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Add_btn.Location = new System.Drawing.Point(375, 102);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(112, 37);
            this.Add_btn.TabIndex = 78;
            this.Add_btn.Text = "Add";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(387, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 75;
            this.label4.Text = "Quantity";
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Shapes2.LineThickness = 2;
            this.guna2Shapes2.Location = new System.Drawing.Point(488, 46);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes2.Size = new System.Drawing.Size(351, 13);
            this.guna2Shapes2.TabIndex = 77;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.Zoom = 80;
            // 
            // quantity_product_txtbox
            // 
            this.quantity_product_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantity_product_txtbox.BorderColor = System.Drawing.Color.White;
            this.quantity_product_txtbox.BorderThickness = 0;
            this.quantity_product_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity_product_txtbox.DefaultText = "";
            this.quantity_product_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantity_product_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantity_product_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantity_product_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantity_product_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantity_product_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantity_product_txtbox.ForeColor = System.Drawing.Color.Black;
            this.quantity_product_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantity_product_txtbox.Location = new System.Drawing.Point(526, 21);
            this.quantity_product_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantity_product_txtbox.Name = "quantity_product_txtbox";
            this.quantity_product_txtbox.PasswordChar = '\0';
            this.quantity_product_txtbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.quantity_product_txtbox.PlaceholderText = "10";
            this.quantity_product_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantity_product_txtbox.SelectedText = "";
            this.quantity_product_txtbox.Size = new System.Drawing.Size(286, 29);
            this.quantity_product_txtbox.TabIndex = 76;
            this.quantity_product_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(24, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 72;
            this.label3.Text = "Name";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Shapes1.LineThickness = 2;
            this.guna2Shapes1.Location = new System.Drawing.Point(81, 46);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(300, 13);
            this.guna2Shapes1.TabIndex = 74;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_txt.BorderColor = System.Drawing.Color.White;
            this.name_txt.BorderThickness = 0;
            this.name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txt.DefaultText = "";
            this.name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name_txt.ForeColor = System.Drawing.Color.Black;
            this.name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.Location = new System.Drawing.Point(89, 21);
            this.name_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_txt.Name = "name_txt";
            this.name_txt.PasswordChar = '\0';
            this.name_txt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.name_txt.PlaceholderText = "Product";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name_txt.SelectedText = "";
            this.name_txt.Size = new System.Drawing.Size(307, 29);
            this.name_txt.TabIndex = 73;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dispatcher_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.status_bar_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dispatcher_Control";
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
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private Guna.UI2.WinForms.Guna2TextBox searchbox;
        private Guna.UI2.WinForms.Guna2Button Check_Cart_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel status_bar_panel;
        private Guna.UI2.WinForms.Guna2Button Done_btn;
        private Guna.UI2.WinForms.Guna2Button delete_btn;
        private Guna.UI2.WinForms.Guna2Button edit_btn;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2TextBox quantity_product_txtbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox name_txt;
        private Guna.UI2.WinForms.Guna2DataGridView GridProduct;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}