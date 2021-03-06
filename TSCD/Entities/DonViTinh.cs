﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TSCD.Entities
{
    /// <summary>
    /// Đơn vị tính, dành cho loại tài sản
    /// </summary>
    [Table("DONVITINHS")]
    public class DonViTinh:_EntityAbstract1<DonViTinh>
    {
        public DonViTinh()
            : base()
        {

        }
        #region Dinh nghia
        /// <summary>
        /// CÁI, BỘ, CON, LÔ, BLOCK,...
        /// </summary>
        public String ten { get; set; }

        /*
         * KF
         */
        public virtual ICollection<LoaiTaiSan> loaitaisans { get; set; }
        #endregion

        #region override
        public static new String VNNAME
        {
            get
            {
                return "ĐƠN VỊ TÍNH";
            }
        }
        public override string niceName()
        {
            return VNNAME+": " + ten;
        }
        #endregion
    }
}
