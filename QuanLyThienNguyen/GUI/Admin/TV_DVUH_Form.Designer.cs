﻿namespace QuanLyThienNguyen.GUI.Admin
{
    partial class TV_DVUH_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combobox_MaDVUH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_Huy = new Guna.UI2.WinForms.Guna2Button();
            this.button_ThucHien = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.textbox_DiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupbox_GioiTinh = new System.Windows.Forms.GroupBox();
            this.radiobutton_Nu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radiobutton_Nam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.textbox_CCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_MaDVUH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textbox_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_DiaChi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_SDT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_CCCD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_HoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupbox_GioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.label_GioiThieu);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(993, 100);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label_GioiThieu
            // 
            this.label_GioiThieu.BackColor = System.Drawing.Color.Transparent;
            this.label_GioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GioiThieu.Location = new System.Drawing.Point(397, 28);
            this.label_GioiThieu.Name = "label_GioiThieu";
            this.label_GioiThieu.Size = new System.Drawing.Size(199, 44);
            this.label_GioiThieu.TabIndex = 0;
            this.label_GioiThieu.Text = "Thành viên";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.dataGridView1);
            this.guna2Panel3.Controls.Add(this.combobox_MaDVUH);
            this.guna2Panel3.Controls.Add(this.button_Huy);
            this.guna2Panel3.Controls.Add(this.button_ThucHien);
            this.guna2Panel3.Controls.Add(this.textbox_SDT);
            this.guna2Panel3.Controls.Add(this.textbox_DiaChi);
            this.guna2Panel3.Controls.Add(this.groupbox_GioiTinh);
            this.guna2Panel3.Controls.Add(this.textbox_CCCD);
            this.guna2Panel3.Controls.Add(this.label_MaDVUH);
            this.guna2Panel3.Controls.Add(this.textbox_HoTen);
            this.guna2Panel3.Controls.Add(this.label_DiaChi);
            this.guna2Panel3.Controls.Add(this.label_SDT);
            this.guna2Panel3.Controls.Add(this.label_CCCD);
            this.guna2Panel3.Controls.Add(this.label_HoTen);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(993, 364);
            this.guna2Panel3.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(727, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 211);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Thuộc tính";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Giá trị";
            this.Column2.Name = "Column2";
            // 
            // combobox_MaDVUH
            // 
            this.combobox_MaDVUH.AutoRoundedCorners = true;
            this.combobox_MaDVUH.BackColor = System.Drawing.Color.Transparent;
            this.combobox_MaDVUH.BorderRadius = 17;
            this.combobox_MaDVUH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_MaDVUH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_MaDVUH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_MaDVUH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_MaDVUH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_MaDVUH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_MaDVUH.ItemHeight = 30;
            this.combobox_MaDVUH.Location = new System.Drawing.Point(160, 35);
            this.combobox_MaDVUH.Name = "combobox_MaDVUH";
            this.combobox_MaDVUH.Size = new System.Drawing.Size(200, 36);
            this.combobox_MaDVUH.TabIndex = 16;
            this.combobox_MaDVUH.SelectedIndexChanged += new System.EventHandler(this.combobox_MaDVUH_SelectedIndexChanged);
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
            this.button_Huy.Location = new System.Drawing.Point(542, 262);
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
            this.button_ThucHien.Location = new System.Drawing.Point(330, 262);
            this.button_ThucHien.Name = "button_ThucHien";
            this.button_ThucHien.Size = new System.Drawing.Size(121, 45);
            this.button_ThucHien.TabIndex = 14;
            this.button_ThucHien.Text = "Thực hiện";
            this.button_ThucHien.Click += new System.EventHandler(this.button_ThucHien_Click);
            // 
            // textbox_SDT
            // 
            this.textbox_SDT.AutoRoundedCorners = true;
            this.textbox_SDT.BorderRadius = 17;
            this.textbox_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_SDT.DefaultText = "";
            this.textbox_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_SDT.Location = new System.Drawing.Point(502, 191);
            this.textbox_SDT.MaxLength = 10;
            this.textbox_SDT.Name = "textbox_SDT";
            this.textbox_SDT.PasswordChar = '\0';
            this.textbox_SDT.PlaceholderText = "";
            this.textbox_SDT.SelectedText = "";
            this.textbox_SDT.Size = new System.Drawing.Size(200, 36);
            this.textbox_SDT.TabIndex = 13;
            // 
            // textbox_DiaChi
            // 
            this.textbox_DiaChi.AutoRoundedCorners = true;
            this.textbox_DiaChi.BorderRadius = 17;
            this.textbox_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_DiaChi.DefaultText = "";
            this.textbox_DiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_DiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_DiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_DiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_DiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_DiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_DiaChi.Location = new System.Drawing.Point(502, 113);
            this.textbox_DiaChi.Name = "textbox_DiaChi";
            this.textbox_DiaChi.PasswordChar = '\0';
            this.textbox_DiaChi.PlaceholderText = "";
            this.textbox_DiaChi.SelectedText = "";
            this.textbox_DiaChi.Size = new System.Drawing.Size(200, 36);
            this.textbox_DiaChi.TabIndex = 12;
            // 
            // groupbox_GioiTinh
            // 
            this.groupbox_GioiTinh.Controls.Add(this.radiobutton_Nu);
            this.groupbox_GioiTinh.Controls.Add(this.radiobutton_Nam);
            this.groupbox_GioiTinh.Location = new System.Drawing.Point(502, 16);
            this.groupbox_GioiTinh.Name = "groupbox_GioiTinh";
            this.groupbox_GioiTinh.Size = new System.Drawing.Size(163, 70);
            this.groupbox_GioiTinh.TabIndex = 11;
            this.groupbox_GioiTinh.TabStop = false;
            this.groupbox_GioiTinh.Text = "Giới tính";
            // 
            // radiobutton_Nu
            // 
            this.radiobutton_Nu.AutoSize = true;
            this.radiobutton_Nu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiobutton_Nu.CheckedState.BorderThickness = 0;
            this.radiobutton_Nu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiobutton_Nu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radiobutton_Nu.CheckedState.InnerOffset = -4;
            this.radiobutton_Nu.Location = new System.Drawing.Point(97, 29);
            this.radiobutton_Nu.Name = "radiobutton_Nu";
            this.radiobutton_Nu.Size = new System.Drawing.Size(37, 17);
            this.radiobutton_Nu.TabIndex = 3;
            this.radiobutton_Nu.Text = "nữ";
            this.radiobutton_Nu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radiobutton_Nu.UncheckedState.BorderThickness = 2;
            this.radiobutton_Nu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radiobutton_Nu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radiobutton_Nam
            // 
            this.radiobutton_Nam.AutoSize = true;
            this.radiobutton_Nam.Checked = true;
            this.radiobutton_Nam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiobutton_Nam.CheckedState.BorderThickness = 0;
            this.radiobutton_Nam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiobutton_Nam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radiobutton_Nam.CheckedState.InnerOffset = -4;
            this.radiobutton_Nam.Location = new System.Drawing.Point(23, 29);
            this.radiobutton_Nam.Name = "radiobutton_Nam";
            this.radiobutton_Nam.Size = new System.Drawing.Size(45, 17);
            this.radiobutton_Nam.TabIndex = 2;
            this.radiobutton_Nam.TabStop = true;
            this.radiobutton_Nam.Text = "nam";
            this.radiobutton_Nam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radiobutton_Nam.UncheckedState.BorderThickness = 2;
            this.radiobutton_Nam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radiobutton_Nam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // textbox_CCCD
            // 
            this.textbox_CCCD.AutoRoundedCorners = true;
            this.textbox_CCCD.BorderRadius = 17;
            this.textbox_CCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_CCCD.DefaultText = "";
            this.textbox_CCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_CCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_CCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_CCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_CCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_CCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_CCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_CCCD.Location = new System.Drawing.Point(160, 191);
            this.textbox_CCCD.MaxLength = 12;
            this.textbox_CCCD.Name = "textbox_CCCD";
            this.textbox_CCCD.PasswordChar = '\0';
            this.textbox_CCCD.PlaceholderText = "";
            this.textbox_CCCD.SelectedText = "";
            this.textbox_CCCD.Size = new System.Drawing.Size(200, 36);
            this.textbox_CCCD.TabIndex = 10;
            // 
            // label_MaDVUH
            // 
            this.label_MaDVUH.BackColor = System.Drawing.Color.Transparent;
            this.label_MaDVUH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaDVUH.Location = new System.Drawing.Point(47, 44);
            this.label_MaDVUH.Name = "label_MaDVUH";
            this.label_MaDVUH.Size = new System.Drawing.Size(107, 18);
            this.label_MaDVUH.TabIndex = 1;
            this.label_MaDVUH.Text = "Mã đơn vị ủng hộ:";
            // 
            // textbox_HoTen
            // 
            this.textbox_HoTen.AutoRoundedCorners = true;
            this.textbox_HoTen.BorderRadius = 17;
            this.textbox_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_HoTen.DefaultText = "";
            this.textbox_HoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_HoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_HoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_HoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_HoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_HoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_HoTen.Location = new System.Drawing.Point(160, 113);
            this.textbox_HoTen.Name = "textbox_HoTen";
            this.textbox_HoTen.PasswordChar = '\0';
            this.textbox_HoTen.PlaceholderText = "";
            this.textbox_HoTen.SelectedText = "";
            this.textbox_HoTen.Size = new System.Drawing.Size(200, 36);
            this.textbox_HoTen.TabIndex = 9;
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.BackColor = System.Drawing.Color.Transparent;
            this.label_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiaChi.Location = new System.Drawing.Point(450, 122);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(46, 18);
            this.label_DiaChi.TabIndex = 5;
            this.label_DiaChi.Text = "Địa chỉ:";
            // 
            // label_SDT
            // 
            this.label_SDT.BackColor = System.Drawing.Color.Transparent;
            this.label_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SDT.Location = new System.Drawing.Point(412, 200);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(84, 18);
            this.label_SDT.TabIndex = 6;
            this.label_SDT.Text = "Số điện thoại:";
            // 
            // label_CCCD
            // 
            this.label_CCCD.BackColor = System.Drawing.Color.Transparent;
            this.label_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CCCD.Location = new System.Drawing.Point(33, 200);
            this.label_CCCD.Name = "label_CCCD";
            this.label_CCCD.Size = new System.Drawing.Size(121, 18);
            this.label_CCCD.TabIndex = 3;
            this.label_CCCD.Text = "Căn cước công dân:";
            // 
            // label_HoTen
            // 
            this.label_HoTen.BackColor = System.Drawing.Color.Transparent;
            this.label_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HoTen.Location = new System.Drawing.Point(46, 122);
            this.label_HoTen.Name = "label_HoTen";
            this.label_HoTen.Size = new System.Drawing.Size(108, 18);
            this.label_HoTen.TabIndex = 2;
            this.label_HoTen.Text = "Họ tên thành viên:";
            // 
            // TV_DVUH_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 464);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TV_DVUH_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TV_DVUH_Form";
            this.Load += new System.EventHandler(this.TV_DVUH_Form_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupbox_GioiTinh.ResumeLayout(false);
            this.groupbox_GioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_GioiThieu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button button_Huy;
        private Guna.UI2.WinForms.Guna2Button button_ThucHien;
        private Guna.UI2.WinForms.Guna2TextBox textbox_SDT;
        private Guna.UI2.WinForms.Guna2TextBox textbox_DiaChi;
        private System.Windows.Forms.GroupBox groupbox_GioiTinh;
        private Guna.UI2.WinForms.Guna2RadioButton radiobutton_Nu;
        private Guna.UI2.WinForms.Guna2RadioButton radiobutton_Nam;
        private Guna.UI2.WinForms.Guna2TextBox textbox_CCCD;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_MaDVUH;
        private Guna.UI2.WinForms.Guna2TextBox textbox_HoTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_DiaChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_SDT;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_CCCD;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_HoTen;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_MaDVUH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}