
namespace QuanLyBanHang
{
    partial class FrmDangNhap_QLBH
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
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.checkBoxSaveAcc = new System.Windows.Forms.CheckBox();
            this.labelForgotPW = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(125, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mật khẩu";
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(102, 235);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(174, 22);
            this.textBoxPW.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email đăng nhập";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(102, 151);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(174, 22);
            this.textBoxEmail.TabIndex = 0;
            // 
            // checkBoxSaveAcc
            // 
            this.checkBoxSaveAcc.AutoSize = true;
            this.checkBoxSaveAcc.Location = new System.Drawing.Point(49, 298);
            this.checkBoxSaveAcc.Name = "checkBoxSaveAcc";
            this.checkBoxSaveAcc.Size = new System.Drawing.Size(142, 21);
            this.checkBoxSaveAcc.TabIndex = 2;
            this.checkBoxSaveAcc.Text = "Ghi nhớ tài khoản";
            this.checkBoxSaveAcc.UseVisualStyleBackColor = true;
            this.checkBoxSaveAcc.CheckedChanged += new System.EventHandler(this.checkBoxSaveAcc_CheckedChanged);
            // 
            // labelForgotPW
            // 
            this.labelForgotPW.AutoSize = true;
            this.labelForgotPW.Location = new System.Drawing.Point(223, 298);
            this.labelForgotPW.MaximumSize = new System.Drawing.Size(113, 17);
            this.labelForgotPW.MinimumSize = new System.Drawing.Size(113, 17);
            this.labelForgotPW.Name = "labelForgotPW";
            this.labelForgotPW.Size = new System.Drawing.Size(113, 17);
            this.labelForgotPW.TabIndex = 3;
            this.labelForgotPW.Text = "Quên mật khẩu ";
            this.labelForgotPW.Click += new System.EventHandler(this.labelForgotPW_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(141, 335);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(102, 40);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(153, 381);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 29);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Thoát";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FrmDangNhap_QLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelForgotPW);
            this.Controls.Add(this.checkBoxSaveAcc);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "FrmDangNhap_QLBH";
            this.Text = "FrmDangNhap_QLBH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDangNhap_QLBH_FormClosed);
            this.Load += new System.EventHandler(this.FrmDangNhap_QLBH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.CheckBox checkBoxSaveAcc;
        private System.Windows.Forms.Label labelForgotPW;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonClose;
    }
}