using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;
using QuanLyThienNguyen.GUI.Admin;
using System;
using System.Windows.Forms;

namespace QuanLyThienNguyen.GUI
{
    public partial class Information_Form_Admin : Form
    {
        public Information_Form_Admin()
        {
            InitializeComponent();
        }
        public void GetAll()
        {
            if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ")
                datagridview.DataSource = BBL_DonViUngHo.Instance.GetAllDonViUngHo(textbox_TimKiem.Text, DTO_DonViUngHo.RenameNameTable_FromDataGridViewToSql(combobox_SapXep.SelectedItem.ToString()));
            else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
                datagridview.DataSource = BBL_ThanhVienDVUH.Instance.GetAllThanhVienDVUH(textbox_TimKiem.Text, DTO_ThanhVienDVUH.RenameNameTable_FromDataGridViewToSql(combobox_SapXep.SelectedItem.ToString()));
            else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                datagridview.DataSource = BBL_HoDan.Instance.GetAllHoDan(textbox_TimKiem.Text, DTO_HoDan.RenameNameTable_FromDataGridViewToSql(combobox_SapXep.SelectedItem.ToString()));
            else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                datagridview.DataSource = BBL_DotUngHo.Instance.GetAllDotUngHo(textbox_TimKiem.Text, DTO_DotUngHo.RenameNameTable_FromDataGridViewToSql(combobox_SapXep.SelectedItem.ToString()));
            else
                datagridview.DataSource = BBL_HinhThucUngHo.Instance.GetAllHinhThucUngHo(textbox_TimKiem.Text, DTO_HinhThucUngHo.RenameNameTable_FromDataGridViewToSql(combobox_SapXep.SelectedItem.ToString()));
        }
        private void combobox_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_SapXep.Items.Clear();
            if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ")
                combobox_SapXep.Items.AddRange(DTO_DonViUngHo.items.ToArray());
            else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
                combobox_SapXep.Items.AddRange(DTO_ThanhVienDVUH.items.ToArray());
            else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                combobox_SapXep.Items.AddRange(DTO_HoDan.items.ToArray());
            else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                combobox_SapXep.Items.AddRange(DTO_DotUngHo.items.ToArray());
            else
                combobox_SapXep.Items.AddRange(DTO_HinhThucUngHo.items.ToArray());
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

        private void Information_Form_Admin_Load(object sender, EventArgs e)
        {
            combobox_TimKiem.SelectedIndex = 0;
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
                GetAll();
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
                    TV_DVUH_Form form = new TV_DVUH_Form(datagridview.SelectedRows[0].Cells[0].Value.ToString());
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
                GetAll();
            }
            else
            {
                MessageBox.Show("Hãy chọn loại thông tin cần cập nhật vào");
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedItem != null && datagridview.SelectedRows != null)
            {
                if (combobox_TimKiem.SelectedItem.ToString() == "Đơn vị ủng hộ")
                    BBL_DonViUngHo.Instance.Delete(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                else if (combobox_TimKiem.SelectedItem.ToString() == "Thành viên đơn vị ủng hộ")
                    BBL_ThanhVienDVUH.Instance.Delete(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                else if (combobox_TimKiem.SelectedItem.ToString() == "Hộ dân")
                    BBL_HoDan.Instance.Delete(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                else if (combobox_TimKiem.SelectedItem.ToString() == "Đợt ủng hộ")
                    BBL_DotUngHo.Instance.Delete(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                else
                    BBL_HinhThucUngHo.Instance.Delete(datagridview.SelectedRows[0].Cells[0].Value.ToString());
                GetAll();
            }
            else
            {
                MessageBox.Show("Hãy chọn loại thông tin cần xóa");
            }
        }
    }
}
