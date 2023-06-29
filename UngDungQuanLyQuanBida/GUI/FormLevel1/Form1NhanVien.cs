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
    public partial class Form1NhanVien : Form
    {
        private string tenDanhSach;

        public Form1NhanVien(string tenDangNhap)
        {
            tenDanhSach = "";

            InitializeComponent();
            dgvDanhSach.DataSource = BllNhanVien.LayDanhSachNhanVien();
            {
                cboLoaiNhanVien.DataSource = BllLoaiNhanVien.GetDataSourceForComboBox();
                cboLoaiNhanVien.ValueMember = "maLoaiNhanVien";
                cboLoaiNhanVien.DisplayMember = "tenLoaiNhanVien";
            }
            //Chỉ nhân viên quản lý gốc mới có quyền thêm sửa xóa nhân viên
            if (BllNhanVien.LayThoiGianThem(tenDangNhap) != new DateTime(2000, 01, 01))
            {
                btnThem.Visible = false;
                panBottom.Height = 10;
                dgvDanhSach.Columns[1].Visible = false;
                dgvDanhSach.Columns[2].Visible = false;
            }
            txtTimKiem.Text = "";
            cboLoaiNhanVien.SelectedIndex = -1;
            TaiLai();
        }

        internal void TaiLai()
        {
            txtTimKiem.Text = "";
            cboLoaiNhanVien.SelectedIndex = -1;

            dgvDanhSach.DataSource = BllNhanVien.LayDanhSachNhanVien();
            tenDanhSach = "Danh sách tất cả nhân viên";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} nhân viên";
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiLai();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            if (txtTimKiem.Text.Length == 0)
            {
                return;
            }

            cboLoaiNhanVien.SelectedIndex = -1;

            dgvDanhSach.DataSource = BllNhanVien.LayDanhSachNhanVien_timKiem(txtTimKiem.Text);
            this.tenDanhSach = $"Kết quả tìm kiếm \"{txtTimKiem.Text}\"";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} nhân viên";
        }

        private void cboLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiNhanVien.SelectedIndex == -1)
            {
                return;
            }

            txtTimKiem.Text = "";

            dgvDanhSach.DataSource = BllNhanVien.LayDanhSachNhanVien_maLoaiNhanVien(cboLoaiNhanVien.SelectedValue.ToString());
            tenDanhSach = $"Danh sách {cboLoaiNhanVien.Text.ToLower()}";
            lblTenDanhSach.Text = $"{tenDanhSach}: {dgvDanhSach.RowCount} nhân viên";
        }

        private void dgvDanhSach_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 2)
            {
                if (!BllNhanVien.KiemTraXoaNhanVien(dgvDanhSach.Rows[e.RowIndex].Cells[4].Value.ToString()))
                {
                    e.PaintBackground(e.ClipBounds, true);
                    e.Handled = true;
                }
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

            string tenDangNhap = dgvDanhSach.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (e.ColumnIndex == 1)
            {
                FormThemSuaNhanVien formThemSuaNhanVien = new FormThemSuaNhanVien(this, tenDangNhap);
                formThemSuaNhanVien.Height = 900;
                formThemSuaNhanVien.ShowDialog();
            }

            if (e.ColumnIndex == 2)
            {
                if (!BllNhanVien.KiemTraXoaNhanVien(tenDangNhap))
                {
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắc muốn xóa nhân viên " +
                    $"{BllNhanVien.LayHoVaTen(tenDangNhap)} có tên đăng nhập là {tenDangNhap}?",
                    "",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (BllNhanVien.Xoa(tenDangNhap))
                    {
                        dgvDanhSach.Rows.RemoveAt(e.RowIndex);
                        lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} nhân viên";
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!\nHãy thử lại!", "Thông báo");
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSuaNhanVien formThemSuaNhanVien = new FormThemSuaNhanVien(this);
            formThemSuaNhanVien.Height = 900;
            formThemSuaNhanVien.ShowDialog();
        }
    }
}
