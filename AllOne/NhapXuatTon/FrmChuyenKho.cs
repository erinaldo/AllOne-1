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
using AllOne.NhapXuatTon;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmChuyenKho : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        List<SanPhamGia> lstMaSP = new List<SanPhamGia>();
        List<string> lstMaNL = new List<string>();
        private bool _isload = false;
        public FrmChuyenKho()
        {
            InitializeComponent();
        }
        private bool KiemTraKhoaTonKho()
        {
            string sql = string.Format("select * from TonKho where Khoa=1 ");
            DataTable dt = _db.FillDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void TaoMoiPN()
        {
            txtGhiChu.Text = "";
            txtTongSL.Text = "";
            txtTongTien.Text = "";
            lstMaSP.Clear();
            grid.Rows.Clear();
            grid.Focus();
            grid.CurrentCell = grid.Rows[0].Cells["SoLuong"];
        }
        private string TaoMaPhieuNhap()
        {
            string mapn = "";
            object max = _db.ExecuteScalar(string.Format("select max(MaPN) from PhieuNhap where MaPN like '{0}%' ",
                                           "PN" + dtpNgayNhap.Value.ToString("ddMMyy")));
            if (max is DBNull)
            {
                mapn = "PN" + dtpNgayNhap.Value.ToString("ddMMyy") + "001";
            }
            else
            {
                mapn = (Convert.ToInt16(max.ToString().Substring(8, 3)) + 1).ToString().PadLeft(3, '0');
                mapn = "PN" + dtpNgayNhap.Value.ToString("ddMMyy") + mapn;
            }
            return mapn;
        }
        private string TaoMaPhieuXuat()
        {
            string mapn = "";
            object max = _db.ExecuteScalar(string.Format("select max(MaPX) from PhieuXuat where MaPX like '{0}%' ",
                                           "PX" + dtpNgayNhap.Value.ToString("ddMMyy")));
            if (max is DBNull)
            {
                mapn = "PX" + dtpNgayNhap.Value.ToString("ddMMyy") + "001";
            }
            else
            {
                mapn = (Convert.ToInt16(max.ToString().Substring(8, 3)) + 1).ToString().PadLeft(3, '0');
                mapn = "PX" + dtpNgayNhap.Value.ToString("ddMMyy") + mapn;
            }
            return mapn;
        }
        private void LoadKho()
        {
            string sql = string.Format("select Makho, tenkho from Kho where Loai='{0}' ",
                                        CurrentSetting.HangHoa.ToString());
            cboKhoXuat.DataSource = _db.FillDataTable(sql);
            cboKhoXuat.ValueMember = "MaKho";
            cboKhoXuat.DisplayMember = "TenKho";

            cboKhoNhap.DataSource = _db.FillDataTable(sql);
            cboKhoNhap.ValueMember = "MaKho";
            cboKhoNhap.DisplayMember = "TenKho";
        }
        private void TongCong()
        {
            decimal tongsoluong = 0;
            decimal tongthanhtien = 0;
            foreach (DataGridViewRow r in grid.Rows)
            {
                if (!r.IsNewRow && r.Cells["SoLuong"].Value != null)
                {
                    if (r.Cells["SoLuong"].Value.ToString() != "")
                        tongsoluong += Convert.ToDecimal(r.Cells["SoLuong"].Value);
                }
                if (!r.IsNewRow && r.Cells["ThanhTienNhap"].Value != null)
                {
                    if (r.Cells["ThanhTienNhap"].Value.ToString() != "")
                        tongthanhtien += Convert.ToDecimal(r.Cells["ThanhTienNhap"].Value);
                }
            }
            txtTongSL.Text = tongsoluong.ToString("N0");
            txtTongTien.Text = tongthanhtien.ToString("N3");
        }
        private void FrmChuyenKho_Shown(object sender, EventArgs e)
        {
            grid.Focus();
            LoadKho();
            lblMaTienTe.Text = CurrentSetting.MaTienTe;
        }

        private void gridPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (grid.CurrentCell.ColumnIndex == grid.Columns["GhiChu"].Index)
                    grid.CurrentCell.Value = "";
            }
            if (e.KeyCode == Keys.Enter && e.Control)
            {
                _isload = true;
                if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
                {
                    FrmTimSanPham frm = new FrmTimSanPham();
                    frm.ShowDialog();
                    if (frm._list != null)
                    {
                        foreach (SanPhamGia sp in frm._list)
                        {
                            if (!lstMaSP.Contains(sp))
                            {
                                grid.Rows.Add();
                                int index = grid.Rows.Count - 1;
                                SanPham obj = new SanPham();
                                obj.MaSP_K = sp.MaSP_K;
                                _db.GetObject(ref obj);
                                DonViTinh dvt = new DonViTinh();
                                dvt.MaDVT_K = obj.MaDVT;
                                _db.GetObject(ref dvt);
                                Mau mau = new Mau();
                                mau.MaMau_K = sp.MaMau_K;
                                _db.GetObject(ref mau);
                                grid.Rows[index].Cells["SoLuong"].Value = 1;
                                grid.Rows[index].Cells["MaSP"].Value = obj.MaSP_K;
                                grid.Rows[index].Cells["MaMau"].Value = sp.MaMau_K;
                                grid.Rows[index].Cells["TenSP"].Value = obj.TenSP;
                               grid.Rows[index].Cells["TenDVT"].Value = dvt.TenDVT;
                                grid.Rows[index].Cells["GiaNhap"].Value = obj.GiaNhap*mau.Price;
                                grid.Rows[index].Cells["ThanhTienNhap"].Value = obj.GiaNhap*mau.Price;
                                grid.Rows[index].Cells["MaTienTe"].Value = obj.MaTienTe;
                                grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];
                                lstMaSP.Add(sp);
                            }
                            else
                            {
                                foreach (DataGridViewRow r in grid.Rows)
                                {
                                    if (!r.IsNewRow)
                                    {
                                        if (r.Cells["MaSP"].Value.ToString() == sp.MaSP_K && r.Cells["MaMau"].Value.ToString() == sp.MaMau_K)
                                        {
                                            r.Cells["SoLuong"].Value = Convert.ToInt16(r.Cells["SoLuong"].Value) + 1;
                                            r.Cells["ThanhTienNhap"].Value = Convert.ToInt16(r.Cells["SoLuong"].Value) * Convert.ToDecimal(r.Cells["GiaNhap"].Value);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }else
                {
                    FrmTimNguyenLieu frm = new FrmTimNguyenLieu();
                    frm.ShowDialog();
                    if (frm._list != null)
                    {
                        foreach (string sp in frm._list)
                        {
                            if (!lstMaNL.Contains(sp))
                            {
                                grid.Rows.Add();
                                int index = grid.Rows.Count - 1;
                                NguyenLieu obj = new NguyenLieu();
                                obj.MaNL_K = sp;
                                _db.GetObject(ref obj);
                                grid.Rows[index].Cells["SoLuong"].Value = 1;
                                grid.Rows[index].Cells["MaSP"].Value = obj.MaNL_K;
                                grid.Rows[index].Cells["TenSP"].Value = obj.TenNL;
                                grid.Rows[index].Cells["TenDVT"].Value = obj.MaDVT;
                                grid.Rows[index].Cells["GiaNhap"].Value = obj.GiaNhap;
                                grid.Rows[index].Cells["ThanhTienNhap"].Value = obj.GiaNhap;
                                grid.Rows[index].Cells["MaTienTe"].Value = obj.MaTienTe;
                                grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];
                                lstMaNL.Add(sp);
                            }
                            else
                            {
                                foreach (DataGridViewRow r in grid.Rows)
                                {
                                    if (!r.IsNewRow)
                                    {
                                        if (r.Cells["MaSP"].Value.ToString() == sp)
                                        {
                                            r.Cells["SoLuong"].Value = Convert.ToInt16(r.Cells["SoLuong"].Value) + 1;
                                            r.Cells["ThanhTienNhap"].Value = Convert.ToInt16(r.Cells["SoLuong"].Value) * Convert.ToDecimal(r.Cells["GiaNhap"].Value);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                _isload = false;
            }
        }


        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (cboKhoNhap.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Kho nhập không được để trống.");
                cboKhoNhap.Focus();
                return;
            }
            if (cboKhoXuat.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Kho xuất không được để trống.");
                cboKhoXuat.Focus();
                return;
            }
            if (cboKhoNhap.SelectedValue.ToString() == cboKhoXuat.SelectedValue.ToString())
            {
                PublicFunction.ShowWarning("Kho xuất và kho nhập phải khác nhau.");
                cboKhoXuat.Focus();
                return;
            }
            if (grid.Rows.Count == 1)
            {
                PublicFunction.ShowWarning("Bạn chưa nhập sản phẩm.");
                grid.Focus();
                grid.CurrentCell = grid.Rows[0].Cells["SoLuong"];
                return;
            }
            if (KiemTraKhoaTonKho())
            {
                PublicFunction.ShowWarning(string.Format("Tồn kho tháng [{0}] đã khóa.",
                                                        dtpNgayNhap.Value.ToString("yyyyMM")));
                return;
            }
            try
            {
                _db.BeginTransaction();

                PhieuNhap objpn = new PhieuNhap();
                objpn.LoaiHinh = CurrentSetting.HangHoa.ToString();
                objpn.GhiChu = txtGhiChu.Text;
                objpn.MaKho = cboKhoNhap.SelectedValue.ToString();
                objpn.NgayNhap = PublicFunction.GetStartDate(dtpNgayNhap.Value);
                objpn.NgayTao = DateTime.Now;
                objpn.NVTao = PublicUtility.CurrentUser.UserID;
                objpn.MaPN_K = TaoMaPhieuNhap();
                _db.Insert(objpn);
                _db.ExecuteNonQuery(string.Format("delete from CTNhap where MaPN='{0}' ", objpn.MaPN_K));
                foreach (DataGridViewRow r in grid.Rows)
                {
                    if (!r.IsNewRow)
                    {
                        CTNhap objctn = new CTNhap();
                        objctn.MaPN_K = objpn.MaPN_K;
                        if (r.Cells["GhiChu"].Value != null)
                            objctn.GhiChu = r.Cells["GhiChu"].Value.ToString();
                        objctn.GiaNhap = Convert.ToDecimal(r.Cells["GiaNhap"].Value);
                        objctn.MaSP_K = r.Cells["MaSP"].Value.ToString();
                        objctn.MaMau_K = r.Cells["MaMau"].Value.ToString();
                        objctn.SoLuong = Convert.ToUInt16(r.Cells["SoLuong"].Value);
                        objctn.MaTienTe = r.Cells["MaTienTe"].Value.ToString();
                        _db.Insert(objctn);
                    }
                }

                PhieuXuat objpx = new PhieuXuat();
                objpx.LoaiHinh = CurrentSetting.HangHoa.ToString();
                objpx.GhiChu = txtGhiChu.Text;
                objpx.MaKho = cboKhoXuat.SelectedValue.ToString();
                objpx.NgayXuat = PublicFunction.GetStartDate(dtpNgayNhap.Value);
                objpx.NgayTao = DateTime.Now;
                objpx.NVTao = PublicUtility.CurrentUser.UserID;
                objpx.MaPX_K = TaoMaPhieuXuat();
                _db.Insert(objpx);
                _db.ExecuteNonQuery(string.Format("delete from CTXuat where MaPX='{0}' ", objpx.MaPX_K));
                foreach (DataGridViewRow r in grid.Rows)
                {
                    if (!r.IsNewRow)
                    {
                        CTXuat objctx = new CTXuat();
                        objctx.MaPX_K = objpx.MaPX_K;
                        if (r.Cells["GhiChu"].Value != null)
                            objctx.GhiChu = r.Cells["GhiChu"].Value.ToString();
                        objctx.GiaBan = Convert.ToDecimal(r.Cells["GiaNhap"].Value);
                        objctx.MaSP_K = r.Cells["MaSP"].Value.ToString();
                        objctx.SoLuong = Convert.ToUInt16(r.Cells["SoLuong"].Value);
                        objctx.MaTienTe = r.Cells["MaTienTe"].Value.ToString();
                        _db.Insert(objctx);
                    }
                }

                _db.Commit();
                TaoMoiPN();
                PublicFunction.ShowSuccess();
            }
            catch (Exception ex)
            {
                _db.RollBack();
                PublicFunction.ShowError(ex, "bttLuu", this.Name);
            }
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TongCong();
        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TongCong();
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || _isload)
                return;
            if (grid.Columns["GiaNhap"].Index == e.ColumnIndex || grid.Columns["SoLuong"].Index == e.ColumnIndex)
            {
                decimal gianhap = 0;
                decimal soluong = 0;
                try
                {
                    if (grid.Rows[e.RowIndex].Cells["GiaNhap"].Value.ToString() != "")
                    {
                        gianhap = Decimal.Parse(grid.Rows[e.RowIndex].Cells["GiaNhap"].Value.ToString());
                    }
                }
                catch (Exception )
                {
                    grid.CurrentRow.Cells["GiaNhap"].Value = 0;
                }
                try
                {
                    if (grid.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString() != "")
                    {
                        soluong = Decimal.Parse(grid.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString());
                    }
                }
                catch (Exception )
                {
                    grid.Rows[e.RowIndex].Cells["SoLuong"].Value = 1;
                }

                grid.Rows[e.RowIndex].Cells["ThanhTienNhap"].Value = soluong * gianhap;
                TongCong();
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid.Columns["Xoa"].Index && !grid.CurrentRow.IsNewRow)
            {
                if (CurrentSetting.HangHoa == PublicFunction.HangHoa.NguyenLieu)
                { lstMaNL.Remove(grid.CurrentRow.Cells["MaSP"].Value.ToString()); }
                else
                {
                    SanPhamGia spg = new SanPhamGia();
                    spg.MaMau_K = grid.CurrentRow.Cells["MaMau"].Value.ToString();
                    spg.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                    _db.GetObject(ref spg);
                    lstMaSP.Remove(spg);
                }
                grid.Rows.Remove(grid.CurrentRow);
            }
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow.IsNewRow)
            {
                grid.Columns["SoLuong"].ReadOnly = true;
                grid.Columns["GiaNhap"].ReadOnly = true;
                grid.Columns["GhiChu"].ReadOnly = true;
            }else
            {
                grid.Columns["SoLuong"].ReadOnly = false;
                grid.Columns["GiaNhap"].ReadOnly = false;
                grid.Columns["GhiChu"].ReadOnly = false;
            }
        }

       }
}

