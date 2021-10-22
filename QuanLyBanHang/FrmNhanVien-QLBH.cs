using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBanHang;
using DTO_QlBanHang;
namespace QuanLyBanHang
{
    public partial class FrmNhanVien_QLBH : Form
    {
        public FrmNhanVien_QLBH()
        {
            InitializeComponent();
        }
        public bool IsValid(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = null;
            textBoxTenNV.Text = null;
            textBoxDiaChi.Text = null;
            textBoxTenNV.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxDiaChi.Enabled = true;
            radioButtonNhanVien.Enabled = true;
            radioButtonQuantri.Enabled = true;
            radioButtonNgungHoatDong.Enabled = true;
            radioButtonHoatDong.Enabled = true;
            buttonSave.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            radioButtonNhanVien.Checked = true;
            radioButtonHoatDong.Checked = true;
            radioButtonNgungHoatDong.Checked = false;
            radioButtonQuantri.Checked = false;
            textBoxEmail.Focus();
        }
        BUS_NhanVien bUS_NhanVien = new BUS_NhanVien();
        private void LoadDataGridView_NhanVien()
        {
            dgvNhanVien.DataSource = bUS_NhanVien.getNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "Email";
            dgvNhanVien.Columns[1].HeaderText = "Tên";
            dgvNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[3].HeaderText = "Vai trò";
            dgvNhanVien.Columns[4].HeaderText = "Tình trạng";
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FrmNhanVien_QLBH_Load(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridView_NhanVien();
        }
        void ResetValue()
        {
            textBoxSearch.Text = "Nhập tên nhân viên";
            textBoxEmail.Text = null;
            textBoxTenNV.Text = null;
            textBoxDiaChi.Text  = null;
            textBoxEmail.Enabled = false;
            textBoxTenNV.Enabled = false;
            textBoxDiaChi.Enabled = false;
            radioButtonNhanVien.Enabled = false;
            radioButtonQuantri.Enabled = false;
            radioButtonHoatDong.Enabled = false;
            radioButtonNgungHoatDong.Enabled = false;
            buttonAdd.Enabled = true;
            buttonSave.Enabled = false;
            buttonClose.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
        }
        public void SendMail(string email)
        {
            try
            {
                // tao smtp client de gui mail
                SmtpClient smtpClient = new SmtpClient("stmp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("hovanthanh12102002@gmail.com", "thanhhvthienq");
                //can tao moi email de gui
                MailMessage mailMessage = new MailMessage();
                //dia chi email nguoi gui
                mailMessage.From = new MailAddress("sender@gmail.com");
                //dia chi nguoi nhan 
                mailMessage.To.Add(email);
                //chủ đề
                mailMessage.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                //phần thân của tin nhắn
                mailMessage.Body = "Chào anh/chị . Mật khẩu mới truy cập phần mềm là 5678";
                //gui thong tin dang nhap den client
                smtpClient.Credentials = cred;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                //chắc chắn muốn gửi mật khẩu
                MessageBox.Show("Đã gửi email phục hồi mật khẩu tới " + email);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int role = 0;
            if (radioButtonQuantri.Checked)
            {
                role = 1;
            }
            int tinhTrang = 0;
            if (radioButtonHoatDong.Checked)
            {
                tinhTrang = 1;
            }
            if (textBoxEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxEmail.Focus();
                return;
            }
            else if (!IsValid(textBoxEmail.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(textBoxTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTenNV.Focus();
                return;
            }
            else if (textBoxDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDiaChi.Focus();
                return;
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(textBoxTenNV.Text, textBoxDiaChi.Text, role, textBoxEmail.Text, tinhTrang, "insert");
                if (bUS_NhanVien.InsertNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValue();
                    LoadDataGridView_NhanVien();
                    SendMail(nv.EmailNV);
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvNhanVien.Rows.Count > 1)
                {
                    buttonSave.Enabled = false;
                    textBoxTenNV.Enabled = true;
                    textBoxDiaChi.Enabled = true;
                    radioButtonQuantri.Enabled = true;
                    radioButtonNhanVien.Enabled = true;
                    radioButtonHoatDong.Enabled = true;
                    radioButtonNgungHoatDong.Enabled = true;
                    buttonEdit.Enabled = true;
                    buttonDelete.Enabled = true;
                    textBoxEmail.Text = dgvNhanVien.CurrentRow.Cells["email"].Value.ToString();
                    textBoxTenNV.Text = dgvNhanVien.CurrentRow.Cells["tennv"].Value.ToString();
                    textBoxDiaChi.Text = dgvNhanVien.CurrentRow.Cells["diachi"].Value.ToString();
                    if (int.Parse(dgvNhanVien.CurrentRow.Cells["vaitro"].Value.ToString()) == 1)
                        radioButtonQuantri.Checked = true;
                    else
                        radioButtonNhanVien.Checked = true;
                    if (int.Parse(dgvNhanVien.CurrentRow.Cells["tinhtrang"].Value.ToString()) == 1)
                        radioButtonHoatDong.Checked = true;
                    else
                        radioButtonNgungHoatDong.Checked = true;
                }
                else
                {
                    MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTenNV.Focus();
                return;
            }
            else if(textBoxDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDiaChi.Focus();
                return;
            }
            else
            {
                int role = 0;
                if (radioButtonQuantri.Checked)
                {
                    role = 1;
                }
                int tinhTrang = 0;
                if (radioButtonHoatDong.Checked)
                {
                    tinhTrang = 1;
                }
                DTO_NhanVien nv = new DTO_NhanVien(textBoxTenNV.Text, textBoxDiaChi.Text, role, textBoxEmail.Text, tinhTrang, "update");
                if(MessageBox.Show("Bạn có chắc muốn chỉnh sửa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    if (bUS_NhanVien.UpdateNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thành công");
                        ResetValue();
                        LoadDataGridView_NhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    ResetValue();
                }
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if(email != FrmMain.mail)
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bUS_NhanVien.DeleteNhanVien(email))
                    {
                        MessageBox.Show("Xoá dữ liệu thành công");
                        ResetValue();
                        LoadDataGridView_NhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công");
                    }
                }
                else
                {
                    ResetValue();
                }
            }
            else
            {
                MessageBox.Show("Nhân viên này đang đăng nhập không thể xoá !");
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string tenNV = textBoxSearch.Text;
            DataTable ds = bUS_NhanVien.SearchNhanVien(tenNV);
            if (ds.Rows.Count > 0)
            {
                dgvNhanVien.DataSource = ds;
                dgvNhanVien.Columns[0].HeaderText = "Email";
                dgvNhanVien.Columns[1].HeaderText = "Tên";
                dgvNhanVien.Columns[2].HeaderText = "Địa chỉ";
                dgvNhanVien.Columns[3].HeaderText = "Vai trò";
                dgvNhanVien.Columns[4].HeaderText = "Tình trạng";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxSearch.Text = "Nhập tên nhân viên";
            textBoxSearch.BackColor = Color.LightGray;
            ResetValue();
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = null;
            textBoxSearch.BackColor = Color.White;
        }

        private void buttonDanhSach_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridView_NhanVien();
        }

        private void buttonBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridView_NhanVien();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNhanVien_QLBH_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
