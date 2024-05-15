using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThienNguyen.GUI.Admin
{
    public partial class DUH_Form : Form
    {
        public DUH_Form(string ma = null)
        {
            InitializeComponent();
            this.ma = ma;
        }
        private string ma { get; set; }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            DotUngHo duh = new DotUngHo();
            duh.NgayBatDau = datatimepicker_NgayBatDau.Value;
            duh.NgayKetThuc = datatimepicker_NgayKetThuc.Value;
            if (duh.NgayBatDau > duh.NgayKetThuc)
            {
                MessageBox.Show("Không hợp lệ !!!");
            }
            else
            {
                if (ma == null)
                    BBL_Information.Instance.Add_DUH(duh);
                else
                {
                    duh.MaDUH = Convert.ToInt32(ma);
                    BBL_Information.Instance.Update_DUH(duh);
                }
                this.Close();
            }
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DUH_Form_Load(object sender, EventArgs e)
        {
            if (ma != null)
            {
                DotUngHo duh = BBL_Information.Instance.TruyVan_DUH(ma);
                textbox_MaDUH.Text = duh.MaDUH.ToString();
                datatimepicker_NgayBatDau.Value = duh.NgayBatDau;
                datatimepicker_NgayKetThuc.Value = duh.NgayKetThuc;
            }
        }
    }
}
