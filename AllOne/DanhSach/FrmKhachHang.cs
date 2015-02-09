using AllOne.DanhSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonDB;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmKhachHang : DockContent
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void bttNhomKH_Click(object sender, EventArgs e)
        {
            FrmMSNhomKH frmNhomSP = new FrmMSNhomKH();
            frmNhomSP.TopLevel = false;
            panelKH.Controls.Clear();
            panelKH.Controls.Add(frmNhomSP);
            frmNhomSP.Show();
            lblTitle.Text = "Nhóm khách hàng";
        }

        private void bttKhachHang_Click(object sender, EventArgs e)
        {
            FrmMSKhachHang frm  = new FrmMSKhachHang();
            frm .TopLevel = false;
            panelKH.Controls.Clear();
            panelKH.Controls.Add(frm );
            frm .Show();
            lblTitle.Text = "Khách hàng";
        }

        private void FrmKhachHang_Shown(object sender, EventArgs e)
        {
            bttKhachHang.PerformClick();
        }

        private void bttNCC_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frmNCC = new FrmNhaCungCap();
            frmNCC.TopLevel = false;
            panelKH.Controls.Clear();
            panelKH.Controls.Add(frmNCC);
            frmNCC.Show();
            lblTitle.Text = "Nhà cung cấp";
        }


    }
}
