﻿namespace QuanLyThienNguyen.GUI
{
    partial class Information_Form_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_GioiThieu = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.button_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.combobox_SapXep = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_CapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Them = new Guna.UI2.WinForms.Guna2Button();
            this.combobox_TimKiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label_GioiThieu);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(993, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label_GioiThieu
            // 
            this.label_GioiThieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_GioiThieu.AutoSize = true;
            this.label_GioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GioiThieu.Location = new System.Drawing.Point(277, 29);
            this.label_GioiThieu.Name = "label_GioiThieu";
            this.label_GioiThieu.Size = new System.Drawing.Size(421, 42);
            this.label_GioiThieu.TabIndex = 1;
            this.label_GioiThieu.Text = "Thông tin thiện nguyện";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.panel1);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(993, 542);
            this.guna2Panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 442);
            this.panel1.TabIndex = 1;
            // 
            // datagridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview.Location = new System.Drawing.Point(0, 0);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.Size = new System.Drawing.Size(993, 442);
            this.datagridview.TabIndex = 1;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.datagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridview.ThemeStyle.HeaderStyle.Height = 30;
            this.datagridview.ThemeStyle.ReadOnly = true;
            this.datagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview.ThemeStyle.RowsStyle.Height = 22;
            this.datagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.button_Xoa);
            this.guna2Panel3.Controls.Add(this.combobox_SapXep);
            this.guna2Panel3.Controls.Add(this.button_CapNhat);
            this.guna2Panel3.Controls.Add(this.textbox_TimKiem);
            this.guna2Panel3.Controls.Add(this.button_Them);
            this.guna2Panel3.Controls.Add(this.combobox_TimKiem);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(993, 100);
            this.guna2Panel3.TabIndex = 0;
            // 
            // button_Xoa
            // 
            this.button_Xoa.AutoRoundedCorners = true;
            this.button_Xoa.BorderRadius = 21;
            this.button_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(249, 28);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(103, 45);
            this.button_Xoa.TabIndex = 11;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // combobox_SapXep
            // 
            this.combobox_SapXep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_SapXep.BackColor = System.Drawing.Color.Transparent;
            this.combobox_SapXep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_SapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_SapXep.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_SapXep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_SapXep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_SapXep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_SapXep.ItemHeight = 30;
            this.combobox_SapXep.Location = new System.Drawing.Point(841, 32);
            this.combobox_SapXep.Name = "combobox_SapXep";
            this.combobox_SapXep.Size = new System.Drawing.Size(140, 36);
            this.combobox_SapXep.TabIndex = 10;
            this.combobox_SapXep.SelectedIndexChanged += new System.EventHandler(this.combobox_SapXep_SelectedIndexChanged);
            // 
            // button_CapNhat
            // 
            this.button_CapNhat.AutoRoundedCorners = true;
            this.button_CapNhat.BorderRadius = 21;
            this.button_CapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_CapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_CapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_CapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_CapNhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_CapNhat.ForeColor = System.Drawing.Color.White;
            this.button_CapNhat.Location = new System.Drawing.Point(130, 28);
            this.button_CapNhat.Name = "button_CapNhat";
            this.button_CapNhat.Size = new System.Drawing.Size(103, 45);
            this.button_CapNhat.TabIndex = 10;
            this.button_CapNhat.Text = "Cập nhật";
            this.button_CapNhat.Click += new System.EventHandler(this.button_CapNhat_Click);
            // 
            // textbox_TimKiem
            // 
            this.textbox_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_TimKiem.DefaultText = "";
            this.textbox_TimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_TimKiem.Location = new System.Drawing.Point(489, 32);
            this.textbox_TimKiem.Name = "textbox_TimKiem";
            this.textbox_TimKiem.PasswordChar = '\0';
            this.textbox_TimKiem.PlaceholderText = "";
            this.textbox_TimKiem.SelectedText = "";
            this.textbox_TimKiem.Size = new System.Drawing.Size(200, 36);
            this.textbox_TimKiem.TabIndex = 7;
            this.textbox_TimKiem.TextChanged += new System.EventHandler(this.textbox_TimKiem_TextChanged);
            // 
            // button_Them
            // 
            this.button_Them.AutoRoundedCorners = true;
            this.button_Them.BorderRadius = 21;
            this.button_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Them.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Them.ForeColor = System.Drawing.Color.White;
            this.button_Them.Location = new System.Drawing.Point(12, 28);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(103, 45);
            this.button_Them.TabIndex = 9;
            this.button_Them.Text = "Thêm";
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // combobox_TimKiem
            // 
            this.combobox_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.combobox_TimKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_TimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_TimKiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_TimKiem.ItemHeight = 30;
            this.combobox_TimKiem.Items.AddRange(new object[] {
            "Đơn vị ủng hộ",
            "Thành viên đơn vị ủng hộ",
            "Hộ dân",
            "Đợt ủng hộ",
            "Hình thức ủng hộ"});
            this.combobox_TimKiem.Location = new System.Drawing.Point(695, 32);
            this.combobox_TimKiem.Name = "combobox_TimKiem";
            this.combobox_TimKiem.Size = new System.Drawing.Size(140, 36);
            this.combobox_TimKiem.TabIndex = 5;
            this.combobox_TimKiem.SelectedIndexChanged += new System.EventHandler(this.combobox_TimKiem_SelectedIndexChanged);
            // 
            // Information_Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 642);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Information_Form_Admin";
            this.Text = "Information_Form_Admin";
            this.Load += new System.EventHandler(this.Information_Form_Admin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_GioiThieu;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_SapXep;
        private Guna.UI2.WinForms.Guna2TextBox textbox_TimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_TimKiem;
        private Guna.UI2.WinForms.Guna2Button button_Xoa;
        private Guna.UI2.WinForms.Guna2Button button_CapNhat;
        private Guna.UI2.WinForms.Guna2Button button_Them;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
    }
}