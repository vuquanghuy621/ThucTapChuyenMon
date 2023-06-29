using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoHoaDon
    {
        private string maHoaDon;
        private DateTime thoiGiamThem;
        private string tenDangNhapNhanVien;
        private string soDienThoaiKhachHang;
        private byte khuyenMaiHangKhachHang;
        private byte khuyenMaiNgay;
        private bool trangThai;

        public DtoHoaDon()
        {
        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public DateTime ThoiGiamThem { get => thoiGiamThem; set => thoiGiamThem = value; }
        public string TenDangNhapNhanVien { get => tenDangNhapNhanVien; set => tenDangNhapNhanVien = value; }
        public string SoDienThoaiKhachHang { get => soDienThoaiKhachHang; set => soDienThoaiKhachHang = value; }
        public byte KhuyenMaiHangKhachHang { get => khuyenMaiHangKhachHang; set => khuyenMaiHangKhachHang = value; }
        public byte KhuyenMaiNgay { get => khuyenMaiNgay; set => khuyenMaiNgay = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
