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
    public partial class FrmPalletList : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmPalletList()
        {
            InitializeComponent();
        }
        public void LoadPalletMaster()
        {
            string sql = string.Format("select W,L,H,Weight,UnitPallet,Description from PalletMaster");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            gridP.DataSource = bdsource;
        }
        private void bttAdd_Click(object sender, EventArgs e)
        {

            if (txtWeight.Text == "")
            {
                PublicFunction.ShowWarning("Weight không được để trống");
                txtWeight.Focus();
                return;
            }
            if (txtUnitPallet.Text == "")
            {
                PublicFunction.ShowWarning("UnitPallet không được để trống");
                txtUnitPallet.Focus();
                return;
            }
            if (txtW.Text == "")
            {
                PublicFunction.ShowWarning("W không được để trống");
                txtW.Focus();
                return;
            }
            if (txtL.Text == "")
            {
                PublicFunction.ShowWarning("L không được để trống");
                txtL.Focus();
                return;
            }
            if (txtH.Text == "")
            {
                PublicFunction.ShowWarning("H không được để trống");
                txtH.Focus();
                return;
            }

            PalletMaster obj = new PalletMaster();
            obj.Weight =Convert.ToInt16( txtWeight.Text);
            obj.UnitPallet = Convert.ToInt16(txtUnitPallet.Text);
            obj.W_K = Convert.ToInt16(txtW.Text);
            obj.L = Convert.ToInt16(txtL.Text);
            obj.H = Convert.ToInt16(txtH.Text);
            obj.Description = string.Format("{0}x{1}x{2}|{3}|{4}", obj.W_K, obj.L, obj.H, obj.Weight, obj.UnitPallet);
            if (_db.ExistObject(obj))
                _db.Update(obj);
            else
                _db.Insert(obj);

            LoadPalletMaster();
            txtW.Focus();
        }

        private void gridP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridP.CurrentRow == null) return;
            if (e.ColumnIndex == gridP.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                PalletMaster obj = new PalletMaster();
                obj.W_K =Convert.ToInt16( gridP.CurrentRow.Cells["W"].Value.ToString());
                _db.Delete(obj);
                gridP.Rows.Remove(gridP.CurrentRow);
                LoadPalletMaster();
                return;
            } else
            {
                txtWeight.Text = gridP.CurrentRow.Cells["Weight"].Value.ToString();
                txtUnitPallet.Text = gridP.CurrentRow.Cells["UnitPallet"].Value.ToString();
                txtW.Text = gridP.CurrentRow.Cells["W"].Value.ToString();
                txtL.Text = gridP.CurrentRow.Cells["L"].Value.ToString();
                txtH.Text = gridP.CurrentRow.Cells["H"].Value.ToString();
            }

        }

        private void FrmPalletList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void FrmPalletList_Shown(object sender, EventArgs e)
        {
            LoadPalletMaster();
        }
    }
}
