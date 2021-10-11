using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QlBanHang
{
    public class DTO_NhanVien
    {
        private int ID;
        private string maNV;
        private string tenNhanVien;
        private string diaChi;
        private int vaiTro;
        private string emailNV;
        private string matKhau;
        private int tinhTrang;
        private string StatementType;


        public DTO_NhanVien(string tenNhanVien, string diaChi, int vaiTro, string emailNV, string matKhau, int tinhTrang, string statementtype)
        {
            this.tenNhanVien = tenNhanVien;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.emailNV = emailNV;
            this.matKhau = matKhau;
            this.tinhTrang = tinhTrang;
            this.StatementType = statementtype;
        }
        public DTO_NhanVien(string tenNhanVien, string diaChi, int vaiTro, string emailNV, int tinhtrang, string statementtype)
        {
            this.tenNhanVien = tenNhanVien;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.emailNV = emailNV;
            this.tinhTrang = tinhtrang;
            this.StatementType = statementtype;
        }

        public DTO_NhanVien(string statementtype)
        {
            this.StatementType = statementtype;
        }
        public DTO_NhanVien()
        {
        }

        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int VaiTro { get => vaiTro; set => vaiTro = value; }
        public string EmailNV { get => emailNV; set => emailNV = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string StatementType1 { get => StatementType; set => StatementType = value; }
    }
}
