namespace LabYTe3
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnDonThuoc = new System.Windows.Forms.Button();
            this.btnBenhNhan = new System.Windows.Forms.Button();
            this.btnBacSi = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnLichSuKham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDonThuoc
            // 
            this.btnDonThuoc.Location = new System.Drawing.Point(228, 87);
            this.btnDonThuoc.Name = "btnDonThuoc";
            this.btnDonThuoc.Size = new System.Drawing.Size(180, 40);
            this.btnDonThuoc.TabIndex = 1;
            this.btnDonThuoc.Text = "Khám Bệnh";
            this.btnDonThuoc.UseVisualStyleBackColor = true;
            this.btnDonThuoc.Click += new System.EventHandler(this.btnDonThuoc_Click);
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.Location = new System.Drawing.Point(228, 41);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.Size = new System.Drawing.Size(180, 40);
            this.btnBenhNhan.TabIndex = 2;
            this.btnBenhNhan.Text = "Quản Lý Bệnh Nhân";
            this.btnBenhNhan.UseVisualStyleBackColor = true;
            this.btnBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // btnBacSi
            // 
            this.btnBacSi.Location = new System.Drawing.Point(12, 87);
            this.btnBacSi.Name = "btnBacSi";
            this.btnBacSi.Size = new System.Drawing.Size(180, 40);
            this.btnBacSi.TabIndex = 3;
            this.btnBacSi.Text = "Quản Lý Bác Sĩ";
            this.btnBacSi.UseVisualStyleBackColor = true;
            this.btnBacSi.Click += new System.EventHandler(this.btnBacSi_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(64, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hệ Thống Quản Lý Y Tế";
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(12, 41);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(180, 40);
            this.btnKhoa.TabIndex = 4;
            this.btnKhoa.Text = "Quản Lý Khoa";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnLichSuKham
            // 
            this.btnLichSuKham.Location = new System.Drawing.Point(120, 133);
            this.btnLichSuKham.Name = "btnLichSuKham";
            this.btnLichSuKham.Size = new System.Drawing.Size(180, 40);
            this.btnLichSuKham.TabIndex = 5;
            this.btnLichSuKham.Text = "Lịch Sử Khám";
            this.btnLichSuKham.UseVisualStyleBackColor = true;
            this.btnLichSuKham.Click += new System.EventHandler(this.btnLichSuKham_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(420, 184);
            this.Controls.Add(this.btnLichSuKham);
            this.Controls.Add(this.btnKhoa);
            this.Controls.Add(this.btnBacSi);
            this.Controls.Add(this.btnBenhNhan);
            this.Controls.Add(this.btnDonThuoc);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmMain";
            this.Text = "Trang Chính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnDonThuoc;
        private System.Windows.Forms.Button btnBenhNhan;
        private System.Windows.Forms.Button btnBacSi;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnLichSuKham;
    }
}
