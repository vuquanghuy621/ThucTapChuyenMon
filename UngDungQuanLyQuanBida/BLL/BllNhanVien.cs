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
    public class BllNhanVien
    {
        public static string LayMatKhau(string tenDangNhap)
        {
            return DalNhanVien.LayMatKhau(tenDangNhap);
        }

        public static string LayHoVaTen(string tenDangNhap)
        {
            return DalNhanVien.LayHoVaTen(tenDangNhap);
        }

        public static string LayMaLoaiNhanVien(string tenDangNhap)
        {
            return DalNhanVien.LayMaLoaiNhanVien(tenDangNhap);
        }

        public static byte[] LayHinhAnh(string tenDangNhap)
        {
            return DalNhanVien.LayHinhAnh(tenDangNhap);
        }

        public static DateTime LayThoiGianThem(string tenDangNhap)
        {
            return DalNhanVien.LayThoiGianThem(tenDangNhap);
        }

        public static bool LayTrangThai(string tenDangNhap)
        {
            return DalNhanVien.LayTrangThai(tenDangNhap);
        }

        public static bool Them(DtoNhanVien dtoNhanVien)
        {
            return DalNhanVien.Them(dtoNhanVien);
        }

        public static bool SuaThongTin(DtoNhanVien dtoNhanVien)
        {
            return DalNhanVien.SuaThongTin(dtoNhanVien);
        }

        public static bool DoiTenDangNhap(string tenDangNhapMoi, string tenDangNhapCu)
        {
            return DalNhanVien.DoiTenDangNhap(tenDangNhapMoi, tenDangNhapCu);
        }

        public static bool DoiMatKhau(string matKhau, string tenDangNhap)
        {
            return DalNhanVien.DoiMatKhau(matKhau, tenDangNhap);
        }

        public static bool Xoa(string tenDangNhap)
        {
            return DalNhanVien.Xoa(tenDangNhap);
        }

        public static DataTable LayDanhSachNhanVien()
        {
            return DalNhanVien.LayDanhSachNhanVien();
        }

        public static DataTable LayDanhSachNhanVien_timKiem(string tuKhoa)
        {
            return DalNhanVien.LayDanhSachNhanVien_timKiem(tuKhoa);
        }

        public static DataTable LayDanhSachNhanVien_maLoaiNhanVien(string maLoaiNhanVien)
        {
            return DalNhanVien.LayDanhSachNhanVien_maLoaiNhanVien(maLoaiNhanVien);
        }

        public static bool KiemTraXoaNhanVien(string tenDangNhap)
        {
            return DalNhanVien.KiemTraXoaNhanVien(tenDangNhap);
        }

        public static bool KiemTraTrungTenDangNhap(string tenDangNhap)
        {
            return DalNhanVien.KiemTraTrungTenDangNhap(tenDangNhap);
        }

        public static bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            return DalNhanVien.KiemTraDangNhap(tenDangNhap, matKhau);
        }
    }
}
