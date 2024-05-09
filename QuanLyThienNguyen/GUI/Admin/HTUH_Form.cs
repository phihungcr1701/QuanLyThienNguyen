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
        public HTUH_Form()
        {
            InitializeComponent();
        }
        private string DataFromParent_button { get; set; }
        private HinhThucUngHo DataFromParent_DataSelect { get; set; }
        public void SetData(string button, HinhThucUngHo dataselect)
        {
            this.DataFromParent_button = button;
            this.DataFromParent_DataSelect = dataselect;
        }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            HinhThucUngHo htuh = new HinhThucUngHo();
            htuh.MaHTUH = DataFromParent_DataSelect.MaHTUH;
            htuh.TenHTUH = textbox_TenHTUH.Text;
            htuh.DonViTinh = textbox_DonViTinh.Text;
            if (DataFromParent_button == "Thêm")
                BBL_Information.Instance.BBL_Add_HTUH(htuh);
            else
                BBL_Information.Instance.BBL_Update_HTUH(htuh);
            this.Close();
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HTUH_Form_Load(object sender, EventArgs e)
        {
            if (DataFromParent_button == "Cập nhật")
            {
                textbox_MaHTUH.Text = DataFromParent_DataSelect.MaHTUH.ToString();
                textbox_TenHTUH.Text = DataFromParent_DataSelect.TenHTUH;
                textbox_DonViTinh.Text = DataFromParent_DataSelect.DonViTinh;
            }
        }
    }
}
