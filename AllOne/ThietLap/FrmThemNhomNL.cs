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
    public partial class FrmThemNhomNL : DockContent
    {
        DBSql _db = new DBSql(PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate = CommonDB.PublicFunction.FormState.AddNew;
        public string _id;
        public FrmThemNhomNL()
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
            if (txtMaNhomNL.Text.Trim()=="")
            {
                PublicFunction.ShowWarning("Mã nhóm không được để trống") ;
                txtMaNhomNL.Focus();
                return;
            }
            if (txtTenNhomNL.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Tên nhóm không được để trống");
                txtMaNhomNL.Focus();
                return;
            }
                  
            try
            {
                NhomNguyenLieu obj = new NhomNguyenLieu();
                obj.MaNhom_K = txtMaNhomNL.Text;
                obj.TenNhom = txtTenNhomNL.Text;
                if (_db.ExistObject(obj) && _frmstate == PublicFunction.FormState.AddNew)
                {
                    PublicFunction.ShowWarning("Mã nhóm đã tồn tại. Vui lòng đặt tên khác.");
                    txtMaNhomNL.Focus();
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
                txtMaNhomNL.Text = "";
                txtTenNhomNL.Text = "";
                txtTenNhomNL.Focus();
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
                txtTenNhomNL.Focus();
                txtMaNhomNL.Text = _id;
                NhomNguyenLieu obj = new NhomNguyenLieu();
                obj.MaNhom_K = _id;
                _db.GetObject(ref obj);
                txtTenNhomNL.Text = obj.TenNhom;
                txtMaNhomNL.Enabled = false;
            }
            else
            {
                txtMaNhomNL.ReadOnly = false;
                txtTenNhomNL.Focus();
            }
        }
    }
}
