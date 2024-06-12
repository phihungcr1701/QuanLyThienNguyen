namespace QuanLyThienNguyen.GUI
{
    partial class TK_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_GioiThieu = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.combobox_LoaiThongKe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combobox_Chart = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combobox_TenHTUH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label_GioiThieu);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(993, 100);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label_GioiThieu
            // 
            this.label_GioiThieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_GioiThieu.AutoSize = true;
            this.label_GioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GioiThieu.Location = new System.Drawing.Point(405, 29);
            this.label_GioiThieu.Name = "label_GioiThieu";
            this.label_GioiThieu.Size = new System.Drawing.Size(183, 42);
            this.label_GioiThieu.TabIndex = 0;
            this.label_GioiThieu.Text = "Thống kê";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.combobox_LoaiThongKe);
            this.guna2Panel3.Controls.Add(this.combobox_Chart);
            this.guna2Panel3.Controls.Add(this.combobox_TenHTUH);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(993, 100);
            this.guna2Panel3.TabIndex = 2;
            // 
            // combobox_LoaiThongKe
            // 
            this.combobox_LoaiThongKe.AutoRoundedCorners = true;
            this.combobox_LoaiThongKe.BackColor = System.Drawing.Color.Transparent;
            this.combobox_LoaiThongKe.BorderRadius = 17;
            this.combobox_LoaiThongKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_LoaiThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_LoaiThongKe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_LoaiThongKe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_LoaiThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_LoaiThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_LoaiThongKe.ItemHeight = 30;
            this.combobox_LoaiThongKe.Items.AddRange(new object[] {
            "Tổng số lượng ủng hộ",
            "Số dư ủng hộ"});
            this.combobox_LoaiThongKe.Location = new System.Drawing.Point(197, 32);
            this.combobox_LoaiThongKe.Name = "combobox_LoaiThongKe";
            this.combobox_LoaiThongKe.Size = new System.Drawing.Size(212, 36);
            this.combobox_LoaiThongKe.TabIndex = 19;
            this.combobox_LoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.combobox_LoaiThongKe_SelectedIndexChanged);
            // 
            // combobox_Chart
            // 
            this.combobox_Chart.AutoRoundedCorners = true;
            this.combobox_Chart.BackColor = System.Drawing.Color.Transparent;
            this.combobox_Chart.BorderRadius = 17;
            this.combobox_Chart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_Chart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_Chart.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_Chart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_Chart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_Chart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_Chart.ItemHeight = 30;
            this.combobox_Chart.Items.AddRange(new object[] {
            "Column ",
            "Pie ",
            "Bar ",
            "Line"});
            this.combobox_Chart.Location = new System.Drawing.Point(20, 32);
            this.combobox_Chart.Name = "combobox_Chart";
            this.combobox_Chart.Size = new System.Drawing.Size(171, 36);
            this.combobox_Chart.TabIndex = 18;
            this.combobox_Chart.SelectedIndexChanged += new System.EventHandler(this.combobox_Chart_SelectedIndexChanged);
            // 
            // combobox_TenHTUH
            // 
            this.combobox_TenHTUH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_TenHTUH.AutoRoundedCorners = true;
            this.combobox_TenHTUH.BackColor = System.Drawing.Color.Transparent;
            this.combobox_TenHTUH.BorderRadius = 17;
            this.combobox_TenHTUH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_TenHTUH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_TenHTUH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_TenHTUH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_TenHTUH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_TenHTUH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_TenHTUH.ItemHeight = 30;
            this.combobox_TenHTUH.Location = new System.Drawing.Point(733, 32);
            this.combobox_TenHTUH.Name = "combobox_TenHTUH";
            this.combobox_TenHTUH.Size = new System.Drawing.Size(240, 36);
            this.combobox_TenHTUH.TabIndex = 16;
            this.combobox_TenHTUH.SelectedIndexChanged += new System.EventHandler(this.combobox_TenHTUH_SelectedIndexChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.splitContainer1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 200);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(993, 442);
            this.guna2Panel2.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chart);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.datagridview);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.splitContainer1.Size = new System.Drawing.Size(993, 442);
            this.splitContainer1.SplitterDistance = 506;
            this.splitContainer1.TabIndex = 0;
            // 
            // chart
            // 
            chartArea1.AxisX.Title = "Đơn vị ủng hộ";
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(20, 20);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(466, 402);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // datagridview
            // 
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview.Location = new System.Drawing.Point(20, 20);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview.Size = new System.Drawing.Size(443, 402);
            this.datagridview.TabIndex = 0;
            // 
            // TK_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 642);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TK_Form";
            this.Text = "TK_Form";
            this.Load += new System.EventHandler(this.TK_Form_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label_GioiThieu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_TenHTUH;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_Chart;
        private System.Windows.Forms.DataGridView datagridview;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_LoaiThongKe;
    }
}