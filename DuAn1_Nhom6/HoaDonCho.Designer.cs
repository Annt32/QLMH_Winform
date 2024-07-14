namespace DuAn1_Nhom6
{
    partial class HoaDonCho
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
            dgvHDC = new DataGridView();
            dgvHDTT = new DataGridView();
            label5 = new Label();
            txtTT = new TextBox();
            label4 = new Label();
            txtSL = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            bttExit = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtMNV = new TextBox();
            label2 = new Label();
            txtTKNV = new TextBox();
            dgvNV = new DataGridView();
            button5 = new Button();
            ss = new Label();
            txtKH = new TextBox();
            dgvKH = new DataGridView();
            button6 = new Button();
            txtTKH = new TextBox();
            label3 = new Label();
            txtSTT = new TextBox();
            txtSTTM = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHDC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHDTT).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            SuspendLayout();
            // 
            // dgvHDC
            // 
            dgvHDC.AllowUserToAddRows = false;
            dgvHDC.AllowUserToDeleteRows = false;
            dgvHDC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDC.Location = new Point(6, 16);
            dgvHDC.Name = "dgvHDC";
            dgvHDC.ReadOnly = true;
            dgvHDC.RowHeadersWidth = 51;
            dgvHDC.RowTemplate.Height = 25;
            dgvHDC.Size = new Size(508, 288);
            dgvHDC.TabIndex = 0;
            dgvHDC.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgvHDTT
            // 
            dgvHDTT.AllowUserToAddRows = false;
            dgvHDTT.AllowUserToDeleteRows = false;
            dgvHDTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDTT.Location = new Point(6, 22);
            dgvHDTT.Name = "dgvHDTT";
            dgvHDTT.ReadOnly = true;
            dgvHDTT.RowHeadersWidth = 51;
            dgvHDTT.RowTemplate.Height = 25;
            dgvHDTT.Size = new Size(508, 244);
            dgvHDTT.TabIndex = 1;
            dgvHDTT.CellContentClick += dgvHDTT_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(551, 106);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 37;
            label5.Text = "Tổng tiền";
            // 
            // txtTT
            // 
            txtTT.Location = new Point(655, 98);
            txtTT.Name = "txtTT";
            txtTT.Size = new Size(298, 23);
            txtTT.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(551, 64);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 35;
            label4.Text = "Số lượng Mua";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(655, 57);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(298, 23);
            txtSL.TabIndex = 34;
            // 
            // button1
            // 
            button1.Location = new Point(622, 308);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 43;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(712, 308);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 44;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(634, 589);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 46;
            button3.Text = "In";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(542, 589);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 45;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // bttExit
            // 
            bttExit.Location = new Point(878, 589);
            bttExit.Name = "bttExit";
            bttExit.Size = new Size(75, 23);
            bttExit.TabIndex = 47;
            bttExit.Text = "Exit";
            bttExit.UseVisualStyleBackColor = true;
            bttExit.Click += bttExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHDC);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 310);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHDTT);
            groupBox2.Location = new Point(12, 327);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(533, 285);
            groupBox2.TabIndex = 49;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn đã thanh toán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(551, 26);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 51;
            label1.Text = "Mã Nhân Viên";
            // 
            // txtMNV
            // 
            txtMNV.Location = new Point(655, 18);
            txtMNV.Name = "txtMNV";
            txtMNV.Size = new Size(298, 23);
            txtMNV.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(553, 352);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 55;
            label2.Text = "Mã Nhân Viên";
            // 
            // txtTKNV
            // 
            txtTKNV.Location = new Point(648, 349);
            txtTKNV.Name = "txtTKNV";
            txtTKNV.Size = new Size(243, 23);
            txtTKNV.TabIndex = 54;
            // 
            // dgvNV
            // 
            dgvNV.AllowUserToAddRows = false;
            dgvNV.AllowUserToDeleteRows = false;
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Location = new Point(553, 378);
            dgvNV.Name = "dgvNV";
            dgvNV.ReadOnly = true;
            dgvNV.RowHeadersWidth = 51;
            dgvNV.RowTemplate.Height = 25;
            dgvNV.Size = new Size(400, 205);
            dgvNV.TabIndex = 2;
            dgvNV.CellContentClick += dgvNV_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(896, 349);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 56;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ss
            // 
            ss.AutoSize = true;
            ss.Location = new Point(550, 132);
            ss.Name = "ss";
            ss.Size = new Size(90, 15);
            ss.TabIndex = 58;
            ss.Text = "Mã Khách hàng";
            // 
            // txtKH
            // 
            txtKH.Location = new Point(655, 124);
            txtKH.Name = "txtKH";
            txtKH.Size = new Size(298, 23);
            txtKH.TabIndex = 57;
            // 
            // dgvKH
            // 
            dgvKH.AllowUserToAddRows = false;
            dgvKH.AllowUserToDeleteRows = false;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Location = new Point(550, 177);
            dgvKH.Name = "dgvKH";
            dgvKH.ReadOnly = true;
            dgvKH.RowHeadersWidth = 51;
            dgvKH.RowTemplate.Height = 25;
            dgvKH.Size = new Size(402, 94);
            dgvKH.TabIndex = 1;
            dgvKH.CellContentClick += dgvKH_CellContentClick;
            // 
            // button6
            // 
            button6.Location = new Point(917, 150);
            button6.Name = "button6";
            button6.Size = new Size(39, 23);
            button6.TabIndex = 59;
            button6.Text = "Tìm";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // txtTKH
            // 
            txtTKH.Location = new Point(648, 153);
            txtTKH.Name = "txtTKH";
            txtTKH.Size = new Size(265, 23);
            txtTKH.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 155);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 61;
            label3.Text = "Tìm kiếm";
            // 
            // txtSTT
            // 
            txtSTT.Location = new Point(896, 189);
            txtSTT.Name = "txtSTT";
            txtSTT.Size = new Size(42, 23);
            txtSTT.TabIndex = 50;
            // 
            // txtSTTM
            // 
            txtSTTM.Location = new Point(896, 215);
            txtSTTM.Name = "txtSTTM";
            txtSTTM.Size = new Size(42, 23);
            txtSTTM.TabIndex = 50;
            // 
            // HoaDonCho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 624);
            Controls.Add(label3);
            Controls.Add(txtTKH);
            Controls.Add(button6);
            Controls.Add(dgvKH);
            Controls.Add(ss);
            Controls.Add(txtKH);
            Controls.Add(button5);
            Controls.Add(dgvNV);
            Controls.Add(label2);
            Controls.Add(txtTKNV);
            Controls.Add(label1);
            Controls.Add(txtMNV);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(bttExit);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtTT);
            Controls.Add(label4);
            Controls.Add(txtSL);
            Controls.Add(txtSTTM);
            Controls.Add(txtSTT);
            Name = "HoaDonCho";
            Text = "HoaDonCho";
            Load += HoaDonCho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHDC).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHDTT).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHDC;
        private DataGridView dgvHDTT;
        private Label label5;
        private TextBox txtTT;
        private Label label4;
        private TextBox txtSL;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button bttExit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtMNV;
        private Label label2;
        private TextBox txtTKNV;
        private DataGridView dgvNV;
        private Button button5;
        private Label ss;
        private TextBox txtKH;
        private DataGridView dgvKH;
        private Button button6;
        private TextBox txtTKH;
        private Label label3;
        private TextBox txtSTT;
        private TextBox txtSTTM;
    }
}