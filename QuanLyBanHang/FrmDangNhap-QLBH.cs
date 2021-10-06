using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QlBanHang;
using BUS_QLBanHang;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
 

namespace QuanLyBanHang
{
    public partial class FrmDangNhap_QLBH : Form
    {
        public string vaiTro { get; set; }
        public string matKhau { get; set; }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        FrmMain fm;
        public FrmDangNhap_QLBH()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
        
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.EmailNV = textBoxEmail.Text;
            nv.MatKhau = busNhanVien.encryption(textBoxPW.Text);

            if (busNhanVien.NhanVienDangNhap(nv))
            {
                //login = true;
                FrmMain.mail = nv.EmailNV;
                DataTable dt = busNhanVien.VaiTroNhanVien(nv.EmailNV);
                vaiTro = dt.Rows[0][0].ToString();//lay vai tro cua nhan vien

                MessageBox.Show("Đăng nhập thành công");
                FrmMain.session = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu");
                textBoxPW.Text = null;
                textBoxEmail.Focus();
            }



        }
        
        bool checkAcc()
        {
            if (String.IsNullOrEmpty(textBoxEmail.Text) == true)
            {
                MessageBox.Show("Chưa nhập email");
                textBoxEmail.Text = null;
                textBoxEmail.Focus();
                return true;
            }
            if (String.IsNullOrEmpty(textBoxPW.Text) == true)
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                textBoxPW.Text = null;
                textBoxPW.Focus();
                return true;
            }
            return false;
        }

        //tao chuoi ngau nhien
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for(int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToLower();

            }
            return builder.ToString();
        }
        //tao so ngau nhien
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        //gioi mail
        public void SenMail(string email, string matkhau)
        {
            try
            {
                // tao smtp client de gui mail
                SmtpClient smtpClient = new SmtpClient("stmp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("sender@gmail.com", "chonduoi");
                //can tao moi email de gui
                MailMessage mailMessage = new MailMessage();
                //dia chi email nguoi gui
                mailMessage.From = new MailAddress("sender@gmail.com");
                //dia chi nguoi nhan 
                mailMessage.To.Add(email);
                //chủ đề
                mailMessage.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                //phần thân của tin nhắn
                mailMessage.Body = "Chào anh/chị . Mật khẩu mới truy cập phần mềm là" + matkhau;
                //gui thong tin dang nhap den client
                smtpClient.Credentials = cred;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                //chắc chắn muốn gửi mật khẩu
                MessageBox.Show("Đã gửi email phục hồi mật khẩu tới "+email);


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void labelForgotPW_Click(object sender, EventArgs e)
        {
            if(textBoxEmail.Text != "")
            {
                if (busNhanVien.NhanVienQuenMatKhau(textBoxEmail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9999));
                    builder.Append(RandomString(2, false));
                    MessageBox.Show(builder.ToString());
                    string matKhauMoi = busNhanVien.encryption(builder.ToString());
                    busNhanVien.TaoMatKhau(textBoxEmail.Text,matKhauMoi);
                    SenMail(textBoxEmail.Text, builder.ToString());

                }
                else
                {
                    MessageBox.Show("Email không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập Email");
                textBoxEmail.Focus();
            }
        }

        private void FrmDangNhap_QLBH_Load(object sender, EventArgs e)
        {

        }

        public void FrmDangNhap_QLBH_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void checkBoxSaveAcc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
