namespace QuanLyThienNguyen.GUI
{
    partial class Activity_Form
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_GioiThieu = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.combobox_SapXep = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_SapXep = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.combobox_TimKiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.label_GioiThieu.Size = new System.Drawing.Size(438, 42);
            this.label_GioiThieu.TabIndex = 0;
            this.label_GioiThieu.Text = "Hoạt động thiện nguyện";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(993, 542);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.dataGridView);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(993, 442);
            this.guna2Panel4.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(993, 442);
            this.dataGridView.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.combobox_SapXep);
            this.guna2Panel3.Controls.Add(this.button_SapXep);
            this.guna2Panel3.Controls.Add(this.btn_TimKiem);
            this.guna2Panel3.Controls.Add(this.textbox_TimKiem);
            this.guna2Panel3.Controls.Add(this.combobox_TimKiem);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(993, 100);
            this.guna2Panel3.TabIndex = 0;
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
            this.combobox_SapXep.Items.AddRange(new object[] {
            "Tên đơn vị",
            "Họ tên chủ hộ",
            "Tên hình thức ủng hộ",
            "Số lượng ủng hộ",
            "Số lượng nhận ủng hộ",
            "Đơn vị tính",
            "Ngày bắt đầu",
            "Ngày kết thúc"});
            this.combobox_SapXep.Location = new System.Drawing.Point(732, 32);
            this.combobox_SapXep.Name = "combobox_SapXep";
            this.combobox_SapXep.Size = new System.Drawing.Size(140, 36);
            this.combobox_SapXep.TabIndex = 15;
            // 
            // button_SapXep
            // 
            this.button_SapXep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SapXep.AutoRoundedCorners = true;
            this.button_SapXep.BorderRadius = 17;
            this.button_SapXep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_SapXep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_SapXep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_SapXep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_SapXep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_SapXep.ForeColor = System.Drawing.Color.White;
            this.button_SapXep.Location = new System.Drawing.Point(878, 32);
            this.button_SapXep.Name = "button_SapXep";
            this.button_SapXep.Size = new System.Drawing.Size(103, 36);
            this.button_SapXep.TabIndex = 14;
            this.button_SapXep.Text = "Sắp xếp";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.AutoRoundedCorners = true;
            this.btn_TimKiem.BorderRadius = 17;
            this.btn_TimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(364, 32);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(103, 36);
            this.btn_TimKiem.TabIndex = 13;
            this.btn_TimKiem.Text = "Tìm kiếm";
            // 
            // textbox_TimKiem
            // 
            this.textbox_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_TimKiem.DefaultText = "";
            this.textbox_TimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_TimKiem.Location = new System.Drawing.Point(158, 32);
            this.textbox_TimKiem.Name = "textbox_TimKiem";
            this.textbox_TimKiem.PasswordChar = '\0';
            this.textbox_TimKiem.PlaceholderText = "";
            this.textbox_TimKiem.SelectedText = "";
            this.textbox_TimKiem.Size = new System.Drawing.Size(200, 36);
            this.textbox_TimKiem.TabIndex = 12;
            // 
            // combobox_TimKiem
            // 
            this.combobox_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.combobox_TimKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_TimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_TimKiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_TimKiem.ItemHeight = 30;
            this.combobox_TimKiem.Items.AddRange(new object[] {
            "All",
            "Đang diễn ra",
            "Đã diễn ra",
            "Sắp diễn ra"});
            this.combobox_TimKiem.Location = new System.Drawing.Point(12, 32);
            this.combobox_TimKiem.Name = "combobox_TimKiem";
            this.combobox_TimKiem.Size = new System.Drawing.Size(140, 36);
            this.combobox_TimKiem.StartIndex = 0;
            this.combobox_TimKiem.TabIndex = 11;
            // 
            // Activity_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 642);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Activity_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity_Form";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label_GioiThieu; 
        private Guna.UI2.WinForms.Guna2ComboBox combobox_SapXep;
        private Guna.UI2.WinForms.Guna2Button button_SapXep;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox textbox_TimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_TimKiem;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}