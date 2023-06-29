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
    public partial class Form2DichVu : Form
    {
        private string tenDanhSach;

        public Form2DichVu(string tenDangNhap)
        {
            tenDanhSach = "";

            InitializeComponent();
            dgvDanhSach.DataSource = BllDichVu.LayDanhSachDichVu();
            {
                cboLoaiDichVu.DataSource = BllLoaiDichVu.GetDataSourceForComboBox();
                cboLoaiDichVu.ValueMember = "maLoaiDichVu";
                cboLoaiDichVu.DisplayMember = "tenLoaiDichVu";
            }
            if (BllNhanVien.LayMaLoaiNhanVien(tenDangNhap) == "0000000002")
            {
                btnThem.Visible = false;
                panBottom.Height = 10;
                dgvDanhSach.Columns[1].Visible = false;
                dgvDanhSach.Columns[2].Visible = false;
            }
            txtTimKiem.Text = "";
            cboLoaiDichVu.SelectedIndex = -1;
            TaiLai();
        }

        internal void TaiLai()
        {
            txtTimKiem.Text = "";
            cboLoaiDichVu.SelectedIndex = -1;

            dgvDanhSach.DataSource = BllDichVu.LayDanhSachDichVu();
            tenDanhSach = "Danh sách tất cả dịch vụ";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} dịch vụ";
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

            cboLoaiDichVu.SelectedIndex = -1;

            dgvDanhSach.DataSource = BllDichVu.LayDanhSachDichVu_timKiem(txtTimKiem.Text);
            this.tenDanhSach = $"Kết quả tìm kiếm \"{txtTimKiem.Text}\"";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} dịch vụ";
        }

        private void cboLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiDichVu.SelectedIndex == -1)
            {
                return;
            }

            txtTimKiem.Text = "";

            dgvDanhSach.DataSource = BllDichVu.LayDanhSachDichVu_maLoaiDichVu(cboLoaiDichVu.SelectedValue.ToString());
            tenDanhSach = $"Danh sách {cboLoaiDichVu.Text.ToLower()}";
            lblTenDanhSach.Text = $"{tenDanhSach}: {dgvDanhSach.RowCount} dịch vụ";
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

            if (!BllDichVu.KiemTraXoaDichVu(dgvDanhSach.Rows[e.RowIndex].Cells[4].Value.ToString()))
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

            string maDichVu = dgvDanhSach.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (e.ColumnIndex == 1)
            {
                FormThemSuaDichVu formThemSuaDichVu = new FormThemSuaDichVu(this, maDichVu);
                formThemSuaDichVu.Height = 900;
                formThemSuaDichVu.ShowDialog();
            }

            if (e.ColumnIndex == 2)
            {
                if (!BllDichVu.KiemTraXoaDichVu(maDichVu))
                {
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắc muốn xóa dịch vụ " +
                    $"{BllDichVu.LayTenDichVu(maDichVu)} có mã {maDichVu}?",
                    "",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (BllDichVu.Xoa(maDichVu))
                    {
                        dgvDanhSach.Rows.RemoveAt(e.RowIndex);
                        lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} dịch vụ";
                    }
                    else
                    {
                        MessageBox.Show("Xóa dịch vụ không thành công!\nHãy thử lại!", "Thông báo");
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSuaDichVu formThemSuaDichVu = new FormThemSuaDichVu(this);
            formThemSuaDichVu.Height = 900;
            formThemSuaDichVu.ShowDialog();
        }
    }
}
