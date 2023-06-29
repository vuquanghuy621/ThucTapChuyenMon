using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllThongTinQuan
    {
        public static string LayTenQuan(string maQuan)
        {
            return DalThongTinQuan.LayTenQuan(maQuan);
        }

        public static string LayDiaChi(string maQuan)
        {
            return DalThongTinQuan.LayDiaChi(maQuan);
        }

        public static string LaySoDienThoai(string maQuan)
        {
            return DalThongTinQuan.LaySoDienThoai(maQuan);
        }

        public static byte[] LayHinhAnh(string maQuan)
        {
            return DalThongTinQuan.LayHinhAnh(maQuan);
        }

        public static bool Sua(DtoThongTinQuan dtoThongTinQuan)
        {
            return DalThongTinQuan.Sua(dtoThongTinQuan);
        }
    }
}
