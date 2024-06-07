using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;

namespace QuanLyThienNguyen.GUI
{
    public partial class Activity : Form
    {
        public Activity()
        {
            InitializeComponent();
            SetView();
        }
        public void SetView()
        {
            foreach (ChiTietUngHo item in DAL_ChiTietUngHo.Instance.GetAll())
            {
                this.flowLayoutPanel1.Controls.Add
                    (
                        addActivity
                        (
                            BBL_ChiTietUngHo.Instance.ByteArrayToImage(item.AnhHoatDong), item.TenHoatDong,
                            BBL_DonViUngHo.Instance.GetDonViUngHo(item.MaDVUH).TenDonVi, item.MaCTUH
                        )
                    );
               
            }
        }
        private void ButtonShow_Click(object sender, EventArgs e)
        {
            var button = sender as Guna.UI2.WinForms.Guna2Button;
            if (button != null)
            {
                string mactuh = button.Tag.ToString();
                Main_Form form = new Main_Form();
                //form.openChildForm(new ChiTietUngHo_Form(mactuh));
                ChiTietUngHo_Form form1 = new ChiTietUngHo_Form(mactuh);
                form1.Show();
                //MessageBox.Show("Xem hoạt động button clicked for MaCTUH: " + maCTUH);
            }
        }


    }
}
