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
    public class BllHangKhachHang
    {
        public static string LayTenHangKhachHang(string maHangKhachHang)
        {
            return DalHangKhachHang.LayTenHangKhachHang(maHangKhachHang);
        }

        public static long LayDoanhSoDatToi(string maHangKhachHang)
        {
            return DalHangKhachHang.LayDoanhSoDatToi(maHangKhachHang);
        }

        public static int LayKhuyenMai(string maHangKhachHang)
        {
            return DalHangKhachHang.LayKhuyenMai(maHangKhachHang);
        }

        public static bool Sua(DtoHangKhachHang dtoHangKhachHang)
        {
            return DalHangKhachHang.Sua(dtoHangKhachHang);
        }

        public static DataTable LayDanhSachHangKhachHang()
        {
            return DalHangKhachHang.LayDanhSachHangKhachHang();
        }

        public static DataTable GetDataSourceForComboBox()
        {
            return DalHangKhachHang.GetDataSourceForComboBox();
        }

    }
}
