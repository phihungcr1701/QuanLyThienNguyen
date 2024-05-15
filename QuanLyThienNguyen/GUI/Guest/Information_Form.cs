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
            textbox_TimKiem.Text = string.Empty;
            if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ") 
            {
                combobox_SapXep.Items.AddRange(DonViUngHo.items.ToArray());
                combobox_SapXep.SelectedIndex = 0;
            }
            else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
            {
                combobox_SapXep.Items.AddRange(ThanhVienDonViUngHo.items.ToArray());
                combobox_SapXep.SelectedIndex = 0;
            }
            else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
            {
                combobox_SapXep.Items.AddRange(HoDan.items.ToArray());
                combobox_SapXep.SelectedIndex = 0;
            }
            else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
            {
                combobox_SapXep.Items.AddRange(DotUngHo.items.ToArray());
                combobox_SapXep.SelectedIndex = 0;
            }
            else if (combobox_TimKiem.SelectedItem.ToString() == "Hình thức ủng hộ")
            {
                combobox_SapXep.Items.AddRange(HinhThucUngHo.items.ToArray());
                combobox_SapXep.SelectedIndex = 0;
            }
            datagridview.DataSource = BBL_Information.Instance.View(combobox_TimKiem.SelectedItem.ToString());
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedItem != null)
            {
                combobox_SapXep.SelectedIndex = 0;
                datagridview.DataSource = BBL_Information.Instance.TimKiem_SapXep(combobox_TimKiem.SelectedItem.ToString(), textbox_TimKiem.Text, combobox_SapXep.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin bảng cần xem !!!");
            }
        }

        private void button_SapXep_Click(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedItem != null)
            {
                datagridview.DataSource = BBL_Information.Instance.TimKiem_SapXep(combobox_TimKiem.SelectedItem.ToString(), textbox_TimKiem.Text, combobox_SapXep.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin bảng cần sắp xếp !!!");
            }
        }

        private void datagridview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    int genderValue;
                    if (int.TryParse(e.Value.ToString(), out genderValue))
                    {
                        e.Value = (genderValue == 0) ? "Nam" : "Nu";
                        e.FormattingApplied = true;
                    }
                }
            }
        }
    }
}
