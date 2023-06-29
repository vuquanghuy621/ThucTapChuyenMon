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
    public partial class FormThemSuaKhuyenMai : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiThem;
        private bool trangThaiLuu;
        private Form1KhuyenMai form1KhuyenMai;

        public FormThemSuaKhuyenMai(Form1KhuyenMai form)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = true;
            trangThaiLuu = false;
            form1KhuyenMai = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm khuyến mãi mới";

            dtpNgay.Value = DateTime.Now;
            txtMoTa.Text = "";
            txtKhuyenMai.Text = "";

            lblLoiNgay.Text = "";
            lblLoiMoTa.Text = "";
            lblLoiKhuyenMai.Text = "Chưa nhập khuyến mãi!";

            panLoiNgay.Visible = false;
            panLoiMoTa.Visible = false;
            panLoiKhuyenMai.Visible = false;
        }

        public FormThemSuaKhuyenMai(Form1KhuyenMai form, DateTime ngay)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = true;
            trangThaiLuu = false;
            form1KhuyenMai = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa khuyến mãi";

            dtpNgay.Enabled = false;
            dtpNgay.Value = ngay;
            txtMoTa.Text = BllNgayCoKhuyenMai.LayMoTa(ngay);
            txtKhuyenMai.Text = BllNgayCoKhuyenMai.LayKhuyenMai(ngay).ToString();

            lblLoiNgay.Text = "";
            lblLoiMoTa.Text = "";
            lblLoiKhuyenMai.Text = "";

            panLoiNgay.Visible = false;
            panLoiMoTa.Visible = false;
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

            if (lblLoiNgay.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiNgay.Text);
                panLoiNgay.Visible = true;
                dtpNgay.Focus();
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgay.Value <= DateTime.Now)
            {
                lblLoiNgay.Text = $"Ngày phải lớn hơn hoặc bằng ngày hôm nay ({DateTime.Now.ToString("dd/MM/yyyy")})";
                panLoiNgay.Visible = true;
            }
            else
            {
                lblLoiNgay.Text = "";
                panLoiNgay.Visible = false;
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

            DtoNgayCoKhuyenMai dtoNgayCoKhuyenMai = new DtoNgayCoKhuyenMai();
            dtoNgayCoKhuyenMai.Ngay = dtpNgay.Value;
            dtoNgayCoKhuyenMai.MoTa = txtMoTa.Text;
            dtoNgayCoKhuyenMai.KhuyenMai = Convert.ToByte(txtKhuyenMai.Text);

            if (trangThaiThem)
            {
                BllNgayCoKhuyenMai.Xoa(dtpNgay.Value);

                if (BllNgayCoKhuyenMai.Them(dtoNgayCoKhuyenMai))
                {
                    form1KhuyenMai.TaiLai();
                    foreach (DataGridViewRow item in form1KhuyenMai.dgvDanhSach.Rows)
                    {
                        if (Convert.ToDateTime(item.Cells[3].Value).Date == dtpNgay.Value.Date)
                        {
                            form1KhuyenMai.dgvDanhSach.CurrentCell = item.Cells[3];
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
                if (BllNgayCoKhuyenMai.Sua(dtoNgayCoKhuyenMai))
                {
                    form1KhuyenMai.dgvDanhSach.CurrentRow.Cells[4].Value = BllNgayCoKhuyenMai.LayMoTa(dtpNgay.Value); ;
                    form1KhuyenMai.dgvDanhSach.CurrentRow.Cells[5].Value = BllNgayCoKhuyenMai.LayKhuyenMai(dtpNgay.Value); ;
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

        private void FormThemSuaKhuyenMai_FormClosing(object sender, FormClosingEventArgs e)
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
