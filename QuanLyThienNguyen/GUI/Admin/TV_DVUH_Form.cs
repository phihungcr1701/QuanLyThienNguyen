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
    public partial class TV_DVUH_Form : Form
    {
        public TV_DVUH_Form()
        {
            InitializeComponent();
        }
        private string DataFromParent_button { get; set; }
        private ThanhVienDonViUngHo DataFromParent_DataSelect { get; set; }
        public void SetData(string button, ThanhVienDonViUngHo dataselect)
        {
            this.DataFromParent_button = button;
            this.DataFromParent_DataSelect = dataselect;
        }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            ThanhVienDonViUngHo tvdvuh = new ThanhVienDonViUngHo();
            tvdvuh.MaDVUH = Int32.Parse(combobox_MaDVUH.SelectedItem.ToString());
            tvdvuh.HoTen = textbox_HoTen.Text;
            tvdvuh.GioiTinh = radiobutton_Nam.Checked ? 0 : 1;
            tvdvuh.CCCD = textbox_CCCD.Text;
            tvdvuh.DiaChi = textbox_DiaChi.Text;
            tvdvuh.SDT = textbox_SDT.Text;
            if (DataFromParent_button == "Thêm")
            {
                if (combobox_MaDVUH.SelectedItem == null || textbox_HoTen.Text == "" || textbox_DiaChi.Text == "" || textbox_CCCD.Text == "" || textbox_SDT.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {
                    if (BBL_Information.Instance.BBL_Check_TVDVUH(tvdvuh) == 0)
                    {
                        BBL_Information.Instance.BBL_Add_TVDVUH(tvdvuh);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại !!!");
                    }
                    
                }
            }
            else
            {
                if (BBL_Information.Instance.BBL_Check_TVDVUH(tvdvuh) == 0 && tvdvuh != DataFromParent_DataSelect)
                {
                    BBL_Information.Instance.BBL_Update_TVDVUH(DataFromParent_DataSelect, tvdvuh);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật trùng với cái đã tồn tại hoặc bạn chưa thay đổi gì !!!");
                }
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TV_DVUH_Form_Load(object sender, EventArgs e)
        {
            combobox_MaDVUH.Items.AddRange(BBL_ComboBox.Instance.BBL_ComboboxList("DonViUngHo", "MaDVUH").ToArray());
            if (DataFromParent_button == "Cập nhật")
            {
                combobox_MaDVUH.SelectedIndex = combobox_MaDVUH.FindString(DataFromParent_DataSelect.MaDVUH.ToString());
                if (DataFromParent_DataSelect.GioiTinh == 1)
                    radiobutton_Nu.Checked = true;    
                textbox_HoTen.Text = DataFromParent_DataSelect.HoTen;
                textbox_CCCD.Text = DataFromParent_DataSelect.CCCD;
                textbox_DiaChi.Text = DataFromParent_DataSelect.DiaChi;
                textbox_SDT.Text = DataFromParent_DataSelect.SDT;
            }
        }
    }
}
