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
    public class DalNgayCoKhuyenMai
    {
        public static string LayMoTa(DateTime ngay)
        {
            string sqlQuery = "SELECT moTa FROM dbo.NgayCoKhuyenMai WHERE ngay = @ngay";
            SqlParameter sqlParameter = new SqlParameter("@ngay", ngay.Date);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }
        public static byte LayKhuyenMai(DateTime ngay)
        {
            string sqlQuery = "SELECT khuyenMai FROM dbo.NgayCoKhuyenMai WHERE ngay = @ngay";
            SqlParameter sqlParameter = new SqlParameter("@ngay", ngay.Date);
            return Convert.ToByte(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool Them(DtoNgayCoKhuyenMai dtoNgayCoKhuyenMai)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.NgayCoKhuyenMai (ngay, moTa, khuyenMai) " +
                    "VALUES(@ngay, @moTa, @khuyenMai)";
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter(@"ngay", dtoNgayCoKhuyenMai.Ngay.Date);
                sqlParameters[1] = new SqlParameter(@"moTa", dtoNgayCoKhuyenMai.MoTa);
                sqlParameters[2] = new SqlParameter(@"khuyenMai", dtoNgayCoKhuyenMai.KhuyenMai);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Sua(DtoNgayCoKhuyenMai dtoNgayCoKhuyenMai)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.NgayCoKhuyenMai " +
                    "SET moTa = @moTa, " +
                    "khuyenMai = @khuyenMai " +
                    "WHERE ngay = @ngay";
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter(@"ngay", dtoNgayCoKhuyenMai.Ngay.Date);
                sqlParameters[1] = new SqlParameter(@"moTa", dtoNgayCoKhuyenMai.MoTa);
                sqlParameters[2] = new SqlParameter(@"khuyenMai", dtoNgayCoKhuyenMai.KhuyenMai);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Xoa(DateTime ngay)
        {
            try
            {
                string sqlQuery = "DELETE dbo.NgayCoKhuyenMai WHERE ngay = @ngay";
                SqlParameter sqlParameter = new SqlParameter("@ngay", ngay.Date);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable LayDanhSachNgayCoKhuyenMai()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachNgayCoKhuyenMai";
            return Helper.ExecuteQuery(sqlQuery);
        }
    }
}
