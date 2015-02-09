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
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne.NhapXuatTon
{
    public partial class FrmTimKiemNX : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public string _ID = "";
        public bool _timkiem = false;
        public bool _isNhap = true;
        DataTable _dtBCNhap;
        public FrmTimKiemNX()
        {
            InitializeComponent();
        }
        private void InPhieu()
        {
            FrmPrint frm = new FrmPrint();
            frm.rptViewer.LocalReport.ReportPath = Application.StartupPath + "\\Report\\rptBaoCaoNhap.rdlc"; 
                
            _dtBCNhap.TableName = "BaoCaoNhap";
            _dtBCNhap.WriteXmlSchema("BaoCaoNhap.xsd");
            frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("BaoCaoNhap", _dtBCNhap));

             if (rdoPhieuNhap.Checked)
            {
                frm.rptViewer.LocalReport.SetParameters(new ReportParameter("TenBC", "BÁO CÁO NHẬP"));
            }
            else
            {
                frm.rptViewer.LocalReport.SetParameters(new ReportParameter("TenBC","BÁO CÁO XUẤT"));
            }
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("TuNgay", dtpStartDate.Value.ToString("dd-MM-yyyy")));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("DenNgay", dtpEndDate.Value.ToString("dd-MM-yyyy")));
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("TenKho", cboKho.Text));
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
        private void LoadKho()
        {
            string sql = string.Format("select Makho, tenkho from Kho where Loai='{0}' ",
                               CurrentSetting.HangHoa.ToString());
            cboKho.DataSource = _db.FillDataTable(sql);
            cboKho.ValueMember = "MaKho";
            cboKho.DisplayMember = "TenKho";
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            string sql = string.Format("sp_TimKiemPhieuSP");
            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.NguyenLieu)
                sql = "sp_TimKiemPhieuNL";
            SqlParameter []para=new SqlParameter[4];
            para[0] = new SqlParameter("@StartDate", PublicFunction.GetStartDate(dtpStartDate.Value));
            para[1] = new SqlParameter("@EndDate", PublicFunction.GetStartDate(dtpEndDate.Value));
            para[2] = new SqlParameter("@MaKho", cboKho.SelectedValue);
            if (rdoPhieuNhap.Checked)
                para[3] = new SqlParameter("@Phieu", "Nhap");
            else
                para[3] = new SqlParameter("@Phieu", "Xuat");
            BindingSource bdsource = new BindingSource();
            _dtBCNhap= _db.ExecuteStoreProcedureTB(sql,para);
            bdsource.DataSource = _dtBCNhap;
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
            Cursor = Cursors.Default;
        }

        private void frmTimKiemPhieuNhapXuat_Shown(object sender, EventArgs e)
        {
            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            {
                grid.Columns["MaMau"].Visible = true;
            }
            else
            {
                grid.Columns["MaMau"].Visible = false;
            }
            LoadKho();
            if (_timkiem)
            {
                bttThoat.Visible = true;
                bttSua.Visible = true;
                rdoPhieuNhap.Enabled = false;
                rdoPhieuXuat.Enabled = false;
                if (_isNhap)
                {
                    rdoPhieuNhap.Checked = true;
                }
                else
                {
                    rdoPhieuXuat.Checked = true;
                }
            }
            else
            {
                bttThoat.Visible = false;
                bttSua.Visible = false;
            }
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
                    bdn.BindingSource.Filter = string.Format(" MaPhieu like '%{0}%' ",txtMaPN.Text);
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
                _ID = grid.CurrentRow.Cells["MaPhieu"].Value.ToString();
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

     }
}
