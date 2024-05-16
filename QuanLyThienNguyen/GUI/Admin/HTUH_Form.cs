using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;
using System;
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
                BBL_HinhThucUngHo.Instance.Add(htuh);
            else
            {
                htuh.MaHTUH = Convert.ToInt32(ma);
                BBL_HinhThucUngHo.Instance.Update(htuh);
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
                HinhThucUngHo htuh = BBL_HinhThucUngHo.Instance.GetHinhThucUngHo(ma);
                textbox_MaHTUH.Text = htuh.MaHTUH.ToString();
                textbox_TenHTUH.Text = htuh.TenHTUH;
                textbox_DonViTinh.Text = htuh.DonViTinh;
            }
        }
    }
}
