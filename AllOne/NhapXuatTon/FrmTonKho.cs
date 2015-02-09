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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using PublicUtility;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmTonKho : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        DataTable _dtTonKho;
        public FrmTonKho()
        {
            InitializeComponent();
        }
        private void InPhieu()
        {
            FrmPrint frm = new FrmPrint();
            frm.rptViewer.LocalReport.ReportPath = Application.StartupPath + "\\Report\\rptBaoCaoTonKho.rdlc";
            _dtTonKho.TableName = "BaoCaoTonKho";
            _dtTonKho.WriteXmlSchema("BaoCaoTonKho.xsd");
            frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("BaoCaoTonKho", _dtTonKho));

            //if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            //{
            //    sql = "[sp_BaoCaoNhapXuatSP]";
            //    frm.rptViewer.LocalReport.ReportPath = Application.StartupPath + "\\Report\\rptBaoCaoTonKho.rdlc";
            //    DataTable dtPN = _db.ExecuteStoreProcedureTB(sql, para);
            //    //dtPN.TableName = "PhieuNhapSP";
            //    //dtPN.WriteXmlSchema("PhieuNhapSP.xsd");
            //    frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("PhieuNhapSP", dtPN));
            //}
            //else
            //{
            //    frm.rptViewer.LocalReport.ReportPath = Application.StartupPath + "\\Report\\rptBaoCaoTonKho.rdlc";
            //    DataTable dtPN = _db.ExecuteStoreProcedureTB(sql, para);
            //    //dtPN.TableName = "PhieuNhapNL";
            //    //dtPN.WriteXmlSchema("PhieuNhapNL.xsd");
            //    frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("PhieuNhapSP", dtPN));
            //}
            frm.rptViewer.LocalReport.SetParameters(new ReportParameter("Thang", dtpThangKK.Value.ToString("MM-yyyy")));
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
        private bool KiemTraKhoaTonKho()
        {
            string sql = string.Format(" select Thang from TonKho where Thang='{0}' and Khoa=1 ",
                                        dtpThangKK.Value.ToString("yyyyMM"));
            DataTable dt = _db.FillDataTable(sql);
            if (dt.Rows.Count>0)
            {
                return true;
            }else
            {
                return false;
            }
        }
        private void LoadNhomSP()
        {
            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            {
                string sql = string.Format(" select MaNhom,TenNhom from NhomSanPham order by TenNhom ");
                cboNhomSP.ComboBox.DataSource = _db.FillDataTable(sql);
                cboNhomSP.ComboBox.DisplayMember = "TenNhom";
                cboNhomSP.ComboBox.ValueMember = "MaNhom";
                cboNhomSP.SelectedIndex = 0;
            }
            else
            {
                string sql = string.Format(" select MaNhom,TenNhom from NhomNguyenLieu order by TenNhom ");
                cboNhomSP.ComboBox.DataSource = _db.FillDataTable(sql);
                cboNhomSP.ComboBox.DisplayMember = "TenNhom";
                cboNhomSP.ComboBox.ValueMember = "MaNhom";
                cboNhomSP.SelectedIndex = 0;
            }
        }
        private void LoadKho()
        {
            string sql = string.Format("select Makho, tenkho from Kho where Loai='{0}' ",
                               CurrentSetting.HangHoa.ToString());
            cboKho.DataSource = _db.FillDataTable(sql);
            cboKho.ValueMember = "MaKho";
            cboKho.DisplayMember = "TenKho";
        }
        private void LoadTonKho()
        {
            string sql = string.Format("sp_LoadTonKho");
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@MaKho", cboKho.SelectedValue);
            para[1] = new SqlParameter("@Thang", dtpThangKK.Value.ToString("yyyyMM"));
            para[2] = new SqlParameter("@Loai",CurrentSetting.HangHoa.ToString());
            BindingSource bdsource = new BindingSource();
            _dtTonKho= _db.ExecuteStoreProcedureTB(sql,para);
            bdsource.DataSource = _dtTonKho;
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            {
                grid.Columns["MaMau"].Visible = true;
            }else
            {
                grid.Columns["MaMau"].Visible = false;
            }
        }

        private void bttChayTon_Click(object sender, EventArgs e)
        {
            if (KiemTraKhoaTonKho())
            {
                PublicFunction.ShowWarning("Tháng này đã khóa không được chạy lại tồn kho.");
                return;
            }
            if (PublicFunction.ShowQuestion("Bạn muốn chạy tồn kho tháng .")==DialogResult.Yes)
            {
                Cursor = Cursors.AppStarting;
                try
                {
                    string sql = string.Format("[sp_ChayTonKho]");
                    SqlParameter[] para = new SqlParameter[4];
                    para[0] = new SqlParameter("@StartDate", PublicFunction.GetStartDayOfMonth(dtpThangKK.Value));
                    para[1] = new SqlParameter("@EndDate", PublicFunction.GetEndDayOfMonth(dtpThangKK.Value));
                    para[2] = new SqlParameter("@ThangNay", dtpThangKK.Value.ToString("yyyyMM"));
                    para[3] = new SqlParameter("@ThangTruoc", dtpThangKK.Value.AddMonths(-1).ToString("yyyyMM"));
                    _db.ExecuteStoreProcedure(sql, para);
                    bttTimKiem.PerformClick();
                    PublicFunction.ShowSuccess();
                }catch (Exception ex)
                {
                    PublicFunction.ShowError(ex, "ChayTon", Name);
                }
                Cursor = Cursors.Default;
            }
        }

        private void FrmTonKho_Shown(object sender, EventArgs e)
        {         
            
            LoadKho();
            LoadNhomSP();
            LoadTonKho();
        }

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKho.ValueMember!="" && cboKho.DisplayMember!="" && cboKho.SelectedIndex>=0)
            {
                LoadTonKho();
            }
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            LoadTonKho();
        }

        private void cboNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKho.ValueMember != "" && cboKho.DisplayMember != "" && cboKho.SelectedIndex >= 0)
            {
                if (bdn.BindingSource != null)
                {
                    if (cboNhomSP.SelectedIndex != 0)
                    {
                        bdn.BindingSource.Filter = string.Format("TenNhom ='{0}'",cboNhomSP.Text);
                    }else
                    {
                        bdn.BindingSource.Filter = string.Format("");
                    }
                }
            }
        }

        private void rdoGiaTri_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGiaTri.Checked)
            {
                grid.Columns["GiaTriDauKy"].Visible = !grid.Columns["GiaTriDauKy"].Visible;
                grid.Columns["GiaTriNhap"].Visible = !grid.Columns["GiaTriNhap"].Visible;
                grid.Columns["GiaTriXuat"].Visible = !grid.Columns["GiaTriXuat"].Visible;
                grid.Columns["GiaTriCuoiKy"].Visible = !grid.Columns["GiaTriCuoiKy"].Visible;

                grid.Columns["SLDauKy"].Visible = !grid.Columns["SLDauKy"].Visible;
                grid.Columns["SLNhap"].Visible = !grid.Columns["SLNhap"].Visible;
                grid.Columns["SLXuat"].Visible = !grid.Columns["SLXuat"].Visible;
                grid.Columns["SLCuoiKy"].Visible = !grid.Columns["SLCuoiKy"].Visible;

            }
            else
            {
                grid.Columns["GiaTriDauKy"].Visible = !grid.Columns["GiaTriDauKy"].Visible;
                grid.Columns["GiaTriNhap"].Visible = !grid.Columns["GiaTriNhap"].Visible;
                grid.Columns["GiaTriXuat"].Visible = !grid.Columns["GiaTriXuat"].Visible;
                grid.Columns["GiaTriCuoiKy"].Visible = !grid.Columns["GiaTriCuoiKy"].Visible;

                grid.Columns["SLDauKy"].Visible = !grid.Columns["SLDauKy"].Visible;
                grid.Columns["SLNhap"].Visible = !grid.Columns["SLNhap"].Visible;
                grid.Columns["SLXuat"].Visible = !grid.Columns["SLXuat"].Visible;
                grid.Columns["SLCuoiKy"].Visible = !grid.Columns["SLCuoiKy"].Visible;
            }
        }

        private void txtMaSP_Enter(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "Mã sản phẩm")
            {
                txtMaSP.ForeColor = Color.Black;
                txtMaSP.Text = "";
            }
        }

        private void txtMaSP_Leave(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                txtMaSP.ForeColor = Color.Gray;
                txtMaSP.Text = "Mã sản phẩm";
            }
        }

        private void txtTenSP_Enter(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "Tên sản phẩm")
            {
                txtTenSP.ForeColor = Color.Black;
                txtTenSP.Text = "";
            }
        }

        private void txtTenSP_Leave(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                txtTenSP.ForeColor = Color.Gray;
                txtTenSP.Text = "Tên sản phẩm";
            }
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid);
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "Mã sản phẩm")
                return;
            if (txtMaSP.Text == "")
            {
                bdn.BindingSource.Filter = "";
            }
            else
            {
                bdn.BindingSource.Filter = string.Format(" MaSP like '%{0}%' ", txtMaSP.Text);
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "Tên sản phẩm")
                return;
            if (txtTenSP.Text == "")
            {
                bdn.BindingSource.Filter = "";
            }
            else
            {
                bdn.BindingSource.Filter = string.Format(" TenSP like '%{0}%' ", txtTenSP.Text);
            }
        }

        private void bttKhoa_Click(object sender, EventArgs e)
        {
            
            if (grid.RowCount > 0)
            {
                if (KiemTraKhoaTonKho()==false)
                {
                    if (PublicFunction.ShowQuestion("Bạn muốn khóa dữ liệu.") == DialogResult.Yes)
                    {

                        if (grid.CurrentRow.Cells["Khoa"].Value.ToString() == bool.FalseString)
                        {
                            string sql = string.Format(" update [AllOne].[dbo].[TonKho] " +
                                                       " set Khoa=1 " +
                                                       " where thang='{0}' ", dtpThangKK.Value.ToString("yyyyMM"));
                            _db.ExecuteNonQuery(sql);
                        }
                    }
                }
                else
                {
                    //if (dtpThangKK.Value<DateTime.Now)
                    //{
                    //    PublicFunction.ShowWarning("Bạn không thể mở khóa tồn kho quá khứ. ");
                    //    return;
                    //}
                    if (PublicFunction.ShowQuestion("Bạn muốn mở khóa dữ liệu.") == DialogResult.Yes)
                    {
                        string sql = string.Format(" update [AllOne].[dbo].[TonKho] " +
                                                   " set Khoa=0 " +
                                                   " where thang='{0}' ", dtpThangKK.Value.ToString("yyyyMM"));
                        _db.ExecuteNonQuery(sql);
                    }
                }
                bttTimKiem.PerformClick();
            }
            
        }

        private void dtpThangKK_ValueChanged(object sender, EventArgs e)
        {
            bttTimKiem.PerformClick();
        }

        private void bttInBC_Click(object sender, EventArgs e)
        {
            if (grid.RowCount>0)
            {
                Cursor = Cursors.AppStarting;
                InPhieu();
                Cursor = Cursors.Default;
            }
        }
    }
}
