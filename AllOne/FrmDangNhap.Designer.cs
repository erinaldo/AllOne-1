namespace AllOne
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.lblLine = new System.Windows.Forms.Label();
            this.bttDangNhap = new System.Windows.Forms.Button();
            this.ckoHienThiPass = new System.Windows.Forms.CheckBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.bttThoat = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.panelCT = new System.Windows.Forms.Panel();
            this.lblAllOne = new System.Windows.Forms.Label();
            this.lblCT = new System.Windows.Forms.Label();
            this.linkCauHinh = new System.Windows.Forms.LinkLabel();
            this.panelCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BackColor = System.Drawing.Color.Green;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.ForeColor = System.Drawing.Color.Green;
            this.lblLine.Location = new System.Drawing.Point(0, 220);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(410, 3);
            this.lblLine.TabIndex = 0;
            // 
            // bttDangNhap
            // 
            this.bttDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("bttDangNhap.Image")));
            this.bttDangNhap.Location = new System.Drawing.Point(108, 235);
            this.bttDangNhap.Name = "bttDangNhap";
            this.bttDangNhap.Size = new System.Drawing.Size(122, 41);
            this.bttDangNhap.TabIndex = 2;
            this.bttDangNhap.Text = "Đăng nhập";
            this.bttDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttDangNhap.UseVisualStyleBackColor = true;
            this.bttDangNhap.Click += new System.EventHandler(this.bttDangNhap_Click);
            // 
            // ckoHienThiPass
            // 
            this.ckoHienThiPass.AutoSize = true;
            this.ckoHienThiPass.Location = new System.Drawing.Point(108, 197);
            this.ckoHienThiPass.Name = "ckoHienThiPass";
            this.ckoHienThiPass.Size = new System.Drawing.Size(136, 20);
            this.ckoHienThiPass.TabIndex = 2;
            this.ckoHienThiPass.Text = "Hiển thị mật khẩu";
            this.ckoHienThiPass.UseVisualStyleBackColor = true;
            this.ckoHienThiPass.CheckedChanged += new System.EventHandler(this.ckoHienThiPass_CheckedChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTenDangNhap.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(108, 103);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(272, 23);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(0, 107);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(105, 16);
            this.lblTenDangNhap.TabIndex = 4;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // bttThoat
            // 
            this.bttThoat.Image = ((System.Drawing.Image)(resources.GetObject("bttThoat.Image")));
            this.bttThoat.Location = new System.Drawing.Point(262, 235);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(118, 41);
            this.bttThoat.TabIndex = 3;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 10F);
            this.txtMatKhau.Location = new System.Drawing.Point(108, 151);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(272, 23);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(34, 155);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(66, 16);
            this.lblMatKhau.TabIndex = 7;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // panelCT
            // 
            this.panelCT.BackColor = System.Drawing.Color.DarkGreen;
            this.panelCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCT.Controls.Add(this.lblAllOne);
            this.panelCT.Controls.Add(this.lblCT);
            this.panelCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCT.Location = new System.Drawing.Point(0, 0);
            this.panelCT.Name = "panelCT";
            this.panelCT.Size = new System.Drawing.Size(409, 83);
            this.panelCT.TabIndex = 8;
            // 
            // lblAllOne
            // 
            this.lblAllOne.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblAllOne.ForeColor = System.Drawing.Color.White;
            this.lblAllOne.Location = new System.Drawing.Point(3, 8);
            this.lblAllOne.Name = "lblAllOne";
            this.lblAllOne.Size = new System.Drawing.Size(405, 29);
            this.lblAllOne.TabIndex = 6;
            this.lblAllOne.Text = "Quản Lý Tồn Kho - Bán Hàng";
            this.lblAllOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT
            // 
            this.lblCT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCT.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCT.Location = new System.Drawing.Point(0, 59);
            this.lblCT.Name = "lblCT";
            this.lblCT.Size = new System.Drawing.Size(407, 22);
            this.lblCT.TabIndex = 5;
            this.lblCT.Text = "CÔNG TY TNHH CÔNG NGHỆ KỸ THUẬT NEWTECH\r\n";
            this.lblCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkCauHinh
            // 
            this.linkCauHinh.AutoSize = true;
            this.linkCauHinh.Location = new System.Drawing.Point(12, 260);
            this.linkCauHinh.Name = "linkCauHinh";
            this.linkCauHinh.Size = new System.Drawing.Size(66, 16);
            this.linkCauHinh.TabIndex = 9;
            this.linkCauHinh.TabStop = true;
            this.linkCauHinh.Text = "Cấu hình";
            this.linkCauHinh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCauHinh_LinkClicked);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(409, 288);
            this.Controls.Add(this.linkCauHinh);
            this.Controls.Add(this.panelCT);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.ckoHienThiPass);
            this.Controls.Add(this.bttDangNhap);
            this.Controls.Add(this.lblLine);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Shown += new System.EventHandler(this.FrmDangNhap_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDangNhap_KeyDown);
            this.panelCT.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button bttDangNhap;
        private System.Windows.Forms.CheckBox ckoHienThiPass;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Panel panelCT;
        private System.Windows.Forms.Label lblAllOne;
        private System.Windows.Forms.Label lblCT;
        private System.Windows.Forms.LinkLabel linkCauHinh;
    }
}