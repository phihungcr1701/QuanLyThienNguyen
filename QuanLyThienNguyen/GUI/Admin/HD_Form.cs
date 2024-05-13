using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            HoDan hd = new HoDan();
            hd.HoTenChuHo = textbox_HoTen.Text;
            hd.GioiTinh = radiobutton_Nam.Checked ? 0 : 1;
            hd.CCCD = textbox_CCCD.Text;
            hd.DiaChi = textbox_DiaChi.Text;
            hd.SDT = textbox_SDT.Text;
            hd.DienGiaDinh = ratiobutton_Ngheo.Checked ? "Ngheo" : "Can Ngheo";
            if (ma == null)
            {
                if (textbox_HoTen.Text == "" || textbox_DiaChi.Text == "" || textbox_CCCD.Text == "" || textbox_SDT.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {
                    BBL_Information.Instance.Add_HD(hd);
                    this.Close();
                }
            }
            else
            {
                hd.MaHD = Convert.ToInt32(ma);
                BBL_Information.Instance.Update_HD(hd);
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
                HoDan hd = BBL_Information.Instance.TruyVan_HD(ma);
                if (hd.GioiTinh == 1)
                    radiobutton_Nu.Checked = true;
                textbox_MaHD.Text = hd.MaHD.ToString();
                textbox_HoTen.Text = hd.HoTenChuHo;
                textbox_CCCD.Text = hd.CCCD;
                textbox_DiaChi.Text = hd.DiaChi;
                textbox_SDT.Text = hd.SDT;
                if (hd.DienGiaDinh == "Can Ngheo")
                    radiobutton_CanNgheo.Checked = true;
            }
        }
    }
}
