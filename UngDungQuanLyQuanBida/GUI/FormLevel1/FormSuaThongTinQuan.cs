using BLL;
using DTO;
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

namespace GUI.FormLevel1
{
    public partial class FormSuaThongTinQuan : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private FormChinh formChinh;
        private Form1ThongTinQuan form1ThonTinQuan;

        public FormSuaThongTinQuan(FormChinh form1, Form1ThongTinQuan form2)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            formChinh = form1;
            form1ThonTinQuan = form2;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thông tin quán";

            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream(BllThongTinQuan.LayHinhAnh("9999999999"));
                    picHinhAnh.Image = Image.FromStream(memoryStream);
                }
                catch (Exception)
                {
                    this.picHinhAnh.Image = Properties.Resources.ZImageDefault;
                }
            }
            txtTenQuan.Text = BllThongTinQuan.LayTenQuan("9999999999");
            txtDiaChi.Text = BllThongTinQuan.LayDiaChi("9999999999");
            txtSoDienThoai.Text = BllThongTinQuan.LaySoDienThoai("9999999999");

            lblLoiTenQuan.Text = "";
            lblLoiDiaChi.Text = "";
            lblLoiSoDienThoai.Text = "";

            panLoiTenQuan.Visible = false;
            panLoiDiaChi.Visible = false;
            panLoiSoDienThoai.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiSoDienThoai.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiSoDienThoai.Text);
                panLoiSoDienThoai.Visible = true;
                txtSoDienThoai.Focus();
            }

            if (lblLoiDiaChi.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiDiaChi.Text);
                panLoiDiaChi.Visible = true;
                txtDiaChi.Focus();
            }

            if (lblLoiTenQuan.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiTenQuan.Text);
                panLoiTenQuan.Visible = true;
                txtTenQuan.Focus();
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

        private void txtTenQuan_TextChanged(object sender, EventArgs e)
        {
            if (txtTenQuan.Text.Length == 0)
            {
                lblLoiTenQuan.Text = "Họ và tên không được để trống!";
                panLoiTenQuan.Visible = true;
            }
            else
            {
                lblLoiTenQuan.Text = "";
                panLoiTenQuan.Visible = false;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Length == 0)
            {
                lblLoiDiaChi.Text = "Địa chỉ không được để trống!";
                panLoiDiaChi.Visible = true;
            }
            else
            {
                lblLoiDiaChi.Text = "";
                panLoiDiaChi.Visible = false;
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

            DtoThongTinQuan dtoThongTinQuan = new DtoThongTinQuan();
            dtoThongTinQuan.MaQuan = "9999999999";
            dtoThongTinQuan.TenQuan = txtTenQuan.Text;
            dtoThongTinQuan.DiaChi = txtDiaChi.Text;
            dtoThongTinQuan.SoDienThoai = txtSoDienThoai.Text;
            {
                MemoryStream memoryStream = new MemoryStream();
                picHinhAnh.Image.Save(memoryStream, picHinhAnh.Image.RawFormat);
                dtoThongTinQuan.HinhAnh = memoryStream.ToArray();
            }

            if (BllThongTinQuan.Sua(dtoThongTinQuan))
            {
                formChinh.TaiLai();
                form1ThonTinQuan.TaiLai();
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

        private void FrmSuaThongTinQuan_FormClosing(object sender, FormClosingEventArgs e)
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
