using System.Data;
using DAL_QLBanHang;
using DTO_QlBanHang;

namespace BUS_QLBanHang
{
    public class BUS_Hang
    {
        DAL_Hang DAL_Hang = new DAL_Hang();
        public DataTable getHang()//danh sach hang
        {
            return DAL_Hang.GetHang();
        }
        public bool InsertHang(DTO_Hang h)
        {
            return DAL_Hang.InsertHang(h);
        }
        public bool UpdateHang(DTO_Hang h)
        {
            return DAL_Hang.UpdateHang(h);
        }
        public bool DeleteHang(string maHang)
        {
            return DAL_Hang.DeleteHang(maHang);
        }
        public DataTable SearchHang(string tenHang)
        {
            return DAL_Hang.SearchHang(tenHang);
        }
        public DataTable ThongKeSP()//danh sach hang
        {
            return DAL_Hang.ThongKeSP();
        }
        public DataTable ThongKeTonKho()//danh sach hang
        {
            return DAL_Hang.ThongKeTonKho();
        }
    }
}
