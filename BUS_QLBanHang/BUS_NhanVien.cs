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
        

        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return dalnhanvien.NhanVienDangNhap(nv);
        }
        public bool NhanVienQuenMatKhau(string email)
        {
            return dalnhanvien.NhanVienQuenMatKhau(email);
        }
        public bool TaoMatKhau(string email, string matKhauMoi)
        {
            return dalnhanvien.TaoMatKhau(email,matKhauMoi);
        }
        public DataTable VaiTroNhanVien(string email)
        {
            return dalnhanvien.VaiTroNhanVien(email);
        }

        public string encryption(string password)
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
