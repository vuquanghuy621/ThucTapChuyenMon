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
    public partial class FormThemSuaLoaiBan : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiThem;
        private bool trangThaiLuu;
        private Form2LoaiBan form2LoaiBan;

        public FormThemSuaLoaiBan(Form2LoaiBan form)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = true;
            trangThaiLuu = false;
            form2LoaiBan = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm loại bàn mới";

            txtMaLoaiBan.Text = BllLoaiBan.TaoMaLoaiBanMoi();
            txtTenLoaiBan.Text = "";

            lblLoiTenLoaiBan.Text = "Chưa nhập tên loại bàn!";

            panLoiTenLoaiBan.Visible = false;
        }

        public FormThemSuaLoaiBan(Form2LoaiBan form, string maLoaiBan)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = false;
            trangThaiLuu = false;
            form2LoaiBan = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thông tin loại bàn";

            txtMaLoaiBan.Text = maLoaiBan;
            txtTenLoaiBan.Text = BllLoaiBan.LayTenLoaiBan(maLoaiBan);

            lblLoiTenLoaiBan.Text = "";

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


            if (trangThaiThem)
            {
                if (BllLoaiBan.Them(dtoLoaiBan))
                {
                    form2LoaiBan.TaiLai();
                    foreach (DataGridViewRow item in form2LoaiBan.dgvDanhSach.Rows)
                    {
                        if (item.Cells[3].Value.ToString() == txtMaLoaiBan.Text)
                        {
                            form2LoaiBan.dgvDanhSach.CurrentCell = item.Cells[3];
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
                if (BllLoaiBan.Sua(dtoLoaiBan))
                {
                    form2LoaiBan.dgvDanhSach.CurrentRow.Cells[4].Value = BllLoaiBan.LayTenLoaiBan(txtMaLoaiBan.Text);
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

        private void FormThemSuaLoaiBan_FormClosing(object sender, FormClosingEventArgs e)
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
