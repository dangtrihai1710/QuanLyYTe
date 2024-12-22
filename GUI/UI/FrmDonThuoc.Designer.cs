namespace LabYTe3
{
    partial class FrmDonThuoc
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
            this.lblMaDonThuoc = new System.Windows.Forms.Label();
            this.txtMaDonThuoc = new System.Windows.Forms.TextBox();
            this.lblMaKhamBenh = new System.Windows.Forms.Label();
            this.txtMaKhamBenh = new System.Windows.Forms.TextBox();
            this.lblNgayKeDon = new System.Windows.Forms.Label();
            this.dtpNgayKeDon = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.colMaDonThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhamBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKeDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaDonThuoc
            // 
            this.lblMaDonThuoc.AutoSize = true;
            this.lblMaDonThuoc.Location = new System.Drawing.Point(30, 20);
            this.lblMaDonThuoc.Name = "lblMaDonThuoc";
            this.lblMaDonThuoc.Size = new System.Drawing.Size(97, 16);
            this.lblMaDonThuoc.TabIndex = 0;
            this.lblMaDonThuoc.Text = "Mã Đơn Thuốc:";
            // 
            // txtMaDonThuoc
            // 
            this.txtMaDonThuoc.Location = new System.Drawing.Point(120, 17);
            this.txtMaDonThuoc.Name = "txtMaDonThuoc";
            this.txtMaDonThuoc.Size = new System.Drawing.Size(150, 22);
            this.txtMaDonThuoc.TabIndex = 1;
            // 
            // lblMaKhamBenh
            // 
            this.lblMaKhamBenh.AutoSize = true;
            this.lblMaKhamBenh.Location = new System.Drawing.Point(30, 60);
            this.lblMaKhamBenh.Name = "lblMaKhamBenh";
            this.lblMaKhamBenh.Size = new System.Drawing.Size(100, 16);
            this.lblMaKhamBenh.TabIndex = 2;
            this.lblMaKhamBenh.Text = "Mã Khám Bệnh:";
            // 
            // txtMaKhamBenh
            // 
            this.txtMaKhamBenh.Location = new System.Drawing.Point(120, 57);
            this.txtMaKhamBenh.Name = "txtMaKhamBenh";
            this.txtMaKhamBenh.Size = new System.Drawing.Size(150, 22);
            this.txtMaKhamBenh.TabIndex = 3;
            // 
            // lblNgayKeDon
            // 
            this.lblNgayKeDon.AutoSize = true;
            this.lblNgayKeDon.Location = new System.Drawing.Point(30, 100);
            this.lblNgayKeDon.Name = "lblNgayKeDon";
            this.lblNgayKeDon.Size = new System.Drawing.Size(89, 16);
            this.lblNgayKeDon.TabIndex = 4;
            this.lblNgayKeDon.Text = "Ngày Kê Đơn:";
            // 
            // dtpNgayKeDon
            // 
            this.dtpNgayKeDon.Location = new System.Drawing.Point(120, 97);
            this.dtpNgayKeDon.Name = "dtpNgayKeDon";
            this.dtpNgayKeDon.Size = new System.Drawing.Size(150, 22);
            this.dtpNgayKeDon.TabIndex = 5;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(30, 140);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(56, 16);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Ghi Chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(120, 137);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(150, 50);
            this.txtGhiChu.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(300, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm/Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(300, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(300, 100);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.AllowUserToAddRows = false;
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDonThuoc,
            this.colMaKhamBenh,
            this.colNgayKeDon,
            this.colGhiChu});
            this.dgvDonThuoc.Location = new System.Drawing.Point(30, 210);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.RowHeadersWidth = 51;
            this.dgvDonThuoc.Size = new System.Drawing.Size(450, 200);
            this.dgvDonThuoc.TabIndex = 11;
            this.dgvDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonThuoc_CellClick);
            // 
            // colMaDonThuoc
            // 
            this.colMaDonThuoc.HeaderText = "Mã Đơn Thuốc";
            this.colMaDonThuoc.MinimumWidth = 6;
            this.colMaDonThuoc.Name = "colMaDonThuoc";
            this.colMaDonThuoc.Width = 80;
            // 
            // colMaKhamBenh
            // 
            this.colMaKhamBenh.HeaderText = "Mã Khám Bệnh";
            this.colMaKhamBenh.MinimumWidth = 6;
            this.colMaKhamBenh.Name = "colMaKhamBenh";
            this.colMaKhamBenh.Width = 125;
            // 
            // colNgayKeDon
            // 
            this.colNgayKeDon.HeaderText = "Ngày Kê Đơn";
            this.colNgayKeDon.MinimumWidth = 6;
            this.colNgayKeDon.Name = "colNgayKeDon";
            this.colNgayKeDon.Width = 125;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Width = 150;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(300, 155);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnChiTiet.TabIndex = 12;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // FrmDonThuoc
            // 
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.dgvDonThuoc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.dtpNgayKeDon);
            this.Controls.Add(this.lblNgayKeDon);
            this.Controls.Add(this.txtMaKhamBenh);
            this.Controls.Add(this.lblMaKhamBenh);
            this.Controls.Add(this.txtMaDonThuoc);
            this.Controls.Add(this.lblMaDonThuoc);
            this.Name = "FrmDonThuoc";
            this.Text = "Quản Lý Đơn Thuốc";
            this.Load += new System.EventHandler(this.FrmDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblMaDonThuoc;
        private System.Windows.Forms.TextBox txtMaDonThuoc;
        private System.Windows.Forms.Label lblMaKhamBenh;
        private System.Windows.Forms.TextBox txtMaKhamBenh;
        private System.Windows.Forms.Label lblNgayKeDon;
        private System.Windows.Forms.DateTimePicker dtpNgayKeDon;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhamBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKeDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.Button btnChiTiet;
    }
}
