using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoHangKhachHang
    {
        private string maHangKhachHang;
        private string tenHangKhachHang;
        private long doanhSoDatToi;
        private byte khuyenMai;

        public DtoHangKhachHang()
        {
        }

        public string MaHangKhachHang { get => maHangKhachHang; set => maHangKhachHang = value; }
        public string TenHangKhachHang { get => tenHangKhachHang; set => tenHangKhachHang = value; }
        public long DoanhSoDatToi { get => doanhSoDatToi; set => doanhSoDatToi = value; }
        public byte KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
    }
}
