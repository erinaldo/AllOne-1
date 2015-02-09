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
    public partial class FrmColor : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
       public string _maMau = "";
       public  bool _isOK = false;
       public  bool _isGetColor = false;
        public FrmColor()
        {
            InitializeComponent();
        }
        private void LoadColor()
        {
            string sql = string.Format("select TenMau,MaMau,Price from Mau");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        private void bttAdd_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim()=="")
            {
                PublicFunction.ShowWarning("Tên màu không được để trống.");
                return;
            }
            if (txtMaMau.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Mã màu không được để trống.");
                return;
            }
            if (txtPrice.Text.Trim() == "")
            {
                PublicFunction.ShowWarning("Giá không được để trống.");
                return;
            }
            Mau mau = new Mau();
            mau.MaMau_K = txtMaMau.Text;
            mau.Price = Convert.ToDecimal(txtPrice.Text);
            mau.TenMau = txtTenSP.Text;
            if (pboHinh.Image !=null)
            {
                mau.Hinh = PublicFunction.ImageToByteArray(pboHinh.Image);
                mau.H = pboHinh.Image.Height;
                mau.W = pboHinh.Image.Width;
            }else
            {
                mau.Hinh = null;
            }
            if (_db.ExistObject(mau))
            {
                _db.Update(mau);
            }else
            {
                _db.Insert(mau);
            }
            LoadColor();

        }

        private void gridP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid.Columns["Xoa"].Index && !grid.CurrentRow.IsNewRow)
            {
                if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.Yes)
                {
                    Mau m = new Mau();
                    m.MaMau_K = grid.CurrentRow.Cells["MaMau"].Value.ToString();
                    _db.Delete(m);
                    grid.Rows.Remove(grid.CurrentRow);
                    LoadColor();
                }
            }else
            {
                txtTenSP.Text = grid.CurrentRow.Cells["TenMau"].Value.ToString();
                txtMaMau.Text = grid.CurrentRow.Cells["MaMau"].Value.ToString();
                txtPrice.Text = grid.CurrentRow.Cells["Price"].Value.ToString();
                Mau m = new Mau();
                m.MaMau_K = grid.CurrentRow.Cells["MaMau"].Value.ToString();
                _db.GetObject(ref m);
                if (m.Hinh != null)
                {
                    pboHinh.Image = PublicFunction.GetImageFromArrayByte(m.Hinh);
                }else
                {
                    pboHinh.Image = null;
                }
            }
        }

        private void FrmColor_Shown(object sender, EventArgs e)
        {
            LoadColor();
            if (_isGetColor)
            {
                lblPrice.Visible = false;
                txtPrice.Visible = false;
                bttAdd.Visible = false;
                bttXuat.Visible = false;
                bttThoat.Visible = true;
            }
            else
            {
                bttThoat.Visible = false;
            }
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid);
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                if (_isGetColor)
                {
                    _maMau = grid.CurrentRow.Cells["MaMau"].Value.ToString();
                    _isOK = true;
                    Close();
                }
            }
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttUpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pboHinh.ImageLocation = open.FileName;
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            pboHinh.Image = null;
        }

        private void txtMaMau_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource !=null)
            {
                if (txtMaMau.Text != "")
                {
                    bdn.BindingSource.Filter = string.Format(" MaMau like '%{0}%' ", txtMaMau.Text);
                }
                else
                {
                    bdn.BindingSource.Filter = "";
                }
            }
        }
    }
}
