using Do_An_DAL.DATA;
using Do_An_Nhom_2.TrangChu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Messaging;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Do_An_Nhom_2
{
    public partial class Form_QuanLy : Form
    {
        public Form_QuanLy()
        {
            InitializeComponent();
        }
        /*---------------------------------------------------Others------------------------------------------------------------------*/
        public string FormatCurrency(int? amount)
        {
            // Định dạng tiền tệ theo định dạng Việt Nam (đơn vị VNĐ)
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            string money_VN = string.Format(cultureInfo, "{0:C}", amount);

            return money_VN;
        }

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[\p{L}\p{N}._%+-]+@gmail\.com$");
        }
        /*-------------------------------------------------TAB CONTROL------------------------------------------------------------*/
        private void Form_QuanLy_Load(object sender, EventArgs e)
        {
            DATA_FOR_CMB_CV();
            Data_Tab1();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl1.SelectedTab;

            // Thực hiện các hành động dựa trên tab hiện tại
            if (selectedTab == QLNV)
            {
                DATA_FOR_CMB_CV();
                Data_Tab1();
            }
            else if (selectedTab == LichNhanVien)
            {
                DATA_FOR_CMB_MaNV();
                Data_Tab2();
            }
            else if (selectedTab == TKDT)
            {
                DATA_FOR_CMB_NAM_TAB_4();
                Data_Tab4();
            }
            else
                Data_Tab3();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn thoát không";
            string title = "Thoát";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form_TrangChu frm = new Form_TrangChu();
                frm.Visible = true;
                this.Close();
            }
                
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void lịchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void quảnLýPhòngĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }
        /*-------------------------------------------------TAB 1------------------------------------------------------------*/

        private void reset_textbox()
        {
            txt_TenNV.ResetText();
            DateTime_NgaySinh.ResetText();
            rdo_btn_Nam.Checked = false;
            rdo_btn_Nu.Checked = false;
            txt_CCCD.ResetText();
            txt_SDT.ResetText();
            txt_Email.ResetText();
            txt_Diachi.ResetText();
        }

        private void DATA_FOR_CMB_CV()
        {
            List<CHUC_VU> a = new CSDL_QLKS().CHUC_VU.Where(x => x.MA_CV!= "NVQL").ToList();
            cmb_ChucVu.DataSource = a;
            cmb_ChucVu.DisplayMember = "TEN_CV";
            cmb_ChucVu.ValueMember = "MA_CV";
            cmb_ChucVu_NV.SelectedIndex = 0;
        }

        private void txt_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar)) ||
        (txt_CCCD.TextLength == 12 && txt_CCCD.SelectedText.Length == 0))
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar)) ||
        (txt_SDT.TextLength == 10 && txt_SDT.SelectedText.Length == 0))
            {
                e.Handled = true;
            }
        }

        private void Data_Chart_Tab1(string s)
        {
            bool elementExists = false;
            foreach (DataPoint point in Bieu_Do_Chuc_Vu_NV.Series["Nhân viên"].Points)
            {
                if (point.AxisLabel == s)
                {
                    elementExists = true;
                    point.YValues[0]++;
                    break;
                }
            }
            // Nếu phần tử chưa tồn tại, thêm mới vào chuỗi dữ liệu
            if (!elementExists)
            {
                Bieu_Do_Chuc_Vu_NV.Series["Nhân viên"].Points.AddXY(s, 1);
            }
        }

        private void Data_Tab1()
        {
            try
            {
                //DataGridView và chart
                foreach (Series series in Bieu_Do_Chuc_Vu_NV.Series)
                {
                    series.Points.Clear();
                }
                Data_NhanVien.Rows.Clear();
                var nv = new CSDL_QLKS();
                
                var nhanvien_list = nv.NHAN_VIEN.Where(a => a.MA_NV != "BOSS").ToList(); 
                foreach (var d in nhanvien_list)
                {
                    string d1 = (d.GIOITINH.ToString() == "True") ? (d1 = "Nam") : (d1 = "Nữ");
                    string money = FormatCurrency(nv.CHUC_VU.FirstOrDefault(s => s.MA_CV == d.MA_CV)?.LCB);
                    Data_NhanVien.Rows.Add(Data_NhanVien.RowCount.ToString(), d.MA_NV,
                                                                                 d.TEN_NV,
                                                                                 d.NGAYSINH.ToString().Substring(0, d.NGAYSINH.ToString().IndexOf(' ')),
                                                                                 d1,
                                                                                 d.CCCD,
                                                                                 d.SDT,
                                                                                 d.EMAIL,
                                                                                 d.DIACHI,
                                                                                 nv.CHUC_VU.FirstOrDefault(s => s.MA_CV == d.MA_CV)?.TEN_CV,
                                                                                 (money.Replace(",00", "")).Trim());

                    Data_Chart_Tab1(nv.CHUC_VU.FirstOrDefault(s => s.MA_CV == d.MA_CV)?.TEN_CV);
                }
                var s1 = "";
                //
                var nhanvien_list1 = nv.CHUC_VU.Where(a => a.MA_CV != "NVQL").Select(s => s).ToList();
                //
                foreach (var d in nhanvien_list1)
                {
                    bool elementExists = false;
                    foreach (DataPoint point in Bieu_Do_Chuc_Vu_NV.Series["Nhân viên"].Points)
                    {
                        if (point.AxisLabel == d.TEN_CV.ToString())
                        {
                            elementExists = true;
                            break;
                        }
                    }
                    // Nếu phần tử chưa tồn tại, thêm mới vào chuỗi dữ liệu
                    if (!elementExists)
                    {
                        Bieu_Do_Chuc_Vu_NV.Series["Nhân viên"].Points.AddXY(d.TEN_CV.ToString(), 0);
                        s1 += d.TEN_CV.ToString() + ", ";
                        s1.Trim();
                    }
                }
                if (s1 != "")
                {
                    s1 = s1.Substring(0, s1.Length - 2).ToLower();
                    lb_De_Xuat_NV.Text = "  - Hiện khách sạn đang thiếu những nhân viên sau đây: " + s1 + ". \n\n    - Đề xuất tuyển thêm những nhân viên vào các chức vụ còn trống.";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Data_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Data_NhanVien.Rows.Count > 0 && e.RowIndex < (Data_NhanVien.RowCount -1) && e.RowIndex > -1)
                {
                    string msnv = Data_NhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CSDL_QLKS con = new CSDL_QLKS();
                    NHAN_VIEN nv = con.NHAN_VIEN.FirstOrDefault(p => p.MA_NV == msnv);
                    if(nv != null)
                    {
                        txt_TenNV.Text = nv.TEN_NV;
                        DateTime_NgaySinh.Text = nv.NGAYSINH.ToString();
                        if (nv.GIOITINH==true)
                        {
                            rdo_btn_Nam.Checked = true;
                        }
                        else
                        {
                            rdo_btn_Nu.Checked = true;
                        }
                        txt_CCCD.Text = nv.CCCD;
                        txt_SDT.Text = nv.SDT;
                        txt_Email.Text = nv.EMAIL;
                        txt_Diachi.Text = nv.DIACHI;
                        cmb_ChucVu.SelectedValue = nv.MA_CV;
                    }
                }
                else
                {
                    reset_textbox();
                    cmb_ChucVu.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string Tao_MSNV()
        {
            string s = "1";
            try
            {
                CSDL_QLKS con = new CSDL_QLKS();
                if (con.NHAN_VIEN.Any())
                {
                    var manv_last = con.NHAN_VIEN.Where(s1 => s1.MA_NV != "BOSS").Select(s1 => s1.MA_NV).ToList();

                    var list = new List<int>();
                    foreach (var a in manv_last)
                    {
                        list.Add(int.Parse(a.Substring(a.IndexOf('-') + 1)));
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
            return "NV" + "-" + s;
        }

        private bool Kiem_Tra()
        {
            return (txt_TenNV.Text ==""||
            (!rdo_btn_Nam.Checked && !rdo_btn_Nu.Checked) ||
            txt_CCCD.Text == "" ||
            txt_SDT.Text == ""  ||
            cmb_ChucVu.Text =="")?true:false;
        }
        private void btn_Them_NV_Click(object sender, EventArgs e)
        {
            if (Kiem_Tra())
            {
                if (txt_TenNV.Text == "")
                {
                    error_TenNV.SetError(txt_TenNV, "Tên không để trống");
                    error_TenNV.SetIconPadding(txt_TenNV, 5);
                    error_TenNV.SetIconAlignment(txt_TenNV, ErrorIconAlignment.MiddleRight);
                }
                if ((!rdo_btn_Nam.Checked && !rdo_btn_Nu.Checked))
                {
                    error_GioiTinh.SetError(rdo_btn_Nu, "Giới tính không để trống");
                    error_GioiTinh.SetIconPadding(rdo_btn_Nu, 5);
                    error_GioiTinh.SetIconAlignment(rdo_btn_Nu, ErrorIconAlignment.MiddleRight);
                }
                if (txt_CCCD.Text == "")
                {
                    error_CCCD.SetError(txt_CCCD, "Số CCCD không để trống");
                    error_CCCD.SetIconPadding(txt_CCCD, 5);
                    error_CCCD.SetIconAlignment(txt_CCCD, ErrorIconAlignment.MiddleRight);
                }
                if (txt_SDT.Text == "")
                {
                    error_SDT.SetError(txt_SDT, "Số điện thoại không để trống");
                    error_SDT.SetIconPadding(txt_SDT, 5);
                    error_SDT.SetIconAlignment(txt_SDT, ErrorIconAlignment.MiddleRight);
                }
                if (cmb_ChucVu.Text == "")
                {
                    error_ChucVu.SetError(cmb_ChucVu, "Chức vụ không để trống");
                    error_ChucVu.SetIconPadding(cmb_ChucVu, 5);
                    error_ChucVu.SetIconAlignment(cmb_ChucVu, ErrorIconAlignment.MiddleRight);
                }
                return;
            }
            else if (txt_Email.Text !="" && !CheckEmail(txt_Email.Text.Trim()))
            {
                error_ChucVu.SetError(txt_Email, "Sai định dạng Email");
                error_ChucVu.SetIconPadding(txt_Email, 5);
                error_ChucVu.SetIconAlignment(txt_Email, ErrorIconAlignment.MiddleRight);
                return;
            }

            else if (txt_CCCD.Text != "" && txt_CCCD.Text.Length<12)
            {
                error_CCCD.SetError(txt_CCCD, "Vui lòng nhập số CCCD đủ 12 số");
                error_CCCD.SetIconPadding(txt_CCCD, 5);
                error_CCCD.SetIconAlignment(txt_CCCD, ErrorIconAlignment.MiddleRight);
                return;
            }

            else if (txt_SDT.Text != "" && txt_SDT.Text.Length < 10)
            {
                error_SDT.SetError(txt_SDT, "Vui lòng nhập số điện thoại đủ 10 số");
                error_SDT.SetIconPadding(txt_SDT, 5);
                error_SDT.SetIconAlignment(txt_SDT, ErrorIconAlignment.MiddleRight);
                return;
            }

            else if (!Kiem_Tra())
            {
                try
                {
                    CSDL_QLKS con = new CSDL_QLKS();
                    if (!con.NHAN_VIEN.Any(x => x.CCCD == txt_CCCD.Text))
                    {
                        string tmp = ((cmb_ChucVu.SelectedItem as CHUC_VU).MA_CV.ToString()).Trim();
                        bool gioitinh = (rdo_btn_Nam.Checked)?true:false;
                        NHAN_VIEN nv = new NHAN_VIEN()
                        {
                            MA_NV = Tao_MSNV(),
                            TEN_NV = txt_TenNV.Text,
                            NGAYSINH = DateTime.Parse(DateTime_NgaySinh.Text),
                            GIOITINH = gioitinh,
                            CCCD = txt_CCCD.Text,
                            SDT = txt_SDT.Text,
                            EMAIL = txt_Email.Text,
                            DIACHI = txt_Diachi.Text,
                            MA_CV = tmp
                        };
                        //
                        con.NHAN_VIEN.Add(nv);
                        MessageBox.Show("Thêm thành công!");
                        con.SaveChanges();
                        Data_Tab1();
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên đã tồn tại!");
                    }
                    reset_textbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnt_CapNhat_NV_Click(object sender, EventArgs e)
        {
            try
            {
                CSDL_QLKS con = new CSDL_QLKS();
                NHAN_VIEN update = con.NHAN_VIEN.FirstOrDefault(p => p.CCCD == txt_CCCD.Text);
                if (update != null)
                {
                    if (Kiem_Tra())
                    {
                        if (txt_TenNV.Text == "")
                        {
                            error_TenNV.SetError(txt_TenNV, "Tên không để trống");
                            error_TenNV.SetIconPadding(txt_TenNV, 5);
                            error_TenNV.SetIconAlignment(txt_TenNV, ErrorIconAlignment.MiddleRight);
                        }
                        if ((!rdo_btn_Nam.Checked && !rdo_btn_Nu.Checked))
                        {
                            error_GioiTinh.SetError(rdo_btn_Nu, "Giới tính không để trống");
                            error_GioiTinh.SetIconPadding(rdo_btn_Nu, 5);
                            error_GioiTinh.SetIconAlignment(rdo_btn_Nu, ErrorIconAlignment.MiddleRight);
                        }
                        if (txt_CCCD.Text == "")
                        {
                            error_CCCD.SetError(txt_CCCD, "Số CCCD không để trống");
                            error_CCCD.SetIconPadding(txt_CCCD, 5);
                            error_CCCD.SetIconAlignment(txt_CCCD, ErrorIconAlignment.MiddleRight);
                        }
                        if (txt_SDT.Text == "")
                        {
                            error_SDT.SetError(txt_SDT, "Số điện thoại không để trống");
                            error_SDT.SetIconPadding(txt_SDT, 5);
                            error_SDT.SetIconAlignment(txt_SDT, ErrorIconAlignment.MiddleRight);
                        }
                        if (cmb_ChucVu.Text == "")
                        {
                            error_ChucVu.SetError(cmb_ChucVu, "Chức vụ không để trống");
                            error_ChucVu.SetIconPadding(cmb_ChucVu, 5);
                            error_ChucVu.SetIconAlignment(cmb_ChucVu, ErrorIconAlignment.MiddleRight);
                        }
                        return;
                    }
                    else if (txt_Email.Text != "" && !CheckEmail(txt_Email.Text.Trim()))
                    {
                        error_ChucVu.SetError(txt_Email, "Sai định dạng Email");
                        error_ChucVu.SetIconPadding(txt_Email, 5);
                        error_ChucVu.SetIconAlignment(txt_Email, ErrorIconAlignment.MiddleRight);
                        return;
                    }

                    else if (txt_CCCD.Text != "" && txt_CCCD.Text.Length < 12)
                    {
                        error_CCCD.SetError(txt_CCCD, "Vui lòng nhập số CCCD đủ 12 số");
                        error_CCCD.SetIconPadding(txt_CCCD, 5);
                        error_CCCD.SetIconAlignment(txt_CCCD, ErrorIconAlignment.MiddleRight);
                        return;
                    }

                    else if (txt_SDT.Text != "" && txt_SDT.Text.Length < 10)
                    {
                        error_SDT.SetError(txt_SDT, "Vui lòng nhập số điện thoại đủ 10 số");
                        error_SDT.SetIconPadding(txt_SDT, 5);
                        error_SDT.SetIconAlignment(txt_SDT, ErrorIconAlignment.MiddleRight);
                        return;
                    }

                    else if (!Kiem_Tra())
                    {
                        update.TEN_NV = txt_TenNV.Text;
                        bool gioitinh = (rdo_btn_Nam.Checked) ? true : false;
                        update.GIOITINH = gioitinh;
                        update.SDT = txt_SDT.Text;
                        update.DIACHI = txt_Diachi.Text;
                        string tmp = ((cmb_ChucVu.SelectedItem as CHUC_VU).MA_CV.ToString()).Trim();
                        update.MA_CV = tmp;
                        update.EMAIL = txt_Email.Text;
                        //
                        MessageBox.Show("Cập nhật thành công!");
                        con.SaveChanges();
                        Data_Tab1();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên!");
                }
                reset_textbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_NV_Click(object sender, EventArgs e)
        {
            string message, title;
            MessageBoxButtons buttons;
            DialogResult result;
            try
            {
                CSDL_QLKS con = new CSDL_QLKS();
                NHAN_VIEN update = con.NHAN_VIEN.FirstOrDefault(p => p.CCCD == txt_CCCD.Text);

                if (update != null)
                {
                    if (con.HOADONs.Any(p=>p.MA_NV.ToString()==update.MA_NV))
                    {
                        message = "Nhân viên này hiện đang làm việc";
                        title = "Lỗi";
                        buttons = MessageBoxButtons.OK;
                        result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        message = "Bạn có muốn xóa nhân viên này không";
                        title = "Cảnh báo";
                        buttons = MessageBoxButtons.YesNo;
                        result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            con.NHAN_VIEN.Remove(update);
                            con.SaveChanges();
                            Data_Tab1();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên!");
                }
                reset_textbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_TimKiem_NV_Click(object sender, EventArgs e)
        {
            try
            {
                CSDL_QLKS con = new CSDL_QLKS();
                foreach (DataGridViewRow row in Data_NhanVien.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int i = 1;
                        if (cmb_ChucVu_NV.SelectedIndex == 2)
                            i = 7;
                        if (row.Cells[cmb_ChucVu_NV.SelectedIndex + i].Value.ToString()?.IndexOf(txt_TimKiem_NV.Text, StringComparison.OrdinalIgnoreCase) == -1)
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txt_TimKiem_NV_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Data_NhanVien.Rows)
            {
                if (!row.IsNewRow && row.Visible==false)
                {
                    row.Visible = true;
                }
            }
        }
        private void txt_NV_TextChanged(object sender, EventArgs e)
        {
            error_TenNV.Clear();
            error_CCCD.Clear();
            error_SDT.Clear();
            error_ChucVu.Clear();
            error_GioiTinh.Clear();
        }
        /*-------------------------------------------------TAB 2------------------------------------------------------------*/
        private void DATA_LICH_LAM_VIEC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DATA_LICH_LAM_VIEC.Rows.Count > 0 && e.RowIndex < (DATA_LICH_LAM_VIEC.RowCount - 1) && e.RowIndex > -1)
                {
                    string msnv = DATA_LICH_LAM_VIEC.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string malich = DATA_LICH_LAM_VIEC.Rows[e.RowIndex].Cells[6].Value.ToString();
                    CSDL_QLKS con = new CSDL_QLKS();
                    CHI_TIET_LICH_LAM_VIEC ctlv = con.CHI_TIET_LICH_LAM_VIEC.FirstOrDefault(p=>p.MA_NV==msnv && p.MA_LICH==malich);
                    if (ctlv!=null)
                    {
                        cmb_MNV_LLV.Text = ctlv.MA_NV;
                        txt_TenNV_LLV.Text = ctlv.NHAN_VIEN.TEN_NV;
                        DTP_DK_Ngaylam.Text = ctlv.NGAY_LAM.ToString();
                        DTP_DK_GBD.Text = ctlv.GIO_BAT_DAU.ToString();
                        DTP_DK_GKT.Text = ctlv.GIO_KET_THUC.ToString();
                        txt_MaLich_LLV.Text = ctlv.MA_LICH;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DATA_FOR_CMB_MaNV()
        {
            List<NHAN_VIEN> a = new CSDL_QLKS().NHAN_VIEN.Where(x => x.MA_CV != "NVQL").ToList();
            cmb_MNV_LLV.DataSource = a;
            cmb_MNV_LLV.DisplayMember = "MA_NV";
            cmb_MNV_LLV.ValueMember = "MA_NV";
            cmb_MNV_LLV.SelectedIndex = 0;

            txt_TenNV_LLV.Text = new CSDL_QLKS().NHAN_VIEN.SingleOrDefault(s => s.MA_NV == cmb_MNV_LLV.Text).TEN_NV;
        }

        private void cmb_MNV_LLV_TextChanged(object sender, EventArgs e)
        {
            var nhanVien = new CSDL_QLKS().NHAN_VIEN?.SingleOrDefault(s => s.MA_NV == cmb_MNV_LLV.Text);
            if (nhanVien != null)
            {
                txt_TenNV_LLV.Text = nhanVien.TEN_NV;
            }
            else
            {
                txt_TenNV_LLV.Text = string.Empty;
            }
        }

        private void Data_Tab2()
        {
            DATA_LICH_LAM_VIEC.Rows.Clear();
            var nv = new CSDL_QLKS();
            var time_table_staff=nv.CHI_TIET_LICH_LAM_VIEC.Select(x => x).ToList();
            foreach (var t in time_table_staff)
            {
                DATA_LICH_LAM_VIEC.Rows.Add(DATA_LICH_LAM_VIEC.RowCount.ToString(), 
                                            t.MA_NV,nv.NHAN_VIEN.FirstOrDefault(s=>s.MA_NV==t.MA_NV).TEN_NV,
                                            t.NGAY_LAM.ToString().Substring(0, t.NGAY_LAM.ToString().IndexOf(' ')),
                                            t.GIO_BAT_DAU.Value.TimeOfDay,
                                            t.GIO_KET_THUC.Value.TimeOfDay,
                                            t.MA_LICH);
            }
        }

        private void btn_DangKy_LLV_Click(object sender, EventArgs e)
        {
            try
            {
                string message, title;
                MessageBoxButtons buttons;
                DialogResult result;
                if (DateTime.Compare(DTP_DK_Ngaylam.Value.Date, DateTime.Today) < 0 || DateTime.Compare(DTP_DK_Ngaylam.Value.Date, DateTime.Today) == 0)
                {
                    message = "Ngày đăng ký phải lớn hơn ngày hiện tại: "+ DateTime.Today.ToString().Substring(0, DateTime.Today.ToString().IndexOf(' '));
                    title = "Lỗi";
                    buttons = MessageBoxButtons.OK;
                    result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    return;
                }
                else if (TimeSpan.Compare(DTP_DK_GKT.Value.TimeOfDay, DTP_DK_GBD.Value.TimeOfDay)<=0)
                {
                    error_Ngay_KT_LV.SetError(DTP_DK_GKT, "Giờ kết thúc phải lớn hơn giờ bắt đầu");
                    error_Ngay_KT_LV.SetIconPadding(DTP_DK_GKT, 5);
                    error_Ngay_KT_LV.SetIconAlignment(DTP_DK_GKT, ErrorIconAlignment.MiddleRight);
                }
                else
                {
                    CSDL_QLKS con = new CSDL_QLKS();
                    string s1;
                    int i = int.Parse(con.LICH_LAM_VIEC.OrderByDescending(s => s.MA_LICH).First().MA_LICH.ToString().Trim());
                    if (con.CHI_TIET_LICH_LAM_VIEC.Count(s => s.MA_NV == cmb_MNV_LLV.Text)==i)
                    {
                        s1 = (i + 1).ToString();
                        LICH_LAM_VIEC llv = new LICH_LAM_VIEC()
                        {
                            MA_LICH = s1
                        };
                        
                        con.LICH_LAM_VIEC.Add(llv);
                        con.SaveChanges();
                    }
                    else
                    {
                        s1=(con.CHI_TIET_LICH_LAM_VIEC.Count(s => s.MA_NV == cmb_MNV_LLV.Text)+1).ToString();
                    }
                    
                    CHI_TIET_LICH_LAM_VIEC ctlv = new CHI_TIET_LICH_LAM_VIEC()
                    {
                        MA_NV = cmb_MNV_LLV.Text,
                        MA_LICH = s1,
                        NGAY_LAM = DateTime.Parse( DTP_DK_Ngaylam.Text),
                        GIO_BAT_DAU = DateTime.Parse(DTP_DK_GBD.Text),
                        GIO_KET_THUC = DateTime.Parse(DTP_DK_GKT.Text)

                    };
                    con.CHI_TIET_LICH_LAM_VIEC.Add(ctlv);
                    MessageBox.Show("Thêm thành công!");
                    con.SaveChanges();
                    Data_Tab2();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sua_LLV_Click(object sender, EventArgs e)
        {
            try
            {
                CSDL_QLKS con = new CSDL_QLKS();

                string message, title;
                MessageBoxButtons buttons;
                DialogResult result;
                if (DateTime.Compare(con.CHI_TIET_LICH_LAM_VIEC.FirstOrDefault(s => s.MA_NV == cmb_MNV_LLV.Text).NGAY_LAM.Value.Date, DateTime.Today) < 0)
                {
                    message = ("Nhân viên đã làm việc! Không thể sửa lịch!");
                    title = "Lỗi";
                    buttons = MessageBoxButtons.OK;
                    result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    return;
                }
                else if (DateTime.Compare(DTP_DK_Ngaylam.Value.Date, DateTime.Today) < 0)
                {
                    message = "Ngày sửa phải lớn hơn ngày hiện tại: " + DateTime.Today.ToString().Substring(0, DateTime.Today.ToString().IndexOf(' '));
                    title = "Lỗi";
                    buttons = MessageBoxButtons.OK;
                    result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    CHI_TIET_LICH_LAM_VIEC update = con.CHI_TIET_LICH_LAM_VIEC.FirstOrDefault(p => p.MA_NV == cmb_MNV_LLV.Text && txt_MaLich_LLV.Text==p.MA_LICH);
                    if (update != null)
                    {

                        update.MA_NV= cmb_MNV_LLV.Text;
                        update.NGAY_LAM = DTP_DK_Ngaylam.Value.Date;
                        update.GIO_BAT_DAU = DateTime.Parse(DTP_DK_GBD.Text);
                        update.GIO_KET_THUC = DateTime.Parse(DTP_DK_GKT.Text);
                        MessageBox.Show("Sửa thành công!");
                        con.SaveChanges();
                        Data_Tab2();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_LLV_Click(object sender, EventArgs e)
        {
            try
            {
                CSDL_QLKS con = new CSDL_QLKS();

                string message, title;
                MessageBoxButtons buttons;
                DialogResult result;
                if (DateTime.Compare(con.CHI_TIET_LICH_LAM_VIEC.FirstOrDefault(s => s.MA_NV == cmb_MNV_LLV.Text).NGAY_LAM.Value.Date, DateTime.Today) < 0)
                {
                    message = ("Nhân viên đã làm việc! Không thể xóa lịch!");
                    title = "Lỗi";
                    buttons = MessageBoxButtons.OK;
                    result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    CHI_TIET_LICH_LAM_VIEC update = con.CHI_TIET_LICH_LAM_VIEC.FirstOrDefault(p => p.MA_NV == cmb_MNV_LLV.Text && txt_MaLich_LLV.Text == p.MA_LICH);
                    if (update != null)
                    {
                        message = "Bạn có muốn xóa lịch làm việc của nhân viên này không?";
                        title = "Cảnh báo";
                        buttons = MessageBoxButtons.YesNo;
                        result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            con.CHI_TIET_LICH_LAM_VIEC.Remove(update);
                            con.SaveChanges();
                            Data_Tab2();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            try
            {
                CSDL_QLKS con = new CSDL_QLKS();
                foreach (DataGridViewRow row in DATA_LICH_LAM_VIEC.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (DateTime.Compare(DateTime.Parse(row.Cells[3].Value.ToString()), DTP_Ngay_Lam_Viec.Value.Date) != 0)
                        {
                            row.Visible = false;
                        }
                        else if (DateTime.Compare(DateTime.Parse(row.Cells[4].Value.ToString()), DTP_GBD_LLV_Tim.Value) < 0)
                        {
                            row.Visible = false;
                        }
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DTP_Ngay_Lam_Viec_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DATA_LICH_LAM_VIEC.Rows)
            {
                if (!row.IsNewRow && row.Visible == false)
                {
                    row.Visible = true;
                }
            }
        }

        private void KT_Ngay_ValueChanged(object sender, EventArgs e)
        {
            error_Ngay_KT_LV.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DATA_LICH_LAM_VIEC.Rows)
            {
                if (!row.IsNewRow && row.Visible == false)
                {
                    row.Visible = true;
                }
            }
        }

        /*-------------------------------------------------TAB 3------------------------------------------------------------*/
        private void Data_Tab3()
        {
            try
            {
                DGV_Tab_3.Rows.Clear();
                CSDL_QLKS con = new CSDL_QLKS();
                var dt = con.DataGridView_Tab3.OrderByDescending(s=>s.NGAY_TRA).ToList();
                foreach (var a in dt)
                {
                    DGV_Tab_3.Rows.Add(a.SO_PHIEU_DAT_PHONG, DGV_Tab_3.RowCount.ToString(), a.TEN_KH, a.MA_PHONG, a.NGAY_TRA);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DGV_Tab_3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_Tab_3.Rows.Count > 0 && e.RowIndex < (DGV_Tab_3.RowCount - 1) && e.RowIndex > -1)
                {
                    string SoPhieu = DGV_Tab_3.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CSDL_QLKS con = new CSDL_QLKS();
                    DataGridView_Tab3 data = con.DataGridView_Tab3.FirstOrDefault(p => p.SO_PHIEU_DAT_PHONG == SoPhieu);
                    if (data != null)
                    {
                        LB_ma_kh_tab_3.Text = data.MA_KH;
                        LB_ten_kh_tab_3.Text = data.TEN_KH;
                        LB_ns_kh_tab_3.Text = data.NGAYSINH.ToString().Substring(0, data.NGAYSINH.ToString().IndexOf(' '));
                        LB_sdt_kh_tab_3.Text = data.SDT;
                        LB_cccd_kh_tab_3.Text = data.CCCD;

                        LB_SoPhong_tab3.Text = data.MA_PHONG;
                        LB_NgayDat_tab3.Text = data.NGAY_DAT.ToString().Substring(0, data.NGAY_DAT.ToString().IndexOf(' '));
                        LB_NgayTra_tab3.Text = data.NGAY_TRA.ToString().Substring(0, data.NGAY_TRA.ToString().IndexOf(' '));

                        string tmp1 = FormatCurrency((int)data.TONGTIEN);
                        string tmp2 = FormatCurrency((int)data.DATCOC);
                        LB_TongTien_tab3.Text = tmp1.Substring(0, tmp1.IndexOf(','))+tmp1.Substring(tmp1.LastIndexOf('0')+1);
                        LB_DatCoc_tab3.Text = tmp2.Substring(0, tmp2.IndexOf(',')) + tmp2.Substring(tmp2.LastIndexOf('0') + 1);
                    }
                }
                else
                {
                    LB_ma_kh_tab_3.ResetText();
                    LB_ten_kh_tab_3.ResetText();
                    LB_ns_kh_tab_3.ResetText();
                    LB_sdt_kh_tab_3.ResetText();
                    LB_cccd_kh_tab_3.ResetText();

                    LB_SoPhong_tab3.ResetText();
                    LB_NgayDat_tab3.ResetText();
                    LB_NgayTra_tab3.ResetText();
                    LB_TongTien_tab3.ResetText();
                    LB_DatCoc_tab3.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_Tab_3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                CSDL_QLKS con = new CSDL_QLKS();
                DataGridViewRow row = DGV_Tab_3.Rows[e.RowIndex];
                int columnIndex = DGV_Tab_3.Columns["NgayTra"].Index;
                if(row.Cells[columnIndex].Value != null)
                {
                    TimeSpan khoangThoiGian = DateTime.Parse(row.Cells[columnIndex].Value.ToString()) - DateTime.Today;

                    int total_H = khoangThoiGian.Days * 24 + khoangThoiGian.Hours + khoangThoiGian.Minutes / 60;
                    if (total_H < 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        // Đặt màu nền mặc định nếu không thoả mãn điều kiện
                        row.DefaultCellStyle.BackColor = DGV_Tab_3.DefaultCellStyle.BackColor;
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*-------------------------------------------------TAB 4------------------------------------------------------------*/
        private void DATA_FOR_CMB_NAM_TAB_4()
        {
            try
            {
                List<String> a = new CSDL_QLKS().HOADONs.ToList()
                .Select(s => s.NGAYLAP.Value.Year.ToString())
                .Distinct()
                .ToList();
                cmb_Nam_Tab_4.DataSource = a;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Data_Tab4()
        {
            try
            {
                Chart_TK_Theo_Thang_Cua_Nam.Series["VND"].Points.Clear();
                Chart_TK_Theo_Nam.Series["VND"].Points.Clear();

                var C_T = new CSDL_QLKS();

                int year = int.Parse(cmb_Nam_Tab_4.Text);
                var list = C_T.HOADONs
                    .Where(a => a.NGAYLAP.Value.Year == year)
                    .ToList();

                Khoi_Tao_Data_Char_1();
                foreach (var x in list)
                {
                    Data_Chart_1_Tab4(x.NGAYLAP.Value.Month.ToString(), float.Parse(x.TONGTIEN.ToString()));
                }
                Khoi_Tao_Data_Char_2();
                Data_Chart_2_Tab4();
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message );
            }
            
        }

        private void Khoi_Tao_Data_Char_1()
        {
            string[] list_1 = { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            Chart_TK_Theo_Thang_Cua_Nam.ChartAreas[0].AxisX.Interval = 1; //xác định khoảng cách giữa các nhãn trên trục x.
            Chart_TK_Theo_Thang_Cua_Nam.ChartAreas[0].AxisX.MajorTickMark.Interval = 1;//xác định khoảng cách giữa các điểm đánh dấu chính trên trục x.

            foreach (string month in list_1)
            {
                Chart_TK_Theo_Thang_Cua_Nam.Series["VND"].Points.AddXY(month, 0);
            }
        }

        private void Data_Chart_1_Tab4(string s, float total_money)
        {
            List<string> list = new List<string>();

            string[] data = { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            list.AddRange(data);

            int dt = int.Parse(s)-1;
            foreach (DataPoint point in Chart_TK_Theo_Thang_Cua_Nam.Series["VND"].Points)
            { 
                if (point.AxisLabel == data[dt])
                {
                    point.YValues[0]+=total_money;
                    break;
                }
            }
        }

        private List<String> GET_DATA_CHART_2()
        {
            List<String> a = new CSDL_QLKS().HOADONs.ToList()
                .Select(s => s.NGAYLAP.Value.Year.ToString())
                .Distinct()
                .ToList();

            return a;
        }

        private void Khoi_Tao_Data_Char_2()
        {
            List<String> a = GET_DATA_CHART_2();   
            Chart_TK_Theo_Nam.ChartAreas[0].AxisX.Interval = 1; //xác định khoảng cách giữa các nhãn trên trục x.
            Chart_TK_Theo_Nam.ChartAreas[0].AxisX.MajorTickMark.Interval = 1;//xác định khoảng cách giữa các điểm đánh dấu chính trên trục x.

            foreach (string year in a)
            {
                Chart_TK_Theo_Nam.Series["VND"].Points.AddXY(year, 0);
            }
        }

        private void Data_Chart_2_Tab4()
        {
            List<String> a = GET_DATA_CHART_2();
            List<HOADON> list = new CSDL_QLKS().HOADONs.ToList();
            foreach (var item in a)
            {
                float money = 0;
                foreach(var item2 in list)
                {
                    if (item2.NGAYLAP.Value.Year.ToString() == item)
                    {
                        money += float.Parse(item2.TONGTIEN.ToString());
                    }
                }
                foreach (DataPoint point in Chart_TK_Theo_Nam.Series["VND"].Points)
                {
                    if (point.AxisLabel == item)
                    {
                        point.YValues[0]=money;
                        break;
                    }
                }
            }
        }

        private void cmb_Nam_Tab_4_TextChanged(object sender, EventArgs e)
        {
            lb_TK_DT_TNam.Text = lb_TK_DT_TNam.Text.Substring(0, lb_TK_DT_TNam.Text.LastIndexOf('M')+1)+" "+cmb_Nam_Tab_4.Text;
            Data_Tab4(); 
        }
        /*------------------------------------------------------------------------------------------------------------------*/
    }
}
