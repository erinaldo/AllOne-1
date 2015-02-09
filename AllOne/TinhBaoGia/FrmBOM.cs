using AllOne.NhapXuatTon;
using AllOne.Tien;
using CommonDB;
using Microsoft.Reporting.WinForms;
using PublicUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmBOM : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        List<string> lstMaSP = new List<string>();
        public string _masp;
        private bool _isload = false;
        private DataTable _dtBaoGia;
        public FrmBOM()
        {
            InitializeComponent();
        }
     
        private void LoadSanPham()
        {
            string sql = string.Format("select MaSP,TenSP from SanPham ");
            cboSanPham.DataSource = _db.FillDataTable(sql);
            cboSanPham.ValueMember = "MaSP";
            cboSanPham.DisplayMember = "TenSP";
        }
        private void LoadBaoGia()
        {
            _dtBaoGia = _db.ExecuteStoreProcedureTB("sp_LoadBOM");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _dtBaoGia;
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
            txtMaSP_TextChanged(null, null);
            TongCong();
        }
        private void TaoMoiBG()
        {
            grid.Focus();
            grid.CurrentCell = grid.Rows[0].Cells["SoLuong"];
            //bttXoa.Enabled = false;
        }
    

        private void TongCong()
        {
            //decimal tongthanhtien = 0;
            //foreach (DataGridViewRow r in grid.Rows)
            //{
            //    if (!r.IsNewRow && r.Cells["ThanhTien"].Value != null)
            //    {
            //        if (r.Cells["ThanhTien"].Value.ToString() != "")
            //            tongthanhtien += Convert.ToDecimal(r.Cells["ThanhTien"].Value);
            //    }
            //}
            //txtTongTien.Text = tongthanhtien.ToString("N2");
        }

        private void FrmBaoGia_Shown(object sender, EventArgs e)
        {
            grid.Focus();
            LoadSanPham();
            bttTimKiem.PerformClick();
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && e.Control)
            {
                if (cboSanPham.SelectedIndex == -1)
                {
                    PublicFunction.ShowWarning("Bạn chưa chọn mã sản phẩm để đăng lục BOM.");
                    return;
                }
                //Tim kiem hang hoa
                FrmTimNguyenLieu frm = new FrmTimNguyenLieu();
                frm.ShowDialog();
                if (frm._list != null)
                {
                    foreach (string sp in frm._list)
                    {
                        if (!lstMaSP.Contains(sp))
                        {
                            NguyenLieu objnl = new NguyenLieu();
                            objnl.MaNL_K = sp;
                            _db.GetObject(ref objnl);

                            BOM objbom = new BOM();
                            objbom.MaSP_K = cboSanPham.SelectedValue.ToString();
                            objbom.MaNL_K = sp;
                            objbom.DinhMuc = 0;
                            
                            if (!_db.ExistObject(objbom))
                            {
                                objbom.NgayTao = DateTime.Now;
                                objbom.NguoiTao = CurrentUser.UserID;
                                _db.Insert(objbom);
                            }
                            LoadBaoGia();
                        }
                    }
                }
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.ColumnIndex == grid.Columns["Xoa"].Index && !grid.CurrentRow.IsNewRow)
            {
                BOM obj = new BOM();
                obj.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                obj.MaNL_K = grid.CurrentRow.Cells["MaNL"].Value.ToString();
                _db.GetObject(ref obj);
                if (!obj.Khoa)
                {
                    if (PublicFunction.ShowQuestion("Bạn muốn xóa sản phẩm này ?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        _db.Delete(obj);
                        lstMaSP.Remove(grid.CurrentRow.Cells["MaNL"].Value.ToString());
                        grid.Rows.Remove(grid.CurrentRow);
                    }
                }
                else
                {
                    PublicFunction.ShowWarning("BOM đã khóa không thể xóa nguyên liệu.");
                }

            }

        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            LoadBaoGia();

        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.Columns["DinhMuc"].Index == e.ColumnIndex)
            {
                if (grid.CurrentRow.Cells["Khoa"].Value == null)
                {
                    grid.Columns["DinhMuc"].ReadOnly = false;
                }
                else
                {
                    if (grid.CurrentRow.Cells["Khoa"].Value.ToString() == Boolean.FalseString)
                    {
                        grid.Columns["DinhMuc"].ReadOnly = false;
                    }
                    else
                    {
                        grid.Columns["DinhMuc"].ReadOnly = true;
                    }

                }
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            //if (txtMaPX.Text != "")
            //{
            //    if (PublicFunction.ShowQuestion("Bạn muốn xóa phiếu nhập này ?") == DialogResult.Yes)
            //    {
            //        string sqlxoa = string.Format("delete from BaoGia where MaBaoGia='{0}' ", txtMaPX.Text);
            //        _db.ExecuteNonQuery(sqlxoa);
            //        TaoMoiBG();
            //        PublicFunction.ShowSuccess();
            //    }
            //}
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || _isload)
                return;
            if (grid.Columns["DinhMuc"].Index == e.ColumnIndex )
            {
                decimal dinhmuc = 0;
                try
                {
                    if (grid.Rows[e.RowIndex].Cells["DinhMuc"].Value.ToString() != "")
                    {
                        dinhmuc = Decimal.Parse(grid.Rows[e.RowIndex].Cells["DinhMuc"].Value.ToString());
                    }
                }
                catch (Exception )
                {
                    grid.Rows[e.RowIndex].Cells["DinhMuc"].Value = 0;
                }
          
                BOM obj = new BOM();
                obj.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                obj.MaNL_K = grid.CurrentRow.Cells["MaNL"].Value.ToString();
                _db.GetObject(ref obj);
                obj.DinhMuc = dinhmuc;
                obj.NgayTao = DateTime.Now;
                obj.NguoiTao=CurrentUser.UserID;
                _db.Update(obj);
                TongCong();
            }
        }

        private void txtMaNL_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource !=null)
            {
                if (txtMaNL.Text=="")
                {
                    bdn.BindingSource.Filter = "";
                } else
                {
                    bdn.BindingSource.Filter = string.Format("MaNL like '%{0}%' ", txtMaNL.Text );
                }
            }
        }

        private void txtTenNL_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource != null)
            {
                if (txtTenNL.Text == "")
                {
                    bdn.BindingSource.Filter = "";
                }
                else
                {
                    bdn.BindingSource.Filter = string.Format("TenNL like '%{0}%' ", txtTenNL.Text);
                }
            }
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.ValueMember!="" && cboSanPham.DisplayMember!="" && cboSanPham.DataSource !=null)
            {
                txtMaSP.Text = cboSanPham.SelectedValue.ToString();
            }
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                cboSanPham.SelectedValue = txtMaSP.Text;
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource != null)
            {
                if (txtMaSP.Text == "")
                {
                    bdn.BindingSource.Filter = "";
                }
                else
                {
                    bdn.BindingSource.Filter = string.Format("MaSP like '%{0}%' ", txtMaSP.Text);
                }
            }
        }

        private void bttKhoa_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                BOM obj = new BOM();
                obj.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                obj.MaNL_K = grid.CurrentRow.Cells["MaNL"].Value.ToString();
                _db.GetObject(ref obj);
                if (obj.Khoa)
                {
                    if (PublicFunction.ShowQuestion(string.Format("Bạn muốn mở khóa BOM của mã hàng {0} ?", obj.MaSP_K)) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        string sqlUpdate = string.Format("Update BOM set Khoa=0 where  MaSP='{0}' ",
                                                         obj.MaSP_K);
                        _db.ExecuteNonQuery(sqlUpdate);
                        LoadBaoGia();
                        PublicFunction.ShowSuccess();
                    }
                }
                else
                {
                    if (PublicFunction.ShowQuestion(string.Format("Bạn muốn khóa BOM của mã hàng {0} ?", obj.MaSP_K)) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        string sqlUpdate = string.Format("Update BOM set Khoa=1 where MaSP='{0}' ",
                                                          obj.MaSP_K);
                        _db.ExecuteNonQuery(sqlUpdate);
                        LoadBaoGia();
                        PublicFunction.ShowSuccess();
                    }
                }
            }
        }

        private void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TongCong();
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid);
        }

  
    }
}
