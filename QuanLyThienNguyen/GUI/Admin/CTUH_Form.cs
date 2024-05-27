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
        private string MaCTUH;
        public CTUH_Form(string maCTUH = null)
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
            ChiTietUngHoView item = BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(MaCTUH);
            if (item != null)
            {
                txt_MaCTUH.ReadOnly = true;
                txt_MaCTUH.Text = item.MaCTUH;
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
            string maCTUH = txt_MaCTUH.Text;
            string MaDUH = cbb_MaDUH.SelectedItem.ToString();
            string MaDVUH = cbb_MaDVUH.SelectedItem.ToString();
            string MaHD = cbb_MaHD.SelectedItem.ToString();
            string MaHTUH = cbb_MaHTUH.SelectedItem.ToString();
            double SoLuongUH = Convert.ToDouble(txt_SoLuongUH.Text);
            double SoLuongNUH = Convert.ToDouble(txt_SoLuongNUH.Text);
            ChiTietUngHoView chitietungho = new ChiTietUngHoView(maCTUH, MaDVUH, MaDUH, MaHD, MaHTUH, SoLuongUH, SoLuongNUH); 
            if(MaCTUH == null)
            {
                if (txt_MaCTUH.Text.Equals("") || cbb_MaDUH == null || cbb_MaHD == null || cbb_MaDVUH == null
                    || cbb_MaHD == null || cbb_MaHTUH == null || txt_SoLuongUH.Text.Equals("")
                    || txt_SoLuongNUH.Text.Equals(""))
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin");
                }
                else
                {
                    BBL_ChiTietUngHo.Instance.AddActivity(chitietungho);
                }
            }
            else
            {
                BBL_ChiTietUngHo.Instance.EditActivity(chitietungho);
            }
            this.Dispose();
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
