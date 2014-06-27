﻿using QuanLyTaiSan.Libraries;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiSan.Entities
{
    [Table("LOAITHIETBIS")]
    public class LoaiThietBi : _EntityAbstract1<LoaiThietBi>
    {
        public LoaiThietBi() : base()
        {
            
        }
        #region Dinh nghia
        [Required]
        public String ten { get; set; }

        public Boolean loaichung { get; set; }
        /*
         * FK
         */
        public virtual ICollection<ThietBi> thietbis { get; set; }

        public int? parent_id { get; set; }
        [ForeignKey("parent_id")]
        public virtual LoaiThietBi parent { get; set; }

        public virtual ICollection<LoaiThietBi> childs { get; set; }
        #endregion
        #region Nghiep vu
        public List<LoaiThietBi> getAllParent()
        {
            try
            {
                List<LoaiThietBi> objs = db.Set<LoaiThietBi>().Where(c => c.parent_id == null).ToList();
                return objs;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return new List<LoaiThietBi>();
            }
            finally
            {

            }
        }
        #endregion
        #region Override method
        protected override void init()
        {
            base.init();
            this.childs = new List<LoaiThietBi>();
            this.thietbis = new List<ThietBi>();
        }
        public override int update()
        {
            //have to load all [Required] FK object first
            if (parent != null)
            {
                parent.trigger();
            }
            //...

            return base.update();
        }
        #endregion
    }
}
