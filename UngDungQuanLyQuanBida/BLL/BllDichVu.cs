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
    public class BllDichVu
    {
        public static string LayTenDichVu(string maDichVu)
        {
            return DalDichVu.LayTenDichVu(maDichVu);
        }

        public static string LayMaLoaiDichVu(string maDichVu)
        {
            return DalDichVu.LayMaLoaiDichVu(maDichVu);
        }

        public static byte[] LayHinhAnh(string maDichVu)
        {
            return DalDichVu.LayHinhAnh(maDichVu);
        }

        public static long LayGia(string maDichVu)
        {
            return DalDichVu.LayGia(maDichVu);
        }

        public static DateTime LayThoiGianThem(string maDichVu)
        {
            return DalDichVu.LayThoiGianThem(maDichVu);
        }

        public static bool LayTrangThai(string maDichVu)
        {
            return DalDichVu.LayTrangThai(maDichVu);
        }

        public static bool Them(DtoDichVu dtoDichVu)
        {
            return DalDichVu.Them(dtoDichVu);
        }

        public static bool Sua(DtoDichVu dtoDichVu)
        {
            return DalDichVu.Sua(dtoDichVu);
        }

        public static bool Xoa(string maDichVu)
        {
            return DalDichVu.Xoa(maDichVu);
        }

        public static DataTable LayDanhSachDichVu()
        {
            return DalDichVu.LayDanhSachDichVu();
        }

        public static DataTable LayDanhSachDichVu_timKiem(string tuKhoa)
        {
            return DalDichVu.LayDanhSachDichVu_timKiem(tuKhoa);
        }

        public static DataTable LayDanhSachDichVu_maLoaiDichVu(string maLoaiDichVu)
        {
            return DalDichVu.LayDanhSachDichVu_maLoaiDichVu(maLoaiDichVu);
        }

        public static bool KiemTraTonTaiMaDichVu(string maDichVu)
        {
            return DalDichVu.KiemTraTonTaiMaDichVu(maDichVu);
        }

        public static string TaoMaDichVuMoi()
        {
            return DalDichVu.TaoMaDichVuMoi();
        }

        public static bool KiemTraXoaDichVu(string maDichVu)
        {
            return DalDichVu.KiemTraXoaDichVu(maDichVu);
        }
    }
}
