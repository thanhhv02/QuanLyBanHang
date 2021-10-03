using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QlBanHang
{
    class DTO_KhachHang
    {
        private string dienThoai;
        private string tenKhach;
        private string diaChi;
        private string phai;
        private string emailnv;

        public DTO_KhachHang()
        {
        }

        public DTO_KhachHang(string dienThoai, string tenKhach, string diaChi, string phai)
        {
            this.dienThoai = dienThoai;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.phai = phai;
        }

        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Phai { get => phai; set => phai = value; }
    }
}
