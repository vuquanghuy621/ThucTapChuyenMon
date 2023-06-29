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
    public partial class FormDoiMatKhau : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private string tenDangNhapNhanVien;

        public FormDoiMatKhau(string tenDangNhap)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            tenDangNhapNhanVien = tenDangNhap;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Đổi mật khẩu";

            txtMatKhauHienTai.Text = "";
            txtMatKhauMoi.Text = "";
            txtMatKhauMoiNhapLai.Text = "";
            txtMatKhauHienTai.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            txtMatKhauMoiNhapLai.UseSystemPasswordChar = true;

            lblLoiMatKhauHienTai.Text = "Chưa nhập mật khẩu hiện tại!";
            lblLoiMatKhauMoi.Text = "Chưa nhập mật khẩu mới!";
            lblLoiMatKhauMoiNhapLai.Text = "Chưa nhập lại mật khẩu mới!";

            panLoiMatKhauHienTai.Visible = false;
            panLoiMatKhauMoi.Visible = false;
            panLoiMatKhauMoiNhapLai.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiMatKhauMoiNhapLai.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiMatKhauMoiNhapLai.Text);
                panLoiMatKhauMoiNhapLai.Visible = true;
                txtMatKhauMoiNhapLai.Focus();
            }

            if (lblLoiMatKhauMoi.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiMatKhauMoi.Text);
                panLoiMatKhauMoi.Visible = true;
                txtMatKhauMoi.Focus();
            }

            if (lblLoiMatKhauHienTai.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiMatKhauHienTai.Text);
                panLoiMatKhauHienTai.Visible = true;
                txtMatKhauHienTai.Focus();
            }
        }

        private void txtMatKhauHienTai_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhauHienTai.Text.Length == 0)
            {
                lblLoiMatKhauHienTai.Text = "Mật khẩu hiện tại không được để trống!";
                panLoiMatKhauHienTai.Visible = true;
            }
            else if (!Helper.CheckAlphanumericString(txtMatKhauHienTai.Text))
            {
                lblLoiMatKhauHienTai.Text = "Mật khẩu chỉ được chứa các kí tự chữ và số (A-Z/a-z/0-9), không dấu!";
                panLoiMatKhauHienTai.Visible = true;
            }
            else
            {
                lblLoiMatKhauHienTai.Text = "";
                panLoiMatKhauHienTai.Visible = false;
            }
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text.Length == 0)
            {
                lblLoiMatKhauMoi.Text = "Mật khẩu mới không được để trống!";
                panLoiMatKhauMoi.Visible = true;
            }
            else if (!Helper.CheckAlphanumericString(txtMatKhauMoi.Text))
            {
                lblLoiMatKhauMoi.Text = "Mật khẩu chỉ được chứa các kí tự chữ và số (A-Z/a-z/0-9), không dấu!";
                panLoiMatKhauMoi.Visible = true;
            }
            else
            {
                lblLoiMatKhauMoi.Text = "";
                panLoiMatKhauMoi.Visible = false;
            }
        }

        private void txtMatKhauMoiNhapLai_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhauMoiNhapLai.Text.Length == 0)
            {
                lblLoiMatKhauMoiNhapLai.Text = "Mật khẩu mới (nhập lại) không được để trống!";
                panLoiMatKhauMoiNhapLai.Visible = true;
            }
            else if (!Helper.CheckAlphanumericString(txtMatKhauMoiNhapLai.Text))
            {
                lblLoiMatKhauMoiNhapLai.Text = "Mật khẩu chỉ được chứa các kí tự chữ và số (A-Z/a-z/0-9), không dấu!";
                panLoiMatKhauMoi.Visible = true;
            }
            else
            {
                lblLoiMatKhauMoiNhapLai.Text = "";
                panLoiMatKhauMoiNhapLai.Visible = false;
            }
        }

        private void btnHienMatKhauHienTai_Click(object sender, EventArgs e)
        {
            if (txtMatKhauHienTai.UseSystemPasswordChar == true)
            {
                txtMatKhauHienTai.UseSystemPasswordChar = false;
                btnHienMatKhauHienTai.Image = Properties.Resources.Hide_24;
            }
            else
            {
                txtMatKhauHienTai.UseSystemPasswordChar = true;
                btnHienMatKhauHienTai.Image = Properties.Resources.Show_24;
            }
        }

        private void btnHienMatKhauMoi_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.UseSystemPasswordChar == true)
            {
                txtMatKhauMoi.UseSystemPasswordChar = false;
                btnHienMatKhauMoi.Image = Properties.Resources.Hide_24;
            }
            else
            {
                txtMatKhauMoi.UseSystemPasswordChar = true;
                btnHienMatKhauMoi.Image = Properties.Resources.Show_24;
            }
        }

        private void btnHienMatKhauMoiNhapLai_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoiNhapLai.UseSystemPasswordChar == true)
            {
                txtMatKhauMoiNhapLai.UseSystemPasswordChar = false;
                btnHienMatKhauMoiNhapLai.Image = Properties.Resources.Hide_24;
            }
            else
            {
                txtMatKhauMoiNhapLai.UseSystemPasswordChar = true;
                btnHienMatKhauMoiNhapLai.Image = Properties.Resources.Show_24;
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

            if (txtMatKhauMoi.Text != txtMatKhauMoiNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!", "Thông báo");
                return;
            }

            if (!BllNhanVien.KiemTraDangNhap(tenDangNhapNhanVien, Helper.GetHashStringSHA512(txtMatKhauHienTai.Text)))
            {
                MessageBox.Show("Sai mật khẩu hiện tại!", "Thông báo");
                return;
            }

            if (BllNhanVien.DoiMatKhau(Helper.GetHashStringSHA512(txtMatKhauMoi.Text), tenDangNhapNhanVien))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                trangThaiLuu = true;
                Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu không thành công!\nHãy thử lại!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            trangThaiLuu = true;
            Close();
        }

        private void FormDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
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
