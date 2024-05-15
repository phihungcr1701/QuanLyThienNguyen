using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;
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
        public TV_DVUH_Form(ThanhVienDonViUngHo tvdvuh = null)
        {
            InitializeComponent();
            this.tvdvuh = tvdvuh;
        }
        private ThanhVienDonViUngHo tvdvuh { get; set; }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            ThanhVienDonViUngHo tvdvuhchange = new ThanhVienDonViUngHo();
            tvdvuhchange.MaDVUH = Int32.Parse(combobox_MaDVUH.SelectedItem.ToString());
            tvdvuhchange.HoTen = textbox_HoTen.Text;
            tvdvuhchange.GioiTinh = radiobutton_Nam.Checked ? 0 : 1;
            tvdvuhchange.CCCD = textbox_CCCD.Text;
            tvdvuhchange.DiaChi = textbox_DiaChi.Text;
            tvdvuhchange.SDT = textbox_SDT.Text;
            if (tvdvuh == null)
            {
                if (combobox_MaDVUH.SelectedItem == null || textbox_HoTen.Text == "" || textbox_DiaChi.Text == "" || textbox_CCCD.Text == "" || textbox_SDT.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {       
                    if (BBL_Information.Instance.Check_TVDVUH(tvdvuhchange))
                    {
                        BBL_Information.Instance.Add_TVDVUH(tvdvuhchange);
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
                if (BBL_Information.Instance.Check_TVDVUH(tvdvuhchange) && tvdvuh != tvdvuhchange)
                {
                    BBL_Information.Instance.Update_TVDVUH(tvdvuh, tvdvuhchange);
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
            combobox_MaDVUH.Items.AddRange(BBL_ComboBox.Instance.Combobox_Information("DonViUngHo").ToArray());
            if (tvdvuh != null)
            {
                combobox_MaDVUH.SelectedIndex = combobox_MaDVUH.FindString(tvdvuh.MaDVUH.ToString());
                if (tvdvuh.GioiTinh == 1)
                    radiobutton_Nu.Checked = true;    
                textbox_HoTen.Text = tvdvuh.HoTen;
                textbox_CCCD.Text = tvdvuh.CCCD;
                textbox_DiaChi.Text = tvdvuh.DiaChi;
                textbox_SDT.Text = tvdvuh.SDT;
            }
        }
    }
}
