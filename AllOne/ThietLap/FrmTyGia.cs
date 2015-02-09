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

    public partial class FrmTyGia : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmTyGia()
        {
            InitializeComponent();
        }

        private void LoadTyGia()
        {
            string sql = string.Format("SELECT *  FROM [TyGiaQuyDoi] where Thang='{0}' ",dtpNgayNhap.Value.ToString("yyyyMM"));
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;

            if (grid.RowCount==0 && dtpNgayNhap.Value.ToString("yyyyMM")==DateTime.Now.ToString("yyyyMM"))
            {
                string capnhatsql = string.Format(" insert into TyGiaQuyDoi(Thang,MaTienTe,TyGia) "+
                                                  " select '{1}' as Thang, MaTienTe, TyGia from TyGiaQuyDoi where thang='{0}' ",
                                                  dtpNgayNhap.Value.AddMonths(-1).ToString("yyyyMM"),
                                                  dtpNgayNhap.Value.ToString("yyyyMM"));
                _db.ExecuteNonQuery(capnhatsql);

                 sql = string.Format("SELECT *  FROM [TyGiaQuyDoi] where Thang='{0}' ", dtpNgayNhap.Value.ToString("yyyyMM"));
                bdsource.DataSource = _db.FillDataTable(sql);
                bdn.BindingSource = bdsource;
                grid.DataSource = bdsource;
            }
        }
        private void bttXuat_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid);
        }

        private void FrmTyGia_Shown(object sender, EventArgs e)
        {
            LoadTyGia();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            grid.Columns["TyGia"].ReadOnly =! grid.Columns["TyGia"].ReadOnly;
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            LoadTyGia();
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow!=null)
            {
                if (grid.Columns["Tygia"].Index==e.ColumnIndex)
                {
                    TyGiaQuyDoi obj = new TyGiaQuyDoi();
                    obj.Thang_K = grid.CurrentRow.Cells["Thang"].Value.ToString();
                    obj.MaTienTe_K = grid.CurrentRow.Cells["MaTienTe"].Value.ToString();
                    _db.GetObject(ref obj);
                    try
                    {
                        obj.TyGia = Convert.ToDecimal(grid.CurrentRow.Cells["TyGia"].Value);
                        _db.Update(obj);
                    }catch (Exception )
                    {
                        //grid.CurrentRow.Cells["TyGia"].Value = obj.TyGia;
                    }
                    LoadTyGia();
                }
            }
        }
    }
}
