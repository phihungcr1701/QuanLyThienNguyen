using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyThienNguyen.GUI
{
    public partial class DVUH_Form : Form
    {
        public DVUH_Form(string ma = null)
        {
            InitializeComponent();
            this.ma = ma;
        }
        private string ma { get; set; }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            DonViUngHo dvuh = new DonViUngHo(
                Convert.ToInt32(ma),
                textbox_TenDonVi.Text,
                textbox_DiaChiDonVi.Text,
                textbox_SDTDonVi.Text
            );
            
            if (ma == null)
            {
                if (textbox_TenDonVi.Text == "" || textbox_DiaChiDonVi.Text == "" || textbox_SDTDonVi.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {
                    BBL_DonViUngHo.Instance.Add(dvuh);
                    this.Close();
                }
            }
            else
            {
                BBL_DonViUngHo.Instance.Update(dvuh);
                this.Close();
            }
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DVUH_Form_Load(object sender, EventArgs e)
        {
            if (ma != null)
            {
                DonViUngHo obj = BBL_DonViUngHo.Instance.GetDonViUngHo(Convert.ToInt32(ma));
                textbox_MaDVUH.Text = obj.MaDVUH.ToString();
                textbox_TenDonVi.Text = obj.TenDonVi;
                textbox_DiaChiDonVi.Text = obj.DiaChiDonVi;
                textbox_SDTDonVi.Text = obj.SDTDonVi;
            }
                
        }  
    }
}
