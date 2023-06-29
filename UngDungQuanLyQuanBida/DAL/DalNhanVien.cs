using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalNhanVien
    {
        public static string LayMatKhau(string tenDangNhap)
        {
            string sqlQuery = "SELECT matKhau FROM dbo.NhanVien WHERE tenDangNhap = @tenDangNhap";
            SqlParameter sqlParameter = new SqlParameter("@tenDangNhap", tenDangNhap);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LayHoVaTen(string tenDangNhap)
        {
            string sqlQuery = "SELECT hoVaTen FROM dbo.NhanVien WHERE tenDangNhap = @tenDangNhap";
            SqlParameter sqlParameter = new SqlParameter("@tenDangNhap", tenDangNhap);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LayMaLoaiNhanVien(string tenDangNhap)
        {
            string sqlQuery = "SELECT maLoaiNhanVien FROM dbo.NhanVien WHERE tenDangNhap = @tenDangNhap";
            SqlParameter sqlParameter = new SqlParameter("@tenDangNhap", tenDangNhap);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static byte[] LayHinhAnh(string tenDangNhap)
        {
            string sqlQuery = "SELECT hinhAnh FROM dbo.NhanVien WHERE tenDangNhap = @tenDangNhap";
            SqlParameter sqlParameter = new SqlParameter("@tenDangNhap", tenDangNhap);
            return (byte[])Helper.ExecuteScalar(sqlQuery, sqlParameter);
        }

        public static DateTime LayThoiGianThem(string tenDangNhap)
        {
            string sqlQuery = "SELECT thoiGianThem FROM dbo.NhanVien WHERE tenDangNhap = @tenDangNhap";
            SqlParameter sqlParameter = new SqlParameter("@tenDangNhap", tenDangNhap);
            return Convert.ToDateTime(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool LayTrangThai(string tenDangNhap)
        {
            string sqlQuery = "SELECT trangThai FROM dbo.NhanVien WHERE tenDangNhap = @tenDangNhap";
            SqlParameter sqlParameter = new SqlParameter("@tenDangNhap", tenDangNhap);
            return Convert.ToBoolean(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool Them(DtoNhanVien dtoNhanVien)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.NhanVien (tenDangNhap, matKhau, hoVaTen, maLoaiNhanVien, hinhAnh, thoiGianThem, trangThai) " +
                    "VALUES (@tenDangNhap, @matKhau, @hoVaTen, @maLoaiNhanVien, @hinhAnh, @thoiGianThem, @trangThai)";
                SqlParameter[] sqlParameters = new SqlParameter[7];
                sqlParameters[0] = new SqlParameter(@"tenDangNhap", dtoNhanVien.TenDangNhap);
                sqlParameters[1] = new SqlParameter(@"matKhau", dtoNhanVien.MatKhau);
                sqlParameters[2] = new SqlParameter(@"hoVaTen", dtoNhanVien.HoVaTen);
                sqlParameters[3] = new SqlParameter(@"maLoaiNhanVien", dtoNhanVien.MaLoaiNhanVien);
                sqlParameters[4] = new SqlParameter(@"hinhAnh", dtoNhanVien.HinhAnh);
                sqlParameters[5] = new SqlParameter(@"thoiGianThem", dtoNhanVien.ThoiGianThem);
                sqlParameters[6] = new SqlParameter(@"trangThai", dtoNhanVien.TrangThai);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SuaThongTin(DtoNhanVien dtoNhanVien)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.NhanVien " +
                    "SET hoVaTen = @hoVaTen, " +
                    "maLoaiNhanVien = @maLoaiNhanVien, " +
                    "hinhAnh = @hinhAnh, " +
                    "trangThai = @trangThai " +
                    "WHERE tenDangNhap = @tenDangNhap";
                SqlParameter[] sqlParameters = new SqlParameter[5];
                sqlParameters[0] = new SqlParameter(@"tenDangNhap", dtoNhanVien.TenDangNhap);
                sqlParameters[1] = new SqlParameter(@"hoVaTen", dtoNhanVien.HoVaTen);
                sqlParameters[2] = new SqlParameter(@"maLoaiNhanVien", dtoNhanVien.MaLoaiNhanVien);
                sqlParameters[3] = new SqlParameter(@"hinhAnh", dtoNhanVien.HinhAnh);
                sqlParameters[4] = new SqlParameter(@"trangThai", dtoNhanVien.TrangThai);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DoiTenDangNhap(string tenDangNhapMoi, string tenDangNhapCu)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.NhanVien " +
                    "SET tenDangNhap = @tenDangNhapMoi " +
                    "WHERE tenDangNhap = @tenDangNhapCu";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"tenDangNhapCu", tenDangNhapCu);
                sqlParameters[1] = new SqlParameter(@"tenDangNhapMoi", tenDangNhapMoi);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DoiMatKhau(string matKhau, string tenDangNhap)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.NhanVien " +
                    "SET matKhau = @matKhau " +
                    "WHERE tenDangNhap = @tenDangNhap";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"tenDangNhap", tenDangNhap);
                sqlParameters[1] = new SqlParameter(@"matKhau", matKhau);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Xoa(string tenDangNhap)
        {
            try
            {
                string sqlQuery = "DELETE dbo.NhanVien " +
                    "WHERE tenDangNhap = @tenDangNhap";
                SqlParameter sqlParameter = new SqlParameter(@"tenDangNhap", tenDangNhap);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable LayDanhSachNhanVien()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachNhanVien";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static DataTable LayDanhSachNhanVien_timKiem(string tuKhoa)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachNhanVien_timKiem @tuKhoa";
            SqlParameter sqlParameter = new SqlParameter("@tuKhoa", tuKhoa);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static DataTable LayDanhSachNhanVien_maLoaiNhanVien(string maLoaiNhanVien)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachNhanVien_maLoaiNhanVien @maLoaiNhanVien";
            SqlParameter sqlParameter = new SqlParameter("@maLoaiNhanVien", maLoaiNhanVien);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static bool KiemTraXoaNhanVien(string tenDangNhap)
        {
            string sqlQuery = "SELECT * FROM dbo.HoaDon WHERE tenDangNhapNhanVien = @tenDangNhap";
            SqlParameter sqlParameter = new SqlParameter(@"tenDangNhap", tenDangNhap);
            return !Convert.ToBoolean(Helper.ExecuteQuery(sqlQuery, sqlParameter).Rows.Count);
        }

        public static bool KiemTraTrungTenDangNhap(string tenDangNhap)
        {
            string sqlQuery = "SELECT * FROM dbo.NhanVien WHERE tenDangNhap = @tenDangNhap";
            SqlParameter sqlParameter = new SqlParameter(@"tenDangNhap", tenDangNhap);
            return Convert.ToBoolean(Helper.ExecuteQuery(sqlQuery, sqlParameter).Rows.Count);
        }

        public static bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string sqlQuery = "SELECT * FROM dbo.NhanVien WHERE tenDangNhap = @tenDangNhap AND matKhau = @matKhau";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter(@"tenDangNhap", tenDangNhap);
            sqlParameters[1] = new SqlParameter(@"matKhau", matKhau);
            return Convert.ToBoolean(Helper.ExecuteQuery(sqlQuery, sqlParameters).Rows.Count);
        }
    }
}
