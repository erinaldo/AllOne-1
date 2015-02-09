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
    public partial class FrmMSKhachHang : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmMSKhachHang()
        {
            InitializeComponent();
        }
        private void LoadDataNhom()
        {
            string sql = string.Format(" select MaNhomKH,TenNhomKH from NhomKhachHang order by TenNhomKH");
            cboNhomKH.ComboBox.DataSource = _db.FillDataTable(sql);
            cboNhomKH.ComboBox.DisplayMember = "TenNhomKH";
            cboNhomKH.ComboBox.ValueMember = "MaNhomKH";
            cboNhomKH.SelectedIndex = 0;
            string sqlTinhThanh = " SELECT [TinhThanh] FROM [TinhThanh] ";
            cboTinhThanh.ComboBox.DataSource = _db.FillDataTable(sqlTinhThanh);
            cboTinhThanh.ComboBox.ValueMember = "TinhThanh";
            cboTinhThanh.ComboBox.DisplayMember = "TinhThanh";
            cboTinhThanh.SelectedIndex = 0;

        }
        public void LoadAll()
        {
            string sql = string.Format("sp_LoadKhachHang ");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.ExecuteStoreProcedureTB(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        private void bttThemMoi_Click(object sender, EventArgs e)
        {
            FrmThemKhachHang frm = new FrmThemKhachHang();
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
                        KhachHang obj = new KhachHang();
                        obj.MaKH_K = grid.CurrentRow.Cells["MaKH"].Value.ToString();
                        _db.Delete(obj);
                        LoadAll();
                    }
                }
                if (e.ColumnIndex == grid.Columns["Sua"].Index)
                {
                    FrmThemKhachHang frm = new FrmThemKhachHang();
                    frm.Owner = this;
                    frm._frmstate = PublicFunction.FormState.Edit;
                    frm._id = grid.CurrentRow.Cells["MaKH"].Value.ToString();
                    frm.ShowDialog();
                    LoadAll();
                }
            }
        }

        private void cboNhomKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNhomKH.ComboBox.ValueMember != "" && cboNhomKH.ComboBox.DisplayMember != "")
            {
                if (cboNhomKH.Text == "<---Tất cả--->" || cboNhomKH.Text == "")
                {
                    bdn.BindingSource.Filter = "";
                }
                else
                {
                    bdn.BindingSource.Filter = string.Format(" TenNhomKH='{0}' ", cboNhomKH.Text);
                }
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "Tên KH")
                return;
            if (txtTenKH.Text == "")
            {
                bdn.BindingSource.Filter = "";
            }
            else
            {
                bdn.BindingSource.Filter = string.Format(" TenKH like '%{0}%' ", txtTenKH.Text);
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
                bdn.BindingSource.Filter = string.Format(" DienThoai1 like '%{0}%' or DienThoai2 like '%{0}%' ", txtDienThoai.Text);
            }
        }

        private void txtTenKH_Enter(object sender, EventArgs e)
        {
            PublicFunction.SetColorEnter(sender as ToolStripTextBox);
            if (txtTenKH.Text == "Tên KH")
            {
                txtTenKH.ForeColor = Color.Black;
                txtTenKH.Text = "";
            }
        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {
            PublicFunction.SetColorLeave(sender as ToolStripTextBox);
            if (txtTenKH.Text == "")
            {
                txtTenKH.ForeColor = Color.Gray;
                txtTenKH.Text = "Tên KH";
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

       private void txtNguoiDaiDien_Enter(object sender, EventArgs e)
       {
           PublicFunction.SetColorEnter(sender as ToolStripTextBox);
           if (txtNguoiDaiDien.Text == "Người đại diện")
           {
               txtNguoiDaiDien.ForeColor = Color.Black;
               txtNguoiDaiDien.Text = "";
           }
       }

       private void txtNguoiDaiDien_Leave(object sender, EventArgs e)
       {
           PublicFunction.SetColorLeave(sender as ToolStripTextBox);
           if (txtNguoiDaiDien.Text == "")
           {
               txtNguoiDaiDien.ForeColor = Color.Gray;
               txtNguoiDaiDien.Text = "Người đại diện";
           }
       }

       private void txtDienThoai_Click(object sender, EventArgs e)
       {

       }

       private void txtTenKH_Click(object sender, EventArgs e)
       {

       }

       private void txtNguoiDaiDien_TextChanged(object sender, EventArgs e)
       {
           if (txtNguoiDaiDien.Text == "Người đại diện")
               return;
           if (txtNguoiDaiDien.Text == "")
           {
               bdn.BindingSource.Filter = "";
           }
           else
           {
               bdn.BindingSource.Filter = string.Format(" Nguoidaidien1 like '%{0}%' or Nguoidaidien2 like '%{0}%' ", txtNguoiDaiDien.Text);
           }
       }

    }
}
