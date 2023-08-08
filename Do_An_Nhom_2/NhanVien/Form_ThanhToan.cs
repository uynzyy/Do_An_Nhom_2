using Do_An_DAL.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Policy;

namespace Do_An_Nhom_2.NhanVien
{
    public partial class Form_ThanhToan : Form
    {
        string MANV="";
        public Form_ThanhToan()
        {
            InitializeComponent();
        }
        public string MaKH;
        public string MaPDP;
        public string HoTen;

        public string NgaySinh;
        public string SDT;
        public string CCCD;
        public string Email;
        public string DiaChi;
        public string Ngay_DP;
        public string Ngay_TP;
        public string TongTien;


        public List<string> SL_Phong;
        
        CSDL_QLKS con = new CSDL_QLKS();

        string message, title;
        MessageBoxButtons buttons;
        DialogResult result;
        public string FormatCurrency(double amount)
        {
            // Định dạng tiền tệ theo định dạng Việt Nam (đơn vị VNĐ)
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            string money_VN = string.Format(cultureInfo, "{0:C}", amount);

            return money_VN;
        }

        private void btnDTT_Click(object sender, EventArgs e)
        {
           try
           {
                string money = txt_Datcoc.Text.Substring(0, txt_Datcoc.Text.IndexOf(' ')).Replace(".", "").Trim();
                
                if (int.Parse(money) <= int.Parse(TongTien) * 50 / 100)
                {
                    MessageBox.Show("Vui lòng đặt cọc lớn hơn hoặc bằng 50%");
                    return;
                }
                else
                {
                    if (!con.KHACH_HANG.Any(s => s.CCCD == CCCD))
                    {
                        KHACH_HANG kh = new KHACH_HANG()
                        {
                            MA_KH = MaKH,
                            TEN_KH = HoTen,
                            NGAYSINH = DateTime.Parse(NgaySinh),
                            CCCD = CCCD,
                            SDT = SDT,
                            EMAIL = Email,
                            DIACHI = DiaChi
                        };
                        con.KHACH_HANG.Add(kh);
                        con.SaveChanges();
                    }
                    
                    if (int.Parse(money) > int.Parse(TongTien))
                    {
                        string tmp = FormatCurrency(int.Parse(money) - int.Parse(TongTien));
                        message = tmp.Substring(0, tmp.IndexOf(",")) + tmp.Substring(tmp.LastIndexOf('0') + 1);
                        title = "Trả Lại";
                        buttons = MessageBoxButtons.OK;
                        result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);
                        money = TongTien;
                    }

                    PHIEU_DAT_PHONG pdp = new PHIEU_DAT_PHONG()
                    {
                        SO_PHIEU_DAT_PHONG = MaPDP,
                        MA_KH = con.KHACH_HANG.FirstOrDefault(s1 => s1.CCCD == CCCD).MA_KH.ToString(),
                        NGAYLAP = DateTime.Today,
                        TONGTIEN = int.Parse(TongTien),
                        DATCOC = int.Parse(money)
                    };

                    con.PHIEU_DAT_PHONG.Add(pdp);
                    con.SaveChanges();

                    foreach (var a in SL_Phong)
                    {
                        CHI_TIET_PHIEU_DAT_PHONG ctpdp = new CHI_TIET_PHIEU_DAT_PHONG()
                        {
                            SO_PHIEU_DAT_PHONG = MaPDP,
                            MA_PHONG = a,
                            NGAY_DAT = DateTime.Parse(Ngay_DP),
                            NGAY_TRA = DateTime.Parse(Ngay_TP)
                        };
                        con.CHI_TIET_PHIEU_DAT_PHONG.Add(ctpdp);
                        con.SaveChanges();
                    }

                    foreach (var a in SL_Phong)
                    {
                        PHONG update = con.PHONGs.FirstOrDefault(p => p.MA_PHONG == a);
                        if (update != null)
                        {
                            update.TRANG_THAI = true;
                        }
                        con.SaveChanges();
                    }
                    MessageBox.Show("Đặt phòng thành công!");
                    Form_DatPhong frm = new Form_DatPhong();
                    if(MANV!="")
                        frm.MaNV(MANV);
                    frm.Visible = true;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);            
            }
            
        }


        public void Data_Added(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, List<String> a1)
        {
            MaKH = a;
            MaPDP=b;
            HoTen=c;
            NgaySinh=d;
            SDT=e;
            CCCD=f;
            Email=g;
            DiaChi=h;
            Ngay_DP=i + " " + "14:00:00";
            Ngay_TP=j + " " + "12:00:00";
            TongTien=k;
            SL_Phong = a1;
        }

        private void Form_ThanhToan_Load(object sender, EventArgs e)
        {
            LB_SoPDP.Text = MaPDP;

            LB_HoTen.Text = HoTen;
            LB_SDT.Text = SDT;
            DTP_ND.Value = DateTime.Parse(Ngay_DP);
            DTP_NT.Value = DateTime.Parse(Ngay_TP);
            LB_MaPhong.Text = string.Join(", ", SL_Phong);

            string tmp = FormatCurrency(float.Parse(TongTien));
            LB_TongTien.Text = tmp.Replace(",00", "");
        }

        private void txt_Datcoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int selectionStart = txt_Datcoc.SelectionStart;
                int selectionLength = txt_Datcoc.SelectionLength;

                if (double.TryParse(txt_Datcoc.Text, out double result))
                {
                    string tmp = FormatCurrency(double.Parse(txt_Datcoc.Text));
                    txt_Datcoc.Text = tmp.Replace(",00", "");
                }
                    
                else
                {
                    string tmp = txt_Datcoc.Text;
                    tmp = tmp.Substring(0, tmp.LastIndexOf(' ')+1).Replace(".", "").Trim();

                    string tmp1 = FormatCurrency(double.Parse(tmp));
                    txt_Datcoc.Text = tmp1.Replace(",00", "");
                }
                // Khôi phục vị trí con trỏ chuột sau khi thay đổi nội dung
                txt_Datcoc.SelectionStart = selectionStart;
                txt_Datcoc.SelectionLength = selectionLength;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Form_DatPhong frm = new Form_DatPhong();
            frm.Visible = true;
            frm.Get_Data(HoTen, NgaySinh, SDT, CCCD, Email, DiaChi, Ngay_DP, Ngay_TP, TongTien, SL_Phong);
            this.Close();
        }

        public void MaNV(string s)
        {
            MANV = s;
        }
    }
}
