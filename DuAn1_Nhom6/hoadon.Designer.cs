namespace DuAn1_Nhom6
{
    partial class hoadon
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
            dgvHDCT = new DataGridView();
            dgvHD = new DataGridView();
            button1 = new Button();
            txtSP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSZ = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSL = new TextBox();
            label5 = new Label();
            txtGia = new TextBox();
            label6 = new Label();
            DTPVC = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            txtTK = new TextBox();
            button4 = new Button();
            RBDTT = new RadioButton();
            RBCTT = new RadioButton();
            label9 = new Label();
            txtHDCT = new TextBox();
            button5 = new Button();
            label10 = new Label();
            txtMSP = new TextBox();
            BTHDCT = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtSLHDCY = new TextBox();
            txtIDNV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHDCT
            // 
            dgvHDCT.AllowUserToAddRows = false;
            dgvHDCT.AllowUserToDeleteRows = false;
            dgvHDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDCT.Location = new Point(17, 22);
            dgvHDCT.Name = "dgvHDCT";
            dgvHDCT.ReadOnly = true;
            dgvHDCT.RowHeadersWidth = 51;
            dgvHDCT.RowTemplate.Height = 25;
            dgvHDCT.Size = new Size(470, 257);
            dgvHDCT.TabIndex = 1;
            dgvHDCT.CellContentClick += dgvHDCT_CellContentClick;
            // 
            // dgvHD
            // 
            dgvHD.AllowUserToAddRows = false;
            dgvHD.AllowUserToDeleteRows = false;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Location = new Point(6, 22);
            dgvHD.Name = "dgvHD";
            dgvHD.ReadOnly = true;
            dgvHD.RowHeadersWidth = 51;
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new Size(906, 171);
            dgvHD.TabIndex = 2;
            dgvHD.CellContentClick += dataGridView3_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(850, 339);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSP
            // 
            txtSP.Location = new Point(124, 92);
            txtSP.Name = "txtSP";
            txtSP.Size = new Size(298, 23);
            txtSP.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 95);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 137);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 7;
            label2.Text = "MenhGiaVoucher";
            // 
            // txtSZ
            // 
            txtSZ.Location = new Point(124, 134);
            txtSZ.Name = "txtSZ";
            txtSZ.Size = new Size(298, 23);
            txtSZ.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 180);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 9;
            label3.Text = "HSDVoucher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 222);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 11;
            label4.Text = "Số lượng Mua";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(124, 214);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(298, 23);
            txtSL.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 263);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 13;
            label5.Text = "Giá";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(124, 255);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(298, 23);
            txtGia.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 306);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 15;
            label6.Text = "Trạng thái";
            // 
            // DTPVC
            // 
            DTPVC.CustomFormat = "";
            DTPVC.Format = DateTimePickerFormat.Short;
            DTPVC.Location = new Point(124, 174);
            DTPVC.Margin = new Padding(3, 2, 3, 2);
            DTPVC.Name = "DTPVC";
            DTPVC.Size = new Size(220, 23);
            DTPVC.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(59, 340);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(255, 340);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 19;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 348);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 21;
            label7.Text = "Tìm kiếm";
            label7.Click += label7_Click;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(547, 341);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(298, 23);
            txtTK.TabIndex = 20;
            // 
            // button4
            // 
            button4.Location = new Point(158, 340);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 22;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // RBDTT
            // 
            RBDTT.AutoSize = true;
            RBDTT.Enabled = false;
            RBDTT.Location = new Point(124, 302);
            RBDTT.Name = "RBDTT";
            RBDTT.Size = new Size(100, 19);
            RBDTT.TabIndex = 23;
            RBDTT.TabStop = true;
            RBDTT.Text = "Đã thanh toán";
            RBDTT.UseVisualStyleBackColor = true;
            // 
            // RBCTT
            // 
            RBCTT.AutoSize = true;
            RBCTT.Location = new Point(269, 302);
            RBCTT.Name = "RBCTT";
            RBCTT.Size = new Size(108, 19);
            RBCTT.TabIndex = 24;
            RBCTT.TabStop = true;
            RBCTT.Text = "Chờ thanh toán";
            RBCTT.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 51);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 28;
            label9.Text = "Mã Hóa đơn CT";
            // 
            // txtHDCT
            // 
            txtHDCT.Enabled = false;
            txtHDCT.Location = new Point(124, 48);
            txtHDCT.Name = "txtHDCT";
            txtHDCT.Size = new Size(298, 23);
            txtHDCT.TabIndex = 27;
            // 
            // button5
            // 
            button5.Location = new Point(356, 341);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 29;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 15);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 31;
            label10.Text = "Mã Sản Phẩm";
            // 
            // txtMSP
            // 
            txtMSP.Enabled = false;
            txtMSP.Location = new Point(124, 12);
            txtMSP.Name = "txtMSP";
            txtMSP.Size = new Size(298, 23);
            txtMSP.TabIndex = 30;
            // 
            // BTHDCT
            // 
            BTHDCT.Location = new Point(881, 19);
            BTHDCT.Name = "BTHDCT";
            BTHDCT.Size = new Size(75, 23);
            BTHDCT.TabIndex = 32;
            BTHDCT.Text = "HDCT";
            BTHDCT.UseVisualStyleBackColor = true;
            BTHDCT.Click += BTHDCT_Click;
            // 
            // button6
            // 
            button6.Location = new Point(938, 70);
            button6.Name = "button6";
            button6.Size = new Size(34, 23);
            button6.TabIndex = 33;
            button6.Text = "RL";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHD);
            groupBox1.Location = new Point(20, 369);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 212);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHDCT);
            groupBox2.Location = new Point(439, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 285);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // txtSLHDCY
            // 
            txtSLHDCY.Location = new Point(456, 12);
            txtSLHDCY.Name = "txtSLHDCY";
            txtSLHDCY.Size = new Size(33, 23);
            txtSLHDCY.TabIndex = 38;
            txtSLHDCY.Visible = false;
            // 
            // txtIDNV
            // 
            txtIDNV.Location = new Point(495, 12);
            txtIDNV.Name = "txtIDNV";
            txtIDNV.Size = new Size(33, 23);
            txtIDNV.TabIndex = 39;
            txtIDNV.Visible = false;
            // 
            // hoadon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 608);
            Controls.Add(txtIDNV);
            Controls.Add(txtSLHDCY);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(BTHDCT);
            Controls.Add(label10);
            Controls.Add(txtMSP);
            Controls.Add(button5);
            Controls.Add(label9);
            Controls.Add(txtHDCT);
            Controls.Add(RBCTT);
            Controls.Add(RBDTT);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(txtTK);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(DTPVC);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtGia);
            Controls.Add(label4);
            Controls.Add(txtSL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSZ);
            Controls.Add(label1);
            Controls.Add(txtSP);
            Controls.Add(button1);
            Name = "hoadon";
            Text = "hoadon";
            Load += hoadon_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvHDCT;
        private DataGridView dgvHD;
        private Button button1;
        private TextBox txtSP;
        private Label label1;
        private Label label2;
        private TextBox txtSZ;
        private Label label3;
        private Label label4;
        private TextBox txtSL;
        private Label label5;
        private TextBox txtGia;
        private Label label6;
        private DateTimePicker DTPVC;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox txtTK;
        private Button button4;
        private RadioButton RBDTT;
        private RadioButton RBCTT;
        private Label label9;
        private TextBox txtHDCT;
        private Button button5;
        private Label label10;
        private TextBox txtMSP;
        private Button BTHDCT;
        private Button button6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtSLHDCY;
        private TextBox txtIDNV;
    }
}