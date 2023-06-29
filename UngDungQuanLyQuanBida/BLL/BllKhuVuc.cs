using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllKhuVuc
    {
        public static string LayTenKhuVuc(string maKhuVuc)
        {
            return DalKhuVuc.LayTenKhuVuc(maKhuVuc);
        }

        public static bool Them(DtoKhuVuc dtoKhuVuc)
        {
            return DalKhuVuc.Them(dtoKhuVuc);
        }

        public static bool Sua(DtoKhuVuc dtoKhuVuc)
        {
            return DalKhuVuc.Sua(dtoKhuVuc);
        }

        public static bool Xoa(string maKhuVuc)
        {
            return DalKhuVuc.Xoa(maKhuVuc);
        }

        public static DataTable LayDanhSachKhuVuc()
        {
            return DalKhuVuc.LayDanhSachKhuVuc();
        }

        public static DataTable GetDataSourceForComboBox()
        {
            return DalKhuVuc.GetDataSourceForComboBox();
        }

        public static bool KiemTraTonTaiMaKhuVuc(string maKhuVuc)
        {
            return DalKhuVuc.KiemTraTonTaiMaKhuVuc(maKhuVuc);
        }

        public static string TaoMaKhuVucMoi()
        {
            return DalKhuVuc.TaoMaKhuVucMoi();
        }

        public static bool KiemTraXoaKhuVuc(string maKhuVuc)
        {
            return DalKhuVuc.KiemTraXoaKhuVuc(maKhuVuc);
        }
    }
}
