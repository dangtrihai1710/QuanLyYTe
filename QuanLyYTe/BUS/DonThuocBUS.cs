using System;
using System.Collections.Generic;
using DAL.DAL;
using DTO.Entities;

namespace QuanLyYTe.BUS
{
    public class DonThuocBUS
    {
        private DonThuocDAL donThuocDAL;

        public DonThuocBUS()
        {
            donThuocDAL = new DonThuocDAL();
        }

        // Thêm đơn thuốc
        public bool ThemDonThuoc(int maDonThuoc, int? maKhamBenh, DateTime ngayKeDon, string ghiChu)
        {
            DonThuoc donThuoc = new DonThuoc
            {
                MaDonThuoc = maDonThuoc,
                MaKhamBenh = maKhamBenh,
                NgayKeDon = ngayKeDon,
                GhiChu = ghiChu
            };

            return donThuocDAL.ThemDonThuoc(donThuoc);
        }

        // Sửa đơn thuốc
        public bool SuaDonThuoc(int maDonThuoc, int? maKhamBenh, DateTime ngayKeDon, string ghiChu)
        {
            DonThuoc donThuoc = new DonThuoc
            {
                MaDonThuoc = maDonThuoc,
                MaKhamBenh = maKhamBenh,
                NgayKeDon = ngayKeDon,
                GhiChu = ghiChu
            };

            return donThuocDAL.SuaDonThuoc(donThuoc);
        }

        // Xóa đơn thuốc
        public bool XoaDonThuoc(int maDonThuoc)
        {
            return donThuocDAL.XoaDonThuoc(maDonThuoc);
        }

        // Tìm kiếm đơn thuốc
        public List<DonThuoc> TimKiemDonThuoc(string keyword)
        {
            return donThuocDAL.TimKiemDonThuoc(keyword);
        }
    }
}
