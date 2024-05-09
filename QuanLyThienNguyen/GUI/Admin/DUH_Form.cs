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
        public DUH_Form()
        {
            InitializeComponent();
        }
        private string DataFromParent_button { get; set; }
        private DotUngHo DataFromParent_DataSelect { get; set; }
        public void SetData(string button, DotUngHo dataselect)
        {
            this.DataFromParent_button = button;
            this.DataFromParent_DataSelect = dataselect;
        }
        private void button_ThucHien_Click(object sender, EventArgs e)
        {
            DotUngHo duh = new DotUngHo();
            duh.MaDUH = DataFromParent_DataSelect.MaDUH;
            duh.NgayBatDau = datatimepicker_NgayBatDau.Value;
            duh.NgayKetThuc = datatimepicker_NgayKetThuc.Value;
            if (duh.NgayBatDau > duh.NgayKetThuc)
            {
                MessageBox.Show("Không hợp lệ !!!");
            }
            else
            {
                if (DataFromParent_button == "Thêm")
                    BBL_Information.Instance.BBL_Add_DUH(duh);
                else
                    BBL_Information.Instance.BBL_Update_DUH(duh);
                this.Close();
            }
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DUH_Form_Load(object sender, EventArgs e)
        {
            if (DataFromParent_button == "Cập nhật")
            {
                textbox_MaDUH.Text = DataFromParent_DataSelect.MaDUH.ToString();
                datatimepicker_NgayBatDau.Value = DataFromParent_DataSelect.NgayBatDau;
                datatimepicker_NgayKetThuc.Value = DataFromParent_DataSelect.NgayKetThuc;
            }
        }
    }
}
