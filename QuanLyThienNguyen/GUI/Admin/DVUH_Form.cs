using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;
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
            DonViUngHo dvuh = new DonViUngHo
            {
                MaDVUH = textbox_MaDVUH.Text,
                TenDonVi = textbox_TenDonVi.Text,
                DiaChiDonVi = textbox_DiaChiDonVi.Text,
                SDTDonVi = textbox_SDTDonVi.Text
            };
            if (ma == null)
            {
                if (textbox_MaDVUH.Text == "" || textbox_TenDonVi.Text == "" || textbox_DiaChiDonVi.Text == "" || textbox_SDTDonVi.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {
                    if (BBL_DonViUngHo.Instance.GetDonViUngHo(textbox_MaDVUH.Text) != null)
                        MessageBox.Show("Đã tồn tại !!!");
                    else
                    {
                        BBL_DonViUngHo.Instance.Add(dvuh);
                        this.Close();
                    } 
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
                textbox_MaDVUH.ReadOnly = true;
                DonViUngHo obj = BBL_DonViUngHo.Instance.GetDonViUngHo(ma);
                textbox_MaDVUH.Text = obj.MaDVUH;
                textbox_TenDonVi.Text = obj.TenDonVi;
                textbox_DiaChiDonVi.Text = obj.DiaChiDonVi;
                textbox_SDTDonVi.Text = obj.SDTDonVi;
            }
                
        }  
    }
}
