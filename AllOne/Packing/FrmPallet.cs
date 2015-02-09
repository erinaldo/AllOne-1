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
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne.Packing
{
    public partial class FrmPallet : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        bool isLoad = true;
        public FrmPallet()
        {
            InitializeComponent();
        }
        private void UpdatePalletNo()
        {
            string sql = string.Format(" update Pallet " +
                            " set UnitPallet=SL " +
                            " from (" +
                            " select PalletNo,sum(soluong) as SL from Pallet" +
                            " where PackNo='{0}'" +
                            " group by PalletNo" +
                            " )pl" +
                            " where Pallet.PalletNo=pl.PalletNo" +
                            " and Pallet.PackNo='{0}' ",
                            txtPackNo.Text);
            _db.ExecuteNonQuery(sql);
        }
        private void LoadPalletMaster()
        {
            string sql = string.Format("select W,Description from PalletMaster ");
            cboPallet.DataSource = _db.FillDataTable(sql);
            cboPallet.ValueMember = "W";
            cboPallet.DisplayMember = "Description";
            cboPallet.SelectedIndex = -1;
            cboPallet.SelectedIndex = 0;
        }
        private void TongCong()
        {
            decimal tongsoluong = 0;
            decimal tongthanhtien = 0;
            foreach (DataGridViewRow r in grid.Rows)
            {
                if (!r.IsNewRow && r.Cells["SoLuong"].Value != null)
                {
                    if (r.Cells["SoLuong"].Value.ToString() != "")
                        tongsoluong += Convert.ToDecimal(r.Cells["SoLuong"].Value);
                }
                if (!r.IsNewRow && r.Cells["ThanhTien"].Value != null)
                {
                    if (r.Cells["ThanhTien"].Value.ToString() != "")
                        tongthanhtien += Convert.ToDecimal(r.Cells["ThanhTien"].Value);
                }
            }
            txtTongSL.Text = tongsoluong.ToString("N0");
            txtTongTien.Text = tongthanhtien.ToString("N3");
        }
        private void LoadPallet()
        {
            string sql = string.Format("select * from Pallet where PackNo='{0}' ",txtPackNo.Text);
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.FillDataTable(sql);
            bdn.BindingSource = bdsource;
            gridP.DataSource = bdsource;
            TongCong();
        }
        private void LoadPackinglist()
        {
            isLoad = true;
            SqlParameter []para=new SqlParameter[1];
            para[0] = new SqlParameter("@PackNo", txtPackNo.Text);
            string sql = string.Format("sp_LoadPackinglist2");
            DataTable dtPL = _db.ExecuteStoreProcedureTB(sql, para);
            grid.RowCount = 0;
            if (dtPL.Rows.Count>0)
            {
                foreach (DataRow sp in dtPL.Rows)
                {
                    if (sp["ConLai"].ToString() != "0")
                    {
                        grid.Rows.Add();
                        int index = grid.Rows.Count - 1;
                        grid.Rows[index].Cells["SoLuong"].Value = sp["SoLuong"].ToString();
                        grid.Rows[index].Cells["ConLai"].Value = sp["ConLai"].ToString();
                        grid.Rows[index].Cells["MaSP"].Value = sp["MaSP"].ToString();
                        grid.Rows[index].Cells["MaMau"].Value = sp["MaMau"].ToString();
                        grid.Rows[index].Cells["TenSP"].Value = sp["TenSP"].ToString();
                        grid.Rows[index].Cells["TenDVT"].Value = sp["TenDVT"].ToString();
                        grid.Rows[index].Cells["GiaBan"].Value = sp["GiaBan"].ToString();
                        grid.Rows[index].Cells["ThanhTien"].Value = sp["ThanhTien"].ToString();
                        grid.Rows[index].Cells["CanNang"].Value = sp["CanNang"].ToString();
                        txtPackNo.Text = sp["PackNo"].ToString();
                    }
                }
            }
            LoadPallet();
            isLoad = false;
        }

        private void txtPackNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPackNo.Text != "")
                {
                    LoadPackinglist();
                }
            }
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
             SqlParameter []para=new SqlParameter[1];
            para[0] = new SqlParameter("@PackNo", txtPackNo.Text);
            int soluong = 0;
            if (grid.CurrentRow != null)
            {
                soluong=Convert.ToInt16( grid.CurrentRow.Cells["ConLai"].Value.ToString());
            }else
            {
                soluong = Convert.ToInt16(gridP.CurrentRow.Cells["SoLuongP"].Value.ToString());
            }
            if (cboPalletNo.Text=="")
            {
                PublicFunction.ShowWarning("Bạn chưa nhập số thứ tự PalletNo.");
                cboPalletNo.Focus();
                return;
            }
            if (txtQty.Text == "" || txtQty.Text == "0")
            {
                PublicFunction.ShowWarning("Bạn chưa nhập số lượng.");
                txtQty.Focus();
                return;
            }
            if ((Math.Abs(Convert.ToInt16(txtQty.Text))>soluong && grid.CurrentRow !=null ) || 
                (Math.Abs(Convert.ToInt16(txtQty.Text))>=soluong && grid.CurrentRow ==null))
            {
                PublicFunction.ShowWarning("Số lượng không được lớn hơn số còn lại.");
                txtQty.Focus();
                return;
            }
            if (Convert.ToInt16(txtQty.Text)<0 && grid.CurrentRow != null) 
            {
                PublicFunction.ShowWarning("Số lượng không được âm.");
                txtQty.Focus();
                return;
            }
            if (grid.CurrentRow == null)
            {
                Pallet obj = new Pallet();
                obj.PackNo_K = txtPackNo.Text;
                obj.PalletNo_K = Convert.ToInt16(cboPalletNo.Text);
                obj.MaSP_K = gridP.CurrentRow.Cells["MaSPP"].Value.ToString();
                obj.MaMau_K = gridP.CurrentRow.Cells["MaMauP"].Value.ToString();
                _db.GetObjectNotReset(ref obj);
                SanPham sp = new SanPham();
                sp.MaSP_K = obj.MaSP_K;
                _db.GetObject(ref sp);
                obj.TenDVT = gridP.CurrentRow.Cells["TenDVTP"].Value.ToString();
                obj.TenSP = gridP.CurrentRow.Cells["TenSPP"].Value.ToString();
                obj.SoLuong += Convert.ToInt16(txtQty.Text);
                obj.W = Convert.ToInt16(txtW.Text);
                obj.L = Convert.ToInt16(txtL.Text);
                obj.H = Convert.ToInt16(txtH.Text);
                obj.UnitPallet = Convert.ToInt16(txtUnitPallet.Text);
                obj.NetWeight = sp.CanNang * obj.SoLuong;
                obj.GrossWeight = obj.NetWeight + Convert.ToInt16(txtWeight.Text);
                obj.CBM = Math.Round((obj.W * obj.L * obj.H) / 1000000.0m, 4);
                if (_db.ExistObject(obj))
                    _db.Update(obj);
                else
                    _db.Insert(obj);
            }
            else
            {
                Pallet obj = new Pallet();
                obj.PackNo_K = txtPackNo.Text;
                obj.PalletNo_K = Convert.ToInt16(cboPalletNo.Text);
                obj.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                obj.MaMau_K = grid.CurrentRow.Cells["MaMau"].Value.ToString();
                obj.TenDVT = grid.CurrentRow.Cells["TenDVT"].Value.ToString();
                obj.TenSP = grid.CurrentRow.Cells["TenSP"].Value.ToString();
                _db.GetObjectNotReset(ref obj);
                obj.SoLuong += Convert.ToInt16(txtQty.Text);
                obj.W = Convert.ToInt16(txtW.Text);
                obj.L = Convert.ToInt16(txtL.Text);
                obj.H = Convert.ToInt16(txtH.Text);
                obj.UnitPallet = Convert.ToInt16(txtUnitPallet.Text);
                obj.NetWeight = Convert.ToDecimal(grid.CurrentRow.Cells["CanNang"].Value) * obj.SoLuong;
                obj.GrossWeight = obj.NetWeight + Convert.ToInt16(txtWeight.Text);
                obj.CBM = Math.Round((obj.W * obj.L * obj.H) / 1000000.0m, 4);
                if (_db.ExistObject(obj))
                    _db.Update(obj);
                else
                    _db.Insert(obj);
            }

            _db.ExecuteStoreProcedure("sp_UpdatePallet", para);
            UpdatePalletNo();
            LoadPallet();
            LoadPackinglist();
        }

        private void cboPallet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPallet.SelectedIndex>=0 && cboPallet.DisplayMember!="" && cboPallet.ValueMember!="" && cboPallet.DataSource!=null)
            {
                PalletMaster obj = new PalletMaster();
                obj.W_K =Convert.ToInt16( cboPallet.SelectedValue);
                _db.GetObject(ref obj);
                txtWeight.Text = obj.Weight.ToString();
                txtW.Text = obj.W_K.ToString();
                txtL.Text = obj.L.ToString();
                txtH.Text = obj.H.ToString();
                txtUnitPallet.Text = obj.UnitPallet.ToString();
            }
        }

        private void FrmPallet_Shown(object sender, EventArgs e)
        {
            LoadPalletMaster();

            for (int i=1;i<=100;i++)
            {
                cboPalletNo.Items.Add(i);
            }
        }

        private void gridP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridP.CurrentRow == null)
                return;

            if (e.ColumnIndex == gridP.Columns["Xoa"].Index && e.RowIndex>=0)
            {
                Pallet obj = new Pallet();
                obj.PackNo_K = gridP.CurrentRow.Cells["PackNo"].Value.ToString();
                obj.PalletNo_K =Convert.ToInt16( gridP.CurrentRow.Cells["PalletNo"].Value);
                obj.MaSP_K = gridP.CurrentRow.Cells["MaSPP"].Value.ToString();
                obj.MaMau_K = gridP.CurrentRow.Cells["MaMauP"].Value.ToString();
                _db.Delete(obj);
                gridP.Rows.Remove(gridP.CurrentRow);
                UpdatePalletNo();
                LoadPackinglist();
            }
            else
            {
                cboPallet.SelectedValue = gridP.CurrentRow.Cells["W"].Value.ToString();
                cboPalletNo.Text = gridP.CurrentRow.Cells["PalletNo"].Value.ToString();
                txtQty.Text = gridP.CurrentRow.Cells["SoLuongP"].Value.ToString();
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                txtQty.Text = grid.CurrentRow.Cells["ConLai"].Value.ToString();
            }
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            FrmPackinglistMaster frm = new FrmPackinglistMaster();
            frm._chon = true;
            frm._PackNo = "";
            frm.ShowDialog();
            txtPackNo.Text = frm._PackNo;
            LoadPackinglist();
        }

        private void bttLamMoi_Click(object sender, EventArgs e)
        {
            if (txtPackNo.Text != "")
            {
                LoadPackinglist();
            }
        }

        private void bttUpdatePalletNo_Click(object sender, EventArgs e)
        {
            if (gridP.RowCount == 0)
                return;

            foreach (DataGridViewRow r in gridP.Rows)
            {
                if (r.Cells["PalletNo"].Value.ToString()==cboPalletNo.Text)
                {
                    PublicFunction.ShowWarning(string.Format("PalletNo<{0}> đã tồn tại rồi.", cboPalletNo.Text));
                    return;
                }
            }
            if (PublicFunction.ShowQuestion(string.Format("Bạn muốn chuyển đổi PalletNo: {0} ---> {1}",
                                            gridP.CurrentRow.Cells["PalletNo"].Value,cboPalletNo.Text))==System.Windows.Forms.DialogResult.Yes)
            {
                string sql = string.Format(" update [dbo].[Pallet] "+
                                           " set PalletNo='{1}'"+
                                           " where palletNo='{0}' and PackNo='{2}' ",
                                           gridP.CurrentRow.Cells["PalletNo"].Value,
                                           cboPalletNo.Text,
                                           gridP.CurrentRow.Cells["PackNo"].Value);
                _db.ExecuteNonQuery(sql);
                if (txtPackNo.Text != "")
                {
                    LoadPackinglist();
                }
            }
            
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow !=null && ! isLoad)
            {
                if (e.ColumnIndex==grid.Columns["SoLuong"].Index)
                {
                    Packinglist2 obj = new Packinglist2();
                    obj.PackNo_K = txtPackNo.Text;
                    obj.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                    obj.MaMau_K = grid.CurrentRow.Cells["MaMau"].Value.ToString();
                    _db.GetObject(ref obj);
                    obj.SoLuong =Convert.ToInt32( grid.CurrentRow.Cells["SoLuong"].Value);
                    _db.Update(obj);
                }
            }
        }

        private void FrmPallet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {
                grid.Columns["SoLuong"].ReadOnly = !grid.Columns["SoLuong"].ReadOnly;
            }
        }
        
    }
}
