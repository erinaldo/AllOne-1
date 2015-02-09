namespace AllOne.Packing
{
    partial class FrmPalletList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPalletList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bdn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gridP = new System.Windows.Forms.DataGridView();
            this.txtUnitPallet = new System.Windows.Forms.TextBox();
            this.bttAdd = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblW = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.lblL = new System.Windows.Forms.Label();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).BeginInit();
            this.bdn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridP)).BeginInit();
            this.SuspendLayout();
            // 
            // bdn
            // 
            this.bdn.AddNewItem = null;
            this.bdn.AutoSize = false;
            this.bdn.CountItem = this.bindingNavigatorCountItem;
            this.bdn.DeleteItem = null;
            this.bdn.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.bdn.Location = new System.Drawing.Point(0, 427);
            this.bdn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bdn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdn.Name = "bdn";
            this.bdn.PositionItem = this.bindingNavigatorPositionItem;
            this.bdn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bdn.Size = new System.Drawing.Size(965, 30);
            this.bdn.TabIndex = 34;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 27);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // gridP
            // 
            this.gridP.AllowUserToAddRows = false;
            this.gridP.AllowUserToDeleteRows = false;
            this.gridP.AllowUserToOrderColumns = true;
            this.gridP.AllowUserToResizeRows = false;
            this.gridP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridP.BackgroundColor = System.Drawing.Color.White;
            this.gridP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridP.ColumnHeadersHeight = 30;
            this.gridP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa,
            this.W,
            this.L,
            this.H,
            this.Weight,
            this.UnitPallet,
            this.Description});
            this.gridP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridP.EnableHeadersVisualStyles = false;
            this.gridP.Location = new System.Drawing.Point(0, 42);
            this.gridP.Name = "gridP";
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridP.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gridP.RowHeadersVisible = false;
            this.gridP.RowHeadersWidth = 30;
            this.gridP.RowTemplate.Height = 30;
            this.gridP.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridP.Size = new System.Drawing.Size(965, 382);
            this.gridP.StandardTab = true;
            this.gridP.TabIndex = 33;
            this.gridP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridP_CellClick);
            // 
            // txtUnitPallet
            // 
            this.txtUnitPallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUnitPallet.Location = new System.Drawing.Point(372, 12);
            this.txtUnitPallet.Name = "txtUnitPallet";
            this.txtUnitPallet.Size = new System.Drawing.Size(40, 20);
            this.txtUnitPallet.TabIndex = 4;
            this.txtUnitPallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttAdd
            // 
            this.bttAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttAdd.Location = new System.Drawing.Point(418, 8);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(71, 28);
            this.bttAdd.TabIndex = 5;
            this.bttAdd.Text = "Add";
            this.bttAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(217, 15);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(40, 14);
            this.lblWeight.TabIndex = 41;
            this.lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtWeight.Location = new System.Drawing.Point(261, 12);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(44, 20);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(313, 15);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(53, 14);
            this.lblUnit.TabIndex = 42;
            this.lblUnit.Text = "Unit/pallet";
            // 
            // txtH
            // 
            this.txtH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtH.Location = new System.Drawing.Point(173, 12);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(38, 20);
            this.txtH.TabIndex = 2;
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(9, 15);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(17, 14);
            this.lblW.TabIndex = 43;
            this.lblW.Text = "W";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(149, 15);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(14, 14);
            this.lblH.TabIndex = 45;
            this.lblH.Text = "H";
            // 
            // txtW
            // 
            this.txtW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtW.Location = new System.Drawing.Point(35, 12);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(38, 20);
            this.txtW.TabIndex = 0;
            this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtL
            // 
            this.txtL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtL.Location = new System.Drawing.Point(103, 12);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(38, 20);
            this.txtL.TabIndex = 1;
            this.txtL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(81, 15);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(13, 14);
            this.lblL.TabIndex = 44;
            this.lblL.Text = "L";
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.FillWeight = 66.81474F;
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 50;
            // 
            // W
            // 
            this.W.DataPropertyName = "W";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.W.DefaultCellStyle = dataGridViewCellStyle9;
            this.W.HeaderText = "W";
            this.W.Name = "W";
            this.W.ReadOnly = true;
            this.W.Width = 50;
            // 
            // L
            // 
            this.L.DataPropertyName = "L";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.L.DefaultCellStyle = dataGridViewCellStyle10;
            this.L.HeaderText = "L";
            this.L.Name = "L";
            this.L.ReadOnly = true;
            this.L.Width = 50;
            // 
            // H
            // 
            this.H.DataPropertyName = "H";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.H.DefaultCellStyle = dataGridViewCellStyle11;
            this.H.HeaderText = "H";
            this.H.Name = "H";
            this.H.ReadOnly = true;
            this.H.Width = 50;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            this.Weight.DefaultCellStyle = dataGridViewCellStyle12;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 80;
            // 
            // UnitPallet
            // 
            this.UnitPallet.DataPropertyName = "UnitPallet";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.UnitPallet.DefaultCellStyle = dataGridViewCellStyle13;
            this.UnitPallet.HeaderText = "UnitPallet";
            this.UnitPallet.Name = "UnitPallet";
            this.UnitPallet.ReadOnly = true;
            this.UnitPallet.Width = 80;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // FrmPalletList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 457);
            this.Controls.Add(this.txtUnitPallet);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.bdn);
            this.Controls.Add(this.gridP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmPalletList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PalletList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmPalletList_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPalletList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).EndInit();
            this.bdn.ResumeLayout(false);
            this.bdn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bdn;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView gridP;
        private System.Windows.Forms.TextBox txtUnitPallet;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn L;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}