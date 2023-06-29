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
    public partial class FormThemSuaKhuVuc : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiThem;
        private bool trangThaiLuu;
        private Form2KhuVuc form2KhuVuc;

        public FormThemSuaKhuVuc(Form2KhuVuc form)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = true;
            trangThaiLuu = false;
            form2KhuVuc = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm loại khu vực";

            txtMaKhuVuc.Text = BllKhuVuc.TaoMaKhuVucMoi();
            txtTenKhuVuc.Text = "";

            lblLoiTenKhuVuc.Text = "Chưa nhập tên loại bàn!";

            panLoiTenKhuVuc.Visible = false;
        }

        public FormThemSuaKhuVuc(Form2KhuVuc form, string maKhuVuc)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = false;
            trangThaiLuu = false;
            form2KhuVuc = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thông tin loại bàn";

            txtMaKhuVuc.Text = maKhuVuc;
            txtTenKhuVuc.Text = BllKhuVuc.LayTenKhuVuc(maKhuVuc);

            lblLoiTenKhuVuc.Text = "";

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
                lblLoiTenKhuVuc.Text = "Tên loại bàn không được để trống!";
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


            if (trangThaiThem)
            {
                if (BllKhuVuc.Them(dtoKhuVuc))
                {
                    form2KhuVuc.TaiLai();
                    foreach (DataGridViewRow item in form2KhuVuc.dgvDanhSach.Rows)
                    {
                        if (item.Cells[3].Value.ToString() == txtMaKhuVuc.Text)
                        {
                            form2KhuVuc.dgvDanhSach.CurrentCell = item.Cells[3];
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
                if (BllKhuVuc.Sua(dtoKhuVuc))
                {
                    form2KhuVuc.dgvDanhSach.CurrentRow.Cells[4].Value = BllKhuVuc.LayTenKhuVuc(txtMaKhuVuc.Text);
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

        private void FormThemSuaKhuVuc_FormClosing(object sender, FormClosingEventArgs e)
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
