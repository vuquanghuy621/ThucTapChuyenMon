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
    public partial class Form2KhuVuc : Form
    {
        private string tenDanhSach;

        public Form2KhuVuc(string tenDangNhap)
        {
            InitializeComponent();
            dgvDanhSach.DataSource = BllKhuVuc.LayDanhSachKhuVuc();
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
            dgvDanhSach.DataSource = BllKhuVuc.LayDanhSachKhuVuc();
            tenDanhSach = "Danh sách tất cả loại bàn";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} loại bàn";
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

            if (!BllKhuVuc.KiemTraXoaKhuVuc(dgvDanhSach.Rows[e.RowIndex].Cells[3].Value.ToString()))
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

            string maKhuVuc = dgvDanhSach.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (e.ColumnIndex == 1)
            {
                FormThemSuaKhuVuc formThemSuaKhuVuc = new FormThemSuaKhuVuc(this, maKhuVuc);
                formThemSuaKhuVuc.ShowDialog();
            }

            if (e.ColumnIndex == 2)
            {
                if (!BllKhuVuc.KiemTraXoaKhuVuc(maKhuVuc))
                {
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắc muốn xóa loại " +
                    $"{BllKhuVuc.LayTenKhuVuc(maKhuVuc)} có mã {maKhuVuc}?",
                    "",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (BllKhuVuc.Xoa(maKhuVuc))
                    {
                        dgvDanhSach.Rows.RemoveAt(e.RowIndex);
                        lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} loại bàn";
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại bàn không thành công!\nHãy thử lại!", "Thông báo");
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSuaKhuVuc formThemSuaKhuVuc = new FormThemSuaKhuVuc(this);
            formThemSuaKhuVuc.ShowDialog();
        }
    }
}
