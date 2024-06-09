using System;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows;
using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;

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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(993, 642);
            this.flowLayoutPanel1.TabIndex = 0;

            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 642);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Activity";
            this.Text = "InformationActivity_Form";
            this.flowLayoutPanel1.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        

        //them mot hoat dong
        public Guna.UI2.WinForms.Guna2Panel addActivity(System.Drawing.Image image, 
            string nameActivity, string nameDVUH, string mactuh)
        {
            Guna.UI2.WinForms.Guna2Panel pnActivity = new Guna.UI2.WinForms.Guna2Panel();
            System.Windows.Forms.TableLayoutPanel pnText = new System.Windows.Forms.TableLayoutPanel();
            Guna.UI2.WinForms.Guna2Button btnShow = new Guna.UI2.WinForms.Guna2Button();
            Guna.UI2.WinForms.Guna2PictureBox pictureActivity = new Guna.UI2.WinForms.Guna2PictureBox();
            System.Windows.Forms.Label lbNameDVUH = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbNameActivity = new System.Windows.Forms.Label();
    
            pnActivity.Controls.Add(pnText);
            pnActivity.Controls.Add(btnShow);
            pnActivity.Controls.Add(pictureActivity);
            pnActivity.Location = new System.Drawing.Point(20, 20);
            pnActivity.Margin = new System.Windows.Forms.Padding(20);
            pnActivity.BorderColor = System.Drawing.Color.Yellow;
            pnActivity.BorderThickness = 5;
            pnActivity.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pnActivity.Name = "pnActivity";
            pnActivity.Size = new System.Drawing.Size(238, 300);
            pnActivity.TabIndex = 1;

            pictureActivity.Dock = System.Windows.Forms.DockStyle.Top;
            pictureActivity.Image = image;
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
            btnShow.AutoRoundedCorners = true;
            btnShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnShow.ForeColor = System.Drawing.Color.White;
            btnShow.Location = new System.Drawing.Point(0, 264);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(238, 36);
            btnShow.TabIndex = 2;
            btnShow.Text = "Xem hoạt động";
            btnShow.Tag = mactuh;
            btnShow.Click += new System.EventHandler(this.ButtonShow_Click);


            pnText.ColumnCount = 1;
            pnText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            pnText.Dock = System.Windows.Forms.DockStyle.Fill;
            pnText.Location = new System.Drawing.Point(0, 144);
            pnText.Name = "pnText";
            pnText.Size = new System.Drawing.Size(238, 120);
            pnText.Controls.Add(lbNameActivity, 0, 0);
            pnText.Controls.Add(lbNameDVUH, 0, 1);
            pnText.RowCount = 2;
            pnText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            pnText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            pnText.TabIndex = 3;
            // 
            // lbNameActivity
            // 
            lbNameActivity.AutoSize = true;
            lbNameActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            lbNameActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbNameActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lbNameActivity.Location = new System.Drawing.Point(0, 0);
            lbNameActivity.Name = "lbNameActivity";
            lbNameActivity.Size = new System.Drawing.Size(221, 42);
            lbNameActivity.TabIndex = 0;
            lbNameActivity.Text = nameActivity;

            // 
            // lbNameDVUH
            // 
            lbNameDVUH.AutoSize = true;
            lbNameDVUH.Dock = System.Windows.Forms.DockStyle.Fill;
            lbNameDVUH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbNameDVUH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lbNameDVUH.Location = new System.Drawing.Point(0, 42);
            lbNameDVUH.Name = "lbNameDVUH";
            lbNameDVUH.Size = new System.Drawing.Size(77, 13);
            lbNameDVUH.TabIndex = 1;
            lbNameDVUH.Text = "Đơn vị ủng hộ: " + nameDVUH;

            
            return pnActivity;
        }

        
    }
}