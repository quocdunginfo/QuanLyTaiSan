﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiSan.DataFilter
{
    public class ChiTietTBHienThi : FilterAbstract<ChiTietTBHienThi>
    {
        public int id { get; set; }
        public int idTB { get; set; }
        public String ten { get; set; }
        public String tinhtrang { get; set; }
        public int soluong { get; set; }
        public String tenloai { get; set; }

        #region Nghiệp vụ
        public static List<ChiTietTBHienThi> getAllByPhongId(int _phongid)
        {
            //OurDBContext db = new OurDBContext();
            List<ChiTietTBHienThi> re =
                (from c in db.CTTHIETBIS
                 where (c.phong.id == _phongid)
                 select new ChiTietTBHienThi
                 {
                     id = c.id,
                     idTB = c.thietbi.id,
                     ten = c.thietbi.ten,
                     tinhtrang = c.tinhtrang.value,
                     soluong = c.soluong,
                     tenloai = c.thietbi.loaithietbi.ten
                 }).ToList();
            return re;
        }
        #endregion
    }
}