using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoThongTinQuan
    {
        private string maQuan;
        private string tenQuan;
        private string diaChi;
        private string soDienThoai;
        private byte[] hinhAnh;

        public DtoThongTinQuan()
        {
        }

        public string MaQuan { get => maQuan; set => maQuan = value; }
        public string TenQuan { get => tenQuan; set => tenQuan = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}
