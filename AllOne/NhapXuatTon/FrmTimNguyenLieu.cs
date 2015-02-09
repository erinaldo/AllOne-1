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
    public partial class FrmTimNguyenLieu : Form
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        //public string _masp = "";
        public List<string> _list = null;
        public FrmTimNguyenLieu()
        {
            InitializeComponent();
        }
        public void LoadAll()
        {
            string sql = string.Format("sp_LoadNguyenLieu");
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
            if (e.KeyCode==Keys.Escape)
            {
                Close();
            }
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode==Keys.Enter)
            //{
            //    _masp = grid.CurrentRow.Cells["MaNL"].Value.ToString();
            //    Close();
            //}
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                bdn.BindingSource.Filter = "";
            }
            else
            {
                bdn.BindingSource.Filter = string.Format(" MaNL like '%{0}%' ", txtMaSP.Text);
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
                bdn.BindingSource.Filter = string.Format(" TenNL like '%{0}%' ", txtTenSP.Text);
            }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //_masp = grid.CurrentRow.Cells["MaNL"].Value.ToString();
            //Close();
        }

        private void bttChon_Click(object sender, EventArgs e)
        {
            _list = new List<string>();
            foreach (DataGridViewRow r in grid.Rows)
            {
                if (r.Cells["Check"].Value != null)
                {
                    if (r.Cells["Check"].Value.ToString() == Boolean.TrueString)
                    {
                        _list.Add(r.Cells["MaNL"].Value.ToString());
                    }
                }
            }
            //_masp = grid.CurrentRow.Cells["MaNL"].Value.ToString();
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
            //    _masp = grid.CurrentRow.Cells["MaNL"].Value.ToString();
            //    Close();
            //}
        }

        private void txtTenSP_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    _masp = grid.CurrentRow.Cells["MaNL"].Value.ToString();
            //    Close();
            //}
        }
    }
}
