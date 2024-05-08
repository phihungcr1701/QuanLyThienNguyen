using QuanLyThienNguyen.BBL;
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
        private DonViUngHo TransferDataGridViewRowToObject(DataGridViewRow row)
        {
            DonViUngHo dvuh = new DonViUngHo();
            dvuh.MaDVUH = Int32.Parse(row.Cells["Mã Đơn Vị Ủng Hộ"].Value.ToString());
            dvuh.HoTen = row.Cells["Họ Tên"].Value.ToString();
            dvuh.GioiTinh = row.Cells["Giới Tính"].Value.ToString() == "Nam" ? 0 : 1;
            dvuh.CCCD = row.Cells["CCCD"].Value.ToString();
            dvuh.DiaChi = row.Cells["Địa Chỉ"].Value.ToString();
            dvuh.SDT = row.Cells["Số Điện Thoại"].Value.ToString();
            return dvuh;
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
                combobox_SapXep.SelectedIndex = 0;
                datagridview.DataSource = BBL_Information.Instance.BBL_InformationView(combobox_TimKiem.SelectedItem.ToString(), textbox_TimKiem.Text, combobox_SapXep.SelectedItem.ToString());
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
                datagridview.DataSource = BBL_Information.Instance.BBL_InformationView(combobox_TimKiem.SelectedItem.ToString(), textbox_TimKiem.Text, combobox_SapXep.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin bảng cần xem !!!");
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedItem != null)
                if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ")
                {
                    DVUH_Form form = new DVUH_Form();
                    form.SetData(button_Them.Text, new DonViUngHo());
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
            else
            {
                MessageBox.Show("Hãy chọn loại thông tin cần thêm vào");
            }
            button_SapXep_Click(sender, e);
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedItem != null && datagridview.SelectedRows != null)
            {
                if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ")
                {
                    DVUH_Form form = new DVUH_Form();
                    DonViUngHo dvuh = TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    form.SetData(button_CapNhat.Text , dvuh);
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
            }
            else
            {
                MessageBox.Show("Hãy chọn loại thông tin cần cập nhật vào");
            }
            button_SapXep_Click(sender, e);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            DVUH_Form form = new DVUH_Form();
            DonViUngHo dvuh = TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n "+ dvuh.MaDVUH +" | "+ dvuh.HoTen +" | "+ dvuh.GioiTinh +" | "+ dvuh.CCCD +" | "+ dvuh.DiaChi +" | "+ dvuh.SDT, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                BBL_DVUH.Instance.BBL_Delete_DVUH(dvuh.MaDVUH);
            }
            button_SapXep_Click(sender, e);
        }
    }
}
