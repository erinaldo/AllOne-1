using System; 
 public class SanPhamGia:IEquatable<SanPhamGia>
 {
     public  string  MaSP_K ; 
     public  string  MaMau_K ;
     public bool Equals(SanPhamGia other)
     {
         if (this.MaMau_K == other.MaMau_K && this.MaSP_K == other.MaSP_K)
         {
             return true;
         }
         else
         {
             return false;
         }
     }
 }
