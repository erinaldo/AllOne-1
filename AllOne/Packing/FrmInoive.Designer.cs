namespace AllOne.Packing
{
    partial class FrmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bttXoa = new System.Windows.Forms.Button();
            this.cboInvoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttTaoMoi = new System.Windows.Forms.Button();
            this.bttXuatExcel = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaGoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetPerPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).BeginInit();
            this.bdn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.bdn.Location = new System.Drawing.Point(0, 414);
            this.bdn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bdn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdn.Name = "bdn";
            this.bdn.PositionItem = this.bindingNavigatorPositionItem;
            this.bdn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bdn.Size = new System.Drawing.Size(1281, 45);
            this.bdn.TabIndex = 13;
            this.bdn.RefreshItems += new System.EventHandler(this.bdn_RefreshItems);
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
            this.GiaGoc,
            this.GiaBan,
            this.ThanhTien,
            this.W,
            this.L,
            this.H,
            this.SetPerPallet});
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(2, 61);
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
            this.grid.Size = new System.Drawing.Size(1277, 350);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 12;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValueChanged);
            this.grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.ForeColor = System.Drawing.Color.White;
            this.lblNgay.Location = new System.Drawing.Point(228, 4);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(61, 15);
            this.lblNgay.TabIndex = 12;
            this.lblNgay.Text = "StartDate";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(304, 1);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(105, 23);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhieu.ForeColor = System.Drawing.Color.White;
            this.lblSoPhieu.Location = new System.Drawing.Point(1, 6);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(62, 15);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "InvoiceNo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bttXuatExcel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboInvoice);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.lblNgay);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.lblSoPhieu);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 60);
            this.panel1.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(228, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 42;
            this.label15.Text = "EndDate";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(304, 28);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(105, 23);
            this.dtpEnd.TabIndex = 2;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // bttSua
            // 
            this.bttSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttSua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Image = ((System.Drawing.Image)(resources.GetObject("bttSua.Image")));
            this.bttSua.Location = new System.Drawing.Point(1086, 415);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(92, 40);
            this.bttSua.TabIndex = 15;
            this.bttSua.Text = "Sửa";
            this.bttSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttSua, "Sửa");
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttLuu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Image = ((System.Drawing.Image)(resources.GetObject("bttLuu.Image")));
            this.bttLuu.Location = new System.Drawing.Point(890, 417);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(92, 40);
            this.bttLuu.TabIndex = 14;
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
            this.bttXoa.Location = new System.Drawing.Point(1184, 414);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(92, 40);
            this.bttXoa.TabIndex = 17;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttXoa, "Xóa");
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // cboInvoice
            // 
            this.cboInvoice.FormattingEnabled = true;
            this.cboInvoice.Location = new System.Drawing.Point(69, 5);
            this.cboInvoice.Name = "cboInvoice";
            this.cboInvoice.Size = new System.Drawing.Size(121, 22);
            this.cboInvoice.TabIndex = 43;
            this.toolTip1.SetToolTip(this.cboInvoice, "Nhập mã Invoice để tạo mới");
            this.cboInvoice.SelectedIndexChanged += new System.EventHandler(this.cboInvoice_SelectedIndexChanged);
            this.cboInvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPO_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 14);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nhập mã invoice, Enter để tìm nhanh";
            // 
            // bttTaoMoi
            // 
            this.bttTaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttTaoMoi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTaoMoi.Image = ((System.Drawing.Image)(resources.GetObject("bttTaoMoi.Image")));
            this.bttTaoMoi.Location = new System.Drawing.Point(988, 417);
            this.bttTaoMoi.Name = "bttTaoMoi";
            this.bttTaoMoi.Size = new System.Drawing.Size(92, 40);
            this.bttTaoMoi.TabIndex = 18;
            this.bttTaoMoi.Text = "Tạo mới";
            this.bttTaoMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttTaoMoi, "Lưu (Alt+L)");
            this.bttTaoMoi.UseVisualStyleBackColor = true;
            this.bttTaoMoi.Click += new System.EventHandler(this.bttTaoMoi_Click);
            // 
            // bttXuatExcel
            // 
            this.bttXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttXuatExcel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("bttXuatExcel.Image")));
            this.bttXuatExcel.Location = new System.Drawing.Point(1122, 6);
            this.bttXuatExcel.Name = "bttXuatExcel";
            this.bttXuatExcel.Size = new System.Drawing.Size(113, 40);
            this.bttXuatExcel.TabIndex = 45;
            this.bttXuatExcel.Text = "Xuất excel";
            this.bttXuatExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttXuatExcel, "Lưu (Alt+L)");
            this.bttXuatExcel.UseVisualStyleBackColor = true;
            this.bttXuatExcel.Click += new System.EventHandler(this.bttXuatExcel_Click);
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.FillWeight = 66.81474F;
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MaSP.DefaultCellStyle = dataGridViewCellStyle2;
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
            // TenDVT
            // 
            this.TenDVT.DataPropertyName = "TenDVT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenDVT.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Format = "N0";
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle5;
            this.SoLuong.FillWeight = 66.81474F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.SoLuong.Width = 80;
            // 
            // GiaGoc
            // 
            this.GiaGoc.DataPropertyName = "GiaGoc";
            this.GiaGoc.HeaderText = "Giá gốc";
            this.GiaGoc.Name = "GiaGoc";
            this.GiaGoc.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Format = "N3";
            this.GiaBan.DefaultCellStyle = dataGridViewCellStyle6;
            this.GiaBan.FillWeight = 66.81474F;
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GiaBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N3";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle7;
            this.ThanhTien.FillWeight = 66.81474F;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ThanhTien.Width = 120;
            // 
            // W
            // 
            this.W.DataPropertyName = "W";
            this.W.HeaderText = "W";
            this.W.Name = "W";
            this.W.ReadOnly = true;
            this.W.Width = 50;
            // 
            // L
            // 
            this.L.DataPropertyName = "L";
            this.L.HeaderText = "L";
            this.L.Name = "L";
            this.L.ReadOnly = true;
            this.L.Width = 50;
            // 
            // H
            // 
            this.H.DataPropertyName = "H";
            this.H.HeaderText = "H";
            this.H.Name = "H";
            this.H.ReadOnly = true;
            this.H.Width = 50;
            // 
            // SetPerPallet
            // 
            this.SetPerPallet.DataPropertyName = "SetPerPallet";
            this.SetPerPallet.HeaderText = "SetPerPallet";
            this.SetPerPallet.Name = "SetPerPallet";
            this.SetPerPallet.ReadOnly = true;
            this.SetPerPallet.Width = 80;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 462);
            this.Controls.Add(this.bttTaoMoi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bdn);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPackinglist_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).EndInit();
            this.bdn.ResumeLayout(false);
            this.bdn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.ToolStripLabel lblMaTienTe;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cboInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttTaoMoi;
        private System.Windows.Forms.Button bttXuatExcel;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaGoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn L;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetPerPallet;
    }
}