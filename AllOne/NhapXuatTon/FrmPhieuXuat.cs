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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using PublicUtility;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmPhieuXuat : DockContent
    {
        
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        List<SanPhamGia> lstMaSP = new List<SanPhamGia>();
        List<string> lstMaNL = new List<string>();
        public string _masp;
        private bool _isload =false;
        private string _MaPhieu="";
        public FrmPhieuXuat()
        {
            InitializeComponent();
        }
        private bool KiemTraKhoaTonKho()
        {
            string sql = string.Format(" select Thang from TonKho where Thang='{0}' and Khoa=1 ",
                            dtpNgayXuat.Value.ToString("yyyyMM"));
            DataTable dt = _db.FillDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                PublicFunction.ShowWarning(string.Format("Tồn kho tháng [{0}] đã khóa.",
                                        dtpNgayXuat.Value.ToString("yyyyMM")));
                return true;
            }
            else
            {
                return false;
            }
        }
        private void InPhieu(string ID)
        {
            FrmPrint frm = new FrmPrint();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Phieu", "Xuat");
            para[1] = new SqlParameter("@MaPhieu", ID);
            string sql = "[sp_BaoCaoNhapXuatNL]";
            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            {
                sql = "[sp_BaoCaoNhapXuatSP]";
                frm.rptViewer.LocalReport.ReportPath = Application.StartupPath + "\\Report\\rptPhieuXuatSP.rdlc";
                DataTable dtPN = _db.ExecuteStoreProcedureTB(sql, para);
                dtPN.TableName = "PhieuXuatSP";
                dtPN.WriteXmlSchema("PhieuXuatSP.xsd");
                frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("PhieuXuatSP", dtPN));
            }
            else
            {
                frm.rptViewer.LocalReport.ReportPath = Application.StartupPath + "\\Report\\rptPhieuXuatSP.rdlc";
                DataTable dtPN = _db.ExecuteStoreProcedureTB(sql, para);
                dtPN.TableName = "PhieuNhapNL";
                dtPN.WriteXmlSchema("PhieuNhapNL.xsd");
                frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("PhieuXuatSP", dtPN));
            }

            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("NhanVien", CurrentUser.FullName));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("TenCongTy", CurrentSetting.TenCongTy));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("DiaChi", CurrentSetting.DiaChi));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("DienThoai", CurrentSetting.DienThoai));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("MST", CurrentSetting.MST));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("Fax", CurrentSetting.Fax));
            frm.rptViewer.RefreshReport();
            frm.rptViewer.ZoomMode = ZoomMode.PageWidth;
            // frm.rptViewer
            frm.Show();
        }
        private void LoadPhieuXuat(string _id)
        {
            lstMaSP.Clear();
            grid.Rows.Clear();
            int index = 0;
            PhieuXuat obj = new PhieuXuat();
            obj.MaPX_K = _id;
            _db.GetObject(ref obj);
            txtGhiChu.Text = obj.GhiChu;
            txtMaPX.Text = _id;
            cboKho.SelectedValue = obj.MaKho;
            dtpNgayXuat.Value = obj.NgayXuat;
            cboKH.SelectedValue = obj.MaKH;
            _isload = true;
            CTXuat[] cobj = _db.GetObjects<CTXuat>(string.Format("select * from CTXuat where MaPX='{0}' ", txtMaPX.Text));
            foreach (CTXuat c in cobj)
            {      
                grid.Rows.Add();
                index = grid.Rows.Count - 1; 
                if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
                {
                    SanPham sp = new SanPham();
                    sp.MaSP_K = c.MaSP_K;
                    _db.GetObject(ref sp);
                    DonViTinh dvt = new DonViTinh();
                    dvt.MaDVT_K = sp.MaDVT;
                    _db.GetObject(ref dvt);
                    grid.Rows[index].Cells["SoLuong"].Value = c.SoLuong;
                    grid.Rows[index].Cells["MaSP"].Value = c.MaSP_K;
                    grid.Rows[index].Cells["MaMau"].Value = c.MaMau_K;
                    grid.Rows[index].Cells["TenSP"].Value = sp.TenSP;
                    grid.Rows[index].Cells["TenDVT"].Value = dvt.TenDVT;
                    grid.Rows[index].Cells["GiaBan"].Value = c.GiaBan;
                    grid.Rows[index].Cells["ThanhTienBan"].Value = c.GiaBan * c.SoLuong;
                    grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];
                    grid.Rows[index].Cells["MaTienTe"].Value = c.MaTienTe;
                    lblMaTienTe.Text = c.MaTienTe;

                    SanPhamGia spg = new SanPhamGia();
                    spg.MaMau_K = c.MaMau_K;
                    spg.MaSP_K = c.MaSP_K;
                    _db.GetObject(ref spg);
                    lstMaSP.Add(spg);
                }else
                {
                    NguyenLieu sp = new NguyenLieu();
                    sp.MaNL_K = c.MaSP_K;
                    _db.GetObject(ref sp);
                    DonViTinh dvt = new DonViTinh();
                    dvt.MaDVT_K = sp.MaDVT;
                    _db.GetObject(ref dvt);
                    grid.Rows[index].Cells["SoLuong"].Value = c.SoLuong;
                    grid.Rows[index].Cells["MaSP"].Value = c.MaSP_K;
                    grid.Rows[index].Cells["TenSP"].Value = sp.TenNL;
                    grid.Rows[index].Cells["TenDVT"].Value = dvt.TenDVT;
                    grid.Rows[index].Cells["GiaBan"].Value = c.GiaBan;
                    grid.Rows[index].Cells["ThanhTienBan"].Value = c.GiaBan * c.SoLuong;
                    grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];
                    grid.Rows[index].Cells["MaTienTe"].Value = c.MaTienTe;
                    lblMaTienTe.Text = c.MaTienTe;
                    lstMaNL.Add(c.MaSP_K);
                }
              
            }
            _isload = false;
            TongCong();
        }
        private void TaoMoiPX()
        {
            txtGhiChu.Text = "";
            txtMaPX.Text = "";
            txtTongSL.Text = "";
            txtTongTien.Text = "";
            lstMaSP.Clear();
            grid.Rows.Clear();
            grid.Focus();
            bttXoa.Enabled = false;
            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            {
                grid.Columns["MaMau"].Visible = true;
            }
            else
            {
                grid.Columns["MaMau"].Visible = false;
            }
        }
        private string TaoMaPhieuXuat()
        {
            string mapn = "";
            object max = _db.ExecuteScalar(string.Format("select max(MaPX) from PhieuXuat where MaPX like '{0}%' ",
                                           "PX" + dtpNgayXuat.Value.ToString("yyMMdd")));
            if (max is DBNull)
            {
                mapn = "PX" + dtpNgayXuat.Value.ToString("yyMMdd") + "001";
            }
            else
            {
                mapn = (Convert.ToInt16(max.ToString().Substring(8, 3)) + 1).ToString().PadLeft(3, '0');
                mapn = "PX" + dtpNgayXuat.Value.ToString("yyMMdd") + mapn;
            }
            return mapn;
        }

        private void LuuPhieuXuat()
        {
            if (cboKho.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Kho không được để trống.");
                cboKho.Focus();
                return;
            }
            if (cboKH.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Khách hàng không được để trống.");
                cboKH.Focus();
                return;
            }
            if (grid.Rows.Count == 0)
            {
                PublicFunction.ShowWarning("Bạn chưa nhập sản phẩm.");
                grid.Focus();
                return;
            }
            if (KiemTraKhoaTonKho())
            {
                return;
            }
            try
            {
                _db.BeginTransaction();
                PhieuXuat objpx = new PhieuXuat();
                objpx.LoaiHinh = CurrentSetting.HangHoa.ToString();
                objpx.GhiChu = txtGhiChu.Text;
                objpx.MaKho = cboKho.SelectedValue.ToString();
                objpx.NgayXuat = PublicFunction.GetStartDate(dtpNgayXuat.Value);
                objpx.NgayTao = DateTime.Now;
                objpx.NVTao = PublicUtility.CurrentUser.UserID;
                objpx.MaKH = cboKH.SelectedValue.ToString();
                if (txtMaPX.Text == "")
                {
                    objpx.MaPX_K = TaoMaPhieuXuat();
                    _db.Insert(objpx);
                }
                else
                {
                    objpx.MaPX_K = txtMaPX.Text;
                    _db.Update(objpx);
                }
                _db.ExecuteNonQuery(string.Format("delete from CTXuat where MaPX='{0}' ", objpx.MaPX_K));
                foreach (DataGridViewRow r in grid.Rows)
                {
                    if (!r.IsNewRow)
                    {
                        CTXuat objctx = new CTXuat();
                        objctx.MaPX_K = objpx.MaPX_K;
                        if (r.Cells["GhiChu"].Value != null)
                            objctx.GhiChu = r.Cells["GhiChu"].Value.ToString();
                        objctx.GiaBan = Convert.ToDecimal(r.Cells["GiaBan"].Value);
                        objctx.MaSP_K = r.Cells["MaSP"].Value.ToString();
                        if (r.Cells["MaMau"].Value != null)
                        {
                            objctx.MaMau_K = r.Cells["MaMau"].Value.ToString();
                        }
                        else
                        {
                            objctx.MaMau_K = "";
                        }
                        objctx.SoLuong = Convert.ToUInt16(r.Cells["SoLuong"].Value);
                        objctx.MaTienTe = r.Cells["MaTienTe"].Value.ToString();
                        _db.Insert(objctx);
                    }
                }
              _MaPhieu = objpx.MaPX_K;
                TaoMoiPX();
                _db.Commit();
                PublicFunction.ShowSuccess();

            }
            catch (Exception ex)
            {
                _db.RollBack();
                PublicFunction.ShowError(ex, "bttLuu", this.Name);
            }
        }

        private void LoadKho()
        {
            string sql = string.Format("select Makho, tenkho from Kho where Loai='{0}' order by tenkho ",
                               CurrentSetting.HangHoa.ToString());
            cboKho.DataSource = _db.FillDataTable(sql);
            cboKho.ValueMember = "MaKho";
            cboKho.DisplayMember = "TenKho";

            string sqlKH = string.Format("select MaKH, TenKH from KhachHang order by TenKH ");
            cboKH.DataSource = _db.FillDataTable(sqlKH);
            cboKH.ValueMember = "MaKH";
            cboKH.DisplayMember = "TenKH";
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
                if (!r.IsNewRow && r.Cells["ThanhTienBan"].Value != null)
                {
                    if (r.Cells["ThanhTienBan"].Value.ToString() != "")
                        tongthanhtien += Convert.ToDecimal(r.Cells["ThanhTienBan"].Value);
                }
            }
            txtTongSL.Text = tongsoluong.ToString("N0");
            txtTongTien.Text = tongthanhtien.ToString("N3");
        }

        private void FrmPhieuNhap_Shown(object sender, EventArgs e)
        {
            grid.Focus();
            LoadKho();
            bttXoa.Enabled = false;
            lblMaTienTe.Text = CurrentSetting.MaTienTe;
            TaoMoiPX();
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
                    //Tim kiem hang hoa
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
                                grid.Rows[index].Cells["GiaBan"].Value = obj.GiaBan * mau.Price;
                                grid.Rows[index].Cells["ThanhTienBan"].Value = obj.GiaBan * mau.Price;
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
                                            r.Cells["ThanhTienBan"].Value = Convert.ToInt16(r.Cells["SoLuong"].Value) * Convert.ToDecimal(r.Cells["GiaBan"].Value);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    //Tim kiem hang hoa
                    FrmTimNguyenLieu frm = new FrmTimNguyenLieu();
                    frm.ShowDialog();
                    if (frm._list != null)
                    {
                        foreach (string nl in frm._list)
                        {
                            if (!lstMaNL.Contains(nl))
                            {
                                grid.Rows.Add();
                                int index = grid.Rows.Count - 1;
                                NguyenLieu obj = new NguyenLieu();
                                obj.MaNL_K = nl;
                                _db.GetObject(ref obj);
                                DonViTinh dvt = new DonViTinh();
                                dvt.MaDVT_K = obj.MaDVT;
                                _db.GetObject(ref dvt);
                                grid.Rows[index].Cells["SoLuong"].Value = 1;
                                grid.Rows[index].Cells["MaSP"].Value = obj.MaNL_K;
                                grid.Rows[index].Cells["TenSP"].Value = obj.TenNL;
                                grid.Rows[index].Cells["TenDVT"].Value = dvt.TenDVT;
                                grid.Rows[index].Cells["MaTienTe"].Value = CurrentSetting.MaTienTe;
                                grid.Rows[index].Cells["GiaBan"].Value = obj.GiaBan;
                                grid.Rows[index].Cells["ThanhTienBan"].Value = obj.GiaBan;                              

                                grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];
                                lstMaNL.Add(obj.MaNL_K);
                            }
                            else
                            {
                                foreach (DataGridViewRow r in grid.Rows)
                                {
                                    if (!r.IsNewRow)
                                    {
                                        if (r.Cells["MaSP"].Value.ToString() == nl)
                                        {
                                            r.Cells["SoLuong"].Value = Convert.ToInt16(r.Cells["SoLuong"].Value) + 1;
                                            r.Cells["ThanhTienBan"].Value = Convert.ToInt16(r.Cells["SoLuong"].Value) * Convert.ToDecimal(r.Cells["GiaBan"].Value);
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

        private void bttLuu_Click(object sender, EventArgs e)
        {
            LuuPhieuXuat();
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimKiemNX frm = new FrmTimKiemNX();
            frm._isNhap = false;
            frm._timkiem = true;
            frm.ShowDialog();
            if (frm._ID != "")
            {
                bttXoa.Enabled = true;
                _MaPhieu = frm._ID;
                LoadPhieuXuat(frm._ID);
            }
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || _isload)
                return;
            if (grid.Columns["GiaBan"].Index == e.ColumnIndex || grid.Columns["SoLuong"].Index == e.ColumnIndex)
            {
                decimal gianhap = 0;
                decimal soluong = 0;
                try
                {
                    if (grid.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString() != "")
                    {
                        gianhap = Decimal.Parse(grid.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString());
                    }
                }
                catch (Exception )
                {
                    grid.Rows[e.RowIndex].Cells["GiaBan"].Value = 0;
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

                grid.Rows[e.RowIndex].Cells["ThanhTienBan"].Value = soluong * gianhap;
                TongCong();
            }
        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TongCong();
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TongCong();
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow.IsNewRow)
            {
                grid.Columns["SoLuong"].ReadOnly = true;
                grid.Columns["GiaBan"].ReadOnly = true;
                grid.Columns["GhiChu"].ReadOnly = true;
            }
            else
            {
                grid.Columns["SoLuong"].ReadOnly = false;
                grid.Columns["GiaBan"].ReadOnly = false;
                grid.Columns["GhiChu"].ReadOnly = false;
            }
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            if (KiemTraKhoaTonKho())
            {
                return;
            }
            if (txtMaPX.Text != "")
            {
                if (PublicFunction.ShowQuestion("Bạn muốn xóa phiếu nhập này ?") == DialogResult.Yes)
                {
                    PhieuXuat obj = new PhieuXuat();
                    obj.MaPX_K = txtMaPX.Text;
                    _db.Delete(obj);                    
                    TaoMoiPX();
                    PublicFunction.ShowSuccess();
                }
            }
        }

        private void bttLuuVaIn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            LuuPhieuXuat();            
            if (_MaPhieu != "")
                InPhieu(_MaPhieu);
            _MaPhieu = "";
            Cursor = Cursors.Default;
        }
    }
}
