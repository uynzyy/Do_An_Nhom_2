namespace Do_An_Nhom_2.NhanVien
{
    partial class Form_DatPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DatPhong));
            this.lblTien = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Tang = new System.Windows.Forms.ComboBox();
            this.lblSLphong = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DTP_NTP = new System.Windows.Forms.DateTimePicker();
            this.DTP_NNP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.txt_SDT_KH = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.DTP_NgaySinh_KH = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.btnTT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.LB_DS_P = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.errorProvider_TenKH = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_SDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_CCCD = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_TenKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_SDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_CCCD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTien.Location = new System.Drawing.Point(568, 672);
            this.lblTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(20, 24);
            this.lblTien.TabIndex = 41;
            this.lblTien.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(403, 672);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 24);
            this.label12.TabIndex = 40;
            this.label12.Text = "Tổng tiền 1 ngày : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmb_Tang);
            this.groupBox1.Location = new System.Drawing.Point(23, 259);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(480, 305);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(152, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "CHỌN PHÒNG";
            // 
            // cmb_Tang
            // 
            this.cmb_Tang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tang.FormattingEnabled = true;
            this.cmb_Tang.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Tầng 3",
            "Tầng 4"});
            this.cmb_Tang.Location = new System.Drawing.Point(175, 63);
            this.cmb_Tang.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Tang.Name = "cmb_Tang";
            this.cmb_Tang.Size = new System.Drawing.Size(146, 21);
            this.cmb_Tang.TabIndex = 1;
            this.cmb_Tang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSLphong
            // 
            this.lblSLphong.AutoSize = true;
            this.lblSLphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLphong.Location = new System.Drawing.Point(166, 672);
            this.lblSLphong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSLphong.Name = "lblSLphong";
            this.lblSLphong.Size = new System.Drawing.Size(20, 24);
            this.lblSLphong.TabIndex = 36;
            this.lblSLphong.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 672);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Số lượng phòng :";
            // 
            // DTP_NTP
            // 
            this.DTP_NTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_NTP.Location = new System.Drawing.Point(486, 204);
            this.DTP_NTP.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_NTP.Name = "DTP_NTP";
            this.DTP_NTP.Size = new System.Drawing.Size(161, 20);
            this.DTP_NTP.TabIndex = 30;
            // 
            // DTP_NNP
            // 
            this.DTP_NNP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_NNP.Location = new System.Drawing.Point(486, 168);
            this.DTP_NNP.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_NNP.Name = "DTP_NNP";
            this.DTP_NNP.Size = new System.Drawing.Size(161, 20);
            this.DTP_NNP.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ngày trả phòng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ngày nhận phòng :";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(109, 204);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(193, 20);
            this.txt_CCCD.TabIndex = 26;
            this.txt_CCCD.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_CCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CCCD_KeyPress);
            // 
            // txt_SDT_KH
            // 
            this.txt_SDT_KH.Location = new System.Drawing.Point(109, 168);
            this.txt_SDT_KH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SDT_KH.Name = "txt_SDT_KH";
            this.txt_SDT_KH.Size = new System.Drawing.Size(193, 20);
            this.txt_SDT_KH.TabIndex = 25;
            this.txt_SDT_KH.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_SDT_KH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KH_KeyPress);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(109, 96);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(193, 20);
            this.txt_HoTen.TabIndex = 24;
            this.txt_HoTen.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // DTP_NgaySinh_KH
            // 
            this.DTP_NgaySinh_KH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_NgaySinh_KH.Location = new System.Drawing.Point(109, 131);
            this.DTP_NgaySinh_KH.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_NgaySinh_KH.Name = "DTP_NgaySinh_KH";
            this.DTP_NgaySinh_KH.Size = new System.Drawing.Size(193, 20);
            this.DTP_NgaySinh_KH.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số CCCD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Họ tên :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(521, 245);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 24);
            this.label13.TabIndex = 42;
            this.label13.Text = "Ghi chú:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(515, 493);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(297, 60);
            this.label14.TabIndex = 44;
            this.label14.Text = "1-2-3: Phòng đơn (300.000 VND / Ngày)\r\n4-5-6-7: Phòng đôi (600.000 VND / Ngày)\r\n8" +
    "-9-10: Phòng 4 (800.000 VND / Ngày)";
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKH.Location = new System.Drawing.Point(295, 25);
            this.lblKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(231, 39);
            this.lblKH.TabIndex = 45;
            this.lblKH.Text = "ĐẶT PHÒNG";
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.Lime;
            this.btnTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTT.Location = new System.Drawing.Point(621, 720);
            this.btnTT.Margin = new System.Windows.Forms.Padding(2);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(146, 38);
            this.btnTT.TabIndex = 46;
            this.btnTT.Text = "Thanh toán";
            this.btnTT.UseVisualStyleBackColor = false;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(515, 274);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 210);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Email :";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(486, 95);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(202, 20);
            this.txt_Email.TabIndex = 48;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(353, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Địa chỉ :";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(486, 131);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(202, 20);
            this.txt_DiaChi.TabIndex = 50;
            // 
            // LB_DS_P
            // 
            this.LB_DS_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LB_DS_P.Location = new System.Drawing.Point(245, 618);
            this.LB_DS_P.Name = "LB_DS_P";
            this.LB_DS_P.Size = new System.Drawing.Size(343, 23);
            this.LB_DS_P.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 618);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 24);
            this.label10.TabIndex = 52;
            this.label10.Text = "Danh sách phòng đặt :";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Location = new System.Drawing.Point(598, 607);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 43);
            this.btn_clear.TabIndex = 53;
            this.btn_clear.Text = "HỦY";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Red;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(12, 720);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(146, 38);
            this.btn_Thoat.TabIndex = 54;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // errorProvider_TenKH
            // 
            this.errorProvider_TenKH.ContainerControl = this;
            // 
            // errorProvider_SDT
            // 
            this.errorProvider_SDT.ContainerControl = this;
            // 
            // errorProvider_CCCD
            // 
            this.errorProvider_CCCD.ContainerControl = this;
            // 
            // Form_DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 769);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LB_DS_P);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.lblKH);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSLphong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTP_NTP);
            this.Controls.Add(this.DTP_NNP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.txt_SDT_KH);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.DTP_NgaySinh_KH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_DatPhong";
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.Form_DatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_TenKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_SDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_CCCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_Tang;
        private System.Windows.Forms.Label lblSLphong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DTP_NTP;
        private System.Windows.Forms.DateTimePicker DTP_NNP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.TextBox txt_SDT_KH;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.DateTimePicker DTP_NgaySinh_KH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label LB_DS_P;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ErrorProvider errorProvider_TenKH;
        private System.Windows.Forms.ErrorProvider errorProvider_SDT;
        private System.Windows.Forms.ErrorProvider errorProvider_CCCD;
    }
}