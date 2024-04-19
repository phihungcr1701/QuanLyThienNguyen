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

namespace QuanLyThienNguyen.GUI
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        private UserControl currentFormChild;
        private void openChildForm(UserControl childControl)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Dispose(); 
            }
            currentFormChild = childControl;
            childControl.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear(); 
            guna2Panel2.Controls.Add(childControl); 
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Button4.FillColor = Color.FromArgb(255, 255, 128);
            guna2Button1.FillColor = Color.FromArgb(255, 255, 255);
            openChildForm(new Login());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.FromArgb(255, 255, 128);
            guna2Button4.FillColor = Color.FromArgb(255, 255, 255);
            openChildForm(new Home_Form());
        }
    }
}
