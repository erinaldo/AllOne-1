namespace AllOne
{
    partial class FrmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangKy));
            this.bttDangKy = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttDangKy
            // 
            this.bttDangKy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDangKy.Image = ((System.Drawing.Image)(resources.GetObject("bttDangKy.Image")));
            this.bttDangKy.Location = new System.Drawing.Point(53, 95);
            this.bttDangKy.Name = "bttDangKy";
            this.bttDangKy.Size = new System.Drawing.Size(132, 50);
            this.bttDangKy.TabIndex = 0;
            this.bttDangKy.Text = "Đăng ký";
            this.bttDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttDangKy.UseVisualStyleBackColor = true;
            this.bttDangKy.Click += new System.EventHandler(this.bttDangKy_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(39, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(303, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mật khẩu đăng ký";
            // 
            // bttThoat
            // 
            this.bttThoat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Image = ((System.Drawing.Image)(resources.GetObject("bttThoat.Image")));
            this.bttThoat.Location = new System.Drawing.Point(191, 95);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(132, 50);
            this.bttThoat.TabIndex = 3;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(376, 157);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.bttDangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký bản quyền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttDangKy;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttThoat;
    }
}