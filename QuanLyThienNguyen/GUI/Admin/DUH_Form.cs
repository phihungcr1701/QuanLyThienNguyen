﻿using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyThienNguyen.GUI.Admin
{
    public partial class DUH_Form : Form
    {
        public DUH_Form(string ma = null)
        {
            InitializeComponent();
            this.ma = ma;
        }
        private string ma { get; set; }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            DotUngHo duh = new DotUngHo(
                Convert.ToInt32(ma),
                datatimepicker_NgayBatDau.Value,
                datatimepicker_NgayKetThuc.Value
            );
            
            if (duh.NgayBatDau > duh.NgayKetThuc)
            {
                MessageBox.Show("Không hợp lệ !!!");
            }
            else
            {
                if (ma == null)
                    BBL_DotUngHo.Instance.Add(duh);
                else
                    BBL_DotUngHo.Instance.Update(duh);
                this.Close();
            }
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DUH_Form_Load(object sender, EventArgs e)
        {
            if (ma != null)
            {
                DotUngHo duh = BBL_DotUngHo.Instance.GetDotUngHo(Convert.ToInt32(ma));
                textbox_MaDUH.Text = duh.MaDUH.ToString();
                datatimepicker_NgayBatDau.Value = duh.NgayBatDau;
                datatimepicker_NgayKetThuc.Value = duh.NgayKetThuc;
            }
        }
    }
}
