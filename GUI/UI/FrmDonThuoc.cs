using LabYTe3.QLYT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace LabYTe3
{
    public partial class FrmDonThuoc : Form
    {
        public FrmDonThuoc()
        {
            InitializeComponent();
        }

        private void FrmDonThuoc_Load(object sender, EventArgs e)
        {
            LoadFormDataGridView();
            ClearForm();
        }

        private void LoadFormDataGridView()
        {
            using (var context = new Model1())
            {
                var listDT = context.DonThuocs.Include(dt => dt.BenhNhan).ToList();
                FillDonThuoc(listDT);
            }
        }

        private void FillDonThuoc(List<DonThuoc> listDT)
        {
            dgvDonThuoc.Rows.Clear();
            foreach (DonThuoc dt in listDT)
            {
                int index = dgvDonThuoc.Rows.Add();
                dgvDonThuoc.Rows[index].Cells[0].Value = dt.MaDonThuoc;
                dgvDonThuoc.Rows[index].Cells[1].Value = dt.MaKhamBenh;
                dgvDonThuoc.Rows[index].Cells[2].Value = dt.NgayKeDon.ToString("yyyy-MM-dd");
                dgvDonThuoc.Rows[index].Cells[3].Value = dt.GhiChu;
            }
        }

        private void ClearForm()
        {
            txtMaDonThuoc.Clear();
            txtMaKhamBenh.Clear();
            dtpNgayKeDon.Value = DateTime.Now;
            txtGhiChu.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    if (!int.TryParse(txtMaDonThuoc.Text, out int maDonThuoc))
                    {
                        MessageBox.Show("Mã đơn thuốc không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var donThuoc = context.DonThuocs.FirstOrDefault(dt => dt.MaDonThuoc == maDonThuoc);

                    if (donThuoc == null)
                    {
                        DonThuoc newDT = new DonThuoc
                        {
                            MaDonThuoc = maDonThuoc,
                            MaKhamBenh = int.TryParse(txtMaKhamBenh.Text, out int maKhamBenh) ? maKhamBenh : (int?)null,
                            NgayKeDon = dtpNgayKeDon.Value,
                            GhiChu = txtGhiChu.Text
                        };
                        context.DonThuocs.Add(newDT);
                        context.SaveChanges();
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        donThuoc.MaKhamBenh = int.TryParse(txtMaKhamBenh.Text, out int maKhamBenh) ? maKhamBenh : (int?)null;
                        donThuoc.NgayKeDon = dtpNgayKeDon.Value;
                        donThuoc.GhiChu = txtGhiChu.Text;

                        context.Entry(donThuoc).State = EntityState.Modified;
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadFormDataGridView();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaDonThuoc.Text) && int.TryParse(txtMaDonThuoc.Text, out int maDonThuoc))
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn thuốc này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (var context = new Model1())
                        {
                            var donThuoc = context.DonThuocs.SingleOrDefault(dt => dt.MaDonThuoc == maDonThuoc);

                            if (donThuoc != null)
                            {
                                context.DonThuocs.Remove(donThuoc);
                                context.SaveChanges();

                                MessageBox.Show("Xóa đơn thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadFormDataGridView();
                                ClearForm();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy đơn thuốc để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn thuốc cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaDonThuoc.Text, out int maDonThuoc))
                {
                    MessageBox.Show("Mã đơn thuốc không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var context = new Model1())
                {
                    var donThuoc = context.DonThuocs.FirstOrDefault(dt => dt.MaDonThuoc == maDonThuoc);
                    dgvDonThuoc.Rows.Clear();

                    if (donThuoc == null)
                    {
                        MessageBox.Show("Đơn thuốc không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        int index = dgvDonThuoc.Rows.Add();
                        dgvDonThuoc.Rows[index].Cells[0].Value = donThuoc.MaDonThuoc;
                        dgvDonThuoc.Rows[index].Cells[1].Value = donThuoc.MaKhamBenh;
                        dgvDonThuoc.Rows[index].Cells[2].Value = donThuoc.NgayKeDon.ToString("yyyy-MM-dd");
                        dgvDonThuoc.Rows[index].Cells[3].Value = donThuoc.GhiChu;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDonThuoc.Rows[e.RowIndex];
                txtMaDonThuoc.Text = row.Cells[0].Value.ToString();
                txtMaKhamBenh.Text = row.Cells[1].Value?.ToString();
                dtpNgayKeDon.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                txtGhiChu.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietDonThuoc ct = new FrmChiTietDonThuoc();
            ct.ShowDialog();
        }
    }
}
