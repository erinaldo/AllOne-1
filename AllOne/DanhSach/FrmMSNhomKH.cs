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

namespace AllOne.DanhSach
{
    public partial class FrmMSNhomKH : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate = CommonDB.PublicFunction.FormState.AddNew;
        public string _id;
        public void LoadAll()
        {
            string sql = string.Format("select MaNhomKH,TenNhomKH from NhomKhachHang where MaNhomKH <>'00' order by TenNhomKH  ");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        public FrmMSNhomKH()
        {
            InitializeComponent();
        }

        private void bttThemMoi_Click(object sender, EventArgs e)
        {
            FrmThemNhomKH frm = new FrmThemNhomKH();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void bttXuatExcel_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid,true);
        }

        private void FrmMSNhomKH_Shown(object sender, EventArgs e)
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
                        NhomKhachHang obj = new NhomKhachHang();
                        obj.MaNhomKH_K = grid.CurrentRow.Cells["MaNhomKH"].Value.ToString();
                        _db.Delete(obj);
                        LoadAll();
                    }
                }
                if (e.ColumnIndex == grid.Columns["Sua"].Index)
                {
                    FrmThemNhomKH frm = new FrmThemNhomKH();
                    frm.Owner = this;
                    frm._frmstate = PublicFunction.FormState.Edit;
                    frm._id = grid.CurrentRow.Cells["MaNhomKH"].Value.ToString();
                    frm.ShowDialog();
                    LoadAll();
                }
            }
        }
    }
}
