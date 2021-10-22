using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBanHang;
using DTO_QlBanHang;

namespace QuanLyBanHang
{
    public partial class FrmHang_QLBH : Form
    {
        public FrmHang_QLBH()
        {
            InitializeComponent();
        }

        BUS_Hang BUS_Hang = new BUS_Hang();
        string mail = FrmMain.mail;//nhận mail từ form main
        string checkUrlImage;// kiểm tra hình khi cập nhật
        string fileName;//tên file
        string fileSavePath;//url store image
        string fileAddress;// url load images
        private void FrmHang_QLBH_Load(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridView_Hang();
            pictureBoxHinh.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void LoadDataGridView_Hang()
        {
            dgvHang.DataSource = BUS_Hang.getHang();
            dgvHang.Columns[0].HeaderText = "Mã sản phẩm";
            dgvHang.Columns[1].HeaderText = "Tên sản phẩm";
            dgvHang.Columns[2].HeaderText = "Số lượng";
            dgvHang.Columns[3].HeaderText = "Đơn giá nhập";
            dgvHang.Columns[3].HeaderText = "Đơn giá nhập";
            dgvHang.Columns[3].HeaderText = "Hình ảnh";
            dgvHang.Columns[3].HeaderText = "Ghi chú";
            dgvHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void ResetValue()
        {
            textBoxSearch.Text = "Nhập tên hàng";
            textBoxMaHang.Text = null;
            textBoxMaHang.Enabled = false;
            textBoxTenHang.Text = null;
            textBoxTenHang.Enabled = false;
            textBoxSL.Text = null;
            textBoxSL.Enabled = false;
            textBoxDGNhap.Text = null;
            textBoxDGNhap.Enabled = false;
            textBoxDGBan.Text = null;
            textBoxDGBan.Enabled = false;
            richTextBoxGhiChu.Text = null;
            richTextBoxGhiChu.Enabled = false;
            textBoxHinh.Enabled = false;
            textBoxHinh.Text = null;
            buttonAdd.Enabled = true;
            buttonSave.Enabled = false;
            buttonClose.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonMoHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|.bmp|JPEG(*.jpg)|*.jpg|GIF(*.fig)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                pictureBoxHinh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = "Images\\" + fileName;//combine with file name
                textBoxHinh.Text = "Images\\" + fileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            bool isInt = int.TryParse(textBoxSL.Text.Trim().ToString(), out intSoLuong);// ep kieu la so hay chu
            float floatDonGiaNhap;
            bool isFloatNhap = float.TryParse(textBoxDGNhap.Text.Trim().ToString(), out floatDonGiaNhap);// ep kieu la so hay chu
            float floatDonGiaBan;
            bool isFloatBan = float.TryParse(textBoxDGBan.Text.Trim().ToString(), out floatDonGiaBan);// ep kieu la so hay chu
            if (textBoxTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTenHang.Focus();
                return;
            }
            else if(!isInt || int.Parse(textBoxSL.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTenHang.Focus();
                return;
            }
            else if (!isFloatNhap || int.Parse(textBoxDGNhap.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDGNhap.Focus();
                return;
            }
            else if (!isFloatBan || int.Parse(textBoxDGBan.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDGBan.Focus();
                return;
            }
            else if (textBoxHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải upload hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonMoHinh.Focus();
                return;
            }
            else
            {
                DTO_Hang h = new DTO_Hang(textBoxTenHang.Text, int.Parse(textBoxSL.Text), float.Parse(textBoxDGBan.Text),
                    float.Parse(textBoxDGNhap.Text),"\\Images\\"+fileName, richTextBoxGhiChu.Text, mail);
                if (BUS_Hang.InsertHang(h))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    if (textBoxHinh.Text != checkUrlImage)
                    {
                        File.Copy(fileAddress, fileSavePath, true);//copy file hinh
                    }
                    ResetValue();
                    LoadDataGridView_Hang();

                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công");

                }

            }
        }

        private void FrmHang_QLBH_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxMaHang.Text = null;
            textBoxMaHang.Enabled = false;
            textBoxTenHang.Text = null;
            textBoxTenHang.Enabled = true;
            textBoxSL.Text = null;
            textBoxSL.Enabled = true;
            textBoxDGNhap.Text = null;
            textBoxDGNhap.Enabled = true;
            textBoxDGBan.Text = null;
            textBoxDGBan.Enabled = true;
            richTextBoxGhiChu.Text = null;
            buttonSave.Enabled = true;
            richTextBoxGhiChu.Enabled = true;
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0,(Application.StartupPath.Length-10));
            try
            {
                if (dgvHang.Rows.Count > 1)
                {
                    buttonMoHinh.Enabled = true;
                    buttonSave.Enabled = false;
                    textBoxTenHang.Enabled = true;
                    textBoxSL.Enabled = true;
                    textBoxDGNhap.Enabled = true;
                    textBoxDGBan.Enabled = true;
                    richTextBoxGhiChu.Enabled = true;
                    textBoxTenHang.Focus();
                    buttonEdit.Enabled = true;
                    buttonDelete.Enabled = true;
                    textBoxMaHang.Text = dgvHang.CurrentRow.Cells["mahang"].Value.ToString();
                    textBoxTenHang.Text = dgvHang.CurrentRow.Cells["tenhang"].Value.ToString();
                    textBoxSL.Text = dgvHang.CurrentRow.Cells["soluong"].Value.ToString();
                    textBoxDGNhap.Text = dgvHang.CurrentRow.Cells["dongianhap"].Value.ToString();
                    textBoxDGBan.Text = dgvHang.CurrentRow.Cells["dongiaban"].Value.ToString();
                    textBoxHinh.Text = dgvHang.CurrentRow.Cells["hinhanh"].Value.ToString();
                    checkUrlImage = textBoxHinh.Text;//giu duong dan file hinh
                    pictureBoxHinh.Image = Image.FromFile(saveDirectory + dgvHang.CurrentRow.Cells["hinhanh"].Value.ToString());
                    richTextBoxGhiChu.Text = dgvHang.CurrentRow.Cells["ghichu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                
            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            bool isInt = int.TryParse(textBoxSL.Text.Trim().ToString(), out intSoLuong);// ep kieu la so hay chu
            float floatDonGiaNhap;
            bool isFloatNhap = float.TryParse(textBoxDGNhap.Text.Trim().ToString(), out floatDonGiaNhap);// ep kieu la so hay chu
            float floatDonGiaBan;
            bool isFloatBan = float.TryParse(textBoxDGBan.Text.Trim().ToString(), out floatDonGiaBan);// ep kieu la so hay chu
            if (textBoxTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTenHang.Focus();
                return;
            }
            else if (!isInt || int.Parse(textBoxSL.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTenHang.Focus();
                return;
            }
            else if (!isFloatNhap || int.Parse(textBoxDGNhap.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDGNhap.Focus();
                return;
            }
            else if (!isFloatBan || int.Parse(textBoxDGBan.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDGBan.Focus();
                return;
            }
            else if (textBoxHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải upload hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonMoHinh.Focus();
                return;
            }
            else
            {
                DTO_Hang h = new DTO_Hang(int.Parse(textBoxMaHang.Text), textBoxTenHang.Text, int.Parse(textBoxSL.Text), float.Parse(textBoxDGBan.Text),
                    float.Parse(textBoxDGNhap.Text), "\\Images\\" + fileName, richTextBoxGhiChu.Text);
                if (BUS_Hang.UpdateHang(h))
                {
                    if(textBoxHinh.Text != checkUrlImage)
                    {
                        File.Copy(fileAddress, fileSavePath, true);//copy file hinh
                    }
                    MessageBox.Show("Cập nhật sản phẩm thành công");
                    ResetValue();
                    LoadDataGridView_Hang();

                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm không thành công");

                }

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string MaHang = textBoxMaHang.Text;
            if (MessageBox.Show("Bạn có chắc muốn xoá dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BUS_Hang.DeleteHang(MaHang))
                {
                    MessageBox.Show("Xoá dữ liệu thành công");
                    ResetValue();
                    LoadDataGridView_Hang();
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
            LoadDataGridView_Hang();
        }

        private void buttonDanhSach_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataGridView_Hang();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string tenHang = textBoxSearch.Text;
            DataTable ds = BUS_Hang.SearchHang(tenHang);
            if (ds.Rows.Count > 0)
            {
                dgvHang.DataSource = ds;
                dgvHang.Columns[0].HeaderText = "Mã sản phẩm";
                dgvHang.Columns[1].HeaderText = "Tên sản phẩm";
                dgvHang.Columns[2].HeaderText = "Số lượng";
                dgvHang.Columns[3].HeaderText = "Đơn giá nhập";
                dgvHang.Columns[3].HeaderText = "Đơn giá nhập";
                dgvHang.Columns[3].HeaderText = "Hình ảnh";
                dgvHang.Columns[3].HeaderText = "Ghi chú";
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxSearch.Text = "Nhập tên sản phẩm";
            textBoxSearch.BackColor = Color.LightGray;
            ResetValue();
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = null;
            textBoxSearch.BackColor = Color.White;
        }
    }
}
