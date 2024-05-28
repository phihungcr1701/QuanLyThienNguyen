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
        public TV_DVUH_Form(DTOThanhVienDVUH tvdvuh = null)
        {
            InitializeComponent();
            this.tvdvuh = tvdvuh;
        }
        private DTOThanhVienDVUH tvdvuh { get; set; }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            ThanhVienDVUH tvdvuhchange = new ThanhVienDVUH(
                combobox_MaDVUH.SelectedItem.ToString(),
                textbox_HoTen.Text,
                radiobutton_Nam.Checked,
                textbox_CCCD.Text,
                textbox_DiaChi.Text,
                textbox_SDT.Text
            );
            
            if (tvdvuh == null)
            {
                if (combobox_MaDVUH.SelectedItem == null || textbox_HoTen.Text == "" || textbox_DiaChi.Text == "" || textbox_CCCD.Text == "" || textbox_SDT.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {       
                    //if (BBL_ThanhVienDVUH.Instance.Check(tvdvuhchange))
                    //{
                    //    BBL_ThanhVienDVUH.Instance.Add(tvdvuhchange);
                    //    this.Close();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Đã tồn tại !!!");
                    //}
                }
            }
            else
            {
                //if (BBL_ThanhVienDVUH.Instance.Check(tvdvuhchange) && tvdvuh != tvdvuhchange)
                //{
                //    BBL_ThanhVienDVUH.Instance.Update(tvdvuh, tvdvuhchange);
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("Cập nhật trùng với cái đã tồn tại hoặc bạn chưa thay đổi gì !!!");
                //}
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TV_DVUH_Form_Load(object sender, EventArgs e)
        {
            combobox_MaDVUH.Items.AddRange(BBL_ComboBox.Instance.Combobox_DVUH().ToArray());
            if (tvdvuh != null)
            {
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
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Mã đơn vị ủng hộ", dvuh.MaDVUH);
            dataGridView1.Rows.Add("Tên đơn vị", dvuh.TenDonVi);
            dataGridView1.Rows.Add("Địa chỉ", dvuh.DiaChiDonVi);
            dataGridView1.Rows.Add("Số điện thoại", dvuh.SDTDonVi);
        }
    }
}
