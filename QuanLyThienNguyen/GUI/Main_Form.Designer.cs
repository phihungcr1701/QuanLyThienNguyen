namespace QuanLyThienNguyen.GUI
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChiTiet = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.labelUser = new System.Windows.Forms.Label();
            this.button_ThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.button_ThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.button_HoatDong = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHome = new Guna.UI2.WinForms.Guna2Button();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.panelInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNgayThang = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelLeft.Controls.Add(this.btnChiTiet);
            this.panelLeft.Controls.Add(this.guna2ImageButton1);
            this.panelLeft.Controls.Add(this.labelUser);
            this.panelLeft.Controls.Add(this.button_ThongKe);
            this.panelLeft.Controls.Add(this.button_ThongTin);
            this.panelLeft.Controls.Add(this.btnLogin);
            this.panelLeft.Controls.Add(this.button_HoatDong);
            this.panelLeft.Controls.Add(this.buttonHome);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(199, 664);
            this.panelLeft.TabIndex = 0;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.AutoRoundedCorners = true;
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnChiTiet.BorderRadius = 20;
            this.btnChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnChiTiet.HoverState.FillColor = System.Drawing.Color.White;
            this.btnChiTiet.HoverState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnChiTiet.Location = new System.Drawing.Point(-21, 392);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.PressedColor = System.Drawing.Color.White;
            this.btnChiTiet.Size = new System.Drawing.Size(170, 42);
            this.btnChiTiet.TabIndex = 5;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.Visible = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::QuanLyThienNguyen.Properties.Resources.logo_User;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(3, 5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(63, 54);
            this.guna2ImageButton1.TabIndex = 8;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(62, 22);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(99, 20);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Chào User!";
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.AutoRoundedCorners = true;
            this.button_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_ThongKe.BorderRadius = 20;
            this.button_ThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_ThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_ThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_ThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_ThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_ThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_ThongKe.ForeColor = System.Drawing.Color.Black;
            this.button_ThongKe.HoverState.FillColor = System.Drawing.Color.White;
            this.button_ThongKe.HoverState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_ThongKe.Location = new System.Drawing.Point(-21, 328);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.PressedColor = System.Drawing.Color.White;
            this.button_ThongKe.Size = new System.Drawing.Size(170, 42);
            this.button_ThongKe.TabIndex = 4;
            this.button_ThongKe.Text = "Thống kê";
            this.button_ThongKe.Click += new System.EventHandler(this.button_ThongKe_Click);
            // 
            // button_ThongTin
            // 
            this.button_ThongTin.AutoRoundedCorners = true;
            this.button_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_ThongTin.BorderRadius = 20;
            this.button_ThongTin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_ThongTin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_ThongTin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_ThongTin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_ThongTin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_ThongTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_ThongTin.ForeColor = System.Drawing.Color.Black;
            this.button_ThongTin.HoverState.FillColor = System.Drawing.Color.White;
            this.button_ThongTin.HoverState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_ThongTin.Location = new System.Drawing.Point(-21, 261);
            this.button_ThongTin.Name = "button_ThongTin";
            this.button_ThongTin.PressedColor = System.Drawing.Color.White;
            this.button_ThongTin.Size = new System.Drawing.Size(170, 42);
            this.button_ThongTin.TabIndex = 3;
            this.button_ThongTin.Text = "Thông tin";
            this.button_ThongTin.Click += new System.EventHandler(this.button_ThongTin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLogin.Location = new System.Drawing.Point(-21, 564);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.White;
            this.btnLogin.Size = new System.Drawing.Size(170, 42);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_HoatDong
            // 
            this.button_HoatDong.AutoRoundedCorners = true;
            this.button_HoatDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_HoatDong.BorderRadius = 20;
            this.button_HoatDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_HoatDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_HoatDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_HoatDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_HoatDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_HoatDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_HoatDong.ForeColor = System.Drawing.Color.Black;
            this.button_HoatDong.HoverState.FillColor = System.Drawing.Color.White;
            this.button_HoatDong.HoverState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_HoatDong.Location = new System.Drawing.Point(-21, 194);
            this.button_HoatDong.Name = "button_HoatDong";
            this.button_HoatDong.PressedColor = System.Drawing.Color.White;
            this.button_HoatDong.Size = new System.Drawing.Size(170, 42);
            this.button_HoatDong.TabIndex = 2;
            this.button_HoatDong.Text = "Hoạt động";
            this.button_HoatDong.Click += new System.EventHandler(this.button_HoatDong_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AutoRoundedCorners = true;
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonHome.BorderRadius = 20;
            this.buttonHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHome.ForeColor = System.Drawing.Color.Black;
            this.buttonHome.HoverState.FillColor = System.Drawing.Color.White;
            this.buttonHome.HoverState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonHome.Location = new System.Drawing.Point(-21, 127);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.PressedColor = System.Drawing.Color.White;
            this.buttonHome.Size = new System.Drawing.Size(170, 42);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Trang chủ";
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.panelChildForm);
            this.panelRight.Controls.Add(this.panelInformation);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(199, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(993, 664);
            this.panelRight.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 22);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(993, 642);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelInformation.BorderColor = System.Drawing.Color.White;
            this.panelInformation.Controls.Add(this.labelNgayThang);
            this.panelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInformation.Location = new System.Drawing.Point(0, 0);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(993, 22);
            this.panelInformation.TabIndex = 0;
            // 
            // labelNgayThang
            // 
            this.labelNgayThang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNgayThang.AutoSize = true;
            this.labelNgayThang.Location = new System.Drawing.Point(847, 5);
            this.labelNgayThang.Name = "labelNgayThang";
            this.labelNgayThang.Size = new System.Drawing.Size(85, 13);
            this.labelNgayThang.TabIndex = 0;
            this.labelNgayThang.Text = "labelNgayThang";
            this.labelNgayThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 664);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1208, 703);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoạt động thiện nguyện";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        private Guna.UI2.WinForms.Guna2Button buttonHome;
        private Guna.UI2.WinForms.Guna2Panel panelInformation;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button button_ThongKe;
        private Guna.UI2.WinForms.Guna2Button button_HoatDong;
        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private Guna.UI2.WinForms.Guna2Button button_ThongTin;
        private System.Windows.Forms.Label labelNgayThang;
        private System.Windows.Forms.Label labelUser;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button btnChiTiet;
    }
}