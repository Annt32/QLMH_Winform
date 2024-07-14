namespace DuAn1_Nhom6
{
    partial class CTSP
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
            txtGia = new TextBox();
            txtSL = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtCL = new TextBox();
            txtSZ = new TextBox();
            txtSP = new TextBox();
            txtCTSP = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvCTSP = new DataGridView();
            txtNSX = new TextBox();
            label10 = new Label();
            txtDVC = new TextBox();
            label12 = new Label();
            label14 = new Label();
            txtLSZ = new TextBox();
            txtTSP = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label18 = new Label();
            txtNT = new TextBox();
            label20 = new Label();
            txtVC = new TextBox();
            label21 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            dtpVC = new DateTimePicker();
            label19 = new Label();
            groupBox3 = new GroupBox();
            txtLoaiCL = new ComboBox();
            txtTenNSX = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            txtMHDCT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCTSP).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtGia
            // 
            txtGia.Location = new Point(102, 46);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(200, 23);
            txtGia.TabIndex = 31;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(102, 17);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(200, 23);
            txtSL.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 49);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 27;
            label7.Text = "Giá";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 25);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 26;
            label8.Text = "Số Lượng";
            // 
            // txtCL
            // 
            txtCL.Enabled = false;
            txtCL.Location = new Point(113, 100);
            txtCL.Name = "txtCL";
            txtCL.Size = new Size(225, 23);
            txtCL.TabIndex = 25;
            // 
            // txtSZ
            // 
            txtSZ.Enabled = false;
            txtSZ.Location = new Point(113, 71);
            txtSZ.Name = "txtSZ";
            txtSZ.Size = new Size(225, 23);
            txtSZ.TabIndex = 24;
            // 
            // txtSP
            // 
            txtSP.Enabled = false;
            txtSP.Location = new Point(113, 42);
            txtSP.Name = "txtSP";
            txtSP.Size = new Size(225, 23);
            txtSP.TabIndex = 23;
            // 
            // txtCTSP
            // 
            txtCTSP.Enabled = false;
            txtCTSP.Location = new Point(113, 13);
            txtCTSP.Name = "txtCTSP";
            txtCTSP.Size = new Size(225, 23);
            txtCTSP.TabIndex = 22;
            txtCTSP.TextChanged += txtCTSP_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 103);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 21;
            label4.Text = "Mã Chất Liệu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 74);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 20;
            label3.Text = "Mã Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 45);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 19;
            label2.Text = "Mã Sản Phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 21);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 18;
            label1.Text = "Mã CT Sản Phẩm";
            // 
            // dgvCTSP
            // 
            dgvCTSP.AllowUserToAddRows = false;
            dgvCTSP.AllowUserToDeleteRows = false;
            dgvCTSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTSP.Location = new Point(21, 346);
            dgvCTSP.Name = "dgvCTSP";
            dgvCTSP.ReadOnly = true;
            dgvCTSP.RowHeadersWidth = 51;
            dgvCTSP.RowTemplate.Height = 25;
            dgvCTSP.Size = new Size(1125, 197);
            dgvCTSP.TabIndex = 17;
            dgvCTSP.CellContentClick += dgvCTSP_CellContentClick;
            // 
            // txtNSX
            // 
            txtNSX.Enabled = false;
            txtNSX.Location = new Point(113, 130);
            txtNSX.Name = "txtNSX";
            txtNSX.Size = new Size(225, 23);
            txtNSX.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 134);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 35;
            label10.Text = "Mã nhà sản xuất";
            // 
            // txtDVC
            // 
            txtDVC.Location = new Point(121, 140);
            txtDVC.Name = "txtDVC";
            txtDVC.Size = new Size(279, 23);
            txtDVC.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 142);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 50;
            label12.Text = "Voucher";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 112);
            label14.Name = "label14";
            label14.Size = new Size(95, 15);
            label14.TabIndex = 48;
            label14.Text = "Tên nhà sản xuất";
            // 
            // txtLSZ
            // 
            txtLSZ.Location = new Point(121, 51);
            txtLSZ.Name = "txtLSZ";
            txtLSZ.Size = new Size(279, 23);
            txtLSZ.TabIndex = 46;
            // 
            // txtTSP
            // 
            txtTSP.Location = new Point(121, 22);
            txtTSP.Name = "txtTSP";
            txtTSP.Size = new Size(279, 23);
            txtTSP.TabIndex = 44;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 82);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 43;
            label15.Text = "Loại Chất liệu";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 54);
            label16.Name = "label16";
            label16.Size = new Size(52, 15);
            label16.TabIndex = 42;
            label16.Text = "Loại Size";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(17, 30);
            label18.Name = "label18";
            label18.Size = new Size(81, 15);
            label18.TabIndex = 40;
            label18.Text = "Tên Sản Phẩm";
            // 
            // txtNT
            // 
            txtNT.Enabled = false;
            txtNT.Location = new Point(102, 98);
            txtNT.Name = "txtNT";
            txtNT.Size = new Size(200, 23);
            txtNT.TabIndex = 57;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(12, 101);
            label20.Name = "label20";
            label20.Size = new Size(60, 15);
            label20.TabIndex = 56;
            label20.Text = "Người tạo";
            // 
            // txtVC
            // 
            txtVC.Enabled = false;
            txtVC.Location = new Point(113, 159);
            txtVC.Name = "txtVC";
            txtVC.Size = new Size(225, 23);
            txtVC.TabIndex = 59;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(9, 162);
            label21.Name = "label21";
            label21.Size = new Size(70, 15);
            label21.TabIndex = 58;
            label21.Text = "Mã Voucher";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtVC);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCTSP);
            groupBox1.Controls.Add(txtSP);
            groupBox1.Controls.Add(txtSZ);
            groupBox1.Controls.Add(txtCL);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtNSX);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 293);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin mã";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtNT);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(dtpVC);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(txtSL);
            groupBox2.Controls.Add(txtGia);
            groupBox2.Location = new Point(385, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 293);
            groupBox2.TabIndex = 61;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // button1
            // 
            button1.Location = new Point(158, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 58;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpVC
            // 
            dtpVC.Location = new Point(102, 72);
            dtpVC.Name = "dtpVC";
            dtpVC.Size = new Size(200, 23);
            dtpVC.TabIndex = 55;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 77);
            label19.Name = "label19";
            label19.Size = new Size(75, 15);
            label19.TabIndex = 54;
            label19.Text = "Hạn Voucher";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtLoaiCL);
            groupBox3.Controls.Add(txtTenNSX);
            groupBox3.Controls.Add(txtTSP);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(txtDVC);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtLSZ);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(746, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 293);
            groupBox3.TabIndex = 62;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi Tiết";
            // 
            // txtLoaiCL
            // 
            txtLoaiCL.FormattingEnabled = true;
            txtLoaiCL.Items.AddRange(new object[] { "Nhua Resin", "Go", "Giay" });
            txtLoaiCL.Location = new Point(121, 80);
            txtLoaiCL.Margin = new Padding(3, 2, 3, 2);
            txtLoaiCL.Name = "txtLoaiCL";
            txtLoaiCL.Size = new Size(281, 23);
            txtLoaiCL.TabIndex = 54;
            // 
            // txtTenNSX
            // 
            txtTenNSX.FormattingEnabled = true;
            txtTenNSX.Items.AddRange(new object[] { "Bandai", "MegaHouse" });
            txtTenNSX.Location = new Point(121, 110);
            txtTenNSX.Margin = new Padding(3, 2, 3, 2);
            txtTenNSX.Name = "txtTenNSX";
            txtTenNSX.Size = new Size(281, 23);
            txtTenNSX.TabIndex = 54;
            // 
            // button2
            // 
            button2.Location = new Point(1117, 317);
            button2.Name = "button2";
            button2.Size = new Size(31, 23);
            button2.TabIndex = 59;
            button2.Text = "RL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1073, 554);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 63;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtMHDCT
            // 
            txtMHDCT.Location = new Point(21, 318);
            txtMHDCT.Name = "txtMHDCT";
            txtMHDCT.Size = new Size(22, 23);
            txtMHDCT.TabIndex = 60;
            // 
            // CTSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 589);
            Controls.Add(txtMHDCT);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvCTSP);
            Name = "CTSP";
            Text = "CTSP";
            Load += CTSP_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCTSP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtGia;
        private TextBox txtSL;
        private Label label7;
        private Label label8;
        private TextBox txtCL;
        private TextBox txtSZ;
        private TextBox txtSP;
        private TextBox txtCTSP;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvCTSP;
        private TextBox txtNSX;
        private Label label10;
        private TextBox txtDVC;
        private Label label12;
        private Label label14;
        private TextBox txtLSZ;
        private TextBox txtTSP;
        private Label label15;
        private Label label16;
        private Label label18;
        private TextBox txtNT;
        private Label label20;
        private TextBox txtVC;
        private Label label21;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private GroupBox groupBox3;
        private Button button2;
        private Button button3;
        private TextBox txtMHDCT;
        private DateTimePicker dtpVC;
        private Label label19;
        private ComboBox txtLoaiCL;
        private ComboBox txtTenNSX;
    }
}