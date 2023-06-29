using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoKhachHang
    { 
        private string soDienThoai;
        private string hoVaTen;
        private string maHangKhachHang;
        private DateTime thoiGianThem;

        public DtoKhachHang()
        {
        }

        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string MaHangKhachHang { get => maHangKhachHang; set => maHangKhachHang = value; }
        public DateTime ThoiGianThem { get => thoiGianThem; set => thoiGianThem = value; }
    }
}
