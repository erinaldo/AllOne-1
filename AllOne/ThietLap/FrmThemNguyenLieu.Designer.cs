namespace AllOne.ThietLap
{
    partial class FrmThemNguyenLieu
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
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.txtGiaNhap = new AMS.TextBox.NumericTextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblMaNL = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cboTienTe = new System.Windows.Forms.ComboBox();
            this.lblTienTe = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.cboNhom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaBan = new AMS.TextBox.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTenNL
            // 
            this.txtTenNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTenNL.Location = new System.Drawing.Point(112, 39);
            this.txtTenNL.MaxLength = 100;
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(374, 21);
            this.txtTenNL.TabIndex = 1;
            // 
            // bttHuy
            // 
            this.bttHuy.Location = new System.Drawing.Point(264, 314);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(121, 45);
            this.bttHuy.TabIndex = 10;
            this.bttHuy.Text = "Hủy (Esc)";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Location = new System.Drawing.Point(126, 314);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(121, 45);
            this.bttLuu.TabIndex = 9;
            this.bttLuu.Text = "Lưu (Ctrl+S)";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(2, 298);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(500, 2);
            this.lblLine.TabIndex = 20;
            // 
            // txtMaNL
            // 
            this.txtMaNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMaNL.Location = new System.Drawing.Point(112, 12);
            this.txtMaNL.MaxLength = 6;
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(374, 21);
            this.txtMaNL.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(110, 248);
            this.txtGhiChu.MaxLength = 200;
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(374, 47);
            this.txtGhiChu.TabIndex = 8;
            // 
            // cboDVT
            // 
            this.cboDVT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Location = new System.Drawing.Point(111, 158);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(173, 23);
            this.cboDVT.TabIndex = 5;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.AllowNegative = true;
            this.txtGiaNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGiaNhap.DigitsInGroup = 3;
            this.txtGiaNhap.Flags = 0;
            this.txtGiaNhap.Location = new System.Drawing.Point(111, 72);
            this.txtGiaNhap.MaxDecimalPlaces = 3;
            this.txtGiaNhap.MaxWholeDigits = 10;
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Prefix = "";
            this.txtGiaNhap.RangeMax = 1.7976931348623157E+308D;
            this.txtGiaNhap.RangeMin = -1.7976931348623157E+308D;
            this.txtGiaNhap.Size = new System.Drawing.Size(173, 21);
            this.txtGiaNhap.TabIndex = 2;
            this.txtGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(3, 42);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(94, 15);
            this.lblTenSP.TabIndex = 23;
            this.lblTenSP.Text = "Tên nguyên liệu";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(27, 161);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(65, 15);
            this.lblDVT.TabIndex = 25;
            this.lblDVT.Text = "Đơn vị tính";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(29, 79);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(57, 15);
            this.lblDonGia.TabIndex = 32;
            this.lblDonGia.Text = "Giá nhập";
            // 
            // lblMaNL
            // 
            this.lblMaNL.AutoSize = true;
            this.lblMaNL.Location = new System.Drawing.Point(3, 15);
            this.lblMaNL.Name = "lblMaNL";
            this.lblMaNL.Size = new System.Drawing.Size(89, 15);
            this.lblMaNL.TabIndex = 36;
            this.lblMaNL.Text = "Mã nguyên liệu";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(43, 252);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(49, 15);
            this.lblGhiChu.TabIndex = 38;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // cboTienTe
            // 
            this.cboTienTe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboTienTe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTienTe.FormattingEnabled = true;
            this.cboTienTe.Location = new System.Drawing.Point(111, 129);
            this.cboTienTe.Name = "cboTienTe";
            this.cboTienTe.Size = new System.Drawing.Size(173, 23);
            this.cboTienTe.TabIndex = 4;
            // 
            // lblTienTe
            // 
            this.lblTienTe.AutoSize = true;
            this.lblTienTe.Location = new System.Drawing.Point(48, 134);
            this.lblTienTe.Name = "lblTienTe";
            this.lblTienTe.Size = new System.Drawing.Size(44, 15);
            this.lblTienTe.TabIndex = 54;
            this.lblTienTe.Text = "Tiền tệ";
            // 
            // cboNCC
            // 
            this.cboNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(112, 216);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(374, 23);
            this.cboNCC.TabIndex = 7;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(9, 219);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(83, 15);
            this.lblNCC.TabIndex = 59;
            this.lblNCC.Text = "Nhà cung cấp";
            // 
            // cboNhom
            // 
            this.cboNhom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhom.FormattingEnabled = true;
            this.cboNhom.Location = new System.Drawing.Point(110, 187);
            this.cboNhom.Name = "cboNhom";
            this.cboNhom.Size = new System.Drawing.Size(374, 23);
            this.cboNhom.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nhóm";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.AllowNegative = true;
            this.txtGiaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGiaBan.DigitsInGroup = 3;
            this.txtGiaBan.Flags = 0;
            this.txtGiaBan.Location = new System.Drawing.Point(112, 99);
            this.txtGiaBan.MaxDecimalPlaces = 3;
            this.txtGiaBan.MaxWholeDigits = 10;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Prefix = "";
            this.txtGiaBan.RangeMax = 1.7976931348623157E+308D;
            this.txtGiaBan.RangeMin = -1.7976931348623157E+308D;
            this.txtGiaBan.Size = new System.Drawing.Size(173, 21);
            this.txtGiaBan.TabIndex = 3;
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Giá bán";
            // 
            // FrmThemNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 371);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboNhom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.cboTienTe);
            this.Controls.Add(this.lblTienTe);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.cboDVT);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblMaNL);
            this.Controls.Add(this.txtMaNL);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblDVT);
            this.Controls.Add(this.txtTenNL);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.lblLine);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThemNguyenLieu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm nguyên liệu";
            this.Shown += new System.EventHandler(this.FrmThemSanPham_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmThemSanPham_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cboDVT;
        private AMS.TextBox.NumericTextBox txtGiaNhap;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblMaNL;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.ComboBox cboTienTe;
        private System.Windows.Forms.Label lblTienTe;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.ComboBox cboNhom;
        private System.Windows.Forms.Label label1;
        private AMS.TextBox.NumericTextBox txtGiaBan;
        private System.Windows.Forms.Label label2;
    }
}