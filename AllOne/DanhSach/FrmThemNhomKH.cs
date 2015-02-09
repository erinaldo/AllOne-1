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

namespace AllOne.DanhSach
{
    public partial class FrmThemNhomKH : Form
    {

        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate = CommonDB.PublicFunction.FormState.AddNew;
        public string _id;

        public FrmThemNhomKH()
        {
            InitializeComponent();
        }
 

        private void FrmThemNhomKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.S && e.Control)
            {
                bttLuu.PerformClick();
            }
            if ( e.KeyCode==Keys.Escape)
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
            if (txtMaNhomKH.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Bạn chưa nhập mã nhóm");
                txtMaNhomKH.Focus();
                return;
            }
            if (txtTenNhomKH.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Bạn chưa nhập tên nhóm");
                txtTenNhomKH.Focus();
                return;
            }
            try
            {
                NhomKhachHang obj = new NhomKhachHang();
                obj.MaNhomKH_K = txtMaNhomKH.Text;
                obj.TenNhomKH = txtTenNhomKH.Text;
                obj.GhiChu = txtGhiChu.Text;
                if (_db.ExistObject(obj) && _frmstate == PublicFunction.FormState.AddNew)
                {
                    PublicFunction.ShowWarning("Mã đơn vị tính đã tồn tại. Vui lòng đặt tên khác.");
                    txtMaNhomKH.Text="";
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
                (this.Owner as FrmMSNhomKH).LoadAll();
                txtGhiChu.Text = "";
                txtTenNhomKH.Text = "";
                txtGhiChu.Text = "";
            }
            catch (Exception ex)
            {
                PublicFunction.ShowError(ex, "bttLuu_Click", Name);
            }
        }

        private void FrmThemNhomKH_Shown(object sender, EventArgs e)
        {
           
            if (_frmstate == PublicFunction.FormState.Edit)
            {
                txtMaNhomKH.Enabled = false;
                txtTenNhomKH.Focus();
                txtMaNhomKH.Text = _id;
                NhomKhachHang obj = new NhomKhachHang();
                obj.MaNhomKH_K = _id;
                _db.GetObject(ref obj);
                txtTenNhomKH.Text = obj.TenNhomKH;
                txtGhiChu.Text = obj.GhiChu;
                txtTenNhomKH.Focus();
            }
            else
            {
                txtMaNhomKH.Focus();
            }
        }
    }
}
