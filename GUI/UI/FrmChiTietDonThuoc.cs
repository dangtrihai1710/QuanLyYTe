using LabYTe3.QLYT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace LabYTe3
{
    public partial class FrmChiTietDonThuoc : Form
    {
        public FrmChiTietDonThuoc()
        {
            InitializeComponent();
        }

        private void FrmChiTietDonThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new Model1())
            {
                
                var listCTDT = context.ChiTietDonThuocs.Include(ct => ct.DonThuoc).ToList();
                FillGridView(listCTDT);
            }
        }

        private void FillGridView(List<ChiTietDonThuoc> listCTDT)
        {
            dgvChiTietDonThuoc.Rows.Clear();
            foreach (ChiTietDonThuoc ct in listCTDT)
            {
                int index = dgvChiTietDonThuoc.Rows.Add();
                dgvChiTietDonThuoc.Rows[index].Cells[0].Value = ct.MaChiTiet;  // Mã chi tiết
                dgvChiTietDonThuoc.Rows[index].Cells[1].Value = ct.MaDonThuoc; // Mã đơn thuốc
                dgvChiTietDonThuoc.Rows[index].Cells[2].Value = ct.TenThuoc;   // Tên thuốc
                dgvChiTietDonThuoc.Rows[index].Cells[3].Value = ct.LieuLuong;   // Liều lượng
                dgvChiTietDonThuoc.Rows[index].Cells[4].Value = ct.SoLuong;     // Số lượng
                dgvChiTietDonThuoc.Rows[index].Cells[5].Value = ct.CachDung;    // Cách dùng
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var newCTDT = new ChiTietDonThuoc
                    {
                        MaDonThuoc = int.Parse(txtMaDonThuoc.Text),
                        TenThuoc = txtTenThuoc.Text,
                        LieuLuong = txtLieuLuong.Text,
                        SoLuong = (int)numSoLuong.Value,
                        CachDung = txtCachDung.Text
                    };

                    context.ChiTietDonThuocs.Add(newCTDT);
                    context.SaveChanges();
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();  // Tải lại dữ liệu sau khi thêm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    int maChiTiet = int.Parse(txtMaChiTiet.Text);
                    var ct = context.ChiTietDonThuocs.Find(maChiTiet);

                    if (ct != null)
                    {
                        ct.MaDonThuoc = int.Parse(txtMaDonThuoc.Text);
                        ct.TenThuoc = txtTenThuoc.Text;
                        ct.LieuLuong = txtLieuLuong.Text;
                        ct.SoLuong = (int)numSoLuong.Value;
                        ct.CachDung = txtCachDung.Text;

                        context.Entry(ct).State = EntityState.Modified;
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();  // Tải lại dữ liệu sau khi sửa
                    }
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
                using (var context = new Model1())
                {
                    int maChiTiet = int.Parse(txtMaChiTiet.Text);
                    var ct = context.ChiTietDonThuocs.Find(maChiTiet);

                    if (ct != null)
                    {
                        context.ChiTietDonThuocs.Remove(ct);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();  // Tải lại dữ liệu sau khi xóa
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChiTietDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietDonThuoc.Rows[e.RowIndex];
                txtMaChiTiet.Text = row.Cells[0].Value.ToString();
                txtMaDonThuoc.Text = row.Cells[1].Value.ToString();
                txtTenThuoc.Text = row.Cells[2].Value.ToString();
                txtLieuLuong.Text = row.Cells[3].Value.ToString();
                numSoLuong.Value = (int)row.Cells[4].Value;
                txtCachDung.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
