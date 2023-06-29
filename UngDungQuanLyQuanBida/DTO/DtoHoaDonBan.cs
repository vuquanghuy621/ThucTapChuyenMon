using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoHoaDonBan
    {
        private DateTime thoiGianThem;
        private string maHoaDon;
        private string maBan;
        private long gia;
        private DateTime thoiGianBatDau;
        private DateTime thoiGianKetThuc;

        public DtoHoaDonBan()
        {
        }

        public DateTime ThoiGianThem { get => thoiGianThem; set => thoiGianThem = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaBan { get => maBan; set => maBan = value; }
        public long Gia { get => gia; set => gia = value; }
        public DateTime ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public DateTime ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
    }
}
