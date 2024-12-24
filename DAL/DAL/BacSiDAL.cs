using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO.Entities; // Import lớp DTO của bạn

namespace DAL.DAL
{
    public class BacSiDAL
    {
        private string connectionString = "DBContextYT"; // Thay chuỗi kết nối thực tế của bạn

        // Thêm bác sĩ
        public bool ThemBacSi(BacSi bacSi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO BacSi (MaBacSi, HoTen, MaKhoa, SoDienThoai, Email) " +
                               "VALUES (@MaBacSi, @HoTen, @MaKhoa, @SoDienThoai, @Email)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBacSi", bacSi.MaBacSi);
                    command.Parameters.AddWithValue("@HoTen", bacSi.HoTen);
                    command.Parameters.AddWithValue("@MaKhoa", bacSi.MaKhoa.HasValue ? (object)bacSi.MaKhoa.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@SoDienThoai", bacSi.SoDienThoai ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", bacSi.Email ?? (object)DBNull.Value);

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

        // Sửa bác sĩ
        public bool SuaBacSi(BacSi bacSi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE BacSi " +
                               "SET HoTen = @HoTen, MaKhoa = @MaKhoa, SoDienThoai = @SoDienThoai, Email = @Email " +
                               "WHERE MaBacSi = @MaBacSi";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBacSi", bacSi.MaBacSi);
                    command.Parameters.AddWithValue("@HoTen", bacSi.HoTen);
                    command.Parameters.AddWithValue("@MaKhoa", bacSi.MaKhoa.HasValue ? (object)bacSi.MaKhoa.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@SoDienThoai", bacSi.SoDienThoai ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", bacSi.Email ?? (object)DBNull.Value);

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

        // Xóa bác sĩ
        public bool XoaBacSi(int maBacSi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM BacSi WHERE MaBacSi = @MaBacSi";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBacSi", maBacSi);

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

        // Tìm kiếm bác sĩ
        public List<BacSi> TimKiemBacSi(string keyword)
        {
            List<BacSi> danhSachBacSi = new List<BacSi>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaBacSi, HoTen, MaKhoa, SoDienThoai, Email " +
                               "FROM BacSi " +
                               "WHERE HoTen LIKE @Keyword OR SoDienThoai LIKE @Keyword OR Email LIKE @Keyword";

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
                                BacSi bacSi = new BacSi
                                {
                                    MaBacSi = reader.GetInt32(0),
                                    HoTen = reader.GetString(1),
                                    MaKhoa = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                                    SoDienThoai = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    Email = reader.IsDBNull(4) ? null : reader.GetString(4)
                                };

                                danhSachBacSi.Add(bacSi);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return danhSachBacSi;
        }
    }
}
