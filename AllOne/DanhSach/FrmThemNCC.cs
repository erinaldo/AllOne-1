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
    public partial class FrmThemNCC : Form
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate = CommonDB.PublicFunction.FormState.AddNew;
        public string _id;
        public FrmThemNCC()
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

            string sqlTinhThanh = " SELECT [TinhThanh] FROM [TinhThanh] where TinhThanh<>N'<---Tất cả--->' ";
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

         private string TaoMaKH()
        {
            string makh = "";
            object max = _db.ExecuteScalar("select max(MaNCC) from NhaCungCap ");
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
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";
            txtSoTaiKhoan.Text = "";
            txtNguoiDaiDien.Text = "";
            txtTenKH.Text="";
            cboTinhThanh.SelectedIndex = -1;
            cboTenNganHang.SelectedIndex = -1;
            cboQuocGia.SelectedValue = "VIET NAM";
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
            
        }

        private void FrmThemKhachHang_Shown(object sender, EventArgs e)
        {
            LoadDataCombobox();
            if (_frmstate == PublicFunction.FormState.Edit)
            {
                txtNguoiDaiDien.Focus();
                NhaCungCap obj = new NhaCungCap();
                obj.MaNCC_K = _id;
                _db.GetObject(ref obj);
                txtMaKH.Text = obj.MaNCC_K;
                txtNguoiDaiDien.Text = obj.NguoiDaiDien;
                txtTenKH.Text = obj.TenNCC;
                txtFax.Text = obj.Fax;
                txtMST.Text = obj.MST;
                txtDiaChi.Text=obj.DiaChi;
                txtDienThoai.Text = obj.DienThoai;
                txtEmail.Text = obj.Email;
                txtGhiChu.Text = obj.GhiChu;
                txtSoTaiKhoan.Text = obj.SoTaiKhoan;
                if (obj.TenNganHang != null)
                    cboTenNganHang.SelectedValue = obj.TenNganHang;
                if (obj.TinhThanh != null)
                    cboTinhThanh.SelectedValue = obj.TinhThanh;
                if (obj.QuocGia != null)
                    cboQuocGia.SelectedValue = obj.QuocGia;
            }
            else
            {
                txtNguoiDaiDien.Focus();
            }

            txtTenKH.Focus();
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Tên NCC không được để trống");
                txtTenKH.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Số điện thoại không được để trống");
                txtDienThoai.Focus();
                return;
            }

           try
            {
                NhaCungCap obj = new NhaCungCap();
                if (txtMaKH.Text=="")
                {
                    obj.MaNCC_K = TaoMaKH();
                }else
                {
                    obj.MaNCC_K = txtMaKH.Text;
                }                
                obj.NguoiDaiDien =txtNguoiDaiDien.Text;
                obj.TenNCC = txtTenKH.Text;
                obj.DiaChi = txtDiaChi.Text;
                obj.DienThoai = txtDienThoai.Text;
                obj.Fax = txtFax.Text;
                obj.MST = txtMST.Text;
                obj.SoTaiKhoan = txtSoTaiKhoan.Text;
                obj.TenNganHang = cboTenNganHang.Text;
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
                (this.Owner as FrmNhaCungCap).LoadAll();
                TaoMoi();
            }
            catch (Exception ex)
            {
                PublicFunction.ShowError(ex, "bttLuu_Click", Name);
            }
        }
    }
}
