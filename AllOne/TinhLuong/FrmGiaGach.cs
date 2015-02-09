using CommonDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne.Packing
{
    public partial class FrmGiaGach : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
       public string _maMau = "";
       public  bool _isOK = false;
       public  bool _isGetColor = false;
        public FrmGiaGach()
        {
            InitializeComponent();
        }
        private void LoadGiaGach()
        {
            string sql = string.Format("select Gach,Gia from GiaGach");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        private void bttAdd_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim()=="")
            {
                PublicFunction.ShowWarning("Tên không được để trống.");
                return;
            }
            if (txtPrice.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Giá không được để trống.");
                return;
            }
            GiaGach mau = new GiaGach();
            mau.Gach_K = txtTenSP.Text;
            mau.Gia = Convert.ToDecimal(txtPrice.Text);
            if (_db.ExistObject(mau))
            {
                _db.Update(mau);
            }else
            {
                _db.Insert(mau);
            }
            LoadGiaGach();

        }

        private void gridP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid.Columns["Xoa"].Index && !grid.CurrentRow.IsNewRow)
            {
                if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.Yes)
                {
                    GiaGach m = new GiaGach();
                    m.Gach_K = grid.CurrentRow.Cells["Gach"].Value.ToString();
                    _db.Delete(m);
                    grid.Rows.Remove(grid.CurrentRow);
                    LoadGiaGach();
                }
            }else
            {
                txtTenSP.Text = grid.CurrentRow.Cells["Gach"].Value.ToString();
                txtPrice.Text = grid.CurrentRow.Cells["Gia"].Value.ToString();
            }
        }

        private void FrmColor_Shown(object sender, EventArgs e)
        {
            LoadGiaGach();
            
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid);
        }

    }
}
