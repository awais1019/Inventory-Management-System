namespace Inventory_Management_System
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_header_main = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.minimize_btn = new Guna.UI2.WinForms.Guna2Button();
            this.maximize_btn = new Guna.UI2.WinForms.Guna2Button();
            this.close_btn = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.sidepicture = new System.Windows.Forms.PictureBox();
            this.History_btn = new Guna.UI2.WinForms.Guna2Button();
            this.dispatch_btn = new Guna.UI2.WinForms.Guna2Button();
            this.manufacturer_btn = new Guna.UI2.WinForms.Guna2Button();
            this.products_btn = new Guna.UI2.WinForms.Guna2Button();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidepicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.BorderRadius = 35;
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(180, 77);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(39, 16);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(174, 25);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "STOCK MANAGER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.sidepicture);
            this.panel2.Controls.Add(this.History_btn);
            this.panel2.Controls.Add(this.dispatch_btn);
            this.panel2.Controls.Add(this.manufacturer_btn);
            this.panel2.Controls.Add(this.products_btn);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 648);
            this.panel2.TabIndex = 5;
            // 
            // label_header_main
            // 
            this.label_header_main.AutoSize = true;
            this.label_header_main.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_main.ForeColor = System.Drawing.Color.Blue;
            this.label_header_main.Location = new System.Drawing.Point(15, 7);
            this.label_header_main.Name = "label_header_main";
            this.label_header_main.Size = new System.Drawing.Size(89, 30);
            this.label_header_main.TabIndex = 3;
            this.label_header_main.Text = "Home";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.minimize_btn);
            this.panel4.Controls.Add(this.maximize_btn);
            this.panel4.Controls.Add(this.label_header_main);
            this.panel4.Controls.Add(this.close_btn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(180, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(834, 46);
            this.panel4.TabIndex = 6;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(180, 46);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(834, 602);
            this.main_panel.TabIndex = 7;
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.BorderColor = System.Drawing.Color.Transparent;
            this.minimize_btn.CheckedState.FillColor = System.Drawing.Color.Red;
            this.minimize_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimize_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimize_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimize_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_btn.FillColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.HoverState.FillColor = System.Drawing.Color.Red;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.ImageSize = new System.Drawing.Size(12, 12);
            this.minimize_btn.Location = new System.Drawing.Point(669, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(55, 46);
            this.minimize_btn.TabIndex = 4;
            this.minimize_btn.UseTransparentBackground = true;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // maximize_btn
            // 
            this.maximize_btn.BackColor = System.Drawing.Color.Transparent;
            this.maximize_btn.BorderColor = System.Drawing.Color.Transparent;
            this.maximize_btn.CheckedState.FillColor = System.Drawing.Color.Red;
            this.maximize_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.maximize_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.maximize_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.maximize_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.maximize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximize_btn.FillColor = System.Drawing.Color.Transparent;
            this.maximize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.maximize_btn.ForeColor = System.Drawing.Color.White;
            this.maximize_btn.HoverState.FillColor = System.Drawing.Color.Red;
            this.maximize_btn.Image = ((System.Drawing.Image)(resources.GetObject("maximize_btn.Image")));
            this.maximize_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.maximize_btn.Location = new System.Drawing.Point(724, 0);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(55, 46);
            this.maximize_btn.TabIndex = 3;
            this.maximize_btn.UseTransparentBackground = true;
            this.maximize_btn.Click += new System.EventHandler(this.maximize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BorderColor = System.Drawing.Color.Transparent;
            this.close_btn.CheckedState.FillColor = System.Drawing.Color.Red;
            this.close_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btn.FillColor = System.Drawing.Color.Transparent;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.HoverState.FillColor = System.Drawing.Color.Red;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(779, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(55, 46);
            this.close_btn.TabIndex = 2;
            this.close_btn.UseTransparentBackground = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // btn_close
            // 
            this.btn_close.BorderColor = System.Drawing.Color.White;
            this.btn_close.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_close.Location = new System.Drawing.Point(83, 593);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(45, 38);
            this.btn_close.TabIndex = 1;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // sidepicture
            // 
            this.sidepicture.Image = ((System.Drawing.Image)(resources.GetObject("sidepicture.Image")));
            this.sidepicture.Location = new System.Drawing.Point(141, 91);
            this.sidepicture.Name = "sidepicture";
            this.sidepicture.Size = new System.Drawing.Size(39, 101);
            this.sidepicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sidepicture.TabIndex = 4;
            this.sidepicture.TabStop = false;
            // 
            // History_btn
            // 
            this.History_btn.BackColor = System.Drawing.Color.Transparent;
            this.History_btn.BorderColor = System.Drawing.Color.White;
            this.History_btn.BorderRadius = 25;
            this.History_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.History_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.History_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.History_btn.CheckedState.Image = global::Inventory_Management_System.Properties.Resources.icons8_records_64;
            this.History_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.History_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.History_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.History_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.History_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.History_btn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.History_btn.ForeColor = System.Drawing.Color.White;
            this.History_btn.Image = global::Inventory_Management_System.Properties.Resources.icons8_records_64__2_;
            this.History_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.History_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.History_btn.Location = new System.Drawing.Point(31, 436);
            this.History_btn.Name = "History_btn";
            this.History_btn.Size = new System.Drawing.Size(149, 43);
            this.History_btn.TabIndex = 7;
            this.History_btn.Text = "History";
            this.History_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.History_btn.UseTransparentBackground = true;
            this.History_btn.CheckedChanged += new System.EventHandler(this.btn_home_CheckedChanged);
            // 
            // dispatch_btn
            // 
            this.dispatch_btn.BackColor = System.Drawing.Color.Transparent;
            this.dispatch_btn.BorderColor = System.Drawing.Color.White;
            this.dispatch_btn.BorderRadius = 25;
            this.dispatch_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.dispatch_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.dispatch_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dispatch_btn.CheckedState.Image = global::Inventory_Management_System.Properties.Resources.icons8_in_transit_64;
            this.dispatch_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dispatch_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dispatch_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dispatch_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dispatch_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dispatch_btn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dispatch_btn.ForeColor = System.Drawing.Color.White;
            this.dispatch_btn.Image = global::Inventory_Management_System.Properties.Resources.icons8_in_transit_64__2_;
            this.dispatch_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dispatch_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.dispatch_btn.Location = new System.Drawing.Point(30, 360);
            this.dispatch_btn.Name = "dispatch_btn";
            this.dispatch_btn.Size = new System.Drawing.Size(149, 43);
            this.dispatch_btn.TabIndex = 5;
            this.dispatch_btn.Text = "Dispatcher";
            this.dispatch_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dispatch_btn.UseTransparentBackground = true;
            this.dispatch_btn.CheckedChanged += new System.EventHandler(this.btn_home_CheckedChanged);
            // 
            // manufacturer_btn
            // 
            this.manufacturer_btn.BackColor = System.Drawing.Color.Transparent;
            this.manufacturer_btn.BorderColor = System.Drawing.Color.White;
            this.manufacturer_btn.BorderRadius = 25;
            this.manufacturer_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.manufacturer_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.manufacturer_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.manufacturer_btn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.manufacturer_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manufacturer_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manufacturer_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manufacturer_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manufacturer_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.manufacturer_btn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.manufacturer_btn.ForeColor = System.Drawing.Color.White;
            this.manufacturer_btn.Image = ((System.Drawing.Image)(resources.GetObject("manufacturer_btn.Image")));
            this.manufacturer_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manufacturer_btn.Location = new System.Drawing.Point(30, 283);
            this.manufacturer_btn.Name = "manufacturer_btn";
            this.manufacturer_btn.Size = new System.Drawing.Size(149, 43);
            this.manufacturer_btn.TabIndex = 4;
            this.manufacturer_btn.Text = "Manufacturer";
            this.manufacturer_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manufacturer_btn.UseTransparentBackground = true;
            this.manufacturer_btn.CheckedChanged += new System.EventHandler(this.btn_home_CheckedChanged);
            this.manufacturer_btn.Click += new System.EventHandler(this.manufacturer_btn_Click);
            // 
            // products_btn
            // 
            this.products_btn.BackColor = System.Drawing.Color.Transparent;
            this.products_btn.BorderColor = System.Drawing.Color.White;
            this.products_btn.BorderRadius = 25;
            this.products_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.products_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.products_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.products_btn.CheckedState.Image = global::Inventory_Management_System.Properties.Resources.icons8_products_64__3_;
            this.products_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.products_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.products_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.products_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.products_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.products_btn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.products_btn.ForeColor = System.Drawing.Color.White;
            this.products_btn.Image = global::Inventory_Management_System.Properties.Resources.icons8_products_64__4_;
            this.products_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.products_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.products_btn.Location = new System.Drawing.Point(30, 202);
            this.products_btn.Name = "products_btn";
            this.products_btn.Size = new System.Drawing.Size(149, 43);
            this.products_btn.TabIndex = 3;
            this.products_btn.Text = "Products";
            this.products_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.products_btn.UseTransparentBackground = true;
            this.products_btn.CheckedChanged += new System.EventHandler(this.btn_home_CheckedChanged);
            this.products_btn.Click += new System.EventHandler(this.products_btn_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BorderColor = System.Drawing.Color.White;
            this.btn_home.BorderRadius = 22;
            this.btn_home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_home.Checked = true;
            this.btn_home.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_home.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_home.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_home.Location = new System.Drawing.Point(30, 121);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(149, 43);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_home.UseTransparentBackground = true;
            this.btn_home.CheckedChanged += new System.EventHandler(this.btn_home_CheckedChanged);
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 648);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidepicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button minimize_btn;
        private Guna.UI2.WinForms.Guna2Button maximize_btn;
        private System.Windows.Forms.Label label_header_main;
        private Guna.UI2.WinForms.Guna2Button close_btn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private System.Windows.Forms.PictureBox sidepicture;
        private Guna.UI2.WinForms.Guna2Button History_btn;
        private Guna.UI2.WinForms.Guna2Button dispatch_btn;
        private Guna.UI2.WinForms.Guna2Button manufacturer_btn;
        private Guna.UI2.WinForms.Guna2Button products_btn;
        private Guna.UI2.WinForms.Guna2Button btn_home;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel main_panel;
    }
}

