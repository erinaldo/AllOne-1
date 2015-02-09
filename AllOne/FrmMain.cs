using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CommonDB;
using System.Diagnostics;
using AllOne.TinhLuong;
using AllOne.Packing;
using WeifenLuo.WinFormsUI.Docking;
using AllOne.NhapXuatTon;
using AllOne.ThietLap;
using AllOne.DanhSach;

namespace AllOne
{
    public partial class FrmMain : Form
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)

        {
        //    if (e.KeyCode == Keys.F1 && bttHuongDan.Enabled)
        //    {
        //        bttHuongDan.PerformClick();
        //    }
        //    if (e.KeyCode == Keys.F2 && bttThietLap.Enabled)
        //    {
        //        bttThietLap.PerformClick();
        //    }
        //    if (e.KeyCode == Keys.F3 && bttKhachHang.Enabled)
        //    {
        //        bttKhachHang.PerformClick();
        //    }
        //    if (e.KeyCode == Keys.F4 && bttTinhLuong.Enabled)
        //    {
        //        bttTinhLuong.PerformClick();
        //    }
        //    if (e.KeyCode == Keys.F5 && bttBaoGia.Enabled)
        //    {
        //        bttBaoGia.PerformClick();
        //    }
        //    if (e.KeyCode == Keys.F6 && bttXuatNhapTon.Enabled)
        //    {
        //        bttXuatNhapTon.PerformClick();
        //    }
        //    if (e.KeyCode == Keys.F7 && bttPackinglist.Enabled)
        //    {
        //        bttPackinglist.PerformClick();
        //    }
        //    if (e.KeyCode == Keys.F8 && bttThuNho.Enabled)
        //    {
        //        bttThuNho.PerformClick();
        //    }
        //    if (e.KeyCode==Keys.F9 && bttThoat.Enabled)
        //    {
        //        bttThoat.PerformClick();
        //    }
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình ?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void bttThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //if (this.FormBorderStyle==System.Windows.Forms.FormBorderStyle.Sizable)
            //{
            //    this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            //}else
            //{
            //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //}
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            //Console.WriteLine(VNCurrency.ConvertNumberToStringUSD("12554.82",false));
            //Console.WriteLine(VNCurrency.ConvertNumberToStringUSD("13232",false));

            //txtNhanVien.Text = PublicUtility.CurrentUser.UserName;

            CongTy obj = new CongTy();
            obj.MaCT_K = "01";
            _db.GetObject(ref obj);
            CurrentSetting.MaTienTe = obj.MaTienTe;
            CurrentSetting.TenCongTy = obj.TenCongTy;
            CurrentSetting.DiaChi = obj.DiaChi;
            CurrentSetting.DienThoai = obj.DienThoai;
            CurrentSetting.MST = obj.MaSoThue;
            CurrentSetting.Fax = obj.Fax;

            TyGiaQuyDoi objgia = new TyGiaQuyDoi();
            objgia.Thang_K = DateTime.Now.ToString("yyyyMM");
            objgia.MaTienTe_K = "USD";
            if (_db.ExistObject(objgia)){            
                _db.GetObject(ref objgia);
                CurrentSetting.TyGiaUSD = objgia.TyGia;
            }
            else
            {
                PublicFunction.ShowWarning(string.Format("Bạn chưa nhập tỷ giá tháng {0}. ",
                                            DateTime.Now.ToString("yyyyMM")));
            }

            //bttPackinglist.Enabled = false;
            //bttXuatNhapTon.Enabled = false;
            //bttTinhLuong.Enabled = false;
            //bttBaoGia.Enabled = false;
            //bttKhachHang.Enabled = false;
            //bttThietLap.Enabled = false;
            //bttHuongDan.Enabled = true;
            if (PublicUtility.CurrentUser.UserName.ToLower() != "admin")
            {
                if (!CurrentSetting.User.Packing)
                    naviBar2.Bands.Remove(navPacking);
                if (!CurrentSetting.User.NhapXuatTon)
                    naviBar2.Bands.Remove(navNhapXuat);
                if (!CurrentSetting.User.TinhLuong)
                    naviBar2.Bands.Remove(navTinhLuong);
                if (!CurrentSetting.User.BaoGia)
                    naviBar2.Bands.Remove(navBaoGia);
                if (!CurrentSetting.User.KhachHang)
                    naviBar2.Bands.Remove(navKhachHang);
                if (!CurrentSetting.User.DanhMuc)
                    naviBar2.Bands.Remove(navThietLap);
            }
            else
            {
                
            }

            int trialday = 90;
            License objLS = new License();
            objLS.ID_K = "01";
            if (_db.ExistObject(objLS))
            {
                _db.GetObject(ref objLS);
                if (objLS.Active && PublicFunction.DecryptPassword(objLS.Key) == CurrentSetting.Password)
                {
                    //bttDangKy.Visible = false;
                    //lblStatusLicense.Text = "Đã đăng ký";
                }
                else
                {
                    //bttDangKy.Visible = true;
                    //lblStatusLicense.Text = string.Format("Dùng thử {0} ngày", (trialday - (DateTime.Now - objLS.Entrydate).Days));
                    if ((trialday - (DateTime.Now - objLS.Entrydate).Days)<0)
                    {
                        PublicFunction.ShowWarning("Đã hết hạn sử dụng. Vui lòng đăng ký để sử dụng tiếp.");
                        FrmDangKy frm = new FrmDangKy();
                        frm.ShowDialog();
                    }
                }
            }else
            {
                objLS.ID_K = "01";
                objLS.Key = "";
                objLS.Entrydate = DateTime.Now;
                objLS.Active = true;
                _db.Insert(objLS);

                //bttDangKy.Visible = true;
                //lblStatusLicense.Text = string.Format("Dùng thử {0} ngày",  (trialday-(DateTime.Now-objLS.Entrydate).Days));
            }


            naviBar2.ActiveBand = navPacking;
        }
       

        private void FrmMain_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkHDSD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + "\\HDSD chương trình AllOne.docx");
            }catch (Exception )
            {

            }
        }

         private void bttPackinglist_Click(object sender, EventArgs e)
        {
            FrmPackinglist frm = new FrmPackinglist();
            foreach (DockContent dock in dockPanel1.Documents)
            {
                if (dock.Name == frm.Name)
                {
                    dock.Activate();
                    return;
                }
            }
          frm.Show(dockPanel1, DockState.Document);
        }

         private void bttPallet_Click(object sender, EventArgs e)
         {
             FrmPallet frm = new FrmPallet();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }

             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttGPacking_Click(object sender, EventArgs e)
         {
             FrmPackinglistMaster frm = new FrmPackinglistMaster();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttPalletList_Click(object sender, EventArgs e)
         {
             FrmPalletList frm = new FrmPalletList();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttColor_Click(object sender, EventArgs e)
         {
             FrmColor frm = new FrmColor();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttNhapKho_Click(object sender, EventArgs e)
         {
             FrmPhieuNhap frm = new FrmPhieuNhap();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttChuyenKho_Click(object sender, EventArgs e)
         {
             FrmChuyenKho frm = new FrmChuyenKho();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttXuatKho_Click(object sender, EventArgs e)
         {
             FrmPhieuXuat frm = new FrmPhieuXuat();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttTon_Click(object sender, EventArgs e)
         {
             FrmTonKho frm = new FrmTonKho();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttKiemKe_Click(object sender, EventArgs e)
         {
             FrmKiemKe frm = new FrmKiemKe();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttTimKiemNX_Click(object sender, EventArgs e)
         {
             FrmTimKiemNX frm = new FrmTimKiemNX();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttDuToan_Click(object sender, EventArgs e)
         {
             FrmDuToan frm= new FrmDuToan();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttBOM_Click(object sender, EventArgs e)
         {
             FrmBOM frm = new FrmBOM();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttTínhBaoGia_Click(object sender, EventArgs e)
         {
             FrmTinhBaoGia frm= new FrmTinhBaoGia();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttBaoGia_Click(object sender, EventArgs e)
         {
             FrmBaoGia frm= new FrmBaoGia();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttSSBOM_Click(object sender, EventArgs e)
         {
             FrmSoSanhBOM frm = new FrmSoSanhBOM();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttNhanVien_Click(object sender, EventArgs e)
         {
             FrmNhanVien frm = new FrmNhanVien(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttTangCa_Click(object sender, EventArgs e)
         {
             FrmTangCa frm  = new FrmTangCa(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttChamCong_Click(object sender, EventArgs e)
         {
             FrmChamCong frm  = new FrmChamCong(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttKhachHang_Click_1(object sender, EventArgs e)
         {
             FrmMSKhachHang frm = new FrmMSKhachHang(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttNhomKH_Click(object sender, EventArgs e)
         {
             FrmMSNhomKH frm = new FrmMSNhomKH();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttNCC_Click(object sender, EventArgs e)
         {
             FrmNhaCungCap frm = new FrmNhaCungCap();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttNguyenLieu_Click(object sender, EventArgs e)
         {
             FrmNguyenLieu frm = new FrmNguyenLieu();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttNhomNL_Click(object sender, EventArgs e)
         {
             FrmNhomNL frm = new FrmNhomNL(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttSanPham_Click(object sender, EventArgs e)
         {
             FrmSanPham frm = new FrmSanPham(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttNhomSP_Click(object sender, EventArgs e)
         {
             FrmNhomSP frm = new FrmNhomSP(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttDVT_Click(object sender, EventArgs e)
         {
             FrmDonViTinh frm = new FrmDonViTinh(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttKho_Click_1(object sender, EventArgs e)
         {
             FrmDSKho frm = new FrmDSKho(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttTyGia_Click(object sender, EventArgs e)
         {
             FrmTyGia frm = new FrmTyGia(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttTaiKhoan_Click(object sender, EventArgs e)
         {
             FrmTaiKhoan frm = new FrmTaiKhoan(); 
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttThietLapChung_Click(object sender, EventArgs e)
         {
             FrmThietLapChung frm= new FrmThietLapChung();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void naviBar2_ActiveBandChanged(object sender, EventArgs e)
         {
             if (naviBar2.ActiveBand == navHuongDan)
             {
                 FrmHuongDan frm = new FrmHuongDan();
                 foreach (DockContent dock in dockPanel1.Documents)
                 {
                     if (dock.Name == frm.Name)
                     {
                         dock.Activate();
                         return;
                     }
                 }
                 frm.Show(dockPanel1, DockState.Document);
             }

         }

         private void bttGiaGach_Click(object sender, EventArgs e)
         {
             FrmGiaGach frm = new FrmGiaGach();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttTienGach_Click(object sender, EventArgs e)
         {
             FrmTienGach frm = new FrmTienGach();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }

         private void bttInvoice_Click(object sender, EventArgs e)
         {
             FrmInvoice frm = new FrmInvoice();
             foreach (DockContent dock in dockPanel1.Documents)
             {
                 if (dock.Name == frm.Name)
                 {
                     dock.Activate();
                     return;
                 }
             }
             frm.Show(dockPanel1, DockState.Document);
         }


    }
}
