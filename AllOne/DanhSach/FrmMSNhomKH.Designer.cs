namespace AllOne.DanhSach
{
    partial class FrmMSNhomKH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMSNhomKH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bttXuatExcel = new System.Windows.Forms.Button();
            this.bttThemMoi = new System.Windows.Forms.Button();
            this.bdn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaNhomKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhomKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).BeginInit();
            this.bdn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bttXuatExcel
            // 
            this.bttXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttXuatExcel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("bttXuatExcel.Image")));
            this.bttXuatExcel.Location = new System.Drawing.Point(820, 335);
            this.bttXuatExcel.Name = "bttXuatExcel";
            this.bttXuatExcel.Size = new System.Drawing.Size(110, 40);
            this.bttXuatExcel.TabIndex = 16;
            this.bttXuatExcel.Text = "&Xuất excel";
            this.bttXuatExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttXuatExcel.UseVisualStyleBackColor = true;
            this.bttXuatExcel.Click += new System.EventHandler(this.bttXuatExcel_Click);
            // 
            // bttThemMoi
            // 
            this.bttThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttThemMoi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("bttThemMoi.Image")));
            this.bttThemMoi.Location = new System.Drawing.Point(704, 335);
            this.bttThemMoi.Name = "bttThemMoi";
            this.bttThemMoi.Size = new System.Drawing.Size(110, 40);
            this.bttThemMoi.TabIndex = 15;
            this.bttThemMoi.Text = "&Thêm mới";
            this.bttThemMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttThemMoi.UseVisualStyleBackColor = true;
            this.bttThemMoi.Click += new System.EventHandler(this.bttThemMoi_Click);
            // 
            // bdn
            // 
            this.bdn.AddNewItem = null;
            this.bdn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdn.AutoSize = false;
            this.bdn.CountItem = this.bindingNavigatorCountItem;
            this.bdn.DeleteItem = null;
            this.bdn.Dock = System.Windows.Forms.DockStyle.None;
            this.bdn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bdn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bdn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bdn.Location = new System.Drawing.Point(0, 335);
            this.bdn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bdn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdn.Name = "bdn";
            this.bdn.PositionItem = this.bindingNavigatorPositionItem;
            this.bdn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bdn.Size = new System.Drawing.Size(942, 45);
            this.bdn.TabIndex = 14;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 42);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 42);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 30;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa,
            this.Sua,
            this.MaNhomKH,
            this.TenNhomKH});
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(0, 4);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 30;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 30;
            this.grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.Size = new System.Drawing.Size(942, 325);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 13;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.FillWeight = 66.81474F;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 80;
            // 
            // Sua
            // 
            this.Sua.DataPropertyName = "Sua";
            this.Sua.HeaderText = "Sửa";
            this.Sua.Name = "Sua";
            this.Sua.ReadOnly = true;
            this.Sua.Text = "Sửa";
            this.Sua.UseColumnTextForButtonValue = true;
            this.Sua.Width = 80;
            // 
            // MaNhomKH
            // 
            this.MaNhomKH.DataPropertyName = "MaNhomKH";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaNhomKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaNhomKH.FillWeight = 66.81474F;
            this.MaNhomKH.HeaderText = "Mã nhóm";
            this.MaNhomKH.Name = "MaNhomKH";
            this.MaNhomKH.ReadOnly = true;
            this.MaNhomKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNhomKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MaNhomKH.Width = 80;
            // 
            // TenNhomKH
            // 
            this.TenNhomKH.DataPropertyName = "TenNhomKH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TenNhomKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenNhomKH.FillWeight = 66.81474F;
            this.TenNhomKH.HeaderText = "Tên nhóm";
            this.TenNhomKH.Name = "TenNhomKH";
            this.TenNhomKH.ReadOnly = true;
            this.TenNhomKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenNhomKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TenNhomKH.Width = 200;
            // 
            // FrmMSNhomKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 384);
            this.Controls.Add(this.bttXuatExcel);
            this.Controls.Add(this.bttThemMoi);
            this.Controls.Add(this.bdn);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMSNhomKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhóm khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmMSNhomKH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).EndInit();
            this.bdn.ResumeLayout(false);
            this.bdn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.Button bttXuatExcel;
        private System.Windows.Forms.Button bttThemMoi;
        private System.Windows.Forms.BindingNavigator bdn;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhomKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhomKH;
    }
}