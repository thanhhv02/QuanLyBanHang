
namespace QuanLyBanHang
{
    partial class FrmThongKe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SPTonKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tonKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SPTonKhoToolStripMenuItem,
            this.tonKhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripSPTonKho_ItemClicked);
            // 
            // SPTonKhoToolStripMenuItem
            // 
            this.SPTonKhoToolStripMenuItem.Name = "SPTonKhoToolStripMenuItem";
            this.SPTonKhoToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.SPTonKhoToolStripMenuItem.Text = "Sản phẩm tồn kho";
            this.SPTonKhoToolStripMenuItem.Click += new System.EventHandler(this.SPTonKhoToolStripMenuItem_Click);
            // 
            // tonKhoToolStripMenuItem
            // 
            this.tonKhoToolStripMenuItem.Name = "tonKhoToolStripMenuItem";
            this.tonKhoToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.tonKhoToolStripMenuItem.Text = "Tồn Kho";
            this.tonKhoToolStripMenuItem.Click += new System.EventHandler(this.tonKhoToolStripMenuItem_Click);
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(13, 32);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(775, 386);
            this.dgvSP.TabIndex = 1;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SPTonKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tonKhoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSP;
    }
}