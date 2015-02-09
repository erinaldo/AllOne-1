namespace AllOne
{
    partial class FrmTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTien));
            this.bttDuToan = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.bttBaoGia = new System.Windows.Forms.Button();
            this.bttTínhBaoGia = new System.Windows.Forms.Button();
            this.bttBOM = new System.Windows.Forms.Button();
            this.bttSSBOM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttDuToan
            // 
            this.bttDuToan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDuToan.Image = ((System.Drawing.Image)(resources.GetObject("bttDuToan.Image")));
            this.bttDuToan.Location = new System.Drawing.Point(9, 5);
            this.bttDuToan.Name = "bttDuToan";
            this.bttDuToan.Size = new System.Drawing.Size(114, 42);
            this.bttDuToan.TabIndex = 19;
            this.bttDuToan.Text = "Dự toán";
            this.bttDuToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttDuToan.UseVisualStyleBackColor = true;
            this.bttDuToan.Click += new System.EventHandler(this.bttDuToan_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(837, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 43);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Khách hàng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Location = new System.Drawing.Point(1, 48);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(957, 512);
            this.panel.TabIndex = 17;
            // 
            // bttBaoGia
            // 
            this.bttBaoGia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBaoGia.Image = ((System.Drawing.Image)(resources.GetObject("bttBaoGia.Image")));
            this.bttBaoGia.Location = new System.Drawing.Point(369, 2);
            this.bttBaoGia.Name = "bttBaoGia";
            this.bttBaoGia.Size = new System.Drawing.Size(114, 42);
            this.bttBaoGia.TabIndex = 16;
            this.bttBaoGia.Text = "Báo giá";
            this.bttBaoGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttBaoGia.UseVisualStyleBackColor = true;
            this.bttBaoGia.Click += new System.EventHandler(this.bttBaoGia_Click);
            // 
            // bttTínhBaoGia
            // 
            this.bttTínhBaoGia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTínhBaoGia.Image = ((System.Drawing.Image)(resources.GetObject("bttTínhBaoGia.Image")));
            this.bttTínhBaoGia.Location = new System.Drawing.Point(249, 3);
            this.bttTínhBaoGia.Name = "bttTínhBaoGia";
            this.bttTínhBaoGia.Size = new System.Drawing.Size(114, 42);
            this.bttTínhBaoGia.TabIndex = 15;
            this.bttTínhBaoGia.Text = "Tính báo giá";
            this.bttTínhBaoGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttTínhBaoGia.UseVisualStyleBackColor = true;
            this.bttTínhBaoGia.Click += new System.EventHandler(this.bttTínhBaoGia_Click);
            // 
            // bttBOM
            // 
            this.bttBOM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBOM.Image = ((System.Drawing.Image)(resources.GetObject("bttBOM.Image")));
            this.bttBOM.Location = new System.Drawing.Point(129, 3);
            this.bttBOM.Name = "bttBOM";
            this.bttBOM.Size = new System.Drawing.Size(114, 42);
            this.bttBOM.TabIndex = 20;
            this.bttBOM.Text = "BOM";
            this.bttBOM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttBOM.UseVisualStyleBackColor = true;
            this.bttBOM.Click += new System.EventHandler(this.bttBOM_Click);
            // 
            // bttSSBOM
            // 
            this.bttSSBOM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSSBOM.Image = ((System.Drawing.Image)(resources.GetObject("bttSSBOM.Image")));
            this.bttSSBOM.Location = new System.Drawing.Point(489, 2);
            this.bttSSBOM.Name = "bttSSBOM";
            this.bttSSBOM.Size = new System.Drawing.Size(114, 42);
            this.bttSSBOM.TabIndex = 21;
            this.bttSSBOM.Text = "SS lượng sử dụng";
            this.bttSSBOM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttSSBOM.UseVisualStyleBackColor = true;
            this.bttSSBOM.Click += new System.EventHandler(this.bttSSBOM_Click);
            // 
            // FrmTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 557);
            this.Controls.Add(this.bttSSBOM);
            this.Controls.Add(this.bttBOM);
            this.Controls.Add(this.bttDuToan);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.bttBaoGia);
            this.Controls.Add(this.bttTínhBaoGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiền";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttDuToan;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button bttBaoGia;
        private System.Windows.Forms.Button bttTínhBaoGia;
        private System.Windows.Forms.Button bttBOM;
        private System.Windows.Forms.Button bttSSBOM;

    }
}