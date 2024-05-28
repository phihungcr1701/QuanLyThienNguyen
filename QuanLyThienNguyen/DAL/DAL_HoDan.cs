using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_HoDan : DALBase<HoDan>
    {
        private static DAL_HoDan instance;
        public static DAL_HoDan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_HoDan();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DAL_HoDan() { }
        public List<DTOHoDan> GetAllHoDan()
        {
            var hd = from p in GetAll()
                     select new DTOHoDan
                     {
                         MaHD = p.MaHD,
                         HoTenChuHo = p.HoTenChuHo,
                         GioiTinh = p.GioiTinh,
                         CCCD = p.CCCD,
                         DiaChi = p.DiaChi,
                         SDT = p.SDT,
                         DienGiaDinh = p.DienGiaDinh
                     };
            return hd.ToList();
        }



        protected override object GetEntityKey(HoDan entity)
        {
            return entity.MaHD;
        }
    }
}
