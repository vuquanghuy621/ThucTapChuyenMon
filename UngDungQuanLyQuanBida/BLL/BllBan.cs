using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllBan
    {
        public static string LaySoBan()
        {
            return DalBan.LaySoBan();
        }

        public static string LaySoBanTrong()
        {
            return DalBan.LaySoBanTrong();
        }

        public static string LaySoBanCoKhach()
        {
            return DalBan.LaySoBanCoKhach();
        }

        public static string LayTenBan(string maBan)
        {
            return DalBan.LayTenBan(maBan);
        }

        public static string LayMaLoaiBan(string maBan)
        {
            return DalBan.LayMaLoaiBan(maBan);
        }

        public static string LayMaKhuVuc(string maBan)
        {
            return DalBan.LayMaKhuVuc(maBan);
        }

        public static long LayGia(string maBan)
        {
            return DalBan.LayGia(maBan);
        }

        public static bool LayTrangThai(string maBan)
        {
            return DalBan.LayTrangThai(maBan);
        }

        public static bool Them(DtoBan dtoBan)
        {
            return DalBan.Them(dtoBan);
        }

        public static bool Sua(DtoBan dtoBan)
        {
            return DalBan.Sua(dtoBan);
        }

        public static bool SuaTrangThai(bool trangThai, string maBan)
        {
            return DalBan.SuaTrangThai(trangThai, maBan);
        }

        public static bool Xoa(string maBan)
        {
            return DalBan.Xoa(maBan);
        }

        public static DataTable LayDanhSachBan()
        {
            return DalBan.LayDanhSachBan();
        }

        public static DataTable LayDanhSachBan_maLoaiBan(string maLoaiBan)
        {
            return DalBan.LayDanhSachBan_maLoaiBan(maLoaiBan);
        }

        public static DataTable LayDanhSachBan_maKhuVuc(string maKhuVuc)
        {
            return DalBan.LayDanhSachBan_maKhuVuc(maKhuVuc);
        }

        public static DataTable LayDanhSachBanTrong()
        {
            return DalBan.LayDanhSachBanTrong();
        }

        public static bool KiemTraTonTaiMaBan(string maBan)
        {
            return DalBan.KiemTraTonTaiMaBan(maBan);
        }

        public static string TaoMaBanMoi()
        {
            return DalBan.TaoMaBanMoi();
        }

        public static bool KiemTraXoaBan(string maBan)
        {
            return DalBan.KiemTraXoaBan(maBan);
        }
    }
}
