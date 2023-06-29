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
    public class BllHoaDonBan
    {
        public static string LayMaHoaDon(DateTime thoiGianThem)
        {
            return DalHoaDonBan.LayMaHoaDon(thoiGianThem);
        }

        public static string LayMaBan(DateTime thoiGianThem)
        {
            return DalHoaDonBan.LayMaBan(thoiGianThem);
        }

        public static DateTime LayThoiGianBatDau(DateTime thoiGianThem)
        {
            return DalHoaDonBan.LayThoiGianBatDau(thoiGianThem);
        }

        public static DateTime LayThoiGianKetThuc(DateTime thoiGianThem)
        {
            return DalHoaDonBan.LayThoiGianKetThuc(thoiGianThem);
        }

        public static bool Them(DtoHoaDonBan dtoHoaDonBan)
        {
            return DalHoaDonBan.Them(dtoHoaDonBan);
        }

        public static bool SuaMaBan(string maBan, DateTime thoiGianThem)
        {
            return DalHoaDonBan.SuaMaBan(maBan, thoiGianThem);
        }

        public static bool SuaThoiGianBatDau(DateTime thoiGianBatDau, DateTime thoiGianThem)
        {
            return DalHoaDonBan.SuaThoiGianBatDau(thoiGianBatDau, thoiGianThem);
        }

        public static bool SuaThoiGianKetThuc(DateTime thoiGianKetThuc, DateTime thoiGianThem)
        {
            return DalHoaDonBan.SuaThoiGianKetThuc(thoiGianKetThuc, thoiGianThem);
        }

        public static bool Xoa(DateTime thoiGianThem)
        {
            return DalHoaDonBan.Xoa(thoiGianThem);
        }

        public static DateTime LayThoiGianBatDauSuDung(string maBan)
        {
            return DalHoaDonBan.LayThoiGianBatDauSuDung(maBan);
        }

        public static string LayMaHoaDonDangSuDung(string maBan)
        {
            return DalHoaDonBan.LayMaHoaDonDangSuDung(maBan);
        }

        public static DateTime LayThoiGianThemMoiNhat(string maHoaDon)
        {
            return DalHoaDonBan.LayThoiGianThemMoiNhat(maHoaDon);
        }
    }
}
