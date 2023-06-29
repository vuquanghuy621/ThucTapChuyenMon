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
    public class DalLoaiBan
    {
        public static string LayTenLoaiBan(string maLoaiBan)
        {
            string sqlQuery = "SELECT tenLoaiBan FROM dbo.LoaiBan WHERE maLoaiBan = @maLoaiBan";
            SqlParameter sqlParameter = new SqlParameter("@maLoaiBan", maLoaiBan);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool Them(DtoLoaiBan dtoLoaiBan)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.LoaiBan (maLoaiBan, tenLoaiBan) " +
                    "VALUES (@maLoaiBan, @tenLoaiBan)";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"maLoaiBan", dtoLoaiBan.MaLoaiBan);
                sqlParameters[1] = new SqlParameter(@"tenLoaiBan", dtoLoaiBan.TenLoaiBan);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Sua(DtoLoaiBan dtoLoaiBan)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.LoaiBan " +
                    "SET tenLoaiBan = @tenLoaiBan " +
                    "WHERE maLoaiBan = @maLoaiBan";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"maLoaiBan", dtoLoaiBan.MaLoaiBan);
                sqlParameters[1] = new SqlParameter(@"tenLoaiBan", dtoLoaiBan.TenLoaiBan);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Xoa(string maLoaiBan)
        {
            try
            {
                string sqlQuery = "DELETE dbo.LoaiBan WHERE maLoaiBan = @maLoaiBan";
                SqlParameter sqlParameter = new SqlParameter("@maLoaiBan", maLoaiBan);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable LayDanhSachLoaiBan()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachLoaiBan";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static DataTable GetDataSourceForComboBox()
        {
            string sqlQuery = "SELECT maLoaiBan, tenLoaiBan FROM dbo.LoaiBan";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static bool KiemTraTonTaiMaLoaiBan(string maLoaiBan)
        {
            string sqlQuery = "SELECT * FROM dbo.LoaiBan WHERE maLoaiBan = @maLoaiBan";
            SqlParameter sqlParameter = new SqlParameter("@maLoaiBan", maLoaiBan);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);
            return Convert.ToBoolean(dataTable.Rows.Count);
        }

        public static string TaoMaLoaiBanMoi()
        {
            string maLoaiBan = "";
            int i = 1;
            do
            {
                maLoaiBan = (i++).ToString("0000000000");
            } while (KiemTraTonTaiMaLoaiBan(maLoaiBan));
            return maLoaiBan;
        }

        public static bool KiemTraXoaLoaiBan(string maLoaiBan)
        {
            string sqlQuery = "SELECT * FROM dbo.Ban WHERE maLoaiBan = @maLoaiBan";
            SqlParameter sqlParameter = new SqlParameter("@maLoaiBan", maLoaiBan);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);

            return !Convert.ToBoolean(dataTable.Rows.Count);
        }
    }
}
