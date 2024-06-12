﻿using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_ThongKe
    {
        private static BBL_ThongKe instance;

        public static BBL_ThongKe Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_ThongKe();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public BBL_ThongKe() { }

        public List<double> data = new List<double>();
        public Series Series(string chart, string ten, string loai)
        {
            data.Clear();
            Series series = new Series();
            string chartTypeString = chart;
            series.ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), chartTypeString);
            data.Add(0);

            foreach (DTO_ThongKe i in GetThongKeByTenHTUH(ten))
            {
                if (loai == "Tổng số lượng ủng hộ" && i.TongSoLuongUH != 0)
                {
                    series.Points.AddXY(i.TenDVUH.ToString(), i.TongSoLuongUH);
                    data.Add(Convert.ToInt32(i.TongSoLuongUH.ToString()));
                }
                else if (i.SoDuUH != 0)
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
        public List<DTO_ThongKe> GetThongKeByTenHTUH(string ten)
        {
            return DAL_ThongKe.Instance.GetThongKeByTenHTUH(ten);
        }
        public void Add()
        {
            int count = 0;

            foreach (string i in DAL_ThongKe.Instance.GetAllMaDVUH())
                foreach (string j in DAL_ThongKe.Instance.GetAllMaHTUH())
                {
                    double TongSoluong = BBL_ChiTietUngHo.Instance.TongSoLuong(i, j);
                    double SoDu = BBL_ChiTietUngHo.Instance.SoDu(i, j);
                    DAL_ThongKe.Instance.Add(new ThongKe
                    {
                        MaTK = ++count,
                        MaDVUH = i,
                        MaHTUH = j,
                        TongSoLuongUH = TongSoluong,
                        SoDuUH = SoDu
                    });
                }
        }
        public void DeleteAll()
        {
            DAL_ThongKe.Instance.DeleteAll();
        }
    }
}
