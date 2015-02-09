using AllOne.TinhLuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne.Packing
{
    public partial class FrmPacking : DockContent
    {
        public FrmPacking()
        {
            InitializeComponent();
        }

        private void bttNhanVien_Click(object sender, EventArgs e)
        {
            FrmPackinglist frmBG = new FrmPackinglist();
            frmBG.TopLevel = false;
            frmBG.Show(dockPanel1, DockState.Document);
            lblTitle.Text = "Packinglist";
        }

        private void bttTangCa_Click(object sender, EventArgs e)
        {
            FrmPallet frmBG = new FrmPallet();
            frmBG.TopLevel = false;
            frmBG.Show(dockPanel1, DockState.Document);
            lblTitle.Text = "Pallet";
        }

        private void bttChamCong_Click(object sender, EventArgs e)
        {
            FrmPackinglistMaster frmBG = new FrmPackinglistMaster();
            frmBG.TopLevel = false;
            frmBG.Show(dockPanel1, DockState.Document);
            lblTitle.Text = "Packing";
        }

        private void FrmTinhLuong_Shown(object sender, EventArgs e)
        {
            bttPackinglist.PerformClick();
        }

        private void bttPalletlist_Click(object sender, EventArgs e)
        {
            FrmPalletList frmBG = new FrmPalletList();
            frmBG.TopLevel = false;
            frmBG.Show(dockPanel1, DockState.Document);
            lblTitle.Text = "Pallet list";
        }

        private void bttColor_Click(object sender, EventArgs e)
        {
            FrmColor frm = new FrmColor();
            frm.TopLevel = false;
            frm.Show(dockPanel1, DockState.Document);
            lblTitle.Text = "Color";
        }
    }
}
