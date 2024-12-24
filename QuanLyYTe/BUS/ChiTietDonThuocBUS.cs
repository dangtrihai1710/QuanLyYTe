using System.Collections.Generic;
using DAL.DAL;
using DTO.Entities;

namespace QuanLyYTe.BUS
{
    public class ChiTietDonThuocBUS
    {
        private ChiTietDonThuocDAL chiTietDonThuocDAL;

        public ChiTietDonThuocBUS()
        {
            chiTietDonThuocDAL = new ChiTietDonThuocDAL();
        }

        // Thêm chi tiết đơn thuốc
        public bool ThemChiTietDonThuoc(int maChiTiet, int maDonThuoc, string tenThuoc, string lieuLuong, int? soLuong, string cachDung)
        {
            ChiTietDonThuoc chiTiet = new ChiTietDonThuoc
            {
                MaChiTiet = maChiTiet,
                MaDonThuoc = maDonThuoc,
                TenThuoc = tenThuoc,
                LieuLuong = lieuLuong,
                SoLuong = soLuong,
                CachDung = cachDung
            };

            return chiTietDonThuocDAL.ThemChiTietDonThuoc(chiTiet);
        }

        // Sửa chi tiết đơn thuốc
        public bool SuaChiTietDonThuoc(int maChiTiet, int maDonThuoc, string tenThuoc, string lieuLuong, int? soLuong, string cachDung)
        {
            ChiTietDonThuoc chiTiet = new ChiTietDonThuoc
            {
                MaChiTiet = maChiTiet,
                MaDonThuoc = maDonThuoc,
                TenThuoc = tenThuoc,
                LieuLuong = lieuLuong,
                SoLuong = soLuong,
                CachDung = cachDung
            };

            return chiTietDonThuocDAL.SuaChiTietDonThuoc(chiTiet);
        }

        // Xóa chi tiết đơn thuốc
        public bool XoaChiTietDonThuoc(int maChiTiet)
        {
            return chiTietDonThuocDAL.XoaChiTietDonThuoc(maChiTiet);
        }
    }
}
