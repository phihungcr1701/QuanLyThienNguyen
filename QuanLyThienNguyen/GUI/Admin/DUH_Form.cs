﻿using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;
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
            DotUngHo duh = new DotUngHo
            {
                MaDUH = textbox_MaDUH.Text,
                NgayBatDau = datatimepicker_NgayBatDau.Value,
                NgayKetThuc = datatimepicker_NgayKetThuc.Value
            };
            
            if (duh.NgayBatDau > duh.NgayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc không hợp lệ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ma == null)
                {
                    if (textbox_MaDUH.Text == "") 
                        MessageBox.Show("Điền đầy đủ thông tin !!!", "Thông báo");
                    else
                    {
                        if (BBL_DotUngHo.Instance.GetDotUngHo(textbox_MaDUH.Text) != null)
                            MessageBox.Show("MaDUH đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            BBL_DotUngHo.Instance.Add(duh);
                                this.Close();
                        }
                    }
                }
                else
                {
                    BBL_DotUngHo.Instance.Update(duh);
                    this.Close();
                }
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
                textbox_MaDUH.ReadOnly = true;
                DotUngHo duh = BBL_DotUngHo.Instance.GetDotUngHo(ma);
                textbox_MaDUH.Text = duh.MaDUH.ToString();
                datatimepicker_NgayBatDau.Value = duh.NgayBatDau;
                datatimepicker_NgayKetThuc.Value = duh.NgayKetThuc;
            }
        }
    }
}
