using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QlBanHang;
using System.Data;


namespace DAL_QLBanHang
{
    public class DAL_NhanVien : DBConnect
    {
        
        public DataTable getNhanVien()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetNhanVien";
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;
            }

            finally
            {
                _conn.Close();
            }
        }
        public bool InsertNhanVien(DTO_NhanVien nv)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_NhanVienInsertUpdate";
                cmd.Parameters.AddWithValue("email", nv.EmailNV);
                cmd.Parameters.AddWithValue("tennv", nv.TenNhanVien);
                cmd.Parameters.AddWithValue("diachi", nv.DiaChi);
                cmd.Parameters.AddWithValue("vaitro", nv.VaiTro);
                cmd.Parameters.AddWithValue("tinhtrang", nv.TinhTrang);
                cmd.Parameters.AddWithValue("StatementType", nv.StatementType1);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool UpdateNhanVien(DTO_NhanVien nv)//update nhan vien
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_NhanVienInsertUpdate";
                cmd.Parameters.AddWithValue("email", nv.EmailNV);
                cmd.Parameters.AddWithValue("tennv", nv.TenNhanVien);
                cmd.Parameters.AddWithValue("diachi", nv.DiaChi);
                cmd.Parameters.AddWithValue("vaitro", nv.VaiTro);
                cmd.Parameters.AddWithValue("tinhtrang", nv.TinhTrang);
                cmd.Parameters.AddWithValue("StatementType", nv.StatementType1);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeleteNhanVien(string email)//delete nhan vien
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_XoaNhanVien";
                cmd.Parameters.AddWithValue("email", email);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable SearchNhanVien(string tenNV)//search nhan vien
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchNhanVien";
                cmd.Parameters.AddWithValue("tennv", tenNV);
                DataTable dtSearchNV = new DataTable();
                dtSearchNV.Load(cmd.ExecuteReader());
                return dtSearchNV;
            }

            finally
            {
                _conn.Close();
            }
        }

        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DangNhap";
                cmd.Parameters.AddWithValue("email", nv.EmailNV);
                cmd.Parameters.AddWithValue("matKhau", nv.MatKhau);
                if (Convert.ToInt64(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable VaiTroNhanVien(string email)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_VaiTroNhanVien";
                cmd.Parameters.AddWithValue("email", email);
                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;

            }

            finally
            {
                _conn.Close();
            }

        }
        public  bool NhanVienQuenMatKhau(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_QuenMatKhau";
                cmd.Parameters.AddWithValue("email", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool TaoMatKhau(string email, string matKhauMoi)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TaoMoiMatKhau";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matKhau", matKhauMoi);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
                
            }
            
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool NhanVienDoiMatKhau(string email, string matKhauCu, string matKhauMoi)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_updateUserPassword";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("oldHashedPassword", matKhauCu);
                cmd.Parameters.AddWithValue("newHashedPassword", matKhauMoi);
                if (Convert.ToInt64(cmd.ExecuteScalar()) > 0)
                    return true;
            }

            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
