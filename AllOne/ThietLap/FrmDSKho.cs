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
    public partial class FrmDSKho : DockContent
    {
       
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public void LoadAll()
        {
            string sql = string.Format(" select MaKho,TenKho,NguoiDaiDien,DiaChi,DienThoai,Loai,KhoBan "+
                                       " from Kho order by TenKho ");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        public FrmDSKho()
        {
            InitializeComponent();
        }

        private void bttThemMoi_Click(object sender, EventArgs e)
        {
            FrmThemKho frm = new FrmThemKho();
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
                        Kho obj = new Kho();
                        obj.MaKho_K = grid.CurrentRow.Cells["MaKho"].Value.ToString();
                        _db.Delete(obj);
                        LoadAll();
                    }
                }
                if (e.ColumnIndex == grid.Columns["Sua"].Index)
                {
                    FrmThemKho frm = new FrmThemKho();
                    frm.Owner = this;
                    frm._frmstate = PublicFunction.FormState.Edit;
                    frm._id = grid.CurrentRow.Cells["MaKho"].Value.ToString();
                    frm.ShowDialog();
                    LoadAll();
                }
            }
        }

        private void FrmDSKho_Shown(object sender, EventArgs e)
        {
            LoadAll();
            cboLoai.SelectedIndex = 0;
        }

        private void bttXuatExcel_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid,true);
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {            
                if (cboLoai.Text == "<---Tất cả--->" || cboLoai.Text == "")
                {
                    bdn.BindingSource.Filter = "";
                }
                else
                {
                    bdn.BindingSource.Filter = string.Format(" Loai='{0}' ", cboLoai.Text);
                }
            
        }
    }
}
