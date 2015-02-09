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
    public partial class FrmTinhBaoGia : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        List<string> lstMaSP = new List<string>();
        public string _masp;
        private bool _isload = false;
        private DataTable _dtBaoGia;
        public  FrmTinhBaoGia()
        {
            InitializeComponent();
        }
     
        private void LoadBaoGia()
        {
            SqlParameter []para=new SqlParameter[1];
            para[0]=new SqlParameter("@Thang",dtpThang.Value.ToString("yyyyMM"));
            _dtBaoGia = _db.ExecuteStoreProcedureTB("sp_LoadTinhBaoGia", para);
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _dtBaoGia;
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
            TongCong();
        }
        private void TaoMoiBG()
        {
            grid.Focus();
            grid.CurrentCell = grid.Rows[0].Cells["SoLuong"];
            //bttXoa.Enabled = false;
        }
        //private string TaoMaBG()
        //{
        //    //string mapn = "";
        //    //object max = _db.ExecuteScalar(string.Format("select max(MaBaoGia) from BaoGia where MaBaoGia like '{0}%' ",
        //    //                               "BG" + dtpThang.Value.ToString("yyMMdd")));
        //    //if (max is DBNull)
        //    //{
        //    //    mapn = "BG" + dtpThang.Value.ToString("yyMMdd") + "01";
        //    //}
        //    //else
        //    //{
        //    //    mapn = (Convert.ToInt16(max.ToString().Substring(8, 2)) + 1).ToString().PadLeft(2, '0');
        //    //    mapn = "BG" + dtpThang.Value.ToString("yyMMdd") + mapn;
        //    //}
        //    //return mapn;
        //}

        private void TongCong()
        {
            //decimal tongsoluong = 0;
            //decimal tongthanhtien = 0;
            //foreach (DataGridViewRow r in grid.Rows)
            //{
            //    if (!r.IsNewRow && r.Cells["SoLuong"].Value != null)
            //    {
            //        if (r.Cells["SoLuong"].Value.ToString() != "")
            //            tongsoluong += Convert.ToDecimal(r.Cells["SoLuong"].Value);
            //    }
            //    if (!r.IsNewRow && r.Cells["ThanhTien"].Value != null)
            //    {
            //        if (r.Cells["ThanhTien"].Value.ToString() != "")
            //            tongthanhtien += Convert.ToDecimal(r.Cells["ThanhTien"].Value);
            //    }
            //}
        }

        private void FrmBaoGia_Shown(object sender, EventArgs e)
        {
            grid.Focus();
            LoadBaoGia();
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control)
            {
                    //Tim kiem hang hoa
                    FrmTimSanPham frm = new FrmTimSanPham();
                    frm.ShowDialog();
                    if (frm._list != null)
                    {
                        foreach (SanPhamGia sp in frm._list)
                        {
                            if (!lstMaSP.Contains(sp.MaSP_K))
                            {
                                SqlParameter[] para = new SqlParameter[2];
                                para[0] = new SqlParameter("@Thang", dtpThang.Text);
                                para[1] = new SqlParameter("@MaSP", sp);
                                string sql = string.Format("GetThanhTienNL");
                                object giaNL = _db.ExecuteScalarSP(sql, para);
                                SanPham obj = new SanPham();
                                obj.MaSP_K = sp.MaSP_K;
                                _db.GetObject(ref obj);

                                DuToan objdt = new DuToan();
                                objdt.Thang_K = dtpThang.Text;
                                _db.GetObject(ref objdt);
                                TinhBaoGia objBG = new TinhBaoGia();
                                objBG.MaSP_K = obj.MaSP_K;
                                objBG.Thang_K = dtpThang.Text;
                                _db.GetObject(ref objBG);
                                objBG.MaSP_K = obj.MaSP_K;
                                objBG.Thang_K = dtpThang.Text;
                                objBG.GiaGT = objdt.GiaGT;
                                if (giaNL != null)
                                    objBG.GiaNL = Convert.ToDecimal(giaNL);
                                objBG.GiaQL = objdt.GiaQL;
                                objBG.GiaTT = objdt.GiaTT;
                                objBG.LoiNhuan = 0;
                                if (!_db.ExistObject(objBG))
                                {
                                    _db.Insert(objBG);
                                }
                                else
                                {
                                    // _db.Update(objBG);
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

                TinhBaoGia obj = new TinhBaoGia();
                obj.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                obj.Thang_K = dtpThang.Text;
                _db.GetObject(ref obj);
                if (!obj.Khoa)
                {
                    if (PublicFunction.ShowQuestion("Bạn muốn xóa sản phẩm này ?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        _db.Delete(obj);
                        lstMaSP.Remove( grid.CurrentRow.Cells["MaSP"].Value.ToString());
                        grid.Rows.Remove(grid.CurrentRow);
                    }
                }
                else
                {
                    PublicFunction.ShowWarning("Sản phẩm đã khóa không thể xóa.");
                }
            }
        }
        

        private void bttLuu_Click(object sender, EventArgs e)
        {
           
            if (grid.Rows.Count == 1)
            {
                PublicFunction.ShowWarning("Bạn chưa nhập sản phẩm.");
                grid.Focus();
                grid.CurrentCell = grid.Rows[0].Cells["SoLuong"];
                return;
            }
            try
            {
                _db.BeginTransaction();              
                //_db.ExecuteNonQuery(string.Format("delete from BaoGia where MaBaoGia='{0}' ", txtMaPX.Text));
                string maBG = "";

                foreach (DataGridViewRow r in grid.Rows)
                {
                    if (!r.IsNewRow)
                    {
                        BaoGia bg = new BaoGia();
                        bg.MaBaoGia_K = maBG;
                        if (r.Cells["GhiChu"].Value != null)
                            bg.GhiChu = r.Cells["GhiChu"].Value.ToString();
                        bg.GiaBan = Convert.ToDecimal(r.Cells["GiaBan"].Value);
                        bg.MaSP_K = r.Cells["MaSP"].Value.ToString();
                        bg.TenSP = r.Cells["TenSP"].Value.ToString();
                        bg.MaDVT = r.Cells["MaDVT"].Value.ToString();
                        bg.SoLuong = Convert.ToUInt16(r.Cells["SoLuong"].Value);
                        bg.MaTienTe = CurrentSetting.MaTienTe;
                        _db.Insert(bg);
                    }
                }
                _db.Commit();
                TaoMoiBG();
                PublicFunction.ShowSuccess();

            }
            catch (Exception ex)
            {
                _db.RollBack();
                PublicFunction.ShowError(ex, "bttLuu", this.Name);
            }
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            LoadBaoGia();
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.Columns["GioCong"].Index == e.ColumnIndex || grid.Columns["TLCP"].Index == e.ColumnIndex)
            {
                if (grid.CurrentRow.Cells["Khoa"].Value == null)
                {
                    grid.Columns["GioCong"].ReadOnly = false;
                    grid.Columns["TLCP"].ReadOnly = false;
                }
                else
                {
                    if (grid.CurrentRow.Cells["Khoa"].Value.ToString() == Boolean.FalseString)
                    {
                        grid.Columns["GioCong"].ReadOnly = false;
                        grid.Columns["TLCP"].ReadOnly = false;
                    }
                    else
                    {
                        grid.Columns["GioCong"].ReadOnly = true;
                        grid.Columns["TLCP"].ReadOnly = true;
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
            if (grid.Columns["TLCP"].Index == e.ColumnIndex || grid.Columns["GioCong"].Index == e.ColumnIndex)
            {
                decimal tyle = 0;
                decimal giocong = 0;
                try
                {
                    if (grid.Rows[e.RowIndex].Cells["TLCP"].Value.ToString() != "")
                    {
                        tyle = Decimal.Parse(grid.Rows[e.RowIndex].Cells["TLCP"].Value.ToString());
                    }
                }
                catch (Exception )
                {
                    grid.Rows[e.RowIndex].Cells["TLCP"].Value = 0;
                }
                try
                {
                    if (grid.Rows[e.RowIndex].Cells["GioCong"].Value.ToString() != "")
                    {
                        giocong = Decimal.Parse(grid.Rows[e.RowIndex].Cells["GioCong"].Value.ToString());
                    }
                }
                catch (Exception )
                {
                    grid.Rows[e.RowIndex].Cells["GioCong"].Value = 1;
                }

                TinhBaoGia obj = new TinhBaoGia();
                DuToan objdt = new DuToan();
                objdt.Thang_K = grid.CurrentRow.Cells["Thang"].Value.ToString();
                _db.GetObject(ref objdt);
                obj.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                obj.Thang_K = grid.CurrentRow.Cells["Thang"].Value.ToString();
                _db.GetObject(ref obj);
                obj.GioCong = giocong;
                obj.TLCP = tyle;
                obj.GiaThanh = (obj.GiaTT + obj.GiaGT + obj.GiaQL)*obj.GioCong + obj.GiaNL;
                if (obj.TLCP > 0)
                {
                    obj.GiaThanh = obj.GiaThanh / obj.TLCP;
                }
                obj.LoiNhuan = obj.GiaThanh / (1 - objdt.PhanTramLoiNhuan) - obj.GiaThanh;
                obj.GiaThanh = obj.GiaThanh + obj.LoiNhuan;
                _db.Update(obj);
                grid.Rows[e.RowIndex].Cells["GiaThanh"].Value =obj.GiaThanh;
                grid.Rows[e.RowIndex].Cells["LoiNhuan"].Value = obj.LoiNhuan;
                TongCong();
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource !=null)
            {
                if (txtMaSP.Text=="")
                {
                    bdn.BindingSource.Filter = "";
                } else
                {
                    bdn.BindingSource.Filter = string.Format("MaSP like '%{0}%' ", txtMaSP.Text );
                }
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource != null)
            {
                if (txtTenSP.Text == "")
                {
                    bdn.BindingSource.Filter = "";
                }
                else
                {
                    bdn.BindingSource.Filter = string.Format("TenSP like '%{0}%' ", txtTenSP.Text);
                }
            }
        }

        private void bttKhoa_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                TinhBaoGia obj = new TinhBaoGia();
                obj.Thang_K = dtpThang.Text;
                obj.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                _db.GetObject(ref obj);
                if (obj.Khoa)
                {
                    if (PublicFunction.ShowQuestion(string.Format("Bạn muốn mở khóa tính báo giá mã {0} ?", obj.MaSP_K)) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        obj.Khoa = !obj.Khoa;
                        _db.Update(obj);
                        LoadBaoGia();
                        PublicFunction.ShowSuccess();
                    }
                }
                else
                {
                    if (PublicFunction.ShowQuestion(string.Format("Bạn muốn khóa tính báo giá mã {0} ?", obj.MaSP_K)) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        obj.Khoa = !obj.Khoa;
                        _db.Update(obj);
                        LoadBaoGia();
                        PublicFunction.ShowSuccess();
                    }
                }
            }
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            PublicFunction.ExportEXCEL(grid);
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            bttTimKiem.PerformClick();
        }

    }
}
