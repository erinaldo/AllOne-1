namespace AllOne
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelKH = new System.Windows.Forms.Panel();
            this.bttKhachHang = new System.Windows.Forms.Button();
            this.bttNhomKH = new System.Windows.Forms.Button();
            this.bttNCC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(837, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 42);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Khách hàng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKH
            // 
            this.panelKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelKH.Location = new System.Drawing.Point(1, 54);
            this.panelKH.Name = "panelKH";
            this.panelKH.Size = new System.Drawing.Size(957, 505);
            this.panelKH.TabIndex = 12;
            // 
            // bttKhachHang
            // 
            this.bttKhachHang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("bttKhachHang.Image")));
            this.bttKhachHang.Location = new System.Drawing.Point(9, 9);
            this.bttKhachHang.Name = "bttKhachHang";
            this.bttKhachHang.Size = new System.Drawing.Size(114, 38);
            this.bttKhachHang.TabIndex = 8;
            this.bttKhachHang.Text = "Khách hàng";
            this.bttKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttKhachHang.UseVisualStyleBackColor = true;
            this.bttKhachHang.Click += new System.EventHandler(this.bttKhachHang_Click);
            // 
            // bttNhomKH
            // 
            this.bttNhomKH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNhomKH.Image = ((System.Drawing.Image)(resources.GetObject("bttNhomKH.Image")));
            this.bttNhomKH.Location = new System.Drawing.Point(129, 9);
            this.bttNhomKH.Name = "bttNhomKH";
            this.bttNhomKH.Size = new System.Drawing.Size(114, 38);
            this.bttNhomKH.TabIndex = 7;
            this.bttNhomKH.Text = "Nhóm khách hàng";
            this.bttNhomKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttNhomKH.UseVisualStyleBackColor = true;
            this.bttNhomKH.Click += new System.EventHandler(this.bttNhomKH_Click);
            // 
            // bttNCC
            // 
            this.bttNCC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNCC.Image = ((System.Drawing.Image)(resources.GetObject("bttNCC.Image")));
            this.bttNCC.Location = new System.Drawing.Point(249, 9);
            this.bttNCC.Name = "bttNCC";
            this.bttNCC.Size = new System.Drawing.Size(114, 38);
            this.bttNCC.TabIndex = 14;
            this.bttNCC.Text = "Nhà cung cấp";
            this.bttNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttNCC.UseVisualStyleBackColor = true;
            this.bttNCC.Click += new System.EventHandler(this.bttNCC_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 557);
            this.Controls.Add(this.bttNCC);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelKH);
            this.Controls.Add(this.bttKhachHang);
            this.Controls.Add(this.bttNhomKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmKhachHang_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelKH;
        private System.Windows.Forms.Button bttKhachHang;
        private System.Windows.Forms.Button bttNhomKH;
        private System.Windows.Forms.Button bttNCC;

    }
}