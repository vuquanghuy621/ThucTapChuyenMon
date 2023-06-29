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
    public class DalHoaDon
    {
        public static DateTime LayThoiGiamThem(string maHoaDon)
        {
            string sqlQuery = "SELECT thoiGianThem FROM dbo.HoaDon WHERE maHoaDon = @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToDateTime(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LayTenDangNhapNhanVien(string maHoaDon)
        {
            string sqlQuery = "SELECT tenDangNhapNhanVien FROM dbo.HoaDon WHERE maHoaDon = @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LaySoDienThoaiKhachHang(string maHoaDon)
        {
            string sqlQuery = "SELECT soDienThoaiKhachHang FROM dbo.HoaDon WHERE maHoaDon = @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static byte LayKhuyenMaiHangKhachHang(string maHoaDon)
        {
            string sqlQuery = "SELECT khuyenMaiHangKhachHang FROM dbo.HoaDon WHERE maHoaDon = @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToByte(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static byte LayKhuyenMaiNgay(string maHoaDon)
        {
            string sqlQuery = "SELECT khuyenMaiNgay FROM dbo.HoaDon WHERE maHoaDon = @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToByte(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool LayTrangThai(string maHoaDon)
        {
            string sqlQuery = "SELECT trangThai FROM dbo.HoaDon WHERE maHoaDon = @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToBoolean(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static long LayTienBan(string maHoaDon)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayTienBan @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToInt64(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static long LayTienDichVu(string maHoaDon)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayTienDichVu @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToInt64(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static long LayTienHoaDon(string maHoaDon)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayTienHoaDon @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToInt64(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static long LayTienKhuyenMaiHangKhachHang(string maHoaDon)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayTienKhuyenMaiHangKhachHang @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToInt64(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static long LayTienKhuyenMaiNgay(string maHoaDon)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayTienKhuyenMaiNgay @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToInt64(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static long LayTienPhaiThanhToan(string maHoaDon)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayTienPhaiThanhToan @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Convert.ToInt64(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static DataTable LayDanhSachHoaDonBan(string maHoaDon)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachHoaDonBan @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static DataTable LayDanhSachHoaDonDichVu(string maHoaDon)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachHoaDonDichVu @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static long LayDoanhThuHomNay()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDoanhThuHomNay";
            return Convert.ToInt64(Helper.ExecuteScalar(sqlQuery));
        }

        public static bool Them(DtoHoaDon dtoHoaDon)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.HoaDon (maHoaDon, thoiGianThem, tenDangNhapNhanVien, soDienThoaiKhachHang, khuyenMaiHangKhachHang, khuyenMaiNgay, trangThai) " +
                    "VALUES (@maHoaDon, @thoiGianThem, @tenDangNhapNhanVien, @soDienThoaiKhachHang, @khuyenMaiHangKhachHang, @khuyenMaiNgay, @trangThai)";
                SqlParameter[] sqlParameters = new SqlParameter[7];
                sqlParameters[0] = new SqlParameter("@maHoaDon", dtoHoaDon.MaHoaDon);
                sqlParameters[1] = new SqlParameter("@thoiGianThem", dtoHoaDon.ThoiGiamThem);
                sqlParameters[2] = new SqlParameter("@tenDangNhapNhanVien", dtoHoaDon.TenDangNhapNhanVien);
                if (dtoHoaDon.SoDienThoaiKhachHang == "0000000000")
                {
                    sqlParameters[3] = new SqlParameter("@soDienThoaiKhachHang", DBNull.Value);
                }
                else
                {
                    sqlParameters[3] = new SqlParameter("@soDienThoaiKhachHang", dtoHoaDon.SoDienThoaiKhachHang);
                }
                sqlParameters[4] = new SqlParameter("@khuyenMaiHangKhachHang", dtoHoaDon.KhuyenMaiHangKhachHang);
                sqlParameters[5] = new SqlParameter("@khuyenMaiNgay", dtoHoaDon.KhuyenMaiNgay);
                sqlParameters[6] = new SqlParameter("@trangThai", dtoHoaDon.TrangThai);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SuaKhachHang(string soDienThoai, string maHoaDon)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.HoaDon " +
                "SET soDienThoaiKhachHang = @soDienThoai " +
                "WHERE maHoaDon = @maHoaDon";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@maHoaDon", maHoaDon);
                if (soDienThoai == "0000000000")
                {
                    sqlParameters[1] = new SqlParameter("@maKhachHang", DBNull.Value);
                }
                else
                {
                    sqlParameters[1] = new SqlParameter("@maKhachHang", soDienThoai);
                }
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Xoa(string maHoaDon)
        {
            try
            {
                string sqlQuery = "DELETE dbo.HoaDonBan WHERE maHoaDon = @maHoaDon; " +
                    "DELETE dbo.HoaDonDichVu WHERE maHoaDon = @maHoaDon; " +
                    "DELETE dbo.HoaDon WHERE maHoaDon = @maHoaDon;";
                SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable LayDanhSachHoaDon()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachHoaDon";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static DataTable LayDanhSachHoaDon_khachLe()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachHoaDon_khachLe";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static DataTable LayDanhSachHoaDon_ngay(DateTime ngay)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachHoaDon_ngay @ngay";
            SqlParameter sqlParameter = new SqlParameter("@ngay", ngay);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static DataTable LayDanhSachHoaDon_tuan(DateTime ngay)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachHoaDon_tuan @ngay";
            SqlParameter sqlParameter = new SqlParameter("@ngay", ngay);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static DataTable LayDanhSachHoaDon_thang(DateTime ngay)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachHoaDon_thang @ngay";
            SqlParameter sqlParameter = new SqlParameter("@ngay", ngay);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static DataTable LayDanhSachHoaDon_soDienThoaiKhachHang(string soDienThoai)
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachHoaDon_soDienThoaiKhachHang @soDienThoai";
            SqlParameter sqlParameter = new SqlParameter("@soDienThoai", soDienThoai);
            return Helper.ExecuteQuery(sqlQuery, sqlParameter);
        }

        public static bool KiemTraTonTaiMaHoaDon(string maHoaDon)
        {
            string sqlQuery = "SELECT * FROM dbo.HoaDon WHERE maHoaDon = @maHoaDon";
            SqlParameter sqlParameter = new SqlParameter("@maHoaDon", maHoaDon);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);
            return Convert.ToBoolean(dataTable.Rows.Count);
        }

        public static string TaoMaHoaDonMoi()
        {
            string maHoaDon = "";
            int i = 1;
            do
            {
                maHoaDon = DateTime.Now.ToString("ddMMyyyy") + (i++).ToString("000000");
            } while (KiemTraTonTaiMaHoaDon(maHoaDon));
            return maHoaDon;
        }
    }
}
