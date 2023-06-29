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

namespace GUI.FormLevel2
{
    public partial class FormThemLoaiDichVuChoComboBox : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private ComboBox comboBox;

        public FormThemLoaiDichVuChoComboBox(ComboBox cbo)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            comboBox = cbo;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm loại dịch vụ mới";

            txtMaLoaiDichVu.Text = BllLoaiDichVu.TaoMaLoaiDichVuMoi();
            txtTenLoaiDichVu.Text = "";

            lblLoiTenLoaiDichVu.Text = "Chưa nhập tên loại dịch vụ!";

            panLoiTenLoaiDichVu.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiTenLoaiDichVu.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiTenLoaiDichVu.Text);
                panLoiTenLoaiDichVu.Visible = true;
                txtTenLoaiDichVu.Focus();
            }
        }

        private void txtTenLoaiDichVu_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLoaiDichVu.Text.Length == 0)
            {
                lblLoiTenLoaiDichVu.Text = "Tên loại dịch vụ không được để trống!";
                panLoiTenLoaiDichVu.Visible = true;
            }
            else
            {
                lblLoiTenLoaiDichVu.Text = "";
                panLoiTenLoaiDichVu.Visible = false;
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

            DtoLoaiDichVu dtoLoaiDichVu = new DtoLoaiDichVu();
            dtoLoaiDichVu.MaLoaiDichVu = txtMaLoaiDichVu.Text;
            dtoLoaiDichVu.TenLoaiDichVu = txtTenLoaiDichVu.Text;

            if (BllLoaiDichVu.Them(dtoLoaiDichVu))
            {
                comboBox.DataSource = BllLoaiDichVu.GetDataSourceForComboBox();
                comboBox.ValueMember = "maLoaiDichVu";
                comboBox.DisplayMember = "tenLoaiDichVu";
                comboBox.SelectedValue = txtMaLoaiDichVu.Text;
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

        private void FormThemLoaiDichVuChoComboBox_FormClosing(object sender, FormClosingEventArgs e)
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
