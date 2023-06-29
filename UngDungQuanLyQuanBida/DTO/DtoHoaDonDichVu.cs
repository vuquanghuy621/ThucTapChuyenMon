using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoHoaDonDichVu
    {
        private DateTime thoiGianThem;
        private string maHoaDon;
        private string maDichVu;
        private long gia;
        private int soLuong;

        public DtoHoaDonDichVu()
        {
        }

        public DateTime ThoiGianThem { get => thoiGianThem; set => thoiGianThem = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public long Gia { get => gia; set => gia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
