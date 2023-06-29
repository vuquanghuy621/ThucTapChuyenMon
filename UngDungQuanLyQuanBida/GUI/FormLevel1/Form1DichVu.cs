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

namespace GUI.FormLevel1
{
    public partial class Form1DichVu : Form
    {
        private string tenDangNhapNhanVien;

        public string TenDangNhapNhanVien { get => tenDangNhapNhanVien; set => tenDangNhapNhanVien = value; }


        public Form1DichVu(string tenDangNhap)
        {
            tenDangNhapNhanVien = tenDangNhap;

            InitializeComponent();

            btnDichVu.BackColor = Color.FromArgb(4, 170, 109);
            OpenChildForm(new Form2DichVu(tenDangNhap));
        }

        private void OpenChildForm(Form frm)
        {
            foreach (Form item in panChinh.Controls)
            {
                item.Close();
            }

            panChinh.Controls.Clear();

            frm.TopLevel = false;
            frm.WindowState = FormWindowState.Normal;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panChinh.Controls.Add(frm);
            frm.Show();
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            foreach (Control item in panMenu.Controls)
            {
                item.BackColor = default;
            }

            btn.BackColor = Color.FromArgb(4, 170, 109);

            switch (btn.Name)
            {
                case "btnDichVu":
                    OpenChildForm(new Form2DichVu(TenDangNhapNhanVien));
                    break;
                case "btnLoaiDichVu":
                    OpenChildForm(new Form2LoaiDichVu(tenDangNhapNhanVien));
                    break;
            }
        }
    }
}
