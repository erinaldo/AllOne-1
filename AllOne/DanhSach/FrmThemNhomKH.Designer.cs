namespace AllOne.DanhSach
{
    partial class FrmThemNhomKH
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtTenNhomKH = new System.Windows.Forms.TextBox();
            this.lblTenNhomKH = new System.Windows.Forms.Label();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.txtMaNhomKH = new System.Windows.Forms.TextBox();
            this.lblMaNhomKH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(103, 69);
            this.txtGhiChu.MaxLength = 200;
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(392, 73);
            this.txtGhiChu.TabIndex = 2;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(21, 72);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(49, 15);
            this.lblGhiChu.TabIndex = 12;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtTenNhomKH
            // 
            this.txtTenNhomKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTenNhomKH.Location = new System.Drawing.Point(103, 41);
            this.txtTenNhomKH.MaxLength = 50;
            this.txtTenNhomKH.Name = "txtTenNhomKH";
            this.txtTenNhomKH.Size = new System.Drawing.Size(392, 21);
            this.txtTenNhomKH.TabIndex = 1;
            // 
            // lblTenNhomKH
            // 
            this.lblTenNhomKH.AutoSize = true;
            this.lblTenNhomKH.Location = new System.Drawing.Point(21, 44);
            this.lblTenNhomKH.Name = "lblTenNhomKH";
            this.lblTenNhomKH.Size = new System.Drawing.Size(63, 15);
            this.lblTenNhomKH.TabIndex = 10;
            this.lblTenNhomKH.Text = "Tên nhóm";
            // 
            // bttHuy
            // 
            this.bttHuy.Location = new System.Drawing.Point(271, 171);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(132, 42);
            this.bttHuy.TabIndex = 4;
            this.bttHuy.Text = "Hủy (Esc)";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Location = new System.Drawing.Point(118, 171);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(132, 42);
            this.bttLuu.TabIndex = 3;
            this.bttLuu.Text = "Lưu (Ctrl+S)";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(5, 156);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(518, 2);
            this.lblLine.TabIndex = 7;
            // 
            // txtMaNhomKH
            // 
            this.txtMaNhomKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMaNhomKH.Location = new System.Drawing.Point(103, 13);
            this.txtMaNhomKH.MaxLength = 3;
            this.txtMaNhomKH.Name = "txtMaNhomKH";
            this.txtMaNhomKH.Size = new System.Drawing.Size(392, 21);
            this.txtMaNhomKH.TabIndex = 0;
            // 
            // lblMaNhomKH
            // 
            this.lblMaNhomKH.AutoSize = true;
            this.lblMaNhomKH.Location = new System.Drawing.Point(21, 16);
            this.lblMaNhomKH.Name = "lblMaNhomKH";
            this.lblMaNhomKH.Size = new System.Drawing.Size(58, 15);
            this.lblMaNhomKH.TabIndex = 14;
            this.lblMaNhomKH.Text = "Mã nhóm";
            // 
            // FrmThemNhomKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 226);
            this.Controls.Add(this.txtMaNhomKH);
            this.Controls.Add(this.lblMaNhomKH);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtTenNhomKH);
            this.Controls.Add(this.lblTenNhomKH);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.lblLine);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThemNhomKH";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm nhóm khách hàng";
            this.Shown += new System.EventHandler(this.FrmThemNhomKH_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmThemNhomKH_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtTenNhomKH;
        private System.Windows.Forms.Label lblTenNhomKH;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.TextBox txtMaNhomKH;
        private System.Windows.Forms.Label lblMaNhomKH;
    }
}