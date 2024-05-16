using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.GUI.Admin;
using System;
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
            dataGridView.DataSource = BBL_Activity.Instance.View(index, timkiem, indexSort);
        }

        public void GetLabel_GioiThieu(string st)
        {
            label_GioiThieu.Text = st;
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            CTUH_Form form = new CTUH_Form();
            form.ShowDialog();
            showDGV();
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            CTUH_Form form = new CTUH_Form();
            //form.d += new CTUH_Form.MyDel(showDGV);
            form.ShowDialog();
            showDGV();
        }

        private void combobox_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
