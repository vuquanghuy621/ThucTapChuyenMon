using BLL;
using DTO;
using GUI.FormLevel2;
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
    public partial class FormSuaHangKhachHang : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private Form2HangKhachHang form2HangKhachHang;

        public FormSuaHangKhachHang(Form2HangKhachHang frm, string maHangKhachHang)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            form2HangKhachHang = frm;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thông tin hạng khách hàng";

            txtMaHangKhachHang.Text = maHangKhachHang;
            txtTenHangKhachHang.Text = BllHangKhachHang.LayTenHangKhachHang(maHangKhachHang);
            txtDoanhSoDatToi.Text = BllHangKhachHang.LayDoanhSoDatToi(maHangKhachHang).ToString();
            txtKhuyenMai.Text = BllHangKhachHang.LayKhuyenMai(maHangKhachHang).ToString();

            lblLoiTenHangKhachHang.Text = "";
            lblLoiDoanhSoDatToi.Text = "";
            lblLoiKhuyenMai.Text = "";

            panLoiTenHangKhachHang.Visible = false;
            panLoiDoanhSoDatToi.Visible = false;
            panLoiKhuyenMai.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiKhuyenMai.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiKhuyenMai.Text);
                panLoiKhuyenMai.Visible = true;
                txtKhuyenMai.Focus();
            }

            if (lblLoiDoanhSoDatToi.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiDoanhSoDatToi.Text);
                panLoiDoanhSoDatToi.Visible = true;
                txtDoanhSoDatToi.Focus();
            }

            if (lblLoiTenHangKhachHang.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiTenHangKhachHang.Text);
                panLoiTenHangKhachHang.Visible = true;
                txtTenHangKhachHang.Focus();
            }
        }

        private void txtTenHangKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txtTenHangKhachHang.Text.Length == 0)
            {
                lblLoiTenHangKhachHang.Text = "Tên hạng khách hàng không được để trống!";
                panLoiTenHangKhachHang.Visible = true;
            }
            else
            {
                lblLoiTenHangKhachHang.Text = "";
                panLoiTenHangKhachHang.Visible = false;
            }
        }

        private void txtDoanhSoDatToi_TextChanged(object sender, EventArgs e)
        {
            if (txtDoanhSoDatToi.Text.Length == 0)
            {
                lblLoiDoanhSoDatToi.Text = "Doanh số đạt tới không được để trống!";
                panLoiDoanhSoDatToi.Visible = true;
            }
            else if (!Helper.CheckNumberString(txtDoanhSoDatToi.Text))
            {
                lblLoiDoanhSoDatToi.Text = "Doanh số đạt tới phải là một số nguyên dương!";
                panLoiDoanhSoDatToi.Visible = true;
            }
            else
            {
                lblLoiDoanhSoDatToi.Text = "";
                panLoiDoanhSoDatToi.Visible = false;
            }
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            if (txtKhuyenMai.Text.Length == 0)
            {
                lblLoiKhuyenMai.Text = "Khuyến mãi không được để trống!";
                panLoiKhuyenMai.Visible = true;
                return;
            }
            else if (!Helper.CheckNumberString(txtKhuyenMai.Text))
            {
                lblLoiKhuyenMai.Text = "Khuyến mãi phải là một số nguyên dương!";
                panLoiKhuyenMai.Visible = true;
                return;
            }

            try
            {
                if (Convert.ToInt16(txtKhuyenMai.Text) > 100)
                {
                    lblLoiKhuyenMai.Text = "Khuyến mãi chỉ nằm trong khoảng từ 0 đến 100 (1 - 100)";
                    panLoiKhuyenMai.Visible = true;
                }
                else
                {
                    lblLoiKhuyenMai.Text = "";
                    panLoiKhuyenMai.Visible = false;
                }
            }
            catch (Exception)
            {
                lblLoiKhuyenMai.Text = "Khuyến mãi chỉ nằm trong khoảng từ 0 đến 100 (1 - 100)";
                panLoiKhuyenMai.Visible = true;
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

            DtoHangKhachHang dtoHangKhachHang = new DtoHangKhachHang();
            dtoHangKhachHang.MaHangKhachHang = txtMaHangKhachHang.Text;
            dtoHangKhachHang.TenHangKhachHang = txtTenHangKhachHang.Text;
            dtoHangKhachHang.DoanhSoDatToi = Convert.ToInt64(txtDoanhSoDatToi.Text);
            dtoHangKhachHang.KhuyenMai = Convert.ToByte(txtKhuyenMai.Text);

            if (BllHangKhachHang.Sua(dtoHangKhachHang))
            {
                form2HangKhachHang.dgvDanhSach.CurrentRow.Cells[3].Value = BllHangKhachHang.LayTenHangKhachHang(txtMaHangKhachHang.Text);
                form2HangKhachHang.dgvDanhSach.CurrentRow.Cells[4].Value = BllHangKhachHang.LayDoanhSoDatToi(txtMaHangKhachHang.Text);
                form2HangKhachHang.dgvDanhSach.CurrentRow.Cells[5].Value = BllHangKhachHang.LayKhuyenMai(txtMaHangKhachHang.Text).ToString() + "%";
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo");
                trangThaiLuu = true;
                Close();
            }
            else
            {
                MessageBox.Show("Sửa thông tin không thành công!\nHãy thử lại!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            trangThaiLuu = true;
            Close();
        }

        private void FormSuaHangKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
