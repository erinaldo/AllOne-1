namespace AllOne
{
    partial class FrmHuongDan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHuongDan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkHDSD = new System.Windows.Forms.LinkLabel();
            this.panelCenterRight = new System.Windows.Forms.Panel();
            this.bttDangKy = new System.Windows.Forms.Button();
            this.lblStatusLicense = new System.Windows.Forms.Label();
            this.lblBanQuyen = new System.Windows.Forms.Label();
            this.panelCenterLeft = new System.Windows.Forms.Panel();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCenterRight.SuspendLayout();
            this.panelCenterLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // linkHDSD
            // 
            this.linkHDSD.AutoSize = true;
            this.linkHDSD.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHDSD.Location = new System.Drawing.Point(257, 362);
            this.linkHDSD.Name = "linkHDSD";
            this.linkHDSD.Size = new System.Drawing.Size(364, 26);
            this.linkHDSD.TabIndex = 2;
            this.linkHDSD.TabStop = true;
            this.linkHDSD.Text = "Hướng dẫn sử dụng chương trình";
            this.linkHDSD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHDSD_LinkClicked);
            // 
            // panelCenterRight
            // 
            this.panelCenterRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCenterRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCenterRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenterRight.Controls.Add(this.bttDangKy);
            this.panelCenterRight.Controls.Add(this.lblStatusLicense);
            this.panelCenterRight.Controls.Add(this.lblBanQuyen);
            this.panelCenterRight.Location = new System.Drawing.Point(3, 419);
            this.panelCenterRight.Name = "panelCenterRight";
            this.panelCenterRight.Size = new System.Drawing.Size(327, 47);
            this.panelCenterRight.TabIndex = 4;
            // 
            // bttDangKy
            // 
            this.bttDangKy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDangKy.ForeColor = System.Drawing.Color.Blue;
            this.bttDangKy.Location = new System.Drawing.Point(199, 9);
            this.bttDangKy.Name = "bttDangKy";
            this.bttDangKy.Size = new System.Drawing.Size(88, 27);
            this.bttDangKy.TabIndex = 4;
            this.bttDangKy.Text = "Đăng ký";
            this.bttDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttDangKy.UseVisualStyleBackColor = true;
            this.bttDangKy.Click += new System.EventHandler(this.bttDangKy_Click);
            // 
            // lblStatusLicense
            // 
            this.lblStatusLicense.AutoSize = true;
            this.lblStatusLicense.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLicense.ForeColor = System.Drawing.Color.Blue;
            this.lblStatusLicense.Location = new System.Drawing.Point(85, 16);
            this.lblStatusLicense.Name = "lblStatusLicense";
            this.lblStatusLicense.Size = new System.Drawing.Size(70, 15);
            this.lblStatusLicense.TabIndex = 1;
            this.lblStatusLicense.Text = "Đã đăng ký";
            // 
            // lblBanQuyen
            // 
            this.lblBanQuyen.AutoSize = true;
            this.lblBanQuyen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanQuyen.Location = new System.Drawing.Point(10, 15);
            this.lblBanQuyen.Name = "lblBanQuyen";
            this.lblBanQuyen.Size = new System.Drawing.Size(69, 15);
            this.lblBanQuyen.TabIndex = 0;
            this.lblBanQuyen.Text = "Bản quyền:";
            // 
            // panelCenterLeft
            // 
            this.panelCenterLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCenterLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCenterLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenterLeft.Controls.Add(this.txtNhanVien);
            this.panelCenterLeft.Controls.Add(this.lblNhanVien);
            this.panelCenterLeft.Location = new System.Drawing.Point(329, 419);
            this.panelCenterLeft.Name = "panelCenterLeft";
            this.panelCenterLeft.Size = new System.Drawing.Size(185, 47);
            this.panelCenterLeft.TabIndex = 5;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhanVien.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(74, 12);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(100, 21);
            this.txtNhanVien.TabIndex = 1;
            this.txtNhanVien.Text = "Admin";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.lblNhanVien.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblNhanVien.Location = new System.Drawing.Point(3, 14);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(65, 15);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // FrmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 478);
            this.Controls.Add(this.panelCenterLeft);
            this.Controls.Add(this.panelCenterRight);
            this.Controls.Add(this.linkHDSD);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "FrmHuongDan";
            this.Text = "Hướng dẫn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmHuongDan_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCenterRight.ResumeLayout(false);
            this.panelCenterRight.PerformLayout();
            this.panelCenterLeft.ResumeLayout(false);
            this.panelCenterLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkHDSD;
        private System.Windows.Forms.Panel panelCenterRight;
        private System.Windows.Forms.Button bttDangKy;
        private System.Windows.Forms.Label lblStatusLicense;
        private System.Windows.Forms.Label lblBanQuyen;
        private System.Windows.Forms.Panel panelCenterLeft;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label lblNhanVien;

    }
}