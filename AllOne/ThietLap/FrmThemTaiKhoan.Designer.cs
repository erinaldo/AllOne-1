namespace AllOne.ThietLap
{
    partial class FrmThemTaiKhoan
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblNhom = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.lblNhapLaiMK = new System.Windows.Forms.Label();
            this.cboNhomNV = new System.Windows.Forms.ComboBox();
            this.lblNhacNho = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtHoTen.Location = new System.Drawing.Point(139, 65);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHoTen.Size = new System.Drawing.Size(245, 21);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(70, 68);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(58, 15);
            this.lblHoTen.TabIndex = 12;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTenDangNhap.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtTenDangNhap.Location = new System.Drawing.Point(139, 36);
            this.txtTenDangNhap.MaxLength = 20;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(245, 21);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(38, 39);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(90, 15);
            this.lblTenDangNhap.TabIndex = 10;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(221, 242);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(105, 42);
            this.bttHuy.TabIndex = 6;
            this.bttHuy.Text = "Hủy (Esc)";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(81, 242);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(105, 42);
            this.bttLuu.TabIndex = 5;
            this.bttLuu.Text = "Lưu (Ctrl+S)";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(1, 231);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(414, 2);
            this.lblLine.TabIndex = 7;
            // 
            // lblNhom
            // 
            this.lblNhom.AutoSize = true;
            this.lblNhom.Location = new System.Drawing.Point(87, 99);
            this.lblNhom.Name = "lblNhom";
            this.lblNhom.Size = new System.Drawing.Size(41, 15);
            this.lblNhom.TabIndex = 14;
            this.lblNhom.Text = "Nhóm";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMatKhau.Location = new System.Drawing.Point(139, 121);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatKhau.Size = new System.Drawing.Size(245, 21);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(72, 125);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(56, 15);
            this.lblMatKhau.TabIndex = 15;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNhapLaiMK.Location = new System.Drawing.Point(139, 149);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNhapLaiMK.Size = new System.Drawing.Size(245, 21);
            this.txtNhapLaiMK.TabIndex = 4;
            this.txtNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // lblNhapLaiMK
            // 
            this.lblNhapLaiMK.AutoSize = true;
            this.lblNhapLaiMK.Location = new System.Drawing.Point(21, 152);
            this.lblNhapLaiMK.Name = "lblNhapLaiMK";
            this.lblNhapLaiMK.Size = new System.Drawing.Size(107, 15);
            this.lblNhapLaiMK.TabIndex = 17;
            this.lblNhapLaiMK.Text = "Nhập lại mật khẩu";
            // 
            // cboNhomNV
            // 
            this.cboNhomNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboNhomNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomNV.FormattingEnabled = true;
            this.cboNhomNV.Location = new System.Drawing.Point(139, 92);
            this.cboNhomNV.Name = "cboNhomNV";
            this.cboNhomNV.Size = new System.Drawing.Size(245, 23);
            this.cboNhomNV.TabIndex = 2;
            // 
            // lblNhacNho
            // 
            this.lblNhacNho.BackColor = System.Drawing.Color.DarkGreen;
            this.lblNhacNho.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhacNho.ForeColor = System.Drawing.Color.White;
            this.lblNhacNho.Location = new System.Drawing.Point(1, 186);
            this.lblNhacNho.Name = "lblNhacNho";
            this.lblNhacNho.Size = new System.Drawing.Size(406, 39);
            this.lblNhacNho.TabIndex = 21;
            this.lblNhacNho.Text = "(Mật khẩu ít nhất 6 ký tự, nên đặt mật khẩu bao gồm chữ, số, ký tự đặt biệt để bả" +
    "o mật)";
            // 
            // txtMaNV
            // 
            this.txtMaNV.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMaNV.Location = new System.Drawing.Point(139, 9);
            this.txtMaNV.MaxLength = 4;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(245, 21);
            this.txtMaNV.TabIndex = 22;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(49, 12);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(79, 15);
            this.lblMaNV.TabIndex = 23;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // FrmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 293);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblNhacNho);
            this.Controls.Add(this.cboNhomNV);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.lblNhapLaiMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblNhom);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.lblLine);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThemTaiKhoan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm tài khoản";
            this.Shown += new System.EventHandler(this.FrmThemTaiKhoan_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmThemTaiKhoan_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblNhom;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.Label lblNhapLaiMK;
        private System.Windows.Forms.ComboBox cboNhomNV;
        private System.Windows.Forms.Label lblNhacNho;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
    }
}