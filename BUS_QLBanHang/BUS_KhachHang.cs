using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public bool InsertNhanVien(DTO_KhachHang kh)
        {
            return DAL_KhachHang.InsertKhachHang(kh);
        }
        public bool UpdateKhachHang(DTO_KhachHang kh)
        {
            return DAL_KhachHang.UpdateKhachHang(kh);
        }
        //public bool DeleteNhanVien(string email)
        //{
        //    return dalnhanvien.DeleteNhanVien(email);
        //}
    }
}
