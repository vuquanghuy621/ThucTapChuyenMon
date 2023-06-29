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
    public class DalBan
    {
        public static string LaySoBan()
        {
            string sqlQuery = "SELECT COUNT(maBan) FROM dbo.Ban";
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery));
        }

        public static string LaySoBanTrong()
        {
            string sqlQuery = "SELECT COUNT(maBan) FROM dbo.Ban WHERE trangThai = 0";
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery));
        }

        public static string LaySoBanCoKhach()
        {
            string sqlQuery = "SELECT COUNT(maBan) FROM dbo.Ban WHERE trangThai = 1";
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery));
        }

        public static string LayTenBan(string maBan)
        {
            string sqlQuery = "SELECT tenBan FROM dbo.Ban WHERE maBan = @maBan";
            SqlParameter sqlParameter = new SqlParameter("@maBan", maBan);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LayMaLoaiBan(string maBan)
        {
            string sqlQuery = "SELECT maLoaiBan FROM dbo.Ban WHERE maBan = @maBan";
            SqlParameter sqlParameter = new SqlParameter("@maBan", maBan);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LayMaKhuVuc(string maBan)
        {
            string sqlQuery = "SELECT maKhuVuc FROM dbo.Ban WHERE maBan = @maBan";
            SqlParameter sqlParameter = new SqlParameter("@maBan", maBan);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static long LayGia(string maBan)
        {
            string sqlQuery = "SELECT gia FROM dbo.Ban WHERE maBan = @maBan";
            SqlParameter sqlParameter = new SqlParameter("@maBan", maBan);
            return Convert.ToInt64(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool LayTrangThai(string maBan)
        {
            string sqlQuery = "SELECT trangThai FROM dbo.Ban WHERE maBan = @maBan";
            SqlParameter sqlParameter = new SqlParameter("@maBan", maBan);
            return Convert.ToBoolean(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool Them(DtoBan dtoBan)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.Ban (maBan, tenBan, maLoaiBan, maKhuVuc, gia, trangThai) " +
                    "VALUES (@maBan, @tenBan, @maLoaiBan, @maKhuVuc, @gia, @trangThai)";
                SqlParameter[] sqlParameters = new SqlParameter[6];
                sqlParameters[0] = new SqlParameter(@"maBan", dtoBan.MaBan);
                sqlParameters[1] = new SqlParameter(@"tenBan", dtoBan.TenBan);
                sqlParameters[2] = new SqlParameter(@"maLoaiBan", dtoBan.MaLoaiBan);
                sqlParameters[3] = new SqlParameter(@"maKhuVuc", dtoBan.MaKhuVuc);
                sqlParameters[4] = new SqlParameter(@"gia", dtoBan.Gia);
                sqlParameters[5] = new SqlParameter(@"trangThai", false);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Sua(DtoBan dtoBan)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.Ban " +
                    "SET tenBan = @tenBan, " +
                    "maLoaiBan = @maLoaiBan, " +
                    "maKhuVuc = @maKhuVuc, " +
                    "gia = @gia " +
                    "WHERE maBan = @maBan";
                SqlParameter[] sqlParameters = new SqlParameter[5];
                sqlParameters[0] = new SqlParameter(@"maBan", dtoBan.MaBan);
                sqlParameters[1] = new SqlParameter(@"tenBan", dtoBan.TenBan);
                sqlParameters[2] = new SqlParameter(@"maLoaiBan", dtoBan.MaLoaiBan);
                sqlParameters[3] = new SqlParameter(@"maKhuVuc", dtoBan.MaKhuVuc);
                sqlParameters[4] = new SqlParameter(@"gia", dtoBan.Gia);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SuaTrangThai(bool trangThai, string maBan)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.Ban " +
                    "SET trangThai = @trangThai " +
                    "WHERE maBan = @maBan";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"maBan", maBan);
                sqlParameters[1] = new SqlParameter(@"trangThai", trangThai);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Xoa(string maBan)
        {
            try
            {
                string sqlQuery = "DELETE dbo.Ban WHERE maBan = @maBan";
                SqlParameter sqlParameter = new SqlParameter("@maBan", maBan);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable LayDanhSachBan()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachBan";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static DataTable LayDanhSachBan_maLoaiBan(string maLoaiBan)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachBan_maLoaiBan @maLoaiBan";
            SqlParameter sqlParameter = new SqlParameter("@maLoaiBan", maLoaiBan);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static DataTable LayDanhSachBan_maKhuVuc(string maKhuVuc)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachBan_maKhuVuc @maKhuVuc";
            SqlParameter sqlParameter = new SqlParameter("@maKhuVuc", maKhuVuc);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }
        public static DataTable LayDanhSachBanTrong()
        {
            string sqlQuery = "SELECT maBan, tenBan FROM dbo.Ban WHERE trangThai = 0";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static bool KiemTraTonTaiMaBan(string maBan)
        {
            string sqlQuery = "SELECT * FROM dbo.Ban WHERE maBan = @maBan";
            SqlParameter sqlParameter = new SqlParameter("@maBan", maBan);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);
            return Convert.ToBoolean(dataTable.Rows.Count);
        }

        public static string TaoMaBanMoi()
        {
            string maBan = "";
            int i = 1;
            do
            {
                maBan = (i++).ToString("0000000000");
            } while (KiemTraTonTaiMaBan(maBan));
            return maBan;
        }

        public static bool KiemTraXoaBan(string maBan)
        {
            string sqlQuery = "SELECT * FROM dbo.HoaDonBan WHERE maBan = @maBan";
            SqlParameter sqlParameter = new SqlParameter("@maBan", maBan);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);

            return !Convert.ToBoolean(dataTable.Rows.Count);
        }
    }
}
