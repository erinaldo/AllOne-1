namespace AllOne.ThietLap
{
    partial class FrmThemNhomNL
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
            this.txtMaNhomNL = new System.Windows.Forms.TextBox();
            this.lblMaNhom = new System.Windows.Forms.Label();
            this.txtTenNhomNL = new System.Windows.Forms.TextBox();
            this.lblTenNhom = new System.Windows.Forms.Label();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaNhomNL
            // 
            this.txtMaNhomNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMaNhomNL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaNhomNL.Location = new System.Drawing.Point(77, 46);
            this.txtMaNhomNL.MaxLength = 2;
            this.txtMaNhomNL.Name = "txtMaNhomNL";
            this.txtMaNhomNL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMaNhomNL.Size = new System.Drawing.Size(346, 21);
            this.txtMaNhomNL.TabIndex = 1;
            // 
            // lblMaNhom
            // 
            this.lblMaNhom.AutoSize = true;
            this.lblMaNhom.Location = new System.Drawing.Point(8, 49);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(58, 15);
            this.lblMaNhom.TabIndex = 12;
            this.lblMaNhom.Text = "Mã nhóm";
            // 
            // txtTenNhomNL
            // 
            this.txtTenNhomNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTenNhomNL.Location = new System.Drawing.Point(77, 17);
            this.txtTenNhomNL.MaxLength = 50;
            this.txtTenNhomNL.Name = "txtTenNhomNL";
            this.txtTenNhomNL.Size = new System.Drawing.Size(346, 21);
            this.txtTenNhomNL.TabIndex = 0;
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Location = new System.Drawing.Point(8, 20);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(63, 15);
            this.lblTenNhom.TabIndex = 10;
            this.lblTenNhom.Text = "Tên nhóm";
            // 
            // bttHuy
            // 
            this.bttHuy.Location = new System.Drawing.Point(229, 153);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(132, 42);
            this.bttHuy.TabIndex = 3;
            this.bttHuy.Text = "Hủy (Esc)";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Location = new System.Drawing.Point(76, 153);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(132, 42);
            this.bttLuu.TabIndex = 2;
            this.bttLuu.Text = "Lưu (Ctrl+S)";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(1, 142);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(435, 2);
            this.lblLine.TabIndex = 7;
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.BackColor = System.Drawing.Color.DarkGreen;
            this.lblHuongDan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuongDan.ForeColor = System.Drawing.Color.White;
            this.lblHuongDan.Location = new System.Drawing.Point(1, 84);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(435, 35);
            this.lblHuongDan.TabIndex = 14;
            this.lblHuongDan.Text = "(Mã nhóm được sử dụng làm 2 ký tự đầu cho mã nguyên, nên bạn đặt sau cho dễ nhớ, " +
    "dễ hiểu)";
            // 
            // FrmThemNhomNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 208);
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.txtMaNhomNL);
            this.Controls.Add(this.lblMaNhom);
            this.Controls.Add(this.txtTenNhomNL);
            this.Controls.Add(this.lblTenNhom);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.lblLine);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThemNhomNL";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm nhóm nguyên liệu";
            this.Shown += new System.EventHandler(this.FrmThemNhomSP_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmThemNhomSP_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaNhomNL;
        private System.Windows.Forms.Label lblMaNhom;
        private System.Windows.Forms.TextBox txtTenNhomNL;
        private System.Windows.Forms.Label lblTenNhom;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblHuongDan;
    }
}