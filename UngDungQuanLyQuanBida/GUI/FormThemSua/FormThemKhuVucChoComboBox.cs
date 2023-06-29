using BLL;
using DTO;
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
    public partial class FormThemKhuVucChoComboBox : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private ComboBox comboBox;

        public FormThemKhuVucChoComboBox(ComboBox cbo)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            comboBox = cbo;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm khu vực mới";

            txtMaKhuVuc.Text = BllKhuVuc.TaoMaKhuVucMoi();
            txtTenKhuVuc.Text = "";

            lblLoiTenKhuVuc.Text = "Chưa nhập tên khu vực!";

            panLoiTenKhuVuc.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiTenKhuVuc.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiTenKhuVuc.Text);
                panLoiTenKhuVuc.Visible = true;
                txtTenKhuVuc.Focus();
            }
        }

        private void txtTenKhuVuc_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKhuVuc.Text.Length == 0)
            {
                lblLoiTenKhuVuc.Text = "Tên khu vực không được để trống!";
                panLoiTenKhuVuc.Visible = true;
            }
            else
            {
                lblLoiTenKhuVuc.Text = "";
                panLoiTenKhuVuc.Visible = false;
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

            DtoKhuVuc dtoKhuVuc = new DtoKhuVuc();
            dtoKhuVuc.MaKhuVuc = txtMaKhuVuc.Text;
            dtoKhuVuc.TenKhuVuc = txtTenKhuVuc.Text;

            if (BllKhuVuc.Them(dtoKhuVuc))
            {
                comboBox.DataSource = BllKhuVuc.GetDataSourceForComboBox();
                comboBox.ValueMember = "maKhuVuc";
                comboBox.DisplayMember = "tenKhuVuc";
                comboBox.SelectedValue = txtMaKhuVuc.Text;
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

        private void FormThemKhuVucChoComboBox_FormClosing(object sender, FormClosingEventArgs e)
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
