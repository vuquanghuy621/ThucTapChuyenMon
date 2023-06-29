using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoBan
    {
        private string maBan;
        private string tenBan;
        private string maLoaiBan;
        private string maKhuVuc;
        private long gia;
        private bool trangThai;

        public DtoBan()
        {
        }

        public string MaBan { get => maBan; set => maBan = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string MaLoaiBan { get => maLoaiBan; set => maLoaiBan = value; }
        public string MaKhuVuc { get => maKhuVuc; set => maKhuVuc = value; }
        public long Gia { get => gia; set => gia = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
