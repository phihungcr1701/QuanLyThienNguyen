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
using System.Windows.Forms.VisualStyles;

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
            DonViUngHo dvuh = new DonViUngHo();
            dvuh.TenDonVi = textbox_TenDonVi.Text;
            dvuh.DiaChiDonVi = textbox_DiaChiDonVi.Text;
            dvuh.SDTDonVi = textbox_SDTDonVi.Text;
            if (ma == null)
            {
                if (textbox_TenDonVi.Text == "" || textbox_DiaChiDonVi.Text == "" || textbox_SDTDonVi.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin !!!");
                }
                else
                {
                    BBL_Information.Instance.Add_DVUH(dvuh);
                    this.Close();
                }
            }
            else
            {
                dvuh.MaDVUH = Convert.ToInt32(ma);
                BBL_Information.Instance.Update_DVUH(dvuh);
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
                DonViUngHo obj = BBL_Information.Instance.TruyVan_DVUH(ma);
                textbox_MaDVUH.Text = obj.MaDVUH.ToString();
                textbox_TenDonVi.Text = obj.TenDonVi;
                textbox_DiaChiDonVi.Text = obj.DiaChiDonVi;
                textbox_SDTDonVi.Text = obj.SDTDonVi;
            }
                
        }  
    }
}
