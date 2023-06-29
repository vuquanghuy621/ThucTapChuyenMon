using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyUserControl
{
    public partial class UcBan : UserControl
    {
        private string maBan;

        public string MaBan { get => maBan; set => maBan = value; }

        public UcBan(string maBan)
        {
            this.maBan = maBan;
            InitializeComponent();
            lblThongTinBan.Tag = maBan;
            lblTenBan.Tag = maBan;
            lblGia.Tag = maBan;
            TaiLai();
        }

        internal void TaiLai()
        {
            string thongTinBan = BllLoaiBan.LayTenLoaiBan(BllBan.LayMaLoaiBan(maBan));
            thongTinBan += " | ";
            thongTinBan += BllKhuVuc.LayTenKhuVuc(BllBan.LayMaKhuVuc(maBan));
            lblThongTinBan.Text = thongTinBan;

            string tenBan = BllBan.LayTenBan(maBan) + "\n";
            if (BllBan.LayTrangThai(maBan))
            {
                lblThongTinBan.BackColor = Color.FromArgb(0, 192, 0);
                lblTenBan.BackColor = Color.FromArgb(0, 192, 0);
                lblGia.BackColor = Color.FromArgb(0, 192, 0);
                tenBan = tenBan + "Đã chơi từ " + (BllHoaDonBan.LayThoiGianBatDauSuDung(maBan).ToString("HH:mm"));
            }
            else
            {
                lblThongTinBan.BackColor = Color.White;
                lblTenBan.BackColor = Color.White;
                lblGia.BackColor = Color.White;
                tenBan += "(Trống)";
            }
            lblTenBan.Text = tenBan;

            lblGia.Text = "Giá: " + BllBan.LayGia(maBan).ToString("C0") + "/giờ";
        }

        private void control_MouseEnter(object sender, EventArgs e)
        {
            lblThongTinBan.BackColor = Color.Silver;
            lblTenBan.BackColor = Color.Silver;
            lblGia.BackColor = Color.Silver;
        }

        private void control_MouseLeave(object sender, EventArgs e)
        {
            if (BllBan.LayTrangThai(maBan))
            {
                lblThongTinBan.BackColor = Color.FromArgb(0, 192, 0);
                lblTenBan.BackColor = Color.FromArgb(0, 192, 0);
                lblGia.BackColor = Color.FromArgb(0, 192, 0);
            }
            else
            {
                lblThongTinBan.BackColor = Color.White;
                lblTenBan.BackColor = Color.White;
                lblGia.BackColor = Color.White;
            }
        }
    }
}
