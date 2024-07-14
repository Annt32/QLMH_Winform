using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DuAn1_Nhom6.Tests
{
    [TestClass]
    public class QuanLySanPhamTests
    {
        private const string ConnectionString = "Data Source=DESKTOP-PMB8531\\SQLEXPRESS;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true";
        private SqlConnection conn;

        [TestInitialize]
        public void Initialize()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
        }

        [TestCleanup]
        public void Cleanup()
        {
            conn.Close();
        }

        [TestMethod]
        public void Them_SanPham_Success()
        {
            // Arrange
            var maSanPham = "TestMaSP"; // Giả sử đây là mã sản phẩm dùng để test
            var maCTSanPham = "TestMaCTSP"; // Giả sử đây là mã chi tiết sản phẩm dùng để test
            //... khai báo và khởi tạo các biến khác như maSize, maChatLieu, ...

            // Clean up any existing data
            

            // Act
            SqlCommand cmd1 = new SqlCommand("INSERT INTO SanPham values(@MaSanPham,@IDVoucher, @MaNhaSanXuat, @TenSanPham)", conn);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO ChiTietSanPham Values(@MaCTSanPham, @MaSanPham, @MaSize, @MaChatLieu, @SoLuong, @Gia)", conn);
            cmd1.Parameters.AddWithValue("@MaSanPham", 11);
            cmd1.Parameters.AddWithValue("@IDVoucher", 1);
            cmd1.Parameters.AddWithValue("@MaNhaSanXuat", "MegaHouse");
            cmd1.Parameters.AddWithValue("@TenSanPham", "abc");
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@MaCTSanPham", 11);
            cmd2.Parameters.AddWithValue("@MaSanPham", 11);
            cmd2.Parameters.AddWithValue("@MaSize", "24cm");
            cmd2.Parameters.AddWithValue("@MaChatLieu", "go");
            cmd2.Parameters.AddWithValue("@SoLuong", 2);
            cmd2.Parameters.AddWithValue("@Gia", 500000);
            cmd2.ExecuteNonQuery();
            cmd2.Parameters.Clear();

            // Assert
            var selectCmd = new SqlCommand($"SELECT COUNT(*) FROM SanPham WHERE MaSanPham = '{11}'", conn);
            var result = (int)selectCmd.ExecuteScalar();
            if (result == 1)
            {
                Console.WriteLine("Thêm sản phẩm thành công.");
                Assert.IsTrue(true, "Thêm sản phẩm thành công.");
            }
            else
            {
                Assert.Fail("Thêm sản phẩm không thành công.");
            }

            selectCmd = new SqlCommand($"SELECT COUNT(*) FROM ChiTietSanPham WHERE MaCTSanPham = '{11}'", conn);
            result = (int)selectCmd.ExecuteScalar();
            if (result == 1)
            {
                Console.WriteLine("Thêm chi tiết sản phẩm thành công.");
                Assert.IsTrue(true, "Thêm chi tiết sản phẩm thành công.");
            }
            else
            {
                Assert.Fail("Thêm chi tiết sản phẩm không thành công.");
            }

            try
            {
                // Xóa dữ liệu test từ ChiTietSanPham
                var cleanupCmd1 = new SqlCommand($"DELETE FROM ChiTietSanPham WHERE MaCTSanPham = '{11}'", conn);
                cleanupCmd1.ExecuteNonQuery();

                // Xóa dữ liệu test từ SanPham
                var cleanupCmd2 = new SqlCommand($"DELETE FROM SanPham WHERE MaSanPham = '{11}'", conn);
                cleanupCmd2.ExecuteNonQuery();

                // Thông báo xóa dữ liệu thành công
                Console.WriteLine("Đã xóa dữ liệu test thành công.");
                Assert.IsTrue(true, "Đã xóa dữ liệu test thành công.");
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có và không thành công
                Console.WriteLine($"Lỗi khi xóa dữ liệu test: {ex.Message}");
                Assert.Fail($"Lỗi khi xóa dữ liệu test: {ex.Message}");
            }
            finally
            {
                // Đảm bảo đóng kết nối sau khi thực hiện xong
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            //// Cleanup - remove test data
            //cleanupCmd.ExecuteNonQuery();
        }
    }
}
