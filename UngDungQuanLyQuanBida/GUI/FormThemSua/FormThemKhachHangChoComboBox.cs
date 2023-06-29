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
    public partial class FormThemKhachHangChoComboBox : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private ComboBox comboBox;

        public FormThemKhachHangChoComboBox(ComboBox cbo)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            comboBox = cbo;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm khách hàng mới";

            txtSoDienThoai.Text = "";
            txtHoVaTen.Text = "";

            lblLoiSoDienThoai.Text = "Chưa nhập số điện thoại!";
            lblLoiHoVaTen.Text = "Chưa nhập họ và tên!";

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
            dtoKhachHang.MaHangKhachHang = "0000000001";
            dtoKhachHang.ThoiGianThem = DateTime.Now;

            if (BllKhachHang.Them(dtoKhachHang))
            {
                comboBox.DataSource = BllKhachHang.GetDataSourceForComboBox();
                comboBox.ValueMember = "soDienThoai";
                comboBox.DisplayMember = "khachHang";
                comboBox.SelectedValue = txtSoDienThoai.Text;
                MessageBox.Show("Thêm thành công!", "Thông báo");
                trangThaiLuu = true;
                Close();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!\nHãy thử lại!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            trangThaiLuu = true;
            Close();
        }

        private void FormThemKhachHangChoComboBox_FormClosing(object sender, FormClosingEventArgs e)
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
