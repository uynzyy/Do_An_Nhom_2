using Do_An_DAL.DATA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Do_An_Nhom_2.NhanVien
{
    public partial class Form_HoaDon : Form
    {
        public Form_HoaDon()
        {
            InitializeComponent();
        }

        Dictionary<string, bool> checkBoxStates = new Dictionary<string, bool>();
        CSDL_QLKS con = new CSDL_QLKS();
        /**********************************************************************************************************/
        decimal money = 0;
        decimal a = 0, b = 0;
        string Ma_PDP, manv;

        string message, title;
        MessageBoxButtons buttons;
        DialogResult result;
        /**********************************************************************************************************/
        private string Tao_MaHD()
        {
            string s = "1";
            try
            {
                if (con.HOADONs.Any())
                {
                    var soHDList = con.HOADONs.Select(s1 => s1.SOHD).ToList();
                    var list = new List<int>();
                    foreach (var a in soHDList)
                    {
                        list.Add(int.Parse((a.Substring(a.IndexOf('-') + 1).Trim())));
                    }
                    list.Sort();

                    int n = list.Last() + 1;
                    s = n.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "HD" + "-" + s;
        }

        private void DATA()
        {
            try
            {
                int i = 0;
                var tn = con.TIEN_NGHI.Select(s => s).ToList();
                foreach (var t in tn)
                {
                    System.Windows.Forms.CheckBox cb = new System.Windows.Forms.CheckBox();
                    cb.Location = new System.Drawing.Point(6, 32 + i);
                    cb.Name = t.MA_TN;
                    cb.Size = new System.Drawing.Size(80, 17);
                    cb.TabIndex = 0;
                    cb.Text = t.TEN_TN;
                    cb.Click += new System.EventHandler(this.btnChon);
                    cb.UseVisualStyleBackColor = false;
                    this.groupBox1.Controls.Add(cb);
                    i += 20;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChon(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is System.Windows.Forms.CheckBox cb)
                {
                    // Kiểm tra xem CheckBox đã được ấn trước đó hay chưa
                    bool isChecked = checkBoxStates.ContainsKey(cb.Name) ? checkBoxStates[cb.Name] : false;

                    if (cb.Checked && !isChecked)
                    {
                        var A = con.TIEN_NGHI.FirstOrDefault(s => s.MA_TN == cb.Name);
                        if (A?.GiaTien != null)
                        {
                            money += decimal.Parse(A.GiaTien.ToString());
                        }

                        // Đánh dấu CheckBox là đã được ấn
                        checkBoxStates[cb.Name] = true;
                    }
                    else if (!cb.Checked && isChecked)
                    {
                        var A = con.TIEN_NGHI.FirstOrDefault(s => s.MA_TN == cb.Name);
                        if (A?.GiaTien != null)
                        {
                            money -= decimal.Parse(A.GiaTien.ToString());
                        }

                        // Đánh dấu CheckBox là chưa được ấn
                        checkBoxStates[cb.Name] = false;
                    }
                }
            }
            All_Data();
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            DATA();
            DATA_FOR_CMB_MP();
        }


        private void Reset_CB()
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is System.Windows.Forms.CheckBox cb)
                {
                    if (cb.Checked)
                    {
                        cb.Checked = false;
                    }
                }
            }
            checkBoxStates = new Dictionary<string, bool>();
        }
        private void DATA_FOR_CMB_MP()
        {
            try
            {
                List<PHONG> a = con.PHONGs.Where(s => s.TRANG_THAI == true).ToList();
                cmb_MaPhong.DataSource = a;
                cmb_MaPhong.DisplayMember = "MA_PHONG";
                cmb_MaPhong.ValueMember = "MA_PHONG";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_MaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            money = 0;
            con = new CSDL_QLKS();
            All_Data();
            Reset_CB();
        }

        public string FormatCurrency(decimal amount)
        {
            // Định dạng tiền tệ theo định dạng Việt Nam (đơn vị VNĐ)
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            string money_VN = string.Format(cultureInfo, "{0:C}", amount);

            return money_VN;
        }

        public void All_Data()
        {

            try
            {
                var pdp = con.CHI_TIET_PHIEU_DAT_PHONG.Where(s => s.MA_PHONG == cmb_MaPhong.Text).ToList();
                var list = new List<int>();
                foreach (var a in pdp)
                {
                    list.Add(int.Parse(a.SO_PHIEU_DAT_PHONG.Substring(a.SO_PHIEU_DAT_PHONG.IndexOf('-') + 1)));
                }
                if (list.Any())
                {
                    list.Sort();
                    string s1 = "PDP-" + list.Last().ToString();
                    Ma_PDP = s1;

                    var phieuDatPhong = con.PHIEU_DAT_PHONG.FirstOrDefault(s => s.SO_PHIEU_DAT_PHONG == Ma_PDP);
                    var KH_name = con.KHACH_HANG.FirstOrDefault(s => s.MA_KH == phieuDatPhong.MA_KH).TEN_KH;
                    LB_TenKH.Text = KH_name;

                    LB_NgayTP.Text = DateTime.Today.ToShortDateString();

                    var A = con.PHIEU_DAT_PHONG.FirstOrDefault(s => s.SO_PHIEU_DAT_PHONG == Ma_PDP);
                    if (A?.TONGTIEN != null)
                    {
                        a = decimal.Parse(A.TONGTIEN.ToString());
                    }

                    var B = con.PHIEU_DAT_PHONG.FirstOrDefault(s => s.SO_PHIEU_DAT_PHONG == Ma_PDP);
                    if (B?.DATCOC != null)
                    {
                        b = decimal.Parse(B.DATCOC.ToString());
                    }

                    var C = con.CHI_TIET_PHIEU_DAT_PHONG.FirstOrDefault(s => s.SO_PHIEU_DAT_PHONG == Ma_PDP && s.MA_PHONG == cmb_MaPhong.Text)?.NGAY_TRA;

                    if (C.HasValue)
                    {
                        LB_NgayTraPhongDuTinh.Text = C.Value.ToShortDateString();
                        TimeSpan khoangThoiGian = C.Value - DateTime.Today;

                        int total_H = khoangThoiGian.Days * 24 + khoangThoiGian.Hours + khoangThoiGian.Minutes / 60;
                        if (total_H < 0)
                        {
                            money += Math.Abs(total_H * 100000);
                            LB_NgayTraPhongDuTinh.BackColor = Color.Red;
                        }
                        else
                        {
                            LB_NgayTraPhongDuTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                        }
                    }
                    string tmp = (FormatCurrency(a - b + money));
                    LB_TongTien.Text = tmp.Replace(",00", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            Form_CongViec frm = new Form_CongViec();
            frm.MaNV(manv);
            frm.Visible = true;
            this.Visible = false;
        }

        public void MaNV(string s)
        {
            manv = s;
        }
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_MaPhong.Items.Count > 0)
                {
                    CSDL_QLKS con = new CSDL_QLKS();

                    var update = con.PHIEU_DAT_PHONG
                                   .OrderByDescending(s => s.SO_PHIEU_DAT_PHONG)
                                   .FirstOrDefault(s => s.SO_PHIEU_DAT_PHONG == Ma_PDP);

                    if (a - b != decimal.Zero)
                    {
                        if (update != null)
                        {
                            update.DATCOC = a;
                            con.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin khách hàng!");
                        }
                    }

                    var UD = con.PHONGs.Where(s => s.MA_PHONG == cmb_MaPhong.Text).FirstOrDefault();
                    if (UD != null)
                    {
                        UD.TRANG_THAI = false;
                        con.SaveChanges();

                        HOADON hd = new HOADON()
                        {
                            SOHD = Tao_MaHD(),
                            MA_NV = manv,
                            NGAYLAP = DateTime.Today,
                            TONGTIEN = decimal.Parse(LB_TongTien.Text.Substring(0, LB_TongTien.Text.IndexOf(' ')).Replace(".", "").Trim()),
                            SO_PHIEU_DAT_PHONG = Ma_PDP,
                            MA_PHONG = cmb_MaPhong.Text
                        };
                        con.HOADONs.Add(hd);
                        con.SaveChanges();

                        message = "Tính hóa đơn thành công!!";
                        title = "Thông báo";
                        buttons = MessageBoxButtons.OK;
                        result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);

                        if (cmb_MaPhong.Items.Count > 0)
                        {
                            DATA_FOR_CMB_MP();
                            Reset_CB();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phòng hiện không có ai đặt");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
