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
    public partial class FrmDonViTinh : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmDonViTinh()
        {
            InitializeComponent();
        }
        public void LoadAll()
        {
            string sql = string.Format("select * from DonViTinh order by TenDVT ");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }

        private void bttThemMoi_Click(object sender, EventArgs e)
        {
            FrmThemDVT frm = new FrmThemDVT();
            frm.Owner = this;
            frm.ShowDialog();
            LoadAll();
        }

        private void FrmDonViTinh_Shown(object sender, EventArgs e)
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
                        DonViTinh obj = new DonViTinh();
                        obj.MaDVT_K = grid.CurrentRow.Cells["MaDVT"].Value.ToString();
                        _db.Delete(obj);
                        LoadAll();
                    }
                }
                if (e.ColumnIndex == grid.Columns["Sua"].Index)
                {
                    FrmThemDVT frm = new FrmThemDVT();
                    frm.Owner = this;
                    frm._frmstate = PublicFunction.FormState.Edit;
                    frm._id = grid.CurrentRow.Cells["MaDVT"].Value.ToString();
                    frm.ShowDialog();
                    LoadAll();
                }
            }
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid,true);
        }
    }
}
