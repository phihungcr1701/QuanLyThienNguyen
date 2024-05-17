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

namespace QuanLyThienNguyen.GUI
{
    public partial class Activity_Form : Form
    {
        public Activity_Form()
        {
            InitializeComponent();
            showDGV();
        }

        private void showDGV()
        {
            int index = combobox_TimKiem.SelectedIndex;
            string timkiem = textbox_TimKiem.Text;
            int indexSort = combobox_SapXep.SelectedIndex;
            dataGridView.DataSource = BBL_ChiTietUngHo.Instance.Display(index, timkiem, indexSort);
        }

        private void combobox_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_TimKiem.SelectedIndex == 0)
            {
                showDGV();
            }
            else if (combobox_TimKiem.SelectedIndex == 1)
            {
                showDGV();
            }
            else if (combobox_TimKiem.SelectedIndex == 2)
            {
                showDGV();
            }
            else
            {
                showDGV();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            showDGV();
        }

        private void button_SapXep_Click(object sender, EventArgs e)
        {
            showDGV();
        }
    }
}
