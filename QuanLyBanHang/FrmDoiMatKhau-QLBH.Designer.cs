
namespace QuanLyBanHang
{
    partial class FrmDoiMatKhau_QLBH
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDoiMatKhau = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxOldPW = new System.Windows.Forms.TextBox();
            this.textBoxNewPW = new System.Windows.Forms.TextBox();
            this.textBoxNewPW2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(83, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Đổi mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // buttonDoiMatKhau
            // 
            this.buttonDoiMatKhau.Location = new System.Drawing.Point(102, 323);
            this.buttonDoiMatKhau.Name = "buttonDoiMatKhau";
            this.buttonDoiMatKhau.Size = new System.Drawing.Size(123, 34);
            this.buttonDoiMatKhau.TabIndex = 23;
            this.buttonDoiMatKhau.Text = "Đổi mật khẩu";
            this.buttonDoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(102, 384);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(123, 23);
            this.buttonClose.TabIndex = 23;
            this.buttonClose.Text = "Thoát";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(71, 116);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(197, 22);
            this.textBoxEmail.TabIndex = 24;
            // 
            // textBoxOldPW
            // 
            this.textBoxOldPW.Location = new System.Drawing.Point(71, 172);
            this.textBoxOldPW.Name = "textBoxOldPW";
            this.textBoxOldPW.Size = new System.Drawing.Size(197, 22);
            this.textBoxOldPW.TabIndex = 24;
            // 
            // textBoxNewPW
            // 
            this.textBoxNewPW.Location = new System.Drawing.Point(71, 233);
            this.textBoxNewPW.Name = "textBoxNewPW";
            this.textBoxNewPW.Size = new System.Drawing.Size(197, 22);
            this.textBoxNewPW.TabIndex = 24;
            // 
            // textBoxNewPW2
            // 
            this.textBoxNewPW2.Location = new System.Drawing.Point(71, 285);
            this.textBoxNewPW2.Name = "textBoxNewPW2";
            this.textBoxNewPW2.Size = new System.Drawing.Size(197, 22);
            this.textBoxNewPW2.TabIndex = 24;
            // 
            // FrmDoiMatKhau_QLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.textBoxNewPW2);
            this.Controls.Add(this.textBoxNewPW);
            this.Controls.Add(this.textBoxOldPW);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDoiMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "FrmDoiMatKhau_QLBH";
            this.Text = "FrmDoiMatKhau_QLBH";
            this.Load += new System.EventHandler(this.FrmDoiMatKhau_QLBH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDoiMatKhau;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxOldPW;
        private System.Windows.Forms.TextBox textBoxNewPW;
        private System.Windows.Forms.TextBox textBoxNewPW2;
    }
}