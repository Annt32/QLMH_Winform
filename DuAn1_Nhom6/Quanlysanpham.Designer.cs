﻿namespace DuAn1_Nhom6
{
    partial class Quanlysanpham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            txtMaNSX = new ComboBox();
            txtChatLieu = new ComboBox();
            txtSize = new ComboBox();
            btnXoa = new Button();
            txtVC = new TextBox();
            txtTien = new TextBox();
            txtSoLuong = new TextBox();
            label8 = new Label();
            txtSPCT = new TextBox();
            txtGia = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            btnThem = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtTenSanPham = new TextBox();
            txtMaSP = new TextBox();
            button4 = new Button();
            groupBox2 = new GroupBox();
            button1 = new Button();
            txtTimKiemSP = new TextBox();
            btnTimKiemSP = new Button();
            dgvSP = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaNSX);
            groupBox1.Controls.Add(txtChatLieu);
            groupBox1.Controls.Add(txtSize);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtVC);
            groupBox1.Controls.Add(txtTien);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSPCT);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(666, 261);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtMaNSX
            // 
            txtMaNSX.FormattingEnabled = true;
            txtMaNSX.Items.AddRange(new object[] { "Bandai", "MegaHouse" });
            txtMaNSX.Location = new Point(116, 75);
            txtMaNSX.Margin = new Padding(3, 2, 3, 2);
            txtMaNSX.Name = "txtMaNSX";
            txtMaNSX.Size = new Size(427, 23);
            txtMaNSX.TabIndex = 3;
            // 
            // txtChatLieu
            // 
            txtChatLieu.FormattingEnabled = true;
            txtChatLieu.Items.AddRange(new object[] { "Nhua Resin", "Go", "Giay" });
            txtChatLieu.Location = new Point(116, 148);
            txtChatLieu.Margin = new Padding(3, 2, 3, 2);
            txtChatLieu.Name = "txtChatLieu";
            txtChatLieu.Size = new Size(427, 23);
            txtChatLieu.TabIndex = 3;
            // 
            // txtSize
            // 
            txtSize.FormattingEnabled = true;
            txtSize.Items.AddRange(new object[] { "24cm", "27cm", "30cm" });
            txtSize.Location = new Point(116, 122);
            txtSize.Margin = new Padding(3, 2, 3, 2);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(427, 23);
            txtSize.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(563, 134);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 32);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtVC
            // 
            txtVC.Location = new Point(116, 223);
            txtVC.Margin = new Padding(3, 2, 3, 2);
            txtVC.Name = "txtVC";
            txtVC.Size = new Size(427, 23);
            txtVC.TabIndex = 1;
            txtVC.TextChanged += txtMaSP_TextChanged;
            // 
            // txtTien
            // 
            txtTien.Location = new Point(116, 198);
            txtTien.Margin = new Padding(3, 2, 3, 2);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(427, 23);
            txtTien.TabIndex = 1;
            txtTien.TextChanged += txtMaSP_TextChanged;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(116, 173);
            txtSoLuong.Margin = new Padding(3, 2, 3, 2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(427, 23);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.TextChanged += txtMaSP_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 225);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 2;
            label8.Text = "Voucher";
            label8.Click += label5_Click;
            // 
            // txtSPCT
            // 
            txtSPCT.Location = new Point(116, 100);
            txtSPCT.Margin = new Padding(3, 2, 3, 2);
            txtSPCT.Name = "txtSPCT";
            txtSPCT.Size = new Size(427, 23);
            txtSPCT.TabIndex = 1;
            txtSPCT.TextChanged += txtMaSP_TextChanged;
            // 
            // txtGia
            // 
            txtGia.AutoSize = true;
            txtGia.Location = new Point(17, 200);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(24, 15);
            txtGia.TabIndex = 2;
            txtGia.Text = "Giá";
            txtGia.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 100);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 2;
            label6.Text = "Mã SPCT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 173);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 2;
            label7.Text = "Số lượng";
            label7.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 147);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Chất liệu";
            label2.Click += label5_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(563, 66);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 32);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 124);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 2;
            label4.Text = "Loại size";
            label4.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 50);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 2;
            label5.Text = "Tên sản phẩm";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 74);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên NSX";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Mã sản phẩm";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(116, 52);
            txtTenSanPham.Margin = new Padding(3, 2, 3, 2);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(427, 23);
            txtTenSanPham.TabIndex = 1;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(116, 28);
            txtMaSP.Margin = new Padding(3, 2, 3, 2);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(427, 23);
            txtMaSP.TabIndex = 1;
            txtMaSP.TextChanged += txtMaSP_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(352, 128);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(7, 6);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtTimKiemSP);
            groupBox2.Controls.Add(btnTimKiemSP);
            groupBox2.Controls.Add(dgvSP);
            groupBox2.Location = new Point(10, 288);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(666, 220);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(587, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "CTSP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtTimKiemSP
            // 
            txtTimKiemSP.Location = new Point(16, 29);
            txtTimKiemSP.Margin = new Padding(3, 2, 3, 2);
            txtTimKiemSP.Name = "txtTimKiemSP";
            txtTimKiemSP.Size = new Size(458, 23);
            txtTimKiemSP.TabIndex = 1;
            // 
            // btnTimKiemSP
            // 
            btnTimKiemSP.BackColor = SystemColors.ButtonHighlight;
            btnTimKiemSP.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiemSP.Location = new Point(480, 28);
            btnTimKiemSP.Margin = new Padding(3, 2, 3, 2);
            btnTimKiemSP.Name = "btnTimKiemSP";
            btnTimKiemSP.Size = new Size(101, 20);
            btnTimKiemSP.TabIndex = 0;
            btnTimKiemSP.Text = "TÌm kiếm";
            btnTimKiemSP.UseVisualStyleBackColor = false;
            btnTimKiemSP.Click += btnTimKiemSP_Click;
            // 
            // dgvSP
            // 
            dgvSP.AllowUserToAddRows = false;
            dgvSP.AllowUserToDeleteRows = false;
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Location = new Point(16, 60);
            dgvSP.Margin = new Padding(3, 2, 3, 2);
            dgvSP.Name = "dgvSP";
            dgvSP.ReadOnly = true;
            dgvSP.RowHeadersWidth = 51;
            dgvSP.RowTemplate.Height = 29;
            dgvSP.Size = new Size(633, 140);
            dgvSP.TabIndex = 0;
            dgvSP.CellContentClick += dgvSP_CellContentClick;
            // 
            // Quanlysanpham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 548);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Quanlysanpham";
            Text = "Quanlysanpham";
            Load += Quanlysanpham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Button btnXoa;
        private GroupBox groupBox2;
        private Button button4;
        private TextBox txtTimKiemSP;
        private Button btnTimKiemSP;
        private DataGridView dgvSP;
        private Button btnThem;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox txtTenSanPham;
        private TextBox txtMaSP;
        private Button button1;
        private ComboBox txtSize;
        private Label label4;
        private ComboBox txtMaNSX;
        private ComboBox txtChatLieu;
        private Label label2;
        private Label label6;
        private TextBox txtSPCT;
        private Label txtGia;
        private Label label7;
        private TextBox txtSoLuong;
        private TextBox txtTien;
        private TextBox txtVC;
        private Label label8;
    }
}