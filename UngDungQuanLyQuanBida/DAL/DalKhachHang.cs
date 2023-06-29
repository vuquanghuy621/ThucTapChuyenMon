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
    public class DalKhachHang
    {
        public static string LayHoVaTen(string soDienThoai)
        {
            string sqlQuery = "SELECT hoVaTen FROM dbo.KhachHang WHERE soDienThoai = @soDienThoai";
            SqlParameter sqlParameter = new SqlParameter("@soDienThoai", soDienThoai);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LayMaHangKhachHang(string soDienThoai)
        {
            string sqlQuery = "SELECT maHangKhachHang FROM dbo.KhachHang WHERE soDienThoai = @soDienThoai";
            SqlParameter sqlParameter = new SqlParameter("@soDienThoai", soDienThoai);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static DateTime LayNgayThoiGianThem(string soDienThoai)
        {
            string sqlQuery = "SELECT thoiGianThem FROM dbo.KhachHang WHERE soDienThoai = @soDienThoai";
            SqlParameter sqlParameter = new SqlParameter("@soDienThoai", soDienThoai);
            return Convert.ToDateTime(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool Them(DtoKhachHang dtoKhachHang)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.KhachHang (soDienThoai, hoVaTen, maHangKhachHang, thoiGianThem) " +
                    "VALUES (@soDienThoai, @hoVaTen, @maHangKhachHang, @thoiGianThem)";
                SqlParameter[] sqlParameters = new SqlParameter[4];
                sqlParameters[0] = new SqlParameter(@"soDienThoai", dtoKhachHang.SoDienThoai);
                sqlParameters[1] = new SqlParameter(@"hoVaTen", dtoKhachHang.HoVaTen);
                sqlParameters[2] = new SqlParameter(@"maHangKhachHang", dtoKhachHang.MaHangKhachHang);
                sqlParameters[3] = new SqlParameter(@"thoiGianThem", dtoKhachHang.ThoiGianThem);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Sua(DtoKhachHang dtoKhachHang)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.KhachHang " +
                    "SET hoVaTen = @hoVaTen " +
                    "WHERE soDienThoai = @soDienThoai";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"soDienThoai", dtoKhachHang.SoDienThoai);
                sqlParameters[1] = new SqlParameter(@"hoVaTen", dtoKhachHang.HoVaTen);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Xoa(string soDienThoai)
        {
            try
            {
                string sqlQuery = "DELETE dbo.KhachHang WHERE soDienThoai = @soDienThoai";
                SqlParameter sqlParameter = new SqlParameter("@soDienThoai", soDienThoai);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable LayDanhSachKhachHang()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachKhachHang";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static DataTable LayDanhSachKhachHang_timKiem(string tuKhoa)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachKhachHang_timKiem @tuKhoa";
            SqlParameter sqlParameter = new SqlParameter("@tuKhoa", tuKhoa);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static DataTable LayDanhSachKhachHang_maHangKhachHang(string maHangKhachHang)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachKhachHang_maHangKhachHang @maHangKhachHang";
            SqlParameter sqlParameter = new SqlParameter("@maHangKhachHang", maHangKhachHang);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static DataTable GetDataSourceForComboBox()
        {
            string sqlQuery = "SELECT soDienThoai, soDienThoai + N' | ' + hoVaTen AS khachHang FROM dbo.KhachHang UNION SELECT '0000000000', N'Khách lẻ'";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static bool KiemTraTrungSoDienThoai(string soDienThoai)
        {
            string sqlQuery = "SELECT * FROM dbo.KhachHang WHERE soDienThoai = @soDienThoai";
            SqlParameter sqlParameter = new SqlParameter("@soDienThoai", soDienThoai);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);
            return Convert.ToBoolean(dataTable.Rows.Count);
        }

        public static bool KiemTraXoaKhachHang(string soDienThoai)
        {
            string sqlQuery = "SELECT * FROM dbo.HoaDon WHERE soDienThoaiKhachHang = @soDienThoai";
            SqlParameter sqlParameter = new SqlParameter("@soDienThoai", soDienThoai);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);

            return !Convert.ToBoolean(dataTable.Rows.Count);
        }
    }
}
