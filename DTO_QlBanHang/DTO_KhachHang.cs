using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QlBanHang
{
    public class DTO_KhachHang
    {
        private string dienThoai;
        private string tenKhach;
        private string diaChi;
        private string phai;
        private string emailnv;
        private string statementType;
        public DTO_KhachHang()
        {
        }

        public DTO_KhachHang(string dienThoai, string tenKhach, string diaChi, string phai,string state)
        {
            this.dienThoai = dienThoai;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.phai = phai;
            this.statementType = state;
        }

        public DTO_KhachHang(string dienThoai, string tenKhach, string diaChi, string phai, string emailnv, string statementType)
        {
            this.dienThoai = dienThoai;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.phai = phai;
            this.Emailnv = emailnv;
            this.StatementType = statementType;
        }

        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Phai { get => phai; set => phai = value; }
        public string StatementType { get => statementType; set => statementType = value; }
        public string Emailnv { get => emailnv; set => emailnv = value; }
    }
}
