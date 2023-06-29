using BLL;
using DTO;
using GUI.FormLevel1;
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
    public partial class FormDoiTenDangNhap : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private Form1TaiKhoan form1TaiKhoan;
        private string tenDangNhapNhanVien;

        public FormDoiTenDangNhap(Form1TaiKhoan form, string tenDangNhap)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            form1TaiKhoan = form;
            tenDangNhapNhanVien = tenDangNhap;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Đổi tên đăng nhập";

            txtTenDangNhapMoi.Text = "";
            txtMatKhau.Text = "";
            txtMatKhau.UseSystemPasswordChar = true;

            lblLoiTenDangNhapMoi.Text = "Chưa nhập tên đăng nhập mới!";
            lblLoiMatKhau.Text = "Chưa nhập mật khẩu!";

            panLoiTenDangNhapMoi.Visible = false;
            panLoiMatKhau.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiMatKhau.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiMatKhau.Text);
                panLoiMatKhau.Visible = true;
                txtMatKhau.Focus();
            }

            if (lblLoiTenDangNhapMoi.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiTenDangNhapMoi.Text);
                panLoiTenDangNhapMoi.Visible = true;
                txtTenDangNhapMoi.Focus();
            }
        }

        private void txtTenDangNhapMoi_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDangNhapMoi.Text.Length == 0)
            {
                lblLoiTenDangNhapMoi.Text = "Tên đăng nhập mới không được để trống!";
                panLoiTenDangNhapMoi.Visible = true;
            }
            else if (!Helper.CheckAlphanumericString(txtTenDangNhapMoi.Text))
            {
                lblLoiTenDangNhapMoi.Text = "Tên đăng nhập chỉ được chứa các kí tự chữ và số (A-Z/a-z/0-9), không dấu!";
                panLoiTenDangNhapMoi.Visible = true;
            }
            else if (txtTenDangNhapMoi.Text == tenDangNhapNhanVien)
            {
                lblLoiTenDangNhapMoi.Text = $"Tên đăng nhập mới trùng với tên đăng nhập hiện tại!";
                panLoiTenDangNhapMoi.Visible = true;
            }
            else if (BllNhanVien.KiemTraTrungTenDangNhap(txtTenDangNhapMoi.Text))
            {
                lblLoiTenDangNhapMoi.Text = $"Tên đăng nhập này đã tồn tại!";
                panLoiTenDangNhapMoi.Visible = true;
            }
            else if (txtTenDangNhapMoi.Text.Length > 20)
            {
                lblLoiTenDangNhapMoi.Text = $"Tên đăng nhập không được dài hơn 20 kí tự, dư {txtTenDangNhapMoi.Text.Length - 20} kí tự!";
                panLoiTenDangNhapMoi.Visible = true;
            }
            else
            {
                lblLoiTenDangNhapMoi.Text = "";
                panLoiTenDangNhapMoi.Visible = false;
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length == 0)
            {
                lblLoiMatKhau.Text = "Mật khẩu không được để trống!";
                panLoiMatKhau.Visible = true;
            }
            else
            {
                lblLoiMatKhau.Text = "";
                panLoiMatKhau.Visible = false;
            }
        }

        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                btnHienMatKhau.Image = Properties.Resources.Hide_24;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                btnHienMatKhau.Image = Properties.Resources.Show_24;
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

            if (!BllNhanVien.KiemTraDangNhap(tenDangNhapNhanVien, Helper.GetHashStringSHA512(txtMatKhau.Text)))
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo");
                return;
            }

            if (BllNhanVien.DoiTenDangNhap(txtTenDangNhapMoi.Text, tenDangNhapNhanVien))
            {
                form1TaiKhoan.TenDangNhapNhanVien = txtTenDangNhapMoi.Text;
                form1TaiKhoan.TaiLai();
                MessageBox.Show("Đổi tên đăng nhập thành công!", "Thông báo");
                trangThaiLuu = true;
                Close();
            }
            else
            {
                MessageBox.Show("Đổi tên đăng nhập không thành công!\nHãy thử lại!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            trangThaiLuu = true;
            Close();
        }

        private void FormDoiTenDangNhap_FormClosing(object sender, FormClosingEventArgs e)
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
