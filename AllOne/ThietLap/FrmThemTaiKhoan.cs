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
    public partial class FrmThemTaiKhoan : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate = CommonDB.PublicFunction.FormState.AddNew;
        public string _id;

        public void LoadNhomNV()
        {
            string sql = string.Format("select MaNhomNV, TenNhomNV from NhomTaiKhoan order by MaNhomNV");
            cboNhomNV.DataSource = _db.FillDataTable(sql);
            cboNhomNV.DisplayMember = "TenNhomNV";
            cboNhomNV.ValueMember = "MaNhomNV";
        }
        private void TaoMoi()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtMatKhau.Text = "";
            txtNhapLaiMK.Text = "";
            txtTenDangNhap.Text = "";
            txtTenDangNhap.Focus();
        }
        private string TaoMaNhanVien()
        {
            string manv = "";
            object max = _db.ExecuteScalar("select max(MaNV) from NhanVien ");
            if (max is DBNull)
            {
                manv = "0001";
            }
            else
            {
                manv = (Convert.ToInt16(max) + 1).ToString().PadLeft(4, '0');
            }
            return manv;
        }

        public FrmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmThemTaiKhoan_KeyDown(object sender, KeyEventArgs e)
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
            if (txtTenDangNhap.Text.Length<2)
            {
                PublicFunction.ShowWarning("Tên đăng nhập ít nhất phải 2 ký tự.");
                txtTenDangNhap.Focus();
                return;
            }
            if (txtHoTen.Text.Trim()=="")
            {
                PublicFunction.ShowWarning("Họ tên không được để trống.");
                txtHoTen.Focus();
                return;
            }
            if (cboNhomNV.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Nhóm không được để trống.");
                cboNhomNV.Focus();
                return;
            }
            if (txtMatKhau.Text!=txtNhapLaiMK.Text)
            {
                PublicFunction.ShowWarning("Mật khẩu nhập không giống nhau.");
                txtMatKhau.Focus();
                return;
            }
            if (txtMatKhau.Text.Length<6)
            {
                PublicFunction.ShowWarning("Mật khẩu có ít nhất 6 ký tự");
                txtMatKhau.Focus();
                return;
            }
            string sql = string.Format("select * from TaiKhoan where TenDangNhap='{0}' ",
                                  txtTenDangNhap.Text);
            DataTable dt = _db.FillDataTable(sql);
           
            try
            {
                TaiKhoan obj = new TaiKhoan();
                obj.MaNV_K = txtMaNV.Text;
                obj.TenNV = txtHoTen.Text;
                obj.TenDangNhap = txtTenDangNhap.Text;
                obj.MaNhomNV = cboNhomNV.SelectedValue as string;
                obj.MatKhau = txtMatKhau.Text;
                if (txtMaNV.Text.Trim()=="")
                {
                    if (dt.Rows.Count == 1)
                    {
                        PublicFunction.ShowWarning("Tên đăng nhập này đã tồn tại rồi.");
                        txtTenDangNhap.Focus();
                        return;
                    }
                    obj.MaNV_K = TaoMaNhanVien();
                    _db.Insert(obj);
                }else
                {
                    _db.Update(obj);
                    Close();
                }
                TaoMoi();
                (this.Owner as FrmTaiKhoan).LoadAll();

            }catch (Exception ex)
            {
                PublicFunction.ShowError(ex, "bttLuu_Click", Name);
            }
        }

        private void FrmThemTaiKhoan_Shown(object sender, EventArgs e)
        {
            LoadNhomNV();
            if (_frmstate == PublicFunction.FormState.Edit)
            {
                txtTenDangNhap.Focus();
                txtMaNV.Text = _id;
                TaiKhoan obj = new TaiKhoan();
                obj.MaNV_K= _id;
                _db.GetObject(ref obj);
                txtTenDangNhap.Text = obj.TenDangNhap;
                txtHoTen.Text = obj.TenNV;
                txtMatKhau.Text = obj.MatKhau;
                txtNhapLaiMK.Text = obj.MatKhau;
                cboNhomNV.SelectedValue= obj.MaNhomNV;
                txtTenDangNhap.Enabled = false;
                if (txtTenDangNhap.Text=="admin")
                {                   
                    cboNhomNV.Enabled = false;
                }
            }
            else
            {
                txtTenDangNhap.Focus();
            }
        }

        private void bttThemNhomNV_Click(object sender, EventArgs e)
        {

        }
    }
}
