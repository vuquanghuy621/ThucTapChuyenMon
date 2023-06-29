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
    public class DalDichVu
    {
        public static string LayTenDichVu(string maDichVu)
        {
            string sqlQuery = "SELECT tenDichVu FROM dbo.DichVu WHERE maDichVu = @maDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maDichVu", maDichVu);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LayMaLoaiDichVu(string maDichVu)
        {
            string sqlQuery = "SELECT maLoaiDichVu FROM dbo.DichVu WHERE maDichVu = @maDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maDichVu", maDichVu);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static byte[] LayHinhAnh(string maDichVu)
        {
            string sqlQuery = "SELECT hinhAnh FROM dbo.DichVu WHERE maDichVu = @maDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maDichVu", maDichVu);
            return (byte[])(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static long LayGia(string maDichVu)
        {
            string sqlQuery = "SELECT gia FROM dbo.DichVu WHERE maDichVu = @maDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maDichVu", maDichVu);
            return Convert.ToInt64(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static DateTime LayThoiGianThem(string maDichVu)
        {
            string sqlQuery = "SELECT thoiGianThem FROM dbo.DichVu WHERE maDichVu = @maDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maDichVu", maDichVu);
            return Convert.ToDateTime(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool LayTrangThai(string maDichVu)
        {
            string sqlQuery = "SELECT trangThai FROM dbo.DichVu WHERE maDichVu = @maDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maDichVu", maDichVu);
            return Convert.ToBoolean(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool Them(DtoDichVu dtoDichVu)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.DichVu (maDichVu, tenDichVu, maLoaiDichVu, hinhAnh, gia, thoiGianThem, trangThai) " +
                    "VALUES (@maDichVu, @tenDichVu, @maLoaiDichVu, @hinhAnh, @gia, @thoiGianThem, @trangThai)";
                SqlParameter[] sqlParameters = new SqlParameter[7];
                sqlParameters[0] = new SqlParameter("@maDichVu", dtoDichVu.MaDichVu);
                sqlParameters[1] = new SqlParameter("@tenDichVu", dtoDichVu.TenDichVu);
                sqlParameters[2] = new SqlParameter("@maLoaiDichVu", dtoDichVu.MaLoaiDichVu);
                sqlParameters[3] = new SqlParameter("@hinhAnh", dtoDichVu.HinhAnh);
                sqlParameters[4] = new SqlParameter("@gia", dtoDichVu.Gia);
                sqlParameters[5] = new SqlParameter("@thoiGianThem", dtoDichVu.ThoiGianThem);
                sqlParameters[6] = new SqlParameter("@trangThai", dtoDichVu.TrangThai);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Sua(DtoDichVu dtoDichVu)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.DichVu " +
                    "SET tenDichVu = @tenDichVu, " +
                    "maLoaiDichVu = @maLoaiDichVu, " +
                    "hinhAnh = @hinhAnh, " +
                    "gia = @gia, " +
                    "trangThai = @trangThai " +
                    "WHERE maDichVu = @maDichVu";
                SqlParameter[] sqlParameters = new SqlParameter[6];
                sqlParameters[0] = new SqlParameter("@maDichVu", dtoDichVu.MaDichVu);
                sqlParameters[1] = new SqlParameter("@tenDichVu", dtoDichVu.TenDichVu);
                sqlParameters[2] = new SqlParameter("@maLoaiDichVu", dtoDichVu.MaLoaiDichVu);
                sqlParameters[3] = new SqlParameter("@hinhAnh", dtoDichVu.HinhAnh);
                sqlParameters[4] = new SqlParameter("@gia", dtoDichVu.Gia);
                sqlParameters[5] = new SqlParameter("@trangThai", dtoDichVu.TrangThai);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Xoa(string maDichVu)
        {
            try
            {
                string sqlQuery = "DELETE dbo.DichVu WHERE maDichVu = @maDichVu";
                SqlParameter sqlParameter = new SqlParameter("@maDichVu", maDichVu);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable LayDanhSachDichVu()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachDichVu";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static DataTable LayDanhSachDichVu_timKiem(string tuKhoa)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachDichVu_timKiem @tuKhoa";
            SqlParameter sqlParameter = new SqlParameter("@tuKhoa", tuKhoa);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static DataTable LayDanhSachDichVu_maLoaiDichVu(string maLoaiDichVu)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachDichVu_maLoaiDichVu @maLoaiDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maLoaiDichVu", maLoaiDichVu);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static bool KiemTraTonTaiMaDichVu(string maDichVu)
        {
            string sqlQuery = "SELECT * FROM dbo.DichVu WHERE maDichVu = @maDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maDichVu", maDichVu);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);
            return Convert.ToBoolean(dataTable.Rows.Count);
        }

        public static string TaoMaDichVuMoi()
        {
            string maDichVu = "";
            int i = 1;
            do
            {
                maDichVu = (i++).ToString("0000000000");
            } while (KiemTraTonTaiMaDichVu(maDichVu));
            return maDichVu;
        }

        public static bool KiemTraXoaDichVu(string maDichVu)
        {
            string sqlQuery = "SELECT * FROM dbo.HoaDonDichVu WHERE maDichVu = @maDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maDichVu", maDichVu);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);

            return !Convert.ToBoolean(dataTable.Rows.Count);
        }
    }
}
