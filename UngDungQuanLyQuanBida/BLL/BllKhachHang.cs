using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BllKhachHang
    {
        public static string LayHoVaTen(string soDienThoai)
        {
            return DalKhachHang.LayHoVaTen(soDienThoai);
        }

        public static string LayMaHangKhachHang(string soDienThoai)
        {
            return DalKhachHang.LayMaHangKhachHang(soDienThoai);
        }

        public static DateTime LayNgayThoiGianThem(string soDienThoai)
        {
            return DalKhachHang.LayNgayThoiGianThem(soDienThoai);
        }

        public static bool Them(DtoKhachHang dtoKhachHang)
        {
            return DalKhachHang.Them(dtoKhachHang);
        }

        public static bool Sua(DtoKhachHang dtoKhachHang)
        {
            return DalKhachHang.Sua(dtoKhachHang);
        }

        public static bool Xoa(string soDienThoai)
        {
            return DalKhachHang.Xoa(soDienThoai);
        }

        public static DataTable LayDanhSachKhachHang()
        {
            return DalKhachHang.LayDanhSachKhachHang();
        }

        public static DataTable LayDanhSachKhachHang_timKiem(string tuKhoa)
        {
            return DalKhachHang.LayDanhSachKhachHang_timKiem(tuKhoa);
        }

        public static DataTable LayDanhSachKhachHang_maHangKhachHang(string maHangKhachHang)
        {
            return DalKhachHang.LayDanhSachKhachHang_maHangKhachHang(maHangKhachHang);
        }

        public static DataTable GetDataSourceForComboBox()
        {
            return DalKhachHang.GetDataSourceForComboBox();
        }

        public static bool KiemTraTrungSoDienThoai(string soDienThoai)
        {
            return DalKhachHang.KiemTraTrungSoDienThoai(soDienThoai);
        }

        public static bool KiemTraXoaKhachHang(string soDienThoai)
        {
            return DalKhachHang.KiemTraXoaKhachHang(soDienThoai);
        }
    }
}
