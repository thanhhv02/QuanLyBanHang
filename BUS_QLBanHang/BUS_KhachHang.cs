
using System.Data;
using DAL_QLBanHang;
using DTO_QlBanHang;

namespace BUS_QLBanHang
{
    public class BUS_KhachHang
    {
        DAL_KhachHang DAL_KhachHang = new DAL_KhachHang();
        public DataTable getKhachHang()//danh sach khach hang
        {
            return DAL_KhachHang.GetKhachHang();
        }
        public bool InsertKhachHang(DTO_KhachHang kh)
        {
            return DAL_KhachHang.InsertKhachHang(kh);
        }
        public bool UpdateKhachHang(DTO_KhachHang kh)
        {
            return DAL_KhachHang.UpdateKhachHang(kh);
        }
        public bool DeleteKhachHang(string SDT)
        {
            return DAL_KhachHang.DeleteNhanVien(SDT);
        }
        public DataTable SearchKhach(string SDT)
        {
            return DAL_KhachHang.SearchKhachHang(SDT);
        }
    }
}
