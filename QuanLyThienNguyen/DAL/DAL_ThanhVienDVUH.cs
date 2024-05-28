using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_ThanhVienDVUH : DALBase<ThanhVienDVUH>
    {
        private static DAL_ThanhVienDVUH instance;
        public static DAL_ThanhVienDVUH Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_ThanhVienDVUH();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DAL_ThanhVienDVUH() { }
        public List<DTOThanhVienDVUH> GetAllThanhVienDVUH()
        {
            var tvdvuh = from p in GetAll()
                         select new DTOThanhVienDVUH
                         {
                             MaDVUH = p.MaDVUH,
                             HoTen = p.HoTen,
                             GioiTinh = p.GioiTinh,
                             CCCD = p.CCCD,
                             DiaChi = p.DiaChi,
                             SDT = p.SDT,
                         };
            return tvdvuh.ToList();
        }

        protected override object GetEntityKey(ThanhVienDVUH entity)
        {
            return entity.MaDVUH;
        }
    }
}
