namespace GUI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpThoiGianBatDauMoi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtpThoiGianBatDauMoi
            // 
            this.dtpThoiGianBatDauMoi.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtpThoiGianBatDauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianBatDauMoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianBatDauMoi.Location = new System.Drawing.Point(12, 12);
            this.dtpThoiGianBatDauMoi.Name = "dtpThoiGianBatDauMoi";
            this.dtpThoiGianBatDauMoi.Size = new System.Drawing.Size(400, 45);
            this.dtpThoiGianBatDauMoi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.dtpThoiGianBatDauMoi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpThoiGianBatDauMoi;
    }
}

