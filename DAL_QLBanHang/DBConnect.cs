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
    public class DBConnect
    {
        protected static SqlConnection _conn = new SqlConnection(@"Data Source=VANTHANH\VANTHANH;Initial Catalog=QuanLyBanHang;Integrated Security=True");
    }
}
