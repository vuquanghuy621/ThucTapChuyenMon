using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoNgayCoKhuyenMai
    {
        private DateTime ngay;
        private string moTa;
        private byte khuyenMai;

        public DtoNgayCoKhuyenMai()
        {
        }

        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public byte KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
    }
}
