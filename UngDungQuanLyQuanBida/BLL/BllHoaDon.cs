using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BllHoaDon
    {
        public static DateTime LayThoiGiamThem(string maHoaDon)
        {
            return DalHoaDon.LayThoiGiamThem(maHoaDon);
        }

        public static string LayTenDangNhapNhanVien(string maHoaDon)
        {
            return DalHoaDon.LayTenDangNhapNhanVien(maHoaDon);
        }

        public static string LaySoDienThoaiKhachHang(string maHoaDon)
        {
            return DalHoaDon.LaySoDienThoaiKhachHang(maHoaDon);
        }

        public static byte LayKhuyenMaiHangKhachHang(string maHoaDon)
        {
            return DalHoaDon.LayKhuyenMaiHangKhachHang(maHoaDon);
        }

        public static byte LayKhuyenMaiNgay(string maHoaDon)
        {
            return DalHoaDon.LayKhuyenMaiNgay(maHoaDon);
        }

        public static bool LayTrangThai(string maHoaDon)
        {
            return DalHoaDon.LayTrangThai(maHoaDon);
        }

        public static long LayTienBan(string maHoaDon)
        {
            return DalHoaDon.LayTienBan(maHoaDon);
        }

        public static long LayTienDichVu(string maHoaDon)
        {
            return DalHoaDon.LayTienDichVu(maHoaDon);
        }

        public static long LayTienHoaDon(string maHoaDon)
        {
            return DalHoaDon.LayTienHoaDon(maHoaDon);
        }

        public static long LayTienKhuyenMaiHangKhachHang(string maHoaDon)
        {
            return DalHoaDon.LayTienKhuyenMaiHangKhachHang(maHoaDon);
        }

        public static long LayTienKhuyenMaiNgay(string maHoaDon)
        {
            return DalHoaDon.LayTienKhuyenMaiNgay(maHoaDon);
        }

        public static long LayTienPhaiThanhToan(string maHoaDon)
        {
            return DalHoaDon.LayTienPhaiThanhToan(maHoaDon);
        }

        public static DataTable LayDanhSachHoaDonBan(string maHoaDon)
        {
            return DalHoaDon.LayDanhSachHoaDonBan(maHoaDon);
        }

        public static DataTable LayDanhSachHoaDonDichVu(string maHoaDon)
        {
            return DalHoaDon.LayDanhSachHoaDonDichVu(maHoaDon);
        }

        public static long LayDoanhThuHomNay()
        {
            return DalHoaDon.LayDoanhThuHomNay();
        }

        public static bool Them(DtoHoaDon dtoHoaDon)
        {
            return DalHoaDon.Them(dtoHoaDon);
        }

        public static bool SuaKhachHang(string soDienThoai, string maHoaDon)
        {
            return DalHoaDon.SuaKhachHang(soDienThoai, maHoaDon);
        }

        public static bool Xoa(string maHoaDon)
        {
            return DalHoaDon.Xoa(maHoaDon);
        }

        public static DataTable LayDanhSachHoaDon()
        {
            return DalHoaDon.LayDanhSachHoaDon();
        }

        public static DataTable LayDanhSachHoaDon_khachLe()
        {
            return DalHoaDon.LayDanhSachHoaDon_khachLe();
        }

        public static DataTable LayDanhSachHoaDon_ngay(DateTime ngay)
        {
            return DalHoaDon.LayDanhSachHoaDon_ngay(ngay);
        }

        public static DataTable LayDanhSachHoaDon_tuan(DateTime ngay)
        {
            return DalHoaDon.LayDanhSachHoaDon_tuan(ngay);
        }

        public static DataTable LayDanhSachHoaDon_thang(DateTime ngay)
        {
            return DalHoaDon.LayDanhSachHoaDon_thang(ngay);
        }

        public static DataTable LayDanhSachHoaDon_soDienThoaiKhachHang(string soDienThoai)
        {
            return DalHoaDon.LayDanhSachHoaDon_soDienThoaiKhachHang(soDienThoai);
        }

        public static bool KiemTraTonTaiMaHoaDon(string maHoaDon)
        {
            return DalHoaDon.KiemTraTonTaiMaHoaDon(maHoaDon);
        }

        public static string TaoMaHoaDonMoi()
        {
            return DalHoaDon.TaoMaHoaDonMoi();
        }
    }
}
