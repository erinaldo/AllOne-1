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
    public partial class FrmNguyenLieu : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        private void LoadNCC()
        {
            string sql = string.Format("select MaNhom,TenNhom from NhomNguyenLieu order by TenNhom ");
            cboNhom.ComboBox.DataSource = _db.FillDataTable(sql);
            cboNhom.ComboBox.DisplayMember = "TenNhom";
            cboNhom.ComboBox.ValueMember = "MaNhom";
            cboNhom.SelectedIndex = 0;

            string sqlNCC = string.Format("  select MaNCC,TenNCC from NhaCungCap order by TenNCC ");
            cboNCC.ComboBox.DataSource = _db.FillDataTable(sqlNCC);
            cboNCC.ComboBox.DisplayMember = "TenNCC";
            cboNCC.ComboBox.ValueMember = "MaNCC";
            cboNCC.SelectedIndex = 0;
        }
        public void LoadAll()
        {
            string sql = string.Format("sp_LoadNguyenLieu");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.ExecuteStoreProcedureTB(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        private void SuaNguyenLieu()
        {
            FrmThemNguyenLieu frm = new FrmThemNguyenLieu();
            frm.Owner = this;
            frm._frmstate = PublicFunction.FormState.Edit;
            frm._id = grid.CurrentRow.Cells["MaNL"].Value.ToString();
            frm.ShowDialog();
            LoadAll();
        }
        private void XoaNguyenLieu()
        {
            if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    NguyenLieu obj = new NguyenLieu();
                    obj.MaNL_K = grid.CurrentRow.Cells["MaNL"].Value.ToString();
                    _db.Delete(obj);
                    LoadAll();
                }catch (Exception ex)
                {
                    PublicFunction.ShowError(ex, "XoaNguyenLieu", Name);
                }
            }
        }
        public FrmNguyenLieu()
        {
            InitializeComponent();
        }

        private void bttThemMoi_Click(object sender, EventArgs e)
        {
            FrmThemNguyenLieu frm = new FrmThemNguyenLieu();
            frm.Owner = this;
            frm.ShowDialog();
            LoadAll();
        }

        private void bttXuatExcel_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid,true);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == grid.Columns["Xoa"].Index)
                {
                    XoaNguyenLieu();
                }
                if (e.ColumnIndex == grid.Columns["Sua"].Index)
                {
                    SuaNguyenLieu();
                }
            }
        }

        private void FrmNguyenLieu_Shown(object sender, EventArgs e)
        {
            LoadAll();
        }

        
          private void txtMaSP_TextChanged(object sender, EventArgs e)
          {
              if (txtMaNL.Text == "Mã nguyên liệu")
                  return;
              if (txtMaNL.Text == "")
              {
                  bdn.BindingSource.Filter = "";
              }
              else
              {
                  bdn.BindingSource.Filter = string.Format(" MaNL like '%{0}%' ", txtMaNL.Text);
              }
          }

          private void txtTenSP_TextChanged(object sender, EventArgs e)
          {
              if (txtTenNL.Text == "Tên nguyên liệu")
                  return;
              if ( txtTenNL.Text == "")
              {
                  bdn.BindingSource.Filter = "";
              }
              else
              {
                  bdn.BindingSource.Filter = string.Format(" TenNL like '%{0}%' ", txtTenNL.Text);
              }
          }

          private void txtMaSP_Leave(object sender, EventArgs e)
          {
              if (txtMaNL.Text == "")
              {
                  txtMaNL.ForeColor = Color.Gray;
                  txtMaNL.Text = "Mã nguyên liệu";
              }
          }

          private void txtMaSP_Enter(object sender, EventArgs e)
          {
              if (txtMaNL.Text == "Mã nguyên liệu")
              {
                  txtMaNL.ForeColor = Color.Black;
                  txtMaNL.Text = "";
              }
          }

          private void txtTenSP_Enter(object sender, EventArgs e)
          {
              if (txtTenNL.Text == "Tên nguyên liệu")
              {
                  txtTenNL.ForeColor = Color.Black;
                  txtTenNL.Text = "";
              }
          }

          private void txtTenSP_Leave(object sender, EventArgs e)
          {
              if (txtTenNL.Text == "")
              {
                  txtTenNL.ForeColor = Color.Gray;
                  txtTenNL.Text = "Tên nguyên liệu";
              }
          }

          private void mnuSua_Click(object sender, EventArgs e)
          {
              if (grid.CurrentRow !=null)
              {
                  SuaNguyenLieu();
              }
          }

          private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
          {
              if (grid.CurrentRow != null)
              {
                  XoaNguyenLieu();
              }
          }

          private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
          {
              if (bdn.BindingSource != null)
              {
                  if (cboNCC.ComboBox.ValueMember != "" && cboNCC.ComboBox.DisplayMember != "")
                  {
                      if (cboNCC.Text == "<---Tất cả--->" || cboNCC.Text == "")
                      {
                          bdn.BindingSource.Filter = "";
                      }
                      else
                      {
                          bdn.BindingSource.Filter = string.Format(" TenNCC='{0}' ", cboNCC.Text);
                      }
                  }
              }
          }

          private void FrmNguyenLieu_Shown_1(object sender, EventArgs e)
          {
              LoadNCC();
              LoadAll();

          }

          private void cboNhom_SelectedIndexChanged(object sender, EventArgs e)
          {
              if (cboNhom.ComboBox.ValueMember != "" && cboNhom.ComboBox.DisplayMember != "")
              {
                  if (cboNhom.Text == "<---Tất cả--->" || cboNhom.Text == "")
                  {
                      bdn.BindingSource.Filter = "";
                  }
                  else
                  {
                      bdn.BindingSource.Filter = string.Format(" TenNhom='{0}' ", cboNhom.Text);
                  }
              }
          }
    }
}
