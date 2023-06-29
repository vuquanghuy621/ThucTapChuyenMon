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
    public class BllNgayCoKhuyenMai
    {
        public static string LayMoTa(DateTime ngay)
        {
            return DalNgayCoKhuyenMai.LayMoTa(ngay);
        }
        public static byte LayKhuyenMai(DateTime ngay)
        {
            return DalNgayCoKhuyenMai.LayKhuyenMai(ngay);
        }

        public static bool Them(DtoNgayCoKhuyenMai dtoNgayCoKhuyenMai)
        {
            return DalNgayCoKhuyenMai.Them(dtoNgayCoKhuyenMai);
        }

        public static bool Sua(DtoNgayCoKhuyenMai dtoNgayCoKhuyenMai)
        {
            return DalNgayCoKhuyenMai.Sua(dtoNgayCoKhuyenMai);
        }

        public static bool Xoa(DateTime ngay)
        {
            return DalNgayCoKhuyenMai.Xoa(ngay);
        }

        public static DataTable LayDanhSachNgayCoKhuyenMai()
        {
            return DalNgayCoKhuyenMai.LayDanhSachNgayCoKhuyenMai();
        }
    }
}
