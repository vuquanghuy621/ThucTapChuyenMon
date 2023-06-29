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
    public partial class FormThemSuaBan : Form
    {
        private List<string> danhSachLoiNhapLieu;
        private string loiNhapLieu;
        private bool trangThaiThem;
        private bool trangThaiLuu;
        private Form2Ban form2Ban;

        public FormThemSuaBan(Form2Ban form)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = true;
            trangThaiLuu = false;
            form2Ban = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Thêm bàn mới";
            {
                cboLoaiBan.DataSource = BllLoaiBan.GetDataSourceForComboBox();
                cboLoaiBan.ValueMember = "maLoaiBan";
                cboLoaiBan.DisplayMember = "tenLoaiBan";
            }
            {
                cboKhuVuc.DataSource = BllKhuVuc.GetDataSourceForComboBox();
                cboKhuVuc.ValueMember = "maKhuVuc";
                cboKhuVuc.DisplayMember = "tenKhuVuc";
            }

            txtMaBan.Text = BllBan.TaoMaBanMoi();
            txtTenBan.Text = "";
            cboLoaiBan.SelectedIndex = -1;
            cboKhuVuc.SelectedIndex = -1;
            txtGia.Text = "";

            lblLoiTenBan.Text = "Chưa nhập tên bàn!";
            lblLoiLoaiBan.Text = "Chưa chọn loại bàn!";
            lblLoiKhuVuc.Text = "Chưa chọn khu vực!";
            lblLoiGia.Text = "Chưa nhập giá!";

            panLoiTenBan.Visible = false;
            panLoiLoaiBan.Visible = false;
            panLoiKhuVuc.Visible = false;
            panLoiGia.Visible = false;
        }

        public FormThemSuaBan(Form2Ban form, string maBan)
        {
            danhSachLoiNhapLieu = new List<string>();
            loiNhapLieu = "";
            trangThaiThem = false;
            trangThaiLuu = false;
            form2Ban = form;

            InitializeComponent();
            this.Text = lblTieuDe.Text = "Sửa thông tin bàn";
            {
                cboLoaiBan.DataSource = BllLoaiBan.GetDataSourceForComboBox();
                cboLoaiBan.ValueMember = "maLoaiBan";
                cboLoaiBan.DisplayMember = "tenLoaiBan";
            }
            {
                cboKhuVuc.DataSource = BllKhuVuc.GetDataSourceForComboBox();
                cboKhuVuc.ValueMember = "maKhuVuc";
                cboKhuVuc.DisplayMember = "tenKhuVuc";
            }

            txtMaBan.Text = maBan;
            txtTenBan.Text = BllBan.LayTenBan(maBan);
            cboLoaiBan.SelectedValue = BllBan.LayMaLoaiBan(maBan);
            cboKhuVuc.SelectedValue = BllBan.LayMaLoaiBan(maBan);
            txtGia.Text = BllBan.LayGia(maBan).ToString();

            lblLoiTenBan.Text = "";
            lblLoiLoaiBan.Text = "";
            lblLoiKhuVuc.Text = "";
            lblLoiGia.Text = "";

            panLoiTenBan.Visible = false;
            panLoiLoaiBan.Visible = false;
            panLoiKhuVuc.Visible = false;
            panLoiGia.Visible = false;
        }

        private void KiemSoatLoiNhapLieu()
        {
            danhSachLoiNhapLieu.Clear();
            loiNhapLieu = "";

            if (lblLoiGia.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiGia.Text);
                panLoiGia.Visible = true;
                txtGia.Focus();
            }


            if (lblLoiKhuVuc.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiKhuVuc.Text);
                panLoiKhuVuc.Visible = true;
                cboKhuVuc.Focus();
            }

            if (lblLoiLoaiBan.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiLoaiBan.Text);
                panLoiLoaiBan.Visible = true;
                cboLoaiBan.Focus();
            }

            if (lblLoiTenBan.Text.Length > 0)
            {
                danhSachLoiNhapLieu.Add(lblLoiTenBan.Text);
                panLoiTenBan.Visible = true;
                txtTenBan.Focus();
            }
        }

        private void txtTenBan_TextChanged(object sender, EventArgs e)
        {
            if (txtTenBan.Text.Length == 0)
            {
                lblLoiTenBan.Text = "Tên bàn không được để trống!";
                panLoiTenBan.Visible = true;
            }
            else
            {
                lblLoiTenBan.Text = "";
                panLoiTenBan.Visible = false;
            }
        }

        private void cboLoaiBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiBan.SelectedIndex == -1)
            {
                lblLoiLoaiBan.Text = "Loại bàn không được để trống!";
                panLoiLoaiBan.Visible = true;
            }
            else
            {
                lblLoiLoaiBan.Text = "";
                panLoiLoaiBan.Visible = false;
            }
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhuVuc.SelectedIndex == -1)
            {
                lblLoiKhuVuc.Text = "Khu vực không được để trống!";
                panLoiKhuVuc.Visible = true;
            }
            else
            {
                lblLoiKhuVuc.Text = "";
                panLoiKhuVuc.Visible = false;
            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (txtGia.Text.Length == 0)
            {
                lblLoiGia.Text = "Giá không được để trống!";
                panLoiGia.Visible = true;
            }
            else if (!Helper.CheckNumberString(txtGia.Text))
            {
                lblLoiGia.Text = "Giá phải là một số nguyên dương!";
                panLoiGia.Visible = true;
            }
            else
            {
                lblLoiGia.Text = "";
                panLoiGia.Visible = false;
            }
        }

        private void btnThemLoaiBan_Click(object sender, EventArgs e)
        {
            FormThemLoaiBanChoComboBox formThemLoaiBanChoComboBox = new FormThemLoaiBanChoComboBox(cboLoaiBan);
            formThemLoaiBanChoComboBox.ShowDialog();
        }

        private void btnThemKhuVuc_Click(object sender, EventArgs e)
        {
            FormThemKhuVucChoComboBox formThemKhuVucChoComboBox = new FormThemKhuVucChoComboBox(cboKhuVuc);
            formThemKhuVucChoComboBox.ShowDialog();
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

            DtoBan dtoBan = new DtoBan();
            dtoBan.MaBan = txtMaBan.Text;
            dtoBan.TenBan = txtTenBan.Text;
            dtoBan.MaLoaiBan = cboLoaiBan.SelectedValue.ToString();
            dtoBan.MaKhuVuc = cboKhuVuc.SelectedValue.ToString();
            dtoBan.Gia = Convert.ToInt64(txtGia.Text);

            if (trangThaiThem)
            {
                if (BllBan.Them(dtoBan))
                {
                    form2Ban.TaiLai();
                    foreach (DataGridViewRow item in form2Ban.dgvDanhSach.Rows)
                    {
                        if (item.Cells[3].Value.ToString() == txtMaBan.Text)
                        {
                            form2Ban.dgvDanhSach.CurrentCell = item.Cells[3];
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
                if (BllBan.Sua(dtoBan))
                {
                    form2Ban.dgvDanhSach.CurrentRow.Cells[4].Value = BllBan.LayTenBan(txtMaBan.Text);
                    form2Ban.dgvDanhSach.CurrentRow.Cells[5].Value = BllLoaiBan.LayTenLoaiBan(BllBan.LayMaLoaiBan(txtMaBan.Text));
                    form2Ban.dgvDanhSach.CurrentRow.Cells[6].Value = BllKhuVuc.LayTenKhuVuc(BllBan.LayMaKhuVuc(txtMaBan.Text));
                    form2Ban.dgvDanhSach.CurrentRow.Cells[7].Value = BllBan.LayGia(txtMaBan.Text);
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

        private void FormThemSuaBan_FormClosing(object sender, FormClosingEventArgs e)
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
