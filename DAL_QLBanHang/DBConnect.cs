using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QlBanHang;
using System.Data;
using System.Configuration;

namespace DAL_QLBanHang
{
    public class DBConnect
    {
        //protected static SqlConnection _conn = new SqlConnection(@"Data Source=VANTHANH\VANTHANH;Initial Catalog=QuanLyBanHang;Integrated Security=True");
        //protected static SqlConnection _conn = new SqlConnection(@"Data Source=VANTHANH\VANTHANH;AttachDbFileName=|DataDirectory|\QuanLyBanHang.mdf;Integrated Security=True");
        static string contr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
        protected SqlConnection _conn = new SqlConnection(contr);
    }
}
