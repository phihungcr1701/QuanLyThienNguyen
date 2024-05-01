using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.GUI
{
    public partial class Main_Form : Form
    {
        private Form currentChildForm;
        bool check = false;

        public Main_Form()
        {
            InitializeComponent();
            openChildForm(new Home_Form()); 
        }
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
        
        private void buttonHome_Click(object sender, EventArgs e)
        {
            openChildForm(new Home_Form());
        }

        private void button_HoatDong_Click(object sender, EventArgs e)
        {
            if (check)
            {
                openChildForm(new Activity_Form_Admin());
            }
            else
            {
                openChildForm(new Activity_Form());
            }
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Form_Login form = new Form_Login();
            form.ShowDialog();
            check = form.check;
            if (check)
            {
                new Main_Form();
                btnLogin.Text = "Đăng xuất";
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            labelNgayThang.Text = "Đà Nẵng, Ngày " + DateTime.Now.ToString("dd, MM/yyyy");
        }
    }
}
