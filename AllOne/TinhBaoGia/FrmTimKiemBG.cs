using CommonDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using PublicUtility;

namespace AllOne.Tien
{
    public partial class FrmTimKiemBG : Form
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public string _ID = "";
        public bool _timkiem = false;
        public bool _isNhap = true;
        DataTable _dtBCNhap;
        public FrmTimKiemBG()
        {
            InitializeComponent();
        }
        private void InPhieu()
        {
            FrmPrint frm = new FrmPrint();
            frm.rptViewer.LocalReport.ReportPath = Application.StartupPath + "\\Report\\rptBaoGia.rdlc"; 
                
            _dtBCNhap.TableName = "BaoGia";
            _dtBCNhap.WriteXmlSchema("BaoGia.xsd");
            frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("BaoGia", _dtBCNhap));

            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("NhanVien", CurrentUser.FullName));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("TenCongTy", CurrentSetting.TenCongTy));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("DiaChi", CurrentSetting.DiaChi));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("DienThoai", CurrentSetting.DienThoai));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("MST", CurrentSetting.MST));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("Fax", CurrentSetting.Fax));
            frm.rptViewer.RefreshReport();
            frm.rptViewer.ZoomMode = ZoomMode.PageWidth;
            frm.Show();
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

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            string sql = string.Format(" select bg.MaBaoGia,kh.TenKH,bg.MaSP,bg.TenSP,dvt.TenDVT,bg.SoLuong,bg.GiaBan,bg.SoLuong*bg.GiaBan as ThanhTien,bg.GhiChu,bg.NgayBaoGia" +
                                       " from BaoGia bg inner join KhachHang kh on kh.MaKH=bg.MaKH "+
                                       " left join DonViTinh dvt on dvt.MaDVT=bg.MaDVT  "+
                                       " where NgayBaoGia between @StartDate and @EndDate");
            SqlParameter []para=new SqlParameter[2];
            para[0] = new SqlParameter("@StartDate", PublicFunction.GetStartDate(dtpStartDate.Value));
            para[1] = new SqlParameter("@EndDate", PublicFunction.GetStartDate(dtpEndDate.Value));
            BindingSource bdsource = new BindingSource();
            _dtBCNhap= _db.FillDataTable(sql,para);
            bdsource.DataSource = _dtBCNhap;
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }

        private void frmTimKiemPhieuNhapXuat_Shown(object sender, EventArgs e)
        {
            bttTimKiem.PerformClick();           
        }

        private void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TongCong();
        }

        private void txtMaPN_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource !=null)
            {
                if (txtMaPN.Text!="")
                {
                    bdn.BindingSource.Filter = string.Format(" MaBaoGia like '%{0}%' ",txtMaPN.Text);
                }else
                {
                    bdn.BindingSource.Filter = "";
                }
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                _ID = grid.CurrentRow.Cells["MaBaoGia"].Value.ToString();
                Close();
            }                
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttInBC_Click(object sender, EventArgs e)
        {
            if (grid.RowCount>0)
            {
                InPhieu();
            }
        }

        private void rdoPhieuXuat_CheckedChanged(object sender, EventArgs e)
        {
            bttTimKiem.PerformClick();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource != null)
            {
                if (txtTenKH.Text != "")
                {
                    bdn.BindingSource.Filter = string.Format(" TenKH like '%{0}%' ", txtTenKH.Text);
                }
                else
                {
                    bdn.BindingSource.Filter = "";
                }
            }
        }
    }
}
