using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalThongTinQuan
    {
        public static string LayTenQuan(string maQuan)
        {
            string sqlQuery = "SELECT tenQuan FROM dbo.ThongTinQuan WHERE maQuan = @maQuan";
            SqlParameter sqlParameter = new SqlParameter("@maQuan", maQuan);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LayDiaChi(string maQuan)
        {
            string sqlQuery = "SELECT diaChi FROM dbo.ThongTinQuan WHERE maQuan = @maQuan";
            SqlParameter sqlParameter = new SqlParameter("@maQuan", maQuan);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static string LaySoDienThoai(string maQuan)
        {
            string sqlQuery = "SELECT soDienThoai FROM dbo.ThongTinQuan WHERE maQuan = @maQuan";
            SqlParameter sqlParameter = new SqlParameter("@maQuan", maQuan);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static byte[] LayHinhAnh(string maQuan)
        {
            string sqlQuery = "SELECT hinhAnh FROM dbo.ThongTinQuan WHERE maQuan = @maQuan";
            SqlParameter sqlParameter = new SqlParameter("@maQuan", maQuan);
            return (byte[])Helper.ExecuteScalar(sqlQuery, sqlParameter);
        }

        public static bool Sua(DtoThongTinQuan dtoThongTinQuan)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.ThongTinQuan " +
            "SET tenQuan = @tenQuan, " +
            "diaChi = @diaChi, " +
            "soDienThoai = @soDienThoai, " +
            "hinhAnh = @hinhAnh " +
            "WHERE maQuan = @maQuan";
                SqlParameter[] sqlParameters = new SqlParameter[5];
                sqlParameters[0] = new SqlParameter(@"maQuan", dtoThongTinQuan.MaQuan);
                sqlParameters[1] = new SqlParameter(@"tenQuan", dtoThongTinQuan.TenQuan);
                sqlParameters[2] = new SqlParameter(@"diaChi", dtoThongTinQuan.DiaChi);
                sqlParameters[3] = new SqlParameter(@"soDienThoai", dtoThongTinQuan.SoDienThoai);
                sqlParameters[4] = new SqlParameter(@"hinhAnh", dtoThongTinQuan.HinhAnh);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
