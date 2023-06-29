using BLL;
using DTO;
using GUI.FormLevel1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormThemSua
{
    public partial class FormSuaBan : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private FormThemSuaHoaDon formThemSuaHoaDon;
        private DateTime thoiGianThem;
        private string maBanCu;

        public FormSuaBan(FormThemSuaHoaDon form, DateTime thoiGianThem)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            formThemSuaHoaDon = form;
            this.thoiGianThem = thoiGianThem;
            maBanCu = BllHoaDonBan.LayMaBan(thoiGianThem);

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa bàn";
            {
                cboBanMoi.DataSource = BllBan.LayDanhSachBanTrong();
                cboBanMoi.ValueMember = "maBan";
                cboBanMoi.DisplayMember = "tenBan";
            }

            txtBanHienTai.Text = BllBan.LayTenBan(BllHoaDonBan.LayMaBan(thoiGianThem));
            cboBanMoi.SelectedIndex = -1;

            lblLoiBanMoi.Text = "Chưa chọn bàn mới!";

            panLoiBanMoi.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiBanMoi.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiBanMoi.Text);
                panLoiBanMoi.Visible = true;
                cboBanMoi.Focus();
            }
        }

        private void cboBanMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBanMoi.SelectedIndex == -1)
            {
                lblLoiBanMoi.Text = "Chưa chọn bàn mới!";
                panLoiBanMoi.Visible = true;
            }
            else
            {
                lblLoiBanMoi.Text = "";
                panLoiBanMoi.Visible = false;
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

            if (BllBan.LayTrangThai(BllHoaDonBan.LayMaBan(thoiGianThem)))
            {
                BllBan.SuaTrangThai(false, maBanCu);
                BllBan.SuaTrangThai(true, cboBanMoi.SelectedValue.ToString());
            }

            if (BllHoaDonBan.SuaMaBan(cboBanMoi.SelectedValue.ToString(), thoiGianThem))
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

        private void FormSuaBan_FormClosing(object sender, FormClosingEventArgs e)
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
