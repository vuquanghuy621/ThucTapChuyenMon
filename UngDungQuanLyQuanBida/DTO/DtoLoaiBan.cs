using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoLoaiBan
    {
        private string maLoaiBan;
        private string tenLoaiBan;

        public DtoLoaiBan()
        {
        }

        public string MaLoaiBan { get => maLoaiBan; set => maLoaiBan = value; }
        public string TenLoaiBan { get => tenLoaiBan; set => tenLoaiBan = value; }
    }
}
