using BLL;
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

namespace GUI
{
    public partial class FormChinh : Form
    {
        private string tenDangNhapNhanVien;

        public string TenDangNhapNhanVien { get => tenDangNhapNhanVien; set => tenDangNhapNhanVien = value; }

        public FormChinh()
        {
            tenDangNhapNhanVien = "";

            InitializeComponent();

            Hide();
            FormDangNhap formDangNhap = new FormDangNhap(this);
            formDangNhap.ShowDialog();
            Show();
            TaiLai();
            foreach (Control item in panMenu.Controls)
            {
                item.BackColor = default;
            }
            btnSanh.BackColor = Color.FromArgb(4, 170, 109);
            OpenChildForm(new Form1Sanh(tenDangNhapNhanVien));
        }

        internal void TaiLai()
        {
            this.Text = BllThongTinQuan.LayTenQuan("9999999999");

            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream(BllNhanVien.LayHinhAnh(tenDangNhapNhanVien));
                    picHinhAnhNhanVien.Image = Image.FromStream(memoryStream);
                }
                catch (Exception)
                {
                    picHinhAnhNhanVien.Image = Properties.Resources.ZImageDefault;
                }
            }
        }

        private void OpenChildForm(Form form)
        {
            foreach (Form item in panChinh.Controls)
            {
                item.Close();
            }

            panChinh.Controls.Clear();

            form.TopLevel = false;
            form.WindowState = FormWindowState.Normal;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panChinh.Controls.Add(form);
            form.Show();
        }

        private void picHinhAnhNhanVien_Click(object sender, EventArgs e)
        {
            mnuTaiKhoan.Show(picHinhAnhNhanVien, 0, picHinhAnhNhanVien.Height - 10);
        }

        private void itmTaiKhoan_Click(object sender, EventArgs e)
        {
            foreach (Control item in panMenu.Controls)
            {
                item.BackColor = default;
            }

            OpenChildForm(new Form1TaiKhoan(this, tenDangNhapNhanVien));
        }

        private void itmThongTinQuan_Click(object sender, EventArgs e)
        {
            foreach (Control item in panMenu.Controls)
            {
                item.BackColor = default;
            }

            OpenChildForm(new Form1ThongTinQuan(this, TenDangNhapNhanVien));
        }

        private void itmDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            FormDangNhap formDangNhap = new FormDangNhap(this);
            formDangNhap.ShowDialog();
            Show();
            TaiLai();
            foreach (Control item in panMenu.Controls)
            {
                item.BackColor = default;
            }
            btnSanh.BackColor = Color.FromArgb(4, 170, 109);
            OpenChildForm(new Form1Sanh(tenDangNhapNhanVien));
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            foreach (Control item in panMenu.Controls)
            {
                item.BackColor = default;
            }

            btn.BackColor = Color.FromArgb(4, 170, 109);

            switch (btn.Name)
            {
                case "btnSanh":
                    OpenChildForm(new Form1Sanh(tenDangNhapNhanVien));
                    break;
                case "btnBan":
                    OpenChildForm(new Form1Ban(tenDangNhapNhanVien));
                    break;
                case "btnNhanVien":
                    OpenChildForm(new Form1NhanVien(tenDangNhapNhanVien));
                    break;
                case "btnKhachHang":
                    OpenChildForm(new Form1KhachHang(tenDangNhapNhanVien));
                    break;
                case "btnDichVu":
                    OpenChildForm(new Form1DichVu(tenDangNhapNhanVien));
                    break;
                case "btnKhuyenMai":
                    OpenChildForm(new Form1KhuyenMai(tenDangNhapNhanVien));
                    break;
                case "btnHoaDon":
                    OpenChildForm(new Form1HoaDon());
                    break;
                case "btnThongKe":
                    OpenChildForm(new Form1ThongKe());
                    break;
            }
        }
    }
}
