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
using PublicUtility;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;


namespace AllOne.TinhLuong
{
    public partial class FrmChamCong : DockContent
    {
        DBSql _db = new DBSql(PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmChamCong()
        {
            InitializeComponent();
        }
        public void LoadAll()
        {

            this.Cursor = Cursors.AppStarting;

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("Thang", dtpThang.Value.ToString("yyyyMM"));
            _db.ExecuteStoreProcedure("sp_CapNhatChamCong", para);
            string sql = string.Format("sp_LoadChamCong");

            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.ExecuteStoreProcedureTB(sql, para);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;

            this.Cursor = Cursors.Default;
        }
        private void bttXuatExcel_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid, true);
        }

        private void bttHienThi_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            grid.ReadOnly = !grid.ReadOnly;
            grid.Columns["MaNV"].ReadOnly = true;
            grid.Columns["TenNV"].ReadOnly = true;
            grid.Columns["NgoaiGio"].ReadOnly = true;
            grid.Columns["TienNgoaiGio"].ReadOnly = true;
            grid.Columns["SoNgayCong"].ReadOnly = true;
            grid.Columns["LuongNgay"].ReadOnly = true;
            grid.Columns["LuongNgayCong"].ReadOnly = true;
            grid.Columns["LuongNgayThang"].ReadOnly = true;
            grid.Columns["TienBocCui"].ReadOnly = true;
            grid.Columns["ThucPhat"].ReadOnly = true;
            grid.Columns["DaPhat"].ReadOnly = true;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource != null)
            {
                if (txtMaNV.Text == "")
                    bdn.BindingSource.Filter = "";
                else
                    bdn.BindingSource.Filter = string.Format(" MaNV like '%{0}%' ", txtMaNV.Text);
            }
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource != null)
            {
                if (txtTenNV.Text == "")
                    bdn.BindingSource.Filter = "";
                else
                    bdn.BindingSource.Filter = string.Format(" TenNV like '%{0}%' ", txtTenNV.Text);
            }
        }

        private void FrmChamCong_Shown(object sender, EventArgs e)
        {
            LoadAll();
            grid.ReadOnly = true;
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ot = "null";
                if (grid.CurrentRow.Cells[e.ColumnIndex].Value != DBNull.Value)
                {
                    ot = grid.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
                }
                string sql = string.Format("update ChamCong set {0} = {1} where Thang='{2}' and MaNV='{3}' ",
                                            grid.Columns[e.ColumnIndex].Name, ot, dtpThang.Value.ToString("yyyyMM"),
                                            grid.CurrentRow.Cells["MaNV"].Value.ToString());
                _db.ExecuteNonQuery(sql);
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@Thang", dtpThang.Value.ToString("yyyyMM"));
                para[1] = new SqlParameter("@MaNV", grid.CurrentRow.Cells["MaNV"].Value.ToString());
                _db.ExecuteStoreProcedure("sp_CapNhatNgayChamCong", para);


                int thuong1 = 28;
                int thuong2 = 29;
                int thuong3 = 30;
                int thuong4 = 31;
                int songaytrongthang = PublicFunction.GetEndDayOfMonth(dtpThang.Value).Day;
                thuong4 = songaytrongthang;
                thuong3 = songaytrongthang - 1;
                thuong2 = songaytrongthang - 2;
                thuong1 = songaytrongthang - 3;
                foreach (DataGridViewRow r in grid.Rows)
                {
                      ChamCong obj = new ChamCong();
                        obj.Thang_K = r.Cells["Thang"].Value.ToString();
                        obj.MaNV_K = r.Cells["MaNV"].Value.ToString();
                        _db.GetObject(ref obj);
                    if (obj.SoNgayCong == thuong1)
                    {  
                        obj.Thuong = 1;
                        _db.Update(obj);
                        continue;
                    }
                    if (obj.SoNgayCong == thuong2)
                    {
                        obj.Thuong = 1.5M;
                        _db.Update(obj);
                        continue;
                    }
                    if (obj.SoNgayCong == thuong3)
                    {
                        obj.Thuong = 2;
                        _db.Update(obj);
                        continue;
                    }
                    if (obj.SoNgayCong == thuong4)
                    {
                        obj.Thuong = 2.5M;
                        _db.Update(obj);
                        continue;
                    }
                }
            }

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == grid.Columns["Xoa"].Index)
                {
                    if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.Yes)
                    {
                        ChamCong obj = new ChamCong();
                        obj.MaNV_K = grid.CurrentRow.Cells["MaNV"].Value.ToString();
                        obj.Thang_K = dtpThang.Value.ToString("yyyyMM");
                        _db.Delete(obj);
                        LoadAll();
                    }
                }
                if (e.ColumnIndex == grid.Columns["DaPhatB"].Index)
                {
                    ChamCong obj = new ChamCong();
                    obj.MaNV_K = grid.CurrentRow.Cells["MaNV"].Value.ToString();
                    obj.Thang_K = dtpThang.Value.ToString("yyyyMM");
                    _db.GetObject(ref obj);
                    if (obj.DaPhat)
                    {
                        if (PublicFunction.ShowQuestion("Nhân viên này đã phát tiền. Bạn muốn hủy đã phát tiền.") == System.Windows.Forms.DialogResult.Yes)
                        {
                            string sql = string.Format("update ChamCong set DaPhat=0 where Thang='{0}' and MaNV='{1}' ",
                                obj.Thang_K, obj.MaNV_K);
                            _db.ExecuteNonQuery(sql);
                        }
                    }
                    else
                    {
                        if (PublicFunction.ShowQuestion("Bạn muốn xác nhận đã phát tiền.") == System.Windows.Forms.DialogResult.Yes)
                        {
                            string sql = string.Format("update ChamCong set DaPhat=1 where Thang='{0}' and MaNV='{1}' ",
                                obj.Thang_K, obj.MaNV_K);
                            _db.ExecuteNonQuery(sql);
                        }
                    }
                    LoadAll();
                }

            }
        }

        private void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            decimal tong = 0;
            foreach (DataGridViewRow r in grid.Rows)
            {
                if (r.Cells["ThucPhat"].Value != DBNull.Value)
                    tong += Convert.ToDecimal(r.Cells["ThucPhat"].Value);
            }
            txtTongTien.Text = tong.ToString("N2");
        }

    }
}
