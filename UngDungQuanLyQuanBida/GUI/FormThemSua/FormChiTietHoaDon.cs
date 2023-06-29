using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormThemSua
{
    public partial class FormChiTietHoaDon : Form
    {
        public FormChiTietHoaDon(string maHoaDon)
        {
            InitializeComponent();
            this.Text = "Thông tin hóa đơn";

            txtMaHoaDon.Text = maHoaDon;
            txtThoiGianThem.Text = BllHoaDon.LayThoiGiamThem(maHoaDon).ToString("dd/MM/yyyy HH:mm");
            txtNhanVien.Text = $"{BllNhanVien.LayHoVaTen(BllHoaDon.LayTenDangNhapNhanVien(maHoaDon))}";
            if (BllHoaDon.LaySoDienThoaiKhachHang(maHoaDon) == "")
            {
                txtKhachHang.Text = "Khách lẻ";
            }
            else
            {
                txtKhachHang.Text = $"{BllKhachHang.LayHoVaTen(BllHoaDon.LaySoDienThoaiKhachHang(maHoaDon))} (SĐT: {BllHoaDon.LaySoDienThoaiKhachHang(maHoaDon)})";
            }
            txtKhuyenMaiHangKhachHang.Text = BllHoaDon.LayKhuyenMaiHangKhachHang(maHoaDon).ToString() + "%";
            txtKhuyenMaiNgay.Text = BllHoaDon.LayKhuyenMaiNgay(maHoaDon).ToString() + "%";
            txtTienBan.Text = BllHoaDon.LayTienBan(maHoaDon).ToString("C0");
            txtTienDichVu.Text = BllHoaDon.LayTienDichVu(maHoaDon).ToString("C0");
            txtTienHoaDon.Text = BllHoaDon.LayTienHoaDon(maHoaDon).ToString("C0");
            txtTienKhuyenMaiHangKhachHang.Text = BllHoaDon.LayTienKhuyenMaiHangKhachHang(maHoaDon).ToString("C0");
            txtTienKhuyenMaiNgay.Text = BllHoaDon.LayTienKhuyenMaiNgay(maHoaDon).ToString("C0");
            txtTienPhaiThanhToan.Text = BllHoaDon.LayTienPhaiThanhToan(maHoaDon).ToString("C0");
            dgvDanhSachHoaDonBan.DataSource = BllHoaDon.LayDanhSachHoaDonBan(maHoaDon);
            dgvDanhSachHoaDonDichVu.DataSource = BllHoaDon.LayDanhSachHoaDonDichVu(maHoaDon);
        }

        private void dgvDanhSachHoaDon_Ban_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvDanhSachHoaDonBan.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvDanhSachHoaDon_DichVu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvDanhSachHoaDonDichVu.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
