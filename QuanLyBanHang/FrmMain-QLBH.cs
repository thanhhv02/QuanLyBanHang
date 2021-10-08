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

namespace QuanLyBanHang
{
    public partial class FrmMain : Form
    {
        public static int session = 0;// kt tinh trang login
        public static int profile = 0;
        public static string mail; // luu mail
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmDangNhap_QLBH DN;
        FrmDoiMatKhau_QLBH DMK;
        FrmHang_QLBH Hang;
        FrmKhach_QLBH Khach;
        FrmNhanVien_QLBH NV;

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DN = new FrmDangNhap_QLBH();
            if (!CheckExistForm("FrmDangNhap_QLBH"))
            {
                //IsMdiContainer = true;
                DN.MdiParent = this.MdiParent;
                DN.Show();
                DN.FormClosed += new FormClosedEventHandler(FrmDangNhap_QLBH_FormClosed);
            }
            else
            {
                ActiveChildForm("FrmDangNhap_QLBH");
            }
        }

        private void FrmDangNhap_QLBH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();

            FrmMain_Load(sender, e);
        }
        private void checkBoxSaveAcc_CheckedChanged(object sender, EventArgs e)
        {

        }

        //check da ton tai hay chua
        private bool CheckExistForm(string name)
        {
            foreach( Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    return true;
                    
                }
                
            }
            return false;
        }
        //neu da ton tai chi active
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }

            }
        }

        private void HDSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "HuongDanSuDungPhanMem");
                System.Diagnostics.Process.Start(path);
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FrmMain_Load(object sender, EventArgs e)
        {
            Resetvalue();
            if(profile == 1)
            {
                thongTinNVtoolStripMenuItem1 = null;
                profile = 0; //an muc thong tin nv
            }
        }
        //void ResetValue()
        //{
        //    DN = new FrmDangNhap_QLBH();
        //    if (session == 1)
        //    {
        //        if (Convert.ToInt32(DN.vaiTro) != 0)
        //        {
        //            thongTinNVtoolStripMenuItem1.Text = "Chào " + mail;
        //            HoSoNVToolStripMenuItem.Visible = true;
        //            DanhMucToolStripMenuItem.Visible = true;
        //            SanPhamToolStripMenuItem.Visible = true;
        //            khachHangToolStripMenuItem.Visible = true;
        //            nhanVienToolStripMenuItem.Visible = true;
        //            LogoutToolStripMenuItem.Visible = true;
        //            ThongKeToolStripMenuItem.Visible = true;
        //            ThongKeSPToolStripMenuItem.Visible = true;
        //        }

        //        else
        //        {
        //            nhanVienToolStripMenuItem.Visible = false;
        //            ThongKeToolStripMenuItem.Visible = false;
        //        }
        //    }
        //    else
        //    {
        //        DanhMucToolStripMenuItem.Visible = false;
        //        LogoutToolStripMenuItem.Visible = false;
        //        HoSoNVToolStripMenuItem.Visible = false;
        //        ThongKeSPToolStripMenuItem.Visible = false;
        //    }
        //}
        private void VaiTroNV()
        {
            nhanVienToolStripMenuItem.Visible = false;
            ThongKeToolStripMenuItem.Visible = false;
        }

        //Thiết lập phân quyền khi load FrmMain
        private void Resetvalue()
        {
            if (session == 1)
            {
                thongTinNVtoolStripMenuItem1.Text = "Chào " + mail;
                HoSoNVToolStripMenuItem.Visible = true;
                DanhMucToolStripMenuItem.Visible = true;
                SanPhamToolStripMenuItem.Visible = true;
                khachHangToolStripMenuItem.Visible = true;
                nhanVienToolStripMenuItem.Visible = true;
                LogoutToolStripMenuItem.Visible = true;
                ThongKeToolStripMenuItem.Visible = true;
                ThongKeSPToolStripMenuItem.Visible = true;
                if (int.Parse(DN.vaiTro) == 0)// nếu là vai trò nhân viên
                {
                    VaiTroNV(); // chức năng nhân viên cơ bản
                }
            }
            else
            {
                nhanVienToolStripMenuItem.Visible = false;

                DanhMucToolStripMenuItem.Visible = false;
                LogoutToolStripMenuItem.Visible = false;
                HoSoNVToolStripMenuItem.Visible = false;
                ThongKeSPToolStripMenuItem.Visible = false;

            }
        }
        private void menuStripChucNang_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session = 0;
            Resetvalue();
            thongTinNVtoolStripMenuItem1.Text = null;
        }

        private void HoSoNVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ThongKeSPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GioiThieuPMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
