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
    public class DalLoaiDichVu
    {
        public static string LayTenLoaiDichVu(string maLoaiDichVu)
        {
            string sqlQuery = "SELECT tenLoaiDichVu FROM dbo.LoaiDichVu WHERE maLoaiDichVu = @maLoaiDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maLoaiDichVu", maLoaiDichVu);
            return Convert.ToString(Helper.ExecuteScalar(sqlQuery, sqlParameter));
        }

        public static bool Them(DtoLoaiDichVu dtoLoaiDichVu)
        {
            try
            {
                string sqlQuery = "INSERT INTO dbo.LoaiDichVu (maLoaiDichVu, tenLoaiDichVu) " +
                    "VALUES (@maLoaiDichVu, @tenLoaiDichVu)";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"maLoaiDichVu", dtoLoaiDichVu.MaLoaiDichVu);
                sqlParameters[1] = new SqlParameter(@"tenLoaiDichVu", dtoLoaiDichVu.TenLoaiDichVu);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Sua(DtoLoaiDichVu dtoLoaiDichVu)
        {
            try
            {
                string sqlQuery = "UPDATE dbo.LoaiDichVu " +
                    "SET tenLoaiDichVu = @tenLoaiDichVu " +
                    "WHERE maLoaiDichVu = @maLoaiDichVu";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter(@"maLoaiDichVu", dtoLoaiDichVu.MaLoaiDichVu);
                sqlParameters[1] = new SqlParameter(@"tenLoaiDichVu", dtoLoaiDichVu.TenLoaiDichVu);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Xoa(string maLoaiDichVu)
        {
            try
            {
                string sqlQuery = "DELETE dbo.LoaiDichVu WHERE maLoaiDichVu = @maLoaiDichVu";
                SqlParameter sqlParameter = new SqlParameter("@maLoaiDichVu", maLoaiDichVu);
                Helper.ExecuteNonQuery(sqlQuery, sqlParameter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable LayDanhSachLoaiDichVu()
        {
            string sqlQuery = "EXECUTE dbo.sp_LayDanhSachLoaiDichVu";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static DataTable GetDataSourceForComboBox()
        {
            string sqlQuery = "SELECT maLoaiDichVu, tenLoaiDichVu FROM dbo.LoaiDichVu";
            return Helper.ExecuteQuery(sqlQuery);
        }

        public static bool KiemTraTonTaiMaLoaiDichVu(string maLoaiDichVu)
        {
            string sqlQuery = "SELECT * FROM dbo.LoaiDichVu WHERE maLoaiDichVu = @maLoaiDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maLoaiDichVu", maLoaiDichVu);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);
            return Convert.ToBoolean(dataTable.Rows.Count);
        }

        public static string TaoMaLoaiDichVuMoi()
        {
            string maLoaiDichVu = "";
            int i = 1;
            do
            {
                maLoaiDichVu = (i++).ToString("0000000000");
            } while (KiemTraTonTaiMaLoaiDichVu(maLoaiDichVu));
            return maLoaiDichVu;
        }

        public static bool KiemTraXoaLoaiDichVu(string maLoaiDichVu)
        {
            string sqlQuery = "SELECT * FROM dbo.DichVu WHERE maLoaiDichVu = @maLoaiDichVu";
            SqlParameter sqlParameter = new SqlParameter("@maLoaiDichVu", maLoaiDichVu);
            DataTable dataTable = Helper.ExecuteQuery(sqlQuery, sqlParameter);

            return !Convert.ToBoolean(dataTable.Rows.Count);
        }
    }
}
