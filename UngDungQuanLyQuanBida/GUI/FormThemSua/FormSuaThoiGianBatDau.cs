using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormThemSua
{
    public partial class FormSuaThoiGianBatDau : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private FormThemSuaHoaDon formThemSuaHoaDon;
        private DateTime thoiGianThem;

        public FormSuaThoiGianBatDau(FormThemSuaHoaDon form, DateTime thoiGianThem)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            formThemSuaHoaDon = form;
            this.thoiGianThem = thoiGianThem;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thời gian bắt đầu";

            txtThoiGianBatDauCu.Text = BllHoaDonBan.LayThoiGianBatDau(thoiGianThem).ToString("HH:mm dd/MM/yyyy");
            txtThoiGianKetThuc.Text = BllHoaDonBan.LayThoiGianKetThuc(thoiGianThem).ToString("HH:mm dd/MM/yyyy");
            dtpThoiGianBatDauMoi.Value = BllHoaDonBan.LayThoiGianBatDau(thoiGianThem);

            lblLoiThoiGianBatDauMoi.Text = "";

            panLoiThoiGianBatDauMoi.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiThoiGianBatDauMoi.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiThoiGianBatDauMoi.Text);
                panLoiThoiGianBatDauMoi.Visible = true;
                dtpThoiGianBatDauMoi.Focus();
            }
        }

        private void dtpThoiGianBatDauMoi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpThoiGianBatDauMoi.Value >= BllHoaDonBan.LayThoiGianKetThuc(thoiGianThem))
            {
                lblLoiThoiGianBatDauMoi.Text = "Thời gian bắt đầu phải trước hơn thời gian kết thúc!";
                panLoiThoiGianBatDauMoi.Visible = true;
            }
            else
            {
                lblLoiThoiGianBatDauMoi.Text = "";
                panLoiThoiGianBatDauMoi.Visible = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KiemSoatLoiNhapLieu();

            if (danhSachLoiNhapLieu.Count > 0)
            {
                for (int i = danhSachLoiNhapLieu.Count - 1; i >= 0; i--)
                {
                    loiNhapLieu += $"- {danhSachLoiNhapLieu[i]}\n";
                }
                MessageBox.Show(loiNhapLieu, "Lỗi nhập liệu");
                return;
            }

            if (BllHoaDonBan.SuaThoiGianBatDau(dtpThoiGianBatDauMoi.Value, thoiGianThem))
            {
                formThemSuaHoaDon.TaiLai();
                MessageBox.Show("Sửa thành công!", "Thông báo");
                trangThaiLuu = true;
                Close();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!\nHãy thử lại!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            trangThaiLuu = true;
            Close();
        }

        private void FormSuaThoiGianBatDau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!trangThaiLuu)
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn chưa lưu!\nVẫn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
