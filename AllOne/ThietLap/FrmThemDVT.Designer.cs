namespace AllOne.ThietLap
{
    partial class FrmThemDVT
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.lblTenDVT = new System.Windows.Forms.Label();
            this.txtTenDVT = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMaDVT = new System.Windows.Forms.TextBox();
            this.lblMaDVT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 2);
            this.label1.TabIndex = 0;
            // 
            // bttLuu
            // 
            this.bttLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttLuu.Location = new System.Drawing.Point(93, 180);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(113, 39);
            this.bttLuu.TabIndex = 3;
            this.bttLuu.Text = "Lưu (Ctrl+S)";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttHuy.Location = new System.Drawing.Point(224, 180);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(113, 39);
            this.bttHuy.TabIndex = 4;
            this.bttHuy.Text = "Hủy (Esc)";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // lblTenDVT
            // 
            this.lblTenDVT.AutoSize = true;
            this.lblTenDVT.Location = new System.Drawing.Point(11, 40);
            this.lblTenDVT.Name = "lblTenDVT";
            this.lblTenDVT.Size = new System.Drawing.Size(64, 15);
            this.lblTenDVT.TabIndex = 3;
            this.lblTenDVT.Text = "Tên đơn vị";
            // 
            // txtTenDVT
            // 
            this.txtTenDVT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTenDVT.Location = new System.Drawing.Point(81, 37);
            this.txtTenDVT.MaxLength = 20;
            this.txtTenDVT.Name = "txtTenDVT";
            this.txtTenDVT.Size = new System.Drawing.Size(337, 21);
            this.txtTenDVT.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(81, 64);
            this.txtGhiChu.MaxLength = 100;
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(337, 47);
            this.txtGhiChu.TabIndex = 2;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(26, 67);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(36, 15);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtMaDVT
            // 
            this.txtMaDVT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMaDVT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaDVT.Location = new System.Drawing.Point(81, 10);
            this.txtMaDVT.MaxLength = 5;
            this.txtMaDVT.Name = "txtMaDVT";
            this.txtMaDVT.Size = new System.Drawing.Size(337, 21);
            this.txtMaDVT.TabIndex = 0;
            // 
            // lblMaDVT
            // 
            this.lblMaDVT.AutoSize = true;
            this.lblMaDVT.Location = new System.Drawing.Point(16, 13);
            this.lblMaDVT.Name = "lblMaDVT";
            this.lblMaDVT.Size = new System.Drawing.Size(59, 15);
            this.lblMaDVT.TabIndex = 7;
            this.lblMaDVT.Text = "Mã đơn vị";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "(Mã đơn vị tối đã 5 ký tự, viết hoa không dấu, nên đặt dễ hiểu gợi nhớ)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmThemDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaDVT);
            this.Controls.Add(this.lblMaDVT);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtTenDVT);
            this.Controls.Add(this.lblTenDVT);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThemDVT";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm đơn vị tính";
            this.Shown += new System.EventHandler(this.FrmThemDVT_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmThemDVT_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Label lblTenDVT;
        private System.Windows.Forms.TextBox txtTenDVT;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMaDVT;
        private System.Windows.Forms.Label lblMaDVT;
        private System.Windows.Forms.Label label3;
    }
}