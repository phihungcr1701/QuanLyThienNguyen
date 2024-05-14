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
        }

        public void GetLabel_GioiThieu(string st)
        {
            label_GioiThieu.Text = st;
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            CTUH_Form form = new CTUH_Form();
            form.ShowDialog();
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            CTUH_Form form = new CTUH_Form();
            form.ShowDialog();
        }

        private void combobox_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
