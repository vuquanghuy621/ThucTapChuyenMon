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
    public partial class FormThemLoaiBanChoComboBox : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiLuu;
        private ComboBox comboBox;

        public FormThemLoaiBanChoComboBox(ComboBox cbo)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiLuu = false;
            comboBox = cbo;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm loại bàn mới";

            txtMaLoaiBan.Text = BllLoaiBan.TaoMaLoaiBanMoi();
            txtTenLoaiBan.Text = "";

            lblLoiTenLoaiBan.Text = "Chưa nhập tên loại bàn!";

            panLoiTenLoaiBan.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiTenLoaiBan.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiTenLoaiBan.Text);
                panLoiTenLoaiBan.Visible = true;
                txtTenLoaiBan.Focus();
            }
        }

        private void txtTenLoaiBan_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLoaiBan.Text.Length == 0)
            {
                lblLoiTenLoaiBan.Text = "Tên loại bàn không được để trống!";
                panLoiTenLoaiBan.Visible = true;
            }
            else
            {
                lblLoiTenLoaiBan.Text = "";
                panLoiTenLoaiBan.Visible = false;
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

            DtoLoaiBan dtoLoaiBan = new DtoLoaiBan();
            dtoLoaiBan.MaLoaiBan = txtMaLoaiBan.Text;
            dtoLoaiBan.TenLoaiBan = txtTenLoaiBan.Text;

            if (BllLoaiBan.Them(dtoLoaiBan))
            {
                comboBox.DataSource = BllLoaiBan.GetDataSourceForComboBox();
                comboBox.ValueMember = "maLoaiBan";
                comboBox.DisplayMember = "tenLoaiBan";
                comboBox.SelectedValue = txtMaLoaiBan.Text;
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

        private void FormThemLoaiBanChoComboBox_FormClosing(object sender, FormClosingEventArgs e)
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
