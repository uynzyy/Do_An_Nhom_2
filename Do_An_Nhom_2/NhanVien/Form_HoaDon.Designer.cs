namespace Do_An_Nhom_2.NhanVien
{
    partial class Form_HoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_MaPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_TenKH = new System.Windows.Forms.Label();
            this.LB_NgayTP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_TongTien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_TroLai = new System.Windows.Forms.Button();
            this.LB_NgayTraPhongDuTinh = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(451, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng:";
            // 
            // cmb_MaPhong
            // 
            this.cmb_MaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MaPhong.FormattingEnabled = true;
            this.cmb_MaPhong.Location = new System.Drawing.Point(347, 170);
            this.cmb_MaPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_MaPhong.Name = "cmb_MaPhong";
            this.cmb_MaPhong.Size = new System.Drawing.Size(201, 24);
            this.cmb_MaPhong.TabIndex = 2;
            this.cmb_MaPhong.SelectedIndexChanged += new System.EventHandler(this.cmb_MaPhong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khách Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Trả Phòng Thực Tế::";
            // 
            // LB_TenKH
            // 
            this.LB_TenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LB_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TenKH.Location = new System.Drawing.Point(341, 225);
            this.LB_TenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TenKH.Name = "LB_TenKH";
            this.LB_TenKH.Size = new System.Drawing.Size(263, 25);
            this.LB_TenKH.TabIndex = 5;
            // 
            // LB_NgayTP
            // 
            this.LB_NgayTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LB_NgayTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NgayTP.Location = new System.Drawing.Point(341, 347);
            this.LB_NgayTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NgayTP.Name = "LB_NgayTP";
            this.LB_NgayTP.Size = new System.Drawing.Size(263, 25);
            this.LB_NgayTP.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng tiền:";
            // 
            // LB_TongTien
            // 
            this.LB_TongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LB_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TongTien.Location = new System.Drawing.Point(341, 396);
            this.LB_TongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TongTien.Name = "LB_TongTien";
            this.LB_TongTien.Size = new System.Drawing.Size(263, 25);
            this.LB_TongTien.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(888, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tiện nghi bị hư hại";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(925, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(189, 409);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Lime;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(503, 578);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(311, 55);
            this.btn_ThanhToan.TabIndex = 13;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_TroLai
            // 
            this.btn_TroLai.BackColor = System.Drawing.Color.SlateGray;
            this.btn_TroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TroLai.Location = new System.Drawing.Point(132, 581);
            this.btn_TroLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TroLai.Name = "btn_TroLai";
            this.btn_TroLai.Size = new System.Drawing.Size(153, 53);
            this.btn_TroLai.TabIndex = 14;
            this.btn_TroLai.Text = "Thoát";
            this.btn_TroLai.UseVisualStyleBackColor = false;
            this.btn_TroLai.Click += new System.EventHandler(this.btn_TroLai_Click);
            // 
            // LB_NgayTraPhongDuTinh
            // 
            this.LB_NgayTraPhongDuTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LB_NgayTraPhongDuTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NgayTraPhongDuTinh.Location = new System.Drawing.Point(341, 286);
            this.LB_NgayTraPhongDuTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NgayTraPhongDuTinh.Name = "LB_NgayTraPhongDuTinh";
            this.LB_NgayTraPhongDuTinh.Size = new System.Drawing.Size(263, 25);
            this.LB_NgayTraPhongDuTinh.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày Trả Phòng Dự Tính:";
            // 
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 678);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LB_NgayTraPhongDuTinh);
            this.Controls.Add(this.btn_TroLai);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LB_TongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LB_NgayTP);
            this.Controls.Add(this.LB_TenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_MaPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_HoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.Form_HoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_MaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_TenKH;
        private System.Windows.Forms.Label LB_NgayTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_TongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_TroLai;
        private System.Windows.Forms.Label LB_NgayTraPhongDuTinh;
        private System.Windows.Forms.Label label8;
    }
}