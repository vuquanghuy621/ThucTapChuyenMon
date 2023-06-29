using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoLoaiDichVu
    {
        private string maLoaiDichVu;
        private string tenLoaiDichVu;

        public DtoLoaiDichVu()
        {
        }

        public string MaLoaiDichVu { get => maLoaiDichVu; set => maLoaiDichVu = value; }
        public string TenLoaiDichVu { get => tenLoaiDichVu; set => tenLoaiDichVu = value; }
    }
}
