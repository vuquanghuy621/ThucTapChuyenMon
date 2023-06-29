using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormLevel1
{
    public partial class Form1ThongTinQuan : Form
    {
        private FormChinh formChinh;

        public Form1ThongTinQuan(FormChinh formChinh, string tenDangNhap)
        {
            this.formChinh = formChinh;

            InitializeComponent();
            if (BllNhanVien.LayMaLoaiNhanVien(tenDangNhap) == "0000000002")
            {
                btnSua.Visible = false;
            }

            TaiLai();
        }

        internal void TaiLai()
        {
            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream(BllThongTinQuan.LayHinhAnh("9999999999"));
                    picHinhAnh.Image = Image.FromStream(memoryStream);
                }
                catch (Exception)
                {
                    picHinhAnh.Image = Properties.Resources.ZImageDefault;
                }
            }
            lblThongTinQuan.Text = $"Tên quán: {BllThongTinQuan.LayTenQuan("9999999999")}\n\n";
            lblThongTinQuan.Text += $"Địa chỉ: {BllThongTinQuan.LayDiaChi("9999999999")}\n\n";
            lblThongTinQuan.Text += $"Số điện thoại: {BllThongTinQuan.LaySoDienThoai("9999999999")}";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaThongTinQuan formSuaThongTinQuan = new FormSuaThongTinQuan(formChinh, this);
            formSuaThongTinQuan.ShowDialog();
        }
    }
}
