namespace LabYTe3
{
    partial class FrmLichSuKham
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
            this.dgvLichSuKham = new System.Windows.Forms.DataGridView();
            this.MaLichSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaLichSu = new System.Windows.Forms.TextBox();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuKham
            // 
            this.dgvLichSuKham.AllowUserToAddRows = false;
            this.dgvLichSuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichSu,
            this.MaBenhNhan,
            this.MaBacSi,
            this.NgayKham,
            this.TrieuChung,
            this.GhiChu});
            this.dgvLichSuKham.Location = new System.Drawing.Point(12, 12);
            this.dgvLichSuKham.Name = "dgvLichSuKham";
            this.dgvLichSuKham.ReadOnly = true;
            this.dgvLichSuKham.RowHeadersWidth = 51;
            this.dgvLichSuKham.RowTemplate.Height = 24;
            this.dgvLichSuKham.Size = new System.Drawing.Size(783, 200);
            this.dgvLichSuKham.TabIndex = 0;
            this.dgvLichSuKham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSuKham_CellClick);
            // 
            // MaLichSu
            // 
            this.MaLichSu.DataPropertyName = "MaLichSu";
            this.MaLichSu.HeaderText = "Mã Lịch Sử";
            this.MaLichSu.MinimumWidth = 6;
            this.MaLichSu.Name = "MaLichSu";
            this.MaLichSu.ReadOnly = true;
            this.MaLichSu.Width = 125;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.DataPropertyName = "MaBenhNhan";
            this.MaBenhNhan.HeaderText = "Mã Bệnh Nhân";
            this.MaBenhNhan.MinimumWidth = 6;
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.ReadOnly = true;
            this.MaBenhNhan.Width = 125;
            // 
            // MaBacSi
            // 
            this.MaBacSi.DataPropertyName = "MaBacSi";
            this.MaBacSi.HeaderText = "Mã Bác Sĩ";
            this.MaBacSi.MinimumWidth = 6;
            this.MaBacSi.Name = "MaBacSi";
            this.MaBacSi.ReadOnly = true;
            this.MaBacSi.Width = 125;
            // 
            // NgayKham
            // 
            this.NgayKham.DataPropertyName = "NgayKham";
            this.NgayKham.HeaderText = "Ngày Khám";
            this.NgayKham.MinimumWidth = 6;
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.ReadOnly = true;
            this.NgayKham.Width = 125;
            // 
            // TrieuChung
            // 
            this.TrieuChung.DataPropertyName = "TrieuChung";
            this.TrieuChung.HeaderText = "Triệu Chứng";
            this.TrieuChung.MinimumWidth = 6;
            this.TrieuChung.Name = "TrieuChung";
            this.TrieuChung.ReadOnly = true;
            this.TrieuChung.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Width = 125;
            // 
            // txtMaLichSu
            // 
            this.txtMaLichSu.Location = new System.Drawing.Point(12, 240);
            this.txtMaLichSu.Name = "txtMaLichSu";
            this.txtMaLichSu.Size = new System.Drawing.Size(100, 22);
            this.txtMaLichSu.TabIndex = 1;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Location = new System.Drawing.Point(118, 240);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(100, 22);
            this.txtMaBenhNhan.TabIndex = 2;
            // 
            // txtMaBacSi
            // 
            this.txtMaBacSi.Location = new System.Drawing.Point(224, 240);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(100, 22);
            this.txtMaBacSi.TabIndex = 3;
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.Location = new System.Drawing.Point(330, 240);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayKham.TabIndex = 4;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(536, 240);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(200, 22);
            this.txtTrieuChung.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(536, 301);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 22);
            this.txtGhiChu.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 300);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(93, 300);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(174, 300);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Lịch Sử:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Bệnh Nhân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã Bác Sĩ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày Khám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Triệu Chứng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ghi Chú:";
            // 
            // FrmLichSuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.dtpNgayKham);
            this.Controls.Add(this.txtMaBacSi);
            this.Controls.Add(this.txtMaBenhNhan);
            this.Controls.Add(this.txtMaLichSu);
            this.Controls.Add(this.dgvLichSuKham);
            this.Name = "FrmLichSuKham";
            this.Text = "Lịch Sử Khám";
            this.Load += new System.EventHandler(this.FrmLichSuKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvLichSuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TextBox txtMaLichSu;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.TextBox txtGhiChu;
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
