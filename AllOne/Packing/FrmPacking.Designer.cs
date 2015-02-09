namespace AllOne.Packing
{
    partial class FrmPacking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacking));
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bttPacking = new System.Windows.Forms.Button();
            this.bttPallet = new System.Windows.Forms.Button();
            this.bttPackinglist = new System.Windows.Forms.Button();
            this.bttPalletlist = new System.Windows.Forms.Button();
            this.bttColor = new System.Windows.Forms.Button();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
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
            // bttPacking
            // 
            this.bttPacking.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPacking.Image = ((System.Drawing.Image)(resources.GetObject("bttPacking.Image")));
            this.bttPacking.Location = new System.Drawing.Point(243, -1);
            this.bttPacking.Name = "bttPacking";
            this.bttPacking.Size = new System.Drawing.Size(114, 49);
            this.bttPacking.TabIndex = 18;
            this.bttPacking.Text = "G.Packing";
            this.bttPacking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttPacking.UseVisualStyleBackColor = true;
            this.bttPacking.Click += new System.EventHandler(this.bttChamCong_Click);
            // 
            // bttPallet
            // 
            this.bttPallet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPallet.Image = ((System.Drawing.Image)(resources.GetObject("bttPallet.Image")));
            this.bttPallet.Location = new System.Drawing.Point(123, 0);
            this.bttPallet.Name = "bttPallet";
            this.bttPallet.Size = new System.Drawing.Size(114, 49);
            this.bttPallet.TabIndex = 17;
            this.bttPallet.Text = "Pallet";
            this.bttPallet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttPallet.UseVisualStyleBackColor = true;
            this.bttPallet.Click += new System.EventHandler(this.bttTangCa_Click);
            // 
            // bttPackinglist
            // 
            this.bttPackinglist.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPackinglist.Image = ((System.Drawing.Image)(resources.GetObject("bttPackinglist.Image")));
            this.bttPackinglist.Location = new System.Drawing.Point(1, 0);
            this.bttPackinglist.Name = "bttPackinglist";
            this.bttPackinglist.Size = new System.Drawing.Size(114, 49);
            this.bttPackinglist.TabIndex = 16;
            this.bttPackinglist.Text = "Packinglist";
            this.bttPackinglist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttPackinglist.UseVisualStyleBackColor = true;
            this.bttPackinglist.Click += new System.EventHandler(this.bttNhanVien_Click);
            // 
            // bttPalletlist
            // 
            this.bttPalletlist.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPalletlist.Image = ((System.Drawing.Image)(resources.GetObject("bttPalletlist.Image")));
            this.bttPalletlist.Location = new System.Drawing.Point(363, -1);
            this.bttPalletlist.Name = "bttPalletlist";
            this.bttPalletlist.Size = new System.Drawing.Size(114, 49);
            this.bttPalletlist.TabIndex = 23;
            this.bttPalletlist.Text = "Pallet list";
            this.bttPalletlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttPalletlist.UseVisualStyleBackColor = true;
            this.bttPalletlist.Click += new System.EventHandler(this.bttPalletlist_Click);
            // 
            // bttColor
            // 
            this.bttColor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttColor.Image = ((System.Drawing.Image)(resources.GetObject("bttColor.Image")));
            this.bttColor.Location = new System.Drawing.Point(483, -3);
            this.bttColor.Name = "bttColor";
            this.bttColor.Size = new System.Drawing.Size(114, 49);
            this.bttColor.TabIndex = 24;
            this.bttColor.Text = "Color";
            this.bttColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttColor.UseVisualStyleBackColor = true;
            this.bttColor.Click += new System.EventHandler(this.bttColor_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockPanel1.DockBackColor = System.Drawing.SystemColors.Control;
            this.dockPanel1.Location = new System.Drawing.Point(1, 55);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(952, 501);
            dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
            tabGradient1.EndColor = System.Drawing.SystemColors.Control;
            tabGradient1.StartColor = System.Drawing.SystemColors.Control;
            tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin1.TabGradient = tabGradient1;
            autoHideStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
            dockPaneStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
            dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
            this.dockPanel1.Skin = dockPanelSkin1;
            this.dockPanel1.TabIndex = 25;
            // 
            // FrmPacking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 557);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.bttColor);
            this.Controls.Add(this.bttPalletlist);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.bttPacking);
            this.Controls.Add(this.bttPallet);
            this.Controls.Add(this.bttPackinglist);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "FrmPacking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packinglist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmTinhLuong_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button bttPacking;
        private System.Windows.Forms.Button bttPallet;
        private System.Windows.Forms.Button bttPackinglist;
        private System.Windows.Forms.Button bttPalletlist;
        private System.Windows.Forms.Button bttColor;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;

    }
}