using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThienNguyen.GUI
{
    public partial class Activity_Form_Admin : Form
    {
        public Activity_Form_Admin()
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

        private void button_Them_Click(object sender, EventArgs e)
        {
            CTUH_Form form = new CTUH_Form();
            form.ShowDialog();
            showDGV();
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count == 1)
            {
                int mactuh = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["MaCTUH"].Value.ToString());
                CTUH_Form form = new CTUH_Form(mactuh);
                form.ShowDialog();
                showDGV();
            }    
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

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                int mactuh = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["MaCTUH"].Value.ToString());
                BBL_ChiTietUngHo.Instance.DeleteActivity(mactuh);
                showDGV();
            }
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            showDGV();
        }

        private void button_SapXep_Click(object sender, EventArgs e)
        {
            showDGV();
        }
    }
}
