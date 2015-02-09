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
using PublicUtility;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmPhieuNhap : DockContent
    {
        DBSql _db = new DBSql(PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        List<SanPhamGia> lstMaSP = new List<SanPhamGia>();
        List<string> lstMaNL = new List<string>();
        private bool _isload = false;
        private string _MaPhieu="";
        public FrmPhieuNhap()
        {
            InitializeComponent();
        }
        private bool KiemTraKhoaTonKho()
        {
            string sql = string.Format(" select Thang from TonKho where Thang='{0}' and Khoa=1 ",
                            dtpNgayNhap.Value.ToString("yyyyMM"));
            DataTable dt = _db.FillDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                PublicFunction.ShowWarning(string.Format("Tồn kho tháng [{0}] đã khóa.",
                                        dtpNgayNhap.Value.ToString("yyyyMM")));
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LuuPhieuNhap()
        {
            if (cboKho.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Kho không được để trống.");
                cboKho.Focus();
                return;
            }
            if (cboNCC.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Nhà cung cấp không được để trống.");
                cboNCC.Focus();
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
                return;
            }
            try
            {
                _db.BeginTransaction();
                PhieuNhap objpn = new PhieuNhap();
                objpn.LoaiHinh = CurrentSetting.HangHoa.ToString();
                objpn.GhiChu = txtGhiChu.Text;
                objpn.MaKho = cboKho.SelectedValue.ToString();
                objpn.MaNCC = cboNCC.SelectedValue.ToString();
                objpn.NgayNhap = PublicFunction.GetStartDate(dtpNgayNhap.Value);
                objpn.NgayTao = DateTime.Now;
                objpn.NVTao = PublicUtility.CurrentUser.UserID;
                if (txtMaPN.Text == "")
                {
                    objpn.MaPN_K = TaoMaPhieuNhap();
                    _db.Insert(objpn);
                }
                else
                {
                    objpn.MaPN_K = txtMaPN.Text;
                    _db.Update(objpn);
                }
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
                        if (r.Cells["MaMau"].Value != null)
                        {
                            objctn.MaMau_K = r.Cells["MaMau"].Value.ToString();
                        }
                        else
                        {
                            objctn.MaMau_K = "";
                        }
                        objctn.SoLuong = Convert.ToUInt16(r.Cells["SoLuong"].Value);
                        objctn.MaTienTe = r.Cells["MaTienTe"].Value.ToString();
                        _db.Insert(objctn);
                    }
                }
                _MaPhieu = objpn.MaPN_K;
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
        private void InPhieu(string ID)
        {
            FrmPrint frm = new FrmPrint();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Phieu", "Nhap");
            para[1] = new SqlParameter("@MaPhieu", ID);
            string sql = "[sp_BaoCaoNhapXuatNL]";
            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            {
                sql = "[sp_BaoCaoNhapXuatSP]";
                frm.rptViewer.LocalReport.ReportPath =Application.StartupPath+ "\\Report\\rptPhieuNhapSP.rdlc";
                DataTable dtPN = _db.ExecuteStoreProcedureTB(sql,para);
                dtPN.TableName = "PhieuNhapSP";
                dtPN.WriteXmlSchema("PhieuNhapSP.xsd");
                frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("PhieuNhapSP", dtPN));
            }
            else
            {
                frm.rptViewer.LocalReport.ReportPath = Application.StartupPath + "\\Report\\rptPhieuNhapSP.rdlc";
                DataTable dtPN = _db.ExecuteStoreProcedureTB(sql,para);
                dtPN.TableName = "PhieuNhapNL";
                dtPN.WriteXmlSchema("PhieuNhapNL.xsd");
                frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("PhieuNhapSP", dtPN));
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
        private void LoadPhieuNhap(string _id)
        {
            lstMaSP.Clear();
            grid.Rows.Clear();
            int index = 0;
            PhieuNhap obj = new PhieuNhap();
            obj.MaPN_K = _id;
            _db.GetObject(ref obj);
            txtGhiChu.Text = obj.GhiChu;
            txtMaPN.Text = _id;
            cboKho.SelectedValue = obj.MaKho;
            cboNCC.SelectedValue = obj.MaNCC;
            dtpNgayNhap.Value = obj.NgayNhap;
            _isload = true;
            CTNhap[] cobj = _db.GetObjects<CTNhap>(string.Format("select * from CTNhap where MaPN='{0}' ", txtMaPN.Text));
            foreach (CTNhap c in cobj)
            {
                grid.Rows.Add();
                index = grid.Rows.Count - 1;
                if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
                {
                    grid.Columns["MaMau"].Visible = true;
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
                    grid.Rows[index].Cells["GiaNhap"].Value = c.GiaNhap;
                    grid.Rows[index].Cells["ThanhTienNhap"].Value = c.GiaNhap * c.SoLuong;
                    grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];
                    grid.Rows[index].Cells["MaTienTe"].Value = c.MaTienTe;
                    SanPhamGia spg = new SanPhamGia();
                    spg.MaMau_K = c.MaMau_K;
                    spg.MaSP_K = c.MaSP_K;
                    _db.GetObject(ref spg);
                    lstMaSP.Add(spg);
                    lblMaTienTe.Text = c.MaTienTe;
                }
                else
                {
                    grid.Columns["MaMau"].Visible = false;
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
                    grid.Rows[index].Cells["GiaNhap"].Value = c.GiaNhap;
                    grid.Rows[index].Cells["ThanhTienNhap"].Value = c.GiaNhap * c.SoLuong;
                    grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];
                    grid.Rows[index].Cells["MaTienTe"].Value = c.MaTienTe;
                    lstMaNL.Add(c.MaSP_K);
                    lblMaTienTe.Text = c.MaTienTe;
                }
             
            }
            _isload = false;
            TongCong();
        }
        private void TaoMoiPN()
        {
            txtGhiChu.Text = "";
            txtMaPN.Text = "";
            txtTongSL.Text = "";
            txtTongTien.Text = "";
            lstMaSP.Clear();
            grid.Rows.Clear();
            grid.Focus();
            bttXoa.Enabled = false;
            lblMaTienTe.Text = CurrentSetting.MaTienTe;
            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            {
                grid.Columns["MaMau"].Visible = true;
            }else
            {
                grid.Columns["MaMau"].Visible = false;
            }
        }
        private string TaoMaPhieuNhap()
        {
            string mapn = "";
            object max = _db.ExecuteScalar(string.Format("select max(MaPN) from PhieuNhap where MaPN like '{0}%' ",
                                           "PN" + dtpNgayNhap.Value.ToString("yyMMdd")));
            if (max is DBNull)
            {
                mapn = "PN" + dtpNgayNhap.Value.ToString("yyMMdd") + "001";
            }
            else
            {
                mapn = (Convert.ToInt16(max.ToString().Substring(8, 3)) + 1).ToString().PadLeft(3, '0');
                mapn = "PN" + dtpNgayNhap.Value.ToString("yyMMdd") + mapn;
            }
            return mapn;
        }
        private void LoadKho()
        {
            string sql = string.Format("select Makho, tenkho from Kho where Loai='{0}' ",
                               CurrentSetting.HangHoa.ToString());
            cboKho.DataSource = _db.FillDataTable(sql);
            cboKho.ValueMember = "MaKho";
            cboKho.DisplayMember = "TenKho";
            
            string sqlNCC = string.Format("select MaNCC, tenNCC from NhaCungCap where MaNCC<>'0000' order by TenNCC ");
            cboNCC.DataSource = _db.FillDataTable(sqlNCC);
            cboNCC.ValueMember = "MaNCC";
            cboNCC.DisplayMember = "TenNCC";
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
        private void FrmPhieuNhap_Shown(object sender, EventArgs e)
        {
            grid.Focus();
            LoadKho();
            bttXoa.Enabled = false;
            lblMaTienTe.Text = CurrentSetting.MaTienTe;
            TaoMoiPN();
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
                //Tim kiem hang hoa
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
                                grid.CurrentCell = grid.Rows[index].Cells["MaSP"];
                                lstMaSP.Add(sp);
                            }
                            else
                            {
                                foreach (DataGridViewRow r in grid.Rows)
                                {
                                    if (!r.IsNewRow)
                                    {
                                        if (r.Cells["MaSP"].Value.ToString() == sp.MaSP_K && r.Cells["MaMau"].Value.ToString()==sp.MaMau_K)
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
                else
                {
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
                                grid.Rows[index].Cells["GiaNhap"].Value = obj.GiaNhap;
                                grid.Rows[index].Cells["ThanhTienNhap"].Value = obj.GiaNhap;
                                grid.Rows[index].Cells["MaTienTe"].Value = obj.MaTienTe;
                                grid.CurrentCell = grid.Rows[index].Cells["MaSP"];
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
                    grid.Rows[e.RowIndex].Cells["GiaNhap"].Value = 0;
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

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TongCong();
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TongCong();
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            LuuPhieuNhap();
            
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow.IsNewRow)
            {
                grid.Columns["SoLuong"].ReadOnly = true;
                grid.Columns["GiaNhap"].ReadOnly = true;
                grid.Columns["GhiChu"].ReadOnly = true;
            }
            else
            {
                grid.Columns["SoLuong"].ReadOnly = false;
                grid.Columns["GiaNhap"].ReadOnly = false;
                grid.Columns["GhiChu"].ReadOnly = false;
            }

        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            if (KiemTraKhoaTonKho())
            {
                return;
            }
            if (txtMaPN.Text != "")
            {
                if (PublicFunction.ShowQuestion("Bạn muốn xóa phiếu nhập này ?") == DialogResult.Yes)
                {
                    PhieuNhap obj = new PhieuNhap();
                    obj.MaPN_K = txtMaPN.Text;
                    _db.Delete(obj);
                    TaoMoiPN();
                    PublicFunction.ShowSuccess();
                }
            }
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimKiemNX frm = new FrmTimKiemNX();
            frm._isNhap = true;
            frm._timkiem = true;
            frm.ShowDialog();
            if (frm._ID != "")
            {
                bttXoa.Enabled = true;
                _MaPhieu = frm._ID;
                LoadPhieuNhap(frm._ID);
            }
        }

        private void bttLuuVaIn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            LuuPhieuNhap();
            if (_MaPhieu!= "")
                InPhieu(_MaPhieu);
            _MaPhieu = "";
            Cursor = Cursors.Default;

        }


    }
}

