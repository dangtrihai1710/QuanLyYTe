using System;
using System.Collections.Generic;
using DAL.DAL;
using DTO.Entities;

namespace QuanLyYTe.BUS
{
    public class BenhNhanBUS
    {
        private BenhNhanDAL benhNhanDAL;

        public BenhNhanBUS()
        {
            benhNhanDAL = new BenhNhanDAL();
        }

        // Thêm bệnh nhân
        public bool ThemBenhNhan(int maBenhNhan, string hoTen, DateTime? ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string cmndCccd, DateTime? ngayDangKy)
        {
            BenhNhan benhNhan = new BenhNhan
            {
                MaBenhNhan = maBenhNhan,
                HoTen = hoTen,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                DiaChi = diaChi,
                SoDienThoai = soDienThoai,
                CMND_CCCD = cmndCccd,
                NgayDangKy = ngayDangKy ?? DateTime.Now
            };

            return benhNhanDAL.ThemBenhNhan(benhNhan);
        }

        // Sửa thông tin bệnh nhân
        public bool SuaBenhNhan(int maBenhNhan, string hoTen, DateTime? ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string cmndCccd)
        {
            BenhNhan benhNhan = new BenhNhan
            {
                MaBenhNhan = maBenhNhan,
                HoTen = hoTen,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                DiaChi = diaChi,
                SoDienThoai = soDienThoai,
                CMND_CCCD = cmndCccd
            };

            return benhNhanDAL.SuaBenhNhan(benhNhan);
        }

        // Xóa bệnh nhân
        public bool XoaBenhNhan(int maBenhNhan)
        {
            return benhNhanDAL.XoaBenhNhan(maBenhNhan);
        }

        // Lấy lịch sử khám bệnh
        public List<KhamBenh> LayLichSuKhamBenh(int maBenhNhan)
        {
            return benhNhanDAL.LayLichSuKhamBenh(maBenhNhan);
        }
    }
}
