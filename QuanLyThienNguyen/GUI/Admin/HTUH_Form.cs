using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;
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
            HinhThucUngHo htuh = new HinhThucUngHo
            {
                MaHTUH = textbox_MaHTUH.Text,
                TenHTUH = textbox_TenHTUH.Text,
                DonViTinh = textbox_DonViTinh.Text
            };
            if (ma == null)
                if (textbox_MaHTUH.Text == "" || textbox_TenHTUH.Text == "" || textbox_DonViTinh.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!", "Thông báo");
                }
                else
                {
                    if (BBL_HinhThucUngHo.Instance.GetHinhThucUngHo(textbox_MaHTUH.Text) != null)
                        MessageBox.Show("MaHTUH đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        BBL_HinhThucUngHo.Instance.Add(htuh);
                        this.Close();
                    }
                }
            else
            {
                BBL_HinhThucUngHo.Instance.Update(htuh);
                this.Close();
            }
                
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HTUH_Form_Load(object sender, EventArgs e)
        {
            if (ma != null)
            {
                textbox_MaHTUH.ReadOnly = true;
                HinhThucUngHo htuh = BBL_HinhThucUngHo.Instance.GetHinhThucUngHo(ma);
                textbox_MaHTUH.Text = htuh.MaHTUH;
                textbox_TenHTUH.Text = htuh.TenHTUH;
                textbox_DonViTinh.Text = htuh.DonViTinh;
            }
        }
    }
}
