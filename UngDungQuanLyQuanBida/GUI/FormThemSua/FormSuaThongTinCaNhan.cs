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
    public partial class FormSuaThongTinCaNhan : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private FormChinh formChinh;
        private Form1TaiKhoan form1TaiKhoan;
        private string tenDangNhapNhanVien;

        public FormSuaThongTinCaNhan(FormChinh form1, Form1TaiKhoan form2, string tenDangNhap)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            formChinh = form1;
            form1TaiKhoan = form2;
            tenDangNhapNhanVien = tenDangNhap;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thông tin cá nhân";

            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream(BllNhanVien.LayHinhAnh(tenDangNhap));
                    picHinhAnh.Image = Image.FromStream(memoryStream);
                }
                catch (Exception)
                {
                    this.picHinhAnh.Image = Properties.Resources.ZImageDefault;
                }
            }
            txtHoVaTen.Text = BllNhanVien.LayHoVaTen(tenDangNhap);

            lblLoiHoVaTen.Text = "";

            panLoiHoVaTen.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiHoVaTen.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiHoVaTen.Text);
                panLoiHoVaTen.Visible = true;
                txtHoVaTen.Focus();
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh nhân viên";
            openFileDialog.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.ImageLocation = openFileDialog.FileName;
            }
        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text.Length == 0)
            {
                lblLoiHoVaTen.Text = "Họ và tên không được để trống!";
                panLoiHoVaTen.Visible = true;
            }
            else
            {
                lblLoiHoVaTen.Text = "";
                panLoiHoVaTen.Visible = false;
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

            DtoNhanVien dtoNhanVien = new DtoNhanVien();
            dtoNhanVien.TenDangNhap = tenDangNhapNhanVien;
            dtoNhanVien.HoVaTen = txtHoVaTen.Text;
            dtoNhanVien.MaLoaiNhanVien = BllNhanVien.LayMaLoaiNhanVien(tenDangNhapNhanVien);
            {
                MemoryStream memoryStream = new MemoryStream();
                picHinhAnh.Image.Save(memoryStream, picHinhAnh.Image.RawFormat);
                dtoNhanVien.HinhAnh = memoryStream.ToArray();
            }
            dtoNhanVien.TrangThai = BllNhanVien.LayTrangThai(tenDangNhapNhanVien);

            if (BllNhanVien.SuaThongTin(dtoNhanVien))
            {
                formChinh.TaiLai();
                form1TaiKhoan.TaiLai();
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

        private void FormSuaThongTinCaNhan_FormClosing(object sender, FormClosingEventArgs e)
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
