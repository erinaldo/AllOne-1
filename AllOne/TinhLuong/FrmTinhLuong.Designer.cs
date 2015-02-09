namespace AllOne.TinhLuong
{
    partial class FrmTinhLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTinhLuong));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.bttChamCong = new System.Windows.Forms.Button();
            this.bttTangCa = new System.Windows.Forms.Button();
            this.bttNhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(843, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 47);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "...";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Location = new System.Drawing.Point(1, 52);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(957, 505);
            this.panel.TabIndex = 21;
            // 
            // bttChamCong
            // 
            this.bttChamCong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttChamCong.Image = ((System.Drawing.Image)(resources.GetObject("bttChamCong.Image")));
            this.bttChamCong.Location = new System.Drawing.Point(245, 0);
            this.bttChamCong.Name = "bttChamCong";
            this.bttChamCong.Size = new System.Drawing.Size(114, 49);
            this.bttChamCong.TabIndex = 18;
            this.bttChamCong.Text = "Chấm công";
            this.bttChamCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttChamCong.UseVisualStyleBackColor = true;
            this.bttChamCong.Click += new System.EventHandler(this.bttChamCong_Click);
            // 
            // bttTangCa
            // 
            this.bttTangCa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTangCa.Image = ((System.Drawing.Image)(resources.GetObject("bttTangCa.Image")));
            this.bttTangCa.Location = new System.Drawing.Point(123, 0);
            this.bttTangCa.Name = "bttTangCa";
            this.bttTangCa.Size = new System.Drawing.Size(114, 49);
            this.bttTangCa.TabIndex = 17;
            this.bttTangCa.Text = "Tăng ca";
            this.bttTangCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttTangCa.UseVisualStyleBackColor = true;
            this.bttTangCa.Click += new System.EventHandler(this.bttTangCa_Click);
            // 
            // bttNhanVien
            // 
            this.bttNhanVien.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("bttNhanVien.Image")));
            this.bttNhanVien.Location = new System.Drawing.Point(1, 0);
            this.bttNhanVien.Name = "bttNhanVien";
            this.bttNhanVien.Size = new System.Drawing.Size(114, 49);
            this.bttNhanVien.TabIndex = 16;
            this.bttNhanVien.Text = "Nhân viên";
            this.bttNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttNhanVien.UseVisualStyleBackColor = true;
            this.bttNhanVien.Click += new System.EventHandler(this.bttNhanVien_Click);
            // 
            // FrmTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 557);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.bttChamCong);
            this.Controls.Add(this.bttTangCa);
            this.Controls.Add(this.bttNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "FrmTinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính lương";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmTinhLuong_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button bttChamCong;
        private System.Windows.Forms.Button bttTangCa;
        private System.Windows.Forms.Button bttNhanVien;

    }
}