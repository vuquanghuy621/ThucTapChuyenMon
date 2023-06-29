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
    public class BllHoaDonDichVu
    {
        public static bool Them(DtoHoaDonDichVu dtoHoaDonDichVu)
        {
            return DalHoaDonDichVu.Them(dtoHoaDonDichVu);
        }

        public static bool SuaSoLuong(int soLuong, DateTime thoiGianThem)
        {
            return DalHoaDonDichVu.SuaSoLuong(soLuong, thoiGianThem);
        }

        public static bool Xoa(DateTime thoiGianThem)
        {
            return DalHoaDonDichVu.Xoa(thoiGianThem);
        }
    }
}
