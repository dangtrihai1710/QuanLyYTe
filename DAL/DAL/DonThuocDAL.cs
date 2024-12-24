using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO.Entities;

namespace DAL.DAL
{
    public class DonThuocDAL
    {
        private string connectionString = "DBContextYT"; // Thay bằng chuỗi kết nối thực tế

        // Thêm đơn thuốc
        public bool ThemDonThuoc(DonThuoc donThuoc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DonThuoc (MaDonThuoc, MaKhamBenh, NgayKeDon, GhiChu) " +
                               "VALUES (@MaDonThuoc, @MaKhamBenh, @NgayKeDon, @GhiChu)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaDonThuoc", donThuoc.MaDonThuoc);
                    command.Parameters.AddWithValue("@MaKhamBenh", donThuoc.MaKhamBenh ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NgayKeDon", donThuoc.NgayKeDon);
                    command.Parameters.AddWithValue("@GhiChu", donThuoc.GhiChu ?? (object)DBNull.Value);

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

        // Sửa đơn thuốc
        public bool SuaDonThuoc(DonThuoc donThuoc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE DonThuoc " +
                               "SET MaKhamBenh = @MaKhamBenh, NgayKeDon = @NgayKeDon, GhiChu = @GhiChu " +
                               "WHERE MaDonThuoc = @MaDonThuoc";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaDonThuoc", donThuoc.MaDonThuoc);
                    command.Parameters.AddWithValue("@MaKhamBenh", donThuoc.MaKhamBenh ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NgayKeDon", donThuoc.NgayKeDon);
                    command.Parameters.AddWithValue("@GhiChu", donThuoc.GhiChu ?? (object)DBNull.Value);

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

        // Xóa đơn thuốc
        public bool XoaDonThuoc(int maDonThuoc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM DonThuoc WHERE MaDonThuoc = @MaDonThuoc";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaDonThuoc", maDonThuoc);

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

        // Tìm kiếm đơn thuốc
        public List<DonThuoc> TimKiemDonThuoc(string keyword)
        {
            List<DonThuoc> danhSachDonThuoc = new List<DonThuoc>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaDonThuoc, MaKhamBenh, NgayKeDon, GhiChu " +
                               "FROM DonThuoc " +
                               "WHERE MaDonThuoc LIKE @Keyword OR GhiChu LIKE @Keyword";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DonThuoc donThuoc = new DonThuoc
                                {
                                    MaDonThuoc = reader.GetInt32(0),
                                    MaKhamBenh = reader.IsDBNull(1) ? (int?)null : reader.GetInt32(1),
                                    NgayKeDon = reader.GetDateTime(2),
                                    GhiChu = reader.IsDBNull(3) ? null : reader.GetString(3)
                                };

                                danhSachDonThuoc.Add(donThuoc);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return danhSachDonThuoc;
        }
    }
}
