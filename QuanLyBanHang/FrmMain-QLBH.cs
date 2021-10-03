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
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmDangNhap_QLBH DN;
        FrmDoiMatKhau_QLBH DMK;
        FrmHang_QLBH Hang;
        FrmKhach_QLBH Khach;
        FrmNhanVien_QLBH NV;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DN = new FrmDangNhap_QLBH();
            if (!CheckExistForm("FrmDangNhap_QLBH"))
            {
                //IsMdiContainer = true;
                DN.MdiParent = this.MdiParent;
                DN.Show();
            }
            else
            {
                ActiveChildForm("FrmDangNhap_QLBH");
            }
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
    }
}
