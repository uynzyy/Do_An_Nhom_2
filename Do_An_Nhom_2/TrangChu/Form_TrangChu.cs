using Do_An_DAL.DATA;
using Do_An_Nhom_2.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Nhom_2.TrangChu
{
    public partial class Form_TrangChu : Form
    {
        public Form_TrangChu()
        {
            InitializeComponent();
        }

        CSDL_QLKS con = new CSDL_QLKS();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Form_DangNhap frm = new Form_DangNhap();
            frm.ShowDialog();
            this.Visible = false;
        }

        private void btn_DangNhap_KH_Click(object sender, EventArgs e)
        {
            Form_DatPhong frm = new Form_DatPhong();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
