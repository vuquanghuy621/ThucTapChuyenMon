using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllLoaiDichVu
    {
        public static string LayTenLoaiDichVu(string maLoaiDichVu)
        {
            return DalLoaiDichVu.LayTenLoaiDichVu(maLoaiDichVu);
        }

        public static bool Them(DtoLoaiDichVu dtoLoaiDichVu)
        {
            return DalLoaiDichVu.Them(dtoLoaiDichVu);
        }

        public static bool Sua(DtoLoaiDichVu dtoLoaiDichVu)
        {
            return DalLoaiDichVu.Sua(dtoLoaiDichVu);
        }

        public static bool Xoa(string maLoaiDichVu)
        {
            return DalLoaiDichVu.Xoa(maLoaiDichVu);
        }

        public static DataTable LayDanhSachLoaiDichVu()
        {
            return DalLoaiDichVu.LayDanhSachLoaiDichVu();
        }

        public static DataTable GetDataSourceForComboBox()
        {
            return DalLoaiDichVu.GetDataSourceForComboBox();
        }

        public static bool KiemTraTonTaiMaLoaiDichVu(string maLoaiDichVu)
        {
            return DalLoaiDichVu.KiemTraTonTaiMaLoaiDichVu(maLoaiDichVu);
        }

        public static string TaoMaLoaiDichVuMoi()
        {
            return DalLoaiDichVu.TaoMaLoaiDichVuMoi();
        }

        public static bool KiemTraXoaLoaiDichVu(string maLoaiDichVu)
        {
            return DalLoaiDichVu.KiemTraXoaLoaiDichVu(maLoaiDichVu);
        }
    }
}
