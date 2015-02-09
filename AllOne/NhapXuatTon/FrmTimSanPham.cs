using AllOne.Packing;
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

namespace AllOne.NhapXuatTon
{
    public partial class FrmTimSanPham : Form
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public List<SanPhamGia> _list = null;
        public FrmTimSanPham()
        {
            InitializeComponent();
        }
        public void LoadAll()
        {
            string sql = string.Format("sp_LoadSanPham");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.ExecuteStoreProcedureTB(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }

        private void FrmTimSanPham_Shown(object sender, EventArgs e)
        {
            LoadAll();
            txtMaSP.Focus();
        }

        private void FrmTimSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //_masp = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                //Close();
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                bdn.BindingSource.Filter = "";
            }
            else
            {
                bdn.BindingSource.Filter = string.Format(" MaSP like '%{0}%' ", txtMaSP.Text);
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                bdn.BindingSource.Filter = "";
            }
            else
            {
                bdn.BindingSource.Filter = string.Format(" TenSP like '%{0}%' ", txtTenSP.Text);
            }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //_masp = grid.CurrentRow.Cells["MaSP"].Value.ToString();
            //Close();
        }

        private void bttChon_Click(object sender, EventArgs e)
        {
            _list = new List<SanPhamGia>();
            foreach (DataGridViewRow r in grid.Rows)
            {
                if (r.Cells["Check"].Value != null)
                {
                    if (r.Cells["Check"].Value.ToString() == Boolean.TrueString)
                    {
                        SanPhamGia obj = new SanPhamGia();
                        obj.MaMau_K = r.Cells["MaMau"].Value.ToString();
                        obj.MaSP_K = r.Cells["MaSP"].Value.ToString();
                        _list.Add(obj);
                    }
                }
            }
            //_masp = grid.CurrentRow.Cells["MaSP"].Value.ToString();
            Close();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter && grid.CurrentRow !=null)
            //{
            //    _masp = grid.CurrentRow.Cells["MaSP"].Value.ToString();
            //    Close();
            //}
        }

        private void txtTenSP_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    _masp = grid.CurrentRow.Cells["MaSP"].Value.ToString();
            //    Close();
            //}
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid.CurrentCell.ColumnIndex == grid.Columns["MaMau"].Index)
            {
                FrmColor frm = new FrmColor();
                frm._isGetColor = true;
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                frm.WindowState = FormWindowState.Normal;
                frm.ShowDialog();
                if (frm._isOK)
                {
                    grid.CurrentRow.Cells["MaMau"].Value = frm._maMau;
                }
            }
        }
    }
}
