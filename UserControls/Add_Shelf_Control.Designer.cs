namespace Inventory_Management_System.UserControls
{
    partial class Add_Shelf_Control
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.block_combo_box = new System.Windows.Forms.ComboBox();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Shapes5 = new Guna.UI2.WinForms.Guna2Shapes();
            this.capacity_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.shelfname_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.block_combo_box);
            this.panel2.Controls.Add(this.Add_btn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.guna2Shapes5);
            this.panel2.Controls.Add(this.capacity_txtbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.guna2Shapes1);
            this.panel2.Controls.Add(this.shelfname_txtbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 540);
            this.panel2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label7.Location = new System.Drawing.Point(158, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Block";
            // 
            // block_combo_box
            // 
            this.block_combo_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.block_combo_box.FormattingEnabled = true;
            this.block_combo_box.Location = new System.Drawing.Point(366, 285);
            this.block_combo_box.Name = "block_combo_box";
            this.block_combo_box.Size = new System.Drawing.Size(283, 28);
            this.block_combo_box.Sorted = true;
            this.block_combo_box.TabIndex = 31;
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
            this.Add_btn.Location = new System.Drawing.Point(401, 465);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(180, 45);
            this.Add_btn.TabIndex = 30;
            this.Add_btn.Text = "Add";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(135, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Capacity";
            // 
            // guna2Shapes5
            // 
            this.guna2Shapes5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Shapes5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Shapes5.LineThickness = 2;
            this.guna2Shapes5.Location = new System.Drawing.Point(331, 209);
            this.guna2Shapes5.Name = "guna2Shapes5";
            this.guna2Shapes5.PolygonSkip = 1;
            this.guna2Shapes5.Rotate = 0F;
            this.guna2Shapes5.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes5.Size = new System.Drawing.Size(351, 13);
            this.guna2Shapes5.TabIndex = 28;
            this.guna2Shapes5.Text = "guna2Shapes5";
            this.guna2Shapes5.Zoom = 80;
            // 
            // capacity_txtbox
            // 
            this.capacity_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.capacity_txtbox.BorderColor = System.Drawing.Color.White;
            this.capacity_txtbox.BorderThickness = 0;
            this.capacity_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.capacity_txtbox.DefaultText = "";
            this.capacity_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.capacity_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.capacity_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capacity_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capacity_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capacity_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.capacity_txtbox.ForeColor = System.Drawing.Color.Black;
            this.capacity_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capacity_txtbox.Location = new System.Drawing.Point(342, 182);
            this.capacity_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.capacity_txtbox.Name = "capacity_txtbox";
            this.capacity_txtbox.PasswordChar = '\0';
            this.capacity_txtbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.capacity_txtbox.PlaceholderText = "100";
            this.capacity_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.capacity_txtbox.SelectedText = "";
            this.capacity_txtbox.Size = new System.Drawing.Size(307, 29);
            this.capacity_txtbox.TabIndex = 27;
            this.capacity_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(133, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shelf Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Shapes1.LineThickness = 2;
            this.guna2Shapes1.Location = new System.Drawing.Point(331, 130);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(351, 13);
            this.guna2Shapes1.TabIndex = 16;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // shelfname_txtbox
            // 
            this.shelfname_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shelfname_txtbox.BorderColor = System.Drawing.Color.White;
            this.shelfname_txtbox.BorderThickness = 0;
            this.shelfname_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.shelfname_txtbox.DefaultText = "";
            this.shelfname_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.shelfname_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.shelfname_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shelfname_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shelfname_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shelfname_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shelfname_txtbox.ForeColor = System.Drawing.Color.Black;
            this.shelfname_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shelfname_txtbox.Location = new System.Drawing.Point(351, 104);
            this.shelfname_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shelfname_txtbox.Name = "shelfname_txtbox";
            this.shelfname_txtbox.PasswordChar = '\0';
            this.shelfname_txtbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.shelfname_txtbox.PlaceholderText = "A";
            this.shelfname_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shelfname_txtbox.SelectedText = "";
            this.shelfname_txtbox.Size = new System.Drawing.Size(307, 29);
            this.shelfname_txtbox.TabIndex = 15;
            this.shelfname_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Add_Shelf_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "Add_Shelf_Control";
            this.Size = new System.Drawing.Size(834, 540);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox block_combo_box;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes5;
        private Guna.UI2.WinForms.Guna2TextBox capacity_txtbox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox shelfname_txtbox;
    }
}
