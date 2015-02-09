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
using PublicUtility;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne.ThietLap
{
    public partial class FrmThemDVT : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate=CommonDB.PublicFunction.FormState.AddNew;
        public string _id;
        public FrmThemDVT()
        {
            InitializeComponent();
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (txtMaDVT.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Bạn chưa nhập mã đơn vị tính");
                txtMaDVT.Focus();
                return;
            }
            if (txtMaDVT.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Bạn chưa nhập tên đơn vị tính");
                txtTenDVT.Focus();
                return;
            }
            try
            {
                DonViTinh obj = new DonViTinh();
                obj.MaDVT_K = txtMaDVT.Text;
                obj.TenDVT = txtTenDVT.Text;
                obj.MoTa = txtGhiChu.Text;
                if (_db.ExistObject(obj) && _frmstate == PublicFunction.FormState.AddNew)
                {
                    PublicFunction.ShowWarning("Mã đơn vị tính đã tồn tại. Vui lòng đặt tên khác.");
                    txtMaDVT.Focus();
                    return;
                }
                if (_db.ExistObject(obj))
                {
                    _db.Update(obj);
                    Close();
                }
                else
                {
                    _db.Insert(obj);
                }
                (this.Owner as FrmDonViTinh).LoadAll();
                txtGhiChu.Text = "";
                txtTenDVT.Text = "";
            }catch (Exception ex)
            {
                PublicFunction.ShowError(ex, "bttLuu_Click", Name);
            }
        }

        private void FrmThemDVT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
            if (e.KeyCode == Keys.S && e.Control)
            {
                bttLuu.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FrmThemDVT_Shown(object sender, EventArgs e)
        {
            if (_frmstate==PublicFunction.FormState.Edit)
            {
                txtMaDVT.Enabled = false;
                txtTenDVT.Focus();
                txtMaDVT.Text = _id;
                DonViTinh obj = new DonViTinh();
                obj.MaDVT_K = _id;
                _db.GetObject(ref obj);
                txtTenDVT.Text = obj.TenDVT;
                txtGhiChu.Text = obj.MoTa;
            }else
            {
                txtMaDVT.Focus();
            }
        }
    }
}
