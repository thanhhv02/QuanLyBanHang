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
    public class DAL_Hang : DBConnect
    {
        public DataTable GetHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetHang";
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool InsertHang(DTO_Hang h)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_HangInsert";
                cmd.Parameters.AddWithValue("tenhang", h.TenHang);
                cmd.Parameters.AddWithValue("soluong", h.SoLuong);
                cmd.Parameters.AddWithValue("dongianhap", h.DonGiaNhap);
                cmd.Parameters.AddWithValue("dongiaban", h.DonGiaBan);
                cmd.Parameters.AddWithValue("hinh", h.HinhAnh);
                cmd.Parameters.AddWithValue("ghichu", h.GhiChu);
                cmd.Parameters.AddWithValue("email", h.EmailNV);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool UpdateHang(DTO_Hang h)//update hang
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_HangUpdate";
                cmd.Parameters.AddWithValue("mahang", h.MaHang);
                cmd.Parameters.AddWithValue("tenhang", h.TenHang);
                cmd.Parameters.AddWithValue("soluong", h.SoLuong);
                cmd.Parameters.AddWithValue("dongianhap", h.DonGiaNhap);
                cmd.Parameters.AddWithValue("dongiaban", h.DonGiaBan);
                cmd.Parameters.AddWithValue("hinh", h.HinhAnh);
                cmd.Parameters.AddWithValue("ghichu", h.GhiChu);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeleteHang(string maHang)//delete nhan vien
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_XoaHang";
                cmd.Parameters.AddWithValue("mahang", maHang);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable SearchHang(string tenHang)//search hang
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchHang";
                cmd.Parameters.AddWithValue("tenhang", tenHang);
                DataTable dtSearchNV = new DataTable();
                dtSearchNV.Load(cmd.ExecuteReader());
                return dtSearchNV;
            }

            finally
            {
                _conn.Close();
            }
        }
        public DataTable ThongKeSP()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ThongKeSP";
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;
            }

            finally
            {
                _conn.Close();
            }
        
        }
        public DataTable ThongKeTonKho()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ThongKeTonKho";
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;
            }

            finally
            {
                _conn.Close();
            }

        }
    }
}
