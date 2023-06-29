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

namespace GUI.FormLevel2
{
    public partial class Form2KhachHang : Form
    {
        private string tenDanhSach;

        public Form2KhachHang()
        {
            InitializeComponent();
            dgvDanhSach.DataSource = BllKhachHang.LayDanhSachKhachHang();
            {
                cboHangKhachHang.DataSource = BllHangKhachHang.GetDataSourceForComboBox();
                cboHangKhachHang.ValueMember = "maHangKhachHang";
                cboHangKhachHang.DisplayMember = "tenHangKhachHang";
            }
            txtTimKiem.Text = "";
            cboHangKhachHang.SelectedIndex = -1;
            TaiLai();
        }

        internal void TaiLai()
        {
            txtTimKiem.Text = "";
            cboHangKhachHang.SelectedIndex = -1;

            dgvDanhSach.DataSource = BllKhachHang.LayDanhSachKhachHang();
            tenDanhSach = "Danh sách tất cả khách hàng";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} khách hàng";
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

            cboHangKhachHang.SelectedIndex = -1;

            dgvDanhSach.DataSource = BllKhachHang.LayDanhSachKhachHang_timKiem(txtTimKiem.Text);
            this.tenDanhSach = $"Kết quả tìm kiếm \"{txtTimKiem.Text}\"";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} khách hàng";
        }

        private void cboHangKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHangKhachHang.SelectedIndex == -1)
            {
                return;
            }

            txtTimKiem.Text = "";

            dgvDanhSach.DataSource = BllKhachHang.LayDanhSachKhachHang_maHangKhachHang(cboHangKhachHang.SelectedValue.ToString());
            tenDanhSach = $"Danh sách khách hàng hạng {cboHangKhachHang.Text}";
            lblTenDanhSach.Text = $"{tenDanhSach}: {dgvDanhSach.RowCount} khách hàng";
        }

        private void dgvDanhSach_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex != 2)
            {
                return;
            }

            if (!BllKhachHang.KiemTraXoaKhachHang(dgvDanhSach.Rows[e.RowIndex].Cells[4].Value.ToString()))
            {
                e.PaintBackground(e.ClipBounds, true);
                e.Handled = true;
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

            string soDienThoai = dgvDanhSach.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (e.ColumnIndex == 1)
            {
                FormThemSuaKhachHang formThemSuaKhachHang = new FormThemSuaKhachHang(this, soDienThoai);
                formThemSuaKhachHang.ShowDialog();
            }

            if (e.ColumnIndex == 2)
            {
                if (!BllKhachHang.KiemTraXoaKhachHang(soDienThoai))
                {
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắc muốn xóa khách hàng " +
                    $"{BllKhachHang.LayHoVaTen(soDienThoai)} có số điện thoại là {soDienThoai}?",
                    "",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (BllKhachHang.Xoa(soDienThoai))
                    {
                        dgvDanhSach.Rows.RemoveAt(e.RowIndex);
                        lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} khách hàng";
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
            FormThemSuaKhachHang formThemSuaKhachHang = new FormThemSuaKhachHang(this);
            formThemSuaKhachHang.ShowDialog();
        }
    }
}
