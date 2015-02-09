using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllOne.Tien;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmTien : DockContent
    {
        public FrmTien()
        {
            InitializeComponent();
        }

        private void bttBaoGia_Click(object sender, EventArgs e)
        {
            FrmBaoGia frmBG = new FrmBaoGia();
            frmBG.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmBG);
            frmBG.Show();
            lblTitle.Text = "Báo giá";
        }

        private void bttDuToan_Click(object sender, EventArgs e)
        {
            FrmDuToan frmBG = new FrmDuToan();
            frmBG.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmBG);
            frmBG.Show();
            lblTitle.Text = "Dự toán";
        }

        private void bttTínhBaoGia_Click(object sender, EventArgs e)
        {
            FrmTinhBaoGia frmBG = new FrmTinhBaoGia();
            frmBG.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmBG);
            frmBG.Show();
            lblTitle.Text = "Tính báo giá";
        }

        private void bttBOM_Click(object sender, EventArgs e)
        {
            FrmBOM frmbom = new FrmBOM();
            frmbom.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmbom);
            frmbom.Show();
            lblTitle.Text = "BOM";
        }

        private void bttSSBOM_Click(object sender, EventArgs e)
        {
            FrmSoSanhBOM frmbom = new FrmSoSanhBOM();
            frmbom.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmbom);
            frmbom.Show();
            lblTitle.Text = "SS lượng sử dụng";
        }
    }
}
