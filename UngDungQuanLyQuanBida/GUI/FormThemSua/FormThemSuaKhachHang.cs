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
    public partial class FormThemSuaKhachHang : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiThem;
        private bool trangThaiLuu;
        private Form2KhachHang form2KhachHang;

        public FormThemSuaKhachHang(Form2KhachHang frm)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = true;
            trangThaiLuu = false;
            form2KhachHang = frm;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm khách hàng mới";

            txtSoDienThoai.Text = "";
            txtHoVaTen.Text = "";

            lblLoiSoDienThoai.Text = "Chưa nhập số điện thoại!";
            lblLoiHoVaTen.Text = "Chưa nhập họ và tên!";

            panLoiSoDienThoai.Visible = false;
            panLoiHoVaTen.Visible = false;
        }

        public FormThemSuaKhachHang(Form2KhachHang form, string soDienThoai)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = false;
            trangThaiLuu = false;
            form2KhachHang = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thông tin khách hàng";

            txtSoDienThoai.Text = soDienThoai;
            txtSoDienThoai.ReadOnly = true;
            txtHoVaTen.Text = BllKhachHang.LayHoVaTen(soDienThoai);

            lblLoiSoDienThoai.Text = "";
            lblLoiHoVaTen.Text = "";

            panLoiSoDienThoai.Visible = false;
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

            if (lblLoiSoDienThoai.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiSoDienThoai.Text);
                panLoiSoDienThoai.Visible = true;
                txtSoDienThoai.Focus();
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text.Length == 0)
            {
                lblLoiSoDienThoai.Text = "Số điện thoại không được để trống!";
                panLoiSoDienThoai.Visible = true;
            }
            else if (!Helper.CheckNumberString(txtSoDienThoai.Text))
            {
                lblLoiSoDienThoai.Text = "Số điện thoại chỉ được chứa các kí tự số (0 - 9)!";
                panLoiSoDienThoai.Visible = true;
            }
            else if (txtSoDienThoai.Text.Length < 10)
            {
                lblLoiSoDienThoai.Text = $"Số điện thoại chưa đủ 10 chữ số, thiếu {10 - txtSoDienThoai.Text.Length} chữ số!";
                panLoiSoDienThoai.Visible = true;
            }
            else if (BllKhachHang.KiemTraTrungSoDienThoai(txtSoDienThoai.Text))
            {
                lblLoiSoDienThoai.Text = $"Số điện thoại này đã tồn tại!";
                panLoiSoDienThoai.Visible = true;
            }
            else if (txtSoDienThoai.Text.Length > 10)
            {
                lblLoiSoDienThoai.Text = $"Số điện thoại không được dài hơn 10 chữ số, dư {txtSoDienThoai.Text.Length - 10} chữ số!";
                panLoiSoDienThoai.Visible = true;
            }
            else
            {
                lblLoiSoDienThoai.Text = "";
                panLoiSoDienThoai.Visible = false;
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

            DtoKhachHang dtoKhachHang = new DtoKhachHang();
            dtoKhachHang.SoDienThoai = txtSoDienThoai.Text;
            dtoKhachHang.HoVaTen = txtHoVaTen.Text;

            if (trangThaiThem)
            {
                dtoKhachHang.MaHangKhachHang = "0000000001";
                dtoKhachHang.ThoiGianThem = DateTime.Now;
                if (BllKhachHang.Them(dtoKhachHang))
                {
                    form2KhachHang.TaiLai();
                    foreach (DataGridViewRow item in form2KhachHang.dgvDanhSach.Rows)
                    {
                        if (item.Cells[4].Value.ToString() == txtSoDienThoai.Text)
                        {
                            form2KhachHang.dgvDanhSach.CurrentCell = item.Cells[4];
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
                if (BllKhachHang.Sua(dtoKhachHang))
                {
                    form2KhachHang.dgvDanhSach.CurrentRow.Cells[5].Value = BllKhachHang.LayHoVaTen(txtSoDienThoai.Text);
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

        private void FormThemSuaKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
