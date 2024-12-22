using LabYTe3.QLYT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabYTe3
{
    public partial class FrmBacSi : Form
    {
        public FrmBacSi()
        {
            InitializeComponent();
        }

        private void FrmBacSi_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 m = new Model1();
                List<BacSi> listBS = m.BacSis.ToList();
                FillBS(listBS);
                txtHoTen.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillBS(List<BacSi> listBS)
        {
            dgvBacSi.Rows.Clear();
            foreach (BacSi bs in listBS)
            {
                int index = dgvBacSi.Rows.Add();
                dgvBacSi.Rows[index].Cells[0].Value = bs.MaBacSi;
                dgvBacSi.Rows[index].Cells[1].Value = bs.HoTen;
                dgvBacSi.Rows[index].Cells[2].Value = bs.MaKhoa;             
                dgvBacSi.Rows[index].Cells[3].Value = bs.SoDienThoai;
                dgvBacSi.Rows[index].Cells[4].Value = bs.Email;
             
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    if (!int.TryParse(txtMaKhoa.Text, out int makhoa))
                    {
                        MessageBox.Show("Mã bác sĩ không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var bacsi = context.BacSis.FirstOrDefault(bs => bs.MaKhoa == makhoa);

                    if (bacsi == null)
                    {
                        BacSi newBS = new BacSi
                        {
                            MaKhoa = makhoa,
                            HoTen = txtHoTen.Text,
                            SoDienThoai = txtSoDienThoai.Text,
                            Email = txtEmail.Text,
                            //   NgayDangKy = DateTime.Parse(txtDangKy.Text),
                            //     GioiTinh = rdbNam.Checked ? "Nam" : "Nữ"
                        };
                        context.BacSis.Add(newBS);
                        context.SaveChanges();
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bacsi.HoTen = txtHoTen.Text;                      
                        bacsi.SoDienThoai = txtSoDienThoai.Text;
                        bacsi.Email = txtEmail.Text;
                        // benhNhan.NgayDangKy = DateTime.Parse(txtDangKy.Text);
                        //   benhNhan.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";

                        context.Entry(bacsi).State = EntityState.Modified;
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadFormDataGridView();
              //      ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFormDataGridView()
        {
            using (var context = new Model1())
            {
                var listBS = context.BacSis.ToList();
                FillBS(listBS);
          
            }
        }

        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBacSi.Rows[e.RowIndex];
          //      txtHoTen.Text = row.Cells[1].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtMaKhoa.Text = row.Cells[2].Value.ToString();
                txtSoDienThoai.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                //  txtDangKy.Text = DateTime.Parse(row.Cells[7].Value.ToString()).ToString("yyyy-MM-dd");
            }
        }
    }
}
