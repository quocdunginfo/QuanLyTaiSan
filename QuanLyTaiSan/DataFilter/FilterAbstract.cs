﻿using QuanLyTaiSan.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiSan.DataFilter
{
    public abstract class FilterAbstract<T>
    {
        public FilterAbstract()
        {

        }
        protected static OurDBContext db
        {
            get
            {
                return DBInstance.DB;
            }
        }
    }
}
