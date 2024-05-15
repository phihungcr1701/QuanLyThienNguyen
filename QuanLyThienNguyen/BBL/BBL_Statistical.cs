using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_Statistical
    {
        private static BBL_Statistical instance;

        public static BBL_Statistical Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_Statistical();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public BBL_Statistical() { }
        
        public List<int> data = new List<int>();
        public Series Series(string chart, string ten, string loai)
        {
            List<ThongKe> list = View(ten);
            data.Clear();
            Series series = new Series();
            string chartTypeString = chart;
            series.ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), chartTypeString);

            foreach (ThongKe i in list)
            {
                if (loai == "Tổng số lượng ủng hộ")
                {
                    series.Points.AddXY(i.TenDVUH.ToString(), i.TongSoLuongUH);
                    data.Add(Convert.ToInt32(i.TongSoLuongUH.ToString()));
                }
                else
                {
                    series.Points.AddXY(i.TenDVUH.ToString(), i.SoDuUH);
                    data.Add(Convert.ToInt32(i.SoDuUH.ToString()));
                }
            }

            Random random = new Random();
            foreach (DataPoint point in series.Points)
            {
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                point.Color = randomColor;
            }

            return series;
        }
        public List<ThongKe> View(string ten)
        {
            List<ThongKe> list = new List<ThongKe>();
            foreach (DataRow row in DAL_Statistical.Instance.View(ten).Rows)
            {
                list.Add(new ThongKe
                {
                    TenDVUH = row["TenDVUH"].ToString(),
                    TenHTUH = row["TenHTUH"].ToString(),
                    TongSoLuongUH = Convert.ToDouble(row["TongSoLuongUH"].ToString()),
                    SoDuUH = Convert.ToDouble(row["SoDuUH"].ToString()),
                    DonViTinh = row["DonViTinh"].ToString()
                });
            }
            return list;
        }
        public void Add_TK(ThongKe tk)
        {
            DataTable datatable = new DataTable();
            ThongKe thongke = new ThongKe();

            foreach (string i in BBL_ComboBox.Instance.Combobox_Statistical_MaDVUH())
                foreach (string j in BBL_ComboBox.Instance.Combobox_Statistical_MaHTUH())
                {
                    double TongSoluong = 0;
                    double SoDu = 0;
                    foreach (DataRow row in datatable.Rows)
                        if (row["MaDVUH"].ToString() == i && row["MaHTUH"].ToString() == j)
                        {
                            TongSoluong += Convert.ToDouble(row["SoLuongUH"].ToString());
                            SoDu += Convert.ToDouble(row["SoLuongUH"].ToString()) - Convert.ToDouble(row["SoLuongNUH"].ToString());
                        }
                    thongke.MaDVUH = Convert.ToInt32(i);
                    thongke.MaHTUH = Convert.ToInt32(j);
                    thongke.TongSoLuongUH = TongSoluong;
                    thongke.SoDuUH = SoDu;
                    DAL_Statistical.Instance.Add_TK(tk);
                }
        }
        public void Delete_DVUH()
        {
            DAL_Statistical.Instance.Delete_TK();
        }
    }
}
