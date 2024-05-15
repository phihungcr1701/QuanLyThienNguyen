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
    public partial class HTUH_Form : Form
    {
        public HTUH_Form(string ma = null)
        {
            InitializeComponent();
            this.ma = ma;
        }
        private string ma { get; set; }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            HinhThucUngHo htuh = new HinhThucUngHo();
            htuh.TenHTUH = textbox_TenHTUH.Text;
            htuh.DonViTinh = textbox_DonViTinh.Text;
            if (ma == null)
                BBL_Information.Instance.Add_HTUH(htuh);
            else
            {
                htuh.MaHTUH = Convert.ToInt32(ma);
                BBL_Information.Instance.Update_HTUH(htuh);
            }
                
            this.Close();
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HTUH_Form_Load(object sender, EventArgs e)
        {
            if (ma != null)
            {
                HinhThucUngHo htuh = BBL_Information.Instance.TruyVan_HTUH(ma);
                textbox_MaHTUH.Text = htuh.MaHTUH.ToString();
                textbox_TenHTUH.Text = htuh.TenHTUH;
                textbox_DonViTinh.Text = htuh.DonViTinh;
            }
        }
    }
}
