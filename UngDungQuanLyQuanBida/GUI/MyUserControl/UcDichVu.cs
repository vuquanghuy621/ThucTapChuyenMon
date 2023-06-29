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

namespace GUI.MyUserControl
{
    public partial class UcDichVu : UserControl
    {
        private string maDichVu;

        public string MaDichVu { get => maDichVu; set => maDichVu = value; }

        public UcDichVu(string maDichVu)
        {
            this.maDichVu = maDichVu;
            InitializeComponent();
            lblGia.Text = BllDichVu.LayGia(maDichVu).ToString("C0");
            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream(BllDichVu.LayHinhAnh(maDichVu));
                    picHinhAnh.Image = Image.FromStream(memoryStream);
                }
                catch (Exception)
                {
                    picHinhAnh.Image = Properties.Resources.ZImageDefault;
                }
            }
            lblTenDichVu.Text = BllDichVu.LayTenDichVu(maDichVu);
            if (BllDichVu.LayTrangThai(maDichVu))
            {
                lblNgungKinhDoanh.Visible = false;
            }
            else
            {
                lblNgungKinhDoanh.Visible = true;
                lblGia.BackColor = Color.Brown;
                picHinhAnh.BackColor = Color.Brown;
                lblTenDichVu.BackColor = Color.Brown;
            }

            lblGia.Tag = maDichVu;
            picHinhAnh.Tag = maDichVu;
            lblTenDichVu.Tag = maDichVu;
        }
    }
}
