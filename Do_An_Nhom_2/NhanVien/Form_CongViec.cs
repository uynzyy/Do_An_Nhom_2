using Do_An_DAL.DATA;
using Do_An_Nhom_2.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Nhom_2.NhanVien
{
    public partial class Form_CongViec : Form
    {
        CSDL_QLKS con = new CSDL_QLKS();
        public Form_CongViec()
        {
            InitializeComponent();
        }

        string msnv = "";
        string message, title;
        MessageBoxButtons buttons;
        DialogResult result;
        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            var kt1 = con.NHAN_VIEN.FirstOrDefault(s => s.MA_NV == msnv).MA_CV.ToString();
            if (kt1 == "NVLT")
            {
                Form_DatPhong frm = new Form_DatPhong();
                frm.MaNV(msnv);
                frm.Visible = true;
                this.Close();
            }
            else
            {
                message = ("Bạn không có quyền để thực hiện chức năng này!");
                title = "Lỗi";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_TraPhong_Click(object sender, EventArgs e)
        {
            var kt1 = con.NHAN_VIEN.FirstOrDefault(s=>s.MA_NV==msnv).MA_CV.ToString();
            if(kt1== "NVLT")
            {
                Form_HoaDon frm = new Form_HoaDon();
                frm.MaNV(msnv);
                frm.Visible = true;
                this.Close();
            }
            else
            {
                message = ("Bạn không có quyền để thực hiện chức năng này!");
                title = "Lỗi";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Form_TrangChu frm = new Form_TrangChu();
            frm.Visible = true;
            this.Close();
        }

        public void MaNV(string s)
        {
            msnv = s;
        }
    }
}
