using BLL;
using DTO;
using GUI.FormThemSua;
using GUI.MyUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormLevel1
{
    public partial class Form1Sanh : Form
    {
        private DataTable dataTable;
        private string tenDanhSach;
        private string tenDangNhapNhanVien;

        public Form1Sanh(string tenDangNhap)
        {
            dataTable = new DataTable();
            tenDanhSach = "";
            tenDangNhapNhanVien = tenDangNhap;

            InitializeComponent();
            {
                cboLoaiBan.DataSource = BllLoaiBan.GetDataSourceForComboBox();
                cboLoaiBan.ValueMember = "maLoaiBan";
                cboLoaiBan.DisplayMember = "tenLoaiBan";
            }
            {
                cboKhuVuc.DataSource = BllKhuVuc.GetDataSourceForComboBox();
                cboKhuVuc.ValueMember = "maKhuVuc";
                cboKhuVuc.DisplayMember = "tenKhuVuc";
            }

            TaiLai();
        }

        private void ban_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;

            string maBan = control.Tag.ToString();

            if (BllBan.LayTrangThai(maBan))
            {
                FormThemSuaHoaDon formThemSuaHoaDon = new FormThemSuaHoaDon(BllHoaDonBan.LayMaHoaDonDangSuDung(maBan));
                formThemSuaHoaDon.ShowDialog();
            }
            else
            {
                //Tạo hóa đơn
                string maHoaDon = BllHoaDon.TaoMaHoaDonMoi();
                DateTime thoiGianThem = DateTime.Now;
                DtoHoaDon dtoHoaDon = new DtoHoaDon();
                dtoHoaDon.MaHoaDon = maHoaDon;
                dtoHoaDon.ThoiGiamThem = thoiGianThem;
                dtoHoaDon.TenDangNhapNhanVien = tenDangNhapNhanVien;
                dtoHoaDon.SoDienThoaiKhachHang = "0000000000";
                dtoHoaDon.KhuyenMaiHangKhachHang = 0;
                dtoHoaDon.KhuyenMaiNgay = 0;
                dtoHoaDon.TrangThai = false;
                BllHoaDon.Them(dtoHoaDon);

                //Thêm bàn hiện tại vào hóa đơn
                DtoHoaDonBan dtoHoaDonBan = new DtoHoaDonBan();
                dtoHoaDonBan.ThoiGianThem = thoiGianThem;
                dtoHoaDonBan.MaHoaDon = maHoaDon;
                dtoHoaDonBan.MaBan = control.Tag.ToString();
                dtoHoaDonBan.ThoiGianBatDau = thoiGianThem;
                dtoHoaDonBan.ThoiGianKetThuc = thoiGianThem;
                BllHoaDonBan.Them(dtoHoaDonBan);

                BllBan.SuaTrangThai(true, control.Tag.ToString());

                FormThemSuaHoaDon formThemSuaHoaDon = new FormThemSuaHoaDon(maHoaDon);
                formThemSuaHoaDon.ShowDialog();
            }
            TaiLai();
        }

        internal void TaiLai()
        {
            cboLoaiBan.SelectedIndex = -1;
            cboKhuVuc.SelectedIndex = -1;
            panDanhSach.Controls.Clear();

            dataTable = BllBan.LayDanhSachBan();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                UcBan ucBan = new UcBan(dataRow[0].ToString());
                ucBan.lblThongTinBan.Click += ban_Click;
                ucBan.lblTenBan.Click += ban_Click;
                ucBan.lblGia.Click += ban_Click;
                panDanhSach.Controls.Add(ucBan);
            }

            tenDanhSach = "Danh sách tất cả bàn";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dataTable.Rows.Count} bàn";

            lblDoanhThuHomNay.Text = "Doanh thu hôm nay ngày "
                + DateTime.Now.ToString("dd/MM/yyyy")
                + ": "
                + BllHoaDon.LayDoanhThuHomNay().ToString("C0");

            lblTrangThai.Text = "Số bàn có khách: "
                + BllBan.LaySoBanCoKhach()
                + " | "
                + "Số bàn trống: "
                + BllBan.LaySoBanTrong()
                + " | "
                + "Tất cả: "
                + BllBan.LaySoBan();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiLai();
        }

        private void cboLoaiBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiBan.SelectedIndex == -1)
            {
                return;
            }

            cboKhuVuc.SelectedIndex = -1;
            panDanhSach.Controls.Clear();

            dataTable = BllBan.LayDanhSachBan_maLoaiBan(cboLoaiBan.SelectedValue.ToString());

            foreach (DataRow dataRow in dataTable.Rows)
            {
                UcBan ucBan = new UcBan(dataRow[0].ToString());
                ucBan.lblThongTinBan.Click += ban_Click;
                ucBan.lblTenBan.Click += ban_Click;
                ucBan.lblGia.Click += ban_Click;
                panDanhSach.Controls.Add(ucBan);
            }

            tenDanhSach = $"Danh sách {cboLoaiBan.Text}";
            lblTenDanhSach.Text = $"{tenDanhSach}: {dataTable.Rows.Count} bàn";
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhuVuc.SelectedIndex == -1)
            {
                return;
            }

            cboLoaiBan.SelectedIndex = -1;
            panDanhSach.Controls.Clear();

            dataTable = BllBan.LayDanhSachBan_maKhuVuc(cboKhuVuc.SelectedValue.ToString());

            foreach (DataRow dataRow in dataTable.Rows)
            {
                UcBan ucBan = new UcBan(dataRow[0].ToString());
                ucBan.lblThongTinBan.Click += ban_Click;
                ucBan.lblTenBan.Click += ban_Click;
                ucBan.lblGia.Click += ban_Click;
                panDanhSach.Controls.Add(ucBan);
            }

            tenDanhSach = $"Danh sách {cboKhuVuc.Text}";
            lblTenDanhSach.Text = $"{tenDanhSach}: {dataTable.Rows.Count} bàn";
        }
    }
}
