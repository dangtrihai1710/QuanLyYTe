using LabYTe3.QLYT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace LabYTe3
{
    public partial class FrmLichSuKham : Form
    {
        public FrmLichSuKham()
        {
            InitializeComponent();
        }

        private void FrmLichSuKham_Load(object sender, EventArgs e)
        {
            LoadFormDataGridView();
        }

        private void LoadFormDataGridView()
        {
            using (var context = new Model1())
            {
                var listLichSuKham = context.LichSuKhams
                    .Include(ls => ls.BenhNhan)
                    .Include(ls => ls.BacSi)
                    .ToList();

                FillLichSuKham(listLichSuKham);
            }
        }

        private void FillLichSuKham(List<LichSuKham> listLichSuKham)
        {
            dgvLichSuKham.Rows.Clear();
            foreach (var ls in listLichSuKham)
            {
                int index = dgvLichSuKham.Rows.Add();
                dgvLichSuKham.Rows[index].Cells[0].Value = ls.MaLichSu;
                dgvLichSuKham.Rows[index].Cells[1].Value = ls.BenhNhan.HoTen;
                dgvLichSuKham.Rows[index].Cells[2].Value = ls.BacSi.HoTen;
                dgvLichSuKham.Rows[index].Cells[3].Value = ls.NgayKham;
                dgvLichSuKham.Rows[index].Cells[4].Value = ls.ChuanDoan;
                dgvLichSuKham.Rows[index].Cells[5].Value = ls.GhiChu;
            }
        }

        private void ResetForm()
        {
            txtMaLichSu.Clear();
            txtMaBenhNhan.Clear();
            txtMaBacSi.Clear();
            dtpNgayKham.Value = DateTime.Now;
            txtTrieuChung.Clear();
            txtGhiChu.Clear();
        }

        private void dgvLichSuKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLichSuKham.Rows[e.RowIndex];
                txtMaLichSu.Text = row.Cells[0].Value.ToString();
                txtMaBenhNhan.Text = row.Cells[1].Value.ToString();
                txtMaBacSi.Text = row.Cells[2].Value.ToString();
                dtpNgayKham.Value = Convert.ToDateTime(row.Cells[3].Value);
                txtTrieuChung.Text = row.Cells[4].Value.ToString();
                txtGhiChu.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaLichSu.Text))
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch sử khám này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (var context = new Model1())
                        {
                            var lichSuKham = context.LichSuKhams.Find(txtMaLichSu.Text);
                            if (lichSuKham != null)
                            {
                                context.LichSuKhams.Remove(lichSuKham);
                                context.SaveChanges();
                                MessageBox.Show("Xóa lịch sử khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadFormDataGridView();
                                ResetForm();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy lịch sử khám để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lịch sử khám cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
