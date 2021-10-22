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
    public partial class FrmKhach_QLBH : Form
    {
        public FrmKhach_QLBH()
        {
            InitializeComponent();
        }
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        string nvMail = FrmMain.mail;
        private void FrmKhach_QLBH_Load(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridView_KhachHang();
        }
        private void LoadDataGridView_KhachHang()
        {
            dgvKhachHang.DataSource = BUS_KhachHang.getKhachHang();
            dgvKhachHang.Columns[0].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[1].HeaderText = "Họ và tên";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Giới tính";
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void ResetValue()
        {
            textBoxSearch.Text = "Nhập số điện thoại khách hàng";
            textBoxSDT.Text = null;
            textBoxSDT.Enabled = false;
            textBoxDiaChi.Text = null;
            textBoxTenKhach.Text = null;
            textBoxTenKhach.Enabled = false;
            textBoxDiaChi.Enabled = false;
            radioButtonNam.Enabled = false;
            radioButtonNu.Enabled = false;
            buttonAdd.Enabled = true;
            buttonSave.Enabled = false;
            buttonClose.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxSDT.Text = null;
            textBoxDiaChi.Text = null;
            textBoxTenKhach.Text = null;
            textBoxSDT.Enabled = true;
            textBoxDiaChi.Enabled = true;
            textBoxTenKhach.Enabled = true;
            radioButtonNu.Enabled = true;
            radioButtonNam.Enabled = true;
            radioButtonNam.Checked = true;
            radioButtonNu.Checked = false;
            buttonSave.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            textBoxSDT.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            float intDienThoai;
            bool isInt = float.TryParse(textBoxSDT.Text.Trim().ToString(), out intDienThoai);// check num or word
            string phai = "Nam";
            if(radioButtonNu.Checked == true)
            {
                phai = "Nữ";
            }
            if(!isInt || float.Parse(textBoxSDT.Text) < 0)//check SDT
            {
                MessageBox.Show("Bạn phải nhập số điện thoại > 0, số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSDT.Focus();
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(textBoxSDT.Text, textBoxTenKhach.Text, textBoxDiaChi.Text, phai,nvMail, "insert");
                if (BUS_KhachHang.InsertKhachHang(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValue();
                    LoadDataGridView_KhachHang();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvKhachHang.Rows.Count > 0)
                {
                    textBoxSDT.Enabled = false;
                    buttonSave.Enabled = false;
                    textBoxDiaChi.Enabled = true;
                    textBoxTenKhach.Enabled = true;
                    radioButtonNam.Enabled = true;
                    radioButtonNu.Enabled = true;
                    textBoxSDT.Focus();
                    buttonEdit.Enabled = true;
                    buttonDelete.Enabled = true;
                    textBoxSDT.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                    textBoxTenKhach.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                    textBoxDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                    string phai = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                    if (phai == "Nam")
                        radioButtonNam.Checked = true;
                    else
                    {
                        radioButtonNu.Checked = true;
                    }
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
            float intDienThoai;
            bool isInt = float.TryParse(textBoxSDT.Text.Trim().ToString(), out intDienThoai);// check num or word
            string phai = "Nam";
            if (radioButtonNu.Checked == true)
            {
                phai = "Nữ";
            }
            if (!isInt || float.Parse(textBoxSDT.Text) < 0)//check SDT
            {
                MessageBox.Show("Bạn phải nhập số điện thoại > 0, số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSDT.Focus();
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(textBoxSDT.Text, textBoxTenKhach.Text, textBoxDiaChi.Text, phai,nvMail,"update");
                if (BUS_KhachHang.UpdateKhachHang(kh))
                {
                    MessageBox.Show("Cập nhật thành công");
                    ResetValue();
                    LoadDataGridView_KhachHang();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
        }

        private void FrmKhach_QLBH_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string SDT = textBoxSDT.Text;
            if (MessageBox.Show("Bạn có chắc muốn xoá dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BUS_KhachHang.DeleteKhachHang(SDT))
                {
                    MessageBox.Show("Xoá dữ liệu thành công");
                    ResetValue();
                    LoadDataGridView_KhachHang();
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

        private void buttonBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridView_KhachHang();
        }

        private void buttonDanhSach_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridView_KhachHang();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string SDT = textBoxSearch.Text;
            DataTable ds = BUS_KhachHang.SearchKhach(SDT);
            if (ds.Rows.Count > 0)
            {
                dgvKhachHang.DataSource = ds;
                dgvKhachHang.Columns[0].HeaderText = "Điện thoại";
                dgvKhachHang.Columns[1].HeaderText = "Họ và tên";
                dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
                dgvKhachHang.Columns[3].HeaderText = "Giới tính";
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxSearch.Text = "Nhập số điện thoại khách hàng";
            textBoxSearch.BackColor = Color.LightGray;
            ResetValue();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = null;
            textBoxSearch.BackColor = Color.White;
        }
    }
}
