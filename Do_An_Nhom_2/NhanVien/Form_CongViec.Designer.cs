namespace Do_An_Nhom_2.NhanVien
{
    partial class Form_CongViec
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
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.btn_TraPhong = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(89, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỨC NĂNG";
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.Location = new System.Drawing.Point(138, 189);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(106, 38);
            this.btn_DatPhong.TabIndex = 1;
            this.btn_DatPhong.Text = "Đặt Phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = true;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // btn_TraPhong
            // 
            this.btn_TraPhong.Location = new System.Drawing.Point(266, 189);
            this.btn_TraPhong.Name = "btn_TraPhong";
            this.btn_TraPhong.Size = new System.Drawing.Size(106, 38);
            this.btn_TraPhong.TabIndex = 2;
            this.btn_TraPhong.Text = "Tính Hóa Đơn";
            this.btn_TraPhong.UseVisualStyleBackColor = true;
            this.btn_TraPhong.Click += new System.EventHandler(this.btn_TraPhong_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(10, 189);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(106, 38);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Form_CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 268);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TraPhong);
            this.Controls.Add(this.btn_DatPhong);
            this.Controls.Add(this.label1);
            this.Name = "Form_CongViec";
            this.Text = "Công Việc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DatPhong;
        private System.Windows.Forms.Button btn_TraPhong;
        private System.Windows.Forms.Button btn_Thoat;
    }
}