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

namespace QuanLyThienNguyen.GUI
{
    public partial class ChiTietUngHo_Form : Form
    {
        string mactuh;
        public ChiTietUngHo_Form(string ma)
        {
            InitializeComponent();
            this.mactuh = ma;
            loadForm();
        }
        public void loadForm()
        {
            string nameActivity = BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(mactuh).TenHoatDong;
            string mota = BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(mactuh).MoTa;
            lbNameActivity.Text = nameActivity;
            lbMoTa.Text = mota;
            pictureActivity.Image = BBL_ChiTietUngHo.Instance.ByteArrayToImage(
                BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(mactuh).AnhHoatDong);
        }

        
    }
}
