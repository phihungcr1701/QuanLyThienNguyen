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
using QuanLyThienNguyen.DAL;
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
            ChiTietUngHo item = BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(MaCTUH);
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
                txtNameActivity.Text = item.TenHoatDong;
                txtMoTa.Text = item.MoTa;
                PictureActivity.Image = BBL_ChiTietUngHo.Instance.ByteArrayToImage(item.AnhHoatDong);
            }
        }

        private void btn_ThucHien_Click(object sender, EventArgs e)
        {
            ChiTietUngHo chitietungho = new ChiTietUngHo
            {
                MaCTUH = txt_MaCTUH.Text,
                TenHoatDong = txtNameActivity.Text,
                MaDVUH = cbb_MaDVUH.SelectedItem.ToString(),
                MaDUH = cbb_MaDUH.SelectedItem.ToString(),
                MaHD = cbb_MaHD.SelectedItem.ToString(),
                MaHTUH = cbb_MaHTUH.SelectedItem.ToString(),
                SoLuongUH = Convert.ToDouble(txt_SoLuongUH.Text),
                SoLuongNUH = Convert.ToDouble(txt_SoLuongNUH.Text),
                MoTa = txtMoTa.Text,
                AnhHoatDong = BBL_ChiTietUngHo.Instance.ImageToByteArray(PictureActivity.Image)
            };
            if (MaCTUH == null)
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

        private void TextChanged(object sender, EventArgs e)
        {
            DataGridView1.Rows[0].Cells[0].Value = txt_MaCTUH.Text;
            DonViUngHo dvuh = BBL_DonViUngHo.Instance.GetDonViUngHo(cbb_MaDVUH.Text.ToString());
            HoDan hd = BBL_HoDan.Instance.GetHoDan(cbb_MaHD.Text.ToString());
            DotUngHo duh = BBL_DotUngHo.Instance.GetDotUngHo(cbb_MaDUH.Text.ToString());
            HinhThucUngHo htuh = BBL_HinhThucUngHo.Instance.GetHinhThucUngHo(cbb_MaHTUH.Text.ToString());
            if (dvuh != null)
            {
                DataGridView1.Rows[0].Cells[1].Value = dvuh.TenDonVi;
            }
            if (hd != null)
            {
                DataGridView1.Rows[0].Cells[2].Value = hd.HoTenChuHo;
            }
            if (htuh != null)
            {
                DataGridView1.Rows[0].Cells[3].Value = htuh.TenHTUH;
                DataGridView1.Rows[0].Cells[6].Value = htuh.DonViTinh;

            }
            DataGridView1.Rows[0].Cells[4].Value = txt_SoLuongUH.Text.ToString();
            DataGridView1.Rows[0].Cells[5].Value = txt_SoLuongNUH.Text.ToString();
            if (duh != null)
            {
                DataGridView1.Rows[0].Cells[7].Value = duh.NgayBatDau.ToString();
                DataGridView1.Rows[0].Cells[8].Value = duh.NgayKetThuc.ToString();
            }
        }

        private void PictureActivity_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                PictureActivity.Image = Image.FromFile(open.FileName);
            }
        }
    }
}