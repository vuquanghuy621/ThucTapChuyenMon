namespace GUI.MyUserControl
{
    partial class UcDichVu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.lblNgungKinhDoanh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGia
            // 
            this.lblGia.BackColor = System.Drawing.Color.White;
            this.lblGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGia.Location = new System.Drawing.Point(0, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(148, 20);
            this.lblGia.TabIndex = 0;
            this.lblGia.Text = "Giá";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.BackColor = System.Drawing.Color.White;
            this.lblTenDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTenDichVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTenDichVu.Location = new System.Drawing.Point(0, 138);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(148, 40);
            this.lblTenDichVu.TabIndex = 1;
            this.lblTenDichVu.Text = "Tên dịch vụ";
            this.lblTenDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BackColor = System.Drawing.Color.White;
            this.picHinhAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHinhAnh.Location = new System.Drawing.Point(0, 20);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(148, 118);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 2;
            this.picHinhAnh.TabStop = false;
            // 
            // lblNgungKinhDoanh
            // 
            this.lblNgungKinhDoanh.BackColor = System.Drawing.Color.White;
            this.lblNgungKinhDoanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNgungKinhDoanh.ForeColor = System.Drawing.Color.Red;
            this.lblNgungKinhDoanh.Location = new System.Drawing.Point(0, 69);
            this.lblNgungKinhDoanh.Name = "lblNgungKinhDoanh";
            this.lblNgungKinhDoanh.Size = new System.Drawing.Size(148, 40);
            this.lblNgungKinhDoanh.TabIndex = 3;
            this.lblNgungKinhDoanh.Text = "Ngừng kinh doanh";
            this.lblNgungKinhDoanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblNgungKinhDoanh);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.lblTenDichVu);
            this.Controls.Add(this.lblGia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcDichVu";
            this.Size = new System.Drawing.Size(148, 178);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblGia;
        internal System.Windows.Forms.Label lblTenDichVu;
        internal System.Windows.Forms.PictureBox picHinhAnh;
        internal System.Windows.Forms.Label lblNgungKinhDoanh;
    }
}
