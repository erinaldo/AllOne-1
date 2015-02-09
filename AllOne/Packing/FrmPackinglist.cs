using AllOne.NhapXuatTon;
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
    public partial class FrmPackinglist : DockContent
    {
        List<SanPhamGia> lstMaSP = new List<SanPhamGia>();
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmPackinglist()
        {
            InitializeComponent();
        }
        private void LoadPackinglist()
        {
            lstMaSP.Clear();

            Packinglist pl = new Packinglist();
            pl.PackNo_K = txtPO.Text;
            _db.GetObject(ref pl);
            if (pl.PackNo_K ==null)
            {
                return;
            }
            txtPO.Text = pl.PackNo_K;
            txtShipper.Text = pl.Shipper;
            txtAddS.Text = pl.Address;
            txtConsignee.Text = pl.Consignee;
            txtAddC.Text = pl.AddC;
            // pl.Paymentterm = "";
            txtDelivery.Text = pl.DeliveryAddress;
            txtAddD.Text = pl.AddD;
            txtTerm.Text = pl.Term;
            txtShipFrom.Text = pl.ShipmentFrom;
            txtShipTo.Text = pl.ShipmentTo;
            if (pl.ETD > DateTime.MinValue)
            {
                dtpETD.Value = pl.ETD;
                dtpETD.Checked = true;
            }
                else
            {
                dtpETD.Checked = false;
            }
            txtShipAgent.Text = pl.ShippingAgent;
            txtBLNumber.Text = pl.BLNumber;
            txtContainerNo.Text = pl.ContainerNumber;
            txtSealNo.Text = pl.SealNumber;
            txtVessel.Text = pl.FeederVesselName;
            dtpThang.Value = pl.PLDate;
            txtPLNumber.Text = pl.PackinglistNumber;

            string sql = string.Format("select * from Packinglist2 where PackNo='{0}' ",
                                       pl.PackNo_K);
            Packinglist2[] pl2 = _db.GetObjects<Packinglist2>(sql);
            grid.RowCount = 0;
            foreach (Packinglist2 sp in pl2)
            {
                grid.Rows.Add();
                int index = grid.Rows.Count - 1;
                grid.Rows[index].Cells["SoLuong"].Value = sp.SoLuong;
                grid.Rows[index].Cells["MaSP"].Value = sp.MaSP_K;
                grid.Rows[index].Cells["MaMau"].Value = sp.MaMau_K;
                grid.Rows[index].Cells["TenSP"].Value = sp.TenSP;
                grid.Rows[index].Cells["TenDVT"].Value = sp.TenDVT;
                grid.Rows[index].Cells["GiaBan"].Value = sp.GiaBan;
                grid.Rows[index].Cells["ThanhTien"].Value = sp.ThanhTien;
                grid.Rows[index].Cells["CanNang"].Value = sp.CanNang;
                grid.Rows[index].Cells["W"].Value = sp.W;
                grid.Rows[index].Cells["L"].Value = sp.L;
                grid.Rows[index].Cells["H"].Value = sp.H;

                SanPhamGia spgia = new SanPhamGia();
                spgia.MaSP_K = sp.MaSP_K;
                spgia.MaMau_K = sp.MaMau_K;
                lstMaSP.Add(spgia);
            }
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
                        if (!lstMaSP.Contains(sp))
                        {
                            grid.Rows.Add();
                            int index = grid.Rows.Count - 1;
                            SanPham obj = new SanPham();         
                            obj.MaSP_K = sp.MaSP_K;
                            _db.GetObject(ref obj);
                            DonViTinh dvt = new DonViTinh();
                            dvt.MaDVT_K = obj.MaDVT;
                            _db.GetObject(ref dvt);
                            Mau mau = new Mau();
                            mau.MaMau_K = sp.MaMau_K;
                            _db.GetObject(ref mau);
                            grid.Rows[index].Cells["SoLuong"].Value = 1;
                            grid.Rows[index].Cells["MaSP"].Value = obj.MaSP_K;
                            grid.Rows[index].Cells["MaMau"].Value = sp.MaMau_K;
                            grid.Rows[index].Cells["TenSP"].Value = obj.TenSP;
                            grid.Rows[index].Cells["TenDVT"].Value = dvt.TenDVT;
                            grid.Rows[index].Cells["CanNang"].Value = obj.CanNang;
                            grid.Rows[index].Cells["W"].Value = obj.W;
                            grid.Rows[index].Cells["L"].Value = obj.L;
                            grid.Rows[index].Cells["H"].Value = obj.H;
                            grid.Rows[index].Cells["GiaBan"].Value = obj.GiaBan*mau.Price;
                            grid.Rows[index].Cells["ThanhTien"].Value = obj.GiaBan* mau.Price;
                        
                            grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];
                            lstMaSP.Add(sp);
                        }
                        else
                        {
                            foreach (DataGridViewRow r in grid.Rows)
                            {
                                if (!r.IsNewRow)
                                {
                                    if (r.Cells["MaSP"].Value.ToString() == sp.MaSP_K && r.Cells["MaMau"].Value.ToString() == sp.MaMau_K)
                                    {
                                        r.Cells["SoLuong"].Value = Convert.ToInt16(r.Cells["SoLuong"].Value) + 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid.Columns["Xoa"].Index && !grid.CurrentRow.IsNewRow)
            {
                SanPhamGia spg = new SanPhamGia();
                spg.MaMau_K = grid.CurrentRow.Cells["MaMau"].Value.ToString();
                spg.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                lstMaSP.Remove(spg);
                grid.Rows.Remove(grid.CurrentRow);
            }
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
                return;
            if (grid.Columns["GiaBan"].Index == e.ColumnIndex || grid.Columns["SoLuong"].Index == e.ColumnIndex)
            {
                decimal gianhap = 0;
                decimal soluong = 0;
                try
                {
                    if (grid.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString() != "")
                    {
                        gianhap = Decimal.Parse(grid.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString());
                    }
                }
                catch (Exception)
                {
                    grid.Rows[e.RowIndex].Cells["GiaBan"].Value = 0;
                }
                try
                {
                    if (grid.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString() != "")
                    {
                        soluong = Decimal.Parse(grid.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString());
                    }
                }
                catch (Exception)
                {
                    grid.Rows[e.RowIndex].Cells["SoLuong"].Value = 1;
                }

                grid.Rows[e.RowIndex].Cells["ThanhTien"].Value = soluong * gianhap;
                TongCong();
            }
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (txtPO.Text == "")
            {
                PublicFunction.ShowWarning("PO không được để trống.");
                txtPO.Focus();
                return;
            }
            if (txtShipper.Text == "")
            {
                PublicFunction.ShowWarning("Shipper không được để trống.");
                txtShipper.Focus();
                return;
            }
            if (txtAddS.Text == "")
            {
                PublicFunction.ShowWarning("Add không được để trống.");
                txtAddS.Focus();
                return;
            }
            if (txtTerm.Text == "")
            {
                PublicFunction.ShowWarning("Term không được để trống.");
                txtTerm.Focus();
                return;
            }
            if (txtShipFrom.Text == "")
            {
                PublicFunction.ShowWarning("ShipFrom không được để trống.");
                txtShipFrom.Focus();
                return;
            }
            if (txtContainerNo.Text == "")
            {
                PublicFunction.ShowWarning("ContainerNo không được để trống.");
                txtContainerNo.Focus();
                return;
            }
            if (txtSealNo.Text == "")
            {
                PublicFunction.ShowWarning("SealNo không được để trống.");
                txtSealNo.Focus();
                return;
            }
            if (grid.RowCount == 0)
            {
                PublicFunction.ShowWarning("Bạn chưa nhập sản phẩm.");
                return;
            }
            if (PublicFunction.ShowQuestionSave() == DialogResult.Yes)

                try
                {
                    _db.BeginTransaction();
                    _db.ExecuteNonQuery(string.Format("delete from Packinglist2 where PackNo='{0}' ", txtPO.Text));
                    Packinglist pl = new Packinglist();
                    pl.PackNo_K = txtPO.Text;
                    pl.Shipper = txtShipper.Text;
                    pl.Address = txtAddS.Text;
                    pl.Consignee = txtConsignee.Text;
                    pl.AddC = txtAddC.Text;
                    pl.Paymentterm = "";
                    pl.DeliveryAddress = txtDelivery.Text;
                    pl.AddD = txtAddD.Text;
                    pl.Term = txtTerm.Text;
                    pl.ShipmentFrom = txtShipFrom.Text;
                    pl.ShipmentTo = txtShipTo.Text;
                    if (dtpETD.Checked == true)
                    {
                        pl.ETD = PublicFunction.GetStartDate(dtpETD.Value);
                    }
                    pl.ShippingAgent = txtShipAgent.Text;
                    pl.BLNumber = txtBLNumber.Text;
                    pl.ContainerNumber = txtContainerNo.Text;
                    pl.SealNumber = txtSealNo.Text;
                    pl.FeederVesselName = txtVessel.Text;
                    pl.PLDate =PublicFunction.GetStartDate( dtpThang.Value);
                    pl.PackinglistNumber = txtPLNumber.Text;
                    if (_db.ExistObject(pl))
                        _db.Update(pl);
                    else
                        _db.Insert(pl);
                    foreach (DataGridViewRow r in grid.Rows)
                    {
                        Packinglist2 obj = new Packinglist2();
                        obj.PackNo_K = txtPO.Text;
                        obj.MaSP_K = r.Cells["MaSP"].Value.ToString();
                        obj.MaMau_K = r.Cells["MaMau"].Value.ToString();
                        obj.TenSP = r.Cells["TenSP"].Value.ToString();
                        obj.TenDVT = r.Cells["TenDVT"].Value.ToString();
                        obj.SoLuong = Convert.ToInt32(r.Cells["SoLuong"].Value);
                        obj.GiaBan = Convert.ToDecimal(r.Cells["GiaBan"].Value);
                        obj.ThanhTien = Convert.ToDecimal(r.Cells["ThanhTien"].Value);
                        obj.W = Convert.ToInt16(r.Cells["W"].Value);
                        obj.L = Convert.ToInt16(r.Cells["L"].Value);
                        obj.H = Convert.ToInt16(r.Cells["H"].Value);
                        obj.CanNang = Convert.ToInt16(r.Cells["CanNang"].Value);
                        _db.Insert(obj);                       
                    }
                    PublicFunction.ShowSuccess();
                    _db.Commit();
                }
                catch (Exception ex)
                {
                    _db.RollBack();
                    PublicFunction.ShowError(ex, "Save", Name);
                }
        }

        private void FrmPackinglist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtPO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPO.Text != "")
                {
                    LoadPackinglist();
                }
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.No)
                    return;
                _db.BeginTransaction();
                Packinglist pl = new Packinglist();
                pl.PackNo_K = txtPO.Text;
                _db.Delete(pl);
                _db.ExecuteNonQuery(string.Format("delete from Packinglist2 where PackNo='{0}' ", pl.PackNo_K));
                _db.Commit();
                PublicFunction.ShowSuccess();
            }catch (Exception ex)
            {
                _db.RollBack();
                PublicFunction.ShowError(ex, "Xoa", Name);
            }
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            FrmPackinglistMaster frm = new FrmPackinglistMaster();
            frm._chon = true;
            frm._PackNo = "";
            frm.ShowDialog();
            txtPO.Text = frm._PackNo;
            LoadPackinglist();
        }

        private void bdn_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            grid.Columns["SoLuong"].ReadOnly = !grid.Columns["SoLuong"].ReadOnly;
            grid.Columns["GiaBan"].ReadOnly = !grid.Columns["GiaBan"].ReadOnly;
        }

    }
}
