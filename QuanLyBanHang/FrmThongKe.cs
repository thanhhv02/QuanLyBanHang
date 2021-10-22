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

namespace QuanLyBanHang
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }
        BUS_Hang BUS_Hang = new BUS_Hang();
        
        public void LoadGridView_ThongKeHang()
        {
            dgvSP.DataSource = BUS_Hang.ThongKeSP();
            dgvSP.Columns[0].HeaderText = "Mã nhân viên";
            dgvSP.Columns[1].HeaderText = "Tên nhân viên";
            dgvSP.Columns[2].HeaderText = "Số lượng sản phẩm nhập";
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadGridView_ThongKeTonKho()
        {
            dgvSP.DataSource = BUS_Hang.ThongKeTonKho();
            dgvSP.Columns[0].HeaderText = "Tên hàng";
            dgvSP.Columns[1].HeaderText = "Số lượng";
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void menuStripSPTonKho_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void SPTonKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGridView_ThongKeHang();
        }

        private void tonKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGridView_ThongKeTonKho();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            LoadGridView_ThongKeHang();
        }
    }
}
