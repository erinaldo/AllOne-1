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
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne.ThietLap
{
    public partial class FrmTaiKhoan : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);

        public void LoadAll()
        {
            string sql = string.Format(" select MaNV,TenNV,TenDangNhap,TenNhomNV,DanhMuc,KhachHang,TinhLuong,BaoGia,NhapXuatTon,Packing from  " +
                                       " TaiKhoan nv inner join NhomTaiKhoan nh on nh.MaNhomNV=nv.MaNhomNV "+
                                       " order by TenNV ");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private void bttThemMoi_Click(object sender, EventArgs e)
        {
            FrmThemTaiKhoan frm = new FrmThemTaiKhoan();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void bttXuatExcel_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid,true);
        }

        private void FrmTaiKhoan_Shown(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == grid.Columns["Xoa"].Index)
                {
                    if (grid.CurrentRow.Cells["TenDangNhap"].Value.ToString()=="admin")
                    {
                        PublicFunction.ShowWarning("Tài khoản admin không được xóa.");
                        return;
                    }
                    if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.Yes)
                    {
                        NhanVien obj = new NhanVien();
                        obj.MaNV_K = grid.CurrentRow.Cells["MaNV"].Value.ToString();
                        _db.Delete(obj);
                        LoadAll();
                    }
                }
                if (e.ColumnIndex == grid.Columns["Sua"].Index)
                {
                    FrmThemTaiKhoan frm = new FrmThemTaiKhoan();
                    frm.Owner = this;
                    frm._frmstate = PublicFunction.FormState.Edit;
                    frm._id = grid.CurrentRow.Cells["MaNV"].Value.ToString();
                    frm.ShowDialog();
                    LoadAll();
                }

              
            }
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                if ( grid.Columns["DanhMuc"].Index==e.ColumnIndex ||
                   grid.Columns["NhapXuatTon"].Index==e.ColumnIndex ||
                   grid.Columns["BaoGia"].Index==e.ColumnIndex ||
                   grid.Columns["TinhLuong"].Index==e.ColumnIndex ||
                   grid.Columns["KhachHang"].Index==e.ColumnIndex ||
                   grid.Columns["Packing"].Index==e.ColumnIndex)
                {
                    TaiKhoan obj = new TaiKhoan();
                    obj.MaNV_K = grid.CurrentRow.Cells["MaNV"].Value.ToString();
                    _db.GetObject(ref obj);
                    if (obj.TenDangNhap=="admin")
                    {
                        PublicFunction.ShowWarning("Tài khoản admin không được phân quyền.");
                        return;
                    }
                    if (grid.CurrentRow.Cells["DanhMuc"].Value !=DBNull.Value)
                    {
                        if (grid.CurrentRow.Cells["DanhMuc"].Value.ToString() == Boolean.FalseString)
                            obj.DanhMuc =false;
                        else
                            obj.DanhMuc = true;
                    }else
                    {
                        obj.DanhMuc = false;
                    }
                    if (grid.CurrentRow.Cells["NhapXuatTon"].Value != DBNull.Value)
                    {
                        if (grid.CurrentRow.Cells["NhapXuatTon"].Value.ToString() == Boolean.FalseString)
                            obj.NhapXuatTon = false;
                        else
                            obj.NhapXuatTon = true;
                    }
                    else
                    {
                        obj.NhapXuatTon = false;
                    }
                    if (grid.CurrentRow.Cells["BaoGia"].Value != DBNull.Value)
                    {
                        if (grid.CurrentRow.Cells["BaoGia"].Value.ToString() == Boolean.FalseString)
                            obj.BaoGia = false;
                        else
                            obj.BaoGia = true;
                    }
                    else
                    {
                        obj.BaoGia = false;
                    }
                    if (grid.CurrentRow.Cells["TinhLuong"].Value != DBNull.Value)
                    {
                        if (grid.CurrentRow.Cells["TinhLuong"].Value.ToString() == Boolean.FalseString)
                            obj.TinhLuong = false;
                        else
                            obj.TinhLuong = true;
                    }
                    else
                    {
                        obj.TinhLuong = false;
                    }
                    if (grid.CurrentRow.Cells["KhachHang"].Value != DBNull.Value)
                    {
                        if (grid.CurrentRow.Cells["KhachHang"].Value.ToString() == Boolean.FalseString)
                            obj.KhachHang = false;
                        else
                            obj.KhachHang = true;
                    }
                    else
                    {
                        obj.KhachHang = false;
                    }
                    if (grid.CurrentRow.Cells["Packing"].Value != DBNull.Value)
                    {
                        if (grid.CurrentRow.Cells["Packing"].Value.ToString() == Boolean.FalseString)
                            obj.Packing = false;
                        else
                            obj.Packing = true;
                    }
                    else
                    {
                        obj.Packing = false;
                    }
                    _db.Update(obj);
                        
                }
            }
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow.Cells["TenDangNhap"].Value.ToString() == "admin")
            {
                grid.Columns["DanhMuc"].ReadOnly = true;
                grid.Columns["NhapXuatTon"].ReadOnly = true;
                grid.Columns["BaoGia"].ReadOnly = true;
                grid.Columns["TinhLuong"].ReadOnly = true;
                grid.Columns["KhachHang"].ReadOnly = true;
                grid.Columns["Packing"].ReadOnly = true;

            }
            else
            {
                grid.Columns["DanhMuc"].ReadOnly = false;
                grid.Columns["NhapXuatTon"].ReadOnly = false;
                grid.Columns["BaoGia"].ReadOnly = false;
                grid.Columns["TinhLuong"].ReadOnly = false;
                grid.Columns["KhachHang"].ReadOnly = false;
                grid.Columns["Packing"].ReadOnly = false;
            }
        }
    }
}
