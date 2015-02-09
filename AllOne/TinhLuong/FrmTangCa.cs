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
    public partial class FrmTangCa : DockContent
    {
        DBSql _db = new DBSql(PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmTangCa()
        {
            InitializeComponent();
        }
        public void LoadAll()
        {
            SqlParameter []para=new SqlParameter[1];
            para[0] = new SqlParameter("@Thang", dtpThang.Value.ToString("yyyyMM"));
            _db.ExecuteStoreProcedure("sp_CapNhatTangCa", para);
            string sql = string.Format("sp_LoadTangCa");

            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.ExecuteStoreProcedureTB(sql,para);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;

            decimal tong = 0;
            foreach(DataGridViewRow r in grid.Rows)
            {
                if (r.Cells["TongCong"].Value != DBNull.Value)
                    tong +=Convert.ToDecimal( r.Cells["TongCong"].Value);
            }
            txtTongGio.Text = tong.ToString("N2");
        }
        private void bttSua_Click(object sender, EventArgs e)
        {
            grid.ReadOnly = !grid.ReadOnly;
            grid.Columns["MaNV"].ReadOnly = true;
            grid.Columns["TenNV"].ReadOnly = true;
            grid.Columns["TongCong"].ReadOnly = true;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource != null)
            {
                if (txtMaNV.Text=="")
                    bdn.BindingSource.Filter="";
                else
                    bdn.BindingSource.Filter = string.Format(" MaNV like '{0}' ",txtMaNV.Text);
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

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == grid.Columns["Xoa"].Index)
                {
                    if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.Yes)
                    {
                        TangCa obj = new TangCa();
                        obj.MaNV_K = grid.CurrentRow.Cells["MaNV"].Value.ToString();
                        obj.Thang_K = dtpThang.Value.ToString("yyyyMM");
                        _db.Delete(obj);
                        LoadAll();
                    }
                }
            }
        }

        private void FrmTangCa_Shown(object sender, EventArgs e)
        {
            LoadAll();
            grid.ReadOnly = true;
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                if (grid.Columns[e.ColumnIndex].Name.Contains("D"))
                {
                    string ot = "null";
                    if (grid.CurrentRow.Cells[e.ColumnIndex].Value !=DBNull.Value)
                    {
                        ot = grid.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
                    }
                    string sql = string.Format("update TangCa set {0} = {1} where Thang='{2}' and MaNV='{3}' ",
                                                grid.Columns[e.ColumnIndex].Name, ot, dtpThang.Value.ToString("yyyyMM"),
                                                grid.CurrentRow.Cells["MaNV"].Value.ToString());
                    _db.ExecuteNonQuery(sql);
                    SqlParameter[] para = new SqlParameter[2];
                    para[0] = new SqlParameter("@Thang", dtpThang.Value.ToString("yyyyMM"));
                    para[1] = new SqlParameter("@MaNV", grid.CurrentRow.Cells["MaNV"].Value.ToString());
                    _db.ExecuteStoreProcedure("sp_CapNhatGioTangCa", para);
                }
            }
        }

        private void bttHienThi_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void bttXuatExcel_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid,true);
        }

    
    }
}

