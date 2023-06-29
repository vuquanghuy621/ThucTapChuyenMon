using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Helper
    {
        public static object ExecuteScalar(string sqlQuery, params SqlParameter[] sqlParameters)
        {
            string connectionString = @"Data Source=DV5502A_VQH621\VQH621_SQLSERVER;Initial Catalog=UngDungQuanLyQuanBida;Integrated Security=True";
            SqlConnection sqlConnection;
            object o = null;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.Parameters.AddRange(sqlParameters);
                o = sqlCommand.ExecuteScalar();
                sqlConnection.Close();
            }
            return o;
        }

        public static DataTable ExecuteQuery(string sqlQuery, params SqlParameter[] sqlParameters)
        {
            string connectionString = @"Data Source=DV5502A_VQH621\VQH621_SQLSERVER;Initial Catalog=UngDungQuanLyQuanBida;Integrated Security=True";
            SqlConnection sqlConnection;
            DataTable dataTable = new DataTable();
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.Parameters.AddRange(sqlParameters);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public static int ExecuteNonQuery(string sqlQuery, params SqlParameter[] sqlParameters)
        {
            string connectionString = @"Data Source=DV5502A_VQH621\VQH621_SQLSERVER;Initial Catalog=UngDungQuanLyQuanBida;Integrated Security=True";
            SqlConnection sqlConnection;
            int i;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.Parameters.AddRange(sqlParameters);
                i = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return i;
        }
    }
}
