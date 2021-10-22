using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_QLBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QlBanHang;
using BUS_QLBanHang;
namespace DAL_QLBanHang.Tests
{
    [TestClass()]
    public class DAL_NhanVienTests
    {
        [TestMethod()]
        public void NhanVienLogin01()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            BUS_NhanVien login = new BUS_NhanVien();
            nv.EmailNV = "";
            nv.MatKhau = "abcd";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void NhanVienLogin02()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            BUS_NhanVien login = new BUS_NhanVien();
            nv.EmailNV = "a@a";
            nv.MatKhau = "5678";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void InsertNhanVienThanhCong()
        {
            DTO_NhanVien nv = new DTO_NhanVien("A", "Lam Dong", 0, "thanhhvps16867@fpt.edu.vn", 1, "insert");
            DAL_NhanVien insert = new DAL_NhanVien();
            bool result = insert.InsertNhanVien(nv);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void InsertNhanVienThatBai()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien insert = new DAL_NhanVien();
            //nv.EmailNV = "hovanthanh12102002@gmail.com";
            nv.TenNhanVien = "b";
            nv.VaiTro = 0;
            nv.TinhTrang = 1;
            nv.DiaChi = "Lam Dong";
            bool result = insert.InsertNhanVien(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void InsertKhachThanhCong()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang insert = new DAL_KhachHang();
            kh.DienThoai = "01238623234";
            kh.TenKhach = "a";
            kh.DiaChi = "Lam Dong";
            kh.Phai = "Nam";
            kh.Emailnv = "a@a";
            kh.StatementType = "insert";
            bool result = insert.InsertKhachHang(kh);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void InsertKhachThatBai()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang insert = new DAL_KhachHang();
            //kh.DienThoai = "012386232";
            kh.TenKhach = "a";
            kh.DiaChi = "Lam Dong";
            kh.Phai = "Nam";
            kh.Emailnv = "a@a";
            kh.StatementType = "insert";
            bool result = insert.InsertKhachHang(kh);
            Assert.IsFalse(result);
        }
    }
}