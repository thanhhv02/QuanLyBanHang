using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO_QlBanHang;
using DAL_QLBanHang;
using System.Data;

namespace BUS_QLBanHang
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalnhanvien = new DAL_NhanVien();
        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            return dalnhanvien.InsertNhanVien(nv);
        }
        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            return dalnhanvien.UpdateNhanVien(nv);
        }
        public bool DeleteNhanVien(string email)
        {
            return dalnhanvien.DeleteNhanVien(email);
        }
        public DataTable SearchNhanVien(string tenNV)
        {
            return dalnhanvien.SearchNhanVien(tenNV);
        }
        public DataTable getNhanVien()//danh sach nhan vien
        {
            return dalnhanvien.getNhanVien();
        }
        public bool NhanVienDangNhap(DTO_NhanVien nv)//nhan vien dang nhap
        {
            return dalnhanvien.NhanVienDangNhap(nv);
        }
        public bool NhanVienQuenMatKhau(string email)//nhan vien quen mat khau
        {
            return dalnhanvien.NhanVienQuenMatKhau(email);
        }
        public bool TaoMatKhau(string email, string matKhauMoi)// tao mat khau moi
        {
            return dalnhanvien.TaoMatKhau(email,matKhauMoi);
        }
        public DataTable VaiTroNhanVien(string email)// voa tro nhan vien
        {
            return dalnhanvien.VaiTroNhanVien(email);
        }
        public bool NhanVienDoiMatKhau(string email,string matKhauCu, string matKhauMoi)// tao mat khau moi
        {
            return dalnhanvien.NhanVienDoiMatKhau(email, matKhauCu, matKhauMoi);
        }
        public string encryption(string password)// ma hoa
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
    }
}
