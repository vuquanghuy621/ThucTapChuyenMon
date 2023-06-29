using BLL;
using DTO;
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

namespace GUI.FormLevel1
{
    public partial class Form1HoaDon : Form
    {
        private string tenDanhSach;

        public Form1HoaDon()
        {
            InitializeComponent();
            dgvDanhSach.DataSource = BllKhachHang.LayDanhSachKhachHang();
            {
                cboKhachHang.DataSource = BllKhachHang.GetDataSourceForComboBox();
                cboKhachHang.ValueMember = "soDienThoai";
                cboKhachHang.DisplayMember = "khachHang";
            }
            cboKhachHang.SelectedIndex = -1;
            TaiLai();
        }

        internal void TaiLai()
        {
            cboKhachHang.SelectedIndex = -1;

            radHomNay.Checked = false;
            radHomNay.Checked = true;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiLai();
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedIndex == -1)
            {
                return;
            }

            if (cboKhachHang.SelectedValue.ToString() == "0000000000")
            {
                dgvDanhSach.DataSource = BllHoaDon.LayDanhSachHoaDon_khachLe();
                tenDanhSach = $"Danh sách hóa đơn của khách lẻ";
                lblTenDanhSach.Text = $"{tenDanhSach}: {dgvDanhSach.RowCount} hóa đơn";
                return;
            }

            radHomNay.Checked = false;
            radTuanNay.Checked = false;
            radThangNay.Checked = false;
            radTatCa.Checked = false;

            dgvDanhSach.DataSource = BllHoaDon.LayDanhSachHoaDon_soDienThoaiKhachHang(cboKhachHang.Text);
            tenDanhSach = $"Danh sách hóa đơn của khách hàng {cboKhachHang.Text}";
            lblTenDanhSach.Text = $"{tenDanhSach}: {dgvDanhSach.RowCount} hóa đơn";
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            cboKhachHang.SelectedIndex = -1;
            radHomNay.Checked = false;
            radTuanNay.Checked = false;
            radThangNay.Checked = false;
            radTatCa.Checked = false;

            dgvDanhSach.DataSource = BllHoaDon.LayDanhSachHoaDon_ngay(dtpNgay.Value);
            tenDanhSach = $"Danh sách hóa đơn ngày {dtpNgay.Value.ToString("dd/MM/yyyy")}";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} hóa đơn";
        }

        private void radHomNay_CheckedChanged(object sender, EventArgs e)
        {
            if (radHomNay.Checked)
            {
                cboKhachHang.SelectedIndex = -1;

                dgvDanhSach.DataSource = BllHoaDon.LayDanhSachHoaDon_ngay(DateTime.Now);
                tenDanhSach = $"Danh sách hóa đơn hôm nay, ngày {DateTime.Now.ToString("dd/MM/yyyy")}";
                lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} hóa đơn";
            }
        }

        private void radTuanNay_CheckedChanged(object sender, EventArgs e)
        {
            if (radTuanNay.Checked)
            {
                cboKhachHang.SelectedIndex = -1;

                dgvDanhSach.DataSource = BllHoaDon.LayDanhSachHoaDon_tuan(DateTime.Now);
                tenDanhSach = "Danh sách hóa đơn tuần này";
                lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} hóa đơn";
            }
        }

        private void radThangNay_CheckedChanged(object sender, EventArgs e)
        {
            if (radThangNay.Checked)
            {
                cboKhachHang.SelectedIndex = -1;

                dgvDanhSach.DataSource = BllHoaDon.LayDanhSachHoaDon_thang(DateTime.Now);
                tenDanhSach = "Danh sách hóa đơn tháng này";
                lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} hóa đơn";
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                cboKhachHang.SelectedIndex = -1;

                dgvDanhSach.DataSource = BllHoaDon.LayDanhSachHoaDon();
                tenDanhSach = "Danh sách tất cả hóa đơn";
                lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} hóa đơn";
            }
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

            if (e.ColumnIndex == 1)
            {
                string maDichVu = dgvDanhSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormChiTietHoaDon formChiTietHoaDon = new FormChiTietHoaDon(maDichVu);
                formChiTietHoaDon.ShowDialog();
            }
        }
    }
}
