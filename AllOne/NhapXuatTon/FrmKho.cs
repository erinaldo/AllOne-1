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
using AllOne.NhapXuatTon;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmKho : DockContent
    {
        public FrmKho()
        {
            InitializeComponent();
        }

        private void bttNhapKho_Click(object sender, EventArgs e)
        {
            FrmPhieuNhap frmPN = new FrmPhieuNhap();
            frmPN.TopLevel = false;
            panelTonKho.Controls.Clear();
            panelTonKho.Controls.Add(frmPN);
            frmPN.Show();
            lblTitle.Text = "Phiếu nhập";
        }

        private void bttChuyenKho_Click(object sender, EventArgs e)
        {
            FrmChuyenKho frmPX = new FrmChuyenKho();
            frmPX.TopLevel = false;
            panelTonKho.Controls.Clear();
            panelTonKho.Controls.Add(frmPX);
            frmPX.Show();
            lblTitle.Text = "Chuyển kho";
        }

        private void bttXuatKho_Click(object sender, EventArgs e)
        {
            FrmPhieuXuat frmPX = new FrmPhieuXuat();
            frmPX.TopLevel = false;
            panelTonKho.Controls.Clear();
            panelTonKho.Controls.Add(frmPX);
            frmPX.Show();
            lblTitle.Text = "Phiếu xuất";
        }

        private void bttTon_Click(object sender, EventArgs e)
        {
            
            FrmTonKho frmPX = new FrmTonKho();
            frmPX.TopLevel = false;
            panelTonKho.Controls.Clear();
            panelTonKho.Controls.Add(frmPX);
            frmPX.Show();
            lblTitle.Text = "Tồn kho";
        }

        private void bttKiemKe_Click(object sender, EventArgs e)
        {
            FrmKiemKe frmPX = new FrmKiemKe();
            frmPX.TopLevel = false;
            panelTonKho.Controls.Clear();
            panelTonKho.Controls.Add(frmPX);
            frmPX.Show();
            lblTitle.Text = "Kiểm kê";
        }

        private void FrmKho_Shown(object sender, EventArgs e)
        {
           if( CurrentSetting.GiaBan == PublicFunction.GiaBan.GiaBanLe)
           { rdoGiaBanLe.Checked = true;}
           else
           { rdoGiaSi.Checked = true;}

            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            { rdoSP.Checked = true; }
            else
            { rdoNL.Checked = true; }

            if (CurrentSetting.MaTienTe == "VND")
                rdoVND.Checked = true;
            else
                rdoUSD.Checked = true;
        }

        private void bttTimKiemNX_Click(object sender, EventArgs e)
        {
            FrmTimKiemNX frmPX = new FrmTimKiemNX();
            frmPX.TopLevel = false;
            panelTonKho.Controls.Clear();
            panelTonKho.Controls.Add(frmPX);
            frmPX.Show();
            lblTitle.Text = "Tìm kiếm nhập xuất";
        }

        private void rdoSP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSP.Checked)
                CurrentSetting.HangHoa = PublicFunction.HangHoa.SanPham;
            else
                CurrentSetting.HangHoa = PublicFunction.HangHoa.NguyenLieu;
        }

        private void rdoGiaBanLe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGiaSi.Checked)
                CurrentSetting.GiaBan = PublicFunction.GiaBan.GiaBanSi;
            else
                CurrentSetting.GiaBan = PublicFunction.GiaBan.GiaBanLe;
        }

        private void rdoVND_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVND.Checked)
                CurrentSetting.MaTienTe = "VND";
            else
                CurrentSetting.MaTienTe = "USD";
        }
    }
}
