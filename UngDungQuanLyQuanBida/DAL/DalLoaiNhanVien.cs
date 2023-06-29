using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalLoaiNhanVien
    {
        public static string LayTenLoaiNhanVien(string maLoaiNhanVien)
        {
            string sqlQuery = "SELECT tenLoaiNhanVien FROM dbo.LoaiNhanVien WHERE maLoaiNhanVien = @maLoaiNhanVien";
            SqlParameter sqlParameter = new SqlParameter("@maLoaiNhanVien", maLoaiNhanVien);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static DataTable GetDataSourceForComboBox()
        {
            string sqlQuery = "SELECT maLoaiNhanVien, tenLoaiNhanVien FROM dbo.LoaiNhanVien";
            return Helper.ExecuteQuery(sqlQuery);
        }
    }
}
