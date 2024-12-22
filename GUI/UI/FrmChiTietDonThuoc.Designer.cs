namespace LabYTe3
{
    partial class FrmChiTietDonThuoc
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
            this.dgvChiTietDonThuoc = new System.Windows.Forms.DataGridView();
            this.MaChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieuLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaChiTiet = new System.Windows.Forms.TextBox();
            this.txtMaDonThuoc = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtLieuLuong = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietDonThuoc
            // 
            this.dgvChiTietDonThuoc.AllowUserToAddRows = false;
            this.dgvChiTietDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTiet,
            this.MaDonThuoc,
            this.TenThuoc,
            this.LieuLuong,
            this.SoLuong,
            this.CachDung});
            this.dgvChiTietDonThuoc.Location = new System.Drawing.Point(12, 12);
            this.dgvChiTietDonThuoc.Name = "dgvChiTietDonThuoc";
            this.dgvChiTietDonThuoc.ReadOnly = true;
            this.dgvChiTietDonThuoc.RowTemplate.Height = 24;
            this.dgvChiTietDonThuoc.Size = new System.Drawing.Size(600, 200);
            this.dgvChiTietDonThuoc.TabIndex = 0;
            this.dgvChiTietDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietDonThuoc_CellClick);
            // 
            // MaChiTiet
            // 
            this.MaChiTiet.DataPropertyName = "MaChiTiet";
            this.MaChiTiet.HeaderText = "Mã Chi Tiết";
            this.MaChiTiet.Name = "MaChiTiet";
            this.MaChiTiet.ReadOnly = true;
            // 
            // MaDonThuoc
            // 
            this.MaDonThuoc.DataPropertyName = "MaDonThuoc";
            this.MaDonThuoc.HeaderText = "Mã Đơn Thuốc";
            this.MaDonThuoc.Name = "MaDonThuoc";
            this.MaDonThuoc.ReadOnly = true;
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            // 
            // LieuLuong
            // 
            this.LieuLuong.DataPropertyName = "LieuLuong";
            this.LieuLuong.HeaderText = "Liều Lượng";
            this.LieuLuong.Name = "LieuLuong";
            this.LieuLuong.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // CachDung
            // 
            this.CachDung.DataPropertyName = "CachDung";
            this.CachDung.HeaderText = "Cách Dùng";
            this.CachDung.Name = "CachDung";
            this.CachDung.ReadOnly = true;
            // 
            // txtMaChiTiet
            // 
            this.txtMaChiTiet.Location = new System.Drawing.Point(120, 230);
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.Size = new System.Drawing.Size(200, 22);
            this.txtMaChiTiet.TabIndex = 1;
            // 
            // txtMaDonThuoc
            // 
            this.txtMaDonThuoc.Location = new System.Drawing.Point(120, 270);
            this.txtMaDonThuoc.Name = "txtMaDonThuoc";
            this.txtMaDonThuoc.Size = new System.Drawing.Size(200, 22);
            this.txtMaDonThuoc.TabIndex = 2;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(120, 310);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(200, 22);
            this.txtTenThuoc.TabIndex = 3;
            // 
            // txtLieuLuong
            // 
            this.txtLieuLuong.Location = new System.Drawing.Point(120, 350);
            this.txtLieuLuong.Name = "txtLieuLuong";
            this.txtLieuLuong.Size = new System.Drawing.Size(200, 22);
            this.txtLieuLuong.TabIndex = 4;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(120, 390);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(200, 22);
            this.numSoLuong.TabIndex = 5;
            // 
            // txtCachDung
            // 
            this.txtCachDung.Location = new System.Drawing.Point(120, 430);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(200, 22);
            this.txtCachDung.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(350, 230);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(350, 270);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(350, 310);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Chi Tiết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Đơn Thuốc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Thuốc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Liều Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cách Dùng:";
            // 
            // FrmChiTietDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtCachDung);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.txtLieuLuong);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.txtMaDonThuoc);
            this.Controls.Add(this.txtMaChiTiet);
            this.Controls.Add(this.dgvChiTietDonThuoc);
            this.Name = "FrmChiTietDonThuoc";
            this.Text = "Chi Tiết Đơn Thuốc";
            this.Load += new System.EventHandler(this.FrmChiTietDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvChiTietDonThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieuLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.TextBox txtMaChiTiet;
        private System.Windows.Forms.TextBox txtMaDonThuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtLieuLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
