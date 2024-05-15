using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using QuanLyThienNguyen.GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThienNguyen.GUI
{
    public partial class Information_Form_Admin : Form
    {
        public Information_Form_Admin()
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

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedItem != null)
            {
                if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ")
                {
                    DVUH_Form form = new DVUH_Form();
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
                {
                    TV_DVUH_Form form = new TV_DVUH_Form();
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                {
                    HD_Form form = new HD_Form();
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                {
                    DUH_Form form = new DUH_Form();
                    form.ShowDialog();
                }
                else
                {
                    HTUH_Form form = new HTUH_Form();
                    form.ShowDialog();
                }
                datagridview.DataSource = BBL_Information.Instance.View(combobox_TimKiem.SelectedItem.ToString());
            } 
            else
            {
                MessageBox.Show("Hãy chọn loại thông tin cần thêm vào");
            }
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedItem != null && datagridview.SelectedRows != null)
            {
                if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ")
                {
                    DVUH_Form form = new DVUH_Form(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
                {
                    TV_DVUH_Form form = new TV_DVUH_Form(BBL_Information.Instance.ConvertFromDataGridViewToObj(datagridview.SelectedRows[0]));
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                {
                    HD_Form form = new HD_Form(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                {
                    DUH_Form form = new DUH_Form(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                    form.ShowDialog();
                }
                else
                {
                    HTUH_Form form = new HTUH_Form(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn loại thông tin cần cập nhật vào");
            }
            button_SapXep_Click(sender, e);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedItem != null && datagridview.SelectedRows != null)
            {
                if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ")
                {
                    BBL_Information.Instance.Delete_DVUH(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
                {

                    BBL_Information.Instance.Delete_TVDVUH(BBL_Information.Instance.ConvertFromDataGridViewToObj(datagridview.SelectedRows[0]));
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                {
                    BBL_Information.Instance.Delete_HD(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                {
                    BBL_Information.Instance.Delete_DUH(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    BBL_Information.Instance.Delete_HTUH(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn loại thông tin cần xóa");
            }
            button_SapXep_Click(sender, e);
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
