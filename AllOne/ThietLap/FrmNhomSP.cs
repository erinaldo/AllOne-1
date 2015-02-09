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
    public partial class FrmNhomSP : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public void LoadAll()
        {
            string sql = string.Format("select MaNhom,TenNhom from NhomSanPham where MaNhom<>'00'  order by TenNhom ");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        public FrmNhomSP()
        {
            InitializeComponent();
        }
        
        private void bttThemMoi_Click(object sender, EventArgs e)
        {
            FrmThemNhomSP frm = new FrmThemNhomSP();
            frm.Owner = this;
            frm.ShowDialog();
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
                        NhomSanPham obj = new NhomSanPham();
                        obj.MaNhom_K = grid.CurrentRow.Cells["MaNhom"].Value.ToString();
                        _db.Delete(obj);
                        LoadAll();
                    }
                }
                if (e.ColumnIndex == grid.Columns["Sua"].Index)
                {
                    FrmThemNhomSP frm = new FrmThemNhomSP();
                    frm.Owner = this;
                    frm._frmstate = PublicFunction.FormState.Edit;
                    frm._id = grid.CurrentRow.Cells["MaNhom"].Value.ToString();
                    frm.ShowDialog();
                    LoadAll();
                }
            }
        }

        private void bttXuatExcel_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid,true);
        }

        private void FrmNhomSP_Shown(object sender, EventArgs e)
        {
            LoadAll();
        }
    }
}
