﻿using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_HinhThucUngHo : DALBase<HinhThucUngHo>
    {
        private static DAL_HinhThucUngHo instance;
        public static DAL_HinhThucUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_HinhThucUngHo();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DAL_HinhThucUngHo() { }
        public List<DTOHinhThucUngHo> GetAllHinhThucUngHo()
        {
            var htuh = from p in GetAll()
                       select new DTOHinhThucUngHo
                       {
                           MaHTUH = p.MaHTUH,
                           TenHTUH = p.TenHTUH,
                           DonViTinh = p.DonViTinh,
                       };
            return htuh.ToList();
        }


        protected override object GetEntityKey(HinhThucUngHo entity)
        {
            return entity.MaHTUH;
        }
    }
}
