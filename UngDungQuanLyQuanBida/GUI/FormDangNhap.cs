using BLL;
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

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiThoat;
        private FormChinh formChinh;

        public FormDangNhap(FormChinh form)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThoat = true;
            formChinh = form;

            InitializeComponent();
            this.Text = "Đăng nhập";
            this.AcceptButton = btnDangNhap;

            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream(BllThongTinQuan.LayHinhAnh("9999999999"));
                    picHinhAnhQuan.Image = Image.FromStream(memoryStream);
                }
                catch (Exception)
                {
                    this.picHinhAnhQuan.Image = Properties.Resources.ZImageDefault;
                }
            }
            lblTenQuan.Text = BllThongTinQuan.LayTenQuan("9999999999");
            lblThongTinQuan.Text = "Địa chỉ: " + BllThongTinQuan.LayDiaChi("9999999999");
            lblThongTinQuan.Text += "\nSố điện thoại: " + BllThongTinQuan.LaySoDienThoai("9999999999");

            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtMatKhau.UseSystemPasswordChar = true;

            lblLoiTenDangNhap.Text = "Chưa nhập tên đăng nhập!";
            lblLoiMatKhau.Text = "Chưa nhập mật khẩu!";

            panLoiTenDangNhap.Visible = false;
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

            if (lblLoiTenDangNhap.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiTenDangNhap.Text);
                panLoiTenDangNhap.Visible = true;
                txtTenDangNhap.Focus();
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Length == 0)
            {
                lblLoiTenDangNhap.Text = "Tên đăng nhập không được để trống!";
                panLoiTenDangNhap.Visible = true;
            }
            else
            {
                lblLoiTenDangNhap.Text = "";
                panLoiTenDangNhap.Visible = false;
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

        private void btnDangNhap_Click(object sender, EventArgs e)
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

            if (!BllNhanVien.KiemTraDangNhap(txtTenDangNhap.Text, Helper.GetHashStringSHA512(txtMatKhau.Text)))
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
                return;
            }

            if (!BllNhanVien.LayTrangThai(txtTenDangNhap.Text))
            {
                MessageBox.Show("Bạn không thể đăng nhập vì bạn không còn làm việc!", "Thông báo");
                return;
            }

            formChinh.TenDangNhapNhanVien = txtTenDangNhap.Text;
            trangThaiThoat = false;
            Close();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThaiThoat)
            {
                Application.Exit();
            }
        }
    }
}
