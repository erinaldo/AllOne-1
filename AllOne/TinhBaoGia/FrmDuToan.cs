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
    public partial class FrmDuToan : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        List<string> lstMaSP = new List<string>();
        private DataTable _dtBaoGia;
        public FrmDuToan()
        {
            InitializeComponent();
        }
        
        private void LoadDuToan()
        {

            _dtBaoGia = _db.FillDataTable(string.Format(" select Khoa,Thang,TienTT,TienGT,TienQL,TongGioCong,GiaTT,GiaGT,GiaQL,PhanTramLoiNhuan "+
                                                        " from DuToan order by Thang desc "));
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _dtBaoGia;
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;

        }
  
 
        private void FrmBaoGia_Shown(object sender, EventArgs e)
        {
            LoadDuToan();
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow !=null)
            {
                txtTienTT.Text = grid.CurrentRow.Cells["TienTT"].Value.ToString();
                txtTienGT.Text = grid.CurrentRow.Cells["TienGT"].Value.ToString();
                txtTienQL.Text = grid.CurrentRow.Cells["TienQL"].Value.ToString();
                txtTongGC.Text = grid.CurrentRow.Cells["TongGioCong"].Value.ToString();
                txtGiaTT.Text = grid.CurrentRow.Cells["GiaTT"].Value.ToString();
                txtGiaGT.Text = grid.CurrentRow.Cells["GiaGT"].Value.ToString();
                txtGiaQL.Text = grid.CurrentRow.Cells["GiaQL"].Value.ToString();
                txtLoiNhuan.Text = grid.CurrentRow.Cells["PhanTramLoiNhuan"].Value.ToString();
                int nam =Convert.ToInt16( grid.CurrentRow.Cells["Thang"].Value.ToString().Substring(0,4));
                int thang = Convert.ToInt16(grid.CurrentRow.Cells["Thang"].Value.ToString().Substring(4, 2));
                dtpThang.Value = new DateTime(nam, thang, 1);
            }
            
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
           if (txtTienTT.Text=="")
           {
               PublicFunction.ShowWarning("Tiền trực tiếp chưa nhập.");
               txtTienTT.Focus();
               return;
           }
           if (txtTienGT.Text == "")
           {
               PublicFunction.ShowWarning("Tiền gián tiếp chưa nhập.");
               txtTienGT.Focus();
               return;
           }
           if (txtTienQL.Text == "")
           {
               PublicFunction.ShowWarning("Tiền quản lý chưa nhập.");
               txtTienQL.Focus();
               return;
           }
           if (txtTongGC.Text == "")
           {
               PublicFunction.ShowWarning("Tổng giờ chưa nhập.");
               txtTongGC.Focus();
               return;
           }
   
           if (txtLoiNhuan.Text == "")
           {
               PublicFunction.ShowWarning("Phần trăm lợi nhuận chưa nhập.");
               txtLoiNhuan.Focus();
               return;
           }
            try
            {
                _db.BeginTransaction();

                DuToan obj = new DuToan();
                obj.Thang_K = dtpThang.Value.ToString("yyyyMM");
                _db.GetObject(ref obj);
                if (obj.Khoa)
                {
                    PublicFunction.ShowWarning("Dự toán này đã khóa không thể lưu");
                    return;
                }
                obj.Thang_K = dtpThang.Value.ToString("yyyyMM");
                obj.TienTT =Convert.ToDecimal( txtTienTT.Text);
                obj.TienGT = Convert.ToDecimal(txtTienGT.Text);
                obj.TienQL = Convert.ToDecimal(txtTienQL.Text);
                obj.TongGioCong = Convert.ToDecimal(txtTongGC.Text);
                obj.GiaTT = Convert.ToDecimal(txtGiaTT.Text);
                obj.GiaGT = Convert.ToDecimal(txtGiaGT.Text);
                obj.GiaQL = Convert.ToDecimal(txtGiaQL.Text);
                obj.PhanTramLoiNhuan = Convert.ToDecimal(txtLoiNhuan.Text);
                if (_db.ExistObject(obj))
                {
                    _db.Update(obj);

                }else
                {
                    _db.Insert(obj);
                }
                _db.Commit();
                LoadDuToan();
                PublicFunction.ShowSuccess();
            }
            catch (Exception ex)
            {
                _db.RollBack();
                PublicFunction.ShowError(ex, "bttLuu", this.Name);
            }
        }


        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                if (PublicFunction.ShowQuestion(string.Format("Bạn muốn xóa dự toán tháng {0} ",
                                                             grid.CurrentRow.Cells["Thang"].Value.ToString())) == System.Windows.Forms.DialogResult.Yes)
                {
                    DuToan obj = new DuToan();
                    obj.Thang_K = grid.CurrentRow.Cells["Thang"].Value.ToString();
                    _db.GetObject(ref obj);
                    if (!obj.Khoa)
                    {
                        _db.Delete(obj);
                        LoadDuToan();
                    }else
                    {
                        PublicFunction.ShowWarning("Dự toán này đã khóa không thể xóa");
                    }
                }
            }
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtTienTT_TextChanged(object sender, EventArgs e)
        {
            if (txtTienTT.Text=="")
            {
                txtGiaTT.Text = "0";
            }else
            {
                if (txtTongGC.Text != "")
                    txtGiaTT.Text =( Convert.ToDecimal(txtTienTT.Text) / Convert.ToDecimal(txtTongGC.Text)).ToString("N2");
                else
                    txtGiaTT.Text = "0";
            }
        }

        private void txtTienGT_TextChanged(object sender, EventArgs e)
        {

            if (txtTienGT.Text == "")
            {
                txtGiaGT.Text = "0";
            }
            else
            {
                if (txtTongGC.Text != "")
                    txtGiaGT.Text = (Convert.ToDecimal(txtTienGT.Text) / Convert.ToDecimal(txtTongGC.Text)).ToString("N2");
                else
                    txtGiaGT.Text = "0";
            }
        }

        private void txtTienQL_TextChanged(object sender, EventArgs e)
        {

            if (txtTienQL.Text == "")
            {
                txtGiaQL.Text = "0";
            }
            else
            {
                if (txtTongGC.Text != "")
                    txtGiaQL.Text = (Convert.ToDecimal(txtTienQL.Text) / Convert.ToDecimal(txtTongGC.Text)).ToString("N2");
                else
                    txtGiaQL.Text = "0";
            }
        }

        private void txtTongGC_TextChanged(object sender, EventArgs e)
        {

            if (txtTongGC.Text == "")
            {
                txtGiaTT.Text = "0";
                txtGiaGT.Text = "0";
                txtGiaQL.Text = "0";
            }
            else
            {
                txtGiaTT.Text = (Convert.ToDecimal(txtTienTT.Text) / Convert.ToDecimal(txtTongGC.Text)).ToString("N2");
                txtGiaGT.Text = (Convert.ToDecimal(txtTienGT.Text) / Convert.ToDecimal(txtTongGC.Text)).ToString("N2");
                txtGiaQL.Text = (Convert.ToDecimal(txtTienQL.Text) / Convert.ToDecimal(txtTongGC.Text)).ToString("N2");
            }
        }

        private void bttKhoa_Click(object sender, EventArgs e)
        {
            DuToan obj = new DuToan();
            obj.Thang_K = dtpThang.Text;
            _db.GetObject(ref obj);
            if (obj.Khoa)
            {
                if (PublicFunction.ShowQuestion("Bạn muốn mở khóa dự toán ?")==System.Windows.Forms.DialogResult.Yes)
                {
                    obj.Khoa = !obj.Khoa;
                    _db.Update(obj);
                    LoadDuToan();
                    PublicFunction.ShowSuccess();
                }
            }else
            {
                if (PublicFunction.ShowQuestion("Bạn muốn khóa dự toán?")==System.Windows.Forms.DialogResult.Yes)
                {
                    obj.Khoa = !obj.Khoa;
                    _db.Update(obj);
                    LoadDuToan();
                    PublicFunction.ShowSuccess();
                }
            }
        }

 

    }
}
