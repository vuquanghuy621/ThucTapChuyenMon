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
    public class BllLoaiBan
    {
        public static string LayTenLoaiBan(string maLoaiBan)
        {
            return DalLoaiBan.LayTenLoaiBan(maLoaiBan);
        }

        public static bool Them(DtoLoaiBan dtoLoaiBan)
        {
            return DalLoaiBan.Them(dtoLoaiBan);
        }

        public static bool Sua(DtoLoaiBan dtoLoaiBan)
        {
            return DalLoaiBan.Sua(dtoLoaiBan);
        }

        public static bool Xoa(string maLoaiBan)
        {
            return DalLoaiBan.Xoa(maLoaiBan);
        }

        public static DataTable LayDanhSachLoaiBan()
        {
            return DalLoaiBan.LayDanhSachLoaiBan();
        }

        public static DataTable GetDataSourceForComboBox()
        {
            return DalLoaiBan.GetDataSourceForComboBox();
        }

        public static bool KiemTraTonTaiMaLoaiBan(string maLoaiBan)
        {
            return DalLoaiBan.KiemTraTonTaiMaLoaiBan(maLoaiBan);
        }

        public static string TaoMaLoaiBanMoi()
        {
            return DalLoaiBan.TaoMaLoaiBanMoi();
        }

        public static bool KiemTraXoaLoaiBan(string maLoaiBan)
        {
            return DalLoaiBan.KiemTraXoaLoaiBan(maLoaiBan);
        }
    }
}
