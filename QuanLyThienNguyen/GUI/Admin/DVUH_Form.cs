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
using System.Windows.Forms.VisualStyles;

namespace QuanLyThienNguyen.GUI
{
    public partial class DVUH_Form : Form
    {
        public DVUH_Form()
        {
            InitializeComponent();
        }
        private string DataFromParent_button { get; set; }
        private DonViUngHo DataFromParent_DataSelect { get; set; }
        public void SetData(string button, DonViUngHo dataselect)
        {
            this.DataFromParent_button = button;
            this.DataFromParent_DataSelect = dataselect;
        }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            DonViUngHo dvuh = new DonViUngHo();
            dvuh.MaDVUH = DataFromParent_DataSelect.MaDVUH;
            dvuh.HoTen = textbox_HoTen.Text;
            dvuh.GioiTinh = radiobutton_Nam.Checked ? 0 : 1;
            dvuh.CCCD = textbox_CCCD.Text;
            dvuh.DiaChi = textbox_DiaChi.Text;
            dvuh.SDT = textbox_SDT.Text;
            if (DataFromParent_button == "Thêm")
            {
                if (textbox_HoTen.Text == "" || textbox_DiaChi.Text == "" || textbox_CCCD.Text == "" || textbox_SDT.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {
                    BBL_Information.Instance.BBL_Add_DVUH(dvuh);
                    this.Close();
                }
            }
            else
            {  
                BBL_Information.Instance.BBL_Update_DVUH(dvuh);
                this.Close();
            }
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DVUH_Form_Load(object sender, EventArgs e)
        {
            if (DataFromParent_button == "Cập nhật")
            {
                if (DataFromParent_DataSelect.GioiTinh == 1)
                    radiobutton_Nu.Checked = true;
                textbox_MaDVUH.Text = DataFromParent_DataSelect.MaDVUH.ToString();
                textbox_HoTen.Text = DataFromParent_DataSelect.HoTen;
                textbox_CCCD.Text = DataFromParent_DataSelect.CCCD;
                textbox_DiaChi.Text = DataFromParent_DataSelect.DiaChi;
                textbox_SDT.Text = DataFromParent_DataSelect.SDT;
            }
                
        }  
    }
}
