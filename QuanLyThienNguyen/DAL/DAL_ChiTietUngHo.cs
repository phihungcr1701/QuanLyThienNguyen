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
                var chiTietUngHo = context.ChiTietUngHos.SingleOrDefault(ct => ct.MaCTUH == item.MaCTUH);
                if (chiTietUngHo != null)
                {
                    chiTietUngHo.SoLuongUH += item.SoLuongUH.Value;
                    chiTietUngHo.SoLuongNUH += item.SoLuongNUH.Value;
                    context.SaveChanges();
                }
            }
        }
        protected override object GetEntityKey(ChiTietUngHo entity)
        {
            return entity.MaCTUH;
        }
    }
}