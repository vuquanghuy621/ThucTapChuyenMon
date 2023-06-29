using BLL;
using GUI.FormThemSua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormLevel1
{
    public partial class Form1TaiKhoan : Form
    {
        private FormChinh formChinh;
        private string tenDangNhapNhanVien;

        public string TenDangNhapNhanVien { get => tenDangNhapNhanVien; set => tenDangNhapNhanVien = value; }

        public Form1TaiKhoan(FormChinh form, string tenDangNhap)
        {
            formChinh = form;
            TenDangNhapNhanVien = tenDangNhap;

            InitializeComponent();
            txtTenDangNhap.Text = TenDangNhapNhanVien;

            TaiLai();
        }

        internal void TaiLai()
        {
            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream(BllNhanVien.LayHinhAnh(TenDangNhapNhanVien));
                    picHinhAnh.Image = Image.FromStream(memoryStream);
                }
                catch (Exception)
                {
                    picHinhAnh.Image = Properties.Resources.ZImageDefault;
                }
            }
            txtTenDangNhap.Text = tenDangNhapNhanVien;
            txtHoVaTen.Text = BllNhanVien.LayHoVaTen(TenDangNhapNhanVien);
            txtLoaiNhanVien.Text = BllLoaiNhanVien.LayTenLoaiNhanVien(BllNhanVien.LayMaLoaiNhanVien(TenDangNhapNhanVien));
            txtNgayThem.Text = BllNhanVien.LayThoiGianThem(TenDangNhapNhanVien).ToString("dd/MM/yyyy");
            txtTrangThai.Text = BllNhanVien.LayTrangThai(TenDangNhapNhanVien) ? "Còn làm việc" : "Không còn làm việc";
        }

        private void btnSuaThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FormSuaThongTinCaNhan formSuaThongTinCaNhan = new FormSuaThongTinCaNhan(formChinh, this, TenDangNhapNhanVien);
            formSuaThongTinCaNhan.ShowDialog();
        }

        private void btnDoiTenDangNhap_Click(object sender, EventArgs e)
        {
            FormDoiTenDangNhap formDoiTenDangNhap = new FormDoiTenDangNhap(this, TenDangNhapNhanVien);
            formDoiTenDangNhap.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau formDoiMatKhau = new FormDoiMatKhau(tenDangNhapNhanVien);
            formDoiMatKhau.ShowDialog();
        }
    }
}
