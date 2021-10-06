
namespace QuanLyBanHang
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStripChucNang = new System.Windows.Forms.MenuStrip();
            this.HeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoSoNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKeSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HuongDanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GioiThieuPMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thongTinNVtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripChucNang
            // 
            this.menuStripChucNang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThongToolStripMenuItem,
            this.DanhMucToolStripMenuItem,
            this.ThongKeToolStripMenuItem,
            this.HuongDanToolStripMenuItem,
            this.thongTinNVtoolStripMenuItem1});
            this.menuStripChucNang.Location = new System.Drawing.Point(0, 0);
            this.menuStripChucNang.Name = "menuStripChucNang";
            this.menuStripChucNang.Size = new System.Drawing.Size(676, 28);
            this.menuStripChucNang.TabIndex = 0;
            this.menuStripChucNang.Text = "menuStrip1";
            this.menuStripChucNang.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripChucNang_ItemClicked);
            // 
            // HeThongToolStripMenuItem
            // 
            this.HeThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginToolStripMenuItem,
            this.LogoutToolStripMenuItem,
            this.HoSoNVToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem";
            this.HeThongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.HeThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.LoginToolStripMenuItem.Text = "Đăng nhập";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.LogoutToolStripMenuItem.Text = "Đăng xuất";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // HoSoNVToolStripMenuItem
            // 
            this.HoSoNVToolStripMenuItem.Name = "HoSoNVToolStripMenuItem";
            this.HoSoNVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HoSoNVToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.HoSoNVToolStripMenuItem.Text = "Hồ sơ nhân viên";
            this.HoSoNVToolStripMenuItem.Click += new System.EventHandler(this.HoSoNVToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ExitToolStripMenuItem.Text = "Thoát";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // DanhMucToolStripMenuItem
            // 
            this.DanhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SanPhamToolStripMenuItem,
            this.nhanVienToolStripMenuItem,
            this.khachHangToolStripMenuItem});
            this.DanhMucToolStripMenuItem.Name = "DanhMucToolStripMenuItem";
            this.DanhMucToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.DanhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // SanPhamToolStripMenuItem
            // 
            this.SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem";
            this.SanPhamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.SanPhamToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SanPhamToolStripMenuItem.Text = "Sản phẩm";
            this.SanPhamToolStripMenuItem.Click += new System.EventHandler(this.SanPhamToolStripMenuItem_Click);
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhanVienToolStripMenuItem.Text = "Nhân viên";
            this.nhanVienToolStripMenuItem.Click += new System.EventHandler(this.nhanVienToolStripMenuItem_Click);
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.khachHangToolStripMenuItem.Text = "Khách hàng";
            this.khachHangToolStripMenuItem.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click);
            // 
            // ThongKeToolStripMenuItem
            // 
            this.ThongKeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongKeSPToolStripMenuItem});
            this.ThongKeToolStripMenuItem.Name = "ThongKeToolStripMenuItem";
            this.ThongKeToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.ThongKeToolStripMenuItem.Text = "Thống kê";
            // 
            // ThongKeSPToolStripMenuItem
            // 
            this.ThongKeSPToolStripMenuItem.Name = "ThongKeSPToolStripMenuItem";
            this.ThongKeSPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.ThongKeSPToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.ThongKeSPToolStripMenuItem.Text = "Thống kê sản phẩm";
            this.ThongKeSPToolStripMenuItem.Click += new System.EventHandler(this.ThongKeSPToolStripMenuItem_Click);
            // 
            // HuongDanToolStripMenuItem
            // 
            this.HuongDanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HDSDToolStripMenuItem,
            this.GioiThieuPMToolStripMenuItem});
            this.HuongDanToolStripMenuItem.Name = "HuongDanToolStripMenuItem";
            this.HuongDanToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HuongDanToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.HuongDanToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // HDSDToolStripMenuItem
            // 
            this.HDSDToolStripMenuItem.Name = "HDSDToolStripMenuItem";
            this.HDSDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.HDSDToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.HDSDToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.HDSDToolStripMenuItem.Click += new System.EventHandler(this.HDSDToolStripMenuItem_Click);
            // 
            // GioiThieuPMToolStripMenuItem
            // 
            this.GioiThieuPMToolStripMenuItem.Name = "GioiThieuPMToolStripMenuItem";
            this.GioiThieuPMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.GioiThieuPMToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.GioiThieuPMToolStripMenuItem.Text = "Giới thiệu phần mềm";
            this.GioiThieuPMToolStripMenuItem.Click += new System.EventHandler(this.GioiThieuPMToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dự án mẫu C# - Quản lí bán hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(269, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 188);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // thongTinNVtoolStripMenuItem1
            // 
            this.thongTinNVtoolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thongTinNVtoolStripMenuItem1.Name = "thongTinNVtoolStripMenuItem1";
            this.thongTinNVtoolStripMenuItem1.Size = new System.Drawing.Size(27, 24);
            this.thongTinNVtoolStripMenuItem1.Text = " ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(676, 317);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripChucNang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripChucNang;
            this.Name = "FrmMain";
            this.Text = "FrmMain-QLBH";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStripChucNang.ResumeLayout(false);
            this.menuStripChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripChucNang;
        private System.Windows.Forms.ToolStripMenuItem HeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoSoNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DanhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongKeSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HuongDanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GioiThieuPMToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem thongTinNVtoolStripMenuItem1;
    }
}

