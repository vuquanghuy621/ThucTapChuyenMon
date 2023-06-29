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

namespace GUI.FormLevel1
{
    public partial class Form1KhuyenMai : Form
    {
        private string tenDanhSach;
        private DateTime ngay;

        public Form1KhuyenMai(string tenDangNhap)
        {
            InitializeComponent();
            dgvDanhSach.DataSource = BllNgayCoKhuyenMai.LayDanhSachNgayCoKhuyenMai();
            if (BllNhanVien.LayMaLoaiNhanVien(tenDangNhap) == "0000000002")
            {
                btnThem.Visible = false;
                panBottom.Height = 10;
                dgvDanhSach.Columns[1].Visible = false;
                dgvDanhSach.Columns[2].Visible = false;
            }
            TaiLai();
        }

        internal void TaiLai()
        {
            dgvDanhSach.DataSource = BllNgayCoKhuyenMai.LayDanhSachNgayCoKhuyenMai();
            tenDanhSach = "Danh sách tất cả ngày có khuyến mãi";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} ngày";
        }

        private void dgvDanhSach_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            ngay = Convert.ToDateTime(dgvDanhSach.Rows[e.RowIndex].Cells[3].Value);

            if (e.ColumnIndex == 1 && ngay.Date < DateTime.Now.Date)
            {
                e.PaintBackground(e.ClipBounds, true);
                e.Handled = true;
            }

            if (e.ColumnIndex == 2 && ngay.Date <= DateTime.Now.Date)
            {
                e.PaintBackground(e.ClipBounds, true);
                e.Handled = true;
            }
        }

        private void dgvDanhSach_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvDanhSach.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            ngay = Convert.ToDateTime(dgvDanhSach.Rows[e.RowIndex].Cells[3].Value);
            if (ngay.Date == DateTime.Now.Date)
            {
                dgvDanhSach.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DateTime ngay = Convert.ToDateTime(dgvDanhSach.Rows[e.RowIndex].Cells[3].Value);

            if (e.ColumnIndex == 1)
            {
                if (ngay.Date < DateTime.Now.Date)
                {
                    return;
                }

                FormThemSuaKhuyenMai formThemSuaKhuyenMai = new FormThemSuaKhuyenMai(this, ngay);
                formThemSuaKhuyenMai.ShowDialog();
            }

            if (e.ColumnIndex == 2)
            {
                if (ngay.Date <= DateTime.Now.Date)
                {
                    return;
                }

                DialogResult dialogResult = MessageBox.Show($"Bạn chắc chắc muốn xóa khuyến mãi ngày {Convert.ToDateTime(dgvDanhSach.Rows[e.RowIndex].Cells[3].Value).ToString("dd/MM/yyyy")}?",
                    "",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (BllNgayCoKhuyenMai.Xoa(ngay))
                    {
                        dgvDanhSach.Rows.RemoveAt(e.RowIndex);
                        lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} ngày";
                    }
                    else
                    {
                        MessageBox.Show("Xóa khuyến mãi không thành công!\nHãy thử lại!", "Thông báo");
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSuaKhuyenMai formThemSuaKhuyenMai = new FormThemSuaKhuyenMai(this);
            formThemSuaKhuyenMai.ShowDialog();
        }
    }
}
