using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;
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
            HoDan hd = new HoDan
            {
                MaHD = textbox_MaHD.Text,
                HoTenChuHo = textbox_HoTen.Text,
                GioiTinh = radiobutton_Nam.Checked,
                CCCD = textbox_CCCD.Text,
                DiaChi = textbox_DiaChi.Text,
                SDT = textbox_SDT.Text,
                DienGiaDinh = ratiobutton_Ngheo.Checked ? "Nghèo" : "Cận Nghèo"
            };
            if (ma == null)
            {
                if (textbox_HoTen.Text == "" || textbox_DiaChi.Text == "" || textbox_CCCD.Text == "" || textbox_SDT.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!", "Thông báo");
                }
                else
                {
                    if (BBL_HoDan.Instance.GetHoDan(textbox_MaHD.Text) != null)
                        MessageBox.Show("MaHD đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                HoDan hd = BBL_HoDan.Instance.GetHoDan(ma);
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
