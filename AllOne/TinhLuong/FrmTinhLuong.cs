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

namespace AllOne.TinhLuong
{
    public partial class FrmTinhLuong : DockContent
    {
        public FrmTinhLuong()
        {
            InitializeComponent();
        }

        private void bttNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmBG = new FrmNhanVien();
            frmBG.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmBG);
            frmBG.Show();
            lblTitle.Text = "Nhân viên";
        }

        private void bttTangCa_Click(object sender, EventArgs e)
        {
            FrmTangCa frmBG = new FrmTangCa();
            frmBG.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmBG);
            frmBG.Show();
            lblTitle.Text = "Tăng ca";
        }

        private void bttChamCong_Click(object sender, EventArgs e)
        {
            FrmChamCong frmBG = new FrmChamCong();
            frmBG.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmBG);
            frmBG.Show();
            lblTitle.Text = "Chấm công";
        }

        private void FrmTinhLuong_Shown(object sender, EventArgs e)
        {
            bttNhanVien.PerformClick();
        }
    }
}
