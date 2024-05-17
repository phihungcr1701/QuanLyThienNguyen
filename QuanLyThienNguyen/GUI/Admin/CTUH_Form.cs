using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.GUI.Admin
{
    public partial class CTUH_Form : Form
    {
        private int MaCTUH;
        public CTUH_Form(int maCTUH = 0)
        {
            MaCTUH = maCTUH;
            InitializeComponent();
            setCBB();
        }
        private void setCBB()
        {
            cbb_MaDUH.Items.AddRange(BBL_ComboBox.Instance.Combobox_DUH().ToArray());
            cbb_MaDVUH.Items.AddRange(BBL_ComboBox.Instance.Combobox_DVUH().ToArray());
            cbb_MaHD.Items.AddRange(BBL_ComboBox.Instance.Combobox_HoDan().ToArray());
            cbb_MaHTUH.Items.AddRange(BBL_ComboBox.Instance.Combobox_HTUH().ToArray());
            ChiTietUngHo item = BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(MaCTUH);
            if (item != null)
            {
                cbb_MaDUH.SelectedItem = item.MaDUH.ToString();
                cbb_MaDVUH.SelectedItem = item.MaDVUH.ToString();
                cbb_MaHD.SelectedItem = item.MaHD.ToString();
                cbb_MaHTUH.SelectedItem = item.MaHTUH.ToString();
                txt_SoLuongUH.Text = item.SoLuongUH.ToString();
                txt_SoLuongNUH.Text = item.SoLuongNUH.ToString();
            }
        }

        private void btn_ThucHien_Click(object sender, EventArgs e)
        {
            int MaDUH = Convert.ToInt32(cbb_MaDUH.SelectedItem.ToString());
            int MaDVUH = Convert.ToInt32(cbb_MaDVUH.SelectedItem.ToString());
            int MaHD = Convert.ToInt32(cbb_MaHD.SelectedItem.ToString());
            int MaHTUH = Convert.ToInt32(cbb_MaHTUH.SelectedItem.ToString());
            double SoLuongUH = Convert.ToDouble(txt_SoLuongUH.Text);
            double SoLuongNUH = Convert.ToDouble(txt_SoLuongNUH.Text);
            ChiTietUngHo chitietungho = new ChiTietUngHo(MaCTUH, MaDVUH, MaDUH, MaHD, MaHTUH, SoLuongUH, SoLuongNUH);    
            BBL_ChiTietUngHo.Instance.AddOrEditActivity(chitietungho);
            this.Dispose();
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
