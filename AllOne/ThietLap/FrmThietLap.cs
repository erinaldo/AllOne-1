using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllOne.ThietLap;
using CommonDB;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmThietLap : DockContent
    {
        public FrmThietLap()
        {
            InitializeComponent();
        }

        private void bttNhomSP_Click(object sender, EventArgs e)
        {
            FrmNhomSP frmNhomSP = new FrmNhomSP();
            frmNhomSP.TopLevel = false;
            panelThietLap.Controls.Clear();
            panelThietLap.Controls.Add(frmNhomSP);
            frmNhomSP.Show();
            lblTitle.Text = "Nhóm sản phẩm";
        }

        private void bttSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSP = new FrmSanPham();
            frmSP.TopLevel = false;
            panelThietLap.Controls.Clear();
            panelThietLap.Controls.Add(frmSP);
            frmSP.Show();
            lblTitle.Text = "Sản phẩm";
        }

        private void bttDVT_Click(object sender, EventArgs e)
        {
            FrmDonViTinh frmDVT = new FrmDonViTinh();
            frmDVT.TopLevel = false;
            panelThietLap.Controls.Clear();
            panelThietLap.Controls.Add(frmDVT);
            frmDVT.Show();
            lblTitle.Text = "Đơn vị tính";
        }

        private void bttKho_Click(object sender, EventArgs e)
        {
            FrmDSKho frmKho = new FrmDSKho();
            frmKho.TopLevel = false;
            panelThietLap.Controls.Clear();
            panelThietLap.Controls.Add(frmKho);
            frmKho.Show();
            lblTitle.Text = "Kho hàng";
        }

        private void btttTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan frmTaiKhoan = new FrmTaiKhoan();
            frmTaiKhoan.TopLevel = false;
            panelThietLap.Controls.Clear();
            panelThietLap.Controls.Add(frmTaiKhoan);
            frmTaiKhoan.Show();
            lblTitle.Text = "Tài khoản";
        }

        private void bttThietLapChung_Click(object sender, EventArgs e)
        {
            FrmThietLapChung frm  = new FrmThietLapChung();
            frm .TopLevel = false;
            panelThietLap.Controls.Clear();
            panelThietLap.Controls.Add(frm );
            frm .Show();
            lblTitle.Text = "Thiết lập chung";
        }

        private void FrmThietLap_Shown(object sender, EventArgs e)
        {
            bttSanPham.PerformClick();
            if (CurrentSetting.User.TenDangNhap=="admin")
            {
                bttTaiKhoan.Enabled = true;
                bttTyGia.Enabled = true;
                bttThietLapChung.Enabled = true;
            }else
            {
                bttTaiKhoan.Enabled = false;
                bttTyGia.Enabled = false;
                bttThietLapChung.Enabled = false;
            }
        }

        private void bttTyGia_Click(object sender, EventArgs e)
        {
            FrmTyGia frmTaiKhoan = new FrmTyGia();
            frmTaiKhoan.TopLevel = false;
            panelThietLap.Controls.Clear();
            panelThietLap.Controls.Add(frmTaiKhoan);
            frmTaiKhoan.Show();
            lblTitle.Text = "Tỷ giá";
        }

        private void bttNguyenLieu_Click(object sender, EventArgs e)
        {
            FrmNguyenLieu frmNL = new FrmNguyenLieu();
            frmNL.TopLevel = false;
            panelThietLap.Controls.Clear();
            panelThietLap.Controls.Add(frmNL);
            frmNL.Show();
            lblTitle.Text = "Nguyên liệu";
        }

        private void bttNhomNL_Click(object sender, EventArgs e)
        {
            FrmNhomNL frmNL = new FrmNhomNL();
            frmNL.TopLevel = false;
            panelThietLap.Controls.Clear();
            panelThietLap.Controls.Add(frmNL);
            frmNL.Show();
            lblTitle.Text = "Nhóm nguyên liệu";
        }
    }
}
