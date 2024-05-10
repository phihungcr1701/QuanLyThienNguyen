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
        }

        public void GetLabel_GioiThieu(string st)
        {
            label_GioiThieu.Text = st;
        }

        private void combobox_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = combobox_TimKiem.SelectedItem.ToString();
            if (item == "All")
            {
                //List<string> list = new List<string>();
                //list.Add("hung");
                //list.Add("huy");
                //dataGridView.DataSource = list;
                dataGridView.DataSource = BBL_Activity.Instance.Show();
            }
            if (item == "Đang diễn ra")
            {

            }
            if (item == "Đã diễn ra")
            {

            }    
        }
    }
}
