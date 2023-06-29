using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalHoaDonDichVu
    {
        public static bool Them(DtoHoaDonDichVu dtoHoaDonDichVu)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.HoaDonDichVu (thoiGianThem, maHoaDon, maDichVu, gia, soLuong) " +
                    "VALUES (@thoiGianThem, @maHoaDon, @maDichVu, @gia, @soLuong)";
                SqlParameter[] sqlParameters = new SqlParameter[4];
                sqlParameters[0] = new SqlParameter(@"thoiGianThem", dtoHoaDonDichVu.ThoiGianThem);
                sqlParameters[1] = new SqlParameter(@"maHoaDon", dtoHoaDonDichVu.MaHoaDon);
                sqlParameters[2] = new SqlParameter(@"maDichVu", dtoHoaDonDichVu.MaDichVu);
                sqlParameters[3] = new SqlParameter(@"gia", dtoHoaDonDichVu.Gia);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SuaSoLuong(int soLuong, DateTime thoiGianThem)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.HoaDonDichVu " +
                    "SET soLuong = @soLuong " +
                    "WHERE thoiGianThem = @thoiGianThem";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"thoiGianThem", thoiGianThem);
                sqlParameters[1] = new SqlParameter(@"soLuong", soLuong);
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
                string sqlQuery = "DELETE dbo.HoaDonDichVu WHERE thoiGianThem = @thoiGianThem";
                SqlParameter sqlParameter = new SqlParameter("@thoiGianThem", thoiGianThem);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
