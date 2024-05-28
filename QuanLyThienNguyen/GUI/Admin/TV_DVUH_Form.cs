using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QuanLyThienNguyen.GUI.Admin
{
    public partial class TV_DVUH_Form : Form
    {
        public TV_DVUH_Form(string ma = null)
        {
            InitializeComponent();
            this.ma = ma;
        }
        private string ma { get; set; }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            ThanhVienDVUH tvdvuh = new ThanhVienDVUH
            {
                MaTVDVUH = textbox_MaTVDVUH.Text,
                MaDVUH = combobox_MaDVUH.SelectedItem.ToString(),
                HoTen = textbox_HoTen.Text,
                GioiTinh = radiobutton_Nam.Checked,
                CCCD = textbox_CCCD.Text,
                DiaChi = textbox_DiaChi.Text,
                SDT = textbox_SDT.Text
            };
            if (ma == null)
            {
                if (combobox_MaDVUH.SelectedItem == null || textbox_MaTVDVUH.Text == "" || textbox_HoTen.Text == "" || textbox_DiaChi.Text == "" || textbox_CCCD.Text == "" || textbox_SDT.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {       
                    if (BBL.BBL_ThanhVienDVUH.Instance.GetThanhVienDVUH(textbox_MaTVDVUH.Text) == null)
                    {
                        BBL_ThanhVienDVUH.Instance.Add(tvdvuh);
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
                BBL_ThanhVienDVUH.Instance.Update(tvdvuh);
                this.Close();
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TV_DVUH_Form_Load(object sender, EventArgs e)
        {
            combobox_MaDVUH.Items.AddRange(BBL_ComboBox.Instance.Combobox_DVUH().ToArray());
            if (ma != null)
            {
                ThanhVienDVUH tvdvuh = BBL_ThanhVienDVUH.Instance.GetThanhVienDVUH(ma);
                textbox_MaTVDVUH.ReadOnly = true;
                textbox_MaTVDVUH.Text = tvdvuh.MaTVDVUH;
                combobox_MaDVUH.SelectedIndex = combobox_MaDVUH.FindString(tvdvuh.MaDVUH);
                if (tvdvuh.GioiTinh == true)
                    radiobutton_Nam.Checked = true;
                else 
                    radiobutton_Nu.Checked = true;
                textbox_HoTen.Text = tvdvuh.HoTen;
                textbox_CCCD.Text = tvdvuh.CCCD;
                textbox_DiaChi.Text = tvdvuh.DiaChi;
                textbox_SDT.Text = tvdvuh.SDT;
            }
        }
        private void combobox_MaDVUH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DonViUngHo dvuh = BBL_DonViUngHo.Instance.GetDonViUngHo(combobox_MaDVUH.SelectedItem.ToString());
            datagridview_DVUH.Rows.Clear();
            datagridview_DVUH.Rows.Add("Mã đơn vị ủng hộ", dvuh.MaDVUH);
            datagridview_DVUH.Rows.Add("Tên đơn vị", dvuh.TenDonVi);
            datagridview_DVUH.Rows.Add("Địa chỉ", dvuh.DiaChiDonVi);
            datagridview_DVUH.Rows.Add("Số điện thoại", dvuh.SDTDonVi);
        }
    }
}
