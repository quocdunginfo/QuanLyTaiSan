﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiSan.Entities
{
    [Table("LOGHETHONGS")]
    public class LogHeThong : _EntityAbstract1<LogHeThong>
    {
        public LogHeThong():base()
        {

        }
        #region Dinh nghia
        [Required]
        public DateTime ngay { get; set; }

        //PARENT DIFINITION
        //vd: { "USER":quocdunginfo, "ACTION":DELETE_USER, "PARAM": nguoibixoa }
        //public String mota { get; set; }
        #endregion
    }
}
