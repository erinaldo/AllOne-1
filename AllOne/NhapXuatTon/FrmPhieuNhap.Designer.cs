namespace AllOne
{
    partial class FrmPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuNhap));
            this.grid = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTienTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblTongSL = new System.Windows.Forms.ToolStripLabel();
            this.txtTongSL = new System.Windows.Forms.ToolStripTextBox();
            this.lblTongTien = new System.Windows.Forms.ToolStripLabel();
            this.txtTongTien = new System.Windows.Forms.ToolStripTextBox();
            this.lblMaTienTe = new System.Windows.Forms.ToolStripLabel();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNCC = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblKhoNhap = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.bttTimKiem = new System.Windows.Forms.Button();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bttLuuVaIn = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 30;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa,
            this.MaSP,
            this.MaMau,
            this.TenSP,
            this.TenDVT,
            this.SoLuong,
            this.GiaNhap,
            this.ThanhTienNhap,
            this.MaTienTe,
            this.GhiChu});
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(2, 56);
            this.grid.Name = "grid";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 30;
            this.grid.RowTemplate.Height = 30;
            this.grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.Size = new System.Drawing.Size(1087, 298);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 1;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            this.grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValueChanged);
            this.grid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grid_RowsAdded);
            this.grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grid_RowsRemoved);
            this.grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridPN_KeyDown);
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.Xoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.Xoa.FillWeight = 66.81474F;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 50;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MaSP.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.MaMau.ReadOnly = true;
            this.MaMau.Width = 80;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TenSP.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenDVT.DefaultCellStyle = dataGridViewCellStyle5;
            this.TenDVT.FillWeight = 66.81474F;
            this.TenDVT.HeaderText = "Đơn vị tính";
            this.TenDVT.Name = "TenDVT";
            this.TenDVT.ReadOnly = true;
            this.TenDVT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenDVT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Format = "N0";
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle6;
            this.SoLuong.FillWeight = 66.81474F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Format = "N3";
            this.GiaNhap.DefaultCellStyle = dataGridViewCellStyle7;
            this.GiaNhap.FillWeight = 66.81474F;
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GiaNhap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ThanhTienNhap
            // 
            this.ThanhTienNhap.DataPropertyName = "ThanhTienNhap";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N3";
            this.ThanhTienNhap.DefaultCellStyle = dataGridViewCellStyle8;
            this.ThanhTienNhap.FillWeight = 66.81474F;
            this.ThanhTienNhap.HeaderText = "Thành tiền";
            this.ThanhTienNhap.Name = "ThanhTienNhap";
            this.ThanhTienNhap.ReadOnly = true;
            this.ThanhTienNhap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThanhTienNhap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ThanhTienNhap.Width = 140;
            // 
            // MaTienTe
            // 
            this.MaTienTe.DataPropertyName = "MaTienTe";
            this.MaTienTe.HeaderText = "Mã tiền tệ";
            this.MaTienTe.Name = "MaTienTe";
            this.MaTienTe.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GhiChu.DefaultCellStyle = dataGridViewCellStyle9;
            this.GhiChu.FillWeight = 66.81474F;
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.GhiChu.Width = 150;
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
            this.lblTongSL,
            this.txtTongSL,
            this.lblTongTien,
            this.txtTongTien,
            this.lblMaTienTe});
            this.bdn.Location = new System.Drawing.Point(0, 357);
            this.bdn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bdn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdn.Name = "bdn";
            this.bdn.PositionItem = this.bindingNavigatorPositionItem;
            this.bdn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bdn.Size = new System.Drawing.Size(1091, 45);
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
            // lblTongSL
            // 
            this.lblTongSL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongSL.Name = "lblTongSL";
            this.lblTongSL.Size = new System.Drawing.Size(86, 42);
            this.lblTongSL.Text = "Tổng số lượng";
            // 
            // txtTongSL
            // 
            this.txtTongSL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTongSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongSL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTongSL.ForeColor = System.Drawing.Color.Blue;
            this.txtTongSL.Name = "txtTongSL";
            this.txtTongSL.ReadOnly = true;
            this.txtTongSL.Size = new System.Drawing.Size(100, 45);
            this.txtTongSL.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(60, 42);
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.Blue;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(100, 45);
            this.txtTongTien.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMaTienTe
            // 
            this.lblMaTienTe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaTienTe.ForeColor = System.Drawing.Color.Green;
            this.lblMaTienTe.Name = "lblMaTienTe";
            this.lblMaTienTe.Size = new System.Drawing.Size(33, 42);
            this.lblMaTienTe.Text = "VND";
            this.lblMaTienTe.Visible = false;
            // 
            // bttLuu
            // 
            this.bttLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttLuu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Image = ((System.Drawing.Image)(resources.GetObject("bttLuu.Image")));
            this.bttLuu.Location = new System.Drawing.Point(888, 359);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(92, 40);
            this.bttLuu.TabIndex = 3;
            this.bttLuu.Text = "&Lưu";
            this.bttLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttLuu, "Lưu (Alt+L)");
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttXoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Image = ((System.Drawing.Image)(resources.GetObject("bttXoa.Image")));
            this.bttXoa.Location = new System.Drawing.Point(986, 359);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(92, 40);
            this.bttXoa.TabIndex = 4;
            this.bttXoa.Text = "&Xóa";
            this.bttXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttXoa, "Hủy (Alt+H)");
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNCC);
            this.panel1.Controls.Add(this.cboNCC);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.lblGhiChu);
            this.panel1.Controls.Add(this.lblNgayNhap);
            this.panel1.Controls.Add(this.lblKhoNhap);
            this.panel1.Controls.Add(this.txtMaPN);
            this.panel1.Controls.Add(this.bttTimKiem);
            this.panel1.Controls.Add(this.dtpNgayNhap);
            this.panel1.Controls.Add(this.cboKho);
            this.panel1.Controls.Add(this.lblSoPhieu);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 55);
            this.panel1.TabIndex = 5;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.ForeColor = System.Drawing.Color.White;
            this.lblNCC.Location = new System.Drawing.Point(215, 32);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(31, 15);
            this.lblNCC.TabIndex = 10;
            this.lblNCC.Text = "NCC";
            // 
            // cboNCC
            // 
            this.cboNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(282, 29);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(200, 23);
            this.cboNCC.TabIndex = 9;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(541, 5);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGhiChu.Size = new System.Drawing.Size(229, 44);
            this.txtGhiChu.TabIndex = 8;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.ForeColor = System.Drawing.Color.White;
            this.lblGhiChu.Location = new System.Drawing.Point(486, 8);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(49, 15);
            this.lblGhiChu.TabIndex = 7;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.ForeColor = System.Drawing.Color.White;
            this.lblNgayNhap.Location = new System.Drawing.Point(3, 29);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(66, 15);
            this.lblNgayNhap.TabIndex = 6;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblKhoNhap
            // 
            this.lblKhoNhap.AutoSize = true;
            this.lblKhoNhap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoNhap.ForeColor = System.Drawing.Color.White;
            this.lblKhoNhap.Location = new System.Drawing.Point(215, 6);
            this.lblKhoNhap.Name = "lblKhoNhap";
            this.lblKhoNhap.Size = new System.Drawing.Size(60, 15);
            this.lblKhoNhap.TabIndex = 5;
            this.lblKhoNhap.Text = "Kho nhập";
            // 
            // txtMaPN
            // 
            this.txtMaPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(84, 3);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.Size = new System.Drawing.Size(110, 21);
            this.txtMaPN.TabIndex = 4;
            // 
            // bttTimKiem
            // 
            this.bttTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("bttTimKiem.Image")));
            this.bttTimKiem.Location = new System.Drawing.Point(971, 6);
            this.bttTimKiem.Name = "bttTimKiem";
            this.bttTimKiem.Size = new System.Drawing.Size(105, 43);
            this.bttTimKiem.TabIndex = 3;
            this.bttTimKiem.Text = "&Tìm kiếm";
            this.bttTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttTimKiem, "Tìm kiếm (Alt+T)");
            this.bttTimKiem.UseVisualStyleBackColor = true;
            this.bttTimKiem.Click += new System.EventHandler(this.bttTimKiem_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(84, 29);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(110, 23);
            this.dtpNgayNhap.TabIndex = 2;
            // 
            // cboKho
            // 
            this.cboKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(282, 3);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(200, 23);
            this.cboKho.TabIndex = 1;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhieu.ForeColor = System.Drawing.Color.White;
            this.lblSoPhieu.Location = new System.Drawing.Point(3, 6);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(56, 15);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu";
            // 
            // bttLuuVaIn
            // 
            this.bttLuuVaIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttLuuVaIn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuuVaIn.Image = ((System.Drawing.Image)(resources.GetObject("bttLuuVaIn.Image")));
            this.bttLuuVaIn.Location = new System.Drawing.Point(790, 359);
            this.bttLuuVaIn.Name = "bttLuuVaIn";
            this.bttLuuVaIn.Size = new System.Drawing.Size(92, 40);
            this.bttLuuVaIn.TabIndex = 6;
            this.bttLuuVaIn.Text = "Lưu và in";
            this.bttLuuVaIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttLuuVaIn, "Lưu và in");
            this.bttLuuVaIn.UseVisualStyleBackColor = true;
            this.bttLuuVaIn.Click += new System.EventHandler(this.bttLuuVaIn_Click);
            // 
            // FrmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 408);
            this.Controls.Add(this.bttLuuVaIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bdn);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmPhieuNhap_Shown);
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
        private System.Windows.Forms.ToolStripLabel lblTongSL;
        private System.Windows.Forms.ToolStripTextBox txtTongSL;
        private System.Windows.Forms.ToolStripLabel lblTongTien;
        private System.Windows.Forms.ToolStripTextBox txtTongTien;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblKhoNhap;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Button bttTimKiem;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripLabel lblMaTienTe;
        private System.Windows.Forms.Button bttLuuVaIn;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTienTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}