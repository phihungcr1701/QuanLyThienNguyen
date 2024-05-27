using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_ChiTietUngHo
    {
        private static DAL_ChiTietUngHo instance;

        internal static DAL_ChiTietUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_ChiTietUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<ChiTietUngHoView> GetAllChiTietUngHo()
        {
            List<ChiTietUngHoView> list = new List<ChiTietUngHoView>();
            DataContext context = new DataContext();
            foreach (var item in context.ChiTietUngHoes)
            {
                list.Add(new ChiTietUngHoView(item.STT, item.MaDVUH, item.MaDUH, item.MaHD, item.MaHTUH, Convert.ToDouble(item.SoLuongUH), Convert.ToDouble(item.SoLuongNUH)));
            }
            return list;
        }
        public void UpdateActivity(ChiTietUngHo item)
        {
            DataContext context = new DataContext();
            var obj = context.ChiTietUngHoes.Find(item.STT);
            obj.MaDVUH = item.MaDVUH;
            obj.MaDUH = item.MaDUH;
            obj.MaHD = item.MaHD;
            obj.MaHTUH = item.MaHTUH;
            obj.SoLuongUH = item.SoLuongUH;
            obj.SoLuongNUH = item.SoLuongNUH;
            context.SaveChanges();
        }
        public void AddActivity(ChiTietUngHo item)
        {

            DataContext context = new DataContext();
            context.ChiTietUngHoes.Add(item);
            context.SaveChanges();
        }
        public void DeleteActivity(string maCTUH)
        {
            DataContext context = new DataContext();
            context.ChiTietUngHoes.Remove(context.ChiTietUngHoes.Find(maCTUH));
            context.SaveChanges();
        }
        public void Combine(ChiTietUngHo item)
        {
            DataContext context = new DataContext();
            foreach (var obj in context.ChiTietUngHoes.Where(p => p.MaDVUH == item.MaDVUH && p.MaDUH == item.MaDUH && p.MaHD == item.MaHD && p.MaHTUH == item.MaHTUH).Select(p => p))
            {
                obj.SoLuongUH += item.SoLuongUH;
                obj.SoLuongNUH += item.SoLuongNUH;
            }
            context.SaveChanges();
        }
    }
}