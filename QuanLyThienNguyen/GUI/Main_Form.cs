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
    public partial class Main_Form : Form
    {
        private Form currentChildForm;

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        public Main_Form()
        {
            InitializeComponent();
            
        }
        
        private void buttonHome_Click(object sender, EventArgs e)
        {

        }

        private void button_HoatDong_Click(object sender, EventArgs e)
        {
            openChildForm(new Activity_Form());
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Form form = new Form_Login();
            form.ShowDialog();
        }
    }
}
