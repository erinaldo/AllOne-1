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
    public partial class FrmThemNguyenLieu : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate = CommonDB.PublicFunction.FormState.AddNew;
        public string _id;
        
        private void TaoMoi()
        {
            txtGhiChu.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtMaNL.Text = "";
            cboDVT.SelectedIndex = -1;
            cboNCC.SelectedIndex = -1;
            txtMaNL.Focus();
        }

        private string TaoMaNL(string manhom)
        {
            string masanpham = "";
            object max = _db.ExecuteScalar(string.Format("select max(MaNL) from NguyenLieu where MaNhom='{0}' ", manhom));
            if (max is DBNull)
            {
                masanpham = manhom + "0001";
            }
            else
            {
                masanpham = (Convert.ToInt16(max.ToString().Substring(2, 4)) + 1).ToString().PadLeft(4, '0');
                masanpham = manhom + masanpham;
            }
            return masanpham;
        }
        private void LoadTienTe()
        {
            string sql = string.Format("select MaTienTe from TienTe order by MaTienTe desc ");
            cboTienTe.DataSource = _db.FillDataTable(sql);
            cboTienTe.DisplayMember = "MaTienTe";
            cboTienTe.ValueMember = "MaTienTe";
        }
        private void LoadDataDVT()
        {
            string sql = string.Format("select MaDVT,TenDVT from DonViTinh order by TenDVT ");
            cboDVT.DataSource = _db.FillDataTable(sql);
            cboDVT.DisplayMember = "TenDVT";
            cboDVT.ValueMember = "MaDVT";
        }
        private void LoadDataNCC()
        {
            string sqlNCC = string.Format("select MaNCC,TenNCC from NhaCungCap where MaNCC <>'0000'  order by TenNCC ");
            cboNCC.DataSource = _db.FillDataTable(sqlNCC);
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
            string sql = string.Format("  select MaNhom,TenNhom from NhomNguyenLieu  where MaNhom <>'00'  order by TenNhom ");
            cboNhom.DataSource = _db.FillDataTable(sql);
            cboNhom.DisplayMember = "TenNhom";
            cboNhom.ValueMember = "MaNhom";
            cboNhom.SelectedIndex = 0;
        }
        public FrmThemNguyenLieu()
        {
            InitializeComponent();
        }
        private void FrmThemSanPham_KeyDown(object sender, KeyEventArgs e)
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

        private void bttThemDVT_Click(object sender, EventArgs e)
        {
            FrmThemDVT frm = new FrmThemDVT();
            frm.ShowDialog();
            LoadDataDVT();
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Mã nguyên liệu không được để trống.");
                txtMaNL.Focus();
                return;
            }
            if (txtTenNL.Text.Trim()=="")
            {
                PublicFunction.ShowWarning("Tên nguyên liệu không được để trống.");
                txtTenNL.Focus();
                return;
            }
            if (cboDVT.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Đơn vị tính không được để trống.");
                cboDVT.Focus();
                return;
            }
            if (cboNCC.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Nhà cung cấp không được để trống.");
                cboNCC.Focus();
                return;
            }
            if (cboNhom.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Nhóm nguyên liệu không được để trống.");
                cboNhom.Focus();
                return;
            }
            try
            {
                NguyenLieu obj = new NguyenLieu();
                obj.MaNL_K = txtMaNL.Text;
                obj.TenNL = txtTenNL.Text;
                obj.MaDVT = cboDVT.SelectedValue.ToString();
                obj.GhiChu = txtGhiChu.Text;
                obj.MaTienTe = cboTienTe.SelectedValue.ToString();
               
                obj.MaNCC = cboNCC.SelectedValue.ToString();
                obj.MaNhom = cboNhom.SelectedValue.ToString();
                if (txtGiaNhap.Text != "")
                    obj.GiaNhap = Convert.ToDecimal(txtGiaNhap.Text);
                else
                    obj.GiaNhap = 0;

                if (txtGiaBan.Text != "")
                    obj.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
                else
                    obj.GiaBan = 0;

                if (txtMaNL.Enabled==true)
                {
                    if (!_db.ExistObject(obj))
                    { _db.Insert(obj); }
                    else
                    {
                        PublicFunction.ShowWarning("Mã nguyên liệu này đã tồn tại rồi. Vui lòng đặt mã khác.");
                        txtMaNL.Focus();
                        return;
                    }
                }
                else
                {
                    _db.Update(obj);
                    Close();
                }
                TaoMoi();
                (this.Owner as FrmNguyenLieu).LoadAll();

            }
            catch (Exception ex)
            {
                PublicFunction.ShowError(ex, "bttLuu_Click", Name);
            }
  
        }

        private void FrmThemSanPham_Shown(object sender, EventArgs e)
        {
            LoadDataDVT();
            LoadDataNCC();
            LoadTienTe();
            if (_frmstate == PublicFunction.FormState.Edit)
            {
                txtTenNL.Focus();
                txtMaNL.Text = _id;
                NguyenLieu obj = new NguyenLieu();
                obj.MaNL_K = _id;
                _db.GetObject(ref obj);
                txtMaNL.Text = obj.MaNL_K;
                txtTenNL.Text = obj.TenNL;
                cboDVT.SelectedValue = obj.MaDVT;
                txtGhiChu.Text = obj.GhiChu;
                txtGiaNhap.Text = obj.GiaNhap.ToString("N3");
                txtGiaBan.Text = obj.GiaBan.ToString("N3");
                cboTienTe.SelectedValue = obj.MaTienTe;
                cboNCC.SelectedValue = obj.MaNCC;
                cboNhom.SelectedValue = obj.MaNhom;

                txtMaNL.Enabled = false;
            }
            else
            {
                txtMaNL.Enabled = true;
                txtMaNL.Focus();
            }
        }

    }
}
