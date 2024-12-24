using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO.Entities;

namespace DAL.DAL
{
    public class ChiTietDonThuocDAL
    {
        private string connectionString = "DBContextYT"; // Thay bằng chuỗi kết nối thực tế

        // Thêm chi tiết đơn thuốc
        public bool ThemChiTietDonThuoc(ChiTietDonThuoc chiTiet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ChiTietDonThuoc (MaChiTiet, MaDonThuoc, TenThuoc, LieuLuong, SoLuong, CachDung) " +
                               "VALUES (@MaChiTiet, @MaDonThuoc, @TenThuoc, @LieuLuong, @SoLuong, @CachDung)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaChiTiet", chiTiet.MaChiTiet);
                    command.Parameters.AddWithValue("@MaDonThuoc", chiTiet.MaDonThuoc);
                    command.Parameters.AddWithValue("@TenThuoc", chiTiet.TenThuoc);
                    command.Parameters.AddWithValue("@LieuLuong", chiTiet.LieuLuong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CachDung", chiTiet.CachDung ?? (object)DBNull.Value);

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

        // Sửa chi tiết đơn thuốc
        public bool SuaChiTietDonThuoc(ChiTietDonThuoc chiTiet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ChiTietDonThuoc " +
                               "SET MaDonThuoc = @MaDonThuoc, TenThuoc = @TenThuoc, LieuLuong = @LieuLuong, SoLuong = @SoLuong, CachDung = @CachDung " +
                               "WHERE MaChiTiet = @MaChiTiet";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaChiTiet", chiTiet.MaChiTiet);
                    command.Parameters.AddWithValue("@MaDonThuoc", chiTiet.MaDonThuoc);
                    command.Parameters.AddWithValue("@TenThuoc", chiTiet.TenThuoc);
                    command.Parameters.AddWithValue("@LieuLuong", chiTiet.LieuLuong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CachDung", chiTiet.CachDung ?? (object)DBNull.Value);

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

        // Xóa chi tiết đơn thuốc
        public bool XoaChiTietDonThuoc(int maChiTiet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ChiTietDonThuoc WHERE MaChiTiet = @MaChiTiet";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaChiTiet", maChiTiet);

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
    }
}
