namespace AllOne
{
    partial class FrmKiemKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKiemKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.bdn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtMaSP = new System.Windows.Forms.ToolStripTextBox();
            this.txtTenSP = new System.Windows.Forms.ToolStripTextBox();
            this.cboNhomSP = new System.Windows.Forms.ToolStripComboBox();
            this.bttXuatExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttDieuChinhTK = new System.Windows.Forms.Button();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblKho = new System.Windows.Forms.Label();
            this.bttTimKiem = new System.Windows.Forms.Button();
            this.dtpThangKK = new System.Windows.Forms.DateTimePicker();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bttInBC = new System.Windows.Forms.Button();
            this.Khoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLKiemKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLDieuChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoDieuChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).BeginInit();
            this.bdn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.grid.ColumnHeadersHeight = 40;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Khoa,
            this.MaKho,
            this.TenNhom,
            this.MaSP,
            this.MaMau,
            this.TenSP,
            this.TenDVT,
            this.SLTonKho,
            this.SLKiemKe,
            this.SLDieuChinh,
            this.LyDoDieuChinh});
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(2, 56);
            this.grid.Name = "grid";
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 30;
            this.grid.RowTemplate.Height = 30;
            this.grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.Size = new System.Drawing.Size(986, 298);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 1;
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            this.grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValueChanged);
            this.grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridPN_KeyDown);
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
            this.bindingNavigatorSeparator2,
            this.txtMaSP,
            this.txtTenSP,
            this.cboNhomSP});
            this.bdn.Location = new System.Drawing.Point(0, 357);
            this.bdn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bdn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdn.Name = "bdn";
            this.bdn.PositionItem = this.bindingNavigatorPositionItem;
            this.bdn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bdn.Size = new System.Drawing.Size(990, 45);
            this.bdn.TabIndex = 2;
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtMaSP.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 45);
            this.txtMaSP.Text = "Mã sản phẩm";
            this.txtMaSP.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaSP.Enter += new System.EventHandler(this.txtMaSP_Enter);
            this.txtMaSP.Leave += new System.EventHandler(this.txtMaSP_Leave);
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTenSP.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(100, 45);
            this.txtTenSP.Text = "Tên sản phẩm";
            this.txtTenSP.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTenSP.Enter += new System.EventHandler(this.txtTenSP_Enter);
            this.txtTenSP.Leave += new System.EventHandler(this.txtTenSP_Leave);
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // cboNhomSP
            // 
            this.cboNhomSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboNhomSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomSP.Name = "cboNhomSP";
            this.cboNhomSP.Size = new System.Drawing.Size(121, 45);
            this.cboNhomSP.SelectedIndexChanged += new System.EventHandler(this.cboNhomSP_SelectedIndexChanged);
            // 
            // bttXuatExcel
            // 
            this.bttXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttXuatExcel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("bttXuatExcel.Image")));
            this.bttXuatExcel.Location = new System.Drawing.Point(896, 359);
            this.bttXuatExcel.Name = "bttXuatExcel";
            this.bttXuatExcel.Size = new System.Drawing.Size(92, 40);
            this.bttXuatExcel.TabIndex = 4;
            this.bttXuatExcel.Text = "&Xuất excel";
            this.bttXuatExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttXuatExcel, "Xuất excel");
            this.bttXuatExcel.UseVisualStyleBackColor = true;
            this.bttXuatExcel.Click += new System.EventHandler(this.bttXuatExcel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bttDieuChinhTK);
            this.panel1.Controls.Add(this.lblNgayNhap);
            this.panel1.Controls.Add(this.lblKho);
            this.panel1.Controls.Add(this.bttTimKiem);
            this.panel1.Controls.Add(this.dtpThangKK);
            this.panel1.Controls.Add(this.cboKho);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 55);
            this.panel1.TabIndex = 5;
            // 
            // bttDieuChinhTK
            // 
            this.bttDieuChinhTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttDieuChinhTK.Image = ((System.Drawing.Image)(resources.GetObject("bttDieuChinhTK.Image")));
            this.bttDieuChinhTK.Location = new System.Drawing.Point(759, 7);
            this.bttDieuChinhTK.Name = "bttDieuChinhTK";
            this.bttDieuChinhTK.Size = new System.Drawing.Size(105, 43);
            this.bttDieuChinhTK.TabIndex = 7;
            this.bttDieuChinhTK.Text = "&Điều chỉnh tồn";
            this.bttDieuChinhTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttDieuChinhTK, "Điều chỉnh tồn");
            this.bttDieuChinhTK.UseVisualStyleBackColor = true;
            this.bttDieuChinhTK.Click += new System.EventHandler(this.bttDieuChinhTK_Click);
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.ForeColor = System.Drawing.Color.White;
            this.lblNgayNhap.Location = new System.Drawing.Point(10, 19);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(42, 15);
            this.lblNgayNhap.TabIndex = 6;
            this.lblNgayNhap.Text = "Tháng";
            // 
            // lblKho
            // 
            this.lblKho.AutoSize = true;
            this.lblKho.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKho.ForeColor = System.Drawing.Color.White;
            this.lblKho.Location = new System.Drawing.Point(162, 20);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(29, 15);
            this.lblKho.TabIndex = 5;
            this.lblKho.Text = "Kho";
            // 
            // bttTimKiem
            // 
            this.bttTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("bttTimKiem.Image")));
            this.bttTimKiem.Location = new System.Drawing.Point(870, 6);
            this.bttTimKiem.Name = "bttTimKiem";
            this.bttTimKiem.Size = new System.Drawing.Size(105, 43);
            this.bttTimKiem.TabIndex = 3;
            this.bttTimKiem.Text = "&Tìm kiếm";
            this.bttTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttTimKiem, "Tìm kiếm (Alt+T)");
            this.bttTimKiem.UseVisualStyleBackColor = true;
            this.bttTimKiem.Click += new System.EventHandler(this.bttTimKiem_Click);
            // 
            // dtpThangKK
            // 
            this.dtpThangKK.CustomFormat = "MM-yyyy";
            this.dtpThangKK.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangKK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangKK.Location = new System.Drawing.Point(58, 17);
            this.dtpThangKK.Name = "dtpThangKK";
            this.dtpThangKK.Size = new System.Drawing.Size(91, 23);
            this.dtpThangKK.TabIndex = 2;
            this.dtpThangKK.ValueChanged += new System.EventHandler(this.dtpThangKK_ValueChanged);
            // 
            // cboKho
            // 
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(197, 17);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(200, 23);
            this.cboKho.TabIndex = 1;
            this.cboKho.SelectedIndexChanged += new System.EventHandler(this.cboKho_SelectedIndexChanged);
            // 
            // bttInBC
            // 
            this.bttInBC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttInBC.Image = ((System.Drawing.Image)(resources.GetObject("bttInBC.Image")));
            this.bttInBC.Location = new System.Drawing.Point(785, 358);
            this.bttInBC.Name = "bttInBC";
            this.bttInBC.Size = new System.Drawing.Size(105, 43);
            this.bttInBC.TabIndex = 14;
            this.bttInBC.Text = "&In";
            this.bttInBC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttInBC, "In");
            this.bttInBC.UseVisualStyleBackColor = true;
            this.bttInBC.Click += new System.EventHandler(this.bttInBC_Click);
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khóa";
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            this.Khoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Khoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Khoa.Width = 40;
            // 
            // MaKho
            // 
            this.MaKho.DataPropertyName = "MaKho";
            this.MaKho.HeaderText = "MaKho";
            this.MaKho.Name = "MaKho";
            this.MaKho.ReadOnly = true;
            this.MaKho.Visible = false;
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Nhóm";
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.ReadOnly = true;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MaSP.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaSP.FillWeight = 365.4822F;
            this.MaSP.HeaderText = "Mã hàng";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MaSP.Width = 80;
            // 
            // MaMau
            // 
            this.MaMau.DataPropertyName = "MaMau";
            this.MaMau.HeaderText = "Mã màu";
            this.MaMau.Name = "MaMau";
            this.MaMau.Width = 80;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TenSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenSP.FillWeight = 66.81474F;
            this.TenSP.HeaderText = "Tên hàng";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TenSP.Width = 200;
            // 
            // TenDVT
            // 
            this.TenDVT.DataPropertyName = "TenDVT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenDVT.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenDVT.FillWeight = 66.81474F;
            this.TenDVT.HeaderText = "Đơn vị tính";
            this.TenDVT.Name = "TenDVT";
            this.TenDVT.ReadOnly = true;
            this.TenDVT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenDVT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // SLTonKho
            // 
            this.SLTonKho.DataPropertyName = "SLTonKho";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.SLTonKho.DefaultCellStyle = dataGridViewCellStyle4;
            this.SLTonKho.FillWeight = 66.81474F;
            this.SLTonKho.HeaderText = "Số lượng tồn kho";
            this.SLTonKho.Name = "SLTonKho";
            this.SLTonKho.ReadOnly = true;
            this.SLTonKho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SLTonKho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.SLTonKho.Width = 140;
            // 
            // SLKiemKe
            // 
            this.SLKiemKe.DataPropertyName = "SLKiemKe";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Format = "N0";
            this.SLKiemKe.DefaultCellStyle = dataGridViewCellStyle5;
            this.SLKiemKe.FillWeight = 66.81474F;
            this.SLKiemKe.HeaderText = "Số lượng kiểm kê";
            this.SLKiemKe.Name = "SLKiemKe";
            this.SLKiemKe.ReadOnly = true;
            this.SLKiemKe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SLKiemKe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.SLKiemKe.Width = 140;
            // 
            // SLDieuChinh
            // 
            this.SLDieuChinh.DataPropertyName = "SLDieuChinh";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.SLDieuChinh.DefaultCellStyle = dataGridViewCellStyle6;
            this.SLDieuChinh.HeaderText = "Chênh lệch";
            this.SLDieuChinh.Name = "SLDieuChinh";
            this.SLDieuChinh.ReadOnly = true;
            // 
            // LyDoDieuChinh
            // 
            this.LyDoDieuChinh.DataPropertyName = "LyDoDieuChinh";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LyDoDieuChinh.DefaultCellStyle = dataGridViewCellStyle7;
            this.LyDoDieuChinh.FillWeight = 66.81474F;
            this.LyDoDieuChinh.HeaderText = "Lý do";
            this.LyDoDieuChinh.Name = "LyDoDieuChinh";
            this.LyDoDieuChinh.ReadOnly = true;
            this.LyDoDieuChinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LyDoDieuChinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.LyDoDieuChinh.Width = 200;
            // 
            // FrmKiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 408);
            this.Controls.Add(this.bttInBC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttXuatExcel);
            this.Controls.Add(this.bdn);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmKiemKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kiểm kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmKiemKe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).EndInit();
            this.bdn.ResumeLayout(false);
            this.bdn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.BindingNavigator bdn;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button bttXuatExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblKho;
        private System.Windows.Forms.Button bttTimKiem;
        private System.Windows.Forms.DateTimePicker dtpThangKK;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bttDieuChinhTK;
        private System.Windows.Forms.ToolStripTextBox txtMaSP;
        private System.Windows.Forms.ToolStripTextBox txtTenSP;
        private System.Windows.Forms.ToolStripComboBox cboNhomSP;
        private System.Windows.Forms.Button bttInBC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLKiemKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLDieuChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoDieuChinh;
    }
}