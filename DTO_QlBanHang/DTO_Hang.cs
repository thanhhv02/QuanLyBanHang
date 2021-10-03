using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QlBanHang
{
    class DTO_Hang
    {
        private int maHang;
        private string tenHang;
        private int soLuong;
        private float donGiaBan;
        private float donGiaNhap;
        private string hinhAnh;
        private string ghiChu;
        private string emailNV;

        public DTO_Hang()
        {
        }

        public DTO_Hang(int maHang, string tenHang, int soLuong, float donGiaBan, float donGiaNhap, string hinhAnh, string ghiChu)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGiaBan = donGiaBan;
            this.donGiaNhap = donGiaNhap;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
        }

        public int MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public float DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
