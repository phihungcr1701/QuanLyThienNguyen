namespace QuanLyThienNguyen.GUI.Admin
{
    partial class DUH_Form
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_GioiThieu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.datatimepicker_NgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datatimepicker_NgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.button_Huy = new Guna.UI2.WinForms.Guna2Button();
            this.button_ThucHien = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_MaDUH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_MaDUH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_NgayBatDau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_NgayKetThuc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.label_GioiThieu);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(784, 100);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label_GioiThieu
            // 
            this.label_GioiThieu.BackColor = System.Drawing.Color.Transparent;
            this.label_GioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GioiThieu.Location = new System.Drawing.Point(294, 28);
            this.label_GioiThieu.Name = "label_GioiThieu";
            this.label_GioiThieu.Size = new System.Drawing.Size(196, 44);
            this.label_GioiThieu.TabIndex = 0;
            this.label_GioiThieu.Text = "Đợt ủng hộ";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.datatimepicker_NgayKetThuc);
            this.guna2Panel3.Controls.Add(this.datatimepicker_NgayBatDau);
            this.guna2Panel3.Controls.Add(this.button_Huy);
            this.guna2Panel3.Controls.Add(this.button_ThucHien);
            this.guna2Panel3.Controls.Add(this.textbox_MaDUH);
            this.guna2Panel3.Controls.Add(this.label_MaDUH);
            this.guna2Panel3.Controls.Add(this.label_NgayBatDau);
            this.guna2Panel3.Controls.Add(this.label_NgayKetThuc);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(784, 264);
            this.guna2Panel3.TabIndex = 8;
            // 
            // datatimepicker_NgayKetThuc
            // 
            this.datatimepicker_NgayKetThuc.AutoRoundedCorners = true;
            this.datatimepicker_NgayKetThuc.BorderRadius = 17;
            this.datatimepicker_NgayKetThuc.Checked = true;
            this.datatimepicker_NgayKetThuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.datatimepicker_NgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datatimepicker_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datatimepicker_NgayKetThuc.Location = new System.Drawing.Point(510, 113);
            this.datatimepicker_NgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datatimepicker_NgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datatimepicker_NgayKetThuc.Name = "datatimepicker_NgayKetThuc";
            this.datatimepicker_NgayKetThuc.Size = new System.Drawing.Size(200, 36);
            this.datatimepicker_NgayKetThuc.TabIndex = 17;
            this.datatimepicker_NgayKetThuc.Value = new System.DateTime(2024, 5, 9, 9, 36, 38, 99);
            // 
            // datatimepicker_NgayBatDau
            // 
            this.datatimepicker_NgayBatDau.AutoRoundedCorners = true;
            this.datatimepicker_NgayBatDau.BorderRadius = 17;
            this.datatimepicker_NgayBatDau.Checked = true;
            this.datatimepicker_NgayBatDau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.datatimepicker_NgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datatimepicker_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datatimepicker_NgayBatDau.Location = new System.Drawing.Point(510, 35);
            this.datatimepicker_NgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datatimepicker_NgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datatimepicker_NgayBatDau.Name = "datatimepicker_NgayBatDau";
            this.datatimepicker_NgayBatDau.Size = new System.Drawing.Size(200, 36);
            this.datatimepicker_NgayBatDau.TabIndex = 16;
            this.datatimepicker_NgayBatDau.Value = new System.DateTime(2024, 5, 9, 9, 36, 38, 99);
            // 
            // button_Huy
            // 
            this.button_Huy.AutoRoundedCorners = true;
            this.button_Huy.BackColor = System.Drawing.Color.White;
            this.button_Huy.BorderRadius = 21;
            this.button_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Huy.ForeColor = System.Drawing.Color.White;
            this.button_Huy.Location = new System.Drawing.Point(443, 183);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(121, 45);
            this.button_Huy.TabIndex = 15;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_ThucHien
            // 
            this.button_ThucHien.AutoRoundedCorners = true;
            this.button_ThucHien.BackColor = System.Drawing.Color.White;
            this.button_ThucHien.BorderRadius = 21;
            this.button_ThucHien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_ThucHien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_ThucHien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_ThucHien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_ThucHien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_ThucHien.ForeColor = System.Drawing.Color.White;
            this.button_ThucHien.Location = new System.Drawing.Point(238, 183);
            this.button_ThucHien.Name = "button_ThucHien";
            this.button_ThucHien.Size = new System.Drawing.Size(121, 45);
            this.button_ThucHien.TabIndex = 14;
            this.button_ThucHien.Text = "Thực hiện";
            this.button_ThucHien.Click += new System.EventHandler(this.button_ThucHien_Click);
            // 
            // textbox_MaDUH
            // 
            this.textbox_MaDUH.AutoRoundedCorners = true;
            this.textbox_MaDUH.BorderRadius = 17;
            this.textbox_MaDUH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_MaDUH.DefaultText = "";
            this.textbox_MaDUH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_MaDUH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_MaDUH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_MaDUH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_MaDUH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_MaDUH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_MaDUH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_MaDUH.Location = new System.Drawing.Point(160, 35);
            this.textbox_MaDUH.Name = "textbox_MaDUH";
            this.textbox_MaDUH.PasswordChar = '\0';
            this.textbox_MaDUH.PlaceholderText = "";
            this.textbox_MaDUH.SelectedText = "";
            this.textbox_MaDUH.Size = new System.Drawing.Size(200, 36);
            this.textbox_MaDUH.TabIndex = 7;
            // 
            // label_MaDUH
            // 
            this.label_MaDUH.BackColor = System.Drawing.Color.Transparent;
            this.label_MaDUH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaDUH.Location = new System.Drawing.Point(64, 44);
            this.label_MaDUH.Name = "label_MaDUH";
            this.label_MaDUH.Size = new System.Drawing.Size(90, 18);
            this.label_MaDUH.TabIndex = 1;
            this.label_MaDUH.Text = "Mã đợt ủng hộ:";
            // 
            // label_NgayBatDau
            // 
            this.label_NgayBatDau.BackColor = System.Drawing.Color.Transparent;
            this.label_NgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayBatDau.Location = new System.Drawing.Point(417, 44);
            this.label_NgayBatDau.Name = "label_NgayBatDau";
            this.label_NgayBatDau.Size = new System.Drawing.Size(87, 18);
            this.label_NgayBatDau.TabIndex = 5;
            this.label_NgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // label_NgayKetThuc
            // 
            this.label_NgayKetThuc.BackColor = System.Drawing.Color.Transparent;
            this.label_NgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayKetThuc.Location = new System.Drawing.Point(417, 122);
            this.label_NgayKetThuc.Name = "label_NgayKetThuc";
            this.label_NgayKetThuc.Size = new System.Drawing.Size(87, 18);
            this.label_NgayKetThuc.TabIndex = 6;
            this.label_NgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // DUH_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 364);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "DUH_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUH_Form";
            this.Load += new System.EventHandler(this.DUH_Form_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_GioiThieu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button button_Huy;
        private Guna.UI2.WinForms.Guna2Button button_ThucHien;
        private Guna.UI2.WinForms.Guna2TextBox textbox_MaDUH;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_MaDUH;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_NgayBatDau;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_NgayKetThuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker datatimepicker_NgayKetThuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker datatimepicker_NgayBatDau;
    }
}