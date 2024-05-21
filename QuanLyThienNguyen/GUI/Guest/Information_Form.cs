using System;
using System.Windows.Forms;
using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.GUI
{
    public partial class Information_Form : Form
    {
        public Information_Form()
        {
            InitializeComponent();
        }

        public void GetAll()
        {
            if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ")
                datagridview.DataSource = BBL_DonViUngHo.Instance.GetAllDonViUngHo(textbox_TimKiem.Text, DonViUngHo.RenameNameTable_FromDataGridViewToSql(combobox_SapXep.SelectedItem.ToString()));
            else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
                datagridview.DataSource = BBL_ThanhVienDVUH.Instance.GetAllThanhVienDVUH(textbox_TimKiem.Text, ThanhVienDVUH.RenameNameTable_FromDataGridViewToSql(combobox_SapXep.SelectedItem.ToString()));
            else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                datagridview.DataSource = BBL_HoDan.Instance.GetAllHoDan(textbox_TimKiem.Text, HoDan.RenameNameTable_FromDataGridViewToSql(combobox_SapXep.SelectedItem.ToString()));
            else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                datagridview.DataSource = BBL_DotUngHo.Instance.GetAllDotUngHo(textbox_TimKiem.Text, DotUngHo.RenameNameTable_FromDataGridViewToSql(combobox_SapXep.SelectedItem.ToString()));
            else
                datagridview.DataSource = BBL_HinhThucUngHo.Instance.GetAllHinhThucUngHo(textbox_TimKiem.Text, HinhThucUngHo.RenameNameTable_FromDataGridViewToSql(combobox_SapXep.SelectedItem.ToString()));
        }
        private void combobox_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_SapXep.Items.Clear();
            if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ")
                combobox_SapXep.Items.AddRange(DonViUngHo.items.ToArray());
            else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
                combobox_SapXep.Items.AddRange(ThanhVienDVUH.items.ToArray());
            else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                combobox_SapXep.Items.AddRange(HoDan.items.ToArray());
            else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                combobox_SapXep.Items.AddRange(DotUngHo.items.ToArray());
            else
                combobox_SapXep.Items.AddRange(HinhThucUngHo.items.ToArray());
            combobox_SapXep.SelectedIndex = 0;
            textbox_TimKiem.Text = string.Empty;
        }

        private void combobox_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAll();
        }

        private void textbox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            GetAll();
        }

        private void Information_Form_Load(object sender, EventArgs e)
        {
            combobox_TimKiem.SelectedIndex = 0;
        }
    }
}
