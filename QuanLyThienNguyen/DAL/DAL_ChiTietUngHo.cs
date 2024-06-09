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
    internal class DAL_ChiTietUngHo : DALBase<ChiTietUngHo>
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
        public void AddCombine(ChiTietUngHo item)
        {
            using (var context = new DataContext())
            {
                var chiTietUngHo = context.ChiTietUngHos.Single(ct => ct.MaDVUH == item.MaDVUH 
                                                                         && ct.MaHD == item.MaHD
                                                                         && ct.MaHTUH == item.MaHTUH
                                                                         && ct.MaDUH == item.MaDUH);
                if (chiTietUngHo != null)
                {
                    chiTietUngHo.SoLuongUH = chiTietUngHo.SoLuongUH + item.SoLuongUH.Value;
                    chiTietUngHo.SoLuongNUH = chiTietUngHo.SoLuongNUH + item.SoLuongNUH.Value;
                    context.SaveChanges();
                    context.Entry(chiTietUngHo).Reload();
                }
            }
        }
        protected override object GetEntityKey(ChiTietUngHo entity)
        {
            return entity.MaCTUH;
        }
    }
}