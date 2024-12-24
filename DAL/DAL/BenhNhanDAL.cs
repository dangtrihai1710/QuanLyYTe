using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO.Entities;

namespace DAL.DAL
{
    public class BenhNhanDAL
    {
        private string connectionString = "DBContextYT"; // Thay bằng chuỗi kết nối thực tế

        // Thêm bệnh nhân
        public bool ThemBenhNhan(BenhNhan benhNhan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO BenhNhan (MaBenhNhan, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, CMND_CCCD, NgayDangKy) " +
                               "VALUES (@MaBenhNhan, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @CMND_CCCD, @NgayDangKy)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBenhNhan", benhNhan.MaBenhNhan);
                    command.Parameters.AddWithValue("@HoTen", benhNhan.HoTen);
                    command.Parameters.AddWithValue("@NgaySinh", benhNhan.NgaySinh ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GioiTinh", benhNhan.GioiTinh ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DiaChi", benhNhan.DiaChi ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SoDienThoai", benhNhan.SoDienThoai ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CMND_CCCD", benhNhan.CMND_CCCD ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NgayDangKy", benhNhan.NgayDangKy ?? DateTime.Now);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Sửa thông tin bệnh nhân
        public bool SuaBenhNhan(BenhNhan benhNhan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE BenhNhan " +
                               "SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, " +
                               "SoDienThoai = @SoDienThoai, CMND_CCCD = @CMND_CCCD " +
                               "WHERE MaBenhNhan = @MaBenhNhan";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBenhNhan", benhNhan.MaBenhNhan);
                    command.Parameters.AddWithValue("@HoTen", benhNhan.HoTen);
                    command.Parameters.AddWithValue("@NgaySinh", benhNhan.NgaySinh ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GioiTinh", benhNhan.GioiTinh ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DiaChi", benhNhan.DiaChi ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SoDienThoai", benhNhan.SoDienThoai ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CMND_CCCD", benhNhan.CMND_CCCD ?? (object)DBNull.Value);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Xóa bệnh nhân
        public bool XoaBenhNhan(int maBenhNhan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM BenhNhan WHERE MaBenhNhan = @MaBenhNhan";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Lấy lịch sử khám bệnh
        public List<KhamBenh> LayLichSuKhamBenh(int maBenhNhan)
        {
            List<KhamBenh> danhSachLichSu = new List<KhamBenh>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaKhamBenh, MaBacSi, NgayKham, ChanDoan, Thuoc, GhiChu " +
                               "FROM KhamBenh WHERE MaBenhNhan = @MaBenhNhan";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                KhamBenh khamBenh = new KhamBenh
                                {
                                    MaKhamBenh = reader.GetInt32(0),
                                    MaBacSi = reader.IsDBNull(1) ? (int?)null : reader.GetInt32(1),
                                    NgayKham = reader.GetDateTime(2),
                                    ChanDoan = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    Thuoc = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    GhiChu = reader.IsDBNull(5) ? null : reader.GetString(5)
                                };

                                danhSachLichSu.Add(khamBenh);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return danhSachLichSu;
        }
    }
}
