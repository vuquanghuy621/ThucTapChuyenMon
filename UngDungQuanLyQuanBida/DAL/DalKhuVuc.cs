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
    public class DalKhuVuc
    {
        public static string LayTenKhuVuc(string maKhuVuc)
        {
            string sqlQuery = "SELECT tenKhuVuc FROM dbo.KhuVuc WHERE maKhuVuc = @maKhuVuc";
            SqlParameter sqlParameter = new SqlParameter("@maKhuVuc", maKhuVuc);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool Them(DtoKhuVuc dtoKhuVuc)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.KhuVuc (maKhuVuc, tenKhuVuc) " +
                    "VALUES (@maKhuVuc, @tenKhuVuc)";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"maKhuVuc", dtoKhuVuc.MaKhuVuc);
                sqlParameters[1] = new SqlParameter(@"tenKhuVuc", dtoKhuVuc.TenKhuVuc);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Sua(DtoKhuVuc dtoKhuVuc)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.KhuVuc " +
                    "SET tenKhuVuc = @tenKhuVuc " +
                    "WHERE maKhuVuc = @maKhuVuc";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"maKhuVuc", dtoKhuVuc.MaKhuVuc);
                sqlParameters[1] = new SqlParameter(@"tenKhuVuc", dtoKhuVuc.TenKhuVuc);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Xoa(string maKhuVuc)
        {
            try
            {
                string sqlQuery = "DELETE dbo.KhuVuc WHERE maKhuVuc = @maKhuVuc";
                SqlParameter sqlParameter = new SqlParameter("@maKhuVuc", maKhuVuc);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable LayDanhSachKhuVuc()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachKhuVuc";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static DataTable GetDataSourceForComboBox()
        {
            string sqlQuery = "SELECT maKhuVuc, tenKhuVuc FROM dbo.KhuVuc";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static bool KiemTraTonTaiMaKhuVuc(string maKhuVuc)
        {
            string sqlQuery = "SELECT * FROM dbo.KhuVuc WHERE maKhuVuc = @maKhuVuc";
            SqlParameter sqlParameter = new SqlParameter("@maKhuVuc", maKhuVuc);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);
            return Convert.ToBoolean(dataTable.Rows.Count);
        }

        public static string TaoMaKhuVucMoi()
        {
            string maKhuVuc = "";
            int i = 1;
            do
            {
                maKhuVuc = (i++).ToString("0000000000");
            } while (KiemTraTonTaiMaKhuVuc(maKhuVuc));
            return maKhuVuc;
        }

        public static bool KiemTraXoaKhuVuc(string maKhuVuc)
        {
            string sqlQuery = "SELECT * FROM dbo.Ban WHERE maKhuVuc = @maKhuVuc";
            SqlParameter sqlParameter = new SqlParameter("@maKhuVuc", maKhuVuc);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);

            return !Convert.ToBoolean(dataTable.Rows.Count);
        }
    }
}
