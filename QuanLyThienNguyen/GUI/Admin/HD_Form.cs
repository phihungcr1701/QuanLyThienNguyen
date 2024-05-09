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
        public HD_Form()
        {
            InitializeComponent();
        }
        private string DataFromParent_button { get; set; }
        private HoDan DataFromParent_DataSelect { get; set; }
        public void SetData(string button, HoDan dataselect)
        {
            this.DataFromParent_button = button;
            this.DataFromParent_DataSelect = dataselect;
        }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            HoDan hd = new HoDan();
            hd.MaHD = DataFromParent_DataSelect.MaHD;
            hd.HoTenChuHo = textbox_HoTen.Text;
            hd.GioiTinh = radiobutton_Nam.Checked ? 0 : 1;
            hd.CCCD = textbox_CCCD.Text;
            hd.DiaChi = textbox_DiaChi.Text;
            hd.SDT = textbox_SDT.Text;
            hd.DienGiaDinh = ratiobutton_Ngheo.Checked ? "Ngheo" : "Can Ngheo";
            if (DataFromParent_button == "Thêm")
            {
                if (textbox_HoTen.Text == "" || textbox_DiaChi.Text == "" || textbox_CCCD.Text == "" || textbox_SDT.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {
                    BBL_Information.Instance.BBL_Add_HD(hd);
                    this.Close();
                }
            }
            else
            {
                BBL_Information.Instance.BBL_Update_HD(hd);
                this.Close();
            }
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HD_Form_Load(object sender, EventArgs e)
        {
            if (DataFromParent_button == "Cập nhật")
            {
                if (DataFromParent_DataSelect.GioiTinh == 1)
                    radiobutton_Nu.Checked = true;
                textbox_MaHD.Text = DataFromParent_DataSelect.MaHD.ToString();
                textbox_HoTen.Text = DataFromParent_DataSelect.HoTenChuHo;
                textbox_CCCD.Text = DataFromParent_DataSelect.CCCD;
                textbox_DiaChi.Text = DataFromParent_DataSelect.DiaChi;
                textbox_SDT.Text = DataFromParent_DataSelect.SDT;
                if (DataFromParent_DataSelect.DienGiaDinh == "Can Ngheo")
                    radiobutton_CanNgheo.Checked = true;
            }

        }
    }
}
