using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonDB;

namespace AllOne
{
    public static class CurrentSetting
    {
        public static PublicFunction.GiaBan GiaBan = PublicFunction.GiaBan.GiaBanLe;
        public static PublicFunction.HangHoa HangHoa = PublicFunction.HangHoa.SanPham;
        public static string MaTienTe="VND";
        public static decimal TyGiaVND = 1;
        public static decimal TyGiaUSD = 1;

        public static string TenCongTy = "";
        public static string DiaChi = "";
        public static string DienThoai = "";
        public static string MST = "";
        public static string Fax = "";
        public static TaiKhoan User=new TaiKhoan();

        public static string Password = "P@ssw0rdnittodenko@123";
        
    }
}
