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
    public partial class Form2Ban : Form
    {
        private string tenDanhSach;

        public Form2Ban(string tenDangNhap)
        {
            InitializeComponent();
            dgvDanhSach.DataSource = BllBan.LayDanhSachBan();
            if (BllNhanVien.LayMaLoaiNhanVien(tenDangNhap) == "0000000002")
            {
                btnThem.Visible = false;
                panBottom.Height = 10;
                dgvDanhSach.Columns[1].Visible = false;
                dgvDanhSach.Columns[2].Visible = false;
            }
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
            cboLoaiBan.SelectedIndex = -1;
            cboKhuVuc.SelectedIndex = -1;
            TaiLai();
        }

        internal void TaiLai()
        {
            cboLoaiBan.SelectedIndex = -1;
            cboKhuVuc.SelectedIndex = -1;

            dgvDanhSach.DataSource = BllBan.LayDanhSachBan();
            tenDanhSach = "Danh sách tất cả bàn";
            lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} bàn";
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

            dgvDanhSach.DataSource = BllBan.LayDanhSachBan_maLoaiBan(cboLoaiBan.SelectedValue.ToString());
            tenDanhSach = $"Danh sách bàn {cboLoaiBan.Text}";
            lblTenDanhSach.Text = $"{tenDanhSach}: {dgvDanhSach.RowCount} bàn";
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhuVuc.SelectedIndex == -1)
            {
                return;
            }

            cboLoaiBan.SelectedIndex = -1;

            dgvDanhSach.DataSource = BllBan.LayDanhSachBan_maKhuVuc(cboKhuVuc.SelectedValue.ToString());
            tenDanhSach = $"Danh sách bàn ở {cboKhuVuc.Text}";
            lblTenDanhSach.Text = $"{tenDanhSach}: {dgvDanhSach.RowCount} bàn";
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

            if (!BllBan.KiemTraXoaBan(dgvDanhSach.Rows[e.RowIndex].Cells[3].Value.ToString()))
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

            string maBan = dgvDanhSach.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (e.ColumnIndex == 1)
            {
                FormThemSuaBan formThemSuaBan = new FormThemSuaBan(this, maBan);
                formThemSuaBan.ShowDialog();
            }

            if (e.ColumnIndex == 2)
            {
                if (!BllBan.KiemTraXoaBan(maBan))
                {
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắc muốn xóa " +
                    $"{BllBan.LayTenBan(maBan)} có mã {maBan}?",
                    "",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (BllBan.Xoa(maBan))
                    {
                        dgvDanhSach.Rows.RemoveAt(e.RowIndex);
                        lblTenDanhSach.Text = $"{this.tenDanhSach}: {dgvDanhSach.RowCount} bàn";
                    }
                    else
                    {
                        MessageBox.Show("Xóa bàn không thành công!\nHãy thử lại!", "Thông báo");
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSuaBan formThemSuaBan = new FormThemSuaBan(this);
            formThemSuaBan.ShowDialog();
        }
    }
}
