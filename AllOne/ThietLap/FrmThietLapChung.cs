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

namespace AllOne.ThietLap
{
    public partial class FrmThietLapChung : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmThietLapChung()
        {
            InitializeComponent();
        }

        private void LoadCongty()
        {
            CongTy obj = new CongTy();
            obj.MaCT_K = "01";
            _db.GetObject(ref obj);
            txtTenCT.Text = obj.TenCongTy;
            txtDiaChi.Text = obj.DiaChi;
            txtDienThoai.Text = obj.DienThoai;
            txtFax.Text = obj.Fax;
            txtMST.Text = obj.MaSoThue;
            txtEmail.Text = obj.Email;
            txtWebsite.Text = obj.Website;
            if (obj.Logo != null)
                pboHinhSP.Image = PublicFunction.GetImageFromArrayByte(obj.Logo);
               
        }


        private void bttTaiHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pboHinhSP.ImageLocation = open.FileName;
            }
        }

        private void bttXoaHinh_Click(object sender, EventArgs e)
        {
            pboHinhSP.Image = null;
        }

        private void FrmThietLapChung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            CongTy obj = new CongTy();
            obj.MaCT_K = "01";
            obj.TenCongTy = txtTenCT.Text;
            obj.DiaChi = txtDiaChi.Text;
            obj.DienThoai = txtDienThoai.Text;
            obj.MaSoThue = txtMST.Text;
            obj.Website = txtWebsite.Text;
            obj.Email = txtEmail.Text;
            obj.Fax = txtFax.Text;
            if (rdoVND.Checked)
                obj.MaTienTe = "VND";
            else
                obj.MaTienTe = "USD";

            if (pboHinhSP.Image != null)
                obj.Logo = PublicFunction.ImageToByteArray(pboHinhSP.Image);
            if (pboHinhSP.ImageLocation!=null)
                obj.Logo = PublicFunction.ConvertFileToArrayByte(pboHinhSP.ImageLocation);
            if (_db.ExistObject(obj))
                _db.Update(obj);
            else
                _db.Insert(obj);

            CurrentSetting.MaTienTe = obj.MaTienTe;
            PublicFunction.ShowSuccess();
        }

        private void FrmThietLapChung_Shown(object sender, EventArgs e)
        {
            LoadCongty();
        }
    }
}
