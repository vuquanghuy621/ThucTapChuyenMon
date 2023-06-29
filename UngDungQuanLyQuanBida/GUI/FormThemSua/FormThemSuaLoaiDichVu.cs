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
    public partial class FormThemSuaLoaiDichVu : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiThem;
        private bool trangThaiLuu;
        private Form2LoaiDichVu form2LoaiDichVu;

        public FormThemSuaLoaiDichVu(Form2LoaiDichVu form)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = true;
            trangThaiLuu = false;
            form2LoaiDichVu = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm loại dịch vụ mới";

            txtMaLoaiDichVu.Text = BllLoaiDichVu.TaoMaLoaiDichVuMoi();
            txtTenLoaiDichVu.Text = "";

            lblLoiTenLoaiDichVu.Text = "Chưa nhập tên loại dịch vụ!";

            panLoiTenLoaiDichVu.Visible = false;
        }

        public FormThemSuaLoaiDichVu(Form2LoaiDichVu form, string maLoaiDichVu)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = false;
            trangThaiLuu = false;
            form2LoaiDichVu = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thông tin loại dịch vụ";

            txtMaLoaiDichVu.Text = maLoaiDichVu;
            txtTenLoaiDichVu.Text = BllLoaiDichVu.LayTenLoaiDichVu(maLoaiDichVu);

            lblLoiTenLoaiDichVu.Text = "";

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


            if (trangThaiThem)
            {
                if (BllLoaiDichVu.Them(dtoLoaiDichVu))
                {
                    form2LoaiDichVu.TaiLai();
                    foreach (DataGridViewRow item in form2LoaiDichVu.dgvDanhSach.Rows)
                    {
                        if (item.Cells[3].Value.ToString() == txtMaLoaiDichVu.Text)
                        {
                            form2LoaiDichVu.dgvDanhSach.CurrentCell = item.Cells[3];
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
                if (BllLoaiDichVu.Sua(dtoLoaiDichVu))
                {
                    form2LoaiDichVu.dgvDanhSach.CurrentRow.Cells[4].Value = BllLoaiDichVu.LayTenLoaiDichVu(txtMaLoaiDichVu.Text);
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

        private void FormThemSuaLoaiDichVu_FormClosing(object sender, FormClosingEventArgs e)
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
