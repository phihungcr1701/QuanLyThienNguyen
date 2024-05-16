using QuanLyThienNguyen.BBL;
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
            HoDan hd = new HoDan();
            hd.HoTenChuHo = textbox_HoTen.Text;
            hd.GioiTinh = radiobutton_Nam.Checked;
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
                    BBL_HoDan.Instance.Add(hd);
                    this.Close();
                }
            }
            else
            {
                hd.MaHD = Convert.ToInt32(ma);
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
                HoDan hd = BBL_HoDan.Instance.GetHoDan(ma);
                radiobutton_Nam.Checked = hd.GioiTinh;
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
