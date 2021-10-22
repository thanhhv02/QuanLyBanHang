using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBanHang;
using DTO_QlBanHang;

namespace QuanLyBanHang
{
    public partial class FrmDoiMatKhau_QLBH : Form
    {
        public FrmDoiMatKhau_QLBH()
        {
            InitializeComponent();
        }
        BUS_NhanVien busNhanVien;
        private void FrmDoiMatKhau_QLBH_Load(object sender, EventArgs e)
        {

        }
        bool checkNewPW()
        {
            if(textBoxNewPW2.Text != textBoxNewPW.Text)
            {
                MessageBox.Show("Mật khẩu mới không giống nhau");
                return true;
            }
            return false;
        }
        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
            
            string EmailNV = textBoxEmail.Text;
            string MatKhau = busNhanVien.encryption(textBoxOldPW.Text);
            string matKhauMoi = busNhanVien.encryption(textBoxNewPW.Text);
            if (busNhanVien.NhanVienDoiMatKhau(EmailNV,MatKhau,matKhauMoi) && checkNewPW())
            {
                MessageBox.Show("Đổi mật khẩu thành công");
            }
        }
    }
}
