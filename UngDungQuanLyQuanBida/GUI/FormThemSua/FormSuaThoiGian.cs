using BLL;
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
    public partial class FormSuaThoiGian : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private FormThemSuaHoaDon formThemSuaHoaDon;
        private DateTime thoiGianThem;

        public FormSuaThoiGian(FormThemSuaHoaDon form, DateTime thoiGianThem)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            formThemSuaHoaDon = form;
            this.thoiGianThem = thoiGianThem;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thời gian bắt đầu";

            dtpThoiGianBatDauCu.Value = BllHoaDonBan.LayThoiGianBatDau(thoiGianThem);
            dtpThoiGianKetThucCu.Value = BllHoaDonBan.LayThoiGianKetThuc(thoiGianThem);
            dtpThoiGianBatDauMoi.Value = BllHoaDonBan.LayThoiGianBatDau(thoiGianThem);
            dtpThoiGianKetThucMoi.Value = BllHoaDonBan.LayThoiGianKetThuc(thoiGianThem);

            lblLoiThoiGian.Text = "";

            panLoiThoiGian.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiThoiGian.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiThoiGian.Text);
                panLoiThoiGian.Visible = true;
                dtpThoiGianBatDauMoi.Focus();
            }
        }

        private void dtpThoiGianBatDauMoi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpThoiGianBatDauMoi.Value >= dtpThoiGianKetThucMoi.Value)
            {
                lblLoiThoiGian.Text = "Thời gian bắt đầu phải trước thời gian kết thúc!";
                panLoiThoiGian.Visible = true;
            }
            else
            {
                lblLoiThoiGian.Text = "";
                panLoiThoiGian.Visible = false;
            }
        }

        private void dtpThoiGianKetThucMoi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpThoiGianBatDauMoi.Value >= dtpThoiGianKetThucMoi.Value)
            {
                lblLoiThoiGian.Text = "Thời gian bắt đầu phải trước thời gian kết thúc!";
                panLoiThoiGian.Visible = true;
            }
            else
            {
                lblLoiThoiGian.Text = "";
                panLoiThoiGian.Visible = false;
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

            BllHoaDonBan.SuaThoiGianBatDau(dtpThoiGianBatDauMoi.Value, thoiGianThem);
            BllHoaDonBan.SuaThoiGianKetThuc(dtpThoiGianKetThucMoi.Value, thoiGianThem);

            formThemSuaHoaDon.TaiLai();
            MessageBox.Show("Sửa thành công!", "Thông báo");
            trangThaiLuu = true;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            trangThaiLuu = true;
            Close();
        }

        private void FormSuaThoiGian_FormClosing(object sender, FormClosingEventArgs e)
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
