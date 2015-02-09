namespace AllOne
{
    partial class FrmBOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBOM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bttTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.lblTenNL = new System.Windows.Forms.Label();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bttKhoa = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DinhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bdn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).BeginInit();
            this.bdn.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttTimKiem
            // 
            this.bttTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("bttTimKiem.Image")));
            this.bttTimKiem.Location = new System.Drawing.Point(981, 6);
            this.bttTimKiem.Name = "bttTimKiem";
            this.bttTimKiem.Size = new System.Drawing.Size(105, 43);
            this.bttTimKiem.TabIndex = 3;
            this.bttTimKiem.Text = "&Tìm kiếm";
            this.bttTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttTimKiem, "Tìm kiếm (Alt+T)");
            this.bttTimKiem.UseVisualStyleBackColor = true;
            this.bttTimKiem.Click += new System.EventHandler(this.bttTimKiem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Controls.Add(this.cboSanPham);
            this.panel1.Controls.Add(this.lblTenNL);
            this.panel1.Controls.Add(this.txtTenNL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaNL);
            this.panel1.Controls.Add(this.bttTimKiem);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 55);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(12, 28);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(83, 20);
            this.txtMaSP.TabIndex = 22;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            this.txtMaSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSP_KeyDown);
            // 
            // cboSanPham
            // 
            this.cboSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(101, 27);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(238, 22);
            this.cboSanPham.TabIndex = 21;
            this.cboSanPham.SelectedIndexChanged += new System.EventHandler(this.cboSanPham_SelectedIndexChanged);
            // 
            // lblTenNL
            // 
            this.lblTenNL.AutoSize = true;
            this.lblTenNL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNL.ForeColor = System.Drawing.Color.White;
            this.lblTenNL.Location = new System.Drawing.Point(451, 11);
            this.lblTenNL.Name = "lblTenNL";
            this.lblTenNL.Size = new System.Drawing.Size(95, 15);
            this.lblTenNL.TabIndex = 20;
            this.lblTenNL.Text = "Tên nguyên liệu";
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(451, 29);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(172, 20);
            this.txtTenNL.TabIndex = 19;
            this.txtTenNL.TextChanged += new System.EventHandler(this.txtTenNL_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(345, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã nguyên liệu";
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(345, 29);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(100, 20);
            this.txtMaNL.TabIndex = 17;
            this.txtMaNL.TextChanged += new System.EventHandler(this.txtMaNL_TextChanged);
            // 
            // bttKhoa
            // 
            this.bttKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttKhoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttKhoa.Image = ((System.Drawing.Image)(resources.GetObject("bttKhoa.Image")));
            this.bttKhoa.Location = new System.Drawing.Point(994, 362);
            this.bttKhoa.Name = "bttKhoa";
            this.bttKhoa.Size = new System.Drawing.Size(93, 43);
            this.bttKhoa.TabIndex = 14;
            this.bttKhoa.Text = "Khóa";
            this.bttKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttKhoa, "Xóa");
            this.bttKhoa.UseVisualStyleBackColor = true;
            this.bttKhoa.Click += new System.EventHandler(this.bttKhoa_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttHuy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Image = ((System.Drawing.Image)(resources.GetObject("bttHuy.Image")));
            this.bttHuy.Location = new System.Drawing.Point(896, 362);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(93, 43);
            this.bttHuy.TabIndex = 15;
            this.bttHuy.Text = "&Xuất excel";
            this.bttHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttHuy, "Hủy (Alt+H)");
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 40;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa,
            this.Khoa,
            this.MaSP,
            this.TenSP,
            this.MaNL,
            this.TenNL,
            this.TenDVT,
            this.DinhMuc,
            this.NgayTao,
            this.NguoiTao});
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(2, 59);
            this.grid.Name = "grid";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 30;
            this.grid.RowTemplate.Height = 30;
            this.grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.Size = new System.Drawing.Size(1097, 298);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 6;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            this.grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValueChanged);
            this.grid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            this.grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.FillWeight = 66.81474F;
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 50;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khóa";
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            this.Khoa.Width = 50;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MaSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaSP.FillWeight = 365.4822F;
            this.MaSP.HeaderText = "Mã hàng";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MaSP.Width = 80;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TenSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenSP.FillWeight = 66.81474F;
            this.TenSP.HeaderText = "Tên hàng";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TenSP.Width = 150;
            // 
            // MaNL
            // 
            this.MaNL.DataPropertyName = "MaNL";
            this.MaNL.HeaderText = "Mã nguyên liệu";
            this.MaNL.Name = "MaNL";
            this.MaNL.ReadOnly = true;
            this.MaNL.Width = 80;
            // 
            // TenNL
            // 
            this.TenNL.DataPropertyName = "TenNL";
            this.TenNL.HeaderText = "Tên nguyên liệu";
            this.TenNL.Name = "TenNL";
            this.TenNL.ReadOnly = true;
            this.TenNL.Width = 120;
            // 
            // TenDVT
            // 
            this.TenDVT.DataPropertyName = "TenDVT";
            this.TenDVT.HeaderText = "Đơn vị tính";
            this.TenDVT.Name = "TenDVT";
            this.TenDVT.ReadOnly = true;
            // 
            // DinhMuc
            // 
            this.DinhMuc.DataPropertyName = "DinhMuc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Format = "N4";
            this.DinhMuc.DefaultCellStyle = dataGridViewCellStyle4;
            this.DinhMuc.HeaderText = "Định mức";
            this.DinhMuc.Name = "DinhMuc";
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy HH:mm";
            this.NgayTao.DefaultCellStyle = dataGridViewCellStyle5;
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            // 
            // NguoiTao
            // 
            this.NguoiTao.DataPropertyName = "NguoiTao";
            this.NguoiTao.HeaderText = "Người tạo";
            this.NguoiTao.Name = "NguoiTao";
            this.NguoiTao.ReadOnly = true;
            this.NguoiTao.Width = 80;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 42);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bdn
            // 
            this.bdn.AddNewItem = null;
            this.bdn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdn.AutoSize = false;
            this.bdn.CountItem = this.bindingNavigatorCountItem;
            this.bdn.DeleteItem = null;
            this.bdn.Dock = System.Windows.Forms.DockStyle.None;
            this.bdn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bdn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bdn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bdn.Location = new System.Drawing.Point(0, 360);
            this.bdn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bdn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdn.Name = "bdn";
            this.bdn.PositionItem = this.bindingNavigatorPositionItem;
            this.bdn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bdn.Size = new System.Drawing.Size(1101, 45);
            this.bdn.TabIndex = 7;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // FrmBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 408);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttKhoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.bdn);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmBOM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOM(Bill of material)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmBaoGia_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).EndInit();
            this.bdn.ResumeLayout(false);
            this.bdn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNgayBG;
        private System.Windows.Forms.Button bttTimKiem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.BindingNavigator bdn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.Label lblTenNL;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Button bttKhoa;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DinhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiTao;
    }
}