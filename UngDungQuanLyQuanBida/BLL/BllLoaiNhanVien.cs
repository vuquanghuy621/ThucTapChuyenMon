using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BllLoaiNhanVien
    {
        public static string LayTenLoaiNhanVien(string maLoaiNhanVien)
        {
            return DalLoaiNhanVien.LayTenLoaiNhanVien(maLoaiNhanVien);
        }

        public static DataTable GetDataSourceForComboBox()
        {
            return DalLoaiNhanVien.GetDataSourceForComboBox();
        }
    }
}
