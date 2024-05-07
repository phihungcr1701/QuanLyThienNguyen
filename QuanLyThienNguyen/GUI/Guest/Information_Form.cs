using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.GUI
{
    public partial class Information_Form : Form
    {
        public Information_Form()
        {
            InitializeComponent();
        }

        private void combobox_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_SapXep.Items.Clear();
            if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ") 
            {
                DonViUngHo table = new DonViUngHo();
                combobox_SapXep.Items.AddRange(table.items.ToArray());
                combobox_SapXep.SelectedIndex = 0;
            }
            else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
            {
                ThanhVienDonViUngHo table = new ThanhVienDonViUngHo();
                combobox_SapXep.Items.AddRange(table.items.ToArray());
                combobox_SapXep.SelectedIndex = 0;
            }
            else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
            {
                HoDan table = new HoDan();
                combobox_SapXep.Items.AddRange(table.items.ToArray());
                combobox_SapXep.SelectedIndex = 0;
            }
            else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
            {
                DotUngHo table = new DotUngHo();
                combobox_SapXep.Items.AddRange(table.items.ToArray());
                combobox_SapXep.SelectedIndex = 0;
            }
            else if (combobox_TimKiem.SelectedItem.ToString() == "Hình thức ủng hộ")
            {
                HinhThucUngHo table = new HinhThucUngHo();
                combobox_SapXep.Items.AddRange(table.items.ToArray());
                combobox_SapXep.SelectedIndex = 0;
            }

        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedItem != null)
            {
                datagridview.DataSource = BBL_Information.Instance.BBL_InformationView(combobox_TimKiem.SelectedItem.ToString(), textbox_TimKiem.Text, combobox_SapXep.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin bảng cần xem !!!");
            }
        }
    }
}
