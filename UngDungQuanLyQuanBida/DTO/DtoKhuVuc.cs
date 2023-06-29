using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoKhuVuc
    {
        private string maKhuVuc;
        private string tenKhuVuc;

        public DtoKhuVuc()
        {
        }

        public string MaKhuVuc { get => maKhuVuc; set => maKhuVuc = value; }
        public string TenKhuVuc { get => tenKhuVuc; set => tenKhuVuc = value; }
    }
}
