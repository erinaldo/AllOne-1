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
    public partial class FrmThemNhomSP : DockContent
    {
        DBSql _db = new DBSql(PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate = CommonDB.PublicFunction.FormState.AddNew;
        public string _id;
        public FrmThemNhomSP()
        {
            InitializeComponent();
        }
   
        private void FrmThemNhomSP_KeyDown(object sender, KeyEventArgs e)
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

        private void bttHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNhomSP.Text.Trim()=="")
            {
                PublicFunction.ShowWarning("Mã nhóm không được để trống") ;
                txtMaNhomSP.Focus();
                return;
            }
            if (txtTenNhomSP.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Tên nhóm không được để trống");
                txtMaNhomSP.Focus();
                return;
            }
                  
            try
            {
                NhomSanPham obj = new NhomSanPham();
                obj.MaNhom_K = txtMaNhomSP.Text;
                obj.TenNhom = txtTenNhomSP.Text;
                if (_db.ExistObject(obj) && _frmstate == PublicFunction.FormState.AddNew)
                {
                    PublicFunction.ShowWarning("Mã nhóm đã tồn tại. Vui lòng đặt tên khác.");
                    txtMaNhomSP.Focus();
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
                (this.Owner as FrmNhomNL).LoadAll();
                txtMaNhomSP.Text = "";
                txtTenNhomSP.Text = "";
                txtTenNhomSP.Focus();
            }
            catch (Exception ex)
            {
                PublicFunction.ShowError(ex, "bttLuu_Click", Name);
            }

        }

        private void FrmThemNhomSP_Shown(object sender, EventArgs e)
        {
            if (_frmstate == PublicFunction.FormState.Edit)
            {
                txtTenNhomSP.Focus();
                txtMaNhomSP.Text = _id;
                NhomSanPham obj = new NhomSanPham();
                obj.MaNhom_K = _id;
                _db.GetObject(ref obj);
                txtTenNhomSP.Text = obj.TenNhom;
                txtMaNhomSP.Enabled = false;
            }
            else
            {
                txtMaNhomSP.ReadOnly = false;
                txtTenNhomSP.Focus();
            }
        }
    }
}
