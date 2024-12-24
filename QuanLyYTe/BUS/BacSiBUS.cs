using DAL.DAL;
using System.Collections.Generic;

namespace QuanLyYTe.BUS
{
    public class BacSiBUS
    {
        private BacSiDAL bacSiDAL;

        public BacSiBUS()
        {
            bacSiDAL = new BacSiDAL();
        }

        // Thêm bác sĩ
        public bool ThemBacSi(int maBacSi, string hoTen, int? maKhoa, string soDienThoai, string email)
        {
            return bacSiDAL.ThemBacSi(new DTO.Entities.BacSi
            {
                MaBacSi = maBacSi,
                HoTen = hoTen,
                MaKhoa = maKhoa,
                SoDienThoai = soDienThoai,
                Email = email
            });
        }

        // Sửa bác sĩ
        public bool SuaBacSi(int maBacSi, string hoTen, int? maKhoa, string soDienThoai, string email)
        {
            return bacSiDAL.SuaBacSi(new DTO.Entities.BacSi
            {
                MaBacSi = maBacSi,
                HoTen = hoTen,
                MaKhoa = maKhoa,
                SoDienThoai = soDienThoai,
                Email = email
            });
        }

        // Xóa bác sĩ
        public bool XoaBacSi(int maBacSi)
        {
            return bacSiDAL.XoaBacSi(maBacSi);
        }

        // Tìm kiếm bác sĩ
        public List<DTO.Entities.BacSi> TimKiemBacSi(string keyword)
        {
            return bacSiDAL.TimKiemBacSi(keyword);
        }
    }
}
