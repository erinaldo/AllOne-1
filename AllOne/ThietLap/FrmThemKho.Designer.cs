namespace AllOne.ThietLap
{
    partial class FrmThemKho
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
            this.txtTenKho = new System.Windows.Forms.TextBox();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNguoiDaiDien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckoChonLamKhoBan = new System.Windows.Forms.CheckBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.lblMaKho = new System.Windows.Forms.Label();
            this.rdoSP = new System.Windows.Forms.RadioButton();
            this.rdoNL = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTenKho
            // 
            this.txtTenKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTenKho.Location = new System.Drawing.Point(106, 36);
            this.txtTenKho.MaxLength = 50;
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(392, 21);
            this.txtTenKho.TabIndex = 1;
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Location = new System.Drawing.Point(47, 39);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(51, 15);
            this.lblTenDV.TabIndex = 10;
            this.lblTenDV.Text = "Tên kho";
            // 
            // bttHuy
            // 
            this.bttHuy.Location = new System.Drawing.Point(271, 195);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(132, 42);
            this.bttHuy.TabIndex = 8;
            this.bttHuy.Text = "Hủy (Esc)";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.Location = new System.Drawing.Point(118, 195);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(132, 42);
            this.bttLuu.TabIndex = 7;
            this.bttLuu.Text = "Lưu (Ctrl+S)";
            this.bttLuu.UseVisualStyleBackColor = true;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 2);
            this.label1.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(106, 64);
            this.txtDiaChi.MaxLength = 100;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(392, 21);
            this.txtDiaChi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Địa chỉ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(106, 92);
            this.txtDienThoai.MaxLength = 50;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(392, 21);
            this.txtDienThoai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Điện thoại";
            // 
            // txtNguoiDaiDien
            // 
            this.txtNguoiDaiDien.Location = new System.Drawing.Point(106, 119);
            this.txtNguoiDaiDien.MaxLength = 50;
            this.txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            this.txtNguoiDaiDien.Size = new System.Drawing.Size(392, 21);
            this.txtNguoiDaiDien.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Người đại diện";
            // 
            // ckoChonLamKhoBan
            // 
            this.ckoChonLamKhoBan.AutoSize = true;
            this.ckoChonLamKhoBan.Location = new System.Drawing.Point(106, 146);
            this.ckoChonLamKhoBan.Name = "ckoChonLamKhoBan";
            this.ckoChonLamKhoBan.Size = new System.Drawing.Size(127, 19);
            this.ckoChonLamKhoBan.TabIndex = 6;
            this.ckoChonLamKhoBan.Text = "Chọn làm kho bán";
            this.ckoChonLamKhoBan.UseVisualStyleBackColor = true;
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(106, 9);
            this.txtMaKho.MaxLength = 50;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.ReadOnly = true;
            this.txtMaKho.Size = new System.Drawing.Size(392, 21);
            this.txtMaKho.TabIndex = 0;
            // 
            // lblMaKho
            // 
            this.lblMaKho.AutoSize = true;
            this.lblMaKho.Location = new System.Drawing.Point(47, 12);
            this.lblMaKho.Name = "lblMaKho";
            this.lblMaKho.Size = new System.Drawing.Size(46, 15);
            this.lblMaKho.TabIndex = 19;
            this.lblMaKho.Text = "Mã kho";
            // 
            // rdoSP
            // 
            this.rdoSP.AutoSize = true;
            this.rdoSP.Checked = true;
            this.rdoSP.Location = new System.Drawing.Point(271, 146);
            this.rdoSP.Name = "rdoSP";
            this.rdoSP.Size = new System.Drawing.Size(106, 19);
            this.rdoSP.TabIndex = 20;
            this.rdoSP.TabStop = true;
            this.rdoSP.Text = "Kho sản phẩm";
            this.rdoSP.UseVisualStyleBackColor = true;
            // 
            // rdoNL
            // 
            this.rdoNL.AutoSize = true;
            this.rdoNL.Location = new System.Drawing.Point(392, 145);
            this.rdoNL.Name = "rdoNL";
            this.rdoNL.Size = new System.Drawing.Size(113, 19);
            this.rdoNL.TabIndex = 21;
            this.rdoNL.Text = "Kho nguyên liệu";
            this.rdoNL.UseVisualStyleBackColor = true;
            // 
            // FrmThemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 247);
            this.Controls.Add(this.rdoNL);
            this.Controls.Add(this.rdoSP);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.lblMaKho);
            this.Controls.Add(this.ckoChonLamKhoBan);
            this.Controls.Add(this.txtNguoiDaiDien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKho);
            this.Controls.Add(this.lblTenDV);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThemKho";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm kho";
            this.Shown += new System.EventHandler(this.FrmThemKho_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmThemKho_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenKho;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguoiDaiDien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckoChonLamKhoBan;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label lblMaKho;
        private System.Windows.Forms.RadioButton rdoSP;
        private System.Windows.Forms.RadioButton rdoNL;
    }
}