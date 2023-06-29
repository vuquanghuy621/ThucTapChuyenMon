using BLL;
using GUI.FormThemSua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormLevel2
{
    public partial class Form2HangKhachHang : Form
    {
        private string tenDanhSach;

        public Form2HangKhachHang(string tenDangNhap)
        {
            tenDanhSach = "";

            InitializeComponent();
            dgvDanhSach.DataSource = BllHangKhachHang.LayDanhSachHangKhachHang();
            if (BllNhanVien.LayMaLoaiNhanVien(tenDangNhap) == "0000000002")
            {
                dgvDanhSach.Columns[1].Visible = false;
            }
            TaiLai();
        }

        internal void TaiLai()
        {
            dgvDanhSach.DataSource = BllHangKhachHang.LayDanhSachHangKhachHang();
            tenDanhSach = "Danh sách hạng khách hàng";
            lblTenDanhSach.Text = tenDanhSach;
        }

        private void dgvDanhSach_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvDanhSach.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string tenDangNhap = dgvDanhSach.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (e.ColumnIndex == 1)
            {
                FormSuaHangKhachHang formSuaHangKhachHang = new FormSuaHangKhachHang(this, tenDangNhap);
                formSuaHangKhachHang.ShowDialog();
            }
        }
    }
}
