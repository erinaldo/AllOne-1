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
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne.TinhLuong
{
    public partial class FrmNhanVien : DockContent
    {
        DBSql _db =new DBSql(PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            string sql = string.Format(" select MaNV,TenNV,CMND,DiaChi,DienThoai,GioiTinh,LuongCoBan,LuongNgay " +
                                       "  from NhanVien order by MaNV ");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        private void bttLuu_Click(object sender, EventArgs e)
        {
            grid.ReadOnly = !grid.ReadOnly;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              if (e.RowIndex >= 0 )
            {
                if (e.ColumnIndex == grid.Columns["Xoa"].Index)
                {
                    if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.Yes)
                    {
                        NhanVien obj = new NhanVien();
                        obj.MaNV_K = grid.CurrentRow.Cells["MaNV"].Value.ToString();
                        _db.Delete(obj);
                        LoadAll();
                    }
                }
              }
        }

        private void FrmNhanVien_Shown(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                NhanVien obj = new NhanVien();
                if (grid.CurrentRow.Cells["MaNV"].Value != DBNull.Value)
                    obj.MaNV_K = grid.CurrentRow.Cells["MaNV"].Value.ToString();
                else
                    obj.MaNV_K = "";

                if (grid.CurrentRow.Cells["TenNV"].Value != DBNull.Value)
                    obj.TenNV = grid.CurrentRow.Cells["TenNV"].Value.ToString();
                else
                    obj.TenNV = "";

                if (grid.CurrentRow.Cells["GioiTinh"].Value != DBNull.Value)
                    obj.GioiTinh = grid.CurrentRow.Cells["GioiTinh"].Value.ToString();
                else
                    obj.GioiTinh = "";

                if (grid.CurrentRow.Cells["CMND"].Value != DBNull.Value)
                    obj.CMND = grid.CurrentRow.Cells["CMND"].Value.ToString();
                else
                    obj.CMND = "";

                if (grid.CurrentRow.Cells["DiaChi"].Value != DBNull.Value)
                    obj.DiaChi = grid.CurrentRow.Cells["DiaChi"].Value.ToString();
                else
                    obj.DiaChi = "";

                if (grid.CurrentRow.Cells["DienThoai"].Value != DBNull.Value)
                    obj.DienThoai = grid.CurrentRow.Cells["DienThoai"].Value.ToString();
                else
                    obj.DienThoai = "";

                if (grid.CurrentRow.Cells["LuongCoBan"].Value != DBNull.Value)
                    obj.LuongCoBan = Convert.ToDecimal(grid.CurrentRow.Cells["LuongCoBan"].Value);
                else
                    obj.LuongCoBan = 0;

                if (grid.CurrentRow.Cells["LuongNgay"].Value != DBNull.Value)
                    obj.LuongNgay = Convert.ToDecimal(grid.CurrentRow.Cells["LuongNgay"].Value);
                else
                    obj.LuongNgay=0;

                if (obj.MaNV_K != "")
                {
                    if (!_db.ExistObject(obj))
                        _db.Insert(obj);
                    else
                        _db.Update(obj);
                }
            }
        }
    }
}
