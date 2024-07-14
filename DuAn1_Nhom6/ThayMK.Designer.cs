namespace DuAn1_Nhom6
{
    partial class ThayMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThayMK));
            label1 = new Label();
            label2 = new Label();
            txtPassMoi = new TextBox();
            txtMKMoi = new TextBox();
            btnConfirm = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(215, 329);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 0;
            label1.Text = "Nhập mật khẩu mới";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(215, 382);
            label2.Name = "label2";
            label2.Size = new Size(174, 21);
            label2.TabIndex = 0;
            label2.Text = "Xác nhận mật khẩu mới";
            // 
            // txtPassMoi
            // 
            txtPassMoi.Location = new Point(410, 331);
            txtPassMoi.Margin = new Padding(3, 2, 3, 2);
            txtPassMoi.Name = "txtPassMoi";
            txtPassMoi.Size = new Size(271, 23);
            txtPassMoi.TabIndex = 1;
            // 
            // txtMKMoi
            // 
            txtMKMoi.Location = new Point(410, 386);
            txtMKMoi.Margin = new Padding(3, 2, 3, 2);
            txtMKMoi.Name = "txtMKMoi";
            txtMKMoi.Size = new Size(271, 23);
            txtMKMoi.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Red;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = SystemColors.Control;
            btnConfirm.Location = new Point(594, 86);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(114, 30);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 34);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1101, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-200, 52);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(136, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(410, 283);
            label3.Name = "label3";
            label3.Size = new Size(228, 21);
            label3.TabIndex = 0;
            label3.Text = "Vui lòng nhập mật khẩu mới";
            label3.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConfirm);
            panel1.Location = new Point(172, 316);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 128);
            panel1.TabIndex = 68;
            // 
            // ThayMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 477);
            Controls.Add(pictureBox3);
            Controls.Add(txtMKMoi);
            Controls.Add(txtPassMoi);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThayMK";
            Text = "ThayMK";
            Load += ThayMK_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPassMoi;
        private TextBox txtMKMoi;
        private Button btnConfirm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label3;
        private Panel panel1;
    }
}