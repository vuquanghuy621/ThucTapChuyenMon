using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalHoaDonBan
    {
        public static string LayMaHoaDon(DateTime thoiGianThem)
        {
            string sqlQuery = "SELECT maHoaDon FROM dbo.HoaDonBan WHERE thoiGianThem = @thoiGianThem";
            SqlParameter sqlParameter = new SqlParameter("@thoiGianThem", thoiGianThem);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LayMaBan(DateTime thoiGianThem)
        {
            string sqlQuery = "SELECT maBan FROM dbo.HoaDonBan WHERE thoiGianThem = @thoiGianThem";
            SqlParameter sqlParameter = new SqlParameter("@thoiGianThem", thoiGianThem);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static DateTime LayThoiGianBatDau(DateTime thoiGianThem)
        {
            string sqlQuery = "SELECT thoiGianBatDau FROM dbo.HoaDonBan WHERE thoiGianThem = @thoiGianThem";
            SqlParameter sqlParameter = new SqlParameter("@thoiGianThem", thoiGianThem);
            return Convert.ToDateTime(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static DateTime LayThoiGianKetThuc(DateTime thoiGianThem)
        {
            string sqlQuery = "SELECT thoiGianKetThuc FROM dbo.HoaDonBan WHERE thoiGianThem = @thoiGianThem";
            SqlParameter sqlParameter = new SqlParameter("@thoiGianThem", thoiGianThem);
            return Convert.ToDateTime(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool Them(DtoHoaDonBan dtoHoaDonBan)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.HoaDonBan (thoiGianThem, maHoaDon, maBan, gia, thoiGianBatDau, thoiGianKetThuc) " +
                    "VALUES (@thoiGianThem, @maHoaDon, @maBan, @gia, @thoiGianBatDau, @thoiGianKetThuc)";
                SqlParameter[] sqlParameters = new SqlParameter[6];
                sqlParameters[0] = new SqlParameter("@thoiGianThem", dtoHoaDonBan.ThoiGianThem);
                sqlParameters[1] = new SqlParameter("@maHoaDon", dtoHoaDonBan.MaHoaDon);
                sqlParameters[2] = new SqlParameter("@maBan", dtoHoaDonBan.MaBan);
                sqlParameters[3] = new SqlParameter("@gia", dtoHoaDonBan.Gia);
                sqlParameters[4] = new SqlParameter("@thoiGianBatDau", dtoHoaDonBan.ThoiGianBatDau);
                sqlParameters[5] = new SqlParameter("@thoiGianKetThuc", dtoHoaDonBan.ThoiGianKetThuc);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SuaMaBan(string maBan, DateTime thoiGianThem)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.HoaDonBan " +
                    "SET maBan = @maBan " +
                    "WHERE thoiGianThem = @thoiGianThem";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@thoiGianThem", thoiGianThem);
                sqlParameters[1] = new SqlParameter("@maBan", maBan);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SuaThoiGianBatDau(DateTime thoiGianBatDau, DateTime thoiGianThem)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.HoaDonBan " +
                    "SET thoiGianBatDau = @thoiGianBatDau " +
                    "WHERE thoiGianThem = @thoiGianThem";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@thoiGianThem", thoiGianThem);
                sqlParameters[1] = new SqlParameter("@thoiGianBatDau", thoiGianBatDau);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SuaThoiGianKetThuc(DateTime thoiGianKetThuc, DateTime thoiGianThem)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.HoaDonBan " +
                    "SET thoiGianKetThuc = @thoiGianKetThuc " +
                    "WHERE thoiGianThem = @thoiGianThem";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@thoiGianThem", thoiGianThem);
                sqlParameters[1] = new SqlParameter("@thoiGianKetThuc", thoiGianKetThuc);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Xoa(DateTime thoiGianThem)
        {
            try
            {
                string sqlQuery = "DELETE dbo.HoaDonBan WHERE thoiGianThem = @thoiGianThem";
                SqlParameter sqlParameter = new SqlParameter("@thoiGianThem", thoiGianThem);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DateTime LayThoiGianBatDauSuDung(string maBan)
        {
            string sqlQuery = "SELECT thoiGianBatDau " +
                "FROM dbo.HoaDonBan " +
                "WHERE maBan = @maBan " +
                "AND thoiGianBatDau = thoiGianKetThuc";
            SqlParameter sqlParameter = new SqlParameter("@maBan", maBan);
            return Convert.ToDateTime(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LayMaHoaDonDangSuDung(string maBan)
        {
            string sqlQuery = "SELECT maHoaDon FROM dbo.HoaDonBan WHERE maBan = @maBan AND thoiGianThem = (SELECT MAX(thoiGianThem) FROM dbo.HoaDonBan WHERE maBan = @maBan)";
            SqlParameter sqlParameter = new SqlParameter("@maBan", maBan);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static DateTime LayThoiGianThemMoiNhat(string maHoaDon)
        {
            string sqlQuery = "SELECT MAX(thoiGianThem) FROM dbo.HoaDonBan WHERE maHoaDon = @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToDateTime(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }
    }
}
