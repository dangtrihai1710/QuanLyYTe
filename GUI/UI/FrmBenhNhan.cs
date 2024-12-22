
using LabYTe3.QLYT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace LabYTe3
{
    public partial class FrmBenhNhan : Form
    {
        public FrmBenhNhan()
        {
            InitializeComponent();
        }
        private void FrmBenhNhan_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 m = new Model1();
                List<BenhNhan> listBN = m.BenhNhans.ToList();
                FillBN(listBN);
                txtHoTen.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillBN(List<BenhNhan> listBN)
        {
            dgvBenhNhan.Rows.Clear();
            foreach (BenhNhan bn in listBN)
            {
                int index = dgvBenhNhan.Rows.Add();
                dgvBenhNhan.Rows[index].Cells[0].Value = bn.MaBenhNhan;
                dgvBenhNhan.Rows[index].Cells[1].Value = bn.HoTen;
                dgvBenhNhan.Rows[index].Cells[2].Value = bn.NgaySinh;
                //    dgvBenhNhan.Rows[index].Cells[3].Value = bn.GioiTinh;
                dgvBenhNhan.Rows[index].Cells[3].Value = bn.DiaChi;
                dgvBenhNhan.Rows[index].Cells[4].Value = bn.SoDienThoai;
                dgvBenhNhan.Rows[index].Cells[5].Value = bn.CMND_CCCD;
                //    dgvBenhNhan.Rows[index].Cells[7].Value = bn.NgayDangKy;
            }
        }

        //        private void LoadForm()
        //        {
        //            txtCCCD.Clear();
        //            txtDiaChi.Clear();
        //            txtHoTen.Clear();
        //            txtNgaySinh.Clear();
        //            txtSoDienThoai.Clear();
        //        }

        //        private void btnTimKiem_Click(object sender, EventArgs e)
        //        {
        //            try
        //            {
        //                if (!int.TryParse(txtCCCD.Text, out int maBenhNhan))
        //                {
        //                    MessageBox.Show("Mã bệnh nhân không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return;
        //                }
        //                using (var context = new Model1())
        //                {
        //                    var benhNhan = context.BenhNhans.FirstOrDefault(bn => bn.MaBenhNhan == maBenhNhan);
        //                    dgvBenhNhan.Rows.Clear();

        //                    if (benhNhan == null)
        //                    {
        //                        MessageBox.Show("Bệnh nhân không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        ResetForm();
        //                    }
        //                    else
        //                    {
        //                        int index = dgvBenhNhan.Rows.Add();
        //                        dgvBenhNhan.Rows[index].Cells[0].Value = benhNhan.MaBenhNhan;
        //                        dgvBenhNhan.Rows[index].Cells[1].Value = benhNhan.HoTen;
        //                        dgvBenhNhan.Rows[index].Cells[2].Value = benhNhan.NgaySinh;
        //                        dgvBenhNhan.Rows[index].Cells[3].Value = benhNhan.GioiTinh;
        //                        dgvBenhNhan.Rows[index].Cells[4].Value = benhNhan.DiaChi;
        //                        dgvBenhNhan.Rows[index].Cells[5].Value = benhNhan.SoDienThoai;
        //                        dgvBenhNhan.Rows[index].Cells[6].Value = benhNhan.CMND_CCCD;
        //                        dgvBenhNhan.Rows[index].Cells[7].Value = benhNhan.NgayDangKy;
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }

        private void LoadFormDataGridView()
        {
            using (var context = new Model1())
            {
                var listBN = context.BenhNhans.ToList();
                FillBN(listBN);
            }
        }
        private void ResetForm()
        {
            txtCCCD.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            // txtCCCD.Clear();
            //txtDangKy.Clear();
            //  cmbBS.SelectedIndex = 0;
        }

  

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    if (!int.TryParse(txtCCCD.Text, out int maBenhNhan))
                    {
                        MessageBox.Show("Mã bệnh nhân không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var benhNhan = context.BenhNhans.FirstOrDefault(bn => bn.MaBenhNhan == maBenhNhan);

                    if (benhNhan == null)
                    {
                        BenhNhan newBN = new BenhNhan
                        {
                            MaBenhNhan = maBenhNhan,
                            HoTen = txtHoTen.Text,
                            NgaySinh = DateTime.Parse(txtNgaySinh.Text),
                            DiaChi = txtDiaChi.Text,
                            SoDienThoai = txtSoDienThoai.Text,
                            CMND_CCCD = txtCCCD.Text,
                            //   NgayDangKy = DateTime.Parse(txtDangKy.Text),
                            //     GioiTinh = rdbNam.Checked ? "Nam" : "Nữ"
                        };
                        context.BenhNhans.Add(newBN);
                        context.SaveChanges();
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        benhNhan.HoTen = txtHoTen.Text;
                        benhNhan.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                        benhNhan.DiaChi = txtDiaChi.Text;
                        benhNhan.SoDienThoai = txtSoDienThoai.Text;
                        benhNhan.CMND_CCCD = txtCCCD.Text;
                        // benhNhan.NgayDangKy = DateTime.Parse(txtDangKy.Text);
                        //   benhNhan.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";

                        context.Entry(benhNhan).State = EntityState.Modified;
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadFormDataGridView();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBenhNhan.Rows[e.RowIndex];
                txtCCCD.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtNgaySinh.Text = DateTime.Parse(row.Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
                //string gioiTinh = row.Cells[3].Value.ToString();
                //rdbNam.Checked = gioiTinh == "Nam";
                //rdbNu.Checked = gioiTinh == "Nữ";
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtSoDienThoai.Text = row.Cells[4].Value.ToString();
                txtCCCD.Text = row.Cells[5].Value.ToString();
                //  txtDangKy.Text = DateTime.Parse(row.Cells[7].Value.ToString()).ToString("yyyy-MM-dd");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCCCD.Text) && int.TryParse(txtCCCD.Text, out int maBenhNhan))
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (var context = new Model1())
                        {
                            var benhNhan = context.BenhNhans.SingleOrDefault(bn => bn.MaBenhNhan == maBenhNhan);

                            if (benhNhan != null)
                            {
                                context.BenhNhans.Remove(benhNhan);
                                context.SaveChanges();

                                MessageBox.Show("Xóa bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadFormDataGridView(); // Tải lại danh sách sau khi xóa
                                ResetForm(); // Đặt lại form
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy bệnh nhân để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bệnh nhân cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (!int.TryParse(txtHoTen.Text, out int maBenhNhan))
                {
                    MessageBox.Show("Mã bệnh nhân không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var context = new Model1())
                {
                    var benhNhan = context.BenhNhans.FirstOrDefault(bn => bn.MaBenhNhan == maBenhNhan);
                    dgvBenhNhan.Rows.Clear();

                    if (benhNhan == null)
                    {
                        MessageBox.Show("Bệnh nhân không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    else
                    {
                        int index = dgvBenhNhan.Rows.Add();
                        dgvBenhNhan.Rows[index].Cells[0].Value = benhNhan.MaBenhNhan;
                        dgvBenhNhan.Rows[index].Cells[1].Value = benhNhan.HoTen;
                        dgvBenhNhan.Rows[index].Cells[2].Value = benhNhan.NgaySinh;
                        //dgvBenhNhan.Rows[index].Cells[3].Value = benhNhan.GioiTinh;
                        dgvBenhNhan.Rows[index].Cells[3].Value = benhNhan.DiaChi;
                        dgvBenhNhan.Rows[index].Cells[4].Value = benhNhan.SoDienThoai;
                        dgvBenhNhan.Rows[index].Cells[5].Value = benhNhan.CMND_CCCD;
                 //       dgvBenhNhan.Rows[index].Cells[7].Value = benhNhan.NgayDangKy;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLichSuKham lichSuKham = new FrmLichSuKham();
            lichSuKham.ShowDialog();
        }
    }
    }
