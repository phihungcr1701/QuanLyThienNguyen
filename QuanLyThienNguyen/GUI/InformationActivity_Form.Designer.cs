namespace QuanLyThienNguyen.GUI
{
    partial class InformationActivity_Form
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnActivity = new Guna.UI2.WinForms.Guna2Panel();
            this.pnText = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNameDVUH = new System.Windows.Forms.Label();
            this.lbNameActivity = new System.Windows.Forms.Label();
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            this.pictureActivity = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnActivity.SuspendLayout();
            this.pnText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pnActivity);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(993, 642);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnActivity
            // 
            this.pnActivity.Controls.Add(this.pnText);
            this.pnActivity.Controls.Add(this.btnShow);
            this.pnActivity.Controls.Add(this.pictureActivity);
            this.pnActivity.Location = new System.Drawing.Point(20, 20);
            this.pnActivity.Margin = new System.Windows.Forms.Padding(20);
            this.pnActivity.Name = "pnActivity";
            this.pnActivity.Size = new System.Drawing.Size(238, 300);
            this.pnActivity.TabIndex = 1;
            // 
            // pnText
            // 
            this.pnText.Controls.Add(this.lbNameDVUH);
            this.pnText.Controls.Add(this.lbNameActivity);
            this.pnText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnText.Location = new System.Drawing.Point(0, 144);
            this.pnText.Name = "pnText";
            this.pnText.Size = new System.Drawing.Size(238, 120);
            this.pnText.TabIndex = 3;
            // 
            // lbNameDVUH
            // 
            this.lbNameDVUH.AutoSize = true;
            this.lbNameDVUH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNameDVUH.Location = new System.Drawing.Point(0, 42);
            this.lbNameDVUH.Name = "lbNameDVUH";
            this.lbNameDVUH.Size = new System.Drawing.Size(77, 13);
            this.lbNameDVUH.TabIndex = 1;
            this.lbNameDVUH.Text = "Đơn vị ủng hộ:";
            // 
            // lbNameActivity
            // 
            this.lbNameActivity.AutoSize = true;
            this.lbNameActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNameActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameActivity.Location = new System.Drawing.Point(0, 0);
            this.lbNameActivity.Name = "lbNameActivity";
            this.lbNameActivity.Size = new System.Drawing.Size(221, 42);
            this.lbNameActivity.TabIndex = 0;
            this.lbNameActivity.Text = "Hành trình nhân đạo - Trao \r\nnhận yêu thương\r\n";
            // 
            // btnShow
            // 
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(0, 264);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(238, 36);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Xem hoạt động";
            // 
            // pictureActivity
            // 
            this.pictureActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureActivity.Image = global::QuanLyThienNguyen.Properties.Resources.logo_thiennguyen;
            this.pictureActivity.ImageRotate = 0F;
            this.pictureActivity.Location = new System.Drawing.Point(0, 0);
            this.pictureActivity.Name = "pictureActivity";
            this.pictureActivity.Size = new System.Drawing.Size(238, 144);
            this.pictureActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureActivity.TabIndex = 1;
            this.pictureActivity.TabStop = false;
            // 
            // InformationActivity_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 642);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationActivity_Form";
            this.Text = "InformationActivity_Form";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnActivity.ResumeLayout(false);
            this.pnText.ResumeLayout(false);
            this.pnText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnActivity;
        private Guna.UI2.WinForms.Guna2Panel pnText;
        private Guna.UI2.WinForms.Guna2Button btnShow;
        private Guna.UI2.WinForms.Guna2PictureBox pictureActivity;
        private System.Windows.Forms.Label lbNameDVUH;
        private System.Windows.Forms.Label lbNameActivity;
        public void addActivity(string linkPicture, string nameActivity, string nameDVUH)
        {
            Guna.UI2.WinForms.Guna2Panel pnActivity = new Guna.UI2.WinForms.Guna2Panel();
            Guna.UI2.WinForms.Guna2Panel pnText= new Guna.UI2.WinForms.Guna2Panel();
            Guna.UI2.WinForms.Guna2Button btnShow = new Guna.UI2.WinForms.Guna2Button();
            Guna.UI2.WinForms.Guna2PictureBox pictureActivity = new Guna.UI2.WinForms.Guna2PictureBox();
            System.Windows.Forms.Label lbNameDVUH = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbNameActivity = new System.Windows.Forms.Label();

            pnActivity.Controls.Add(this.pnText);
            pnActivity.Controls.Add(this.btnShow);
            pnActivity.Controls.Add(this.pictureActivity);
            pnActivity.Location = new System.Drawing.Point(20, 20);
            pnActivity.Margin = new System.Windows.Forms.Padding(20);
            pnActivity.Name = "pnActivity";
            pnActivity.Size = new System.Drawing.Size(238, 300);
            pnActivity.TabIndex = 1;

            pictureActivity.Dock = System.Windows.Forms.DockStyle.Top;
            pictureActivity.Image = global::QuanLyThienNguyen.Properties.Resources.logo_thiennguyen;
            pictureActivity.ImageRotate = 0F;
            pictureActivity.Location = new System.Drawing.Point(0, 0);
            pictureActivity.Name = "pictureActivity";
            pictureActivity.Size = new System.Drawing.Size(238, 144);
            pictureActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureActivity.TabIndex = 1;
            pictureActivity.TabStop = false;

            btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnShow.ForeColor = System.Drawing.Color.White;
            btnShow.Location = new System.Drawing.Point(0, 264);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(238, 36);
            btnShow.TabIndex = 2;
            btnShow.Text = "Xem hoạt động";

            pnText.Controls.Add(this.lbNameDVUH);
            pnText.Controls.Add(this.lbNameActivity);
            pnText.Dock = System.Windows.Forms.DockStyle.Fill;
            pnText.Location = new System.Drawing.Point(0, 144);
            pnText.Name = "pnText";
            pnText.Size = new System.Drawing.Size(238, 120);
            pnText.TabIndex = 3;
            // 
            // lbNameActivity
            // 
            lbNameActivity.AutoSize = true;
            lbNameActivity.Dock = System.Windows.Forms.DockStyle.Top;
            lbNameActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbNameActivity.Location = new System.Drawing.Point(0, 0);
            lbNameActivity.Name = "lbNameActivity";
            lbNameActivity.Size = new System.Drawing.Size(221, 42);
            lbNameActivity.TabIndex = 0;
            lbNameActivity.Text = "Hành trình nhân đạo - Trao \r\nnhận yêu thương\r\n";

            // 
            // lbNameDVUH
            // 
            lbNameDVUH.AutoSize = true;
            lbNameDVUH.Dock = System.Windows.Forms.DockStyle.Fill;
            lbNameDVUH.Location = new System.Drawing.Point(0, 42);
            lbNameDVUH.Name = "lbNameDVUH";
            lbNameDVUH.Size = new System.Drawing.Size(77, 13);
            lbNameDVUH.TabIndex = 1;
            lbNameDVUH.Text = "Đơn vị ủng hộ:";
        }
    }
}