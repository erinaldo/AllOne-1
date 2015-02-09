namespace AllOne
{
    partial class FrmThietLap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThietLap));
            this.bttThietLapChung = new System.Windows.Forms.Button();
            this.bttKho = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelThietLap = new System.Windows.Forms.Panel();
            this.bttDVT = new System.Windows.Forms.Button();
            this.bttSanPham = new System.Windows.Forms.Button();
            this.bttNhomSP = new System.Windows.Forms.Button();
            this.bttTaiKhoan = new System.Windows.Forms.Button();
            this.bttTyGia = new System.Windows.Forms.Button();
            this.bttNguyenLieu = new System.Windows.Forms.Button();
            this.bttNhomNL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttThietLapChung
            // 
            this.bttThietLapChung.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThietLapChung.Image = ((System.Drawing.Image)(resources.GetObject("bttThietLapChung.Image")));
            this.bttThietLapChung.Location = new System.Drawing.Point(834, -1);
            this.bttThietLapChung.Name = "bttThietLapChung";
            this.bttThietLapChung.Size = new System.Drawing.Size(93, 49);
            this.bttThietLapChung.TabIndex = 5;
            this.bttThietLapChung.Text = "Thiết lập";
            this.bttThietLapChung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttThietLapChung.UseVisualStyleBackColor = true;
            this.bttThietLapChung.Click += new System.EventHandler(this.bttThietLapChung_Click);
            // 
            // bttKho
            // 
            this.bttKho.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttKho.Image = ((System.Drawing.Image)(resources.GetObject("bttKho.Image")));
            this.bttKho.Location = new System.Drawing.Point(524, -1);
            this.bttKho.Name = "bttKho";
            this.bttKho.Size = new System.Drawing.Size(93, 49);
            this.bttKho.TabIndex = 3;
            this.bttKho.Text = "Kho hàng";
            this.bttKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttKho.UseVisualStyleBackColor = true;
            this.bttKho.Click += new System.EventHandler(this.bttKho_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1145, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 39);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Nhóm khách hàng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelThietLap
            // 
            this.panelThietLap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelThietLap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelThietLap.Location = new System.Drawing.Point(1, 52);
            this.panelThietLap.Name = "panelThietLap";
            this.panelThietLap.Size = new System.Drawing.Size(1260, 505);
            this.panelThietLap.TabIndex = 21;
            // 
            // bttDVT
            // 
            this.bttDVT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDVT.Image = ((System.Drawing.Image)(resources.GetObject("bttDVT.Image")));
            this.bttDVT.Location = new System.Drawing.Point(421, -1);
            this.bttDVT.Name = "bttDVT";
            this.bttDVT.Size = new System.Drawing.Size(93, 49);
            this.bttDVT.TabIndex = 2;
            this.bttDVT.Text = "Đơn vị tính";
            this.bttDVT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttDVT.UseVisualStyleBackColor = true;
            this.bttDVT.Click += new System.EventHandler(this.bttDVT_Click);
            // 
            // bttSanPham
            // 
            this.bttSanPham.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSanPham.Image = ((System.Drawing.Image)(resources.GetObject("bttSanPham.Image")));
            this.bttSanPham.Location = new System.Drawing.Point(215, -1);
            this.bttSanPham.Name = "bttSanPham";
            this.bttSanPham.Size = new System.Drawing.Size(93, 49);
            this.bttSanPham.TabIndex = 1;
            this.bttSanPham.Text = "Sản phẩm";
            this.bttSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttSanPham.UseVisualStyleBackColor = true;
            this.bttSanPham.Click += new System.EventHandler(this.bttSanPham_Click);
            // 
            // bttNhomSP
            // 
            this.bttNhomSP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNhomSP.Image = ((System.Drawing.Image)(resources.GetObject("bttNhomSP.Image")));
            this.bttNhomSP.Location = new System.Drawing.Point(318, -1);
            this.bttNhomSP.Name = "bttNhomSP";
            this.bttNhomSP.Size = new System.Drawing.Size(93, 49);
            this.bttNhomSP.TabIndex = 0;
            this.bttNhomSP.Text = "Nhóm SP";
            this.bttNhomSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttNhomSP.UseVisualStyleBackColor = true;
            this.bttNhomSP.Click += new System.EventHandler(this.bttNhomSP_Click);
            // 
            // bttTaiKhoan
            // 
            this.bttTaiKhoan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("bttTaiKhoan.Image")));
            this.bttTaiKhoan.Location = new System.Drawing.Point(731, -1);
            this.bttTaiKhoan.Name = "bttTaiKhoan";
            this.bttTaiKhoan.Size = new System.Drawing.Size(93, 49);
            this.bttTaiKhoan.TabIndex = 4;
            this.bttTaiKhoan.Text = "Tài khoản";
            this.bttTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttTaiKhoan.UseVisualStyleBackColor = true;
            this.bttTaiKhoan.Click += new System.EventHandler(this.btttTaiKhoan_Click);
            // 
            // bttTyGia
            // 
            this.bttTyGia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTyGia.Image = ((System.Drawing.Image)(resources.GetObject("bttTyGia.Image")));
            this.bttTyGia.Location = new System.Drawing.Point(628, -1);
            this.bttTyGia.Name = "bttTyGia";
            this.bttTyGia.Size = new System.Drawing.Size(93, 49);
            this.bttTyGia.TabIndex = 23;
            this.bttTyGia.Text = "Tỷ giá";
            this.bttTyGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttTyGia.UseVisualStyleBackColor = true;
            this.bttTyGia.Click += new System.EventHandler(this.bttTyGia_Click);
            // 
            // bttNguyenLieu
            // 
            this.bttNguyenLieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNguyenLieu.Image = ((System.Drawing.Image)(resources.GetObject("bttNguyenLieu.Image")));
            this.bttNguyenLieu.Location = new System.Drawing.Point(9, -1);
            this.bttNguyenLieu.Name = "bttNguyenLieu";
            this.bttNguyenLieu.Size = new System.Drawing.Size(93, 49);
            this.bttNguyenLieu.TabIndex = 24;
            this.bttNguyenLieu.Text = "Nguyên liệu";
            this.bttNguyenLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttNguyenLieu.UseVisualStyleBackColor = true;
            this.bttNguyenLieu.Click += new System.EventHandler(this.bttNguyenLieu_Click);
            // 
            // bttNhomNL
            // 
            this.bttNhomNL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNhomNL.Image = ((System.Drawing.Image)(resources.GetObject("bttNhomNL.Image")));
            this.bttNhomNL.Location = new System.Drawing.Point(112, -1);
            this.bttNhomNL.Name = "bttNhomNL";
            this.bttNhomNL.Size = new System.Drawing.Size(93, 49);
            this.bttNhomNL.TabIndex = 26;
            this.bttNhomNL.Text = "Nhóm NL";
            this.bttNhomNL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttNhomNL.UseVisualStyleBackColor = true;
            this.bttNhomNL.Click += new System.EventHandler(this.bttNhomNL_Click);
            // 
            // FrmThietLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 557);
            this.Controls.Add(this.bttNhomNL);
            this.Controls.Add(this.bttNguyenLieu);
            this.Controls.Add(this.bttTyGia);
            this.Controls.Add(this.bttNhomSP);
            this.Controls.Add(this.bttThietLapChung);
            this.Controls.Add(this.bttTaiKhoan);
            this.Controls.Add(this.bttKho);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelThietLap);
            this.Controls.Add(this.bttDVT);
            this.Controls.Add(this.bttSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmThietLap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmThietLap_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttThietLapChung;
        private System.Windows.Forms.Button bttKho;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelThietLap;
        private System.Windows.Forms.Button bttDVT;
        private System.Windows.Forms.Button bttSanPham;
        private System.Windows.Forms.Button bttNhomSP;
        private System.Windows.Forms.Button bttTaiKhoan;
        private System.Windows.Forms.Button bttTyGia;
        private System.Windows.Forms.Button bttNguyenLieu;
        private System.Windows.Forms.Button bttNhomNL;

    }
}