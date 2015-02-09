namespace AllOne
{
    partial class FrmDuToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuToan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTongGC = new System.Windows.Forms.Label();
            this.txtTongGC = new AMS.TextBox.NumericTextBox();
            this.lblGiaQL = new System.Windows.Forms.Label();
            this.txtGiaQL = new AMS.TextBox.NumericTextBox();
            this.lblGiaGT = new System.Windows.Forms.Label();
            this.lblLoiNhuan = new System.Windows.Forms.Label();
            this.txtGiaGT = new AMS.TextBox.NumericTextBox();
            this.lblGiaTT = new System.Windows.Forms.Label();
            this.txtLoiNhuan = new AMS.TextBox.NumericTextBox();
            this.txtGiaTT = new AMS.TextBox.NumericTextBox();
            this.lblTienQL = new System.Windows.Forms.Label();
            this.txtTienQL = new AMS.TextBox.NumericTextBox();
            this.lblTienGT = new System.Windows.Forms.Label();
            this.txtTienGT = new AMS.TextBox.NumericTextBox();
            this.lblTienTT = new System.Windows.Forms.Label();
            this.txtTienTT = new AMS.TextBox.NumericTextBox();
            this.bttLuu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttKhoa = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Khoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGioCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanTramLoiNhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.ForeColor = System.Drawing.Color.White;
            this.lblNgay.Location = new System.Drawing.Point(3, 5);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(42, 15);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Tháng";
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "yyyyMM";
            this.dtpThang.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(9, 26);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.ShowUpDown = true;
            this.dtpThang.Size = new System.Drawing.Size(116, 23);
            this.dtpThang.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTongGC);
            this.panel1.Controls.Add(this.txtTongGC);
            this.panel1.Controls.Add(this.lblGiaQL);
            this.panel1.Controls.Add(this.txtGiaQL);
            this.panel1.Controls.Add(this.lblGiaGT);
            this.panel1.Controls.Add(this.lblLoiNhuan);
            this.panel1.Controls.Add(this.txtGiaGT);
            this.panel1.Controls.Add(this.lblGiaTT);
            this.panel1.Controls.Add(this.txtLoiNhuan);
            this.panel1.Controls.Add(this.txtGiaTT);
            this.panel1.Controls.Add(this.lblTienQL);
            this.panel1.Controls.Add(this.txtTienQL);
            this.panel1.Controls.Add(this.lblTienGT);
            this.panel1.Controls.Add(this.txtTienGT);
            this.panel1.Controls.Add(this.lblTienTT);
            this.panel1.Controls.Add(this.txtTienTT);
            this.panel1.Controls.Add(this.lblNgay);
            this.panel1.Controls.Add(this.dtpThang);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 59);
            this.panel1.TabIndex = 10;
            // 
            // lblTongGC
            // 
            this.lblTongGC.AutoSize = true;
            this.lblTongGC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGC.ForeColor = System.Drawing.Color.White;
            this.lblTongGC.Location = new System.Drawing.Point(498, 2);
            this.lblTongGC.Name = "lblTongGC";
            this.lblTongGC.Size = new System.Drawing.Size(88, 15);
            this.lblTongGC.TabIndex = 24;
            this.lblTongGC.Text = "Tổng giờ công";
            // 
            // txtTongGC
            // 
            this.txtTongGC.AllowNegative = true;
            this.txtTongGC.DigitsInGroup = 3;
            this.txtTongGC.Flags = 0;
            this.txtTongGC.Location = new System.Drawing.Point(502, 26);
            this.txtTongGC.MaxDecimalPlaces = 3;
            this.txtTongGC.MaxWholeDigits = 12;
            this.txtTongGC.Name = "txtTongGC";
            this.txtTongGC.Prefix = "";
            this.txtTongGC.RangeMax = 1.7976931348623157E+308D;
            this.txtTongGC.RangeMin = -1.7976931348623157E+308D;
            this.txtTongGC.Size = new System.Drawing.Size(116, 21);
            this.txtTongGC.TabIndex = 4;
            this.txtTongGC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTongGC.TextChanged += new System.EventHandler(this.txtTongGC_TextChanged);
            // 
            // lblGiaQL
            // 
            this.lblGiaQL.AutoSize = true;
            this.lblGiaQL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaQL.ForeColor = System.Drawing.Color.White;
            this.lblGiaQL.Location = new System.Drawing.Point(876, 2);
            this.lblGiaQL.Name = "lblGiaQL";
            this.lblGiaQL.Size = new System.Drawing.Size(92, 15);
            this.lblGiaQL.TabIndex = 22;
            this.lblGiaQL.Text = "Giá tiền quản lý";
            // 
            // txtGiaQL
            // 
            this.txtGiaQL.AllowNegative = true;
            this.txtGiaQL.DigitsInGroup = 3;
            this.txtGiaQL.Flags = 0;
            this.txtGiaQL.Location = new System.Drawing.Point(876, 26);
            this.txtGiaQL.MaxDecimalPlaces = 3;
            this.txtGiaQL.MaxWholeDigits = 12;
            this.txtGiaQL.Name = "txtGiaQL";
            this.txtGiaQL.Prefix = "";
            this.txtGiaQL.RangeMax = 1.7976931348623157E+308D;
            this.txtGiaQL.RangeMin = -1.7976931348623157E+308D;
            this.txtGiaQL.ReadOnly = true;
            this.txtGiaQL.Size = new System.Drawing.Size(116, 21);
            this.txtGiaQL.TabIndex = 7;
            this.txtGiaQL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGiaGT
            // 
            this.lblGiaGT.AutoSize = true;
            this.lblGiaGT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGT.ForeColor = System.Drawing.Color.White;
            this.lblGiaGT.Location = new System.Drawing.Point(752, 2);
            this.lblGiaGT.Name = "lblGiaGT";
            this.lblGiaGT.Size = new System.Drawing.Size(67, 15);
            this.lblGiaGT.TabIndex = 20;
            this.lblGiaGT.Text = "Giá tiền GT";
            // 
            // lblLoiNhuan
            // 
            this.lblLoiNhuan.AutoSize = true;
            this.lblLoiNhuan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiNhuan.ForeColor = System.Drawing.Color.White;
            this.lblLoiNhuan.Location = new System.Drawing.Point(1000, 5);
            this.lblLoiNhuan.Name = "lblLoiNhuan";
            this.lblLoiNhuan.Size = new System.Drawing.Size(76, 15);
            this.lblLoiNhuan.TabIndex = 16;
            this.lblLoiNhuan.Text = "% Lợi nhuận";
            // 
            // txtGiaGT
            // 
            this.txtGiaGT.AllowNegative = true;
            this.txtGiaGT.DigitsInGroup = 3;
            this.txtGiaGT.Flags = 0;
            this.txtGiaGT.Location = new System.Drawing.Point(752, 26);
            this.txtGiaGT.MaxDecimalPlaces = 3;
            this.txtGiaGT.MaxWholeDigits = 12;
            this.txtGiaGT.Name = "txtGiaGT";
            this.txtGiaGT.Prefix = "";
            this.txtGiaGT.RangeMax = 1.7976931348623157E+308D;
            this.txtGiaGT.RangeMin = -1.7976931348623157E+308D;
            this.txtGiaGT.ReadOnly = true;
            this.txtGiaGT.Size = new System.Drawing.Size(116, 21);
            this.txtGiaGT.TabIndex = 6;
            this.txtGiaGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGiaTT
            // 
            this.lblGiaTT.AutoSize = true;
            this.lblGiaTT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTT.ForeColor = System.Drawing.Color.White;
            this.lblGiaTT.Location = new System.Drawing.Point(629, 2);
            this.lblGiaTT.Name = "lblGiaTT";
            this.lblGiaTT.Size = new System.Drawing.Size(66, 15);
            this.lblGiaTT.TabIndex = 18;
            this.lblGiaTT.Text = "Giá tiền TT";
            // 
            // txtLoiNhuan
            // 
            this.txtLoiNhuan.AllowNegative = true;
            this.txtLoiNhuan.DigitsInGroup = 3;
            this.txtLoiNhuan.Flags = 0;
            this.txtLoiNhuan.Location = new System.Drawing.Point(1000, 26);
            this.txtLoiNhuan.MaxDecimalPlaces = 3;
            this.txtLoiNhuan.MaxWholeDigits = 12;
            this.txtLoiNhuan.Name = "txtLoiNhuan";
            this.txtLoiNhuan.Prefix = "";
            this.txtLoiNhuan.RangeMax = 1.7976931348623157E+308D;
            this.txtLoiNhuan.RangeMin = -1.7976931348623157E+308D;
            this.txtLoiNhuan.Size = new System.Drawing.Size(116, 21);
            this.txtLoiNhuan.TabIndex = 9;
            this.txtLoiNhuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGiaTT
            // 
            this.txtGiaTT.AllowNegative = true;
            this.txtGiaTT.DigitsInGroup = 3;
            this.txtGiaTT.Flags = 0;
            this.txtGiaTT.Location = new System.Drawing.Point(629, 26);
            this.txtGiaTT.MaxDecimalPlaces = 3;
            this.txtGiaTT.MaxWholeDigits = 12;
            this.txtGiaTT.Name = "txtGiaTT";
            this.txtGiaTT.Prefix = "";
            this.txtGiaTT.RangeMax = 1.7976931348623157E+308D;
            this.txtGiaTT.RangeMin = -1.7976931348623157E+308D;
            this.txtGiaTT.ReadOnly = true;
            this.txtGiaTT.Size = new System.Drawing.Size(116, 21);
            this.txtGiaTT.TabIndex = 5;
            this.txtGiaTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTienQL
            // 
            this.lblTienQL.AutoSize = true;
            this.lblTienQL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienQL.ForeColor = System.Drawing.Color.White;
            this.lblTienQL.Location = new System.Drawing.Point(378, 2);
            this.lblTienQL.Name = "lblTienQL";
            this.lblTienQL.Size = new System.Drawing.Size(74, 15);
            this.lblTienQL.TabIndex = 12;
            this.lblTienQL.Text = "Tiền quản lý";
            // 
            // txtTienQL
            // 
            this.txtTienQL.AllowNegative = true;
            this.txtTienQL.DigitsInGroup = 3;
            this.txtTienQL.Flags = 0;
            this.txtTienQL.Location = new System.Drawing.Point(378, 26);
            this.txtTienQL.MaxDecimalPlaces = 3;
            this.txtTienQL.MaxWholeDigits = 12;
            this.txtTienQL.Name = "txtTienQL";
            this.txtTienQL.Prefix = "";
            this.txtTienQL.RangeMax = 1.7976931348623157E+308D;
            this.txtTienQL.RangeMin = -1.7976931348623157E+308D;
            this.txtTienQL.Size = new System.Drawing.Size(116, 21);
            this.txtTienQL.TabIndex = 3;
            this.txtTienQL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienQL.TextChanged += new System.EventHandler(this.txtTienQL_TextChanged);
            // 
            // lblTienGT
            // 
            this.lblTienGT.AutoSize = true;
            this.lblTienGT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienGT.ForeColor = System.Drawing.Color.White;
            this.lblTienGT.Location = new System.Drawing.Point(254, 2);
            this.lblTienGT.Name = "lblTienGT";
            this.lblTienGT.Size = new System.Drawing.Size(68, 15);
            this.lblTienGT.TabIndex = 10;
            this.lblTienGT.Text = "Tiền SX GT";
            // 
            // txtTienGT
            // 
            this.txtTienGT.AllowNegative = true;
            this.txtTienGT.DigitsInGroup = 3;
            this.txtTienGT.Flags = 0;
            this.txtTienGT.Location = new System.Drawing.Point(254, 26);
            this.txtTienGT.MaxDecimalPlaces = 3;
            this.txtTienGT.MaxWholeDigits = 12;
            this.txtTienGT.Name = "txtTienGT";
            this.txtTienGT.Prefix = "";
            this.txtTienGT.RangeMax = 1.7976931348623157E+308D;
            this.txtTienGT.RangeMin = -1.7976931348623157E+308D;
            this.txtTienGT.Size = new System.Drawing.Size(116, 21);
            this.txtTienGT.TabIndex = 2;
            this.txtTienGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienGT.TextChanged += new System.EventHandler(this.txtTienGT_TextChanged);
            // 
            // lblTienTT
            // 
            this.lblTienTT.AutoSize = true;
            this.lblTienTT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTT.ForeColor = System.Drawing.Color.White;
            this.lblTienTT.Location = new System.Drawing.Point(131, 2);
            this.lblTienTT.Name = "lblTienTT";
            this.lblTienTT.Size = new System.Drawing.Size(67, 15);
            this.lblTienTT.TabIndex = 8;
            this.lblTienTT.Text = "Tiền SX TT";
            // 
            // txtTienTT
            // 
            this.txtTienTT.AllowNegative = true;
            this.txtTienTT.DigitsInGroup = 3;
            this.txtTienTT.Flags = 0;
            this.txtTienTT.Location = new System.Drawing.Point(131, 26);
            this.txtTienTT.MaxDecimalPlaces = 3;
            this.txtTienTT.MaxWholeDigits = 12;
            this.txtTienTT.Name = "txtTienTT";
            this.txtTienTT.Prefix = "";
            this.txtTienTT.RangeMax = 1.7976931348623157E+308D;
            this.txtTienTT.RangeMin = -1.7976931348623157E+308D;
            this.txtTienTT.Size = new System.Drawing.Size(116, 21);
            this.txtTienTT.TabIndex = 1;
            this.txtTienTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienTT.TextChanged += new System.EventHandler(this.txtTienTT_TextChanged);
            // 
            // bttLuu
            // 
            this.bttLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttLuu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Image = ((System.Drawing.Image)(resources.GetObject("bttLuu.Image")));
            this.bttLuu.Location = new System.Drawing.Point(1012, 388);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(107, 43);
            this.bttLuu.TabIndex = 8;
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
            this.bttXoa.Location = new System.Drawing.Point(1127, 388);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(107, 43);
            this.bttXoa.TabIndex = 11;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttXoa, "Xóa");
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttKhoa
            // 
            this.bttKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttKhoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttKhoa.Image = ((System.Drawing.Image)(resources.GetObject("bttKhoa.Image")));
            this.bttKhoa.Location = new System.Drawing.Point(1240, 386);
            this.bttKhoa.Name = "bttKhoa";
            this.bttKhoa.Size = new System.Drawing.Size(107, 43);
            this.bttKhoa.TabIndex = 12;
            this.bttKhoa.Text = "Khóa";
            this.bttKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bttKhoa, "Xóa");
            this.bttKhoa.UseVisualStyleBackColor = true;
            this.bttKhoa.Click += new System.EventHandler(this.bttKhoa_Click);
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
            this.Khoa,
            this.Thang,
            this.TienTT,
            this.TienGT,
            this.TienQL,
            this.TongGioCong,
            this.GiaTT,
            this.GiaGT,
            this.GiaQL,
            this.PhanTramLoiNhuan});
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(2, 63);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 30;
            this.grid.RowTemplate.Height = 30;
            this.grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.Size = new System.Drawing.Size(1374, 319);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 6;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValueChanged);
            this.grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khóa";
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            this.Khoa.Width = 50;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            this.Thang.DefaultCellStyle = dataGridViewCellStyle2;
            this.Thang.HeaderText = "Thang";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            this.Thang.Width = 60;
            // 
            // TienTT
            // 
            this.TienTT.DataPropertyName = "TienTT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.TienTT.DefaultCellStyle = dataGridViewCellStyle3;
            this.TienTT.HeaderText = "Tiền trực tiếp";
            this.TienTT.Name = "TienTT";
            this.TienTT.ReadOnly = true;
            this.TienTT.Width = 120;
            // 
            // TienGT
            // 
            this.TienGT.DataPropertyName = "TienGT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.TienGT.DefaultCellStyle = dataGridViewCellStyle4;
            this.TienGT.HeaderText = "Tiền gián tiếp";
            this.TienGT.Name = "TienGT";
            this.TienGT.ReadOnly = true;
            this.TienGT.Width = 120;
            // 
            // TienQL
            // 
            this.TienQL.DataPropertyName = "TienQL";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.TienQL.DefaultCellStyle = dataGridViewCellStyle5;
            this.TienQL.HeaderText = "Tiền quản lý";
            this.TienQL.Name = "TienQL";
            this.TienQL.ReadOnly = true;
            this.TienQL.Width = 120;
            // 
            // TongGioCong
            // 
            this.TongGioCong.DataPropertyName = "TongGioCong";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.TongGioCong.DefaultCellStyle = dataGridViewCellStyle6;
            this.TongGioCong.HeaderText = "Tổng giờ công";
            this.TongGioCong.Name = "TongGioCong";
            this.TongGioCong.ReadOnly = true;
            // 
            // GiaTT
            // 
            this.GiaTT.DataPropertyName = "GiaTT";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.GiaTT.DefaultCellStyle = dataGridViewCellStyle7;
            this.GiaTT.HeaderText = "Giá tiền trực tiếp";
            this.GiaTT.Name = "GiaTT";
            this.GiaTT.ReadOnly = true;
            // 
            // GiaGT
            // 
            this.GiaGT.DataPropertyName = "GiaGT";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.GiaGT.DefaultCellStyle = dataGridViewCellStyle8;
            this.GiaGT.HeaderText = "Giá tiền gián tiếp";
            this.GiaGT.Name = "GiaGT";
            this.GiaGT.ReadOnly = true;
            // 
            // GiaQL
            // 
            this.GiaQL.DataPropertyName = "GiaQL";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.GiaQL.DefaultCellStyle = dataGridViewCellStyle9;
            this.GiaQL.HeaderText = "Giá tiền quản lý";
            this.GiaQL.Name = "GiaQL";
            this.GiaQL.ReadOnly = true;
            // 
            // PhanTramLoiNhuan
            // 
            this.PhanTramLoiNhuan.DataPropertyName = "PhanTramLoiNhuan";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N4";
            this.PhanTramLoiNhuan.DefaultCellStyle = dataGridViewCellStyle10;
            this.PhanTramLoiNhuan.HeaderText = "% Lợi nhuận";
            this.PhanTramLoiNhuan.Name = "PhanTramLoiNhuan";
            this.PhanTramLoiNhuan.ReadOnly = true;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 45);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 45);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 45);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 48);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(67, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 45);
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
            this.bdn.Location = new System.Drawing.Point(0, 386);
            this.bdn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bdn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdn.Name = "bdn";
            this.bdn.PositionItem = this.bindingNavigatorPositionItem;
            this.bdn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bdn.Size = new System.Drawing.Size(1379, 48);
            this.bdn.TabIndex = 7;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 45);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // FrmDuToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 437);
            this.Controls.Add(this.bttKhoa);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bdn);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmDuToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dự toán";
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

        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttLuu;
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
        private System.Windows.Forms.Label lblTienTT;
        private AMS.TextBox.NumericTextBox txtTienTT;
        private System.Windows.Forms.Label lblLoiNhuan;
        private AMS.TextBox.NumericTextBox txtLoiNhuan;
        private System.Windows.Forms.Label lblTienQL;
        private AMS.TextBox.NumericTextBox txtTienQL;
        private System.Windows.Forms.Label lblTienGT;
        private AMS.TextBox.NumericTextBox txtTienGT;
        private System.Windows.Forms.Label lblGiaQL;
        private AMS.TextBox.NumericTextBox txtGiaQL;
        private System.Windows.Forms.Label lblGiaGT;
        private AMS.TextBox.NumericTextBox txtGiaGT;
        private System.Windows.Forms.Label lblGiaTT;
        private AMS.TextBox.NumericTextBox txtGiaTT;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Label lblTongGC;
        private AMS.TextBox.NumericTextBox txtTongGC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGioCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanTramLoiNhuan;
        private System.Windows.Forms.Button bttKhoa;
    }
}