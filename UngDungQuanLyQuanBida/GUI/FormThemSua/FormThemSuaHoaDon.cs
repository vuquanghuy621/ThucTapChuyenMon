using BLL;
using DTO;
using GUI.MyUserControl;
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
    public partial class FormThemSuaHoaDon : Form
    {
        private string maHoaDon;
        private DateTime thoiGianThem;
        private DataTable dataTable;

        public FormThemSuaHoaDon(string maHoaDon)
        {
            this.maHoaDon = maHoaDon;

            InitializeComponent();
            this.Text = "Hóa đơn";
            {
                cboKhachHang.DataSource = BllKhachHang.GetDataSourceForComboBox();
                cboKhachHang.ValueMember = "soDienThoai";
                cboKhachHang.DisplayMember = "khachHang";
            }
            {
                cboLoaiDichVu.DataSource = BllLoaiDichVu.GetDataSourceForComboBox();
                cboLoaiDichVu.ValueMember = "maLoaiDichVu";
                cboLoaiDichVu.DisplayMember = "tenLoaiDichVu";
            }

            dataTable = BllDichVu.LayDanhSachDichVu();

            panDichVu.Controls.Clear();
            foreach (DataRow row in dataTable.Rows) 
            { 
                UcDichVu ucDichVu = new UcDichVu(row[1].ToString());
                ucDichVu.lblGia.Click += dichVu_Click;
                ucDichVu.picHinhAnh.Click += dichVu_Click;
                ucDichVu.lblTenDichVu.Click += dichVu_Click;
                panDichVu.Controls.Add(ucDichVu);
            }

            TaiLai();
        }

        private void dichVu_Click(object sender, EventArgs e)
        {
            //Control control = sender as Control;

            //string maBan = control.Tag.ToString();

            //if (BllBan.LayTrangThai(maBan))
            //{
            //    FormThemSuaHoaDon formThemSuaHoaDon = new FormThemSuaHoaDon(BllHoaDonBan.LayMaHoaDonDangSuDung(maBan));
            //    formThemSuaHoaDon.ShowDialog();
            //}
            //else
            //{
            //    //Tạo hóa đơn
            //    string maHoaDon = BllHoaDon.TaoMaHoaDonMoi();
            //    DateTime thoiGianThem = DateTime.Now;
            //    DtoHoaDon dtoHoaDon = new DtoHoaDon();
            //    dtoHoaDon.MaHoaDon = maHoaDon;
            //    dtoHoaDon.ThoiGiamThem = thoiGianThem;
            //    dtoHoaDon.TenDangNhapNhanVien = tenDangNhapNhanVien;
            //    dtoHoaDon.SoDienThoaiKhachHang = "0000000000";
            //    dtoHoaDon.KhuyenMaiHangKhachHang = 0;
            //    dtoHoaDon.KhuyenMaiNgay = 0;
            //    dtoHoaDon.TrangThai = false;
            //    BllHoaDon.Them(dtoHoaDon);

            //    //Thêm bàn hiện tại vào hóa đơn
            //    DtoHoaDonBan dtoHoaDonBan = new DtoHoaDonBan();
            //    dtoHoaDonBan.ThoiGianThem = thoiGianThem;
            //    dtoHoaDonBan.MaHoaDon = maHoaDon;
            //    dtoHoaDonBan.MaBan = control.Tag.ToString();
            //    dtoHoaDonBan.ThoiGianBatDau = thoiGianThem;
            //    dtoHoaDonBan.ThoiGianKetThuc = thoiGianThem;
            //    BllHoaDonBan.Them(dtoHoaDonBan);

            //    BllBan.SuaTrangThai(true, control.Tag.ToString());

            //    FormThemSuaHoaDon formThemSuaHoaDon = new FormThemSuaHoaDon(maHoaDon);
            //    formThemSuaHoaDon.ShowDialog();
            //}
        }

        internal void TaiLai()
        {
            dgvDanhSachHoaDonBan.DataSource = BllHoaDon.LayDanhSachHoaDonBan(maHoaDon);

            txtMaHoaDon.Text = maHoaDon;
            txtThoiGianThem.Text = BllHoaDon.LayThoiGiamThem(maHoaDon).ToString("dd/MM/yyyy HH:mm");
            txtNhanVien.Text = $"{BllNhanVien.LayHoVaTen(BllHoaDon.LayTenDangNhapNhanVien(maHoaDon))}";
            cboKhachHang.SelectedValue = BllHoaDon.LaySoDienThoaiKhachHang(maHoaDon) == "" ? "0000000000" : BllHoaDon.LaySoDienThoaiKhachHang(maHoaDon);
            txtKhuyenMaiHangKhachHang.Text = BllHoaDon.LayKhuyenMaiHangKhachHang(maHoaDon).ToString() + "%";
            txtKhuyenMaiNgay.Text = BllHoaDon.LayKhuyenMaiNgay(maHoaDon).ToString() + "%";
            txtTienBan.Text = BllHoaDon.LayTienBan(maHoaDon).ToString("C0");
            txtTienDichVu.Text = BllHoaDon.LayTienDichVu(maHoaDon).ToString("C0");
            txtTienHoaDon.Text = BllHoaDon.LayTienHoaDon(maHoaDon).ToString("C0");
            txtTienKhuyenMaiHangKhachHang.Text = BllHoaDon.LayTienKhuyenMaiHangKhachHang(maHoaDon).ToString("C0");
            txtTienKhuyenMaiNgay.Text = BllHoaDon.LayTienKhuyenMaiNgay(maHoaDon).ToString("C0");
            txtTienPhaiThanhToan.Text = BllHoaDon.LayTienPhaiThanhToan(maHoaDon).ToString("C0");
        }

        private void dgvDanhSachHoaDonBan_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            thoiGianThem = Convert.ToDateTime(dgvDanhSachHoaDonBan.Rows[e.RowIndex].Cells[5].Value);

            if (e.ColumnIndex == 1)
            {
                if (thoiGianThem != BllHoaDonBan.LayThoiGianThemMoiNhat(BllHoaDonBan.LayMaHoaDon(thoiGianThem)))
                {
                    e.PaintBackground(e.ClipBounds, true);
                    e.Handled = true;
                }
            }

            if (e.ColumnIndex == 4)
            {
                if (thoiGianThem == BllHoaDonBan.LayThoiGianThemMoiNhat(BllHoaDonBan.LayMaHoaDon(thoiGianThem)))
                {
                    e.PaintBackground(e.ClipBounds, true);
                    e.Handled = true;
                }
            }
        }

        private void dgvDanhSachHoaDonBan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvDanhSachHoaDonBan.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            thoiGianThem = Convert.ToDateTime(dgvDanhSachHoaDonBan.Rows[e.RowIndex].Cells[5].Value);
            if (thoiGianThem == BllHoaDonBan.LayThoiGianThemMoiNhat(BllHoaDonBan.LayMaHoaDon(thoiGianThem)))
            {
                dgvDanhSachHoaDonBan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen; ;
            }
        }

        private void dgvDanhSachHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            thoiGianThem = Convert.ToDateTime(dgvDanhSachHoaDonBan.Rows[e.RowIndex].Cells[5].Value);

            if (e.ColumnIndex == 1)
            {
                if (thoiGianThem != BllHoaDonBan.LayThoiGianThemMoiNhat(BllHoaDonBan.LayMaHoaDon(thoiGianThem)))
                {
                    return;
                }

                FormChuyenBan formChuyenBan = new FormChuyenBan(this, thoiGianThem);
                formChuyenBan.ShowDialog();
            }

            if (e.ColumnIndex == 2)
            {
                FormSuaBan formSuaBan = new FormSuaBan(this, thoiGianThem);
                formSuaBan.ShowDialog();
            }

            if (e.ColumnIndex == 3)
            {
                FormSuaThoiGian formSuaThoiGian = new FormSuaThoiGian(this, thoiGianThem);
                formSuaThoiGian.ShowDialog();
            }

            if (e.ColumnIndex == 4)
            {
                if (thoiGianThem == BllHoaDonBan.LayThoiGianThemMoiNhat(BllHoaDonBan.LayMaHoaDon(thoiGianThem)))
                {
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắc muốn xóa bàn này khỏi hóa đơn?",
                    "",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (BllHoaDonBan.Xoa(thoiGianThem))
                    {
                        TaiLai();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!\nHãy thử lại!", "Thông báo");
                    }
                }
            }
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedIndex == -1)
            {
                return;
            }

            BllHoaDon.SuaKhachHang(cboKhachHang.SelectedValue.ToString(), maHoaDon);
            txtMaHoaDon.Text = maHoaDon;
            txtThoiGianThem.Text = BllHoaDon.LayThoiGiamThem(maHoaDon).ToString("dd/MM/yyyy HH:mm");
            txtNhanVien.Text = $"{BllNhanVien.LayHoVaTen(BllHoaDon.LayTenDangNhapNhanVien(maHoaDon))}";
            txtKhuyenMaiHangKhachHang.Text = BllHoaDon.LayKhuyenMaiHangKhachHang(maHoaDon).ToString() + "%";
            txtKhuyenMaiNgay.Text = BllHoaDon.LayKhuyenMaiNgay(maHoaDon).ToString() + "%";
            txtTienBan.Text = BllHoaDon.LayTienBan(maHoaDon).ToString("C0");
            txtTienDichVu.Text = BllHoaDon.LayTienDichVu(maHoaDon).ToString("C0");
            txtTienHoaDon.Text = BllHoaDon.LayTienHoaDon(maHoaDon).ToString("C0");
            txtTienKhuyenMaiHangKhachHang.Text = BllHoaDon.LayTienKhuyenMaiHangKhachHang(maHoaDon).ToString("C0");
            txtTienKhuyenMaiNgay.Text = BllHoaDon.LayTienKhuyenMaiNgay(maHoaDon).ToString("C0");
            txtTienPhaiThanhToan.Text = BllHoaDon.LayTienPhaiThanhToan(maHoaDon).ToString("C0");
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            FormThemKhachHangChoComboBox formThemKhachHangChoComboBox = new FormThemKhachHangChoComboBox(cboKhachHang);
            formThemKhachHangChoComboBox.ShowDialog();
        }
    }
}
