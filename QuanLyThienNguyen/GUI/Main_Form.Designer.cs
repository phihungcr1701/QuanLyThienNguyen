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
            this.button_Login = new Guna.UI2.WinForms.Guna2Button();
            this.button_ThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.button_HoatDong = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHome = new Guna.UI2.WinForms.Guna2Button();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.panelInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelLeft.Controls.Add(this.button_Login);
            this.panelLeft.Controls.Add(this.button_ThongKe);
            this.panelLeft.Controls.Add(this.button_HoatDong);
            this.panelLeft.Controls.Add(this.buttonHome);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(199, 664);
            this.panelLeft.TabIndex = 0;
            // 
            // button_Login
            // 
            this.button_Login.AutoRoundedCorners = true;
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_Login.BorderRadius = 20;
            this.button_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.button_Login.Location = new System.Drawing.Point(12, 395);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(170, 42);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "Đăng nhập";
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
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
            this.button_ThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button_ThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_ThongKe.ForeColor = System.Drawing.Color.White;
            this.button_ThongKe.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.button_ThongKe.Location = new System.Drawing.Point(12, 249);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(170, 42);
            this.button_ThongKe.TabIndex = 4;
            this.button_ThongKe.Text = "Thống kê";
            this.button_ThongKe.Click += new System.EventHandler(this.button_ThongKe_Click);
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
            this.button_HoatDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button_HoatDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_HoatDong.ForeColor = System.Drawing.Color.White;
            this.button_HoatDong.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.button_HoatDong.Location = new System.Drawing.Point(12, 181);
            this.button_HoatDong.Name = "button_HoatDong";
            this.button_HoatDong.Size = new System.Drawing.Size(170, 42);
            this.button_HoatDong.TabIndex = 3;
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
            this.buttonHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.buttonHome.Location = new System.Drawing.Point(12, 113);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(170, 42);
            this.buttonHome.TabIndex = 2;
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
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 22);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(993, 642);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInformation.Location = new System.Drawing.Point(0, 0);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(993, 22);
            this.panelInformation.TabIndex = 0;
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
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        private Guna.UI2.WinForms.Guna2Button buttonHome;
        private Guna.UI2.WinForms.Guna2Panel panelInformation;
        private Guna.UI2.WinForms.Guna2Button button_Login;
        private Guna.UI2.WinForms.Guna2Button button_ThongKe;
        private Guna.UI2.WinForms.Guna2Button button_HoatDong;
        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
    }
}