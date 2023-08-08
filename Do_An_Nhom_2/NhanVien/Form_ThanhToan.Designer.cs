namespace Do_An_Nhom_2.NhanVien
{
    partial class Form_ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThanhToan));
            this.label1 = new System.Windows.Forms.Label();
            this.LB_TongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDTT = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMHĐ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LB_SoPDP = new System.Windows.Forms.Label();
            this.LB_HoTen = new System.Windows.Forms.Label();
            this.LB_SDT = new System.Windows.Forms.Label();
            this.LB_MaPhong = new System.Windows.Forms.Label();
            this.DTP_ND = new System.Windows.Forms.DateTimePicker();
            this.DTP_NT = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Datcoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(609, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN";
            // 
            // LB_TongTien
            // 
            this.LB_TongTien.AutoSize = true;
            this.LB_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TongTien.Location = new System.Drawing.Point(506, 331);
            this.LB_TongTien.Name = "LB_TongTien";
            this.LB_TongTien.Size = new System.Drawing.Size(24, 26);
            this.LB_TongTien.TabIndex = 43;
            this.LB_TongTien.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tổng tiền:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 348);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // btnDTT
            // 
            this.btnDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDTT.Location = new System.Drawing.Point(489, 440);
            this.btnDTT.Name = "btnDTT";
            this.btnDTT.Size = new System.Drawing.Size(149, 70);
            this.btnDTT.TabIndex = 46;
            this.btnDTT.Text = "Đã thanh toán";
            this.btnDTT.UseVisualStyleBackColor = true;
            this.btnDTT.Click += new System.EventHandler(this.btnDTT_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(740, 440);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(136, 70);
            this.btnHuy.TabIndex = 46;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Ngày đặt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Mã phòng:";
            // 
            // lblMHĐ
            // 
            this.lblMHĐ.AutoSize = true;
            this.lblMHĐ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMHĐ.Location = new System.Drawing.Point(354, 100);
            this.lblMHĐ.Name = "lblMHĐ";
            this.lblMHĐ.Size = new System.Drawing.Size(157, 20);
            this.lblMHĐ.TabIndex = 50;
            this.lblMHĐ.Text = "Số Phiếu Đặt Phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(735, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Ngày trả:";
            // 
            // LB_SoPDP
            // 
            this.LB_SoPDP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LB_SoPDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SoPDP.Location = new System.Drawing.Point(535, 100);
            this.LB_SoPDP.Name = "LB_SoPDP";
            this.LB_SoPDP.Size = new System.Drawing.Size(133, 20);
            this.LB_SoPDP.TabIndex = 52;
            // 
            // LB_HoTen
            // 
            this.LB_HoTen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LB_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_HoTen.Location = new System.Drawing.Point(455, 147);
            this.LB_HoTen.Name = "LB_HoTen";
            this.LB_HoTen.Size = new System.Drawing.Size(213, 20);
            this.LB_HoTen.TabIndex = 53;
            // 
            // LB_SDT
            // 
            this.LB_SDT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LB_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SDT.Location = new System.Drawing.Point(418, 195);
            this.LB_SDT.Name = "LB_SDT";
            this.LB_SDT.Size = new System.Drawing.Size(250, 20);
            this.LB_SDT.TabIndex = 54;
            // 
            // LB_MaPhong
            // 
            this.LB_MaPhong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LB_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaPhong.Location = new System.Drawing.Point(454, 291);
            this.LB_MaPhong.Name = "LB_MaPhong";
            this.LB_MaPhong.Size = new System.Drawing.Size(214, 20);
            this.LB_MaPhong.TabIndex = 57;
            // 
            // DTP_ND
            // 
            this.DTP_ND.Enabled = false;
            this.DTP_ND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_ND.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_ND.Location = new System.Drawing.Point(459, 239);
            this.DTP_ND.Name = "DTP_ND";
            this.DTP_ND.Size = new System.Drawing.Size(183, 26);
            this.DTP_ND.TabIndex = 58;
            // 
            // DTP_NT
            // 
            this.DTP_NT.Enabled = false;
            this.DTP_NT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_NT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_NT.Location = new System.Drawing.Point(847, 239);
            this.DTP_NT.Name = "DTP_NT";
            this.DTP_NT.Size = new System.Drawing.Size(183, 26);
            this.DTP_NT.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(381, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "*Chú thích: Khách hàng có thể đặt cọc 50% tổng tiền";
            // 
            // txt_Datcoc
            // 
            this.txt_Datcoc.Location = new System.Drawing.Point(847, 339);
            this.txt_Datcoc.Name = "txt_Datcoc";
            this.txt_Datcoc.Size = new System.Drawing.Size(183, 23);
            this.txt_Datcoc.TabIndex = 60;
            this.txt_Datcoc.TextChanged += new System.EventHandler(this.txt_Datcoc_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(734, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 26);
            this.label9.TabIndex = 61;
            this.label9.Text = "Đặt cọc:";
            // 
            // Form_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 588);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Datcoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTP_NT);
            this.Controls.Add(this.DTP_ND);
            this.Controls.Add(this.LB_MaPhong);
            this.Controls.Add(this.LB_SDT);
            this.Controls.Add(this.LB_HoTen);
            this.Controls.Add(this.LB_SoPDP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMHĐ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDTT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_TongTien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ThanhToan";
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.Form_ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_TongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDTT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMHĐ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LB_SoPDP;
        private System.Windows.Forms.Label LB_HoTen;
        private System.Windows.Forms.Label LB_SDT;
        private System.Windows.Forms.Label LB_MaPhong;
        private System.Windows.Forms.DateTimePicker DTP_ND;
        private System.Windows.Forms.DateTimePicker DTP_NT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Datcoc;
        private System.Windows.Forms.Label label9;
    }
}