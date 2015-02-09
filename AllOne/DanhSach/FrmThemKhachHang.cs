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
    public partial class FrmThemKhachHang : Form
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate = CommonDB.PublicFunction.FormState.AddNew;
        public string _id;
        public FrmThemKhachHang()
        {
            InitializeComponent();
        }
        private void LoadDataCombobox()
        {
            string sqlQuocGia = " SELECT [QuocGia] FROM [QuocGia] ";
            cboQuocGia.DataSource = _db.FillDataTable(sqlQuocGia);
            cboQuocGia.ValueMember = "QuocGia";
            cboQuocGia.DisplayMember = "QuocGia";
            cboQuocGia.SelectedValue = "VIET NAM";

            string sqlTinhThanh = " SELECT [TinhThanh] FROM [TinhThanh] where TinhThanh <> N'<---Tất cả--->' ";
            cboTinhThanh.DataSource = _db.FillDataTable(sqlTinhThanh);
            cboTinhThanh.ValueMember = "TinhThanh";
            cboTinhThanh.DisplayMember = "TinhThanh";
            cboTinhThanh.SelectedIndex = -1;

            string sql = " SELECT TenNganHang FROM [NganHang] ";
            cboTenNganHang.DataSource = _db.FillDataTable(sql);
            cboTenNganHang.ValueMember = "TenNganHang";
            cboTenNganHang.DisplayMember = "TenNganHang";
            cboTenNganHang.SelectedIndex = -1;
        }

        private void LoadNhom()
        {
            string sql = " SELECT [MaNhomKH],[TenNhomKH],[GhiChu] "+
                         " FROM [NhomKhachHang] where MaNhomKH<>'00' ";
            cboNhom.DataSource = _db.FillDataTable(sql);
            cboNhom.ValueMember = "MaNhomKH";
            cboNhom.DisplayMember = "TenNhomKH";
            cboNhom.SelectedIndex = 0;
        }
        private string TaoMaKH()
        {
            string makh = "";
            object max = _db.ExecuteScalar("select max(MaKH) from KhachHang ");
            if (max is DBNull)
            {
                makh = "0001";
            }
            else
            {
                makh = (Convert.ToInt16(max) + 1).ToString().PadLeft(4, '0');
            }
            return makh;
        }
        private void TaoMoi()
        {
            txtMaKH.Text = "";
            txtFax.Text = "";
            txtMST.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai1.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";
            txtNguoiDaiDien1.Text = "";
            txtTenKH.Text="";
            cboTinhThanh.SelectedIndex = -1;
            cboQuocGia.SelectedValue = "VIET NAM";
            cboNhom.SelectedIndex = -1;
            txtTenKH.Focus();
        }
        private void FrmThemKhachHang_KeyDown(object sender, KeyEventArgs e)
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

        private void bttThemNhom_Click(object sender, EventArgs e)
        {
            FrmThemNhomKH frm = new FrmThemNhomKH();
            frm.Owner = null;
            frm.ShowDialog();
            LoadNhom();
            
        }

        private void FrmThemKhachHang_Shown(object sender, EventArgs e)
        {
            LoadNhom();
            LoadDataCombobox();
            if (_frmstate == PublicFunction.FormState.Edit)
            {
                txtTenKH.Focus();
                KhachHang obj = new KhachHang();
                obj.MaKH_K = _id;
                _db.GetObject(ref obj);
                txtMaKH.Text = obj.MaKH_K;
                txtNguoiDaiDien1.Text = obj.NguoiDaiDien1;
                txtDienThoai1.Text = obj.DienThoai1;
                txtChucVu1.Text = obj.ChucVu1;
                txtNguoiDaiDien2.Text = obj.NguoiDaiDien2;
                txtDienThoai2.Text = obj.DienThoai2;
                txtChucVu2.Text = obj.ChucVu2;
                txtTenKH.Text = obj.TenKH;
                txtFax.Text = obj.Fax;
                txtMST.Text = obj.MST;
                txtDiaChi.Text=obj.DiaChi;                
                txtEmail.Text = obj.Email;
                txtGhiChu.Text = obj.GhiChu;
                txtSoTaiKhoan.Text = obj.SoTaiKhoan;
                if (obj.TenNganHang != null)
                    cboTenNganHang.SelectedValue = obj.TenNganHang;
                if (obj.TinhThanh != null)
                    cboTinhThanh.SelectedValue = obj.TinhThanh;
                if (obj.QuocGia != null)
                    cboQuocGia.SelectedValue = obj.QuocGia;
                cboNhom.SelectedValue = obj.MaNhomKH;                
            }
            else
            {
                txtTenKH.Focus();
            }
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Tên khách hàng không được để trống");
                txtTenKH.Focus();
                return;
            }
            if (txtNguoiDaiDien1.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Người đại diện (1) không được để trống");
                txtNguoiDaiDien1.Focus();
                return;
            }
            if (txtDienThoai1.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Số điện thoại (1) không được để trống");
                txtDienThoai1.Focus();
                return;
            }

           try
            {
                KhachHang obj = new KhachHang();
                if (txtMaKH.Text=="")
                {
                    obj.MaKH_K = TaoMaKH();
                }else
                {
                    obj.MaKH_K = txtMaKH.Text;
                }                
                obj.NguoiDaiDien1 =txtNguoiDaiDien1.Text;
                obj.NguoiDaiDien2 = txtNguoiDaiDien2.Text;
                obj.DienThoai1 = txtDienThoai1.Text;
                obj.DienThoai2 = txtDienThoai2.Text;
                obj.ChucVu1 = txtChucVu1.Text;
                obj.ChucVu2 = txtChucVu2.Text;
                obj.TenKH = txtTenKH.Text;
                obj.DiaChi = txtDiaChi.Text;                
                obj.Fax = txtFax.Text;
                obj.MST = txtMST.Text;
                obj.SoTaiKhoan = txtSoTaiKhoan.Text;
                obj.TenNganHang = cboTenNganHang.Text;
                obj.MaNhomKH = cboNhom.SelectedValue.ToString();
                obj.TinhThanh = cboTinhThanh.Text;
                obj.QuocGia = cboQuocGia.Text;
                obj.Email = txtEmail.Text;
                obj.GhiChu = txtGhiChu.Text;
                if (_db.ExistObject(obj))
                {
                    _db.Update(obj);
                    Close();
                }
                else
                {
                    _db.Insert(obj);
                }
                (this.Owner as FrmMSKhachHang).LoadAll();
                TaoMoi();
            }
            catch (Exception ex)
            {
                PublicFunction.ShowError(ex, "bttLuu_Click", Name);
            }
        }
    }
}
