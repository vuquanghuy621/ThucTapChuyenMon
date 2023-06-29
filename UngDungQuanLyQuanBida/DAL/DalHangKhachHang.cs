using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalHangKhachHang
    {
        public static string LayTenHangKhachHang(string maHangKhachHang)
        {
            string sqlQuery = "SELECT tenHangKhachHang FROM dbo.HangKhachHang WHERE maHangKhachHang = @maHangKhachHang";
            SqlParameter sqlParameter = new SqlParameter("@maHangKhachHang", maHangKhachHang);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static long LayDoanhSoDatToi(string maHangKhachHang)
        {
            string sqlQuery = "SELECT doanhSoDatToi FROM dbo.HangKhachHang WHERE maHangKhachHang = @maHangKhachHang";
            SqlParameter sqlParameter = new SqlParameter("@maHangKhachHang", maHangKhachHang);
            return Convert.ToInt64(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static int LayKhuyenMai(string maHangKhachHang)
        {
            string sqlQuery = "SELECT khuyenMai FROM dbo.HangKhachHang WHERE maHangKhachHang = @maHangKhachHang";
            SqlParameter sqlParameter = new SqlParameter("@maHangKhachHang", maHangKhachHang);
            return Convert.ToInt32(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool Sua(DtoHangKhachHang dtoHangKhachHang)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.HangKhachHang " +
            "SET tenHangKhachHang = @tenHangKhachHang, " +
            "doanhSoDatToi = @doanhSoDatToi, " +
            "khuyenMai = @khuyenMai " +
            "WHERE maHangKhachHang = @maHangKhachHang;";
                SqlParameter[] sqlParameters = new SqlParameter[4];
                sqlParameters[0] = new SqlParameter(@"maHangKhachHang", dtoHangKhachHang.MaHangKhachHang);
                sqlParameters[1] = new SqlParameter(@"tenHangKhachHang", dtoHangKhachHang.TenHangKhachHang);
                sqlParameters[2] = new SqlParameter(@"doanhSoDatToi", dtoHangKhachHang.DoanhSoDatToi);
                sqlParameters[3] = new SqlParameter(@"khuyenMai", dtoHangKhachHang.KhuyenMai);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable LayDanhSachHangKhachHang()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachHangKhachHang";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static DataTable GetDataSourceForComboBox()
        {
            string sqlQuery = "SELECT maHangKhachHang, tenHangKhachHang FROM dbo.HangKhachHang";
            return Helper.ExecuteQuery(sqlQuery);
        }
    }
}
