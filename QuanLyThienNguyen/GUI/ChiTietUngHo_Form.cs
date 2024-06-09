using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;

namespace QuanLyThienNguyen.GUI
{
    public partial class ChiTietUngHo_Form : Form
    {
        string mactuh;
        public ChiTietUngHo_Form(string ma)
        {
            InitializeComponent();
            this.mactuh = ma;
            loadForm();
        }
        public void loadForm()
        {
            int dem = 0;
            string nameActivity = BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(mactuh).TenHoatDong;
            string mota = BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(mactuh).MoTa;
            lbNameActivity.Text = nameActivity;
            lbMoTa.Text = mota;
            pictureActivity.Image = BBL_ChiTietUngHo.Instance.ByteArrayToImage(
                BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(mactuh).AnhHoatDong);
            ChiTietUngHo item = BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(mactuh);
            lbTenDVUH.Text = BBL_DonViUngHo.Instance.GetDonViUngHo(item.MaDVUH).TenDonVi;
            lbTenHD.Text = BBL_HoDan.Instance.GetHoDan(item.MaHD).HoTenChuHo;
            lbTenHT.Text = BBL_HinhThucUngHo.Instance.GetHinhThucUngHo(item.MaHTUH).TenHTUH;
            lbSLUH.Text = BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(mactuh).SoLuongUH.ToString();
            lbSLNUH.Text = BBL_ChiTietUngHo.Instance.GetChiTietUngHoByMaCTUH(mactuh).SoLuongNUH.ToString();
            lbDonViTinh.Text = BBL_HinhThucUngHo.Instance.GetHinhThucUngHo(item.MaHTUH).DonViTinh;
            lbNgayBatDau.Text = BBL_DotUngHo.Instance.GetDotUngHo(item.MaDUH).NgayBatDau.ToString();
            lbNgayKetThuc.Text = BBL_DotUngHo.Instance.GetDotUngHo(item.MaDUH).NgayKetThuc.ToString();
            foreach(ThanhVienDVUH i in BBL_ThanhVienDVUH.Instance.GetAllThanhVienDonViFromMaDVUH(item.MaDVUH))
            {
                dataGridView.Rows.Add(++dem, i.HoTen);
            }
        }
    }
}
