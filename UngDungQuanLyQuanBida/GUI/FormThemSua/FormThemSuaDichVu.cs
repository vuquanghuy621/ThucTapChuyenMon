using BLL;
using DTO;
using GUI.FormLevel2;
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
    public partial class FormThemSuaDichVu : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiThem;
        private bool trangThaiLuu;
        private Form2DichVu form2DichVu;

        public FormThemSuaDichVu(Form2DichVu form)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = true;
            trangThaiLuu = false;
            form2DichVu = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm dịch vụ mới";
            {
                cboLoaiDichVu.DataSource = BllLoaiDichVu.GetDataSourceForComboBox();
                cboLoaiDichVu.ValueMember = "maLoaiDichVu";
                cboLoaiDichVu.DisplayMember = "tenLoaiDichVu";
            }

            txtMaDichVu.Text = BllDichVu.TaoMaDichVuMoi();
            txtTenDichVu.Text = "";
            cboLoaiDichVu.SelectedIndex = -1;
            picHinhAnhDichVu.Image = Properties.Resources.ZImageDefault;
            txtGia.Text = "";
            radConKinhDoanh.Checked = false;
            radKhongConKinhDoanh.Checked = false;

            lblLoiTenDichVu.Text = "Chưa nhập tên dịch vụ!";
            lblLoiLoaiDichVu.Text = "Chưa chọn loại dịch vụ!";
            lblLoiGia.Text = "Chưa nhập giá!";
            lblLoiTrangThai.Text = "Chưa chọn trạng thái!";

            panLoiTenDichVu.Visible = false;
            panLoiLoaiDichVu.Visible = false;
            panLoiGia.Visible = false;
            panLoiTrangThai.Visible = false;
        }

        public FormThemSuaDichVu(Form2DichVu form, string maDichVu)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = false;
            trangThaiLuu = false;
            form2DichVu = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thông tin dịch vụ";
            {
                cboLoaiDichVu.DataSource = BllLoaiDichVu.GetDataSourceForComboBox();
                cboLoaiDichVu.ValueMember = "maLoaiDichVu";
                cboLoaiDichVu.DisplayMember = "tenLoaiDichVu";
            }

            txtMaDichVu.Text = maDichVu;
            txtTenDichVu.Text = BllDichVu.LayTenDichVu(maDichVu);
            cboLoaiDichVu.SelectedValue = BllDichVu.LayMaLoaiDichVu(maDichVu);
            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream(BllDichVu.LayHinhAnh(maDichVu));
                    picHinhAnhDichVu.Image = Image.FromStream(memoryStream);
                }
                catch (Exception)
                {
                    picHinhAnhDichVu.Image = Properties.Resources.ZImageDefault;
                }
            }
            txtGia.Text = BllDichVu.LayGia(maDichVu).ToString();
            {
                if (BllDichVu.LayTrangThai(maDichVu))
                    radConKinhDoanh.Checked = true;
                else
                    radKhongConKinhDoanh.Checked = true;
            }

            lblLoiTenDichVu.Text = "";
            lblLoiLoaiDichVu.Text = "";
            lblLoiGia.Text = "";
            lblLoiTrangThai.Text = "";

            panLoiTenDichVu.Visible = false;
            panLoiLoaiDichVu.Visible = false;
            panLoiGia.Visible = false;
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

            if (lblLoiGia.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiGia.Text);
                panLoiGia.Visible = true;
                txtGia.Focus();
            }

            if (lblLoiLoaiDichVu.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiLoaiDichVu.Text);
                panLoiLoaiDichVu.Visible = true;
                cboLoaiDichVu.Focus();
            }

            if (lblLoiTenDichVu.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiTenDichVu.Text);
                panLoiTenDichVu.Visible = true;
                txtTenDichVu.Focus();
            }
        }

        private void txtTenDichVu_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDichVu.Text.Length == 0)
            {
                lblLoiTenDichVu.Text = "Tên dịch vụ không được để trống!";
                panLoiTenDichVu.Visible = true;
            }
            else
            {
                lblLoiTenDichVu.Text = "";
                panLoiTenDichVu.Visible = false;
            }
        }

        private void cboLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiDichVu.SelectedIndex == -1)
            {
                lblLoiLoaiDichVu.Text = "Chưa chọn loại dịch vụ!";
                panLoiLoaiDichVu.Visible = true;
            }
            else
            {
                lblLoiLoaiDichVu.Text = "";
                panLoiLoaiDichVu.Visible = false;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh dịch vụ";
            openFileDialog.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnhDichVu.ImageLocation = openFileDialog.FileName;
            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (txtGia.Text.Length == 0)
            {
                lblLoiGia.Text = "Giá không được để trống!";
                panLoiGia.Visible = true;
            }
            else if (!Helper.CheckNumberString(txtGia.Text))
            {
                lblLoiGia.Text = "Giá phải là một số nguyên dương!";
                panLoiGia.Visible = true;
            }
            else
            {
                lblLoiGia.Text = "";
                panLoiGia.Visible = false;
            }
        }

        private void radConKinhDoanh_CheckedChanged(object sender, EventArgs e)
        {
            lblLoiTrangThai.Text = "";
            panLoiTrangThai.Visible = false;
        }

        private void radKhongConKinhDoanh_CheckedChanged(object sender, EventArgs e)
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

            DtoDichVu dtoDichVu = new DtoDichVu();
            dtoDichVu.MaDichVu = txtMaDichVu.Text;
            dtoDichVu.TenDichVu = txtTenDichVu.Text;
            dtoDichVu.MaLoaiDichVu = cboLoaiDichVu.SelectedValue.ToString();
            {
                MemoryStream memoryStream = new MemoryStream();
                picHinhAnhDichVu.Image.Save(memoryStream, picHinhAnhDichVu.Image.RawFormat);
                dtoDichVu.HinhAnh = memoryStream.ToArray();
            }
            dtoDichVu.Gia = Convert.ToInt64(txtGia.Text);
            dtoDichVu.TrangThai = radConKinhDoanh.Checked;

            if (trangThaiThem)
            {
                dtoDichVu.ThoiGianThem = DateTime.Now;
                if (BllDichVu.Them(dtoDichVu))
                {
                    form2DichVu.TaiLai();
                    foreach (DataGridViewRow item in form2DichVu.dgvDanhSach.Rows)
                    {
                        if (item.Cells[4].Value.ToString() == txtMaDichVu.Text)
                        {
                            form2DichVu.dgvDanhSach.CurrentCell = item.Cells[4];
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
                if (BllDichVu.Sua(dtoDichVu))
                {
                    form2DichVu.dgvDanhSach.CurrentRow.Cells[5].Value = BllDichVu.LayTenDichVu(txtMaDichVu.Text);
                    form2DichVu.dgvDanhSach.CurrentRow.Cells[6].Value = BllLoaiDichVu.LayTenLoaiDichVu(BllDichVu.LayMaLoaiDichVu(txtMaDichVu.Text));
                    form2DichVu.dgvDanhSach.CurrentRow.Cells[7].Value = BllDichVu.LayHinhAnh(txtMaDichVu.Text);
                    form2DichVu.dgvDanhSach.CurrentRow.Cells[8].Value = BllDichVu.LayGia(txtMaDichVu.Text);
                    form2DichVu.dgvDanhSach.CurrentRow.Cells[9].Value = BllDichVu.LayTrangThai(txtMaDichVu.Text) ? "Còn kinh doanh" : "Không còn kinh doanh";
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

        private void btnThemLoaiDichVu_Click(object sender, EventArgs e)
        {
            FormThemLoaiDichVuChoComboBox formThemLoaiDichVuChoComboBox = new FormThemLoaiDichVuChoComboBox(cboLoaiDichVu);
            formThemLoaiDichVuChoComboBox.ShowDialog();
        }

        private void FormThemSuaDichVu_FormClosing(object sender, FormClosingEventArgs e)
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
