using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoNhanVien
    {
        private string tenDangNhap;
        private string matKhau;
        private string hoVaTen;
        private string maLoaiNhanVien;
        private byte[] hinhAnh;
        private DateTime thoiGianThem;
        private bool trangThai;

        public DtoNhanVien()
        {
        }

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string MaLoaiNhanVien { get => maLoaiNhanVien; set => maLoaiNhanVien = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public DateTime ThoiGianThem { get => thoiGianThem; set => thoiGianThem = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
