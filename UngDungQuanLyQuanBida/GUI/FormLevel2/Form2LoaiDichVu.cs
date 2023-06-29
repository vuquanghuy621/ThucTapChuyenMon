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
    public partial class Form2LoaiDichVu : Form
    {
        private string tenDanhSach;

        public Form2LoaiDichVu(string tenDangNhap)
        {
            InitializeComponent();
            dgvDanhSach.DataSource = BllLoaiDichVu.LayDanhSachLoaiDichVu();
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
            dgvDanhSach.DataSource = BllLoaiDichVu.LayDanhSachLoaiDichVu();
            tenDanhSach = "Danh sách tất cả loại dịch vụ";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} loại dịch vụ";
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

            if (!BllLoaiDichVu.KiemTraXoaLoaiDichVu(dgvDanhSach.Rows[e.RowIndex].Cells[3].Value.ToString()))
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

            string maLoaiDichVu = dgvDanhSach.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (e.ColumnIndex == 1)
            {
                FormThemSuaLoaiDichVu formThemSuaLoaiDichVu = new FormThemSuaLoaiDichVu(this, maLoaiDichVu);
                formThemSuaLoaiDichVu.ShowDialog();
            }

            if (e.ColumnIndex == 2)
            {
                if (!BllLoaiDichVu.KiemTraXoaLoaiDichVu(maLoaiDichVu))
                {
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắc muốn xóa loại " +
                    $"{BllLoaiDichVu.LayTenLoaiDichVu(maLoaiDichVu)} có mã {maLoaiDichVu}?",
                    "",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (BllLoaiDichVu.Xoa(maLoaiDichVu))
                    {
                        dgvDanhSach.Rows.RemoveAt(e.RowIndex);
                        lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} loại dịch vụ";
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại dịch vụ không thành công!\nHãy thử lại!", "Thông báo");
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSuaLoaiDichVu formThemSuaLoaiDichVu = new FormThemSuaLoaiDichVu(this);
            formThemSuaLoaiDichVu.ShowDialog();
        }
    }
}
