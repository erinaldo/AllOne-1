using AllOne.NhapXuatTon;
using AllOne.Tien;
using CommonDB;
using PublicUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Reporting.WinForms;
using Microsoft.Office;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmBaoGia : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        List<string> lstMaSP = new List<string>();
        public string _masp;
        private bool _isload = false;
        private bool _InPhieu = false;
        private System.Data.DataTable _dtBaoGia;
        public FrmBaoGia()
        {
            InitializeComponent();
        }
  
        private void InPhieu(string ID)
        {
            FrmPrint frm = new FrmPrint();
            frm.rptViewer.LocalReport.ReportPath = System.Windows.Forms.Application.StartupPath + "\\Report\\rptBaoGia.rdlc";

            _dtBaoGia.TableName = "BaoGia";
            _dtBaoGia.WriteXmlSchema("BaoGia.xsd");
            frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("BaoGia", _dtBaoGia));

            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("NhanVien", CurrentUser.FullName));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("TenCongTy", CurrentSetting.TenCongTy));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("DiaChi", CurrentSetting.DiaChi));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("DienThoai", CurrentSetting.DienThoai));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("MST", CurrentSetting.MST));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("Fax", CurrentSetting.Fax));

            KhachHang objkh = new KhachHang();
            objkh.MaKH_K = cboKH.SelectedValue.ToString();
            _db.GetObject(ref objkh);
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("TenKH", objkh.TenKH));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("DiaChiKH", objkh.DiaChi));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("DTKH",objkh.DienThoai1));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("FaxKH", objkh.Fax));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("NguoiNhan", objkh.NguoiDaiDien1));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("HP", ""));

            frm.rptViewer.RefreshReport();
            frm.rptViewer.ZoomMode = ZoomMode.PageWidth;
            frm.Show();
        }
        private void LoadBaoGia(string _id)
        {
            lstMaSP.Clear();
            grid.Rows.Clear();
            int index = 0;

            _isload = true;
            _dtBaoGia = _db.FillDataTable(string.Format(" select bg.MaKH, bg.MaBaoGia,bg.MaSP,bg.TenSP,bg.MaDVT,dvt.TenDVT, bg.SoLuong,bg.GiaBan,bg.SoLuong*bg.GiaBan as ThanhTien,bg.GhiChu,bg.NgayBaoGia"+
                                                        " from BaoGia bg inner join DonViTinh dvt on dvt.MaDVT=bg.MaDVT where bg.MaBaoGia='{0}' ", _id));
            foreach (DataRow c in _dtBaoGia.Rows)
            {
                cboKH.SelectedValue = c["MaKH"].ToString();
                txtMaPX.Text = c["MaBaoGia"].ToString();
                grid.Rows.Add();
                index = grid.Rows.Count - 1;
                grid.Rows[index].Cells["SoLuong"].Value = c["SoLuong"];
                grid.Rows[index].Cells["MaSP"].Value = c["MaSP"];
                grid.Rows[index].Cells["TenSP"].Value = c["TenSP"];
                grid.Rows[index].Cells["MaDVT"].Value = c["MaDVT"];
                grid.Rows[index].Cells["TenDVT"].Value = c["TenDVT"];
                grid.Rows[index].Cells["GiaBan"].Value = c["GiaBan"];
                grid.Rows[index].Cells["ThanhTien"].Value =Convert.ToDecimal( c["GiaBan"]) *Convert.ToDecimal( c["SoLuong"]);
                grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];

               lstMaSP.Add(c["MaSP"].ToString());
            }
            _isload = false;
            TongCong();
        }
        private void TaoMoiBG()
        {
            txtMaPX.Text = "";
            txtTongSL.Text = "";
            txtTongTien.Text = "";
            lstMaSP.Clear();
            grid.Rows.Clear();
            grid.Focus();
            //grid.CurrentCell = grid.Rows[0].Cells["SoLuong"];
            bttXoa.Enabled = false;
        }
        private string TaoMaBG()
        {
            string mapn = "";
            object max = _db.ExecuteScalar(string.Format("select max(MaBaoGia) from BaoGia where MaBaoGia like '{0}%' ",
                                           "BG" + dtpThang.Value.ToString("yyMMdd")));
            if (max is DBNull)
            {
                mapn = "BG" + dtpThang.Value.ToString("yyMMdd") + "01";
            }
            else
            {
                mapn = (Convert.ToInt16(max.ToString().Substring(8, 2)) + 1).ToString().PadLeft(2, '0');
                mapn = "BG" + dtpThang.Value.ToString("yyMMdd") + mapn;
            }
            return mapn;
        }
        private void LoadKho()
        {
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
                if (!r.IsNewRow && r.Cells["ThanhTien"].Value != null)
                {
                    if (r.Cells["ThanhTien"].Value.ToString() != "")
                        tongthanhtien += Convert.ToDecimal(r.Cells["ThanhTien"].Value);
                }
            }
            txtTongSL.Text = tongsoluong.ToString("N0");
            txtTongTien.Text = tongthanhtien.ToString("N3");
        }

        private void FrmBaoGia_Shown(object sender, EventArgs e)
        {
            grid.Focus();
            LoadKho();
            bttXoa.Enabled = false;
            lblMaTienTe.Text = CurrentSetting.MaTienTe;
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (grid.CurrentCell.ColumnIndex == grid.Columns["GhiChu"].Index)
                    grid.CurrentCell.Value = "";
            }
            if (e.KeyCode == Keys.Enter && e.Control)
            {
                //Tim kiem hang hoa
                FrmTimSanPham frm = new FrmTimSanPham();
                frm.ShowDialog();
                if (frm._list != null)
                {
                    foreach (SanPhamGia sp in frm._list)
                    {
                        if (!lstMaSP.Contains(sp.MaSP_K))
                        {
                            grid.Rows.Add();
                            int index = grid.Rows.Count - 1;
                            SanPham obj = new SanPham();                
                            obj.MaSP_K = sp.MaSP_K;
                            _db.GetObject(ref obj);
                            DonViTinh dvt = new DonViTinh();
                            dvt.MaDVT_K = obj.MaDVT;
                            _db.GetObject(ref dvt);
                            grid.Rows[index].Cells["SoLuong"].Value = 1;
                            grid.Rows[index].Cells["MaSP"].Value = obj.MaSP_K;
                            grid.Rows[index].Cells["TenSP"].Value = obj.TenSP;
                            grid.Rows[index].Cells["MaDVT"].Value = obj.MaDVT;
                            grid.Rows[index].Cells["TenDVT"].Value = dvt.TenDVT;
                            grid.Rows[index].Cells["GiaBan"].Value = obj.GiaBan;
                            grid.Rows[index].Cells["ThanhTien"].Value = obj.GiaBan;
                            
                            grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];
                            lstMaSP.Add(sp.MaSP_K);
                        }
                    }
                }
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid.Columns["Xoa"].Index && !grid.CurrentRow.IsNewRow)
            {
                lstMaSP.Remove(grid.CurrentRow.Cells["MaSP"].Value.ToString());
                grid.Rows.Remove(grid.CurrentRow);
            }
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            string maBG = "";
            if (cboKH.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Bạn chưa chọn khách hàng để báo giá.");
                cboKH.Focus();
                return;
            }
            if (grid.Rows.Count == 0)
            {
                PublicFunction.ShowWarning("Bạn chưa nhập sản phẩm.");
                grid.Focus();
                return;
            }
            try
            {
                _db.BeginTransaction();              
                _db.ExecuteNonQuery(string.Format("delete from BaoGia where MaBaoGia='{0}' ", txtMaPX.Text));
              
                if (txtMaPX.Text == "")
                { maBG = TaoMaBG(); }
                else
                { maBG = txtMaPX.Text; }
                foreach (DataGridViewRow r in grid.Rows)
                {
                    if (!r.IsNewRow)
                    {
                        BaoGia bg = new BaoGia();
                        bg.MaBaoGia_K = maBG;
                        bg.MaKH = cboKH.SelectedValue.ToString();
                        if (r.Cells["GhiChu"].Value != null)
                            bg.GhiChu = r.Cells["GhiChu"].Value.ToString();
                        bg.GiaBan = Convert.ToDecimal(r.Cells["GiaBan"].Value);
                        bg.MaSP_K = r.Cells["MaSP"].Value.ToString();
                        bg.TenSP = r.Cells["TenSP"].Value.ToString();
                        bg.MaDVT = r.Cells["MaDVT"].Value.ToString();
                        bg.SoLuong = Convert.ToUInt16(r.Cells["SoLuong"].Value);
                        bg.MaTienTe = CurrentSetting.MaTienTe;
                        bg.NgayBaoGia = PublicFunction.GetStartDate(dtpThang.Value);
                        _db.Insert(bg);
                    }
                }
              
             
               _db.Commit();
               PublicFunction.ShowSuccess();
            }
            catch (Exception ex)
            {
                _db.RollBack();
                PublicFunction.ShowError(ex, "bttLuu", this.Name);
                return;
            }
            if (_InPhieu)
            {
                InPhieu(maBG);
            }
            TaoMoiBG();
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimKiemBG frm = new FrmTimKiemBG();
            frm._isNhap = false;
            frm._timkiem = true;
            frm.ShowDialog();
            if (frm._ID != "")
            {
                bttXoa.Enabled = true;
                LoadBaoGia(frm._ID);
            }
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

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPX.Text != "")
            {
                if (PublicFunction.ShowQuestion("Bạn muốn xóa phiếu nhập này ?") == DialogResult.Yes)
                {
                    string sqlxoa = string.Format("delete from BaoGia where MaBaoGia='{0}' ", txtMaPX.Text);
                    _db.ExecuteNonQuery(sqlxoa);
                    TaoMoiBG();
                    PublicFunction.ShowSuccess();
                }
            }
        }

        private void bttLuuVaIn_Click(object sender, EventArgs e)
        {
            if (cboKH.SelectedIndex == -1)
            {
                PublicFunction.ShowWarning("Khách hàng không được để trống.");
                cboKH.Focus();
                return;
            }
            Cursor = Cursors.AppStarting;
            if (txtMaPX.Text == "")
            {
                _InPhieu = true;
                bttLuu.PerformClick();
                _InPhieu = false;
            }else
            {
                InPhieu(txtMaPX.Text);
            }
            Cursor = Cursors.Default;
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

                grid.Rows[e.RowIndex].Cells["ThanhTien"].Value = soluong * gianhap;
                TongCong();
            }
        }

        private void bttExport_Click(object sender, EventArgs e)
        {
            //ExportExcel();
        }

    }
}
