using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoLoaiNhanVien
    {
        private string maLoaiNhanVien;
        private string tenLoaiNhanVien;

        public DtoLoaiNhanVien()
        {
        }

        public string MaLoaiNhanVien { get => maLoaiNhanVien; set => maLoaiNhanVien = value; }
        public string TenLoaiNhanVien { get => tenLoaiNhanVien; set => tenLoaiNhanVien = value; }
    }
}
