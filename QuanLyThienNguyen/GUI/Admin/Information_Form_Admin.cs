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

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedItem != null)
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
           else
           {
                MessageBox.Show("Hãy chọn loại thông tin cần thêm vào");
           }
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Hãy chọn loại thông tin cần cập nhật vào");
            }
        }
    }
}
