namespace AllOne
{
    partial class FrmCauHinhKetNoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCauHinhKetNoi));
            this.txtKetNoi = new System.Windows.Forms.TextBox();
            this.bttThoat = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKetNoi
            // 
            this.txtKetNoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKetNoi.Font = new System.Drawing.Font("Arial", 10F);
            this.txtKetNoi.Location = new System.Drawing.Point(12, 12);
            this.txtKetNoi.Multiline = true;
            this.txtKetNoi.Name = "txtKetNoi";
            this.txtKetNoi.Size = new System.Drawing.Size(448, 134);
            this.txtKetNoi.TabIndex = 11;
            this.txtKetNoi.UseSystemPasswordChar = true;
            // 
            // bttThoat
            // 
            this.bttThoat.Image = ((System.Drawing.Image)(resources.GetObject("bttThoat.Image")));
            this.bttThoat.Location = new System.Drawing.Point(167, 187);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(138, 44);
            this.bttThoat.TabIndex = 14;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BackColor = System.Drawing.Color.Green;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.ForeColor = System.Drawing.Color.Green;
            this.lblLine.Location = new System.Drawing.Point(-13, 164);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(500, 3);
            this.lblLine.TabIndex = 10;
            // 
            // FrmCauHinhKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 243);
            this.Controls.Add(this.txtKetNoi);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.lblLine);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCauHinhKetNoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Shown += new System.EventHandler(this.FrmCauHinhKetNoi_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKetNoi;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Label lblLine;
    }
}