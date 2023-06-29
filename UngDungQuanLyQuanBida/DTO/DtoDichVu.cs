using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoDichVu
    {
        private string maDichVu;
        private string tenDichVu;
        private string maLoaiDichVu;
        private byte[] hinhAnh;
        private long gia;
        private DateTime thoiGianThem;
        private bool trangThai;

        public DtoDichVu()
        {
        }

        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public string MaLoaiDichVu { get => maLoaiDichVu; set => maLoaiDichVu = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public long Gia { get => gia; set => gia = value; }
        public DateTime ThoiGianThem { get => thoiGianThem; set => thoiGianThem = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
