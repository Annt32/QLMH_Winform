using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DuAn1_Nhom6
{
    public partial class HoaDonCho : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PMB8531\\SQLEXPRESS;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public HoaDonCho()
        {
            InitializeComponent();

            LoadTotalAmount();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void txtHDCT_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtHD_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSP_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtSZ_TextChanged(object sender, EventArgs e)
        {
        }

        private void DTPVC_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        private const string ConnectionString = "Data Source=DESKTOP-PMB8531\\SQLEXPRESS;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true"; // Thay thế bằng chuỗi kết nối của bạn

        private void LoadTotalAmount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();


                    string query1 = "SELECT SUM(TongTien) FROM HoaDonChiTietIN";
                    string query2 = "SELECT SUM(SoLuong)  FROM HoaDonChiTietIN";
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        object result1 = command.ExecuteScalar();
                        if (result1 != DBNull.Value)
                        {

                            txtTT.Text = result1.ToString();

                        }


                    }
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        object result2 = command.ExecuteScalar();

                        if (result2 != DBNull.Value)
                        {
                            txtSL.Text = result2.ToString();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void HoaDonCho_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThi();
            HienThi2();
            HienThi3();
            HienThi4();
            LayDL();
            LayDL2();
            LayDL3();
        }
        void HienThi()
        {
            //SqlCommand cmd = new SqlCommand("select a.MaHoaDonCT, b.IDHoaDon, c.MaSanPham, d.IDVoucher, c.TenSanPham, d.MenhGia, d.HanSuDung, f.SoLuong\r\nfrom HoaDonChiTiet a\r\njoin HoaDon b on a.IDHoaDon = b.IDHoaDon\r\njoin SanPham c on a.MaSanPham = c.MaSanPham\r\njoin Voucher d on a.IDVoucher = d.IDVoucher\r\njoin ChiTietSanPham f on c.MaSanPham = f.MaSanPham", conn);
            SqlCommand cmd = new SqlCommand("select c.MaSanPham, d.IDVoucher, c.TenSanPham, d.MenhGia, d.HanSuDung, f.SoLuong, f.Gia from SanPham c join Voucher d on c.IDVoucher = d.IDVoucher join ChiTietSanPham f on c.MaSanPham = f.MaSanPham", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHDC.DataSource = dt;

        }
        void HienThi2()
        {
            SqlCommand cmd = new SqlCommand("select MaHoaDonCTIN,MaSanPham,TenSanPham,MenhGiaVoucher,HSDVoucher,SoLuong,TongTien,TrangThai from HoaDonChiTietIN", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHDC.DataSource = dt;

        }
        void HienThi3()
        {
            //SqlCommand cmd = new SqlCommand("select a.MaHoaDonCT, b.IDHoaDon, c.MaSanPham, d.IDVoucher, c.TenSanPham, d.MenhGia, d.HanSuDung, f.SoLuong\r\nfrom HoaDonChiTiet a\r\njoin HoaDon b on a.IDHoaDon = b.IDHoaDon\r\njoin SanPham c on a.MaSanPham = c.MaSanPham\r\njoin Voucher d on a.IDVoucher = d.IDVoucher\r\njoin ChiTietSanPham f on c.MaSanPham = f.MaSanPham", conn);
            SqlCommand cmd = new SqlCommand("select c.MaSanPham, d.IDVoucher, c.TenSanPham, d.MenhGia, d.HanSuDung, f.SoLuong, f.Gia from SanPham c join Voucher d on c.IDVoucher = d.IDVoucher join ChiTietSanPham f on c.MaSanPham = f.MaSanPham", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHDTT.DataSource = dt;

        }
        void HienThi4()
        {
            SqlCommand cmd = new SqlCommand("select * from HoaDonChiTietTT", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHDTT.DataSource = dt;
            this.dgvHDTT.Columns[0].Visible = false;
            this.dgvHDTT.Columns[6].Visible = false;

        }
        void LayDL()
        {
            string sql = "select a.MaHoaDonCT, b.IDHoaDon, c.MaSanPham, d.IDVoucher, c.TenSanPham, d.MenhGia, d.HanSuDung, f.SoLuong\r\nfrom HoaDonChiTiet a\r\njoin HoaDon b on a.IDHoaDon = b.IDHoaDon\r\njoin SanPham c on a.MaSanPham = c.MaSanPham\r\njoin Voucher d on a.IDVoucher = d.IDVoucher\r\njoin ChiTietSanPham f on c.MaSanPham = f.MaSanPham";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }
        void LayDL2()
        {
            string sql = "select * from HoaDonChiTietIN";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }

        void LayDL3()
        {
            string sql = "select * from HoaDonChiTietTT";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Them()
        {
            string query = "SELECT TOP 1 STTHoaDonTT FROM HoaDonChiTietTT ORDER BY STTHoaDonTT DESC;";
            SqlCommand cmd8 = new SqlCommand(query, conn);

            try
            {

                object result = cmd8.ExecuteScalar();

                if (result != null)
                {
                    txtSTT.Text = result.ToString();
                }
                else
                {
                    txtSTT.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            int currentSTT = int.Parse(txtSTT.Text);


            txtSTTM.Text = (currentSTT + 1).ToString();
            try
            {
                int i = 1;
                i++;
                SqlCommand cmd = new SqlCommand("INSERT INTO HoaDonChiTietTT (STTHoaDonTT, MaSanPham, IDNhanVien, IDKhachHang, TenSanPham, MenhGiaVoucher, HSDVoucher, SoLuong, TongTien, TrangThai) " +
                                   "SELECT @STTHoaDonTT, MaSanPham, @IDNhanVien,@IDKhachHang ,TenSanPham, MenhGiaVoucher, HSDVoucher, SoLuong, TongTien, @TrangThai FROM HoaDonChiTietIN", conn);

                cmd.Parameters.AddWithValue("@STTHoaDonTT", txtSTTM.Text);
                cmd.Parameters.AddWithValue("@IDNhanVien", txtMNV.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txtSL.Text);
                cmd.Parameters.AddWithValue("@TongTien", txtTT.Text);
                cmd.Parameters.AddWithValue("@IDKhachHang", txtKH.Text);
                cmd.Parameters.AddWithValue("@TrangThai", "Đã Thanh toán");




                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }

        }
        void ThemThua()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO HoaDonChiTietTT values (@TenSanPham, @MenhGiaVoucher, @HSDVoucher, @SoLuong, @TongTien, @TrangThai)", conn);

                //cmd.Parameters.AddWithValue("@MaHoaDonCTIN", 1);
                //cmd.Parameters.AddWithValue("@TenSanPham", txtSP.Text);
                //cmd.Parameters.AddWithValue("@MenhGiaVoucher", txtSZ.Text);
                //cmd.Parameters.AddWithValue("@HSDVoucher", DTPVC.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txtSL.Text);
                cmd.Parameters.AddWithValue("@TongTien", txtTT.Text);
                cmd.Parameters.AddWithValue("@TrangThai", "Đã Thanh toán");

                // Tính tổng và gán giá trị vào tham số TongTien



                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }

        }

        void Them2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDonChiTietTT", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvHDTT.DataSource = dt;
        }
        private void dgvHDTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Them();
            Them2();
            Xoa();
            Xoa2();
            Xoa3();
            LayDL2();
            LayDL3();
            HienThi();
            HienThi2();
            HienThi3();
            HienThi4();
            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Xoa()
        {
            SqlCommand cmd = new SqlCommand("DELETE HoaDonChiTietIN", conn);
            //cmd.Parameters.AddWithValue("@MaHoaDonCTIN", txtHDCT.Text);
            cmd.ExecuteNonQuery();
        }


        void Xoa2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDonChiTietIN", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvHDC.DataSource = dt;
        }
        void Xoa4()
        {
            SqlCommand cmd = new SqlCommand("DELETE HoaDonChiTietTT", conn);
            // cmd.Parameters.AddWithValue("@MaHoaDonTT", txtHDCT.Text);
            cmd.ExecuteNonQuery();
        }


        void Xoa5()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDonChiTietTT", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvHDTT.DataSource = dt;
        }
        void Xoa3()
        {
            //txtHDCT.Text = string.Empty;
            //txtHD.Text = string.Empty;
            //txtSP.Text = string.Empty;
            //txtSZ.Text = string.Empty;
            //DTPVC.Text = string.Empty;
            //txtSL.Text = string.Empty;
            //txtTT.Text = string.Empty;

        }
        void Xoa6()
        {
            //i = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportDgvToText();

        }
        private void ExportDgvToText()
        {
            if (dgvHDTT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo");
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        foreach (DataGridViewRow row in dgvHDTT.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgvHDTT.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString() + "\t");
                                }
                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Dữ liệu đã được xuất thành công.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Xoa();
            //LayDL();
            //HienThi();
            //HienThi2();
            //HienThi3();
            //HienThi4();
            //Xoa2();
            //Xoa3();
            //MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Xoa4();
            LayDL2();
            Xoa5();
            Xoa6();
            MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO HoaDonChiTietTT (MaSanPham, IDNhanVien, TenSanPham, MenhGiaVoucher, HSDVoucher, SoLuong, TongTien, TrangThai) " +
                                   "SELECT MaSanPham, NULL AS IDNhanVien, TenSanPham, MenhGiaVoucher, HSDVoucher, SoLuong, TongTien, TrangThai FROM HoaDonChiTietIN";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được chuyển thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu nào được chuyển.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string maSanPhamTimKiem = txtTKNV.Text.Trim();

            if (string.IsNullOrEmpty(maSanPhamTimKiem))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm cần tìm.", "Lỗi");
                return;
            }

            using (SqlCommand cmd = new SqlCommand("SELECT STTHoaDonTT as N'Hóa Đơn Đã Thanh Toán' from HoaDonChiTietTT where @IDNhanVien = IDNhanVien GROUP BY STTHoaDonTT", conn))
            {
                cmd.Parameters.AddWithValue("@IDNhanVien", maSanPhamTimKiem);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dgvNV.DataSource = dataTable;
                }
            }
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttQR_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string SDT = txtTKH.Text.Trim();

            if (string.IsNullOrEmpty(SDT))
            {
                MessageBox.Show("Vui lòng nhập SDT của Khách hàng cần tìm.", "Lỗi");
                return;
            }

            using (SqlCommand cmd = new SqlCommand("SELECT * from KhachHang where @SDT = SDT", conn))
            {
                cmd.Parameters.AddWithValue("@SDT", SDT);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dgvKH.DataSource = dataTable;
                }
            }
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvKH.CurrentRow.Selected = true;

                txtKH.Text = dgvKH.Rows[e.RowIndex].Cells[0].Value.ToString();


            }
            LayDL();
        }
    }
}
