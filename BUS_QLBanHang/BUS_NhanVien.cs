using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO_QlBanHang;
using DAL_QLBanHang;

namespace BUS_QLBanHang
{
    public class BUS_NhanVien
    {
       
        

        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return DAL_NhanVien.NhanVienDangNhap(nv);
        }
        public bool NhanVienQuenMatKhau(string email)
        {
            return DAL_NhanVien.NhanVienQuenMatKhau(email);
        }
        public bool TaoMatKhau(string email, string matKhauMoi)
        {
            return DAL_NhanVien.TaoMatKhau(email,matKhauMoi);
        }

        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            // gui password vaof encrypted data
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            // tao moi chuoi bang cach dung encrypted data
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();

        }
    }
}
