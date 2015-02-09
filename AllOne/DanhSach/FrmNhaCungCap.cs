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
    public partial class FrmNhaCungCap : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }
        private void LoadDataNhom()
        {
            string sqlTinhThanh = " SELECT [TinhThanh] FROM [TinhThanh] ";
            cboTinhThanh.ComboBox.DataSource = _db.FillDataTable(sqlTinhThanh);
            cboTinhThanh.ComboBox.ValueMember = "TinhThanh";
            cboTinhThanh.ComboBox.DisplayMember = "TinhThanh";
            cboTinhThanh.SelectedIndex = 0;
        }
        public void LoadAll()
        {
            string sql = string.Format("sp_LoadNCC");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.ExecuteStoreProcedureTB(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        private void bttThemMoi_Click(object sender, EventArgs e)
        {
            FrmThemNCC frm = new FrmThemNCC();
            frm.Owner = this;
            frm.ShowDialog();
            LoadAll();
        }      

        private void FrmMSKhachHang_Shown(object sender, EventArgs e)
        {
            LoadAll();
            LoadDataNhom();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == grid.Columns["Xoa"].Index)
                {
                    if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.Yes)
                    {
                        NhaCungCap obj = new NhaCungCap();
                        obj.MaNCC_K = grid.CurrentRow.Cells["MaNCC"].Value.ToString();
                        _db.Delete(obj);
                        LoadAll();
                    }
                }
                if (e.ColumnIndex == grid.Columns["Sua"].Index)
                {
                    FrmThemNCC frm = new FrmThemNCC();
                    frm.Owner = this;
                    frm._frmstate = PublicFunction.FormState.Edit;
                    frm._id = grid.CurrentRow.Cells["MaNCC"].Value.ToString();
                    frm.ShowDialog();
                    LoadAll();
                }
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "Tên NCC")
                return;
            if (txtTenNCC.Text == "")
            {
                bdn.BindingSource.Filter = "";
            }
            else
            {
                bdn.BindingSource.Filter = string.Format(" TenNCC like '%{0}%' ", txtTenNCC.Text);
            }
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtDienThoai.Text == "Điện thoại")
                return;
            if (txtDienThoai.Text == "")
            {
                bdn.BindingSource.Filter = "";
            }
            else
            {
                bdn.BindingSource.Filter = string.Format(" DienThoai like '%{0}%' ", txtDienThoai.Text);
            }
        }

        private void txtTenKH_Enter(object sender, EventArgs e)
        {
            PublicFunction.SetColorEnter(sender as ToolStripTextBox);
            if (txtTenNCC.Text == "Tên NCC")
            {
                txtTenNCC.ForeColor = Color.Black;
                txtTenNCC.Text = "";
            }
        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {
            PublicFunction.SetColorLeave(sender as ToolStripTextBox);
            if (txtTenNCC.Text == "")
            {
                txtTenNCC.ForeColor = Color.Gray;
                txtTenNCC.Text = "Tên NCC";
            }
        }

        private void txtDienThoai_Enter(object sender, EventArgs e)
        {
            PublicFunction.SetColorEnter(sender as ToolStripTextBox);
            if (txtDienThoai.Text == "Điện thoại")
            {
                txtDienThoai.ForeColor = Color.Black;
                txtDienThoai.Text = "";
            }
        }

        private void txtDienThoai_Leave(object sender, EventArgs e)
        {
            PublicFunction.SetColorLeave(sender as ToolStripTextBox);
            if (txtDienThoai.Text == "")
            {
                txtDienThoai.ForeColor = Color.Gray;
                txtDienThoai.Text = "Điện thoại";
            }
        }

       private void cboTinhThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinhThanh.ComboBox.ValueMember != "" && cboTinhThanh.ComboBox.DisplayMember != "")
            {
                if (cboTinhThanh.Text == "<---Tất cả--->" || cboTinhThanh.Text == "")
                {
                    bdn.BindingSource.Filter = "";
                }
                else
                {
                    bdn.BindingSource.Filter = string.Format(" TinhThanh='{0}' ", cboTinhThanh.Text);
                }
            }
        }

    }
}
