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
    public partial class FormThemSuaNhanVien : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiThem;
        private bool trangThaiLuu;
        private Form1NhanVien form1NhanVien;

        public FormThemSuaNhanVien(Form1NhanVien form)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = true;
            trangThaiLuu = false;
            form1NhanVien = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm nhân viên mới";
            {
                cboLoaiNhanVien.DataSource = BllLoaiNhanVien.GetDataSourceForComboBox();
                cboLoaiNhanVien.ValueMember = "maLoaiNhanVien";
                cboLoaiNhanVien.DisplayMember = "tenLoaiNhanVien";
            }

            txtTenDangNhap.Text = "";
            txtHoVaTen.Text = "";
            cboLoaiNhanVien.SelectedIndex = -1;
            picHinhAnhNhanVien.Image = Properties.Resources.ZImageDefault;
            radConLamViec.Checked = false;
            radKhongConLamViec.Checked = false;

            lblLoiTenDangNhap.Text = "Chưa nhập tên đăng nhập!";
            lblLoiHoVaTen.Text = "Chưa nhập họ và tên!";
            lblLoiLoaiNhanVien.Text = "Chưa chọn loại nhân viên!";
            lblLoiTrangThai.Text = "Chưa chọn trạng thái!";

            panLoiTenDangNhap.Visible = false;
            panLoiHoVaTen.Visible = false;
            panLoiLoaiNhanVien.Visible = false;
            panLoiTrangThai.Visible = false;
        }

        public FormThemSuaNhanVien(Form1NhanVien form, string tenDangNhap)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = false;
            trangThaiLuu = false;
            form1NhanVien = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thông tin nhân viên";
            {
                cboLoaiNhanVien.DataSource = BllLoaiNhanVien.GetDataSourceForComboBox();
                cboLoaiNhanVien.ValueMember = "maLoaiNhanVien";
                cboLoaiNhanVien.DisplayMember = "tenLoaiNhanVien";
            }

            txtTenDangNhap.Text = tenDangNhap;
            txtTenDangNhap.ReadOnly = true;
            txtHoVaTen.Text = BllNhanVien.LayHoVaTen(tenDangNhap);
            cboLoaiNhanVien.SelectedValue = BllNhanVien.LayMaLoaiNhanVien(tenDangNhap);
            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream(BllNhanVien.LayHinhAnh(tenDangNhap));
                    picHinhAnhNhanVien.Image = Image.FromStream(memoryStream);
                }
                catch (Exception)
                {
                    picHinhAnhNhanVien.Image = Properties.Resources.ZImageDefault;
                }
            }
            {
                if (BllNhanVien.LayTrangThai(tenDangNhap))
                    radConLamViec.Checked = true;
                else
                    radKhongConLamViec.Checked = true;
            }

            lblLoiTenDangNhap.Text = "";
            lblLoiHoVaTen.Text = "";
            lblLoiLoaiNhanVien.Text = "";
            lblLoiTrangThai.Text = "";

            panLoiTenDangNhap.Visible = false;
            panLoiHoVaTen.Visible = false;
            panLoiLoaiNhanVien.Visible = false;
            panLoiTrangThai.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiTrangThai.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiTrangThai.Text);
                panLoiTrangThai.Visible = true;
            }

            if (lblLoiLoaiNhanVien.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiLoaiNhanVien.Text);
                panLoiLoaiNhanVien.Visible = true;
                cboLoaiNhanVien.Focus();
            }

            if (lblLoiHoVaTen.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiHoVaTen.Text);
                panLoiHoVaTen.Visible = true;
                txtHoVaTen.Focus();
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
            else if (!Helper.CheckAlphanumericString(txtTenDangNhap.Text))
            {
                lblLoiTenDangNhap.Text = "Tên đăng nhập chỉ được chứa các kí tự chữ và số (A-Z/a-z/0-9), không dấu!";
                panLoiTenDangNhap.Visible = true;
            }
            else if (BllNhanVien.KiemTraTrungTenDangNhap(txtTenDangNhap.Text))
            {
                lblLoiTenDangNhap.Text = $"Tên đăng nhập này đã tồn tại!";
                panLoiTenDangNhap.Visible = true;
            }
            else if (txtTenDangNhap.Text.Length > 20)
            {
                lblLoiTenDangNhap.Text = $"Tên đăng nhập không được dài hơn 20 kí tự, dư {txtTenDangNhap.Text.Length - 20} kí tự!";
                panLoiTenDangNhap.Visible = true;
            }
            else
            {
                lblLoiTenDangNhap.Text = "";
                panLoiTenDangNhap.Visible = false;
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

        private void cboLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiNhanVien.SelectedIndex == -1)
            {
                lblLoiLoaiNhanVien.Text = "Chưa chọn loại nhân viên!";
                panLoiLoaiNhanVien.Visible = true;
            }
            else
            {
                lblLoiLoaiNhanVien.Text = "";
                panLoiLoaiNhanVien.Visible = false;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh nhân viên";
            openFileDialog.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnhNhanVien.ImageLocation = openFileDialog.FileName;
            }
        }

        private void radConLamViec_CheckedChanged(object sender, EventArgs e)
        {
            lblLoiTrangThai.Text = "";
            panLoiTrangThai.Visible = false;
        }

        private void radKhongConLamViec_CheckedChanged(object sender, EventArgs e)
        {
            lblLoiTrangThai.Text = "";
            panLoiTrangThai.Visible = false;
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
            dtoNhanVien.TenDangNhap = txtTenDangNhap.Text;
            dtoNhanVien.MatKhau = Helper.GetHashStringSHA512("1");
            dtoNhanVien.HoVaTen = txtHoVaTen.Text;
            dtoNhanVien.MaLoaiNhanVien = cboLoaiNhanVien.SelectedValue.ToString();
            {
                MemoryStream memoryStream = new MemoryStream();
                picHinhAnhNhanVien.Image.Save(memoryStream, picHinhAnhNhanVien.Image.RawFormat);
                dtoNhanVien.HinhAnh = memoryStream.ToArray();
            }
            dtoNhanVien.TrangThai = radConLamViec.Checked;

            if (trangThaiThem)
            {
                dtoNhanVien.ThoiGianThem = DateTime.Now;
                if (BllNhanVien.Them(dtoNhanVien))
                {
                    form1NhanVien.TaiLai();
                    foreach (DataGridViewRow item in form1NhanVien.dgvDanhSach.Rows)
                    {
                        if (item.Cells[4].Value.ToString() == txtTenDangNhap.Text)
                        {
                            form1NhanVien.dgvDanhSach.CurrentCell = item.Cells[4];
                        }
                    }
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    trangThaiLuu = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!\nHãy thử lại!", "Thông báo");
                }
            }

            if (!trangThaiThem)
            {
                if (BllNhanVien.SuaThongTin(dtoNhanVien))
                {
                    form1NhanVien.dgvDanhSach.CurrentRow.Cells[3].Value = BllNhanVien.LayThoiGianThem(txtTenDangNhap.Text);
                    form1NhanVien.dgvDanhSach.CurrentRow.Cells[4].Value = txtTenDangNhap.Text;
                    form1NhanVien.dgvDanhSach.CurrentRow.Cells[5].Value = BllNhanVien.LayHoVaTen(txtTenDangNhap.Text);
                    form1NhanVien.dgvDanhSach.CurrentRow.Cells[6].Value = BllLoaiNhanVien.LayTenLoaiNhanVien(BllNhanVien.LayMaLoaiNhanVien(txtTenDangNhap.Text));
                    form1NhanVien.dgvDanhSach.CurrentRow.Cells[7].Value = BllNhanVien.LayHinhAnh(txtTenDangNhap.Text);
                    form1NhanVien.dgvDanhSach.CurrentRow.Cells[8].Value = BllNhanVien.LayTrangThai(txtTenDangNhap.Text) ? "Còn làm việc" : "Không còn làm việc";
                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo");
                    trangThaiLuu = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công!\nHãy thử lại!", "Thông báo");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            trangThaiLuu = true;
            Close();
        }

        private void FormThemSuaNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
