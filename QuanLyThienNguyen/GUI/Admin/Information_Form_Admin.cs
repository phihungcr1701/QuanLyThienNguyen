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
            button_TimKiem_Click(sender, e);
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
                    form.SetData(button_Them.Text, new ThanhVienDonViUngHo());
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                {
                    HD_Form form = new HD_Form();
                    form.SetData(button_Them.Text, new HoDan());
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                {
                    DUH_Form form = new DUH_Form();
                    form.SetData(button_Them.Text, new DotUngHo());
                    form.ShowDialog();
                }
                else
                {
                    HTUH_Form form = new HTUH_Form();
                    form.SetData(button_Them.Text, new HinhThucUngHo());
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
                    DonViUngHo dvuh = DonViUngHo.TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    form.SetData(button_CapNhat.Text , dvuh);
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
                {
                    TV_DVUH_Form form = new TV_DVUH_Form();
                    ThanhVienDonViUngHo tvdvuh = ThanhVienDonViUngHo.TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    form.SetData(button_CapNhat.Text, tvdvuh);
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                {
                    HD_Form form = new HD_Form();
                    HoDan hd = HoDan.TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    form.SetData(button_CapNhat.Text, hd);
                    form.ShowDialog();
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                {
                    DUH_Form form = new DUH_Form();
                    DotUngHo duh = DotUngHo.TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    form.SetData(button_CapNhat.Text, duh);
                    form.ShowDialog();
                }
                else
                {
                    HTUH_Form form = new HTUH_Form();
                    HinhThucUngHo htuh = HinhThucUngHo.TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    form.SetData(button_CapNhat.Text, htuh);
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
                    DonViUngHo dvuh = DonViUngHo.TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + dvuh.MaDVUH + " | " + dvuh.HoTen + " | " + dvuh.GioiTinh + " | " + dvuh.CCCD + " | " + dvuh.DiaChi + " | " + dvuh.SDT, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                    {
                        BBL_Information.Instance.BBL_Delete_DVUH(dvuh);
                    }
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
                {
                    ThanhVienDonViUngHo tvdvuh = ThanhVienDonViUngHo.TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + tvdvuh.MaDVUH + " | " + tvdvuh.HoTen + " | " + tvdvuh.GioiTinh + " | " + tvdvuh.CCCD + " | " + tvdvuh.DiaChi + " | " + tvdvuh.SDT, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                    {
                        BBL_Information.Instance.BBL_Delete_TVDVUH(tvdvuh);
                    }
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                {
                    HoDan hd = HoDan.TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + hd.MaHD + " | " + hd.HoTenChuHo + " | " + hd.GioiTinh + " | " + hd.CCCD + " | " + hd.DiaChi + " | " + hd.SDT + " | " + hd.DienGiaDinh, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                    {
                        BBL_Information.Instance.BBL_Delete_HD(hd);
                    }
                }
                else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                {
                    DotUngHo duh = DotUngHo.TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + duh.MaDUH + " | " + duh.NgayBatDau + " | " + duh.NgayKetThuc, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                    {
                        BBL_Information.Instance.BBL_Delete_DUH(duh);
                    }
                }
                else
                {
                    HinhThucUngHo htuh = HinhThucUngHo.TransferDataGridViewRowToObject(datagridview.SelectedRows[0]);
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + htuh.MaHTUH + " | " + htuh.TenHTUH + " | " + htuh.DonViTinh, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                    {
                        BBL_Information.Instance.BBL_Delete_HTUH(htuh);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn loại thông tin cần xóa");
            }
            button_SapXep_Click(sender, e);
        }
    }
}
