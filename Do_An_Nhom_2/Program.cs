using Do_An_Nhom_2.NhanVien;
using Do_An_Nhom_2.TrangChu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Nhom_2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_TrangChu());//Form_DatPhong() ///Form_TrangChu()//Form_HoaDon()
        }
    }
}
