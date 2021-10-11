using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QlBanHang;

namespace DAL_QLBanHang
{
    public class DAL_KhachHang : DBConnect
    {
        public DataTable GetKhachHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetKhachHang";
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;
            }

            finally
            {
                _conn.Close();
            }
        }
        public bool InsertKhachHang(DTO_KhachHang kh)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_KhachHangInsertUpdate";
                cmd.Parameters.AddWithValue("sdt", kh.DienThoai);
                cmd.Parameters.AddWithValue("ten", kh.TenKhach);
                cmd.Parameters.AddWithValue("diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("gioitinh", kh.Phai);
                cmd.Parameters.AddWithValue("nvemail", kh.Emailnv);
                cmd.Parameters.AddWithValue("StatementType", kh.StatementType);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool UpdateKhachHang(DTO_KhachHang kh)//update nhan vien
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_KhachHangInsertUpdate";
                cmd.Parameters.AddWithValue("sdt", kh.DienThoai);
                cmd.Parameters.AddWithValue("ten", kh.TenKhach);
                cmd.Parameters.AddWithValue("diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("gioitinh", kh.Phai);
                cmd.Parameters.AddWithValue("StatementType", kh.StatementType);
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

    }
}
