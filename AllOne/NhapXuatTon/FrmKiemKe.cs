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
    public partial class FrmKiemKe : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        DataTable _dtTonKho;
        public FrmKiemKe()
        {
            InitializeComponent();
        }
        private void InPhieu()
        {
            FrmPrint frm = new FrmPrint();
            frm.rptViewer.LocalReport.ReportPath = Application.StartupPath + "\\Report\\rptBaoCaoKiemKe.rdlc";
            _dtTonKho.TableName = "BaoCaoKiemKe";
            _dtTonKho.WriteXmlSchema("BaoCaoKiemKe.xsd");
            frm.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("BaoCaoKiemKe", _dtTonKho));

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
        private void LoadNhomSP()
        {
            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            {
                string sql = string.Format(" select MaNhom,TenNhom from NhomSanPham order by TenNhom ");
                cboNhomSP.ComboBox.DataSource = _db.FillDataTable(sql);
                cboNhomSP.ComboBox.DisplayMember = "TenNhom";
                cboNhomSP.ComboBox.ValueMember = "MaNhom";
                cboNhomSP.SelectedIndex = 0;
            }else
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
            string sql = string.Format("sp_LoadKiemKe");
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@MaKho", cboKho.SelectedValue);
            para[1] = new SqlParameter("@Thang", dtpThangKK.Value.ToString("yyyyMM"));
            para[2] = new SqlParameter("@Loai", CurrentSetting.HangHoa.ToString());
            BindingSource bdsource = new BindingSource();
            _dtTonKho= _db.ExecuteStoreProcedureTB(sql, para);
            bdsource.DataSource = _dtTonKho;
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
            if (CurrentSetting.HangHoa == PublicFunction.HangHoa.SanPham)
            {
                grid.Columns["MaMau"].Visible = true;
            }
            else
            {
                grid.Columns["MaMau"].Visible = false;
            }
        }
        private void FrmKiemKe_Shown(object sender, EventArgs e)
        {
            LoadKho();
            LoadNhomSP();
            LoadTonKho();

            if (grid.RowCount>0)
            {
                if (grid.CurrentRow.Cells["Khoa"].Value.ToString()==bool.FalseString)
                {
                    grid.Columns["SLKiemKe"].ReadOnly = false;
                    grid.Columns["LyDoDieuChinh"].ReadOnly = false;
                }else
                {

                    grid.Columns["SLKiemKe"].ReadOnly = true;
                    grid.Columns["LyDoDieuChinh"].ReadOnly = true;

                }
            }
        }

        private void gridPN_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            LoadTonKho();
        }

        private void bttXuatExcel_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid,true);
        }

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKho.ValueMember != "" && cboKho.DisplayMember != "" && cboKho.SelectedIndex >= 0)
            {
                LoadTonKho();
            }
        }

        private void cboNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKho.ValueMember != "" && cboKho.DisplayMember != "" && cboKho.SelectedIndex >= 0)
            {
                if (bdn.BindingSource != null)
                {
                    if (cboNhomSP.SelectedIndex != 0)
                    {
                        bdn.BindingSource.Filter = string.Format("TenNhom ='{0}'", cboNhomSP.Text);
                    }
                    else
                    {
                        bdn.BindingSource.Filter = string.Format("");
                    }
                }
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

        private void dtpThangKK_ValueChanged(object sender, EventArgs e)
        {
            LoadTonKho();
        }

        private void bttDieuChinhTK_Click(object sender, EventArgs e)
        {
            if (PublicFunction.ShowQuestion("Bạn muốn điều chỉnh tồn ?") == DialogResult.Yes)
            {
                Cursor = Cursors.AppStarting;
                try
                {
                    string sql = string.Format("sp_DieuChinhTonKho");
                    SqlParameter[] para = new SqlParameter[2];
                    para[0] = new SqlParameter("@MaKho", cboKho.SelectedValue);
                    para[1] = new SqlParameter("@Thang", dtpThangKK.Value.ToString("yyyyMM"));
                    _db.ExecuteStoreProcedureTB(sql, para);
                    PublicFunction.ShowSuccess();
                }catch(Exception ex)
                {
                    PublicFunction.ShowError(ex, "DieuChinhTonKho", Name);
                }
                Cursor = Cursors.Default;
            }
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && grid.CurrentRow !=null)
            {
                if (e.ColumnIndex == grid.Columns["SLKiemKe"].Index || e.ColumnIndex == grid.Columns["LyDoDieuChinh"].Index)
                {
                    TonKho obj = new TonKho();
                    obj.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                    obj.MaMau_K = grid.CurrentRow.Cells["MaMau"].Value.ToString();
                    obj.Thang_K = dtpThangKK.Value.ToString("yyyyMM");
                    obj.MaKho_K = cboKho.SelectedValue.ToString();
                    _db.GetObject(ref obj);
                    if (grid.CurrentRow.Cells["LyDoDieuChinh"].Value != DBNull.Value)
                    {
                        obj.LyDoDieuChinh = grid.CurrentRow.Cells["LyDoDieuChinh"].Value.ToString();
                    } else
                    {
                        obj.LyDoDieuChinh = "";
                    }
                    if (grid.CurrentRow.Cells["SLKiemKe"].Value != DBNull.Value)
                    {
                        obj.SLKiemKe = Convert.ToDecimal(grid.CurrentRow.Cells["SLKiemKe"].Value);
                    }else
                    {
                        obj.SLKiemKe = 0;
                    }
                    grid.CurrentRow.Cells["SLDieuChinh"].Value = obj.SLCuoiKy - obj.SLKiemKe;
                    _db.Update(obj);
                }
            }
        }

        private void bttInBC_Click(object sender, EventArgs e)
        {
            if (grid.RowCount>0)
            {
                InPhieu();
            }
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.RowCount > 0)
            {
                if (grid.CurrentRow.Cells["Khoa"].Value.ToString() == bool.FalseString)
                {
                    grid.Columns["SLKiemKe"].ReadOnly = false;
                    grid.Columns["LyDoDieuChinh"].ReadOnly = false;
                }
                else
                {

                    grid.Columns["SLKiemKe"].ReadOnly = true;
                    grid.Columns["LyDoDieuChinh"].ReadOnly = true;

                }
            }
        }
    }
}
