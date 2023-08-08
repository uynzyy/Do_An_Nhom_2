using Do_An_DAL.DATA;
using Do_An_Nhom_2.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Do_An_Nhom_2.NhanVien
{
    public partial class Form_DatPhong : Form
    {

        public Form_DatPhong()
        {
            InitializeComponent();
        }
        string MANV = "";

        string message, title;
        MessageBoxButtons buttons;
        DialogResult result;

        CSDL_QLKS con = new CSDL_QLKS();
        List<string> list_MP = new List<string>();
        int tong = 0;

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[\p{L}\p{N}._%+-]+@gmail\.com$");
        }
        private string Tao_MSKH()
        {
            string s = "1";
            try
            {
                if (con.KHACH_HANG.Any())
                {
                    var List = con.KHACH_HANG.Select(s1 => s1.MA_KH).ToList();
                    var list = new List<int>();
                    foreach (var a in List)
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
            return "KH" + "-" + s;
        }

        private string Tao_MaPDP()
        {
            string s = "1";
            try
            {
                if (con.PHIEU_DAT_PHONG.Any())
                {
                    var List = con.PHIEU_DAT_PHONG.Select(s1 => s1.SO_PHIEU_DAT_PHONG).ToList();
                    var list = new List<int>();
                    foreach (var a in List)
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
            return "PDP" + "-" + s;
        }

        private bool Kiem_Tra()
        {
            return (txt_HoTen.Text == "" ||
            txt_SDT_KH.Text == "" ||
            txt_CCCD.Text == "") ? true : false;
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kiem_Tra())
                {
                    if (txt_HoTen.Text == "")
                    {
                        errorProvider_TenKH.SetError(txt_HoTen, "Tên không để trống");
                        errorProvider_TenKH.SetIconPadding(txt_HoTen, 5);
                        errorProvider_TenKH.SetIconAlignment(txt_HoTen, ErrorIconAlignment.MiddleRight);
                    }

                    if (txt_SDT_KH.Text == "")
                    {
                        errorProvider_SDT.SetError(txt_SDT_KH, "Số điện thoại không để trống");
                        errorProvider_SDT.SetIconPadding(txt_SDT_KH, 5);
                        errorProvider_SDT.SetIconAlignment(txt_SDT_KH, ErrorIconAlignment.MiddleRight);
                    }
                    if (txt_SDT_KH.Text == "")
                    {
                        errorProvider_CCCD.SetError(txt_CCCD, "CCCD không để trống");
                        errorProvider_CCCD.SetIconPadding(txt_CCCD, 5);
                        errorProvider_CCCD.SetIconAlignment(txt_CCCD, ErrorIconAlignment.MiddleRight);
                    }
                }
                else if(!Kiem_Tra())
                {
                    if (LB_DS_P.Text != "")
                    {
                        bool b = false;
                        foreach (var a in list_MP)
                        {
                            PHONG update = con.PHONGs.FirstOrDefault(p => p.MA_PHONG == a);
                            if (update != null)
                            {
                                if (update.TRANG_THAI == true)
                                {
                                    b = true;
                                    MessageBox.Show("Phòng đã có người đặt!");
                                    return;
                                }
                            }
                        }


                        if (DateTime.Compare(DTP_NNP.Value.Date, DateTime.Today) <= 0)
                        {
                            message = "Ngày nhận phòng phải lớn hơn ngày hiện tại: " + DateTime.Today.ToShortDateString();
                            title = "Lỗi";
                            buttons = MessageBoxButtons.OK;
                            result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);
                            return;
                        }

                        else if (DateTime.Compare(DTP_NTP.Value.Date, DTP_NNP.Value.Date) <= 0)
                        {
                            message = "Ngày trả phòng phải lớn hơn ngày nhận phòng: " + DTP_NNP.Value.ToShortDateString();
                            title = "Lỗi";
                            buttons = MessageBoxButtons.OK;
                            result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);
                            return;
                        }
                        else if (b == false)
                        {
                            Form_ThanhToan frm_tt = new Form_ThanhToan();

                            int money = tong;
                            TimeSpan khoangThoiGian = DTP_NTP.Value.Date - DTP_NNP.Value.Date;
                            int soNgay = (int)khoangThoiGian.TotalDays;
                            int totalMoney = money * soNgay;
                            if (!CheckEmail(txt_Email.Text.Trim()) && txt_Email.Text !="")
                            {
                                errorProvider_CCCD.SetError(txt_Email, "Email không hợp lệ");
                                errorProvider_CCCD.SetIconPadding(txt_Email, 5);
                                errorProvider_CCCD.SetIconAlignment(txt_Email, ErrorIconAlignment.MiddleRight);
                                return;
                            }
                            else if(txt_SDT_KH.Text != "" && txt_SDT_KH.Text.Length < 10)
                            {
                                errorProvider_SDT.SetError(txt_SDT_KH, "Vui lòng nhập số điện thoại đủ 10 số");
                                errorProvider_SDT.SetIconPadding(txt_SDT_KH, 5);
                                errorProvider_SDT.SetIconAlignment(txt_SDT_KH, ErrorIconAlignment.MiddleRight);
                                return;
                            }
                            else if (txt_CCCD.Text != "" && txt_CCCD.Text.Length < 12)
                            {
                                errorProvider_CCCD.SetError(txt_CCCD, "Vui lòng nhập CCCD đủ 12 số");
                                errorProvider_CCCD.SetIconPadding(txt_CCCD, 5);
                                errorProvider_CCCD.SetIconAlignment(txt_CCCD, ErrorIconAlignment.MiddleRight);
                                return;
                            }
                            else
                            {
                                string M = totalMoney.ToString();
                                frm_tt.Data_Added(Tao_MSKH(), Tao_MaPDP(), txt_HoTen.Text, DTP_NgaySinh_KH.Text, txt_SDT_KH.Text, txt_CCCD.Text, txt_Email.Text, txt_DiaChi.Text, DTP_NNP.Text, DTP_NTP.Text, M, list_MP);
                                frm_tt.MaNV(MANV);
                                frm_tt.Visible = true;
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn phòng!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnChonPhong(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn.BackColor == Color.White)
            {
                if (!list_MP.Contains((cmb_Tang.SelectedIndex + 1).ToString() + btn.Name))
                {
                    list_MP.Add((cmb_Tang.SelectedIndex + 1).ToString() + btn.Name);
                    Cong(btn.Name);
                }
                btn.BackColor = Color.Blue;
            }

            else if (btn.BackColor == Color.Blue)
            {

                foreach (var a in list_MP)
                {
                    if (a == (cmb_Tang.SelectedIndex + 1).ToString() + btn.Name)
                    {
                        Tru(btn.Name);
                        list_MP.Remove(a);
                        break;
                    }
                }
                btn.BackColor = Color.White;
            }

            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Phòng đã được đặt!!!");
            }
            LB_DS_P.Text = string.Join(", ", list_MP);
        }

        private void Cong(string s)
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is System.Windows.Forms.Button btn)
                {
                    if((cmb_Tang.SelectedIndex + 1).ToString() + btn.Name == (cmb_Tang.SelectedIndex + 1).ToString() + s)
                    {
                        if (int.Parse(btn.Text)- (cmb_Tang.SelectedIndex + 1)*100 <= 3)
                            tong += 300000;
                        else if (int.Parse(btn.Text) - (cmb_Tang.SelectedIndex + 1) * 100 <= 7)
                            tong += 600000;
                        else if (int.Parse(btn.Text) - (cmb_Tang.SelectedIndex + 1) * 100 <= 10)
                            tong += 800000;
                    }
                }
            }
            if (list_MP != null)
                lblSLphong.Text = list_MP.Count().ToString();
            string tmp = FormatCurrency(tong);
            lblTien.Text = tmp.Replace(",00", "");
        }


        private void Tru(string s)
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is System.Windows.Forms.Button btn)
                {
                    if ((cmb_Tang.SelectedIndex + 1).ToString() + btn.Name == (cmb_Tang.SelectedIndex + 1).ToString() + s)
                    {
                        if (int.Parse(btn.Text) - (cmb_Tang.SelectedIndex + 1) * 100 <= 3)
                            tong -= 300000;
                        else if (int.Parse(btn.Text) - (cmb_Tang.SelectedIndex + 1) * 100 <= 7)
                            tong -= 600000;
                        else if (int.Parse(btn.Text) - (cmb_Tang.SelectedIndex + 1) * 100 <= 10)
                            tong -= 800000;
                    }
                }
            }
            if (list_MP != null)
                lblSLphong.Text = (list_MP.Count()-1).ToString();
            string tmp = FormatCurrency(tong);
            lblTien.Text = tmp.Replace(",00", "");
        }

        private void DATA()
        {
            try
            {
                for (int i = 0; i <= 1; i++)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
                        button1.Location = new System.Drawing.Point(60 + 70 * j, 100 + 50 * i);
                        button1.BackColor = System.Drawing.Color.White;
                        if ((i * 5 + j + 1) == 10)
                        {
                            button1.Name = (i * 5 + j + 1).ToString();
                            button1.Text = "1" +(i * 5 + j + 1).ToString();
                        }

                        else
                        {
                            button1.Name = "0" + (i * 5 + j + 1).ToString();
                            button1.Text = "10" + (i * 5 + j + 1).ToString();
                        }
                            
                        button1.Size = new System.Drawing.Size(70, 40);
                        button1.TabIndex = 0;
                        button1.UseVisualStyleBackColor = false;
                        button1.Click += new System.EventHandler(this.btnChonPhong);
                        this.groupBox1.Controls.Add(button1);
                    }
                }
                cmb_Tang.SelectedItem = "Tầng 1";
                int VT = cmb_Tang.SelectedIndex + 1;
                string vt = VT.ToString();
                var list = con.PHONGs.Where(a => a.MA_PHONG.ToString().Substring(0, 1) == vt && a.TRANG_THAI == true).ToList();
                
                foreach (var a in list)
                {
                    change_color_btn(a.MA_PHONG.ToString().Substring(2, 2).Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Form_DatPhong_Load(object sender, EventArgs e)
        {
            string tmp = FormatCurrency(0);
            lblTien.Text = tmp.Replace(",00", "");
            DATA();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in this.groupBox1.Controls)
                {
                    if (control is System.Windows.Forms.Button btn)
                    {
                        btn.Text = (cmb_Tang.SelectedIndex+1).ToString()+btn.Text.Substring(1,2);
                        if (btn.BackColor == Color.Yellow || btn.BackColor == Color.Blue)
                        {
                            btn.BackColor = Color.White;
                        }
                        foreach(var a in list_MP)
                        {
                            if((cmb_Tang.SelectedIndex + 1).ToString()+btn.Name == a)
                            {
                                btn.BackColor = Color.Blue;
                                break;
                            }
                        }
                    }
                }
                int VT = cmb_Tang.SelectedIndex + 1;
                string vt = VT.ToString();
                var list = con.PHONGs.ToList().Where(a => a.MA_PHONG.ToString().Substring(0, 1) == vt && a.TRANG_THAI == true).ToList();
                foreach (var a in list)
                    change_color_btn(a.MA_PHONG.ToString().Substring(1, 2).Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void change_color_btn(string s)
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is System.Windows.Forms.Button btn)
                {
                    if (btn.Name.ToString() == s)
                    {
                        if (btn.BackColor == Color.White)
                        {
                            btn.BackColor = Color.Yellow;
                            break;
                        }
                    }
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            LB_DS_P.Text = "";
            foreach(var a in list_MP)
            {
                foreach (Control control in this.groupBox1.Controls)
                {
                    if (control is System.Windows.Forms.Button btn)
                    {
                        if (btn.BackColor == Color.Yellow && btn.Name==a.Substring(1,2)|| btn.BackColor == Color.Blue && btn.Name == a.Substring(1, 2))
                        {
                            btn.BackColor = Color.White;
                        }
                    }
                }
            }
            list_MP.Clear();
            tong = 0;
            string tmp = FormatCurrency(0);
            lblTien.Text = tmp.Replace(",00", "");
            lblSLphong.Text = "0";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            message = "Bạn có chắc muốn thoát? Toàn bộ dữ liệu sẽ bị mất!! ";
            title = "Cảnh báo";
            buttons = MessageBoxButtons.YesNo;
            result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (MANV != "")
                {
                    Form_CongViec frm = new Form_CongViec();
                    frm.MaNV(MANV);
                    frm.Visible = true;
                    this.Close();
                }
                else
                {
                    Form_TrangChu frm = new Form_TrangChu();
                    frm.Visible = true;
                    this.Close();
                }
            }      
        }

        private void txt_SDT_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar)) ||
        (txt_SDT_KH.TextLength == 10 && txt_SDT_KH.SelectedText.Length == 0))
            {
                e.Handled = true;
            }
        }

        private void txt_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar)) ||
        (txt_CCCD.TextLength == 12 && txt_CCCD.SelectedText.Length == 0))
            {
                e.Handled = true;
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            errorProvider_TenKH.Clear();
            errorProvider_SDT.Clear();
            errorProvider_CCCD.Clear();
        }
        public void MaNV(string s)
        {
            MANV = s;
        }

        public void Get_Data(string c, string d, string e, string f, string g, string h, string i, string j, string k, List<String> a1)
        {
            txt_HoTen.Text = c;
            DTP_NgaySinh_KH.Text = d;
            txt_SDT_KH.Text = e;
            txt_CCCD.Text = f;
            txt_Email.Text = g;
            txt_DiaChi.Text = h;
            DTP_NNP.Text = i;
            DTP_NTP.Text = j;

            TimeSpan khoangThoiGian = DTP_NTP.Value.Date - DTP_NNP.Value.Date;
            int soNgay = (int)khoangThoiGian.TotalDays;
            lblTien.Text = FormatCurrency(int.Parse(k) / soNgay);
            list_MP= a1;
            LB_DS_P.Text = string.Join(", ", list_MP);
            lblSLphong.Text = list_MP.Count().ToString();
            tong= (int.Parse(k) / soNgay);
            Show_Room();
        }

        private void Show_Room()
        {
            foreach (var a in list_MP)
            {
                foreach (Control control in this.groupBox1.Controls)
                {
                    if (control is System.Windows.Forms.Button btn)
                    {
                        if (btn.BackColor == Color.White && btn.Name == a.Substring(1, 2))
                        {
                            btn.BackColor = Color.Blue;
                        }
                    }
                }
            }
        }

        public string FormatCurrency(double amount)
        {
            // Định dạng tiền tệ theo định dạng Việt Nam (đơn vị VNĐ)
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            string money_VN = string.Format(cultureInfo, "{0:C}", amount);

            return money_VN;
        }
    }
}
