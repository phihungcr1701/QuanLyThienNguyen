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
        public List<DTO_ThanhVienDVUH> GetAllThanhVienDVUH()
        {
            return GetAll().Select(p => new DTO_ThanhVienDVUH
            {
                MaTVDVUH = p.MaTVDVUH,
                MaDVUH = p.MaDVUH,
                HoTen = p.HoTen,
                GioiTinh = p.GioiTinh,
                CCCD = p.CCCD,
                DiaChi = p.DiaChi,
                SDT = p.SDT,
            }).ToList();
        }
        protected override object GetEntityKey(ThanhVienDVUH entity)
        {
            return entity.MaTVDVUH;
        }
    }
}