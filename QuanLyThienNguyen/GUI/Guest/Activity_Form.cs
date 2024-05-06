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
    }
}
