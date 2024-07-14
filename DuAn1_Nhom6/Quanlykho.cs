
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Nhom6
{
    public partial class Quanlykho : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PMB8531\\SQLEXPRESS;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public Quanlykho()
        {
            InitializeComponent();
        }

        void HienThi()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhoHang", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

        }
        void LayDL()
        {
            string sql = "SELECT * FROM KhoHang";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }
        
        private void Quanlykho_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            HienThi();
            LayDL();
            MessageBox.Show("Hiển thị thông tin kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
