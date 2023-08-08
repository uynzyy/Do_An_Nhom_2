using Do_An_DAL.DATA;
using Do_An_Nhom_2.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Nhom_2.NhanVien
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }
        private CSDL_QLKS context = new CSDL_QLKS();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var nv = context.NHAN_VIEN.FirstOrDefault(o => o.MA_NV.Equals(txtUser.Text));
            if (nv == null)
            {
                MessageBox.Show("Tài khoản này không tồn tại");
            }
            else
            {
                if (txtPass.Text.Equals(nv.SDT.Trim()))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    if (txtUser.Text != "BOSS")
                    {
                        Form_CongViec frm = new Form_CongViec();
                        frm.MaNV(txtUser.Text);
                        frm.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        Form_QuanLy frm = new Form_QuanLy();
                        frm.Visible = true;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Form_TrangChu frm = new Form_TrangChu();
            frm.Visible = true;
            this.Close();
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btn_Check_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_Check_Pass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
