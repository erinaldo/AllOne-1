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
    public partial class FrmThemSanPham : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate = CommonDB.PublicFunction.FormState.AddNew;
        public string _id;
  
        private void LoadMau()
        {
            string sql = string.Format("select MaMau from Mau ");
            cboMau.DataSource = _db.FillDataTable(sql);
            cboMau.ValueMember = "MaMau";
            cboMau.DisplayMember = "MaMau";
        }
        private void TaoMoi()
        {
            txtGiaBan.Text = "0";
            txtGiaNhap.Text = "0";
            txtTyTrong.Text = "";
            txtMau.Text = "";
            txtGhiChu.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtW.Text = "0";
            txtH.Text = "0";
            txtL.Text = "0";
            txtSetOfPallet.Text = "0";
            txtMinOrder.Text = "0";
            txtWeight.Text = "0";
            //cboDVT.SelectedIndex = -1;
            //cboNhomSP.SelectedIndex = -1;
            cboNCC.SelectedIndex = -1;
            txtMaSP.Focus();
            grid.RowCount = 1;
            gridMau.RowCount = 1;
        }

        private string TaoMaSP(string manhom)
        {
            string masanpham = "";
            object max = _db.ExecuteScalar(string.Format("select max(MaSP) from SanPham where MaNhom='{0}' ",manhom));
            if (max is DBNull)
            {
                masanpham = manhom + "0001";
            }
            else
            {
                masanpham = (Convert.ToInt16(max.ToString().Substring(2,4)) + 1).ToString().PadLeft(4, '0');
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
            cboTienTe.SelectedValue = "VND";
        }
        private void LoadDataDVT()
        {
            string sql = string.Format("select MaDVT,TenDVT from DonViTinh order by TenDVT ");
            cboDVT.DataSource = _db.FillDataTable(sql);
            cboDVT.DisplayMember = "TenDVT";
            cboDVT.ValueMember = "MaDVT";
        }
        private void LoadDataNhomSP()
        {
            string sql = string.Format("select MaNhom,TenNhom from NhomSanPham where MaNhom<>'00' order by TenNhom  ");
            cboNhomSP.DataSource = _db.FillDataTable(sql);
            cboNhomSP.DisplayMember = "TenNhom";
            cboNhomSP.ValueMember = "MaNhom";

            string sqlNCC = string.Format("select MaNCC,TenNCC from NhaCungCap  where MaNCC<>'0000' order by  TenNCC");
            cboNCC.DataSource = _db.FillDataTable(sqlNCC);
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
        }
        private void LuuChiTietSP(string masp)
        {
            string sql = string.Format("delete from CTSanPham where MaSP='{0}' ", masp);
            _db.ExecuteNonQuery(sql);
            foreach(DataGridViewRow r in grid.Rows)
            {
                if (!r.IsNewRow)
                {
                    CTSanPham obj = new CTSanPham();
                    obj.MaSP_K = masp;
                    obj.STT_K =Convert.ToInt16( r.Cells["STT"].Value);
                    obj.Rong =Convert.ToInt16( r.Cells["Rong"].Value);
                    obj.Dai =Convert.ToInt16( r.Cells["Dai"].Value);
                    obj.Cao = Convert.ToInt16(r.Cells["Cao"].Value);
                    obj.CanNang =Convert.ToDecimal( r.Cells["CanNang"].Value);
                    _db.Insert(obj);
                }
            }

            string sqlGia = string.Format("delete from SanPhamGia where MaSP='{0}' ", masp);
            _db.ExecuteNonQuery(sqlGia);
            foreach (DataGridViewRow r in gridMau.Rows)
            {
                if (!r.IsNewRow)
                {
                    SanPhamGia obj = new SanPhamGia();
                    obj.MaSP_K = masp;
                    obj.MaMau_K =r.Cells["MaMau"].Value.ToString();
                    _db.Insert(obj);
                }
            }
        }
        public FrmThemSanPham()
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

        private void bttThemNhomSP_Click(object sender, EventArgs e)
        {
            FrmThemNhomSP frm = new FrmThemNhomSP();
            frm.ShowDialog();
            LoadDataNhomSP();
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Mã sản phẩm không được để trống.");
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim()=="")
            {
                PublicFunction.ShowWarning("Tên sản phẩm không được để trống.");
                txtTenSP.Focus();
                return;
            }
            if (cboDVT.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Đơn vị tính không được để trống.");
                cboDVT.Focus();
                return;
            }
            if (cboNhomSP.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Nhóm sản phẩm không được để trống.");
                cboNhomSP.Focus();
                return;
            }
            //if (cboNCC.SelectedIndex == -1)
            //{
            //    PublicFunction.ShowWarning("Nhà cung cấp không được để trống.");
            //    cboNCC.Focus();
            //    return;
            //}
            if (grid.RowCount==1)
            {
                PublicFunction.ShowWarning("Bạn chưa nhập thông số Pot Size.");
                return;
            }
            // if (gridMau.RowCount==0)
            //{
            //    PublicFunction.ShowWarning("Bạn chưa nhập mã màu sản phẩm.");
            //    return;
            //}
            //if (txtW.Text=="" || txtL.Text=="" || txtH.Text==""||txtMinOrder.Text==""||txtSetOfPallet.Text=="")
            //{
            //    PublicFunction.ShowWarning("Bạn chưa nhập đầy đủ thông tin Pallet.");
            //    txtW.Focus();
            //    return;
            //}
            try
            {
                decimal CanNang = 0;
                foreach (DataGridViewRow r in grid.Rows)
                {
                    if (!r.IsNewRow)
                    {
                        CanNang += Convert.ToDecimal(r.Cells["CanNang"].Value);
                    }
                }
                SanPham obj = new SanPham();
                obj.MaSP_K = txtMaSP.Text;
                obj.TenSP = txtTenSP.Text;
                obj.MaDVT = cboDVT.SelectedValue.ToString();
                obj.MaNhom = cboNhomSP.SelectedValue.ToString();
                obj.GhiChu = txtGhiChu.Text;
                obj.Mau = txtMau.Text;
                obj.MaTienTe = cboTienTe.SelectedValue.ToString();
                if (cboNCC.SelectedIndex >= 0)
                {
                    obj.MaNCC = cboNCC.SelectedValue.ToString();
                }
                obj.CanNang = CanNang;
                obj.Rong = Convert.ToInt16(grid.Rows[0].Cells["Rong"].Value);
                obj.Dai = Convert.ToInt16(grid.Rows[0].Cells["Dai"].Value);
                obj.Cao = Convert.ToInt16(grid.Rows[0].Cells["Cao"].Value);
                if (txtGiaBan.Text != "")
                {
                    obj.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
                }
                if (txtGiaNhap.Text != "")
                {
                    obj.GiaNhap = Convert.ToDecimal(txtGiaNhap.Text);
                }
                if (pboHinhSP.ImageLocation != null)
                {
                    obj.HinhAnh = PublicFunction.ConvertFileToArrayByte(pboHinhSP.ImageLocation);
                    obj.ImageH = pboHinhSP.Image.Height;
                    obj.ImageW = pboHinhSP.Image.Width;
                }else
                {
                    if (pboHinhSP.Image != null)
                    {
                        obj.HinhAnh = PublicFunction.ImageToByteArray(pboHinhSP.Image);
                        obj.ImageH = pboHinhSP.Image.Height;
                        obj.ImageW = pboHinhSP.Image.Width;
                    }
                }
                if (txtTyTrong.Text != "")
                {
                    obj.TyTrong = Convert.ToDecimal(txtTyTrong.Text);
                }
                if (txtL.Text != "")
                {
                    obj.L = Convert.ToInt32(txtL.Int);
                }
                if (txtW.Text != "")
                {
                    obj.W = Convert.ToInt32(txtW.Int);
                }
                if (txtH.Text != "")
                {
                    obj.H = Convert.ToInt32(txtH.Int);
                }
                if (txtWeight.Text != "")
                {
                    obj.Weight = Convert.ToInt32(txtWeight.Int);
                }
                if (txtSetOfPallet.Text != "")
                {
                    obj.SetPerPallet = Convert.ToInt32(txtSetOfPallet.Int);
                }
                if (txtMinOrder.Text != "")
                {
                    obj.MinOrder = Convert.ToInt32(txtMinOrder.Int);
                }
                if (txtMaSP.Enabled)
                {
                    //obj.MaSP_K = TaoMaSP(cboNhomSP.SelectedValue.ToString());
                    if (! _db.ExistObject(obj))
                    {
                        _db.Insert(obj);
                        LuuChiTietSP(obj.MaSP_K);
                    }else
                    {
                        PublicFunction.ShowWarning("Mã sản phẩm này đã tồn tại. Vui lòng nhập mã khác.");
                        return;
                    }
                }
                else
                {
                    _db.Update(obj);
                    LuuChiTietSP(obj.MaSP_K);
                    Close();
                }
                TaoMoi();
                (this.Owner as FrmSanPham).LoadAll();
            }
            catch (Exception ex)
            {
                PublicFunction.ShowError(ex, "bttLuu_Click", Name);
            }
  
        }

        private void FrmThemSanPham_Shown(object sender, EventArgs e)
        {
            LoadMau();
            LoadDataDVT();
            LoadDataNhomSP();
            LoadTienTe();
            if (_frmstate == PublicFunction.FormState.Edit)
            {
                txtMaSP.Enabled = false;
                txtTenSP.Focus();
                txtMaSP.Text = _id;
                SanPham obj = new SanPham();
                obj.MaSP_K = _id;
                _db.GetObject(ref obj);
                txtMaSP.Text = obj.MaSP_K;
                txtTenSP.Text = obj.TenSP;
                cboDVT.SelectedValue = obj.MaDVT;
                cboNhomSP.SelectedValue = obj.MaNhom;
                txtGhiChu.Text = obj.GhiChu;
                txtMaSP.ReadOnly = true;
                txtMau.Text = obj.Mau;
                txtW.Text = obj.W.ToString("N0");
                txtL.Text = obj.L.ToString("N0");
                txtH.Text = obj.H.ToString("N0");
                txtGiaBan.Text = obj.GiaBan.ToString("N3");
                txtGiaNhap.Text = obj.GiaNhap.ToString("N3");
                txtWeight.Text = obj.Weight.ToString();
                txtSetOfPallet.Text = obj.SetPerPallet.ToString();
                txtMinOrder.Text = obj.MinOrder.ToString();
                txtTyTrong.Text = obj.TyTrong.ToString();
                cboTienTe.SelectedValue = obj.MaTienTe;
                if (obj.MaNCC != null)
                    cboNCC.SelectedValue = obj.MaNCC;
                if (obj.HinhAnh != null)
                    pboHinhSP.Image = PublicFunction.GetImageFromArrayByte(obj.HinhAnh);

                DataTable dtCT = _db.FillDataTable(string.Format("select STT,Rong,Dai,Cao,CanNang from CTSanPham where MaSP='{0}' ", obj.MaSP_K));
                foreach (DataRow row in dtCT.Rows)
                {
                    grid.Rows.Add(1);
                    grid.Rows[grid.RowCount - 2].Cells["STT"].Value = row["STT"];
                    grid.Rows[grid.RowCount - 2].Cells["Rong"].Value = row["Rong"];
                    grid.Rows[grid.RowCount - 2].Cells["Dai"].Value = row["Dai"];
                    grid.Rows[grid.RowCount - 2].Cells["Cao"].Value = row["Cao"];
                    grid.Rows[grid.RowCount - 2].Cells["CanNang"].Value = row["CanNang"];
                }
                DataTable dtMau = _db.FillDataTable(string.Format("select MaMau from SanPhamGia where MaSP='{0}' ", obj.MaSP_K));
                foreach (DataRow row in dtMau.Rows)
                {
                    gridMau.Rows.Add(1);
                    gridMau.Rows[gridMau.RowCount - 1].Cells["MaMau"].Value = row["MaMau"];
                }
            }
            else
            {
                txtMaSP.Enabled = true;
                txtMaSP.Focus();
            }
        }

        private void bttTaiHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog()==DialogResult.OK)
            {
                pboHinhSP.ImageLocation = open.FileName;
            }
        }

        private void bttXoaHinh_Click(object sender, EventArgs e)
        {
            pboHinhSP.Image = null;
        }

        private void grid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            int index = 1;
            foreach (DataGridViewRow r in grid.Rows)
            {
                r.Cells["STT"].Value = index;
                index++;
            }
        }

        private void grid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int index = 1;
            foreach (DataGridViewRow r in grid.Rows)
            {
                r.Cells["STT"].Value = index;
                index++;
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow.IsNewRow)
                return;
            if (e.ColumnIndex==grid.Columns["Xoa"].Index)
            {
                grid.Rows.Remove(grid.CurrentRow);
            }
        }

        private void gridMau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridMau.CurrentRow.IsNewRow)
                return;
            if (e.ColumnIndex == gridMau.Columns["XoaM"].Index)
            {
                gridMau.Rows.Remove(gridMau.CurrentRow);
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in gridMau.Rows)
            {
                if (r.Cells["MaMau"].Value.ToString()==cboMau.Text)
                {
                    return;
                }
            }
            gridMau.Rows.Add(1);
            gridMau.Rows[gridMau.RowCount - 1].Cells["MaMau"].Value = cboMau.Text;
        }

        private void cboNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                cboNCC.SelectedIndex = -1;
            }
        }
    }
}

