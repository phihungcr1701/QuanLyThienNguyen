﻿using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyThienNguyen.GUI.Admin
{
    public partial class HD_Form : Form
    {
        public HD_Form(string ma = null)
        {
            InitializeComponent();
            this.ma = ma;
        }
        private string ma { get; set; }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            HoDanView hd = new HoDanView(
                textbox_MaHD.Text,
                textbox_HoTen.Text,
                radiobutton_Nam.Checked,
                textbox_CCCD.Text,
                textbox_DiaChi.Text,
                textbox_SDT.Text,
                ratiobutton_Ngheo.Checked ? "Ngheo" : "Can Ngheo"
            );
            
            if (ma == null)
            {
                if (textbox_HoTen.Text == "" || textbox_DiaChi.Text == "" || textbox_CCCD.Text == "" || textbox_SDT.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {
                    if (BBL_HoDan.Instance.GetHoDan(textbox_MaHD.Text) != null)
                        MessageBox.Show("Đã tồn tại !!!");
                    else
                    {
                        BBL_HoDan.Instance.Add(hd);
                        this.Close();
                    }
                }
            }
            else
            {
                BBL_HoDan.Instance.Update(hd);
                this.Close();
            }
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HD_Form_Load(object sender, EventArgs e)
        {
            if (ma != null)
            {
                textbox_MaHD.ReadOnly = true;
                HoDanView hd = BBL_HoDan.Instance.GetHoDan(ma);
                if (hd.GioiTinh == true)
                    radiobutton_Nam.Checked = true;
                else
                    radiobutton_Nu.Checked = true;
                textbox_MaHD.Text = hd.MaHD;
                textbox_HoTen.Text = hd.HoTenChuHo;
                textbox_CCCD.Text = hd.CCCD;
                textbox_DiaChi.Text = hd.DiaChi;
                textbox_SDT.Text = hd.SDT;
                if (hd.DienGiaDinh == "Can Ngheo")
                    radiobutton_CanNgheo.Checked = true;
                else
                    ratiobutton_Ngheo.Checked = true;
            }
        }
    }
}
