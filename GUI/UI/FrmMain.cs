using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabYTe3
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {
            FrmDonThuoc donThuoc = new FrmDonThuoc();
            donThuoc.ShowDialog();
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            FrmBenhNhan benhNhan = new FrmBenhNhan();
            benhNhan.ShowDialog();
        }

        private void btnBacSi_Click(object sender, EventArgs e)
        {
            FrmBacSi bacSi = new FrmBacSi();
            bacSi.ShowDialog();
        }

        private void btnLichSuKham_Click(object sender, EventArgs e)
        {
            FrmLichSuKham f =new FrmLichSuKham();
            f.ShowDialog();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {

        }
    }
}
