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
            if (DataFromParent_button == "Thêm")
            {
                if (textbox_HoTen.Text == "" || textbox_DiaChi.Text == "" || textbox_CCCD.Text == "" || textbox_SDT.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {
                    int gioitinh;
                    if (radiobutton_Nam.Checked) { gioitinh = 0; } else { gioitinh = 1; }
                    BBL_DVUH.Instance.BBL_Add_DVUH(textbox_HoTen.Text, gioitinh, textbox_CCCD.Text, textbox_DiaChi.Text, textbox_SDT.Text);
                    this.Close();
                }
            }
            else
            {  
                if (textbox_HoTen.Text == "")
                    textbox_HoTen.Text = DataFromParent_DataSelect.HoTen;
                if (textbox_CCCD.Text == "")
                    textbox_CCCD.Text = DataFromParent_DataSelect.CCCD;
                if (textbox_DiaChi.Text =="")
                    textbox_DiaChi.Text = DataFromParent_DataSelect.DiaChi;
                if (textbox_SDT.Text == "")
                    textbox_SDT.Text = DataFromParent_DataSelect.SDT;  
                int gioitinh = radiobutton_Nam.Checked ? 0 : 1;
                BBL_DVUH.Instance.BBL_Update_DVUH(DataFromParent_DataSelect.MaDVUH ,textbox_HoTen.Text, gioitinh, textbox_CCCD.Text, textbox_DiaChi.Text, textbox_SDT.Text);
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
            }
                
        }  
    }
}
